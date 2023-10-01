class Seat < ApplicationRecord
  belongs_to :theatre
  has_one :ticket
end
