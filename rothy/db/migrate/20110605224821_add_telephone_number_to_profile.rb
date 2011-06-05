class AddTelephoneNumberToProfile < ActiveRecord::Migration
  def self.up
    add_column :profiles, :phone, :string
    add_column :profiles, :handy, :string
  end

  def self.down
    remove_column :profiles, :handy
    remove_column :profiles, :phone
  end
end
