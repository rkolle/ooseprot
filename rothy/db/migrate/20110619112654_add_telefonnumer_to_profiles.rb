class AddTelefonnumerToProfiles < ActiveRecord::Migration
  def self.up
    add_column :profiles, :telefonummer, :string
  end

  def self.down
    remove_column :profiles, :telefonummer
  end
end
