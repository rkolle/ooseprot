class CreateUsers < ActiveRecord::Migration
  def self.up
    create_table :users do |t|
      t.string :vorname
      t.string :nachname
      t.string :email
      t.string :username
      t.timestamps
    end
  end

  def self.down
    drop_table :users
  end
end
