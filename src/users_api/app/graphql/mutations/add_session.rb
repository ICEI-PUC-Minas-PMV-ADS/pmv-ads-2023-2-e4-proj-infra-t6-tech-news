module Mutations
  class AddSession < BaseMutation
    field :session, Types::SessionType, null: false

    argument :session_time, GraphQL::Types::ISO8601DateTime, required: true
    argument :movie_id, ID, required: true
    argument :theatre_id, ID, required: true

    def resolve(session_time:, movie_id:, theatre_id:)
      session = Session.create!(
        session_time: session_time,
        movie_id: movie_id,
        theatre_id: theatre_id
      )

      { session: session }
    end
  end
end
