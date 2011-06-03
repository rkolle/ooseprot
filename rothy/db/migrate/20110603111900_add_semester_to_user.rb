class AddSemesterToUser < ActiveRecord::Migration
  def self.up
    add_column :users, :semester, :number
  end

  def self.down
    remove_column :users, :semester
  end
end
