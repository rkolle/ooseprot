class CreatePreferences < ActiveRecord::Migration
  def self.up
    create_table :preferences do |t|

      t.timestamps
    end
  end

  def self.down
    drop_table :preferences
  end
end
