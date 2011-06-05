class AddImToProfile < ActiveRecord::Migration
  def self.up
    add_column :profiles, :icq, :string
  end

  def self.down
    remove_column :profiles, :icq
  end
end
