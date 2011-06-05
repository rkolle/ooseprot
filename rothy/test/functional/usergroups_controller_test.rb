require 'test_helper'

class UsergroupsControllerTest < ActionController::TestCase
  setup do
    @usergroup = usergroups(:one)
  end

  test "should get index" do
    get :index
    assert_response :success
    assert_not_nil assigns(:usergroups)
  end

  test "should get new" do
    get :new
    assert_response :success
  end

  test "should create usergroup" do
    assert_difference('Usergroup.count') do
      post :create, :usergroup => @usergroup.attributes
    end

    assert_redirected_to usergroup_path(assigns(:usergroup))
  end

  test "should show usergroup" do
    get :show, :id => @usergroup.to_param
    assert_response :success
  end

  test "should get edit" do
    get :edit, :id => @usergroup.to_param
    assert_response :success
  end

  test "should update usergroup" do
    put :update, :id => @usergroup.to_param, :usergroup => @usergroup.attributes
    assert_redirected_to usergroup_path(assigns(:usergroup))
  end

  test "should destroy usergroup" do
    assert_difference('Usergroup.count', -1) do
      delete :destroy, :id => @usergroup.to_param
    end

    assert_redirected_to usergroups_path
  end
end
