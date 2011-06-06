class LoginController < ApplicationController

  def signup
    @user = User.new(@params[:user])
    if request.post?
      if @user.save
        session[:user] = User.authenticate(@user.login, @user.password)
        flash[:message] = "Signup successful"
        redirect_to :action => "welcome"
      else
        flash[:warning] = "Signup unsuccessful"
      end
    end
  end

  def check
    if request.post?
      u = User.where(:username => params[:username]).first

      if u != nil
        session[:user] = u
        flash[:message] = "Login erfolgreich"
        redirect_to :controller => 'users', :action => 'index'
      else
        session[:user] = nil
        flash[:warning] = "Falsche Daten eingegeben!"
        redirect_to :action => "login"
      end
    end
  end

  def logout
    session[:user] = nil
    flash[:message] = 'Sie wurden erfolgreich ausgeloggt'
    redirect_to :action => 'login'
  end

  def forgot_password
    if request.post?
      u= User.find_by_email(params[:user][:email])
      if u and u.send_new_password
        flash[:message] = "A new password has been sent by email."
        redirect_to :action=>'login'
      else
        flash[:warning] = "Couldn't send password"
      end
    end
  end

  def welcome

  end

  def login

  end
end
