require 'digest/sha2'

class User < ActiveRecord::Base
    validates :vorname, :nachname, :username, :presence => true
    validates :email, :uniqueness => true, :presence => true
    validates :username, :uniqueness => true


    validates :password, :confirmation => true
    attr_accessor :password_confirmation
    attr_reader :password
    validate :password_must_be_present

    default_scope :order => 'nachname'
    
    has_many :preferences, :dependent => :destroy
    has_one :profile
    
    def User.authenticate(username, password)
      if user = User.find_by_username(username)
        if user.hashed_password == encrypt_password(password, user.salt)
          user
        end
      end
    end
    
    def User.encrypt_password(password, salt)
      Digest::SHA2.hexdigest(password + "wibble" + salt)
    end
    
    def password=(password)
      @password = password
      
      if password.present?
        generate_salt
        self.hashed_password = self.class.encrypt_password(password, salt)
      end
    end
    
    private
    
    def password_must_be_present
      errors.add(:password, "Missing password") unless hashed_password.present?
    end
    
    def generate_salt
      self.salt = self.object_id.to_s + rand.to_s
    end
end
