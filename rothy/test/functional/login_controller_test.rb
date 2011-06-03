require 'test_helper'

class LoginControllerTest < ActionController::TestCase
  test "should get authenticationForm" do
    get :authenticationForm
    assert_response :success
  end

end
