module Types
  class SessionType < Types::BaseObject
    field :id, ID, null: false
    field :session_time, GraphQL::Types::ISO8601DateTime, null: false
    field :movie, Types::MovieType, null: false
    field :theatre, Types::TheatreType, null: false
    field :tickets, [Types::TicketType], null: false
  end
end
