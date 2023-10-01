class CreateSeats < ActiveRecord::Migration[7.0]
  def change
    create_table :seats do |t|
      t.integer :number
      t.string :status
      t.references :theatre, null: false, foreign_key: true

      t.timestamps
    end
  end
end
