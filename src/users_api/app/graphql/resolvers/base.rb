# frozen_string_literal: true
module Resolvers
  class Base < GraphQL::Schema::Resolver
    protected

    def current_user
      context[:current_user]
    end
  end
end
