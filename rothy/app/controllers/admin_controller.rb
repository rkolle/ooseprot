class AdminController < ApplicationController
  skip_before_filter :authorize
  
  def index
    @amount_of_users = session.count
  end

end
