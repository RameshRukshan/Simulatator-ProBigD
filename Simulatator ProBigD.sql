create database SimulatatorData;
use SimulatatorData;
create table rounds(rNumber int identity (1,1) primary key, cmpInDoor char(1), 
		selectedDoor char(1), answer bit, firstSelection char(1), 
		swichStatus bit, secondSelection char(1));

create table GameRounds(rNumber int identity (1,1) primary key,
			playDateTime date default getdate(), winingState bit, winingPresentage float);

select * from rounds;
select * from GameRounds;

insert into rounds (cmpInDoor) values ('A');