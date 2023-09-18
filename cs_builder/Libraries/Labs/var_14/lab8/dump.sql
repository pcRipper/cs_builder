CREATE TABLE passenger(
	id INT PRIMARY KEY,
	name VARCHAR(125),
	from_place VARCHAR(50),
	to_place VARCHAR(50),
	date_out TIMESTAMP,
	carriage SMALLINT,
	seat VARCHAR(3),
	luggage BOOLEAN
);

INSERT INTO passenger (id, name, from_place, to_place, date_out, carriage, seat, luggage) VALUES
(1, 'John Doe', 'New York', 'Los Angeles', '2023-09-16 10:00:00', 1, '1A', TRUE),
(2, 'Jane Doe', 'Los Angeles', 'New York', '2023-09-17 12:00:00', 2, '2B', FALSE),
(3, 'Peter Smith', 'Chicago', 'Miami', '2023-09-18 14:00:00', 3, '3C', TRUE),
(4, 'Susan Jones', 'Miami', 'Chicago', '2023-09-19 16:00:00', 4, '4D', FALSE),
(5, 'David Brown', 'Denver', 'Seattle', '2023-09-20 18:00:00', 5, '5E', TRUE),
(6, 'Elizabeth Green', 'Seattle', 'Denver', '2023-09-21 20:00:00', 6, '6F', FALSE),
(7, 'Michael Johnson', 'San Francisco', 'New York', '2023-09-22 22:00:00', 7, '7G', TRUE),
(8, 'Sarah Williams', 'New York', 'San Francisco', '2023-09-23 24:00:00', 8, '8H', FALSE),
(9, 'William Brown', 'Boston', 'Los Angeles', '2023-09-24 02:00:00', 9, '9I', TRUE),
(10, 'Jennifer Smith', 'Los Angeles', 'Boston', '2023-09-25 04:00:00', 10, '10J', FALSE);
