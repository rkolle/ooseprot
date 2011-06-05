class AddAddressToProfile < ActiveRecord::Migration
  def self.up
    add_column :profiles, :address, :string
  end

  def self.down
    remove_column :profiles, :address
  end
end
