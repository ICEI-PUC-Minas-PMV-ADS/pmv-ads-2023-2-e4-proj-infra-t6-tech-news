module Types
  class MovieType < Types::BaseObject
    field :id, ID, null: false
    field :name, String, null: false
    field :genre, String, null: false
    field :duration, Integer, null: false
    field :sessions, [Types::SessionType], null: false
  end
end
