class LoginController < ApplicationController
  def authenticationForm
    @users = User.all
  end
  
  def test
    
  end
end
