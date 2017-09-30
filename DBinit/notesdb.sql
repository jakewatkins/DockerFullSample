create database notes;

USE notes;

create table Note (
	NoteId int NOT NULL AUTO_INCREMENT ,
	Created datetime,
	NoteText VARCHAR(2000),
	PRIMARY KEY (NoteId)
);


