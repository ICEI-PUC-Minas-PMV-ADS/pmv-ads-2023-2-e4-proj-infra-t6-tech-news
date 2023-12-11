# frozen_string_literal: true

class Users::SessionsController < Devise::SessionsController
  include ActionController::MimeResponds
  skip_before_action :verify_signed_out_user, only: :destroy

  # GET /users/current
  def current
    if user_signed_in?
      render json: {
        id: current_user.id,
        email: current_user.email
      }
    else
      render json: { error: 'Not authenticated' }, status: :unauthorized
    end
  end

  # POST /users/sign_in
  def create
    reset_session
    self.resource = warden.authenticate(scope: :user)

    if resource
      sign_in(resource_name, resource)
      render json: {
        success: true,
        message: 'Successfully signed in',
        user: {
          id: resource.id,
          email: resource.email
        }
      }
    else
      render json: { success: false, message: 'Invalid email or password' }, status: :unauthorized
    end
  end

  # DELETE /users/sign_out
  def destroy
    (Devise.sign_out_all_scopes ? sign_out : sign_out(resource_name))
    respond_to_on_destroy
  end

  protected

  def set_flash_message!(key, kind, options = {}); end

  def require_no_authentication; end

  def respond_to_on_destroy
    respond_to do |format|
      format.all { head :no_content }
      format.any(*navigational_formats) { redirect_to after_sign_out_path_for(resource_name) }
    end
  end
end
