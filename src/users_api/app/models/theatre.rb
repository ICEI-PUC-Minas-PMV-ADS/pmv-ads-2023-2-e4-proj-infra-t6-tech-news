class Theatre < ApplicationRecord
  has_many :seats
  has_many :sessions
end
