module Types
  class MutationType < Types::BaseObject
    field :create_user, mutation: Mutations::CreateUser
    field :purchase_ticket, mutation: Mutations::PurchaseTicket

    field :add_movie, mutation: Mutations::AddMovie
    field :add_session, mutation: Mutations::AddSession
    field :add_seat, mutation: Mutations::AddSeat
    field :add_theatre, mutation: Mutations::AddTheatre
  end
end
