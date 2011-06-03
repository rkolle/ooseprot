# This file should contain all the record creation needed to seed the database with its default values.
# The data can then be loaded with the rake db:seed (or created alongside the db with db:setup).
#
# Examples:
#
#   cities = City.create([{ :name => 'Chicago' }, { :name => 'Copenhagen' }])
#   Mayor.create(:name => 'Daley', :city => cities.first)

User.delete_all

User.create(:vorname => 'Robert', :nachname => 'Kolle', :username => 'kkolle2s', :email => 'robert.kolle@smail.inf.h-brs.de', :semester => 4, :avatar => 'default.jpg')
User.create(:vorname => 'Philipp', :nachname => 'Thomas', :username => 'pthoma2s', :email => 'philipp.thomas@smail.inf.h-brs.de', :semester => 4, :avatar => 'default.jpg')