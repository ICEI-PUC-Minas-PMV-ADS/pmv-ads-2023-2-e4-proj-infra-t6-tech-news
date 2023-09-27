module Resolvers
  class User < Base
    type Types::UserType, null: false

    def resolve
      user = ::User.find_by(id: context[:current_user].id)
      raise GraphQL::ExecutionError, "Not authorized" unless UserPolicy.new(context[:current_user], user).show?

      user
    end
  end
end
