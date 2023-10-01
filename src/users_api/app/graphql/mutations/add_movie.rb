module Mutations
  class AddMovie < BaseMutation
    argument :input, Types::Inputs::AddMovieInputType, required: true

    field :movie, Types::MovieType, null: false

    def resolve(input:)
      movie = Movie.create!(input.to_h)

      { movie: movie }
    end
  end
end
