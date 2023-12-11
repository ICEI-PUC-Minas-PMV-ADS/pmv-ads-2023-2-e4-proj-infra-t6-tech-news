# Frozen_string_literal: true

# The NewsController controller is responsible for handling the News model.
# It is used to create, update, delete and show news.
# It also has a method to list all news.
#

class NewsController < ApplicationController
  before_action :authenticate_user!, except: %i[index show]
  before_action :set_news, only: %i[show update destroy like]
  respond_to :json

  # GET /news
  def index
    @news = News.all
    respond_with @news
  end

  # GET /news/1
  def show
    respond_with @news
  end

  # POST /news/1/like
  def like
    @news = News.find(params[:id])
    @news.increment!(:likes)
    respond_with @news
  end

  # POST /news
  def create
    @news_item = current_user.news.new(news_params)
    if @news_item.save
      respond_with @news_item
    else
      render json: @news_item.errors, status: :unprocessable_entity
    end
  end

  # PATCH/PUT /news/1
  def update
    if @news.update(news_params)
      respond_with @news
    else
      render json: @news.errors, status: :unprocessable_entity
    end
  end

  # DELETE /news/1
  def destroy
    if @news.user_id == current_user.id
      @news.destroy
      head :no_content
    else
      render json: { error: 'Not Authorized' }, status: :unauthorized
    end
  end

  private

  # Use callbacks to share common setup or constraints between actions.
  def set_news
    @news = News.find(params[:id])
  end

  # Only allow a list of trusted parameters through.
  def news_params
    params.require(:news).permit(:title, :link, :likes)
  end
end
