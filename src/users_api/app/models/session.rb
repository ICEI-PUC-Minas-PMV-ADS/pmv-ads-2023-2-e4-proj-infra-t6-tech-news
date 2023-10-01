class Session < ApplicationRecord
  belongs_to :movie
  belongs_to :theatre
  has_many :tickets
end
