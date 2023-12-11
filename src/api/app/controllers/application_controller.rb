require 'application_responder'

class ApplicationController < ActionController::API
  before_action :set_flash_only_for_html
  rescue_from ActiveRecord::RecordInvalid, with: :render_unprocessable_entity_response

  self.responder = ApplicationResponder
  respond_to :json

  private

  def render_unprocessable_entity_response(exception)
    render json: { errors: exception.record.errors.full_messages }, status: :unprocessable_entity
  end

  def set_flash_only_for_html
    request.format = :json unless request.format.html?
  end
end
