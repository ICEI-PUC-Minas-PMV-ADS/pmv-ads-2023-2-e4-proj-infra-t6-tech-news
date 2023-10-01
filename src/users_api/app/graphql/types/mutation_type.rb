module Types
  class MutationType < Types::BaseObject
    field :create_user, mutation: Mutations::CreateUser
    field :purchase_ticket, mutation: Mutations::PurchaseTicket
  end
end
