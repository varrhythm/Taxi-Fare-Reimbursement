CREATE TABLE POOL
(
E_ID int references LOGIN(E_ID),
train_id number references TRAIN_SERVICE(train_iD)
);
INSERT INTO POOL VALUES (1,1337);
insert into ARUSHIDB.POOL values (2,1337);
INSERT INTO POOL VALUES (3,1338);
INSERT INTO POOL VALUES (4,1338);
INSERT INTO POOL VALUES (5,1339);

SELECT * FROM POOL;
