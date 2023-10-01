module Types
  class SeatType < Types::BaseObject
    field :id, ID, null: false
    field :number, Integer, null: false
    field :status, String, null: false
    field :theatre, Types::TheatreType, null: false
    field :ticket, Types::TicketType, null: true
  end
end
