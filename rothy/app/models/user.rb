class User < ActiveRecord::Base
    validates :vorname, :nachname, :username, :presence => true
    validates :email, :uniqueness => true, :presence => true

    default_scope :order => 'nachname'
    
    has_many :preferences, :dependent => :destroy
    has_one :profile
end
