class Usergroup < ActiveRecord::Base
  has_many :users

  validates_format_of :avatar,
                      :with => %r{\.(gif|jpg|png)$}i,
                      :message => 'Kann entweder ein JPG, GIF oder PNG'
end
