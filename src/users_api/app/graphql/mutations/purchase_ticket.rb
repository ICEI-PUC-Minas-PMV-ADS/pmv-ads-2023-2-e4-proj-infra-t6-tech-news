module Mutations
  class PurchaseTicket < BaseMutation
    field :ticket, Types::TicketType, null: false

    argument :user_id, ID, required: true
    argument :session_id, ID, required: true
    argument :seat_id, ID, required: true
    argument :price, Float, required: true

    def resolve(user_id:, session_id:, seat_id:, price:)
      user = User.find(user_id)
      session = Session.find(session_id)
      seat = Seat.find(seat_id)

      # Check if the seat is already occupied
      if seat.status == :occupied
        raise GraphQL::ExecutionError, "Este assento já está ocupado."
      end

      # Business logic to create a new ticket
      ticket = Ticket.create!(
        user: user,
        session: session,
        seat: seat,
        price: price
      )

      # Mark the seat as occupied
      seat.update!(status: :occupied)

      # Return the ticket information
      {
        ticket: ticket
      }
    end
  end
end
