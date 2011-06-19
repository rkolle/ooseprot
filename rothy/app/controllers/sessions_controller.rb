class SessionsController < ApplicationController
  def new
  end

  def create
    if user = User.authenticate(params[:username], params[:password])
      session[:user_id] = user.id
      redirect_to admin_url
    else
      redirect_to login_url, :alert => "Username und/oder Passwort inkorrekt"
    end
  end

  def destroy
    session[:user_id] = nil
    redirect_to login_url, :notice => "Ausgeloggt"
  end

end
