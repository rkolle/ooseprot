class User < ActiveRecord::Base
    validates :vorname, :nachname, :username, :presence => true
    validates :semester, :numericality => {:greater_than_or_equal_to => 1}
    validates :email, :uniqueness => true, :presence => true

    validates_format_of :avatar,
    :with => %r{\.(gif|jpg|png)$}i,
    :message => 'Kann entweder ein JPG, GIF oder PNG'
end
