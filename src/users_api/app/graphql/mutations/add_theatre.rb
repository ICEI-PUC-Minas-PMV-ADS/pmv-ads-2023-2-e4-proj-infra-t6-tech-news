module Mutations
  class AddTheatre < BaseMutation
    field :theatre, Types::TheatreType, null: false

    argument :name, String, required: true
    argument :location, String, required: true

    def resolve(name:, location:)
      theatre = Theatre.create!(
        name: name,
        location: location
      )

      { theatre: theatre }
    end
  end
end
