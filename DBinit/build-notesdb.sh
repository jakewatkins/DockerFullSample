#!/bin/sh
# build the notes database
mysqladmin -u root -p$MYSQL_ROOT_PASSWORD -h$DBHOST ping --wait 

# load the DDL
mysql -u root "-p$MYSQL_ROOT_PASSWORD" -h$DBHOST < /dbbuild/notesdb.sql

# load some sample data
mysql -u root "-p$MYSQL_ROOT_PASSWORD" -h$DBHOST < /dbbuild/notes-sample.sql
