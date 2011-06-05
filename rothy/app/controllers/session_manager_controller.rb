class SessionManagerController < ApplicationController
  def get_user
    @user = User.find(session[:user_id])
  end
  
  def get_usergroup
    @usergroups = find_by_user(get_user())
  end
  
  def get_profile
    @profile = find_by_user(get_user())
  end
  
  def get_preferences
    @preferences = find_by_user(get_user())
  end
end
