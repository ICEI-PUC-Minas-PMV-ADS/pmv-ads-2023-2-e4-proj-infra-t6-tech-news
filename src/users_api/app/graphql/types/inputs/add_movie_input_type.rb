module Types
  module Inputs
    class AddMovieInputType < Types::BaseInputObject
      argument :name, String, required: true
      argument :genre, String, required: true
      argument :duration, Integer, required: true
    end
  end
end
