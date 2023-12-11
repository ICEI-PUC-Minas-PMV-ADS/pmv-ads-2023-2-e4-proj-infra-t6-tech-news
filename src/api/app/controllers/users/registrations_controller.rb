# frozen_string_literal: true

class Users::RegistrationsController < Devise::RegistrationsController
  # POST /users
  def create
    super do |resource|
      if resource.errors.any?
        render json: { errors: resource.errors.full_messages }, status: :unprocessable_entity and return
      end
    end
  end

  protected

  def set_flash_message!(key, kind, options = {}); end

  def require_no_authentication; end
end
