module Types
  class TheatreType < Types::BaseObject
    field :id, ID, null: false
    field :name, String, null: false
    field :location, String, null: false
    field :seats, [Types::SeatType], null: false
    field :sessions, [Types::SessionType], null: false
  end
end
