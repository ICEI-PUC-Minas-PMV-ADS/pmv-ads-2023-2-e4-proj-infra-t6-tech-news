module Mutations
  class AddSeat < BaseMutation
    field :seat, Types::SeatType, null: false

    argument :number, Integer, required: true
    argument :status, String, required: true
    argument :theatre_id, ID, required: true

    def resolve(number:, status:, theatre_id:)
      seat = Seat.create!(
        number: number,
        status: status,
        theatre_id: theatre_id
      )

      { seat: seat }
    end
  end
end
