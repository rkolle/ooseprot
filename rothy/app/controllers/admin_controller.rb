class AdminController < ApplicationController
  def index
    @amount_of_users = session.count
  end

end
