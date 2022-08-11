Use NoteKeeper;


select * from Note;


-- Note Table
create Table Note(
	Id int Identity(1,1) not null primary key,
	GroupId int,
	Title varchar(100),
	Description text,
	Tag varchar(100)
);

INSERT INTO Note Values ('0','New Title','This is the example desc.','TEST');

SELECT * from Note;

-- Group Table
create Table NotesGroup(
	GroupId int Identity(1,1) not null primary key,
	Title varchar(100),
	Description text,
	Tag varchar(100)
);

INSERT INTO NotesGroup Values ('New Group','This is the example Group desc.','TEST');

select * from NotesGroup;