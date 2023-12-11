class News < ApplicationRecord
  belongs_to :user
  validates :likes, numericality: { greater_than_or_equal_to: 0 }
  before_validation :set_default_likes, on: :create

  def as_json(options = {})
    super(options.merge(include: { user: { only: %i[id email] } }))
  end

  private

  def set_default_likes
    self.likes ||= 0
  end
end
