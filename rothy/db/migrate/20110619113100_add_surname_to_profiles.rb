class AddSurnameToProfiles < ActiveRecord::Migration
  def self.up
    add_column :profiles, :surname, :string
  end

  def self.down
    remove_column :profiles, :surname
  end
end
