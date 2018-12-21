CREATE TABLE ROUTE
(
id number PRIMARY KEY,
train_id int references TRAIN_SERVICE(train_id),
station_id number references STATION(id),
arrival_time number,
departure_time number
);
INSERT INTO ROUTE VALUES('1','1337','1','13.00','18.00');
INSERT INTO ROUTE VALUES('2','1338','2','15.00','20.00');
INSERT INTO ROUTE VALUES('3','1339','3','20.00','20.20');
INSERT INTO ROUTE VALUES('4','1340','4','21.00','22.00');
SELECT * FROM ROUTE;