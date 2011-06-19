# This file should contain all the record creation needed to seed the database with its default values.
# The data can then be loaded with the rake db:seed (or created alongside the db with db:setup).
#
# Examples:
#
#   cities = City.create([{ :name => 'Chicago' }, { :name => 'Copenhagen' }])
#   Mayor.create(:name => 'Daley', :city => cities.first)

User.delete_all

User.create(
    :vorname => 'Robert',
    :nachname => 'Kolle',
    :username => 'kkolle2s',
    :email => 'robert.kolle@smail.inf.h-brs.de',
    :password => 'test',
    :salt => '21905033200.831118925565288',
    :hashed_password = '5dff165b0b8b1547a3838628f4ce5b27cf6786fbd0bd74e422339951109e6b38'
)

User.create(
    :vorname => 'Philipp',
    :nachname => 'Thomas',
    :username => 'pthoma2s',
    :email => 'philipp.thomas@smail.inf.h-brs.de'
    :password => 'test',
    :salt => '21905033200.831118925565288',
    :hashed_password = '5dff165b0b8b1547a3838628f4ce5b27cf6786fbd0bd74e422339951109e6b38'
)