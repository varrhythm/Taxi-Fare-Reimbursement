CREATE TABLE STATION
(
id number PRIMARY KEY,
s_name varchar(100),
city varchar(20)
);
INSERT INTO STATION VALUES('1','STATION 1','CITY 1');
INSERT INTO STATION VALUES('2','STATION 2','CITY 2');
INSERT INTO STATION VALUES('3','STATION 3','CITY 3');
INSERT INTO STATION VALUES('4','STATION 4','CITY 4');
SELECT * FROM STATION;