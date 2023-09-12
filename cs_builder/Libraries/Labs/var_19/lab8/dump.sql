CREATE TABLE bank_account (
    account_id INT PRIMARY KEY,
    surname VARCHAR(50),
    name VARCHAR(50),
    middle_name VARCHAR(50),
    dob DATE,
    amount MONEY
);

INSERT INTO bank_account (account_id, surname, name, middle_name, dob, amount)
VALUES
  (1, 'Doe', 'John', 'A', '1980-01-01', 1000.00),
  (2, 'Smith', 'Jane', 'B', '1981-02-02', 2000.00),
  (3, 'Williams', 'Peter', 'C', '1982-03-03', 3000.00),
  (4, 'Brown', 'Mary', 'D', '1983-04-04', 4000.00),
  (5, 'Johnson', 'David', 'E', '1984-05-05', 5000.00),
  (6, 'Jones', 'Susan', 'F', '1985-06-06', 6000.00),
  (7, 'Green', 'Michael', 'G', '1986-07-07', 7000.00),
  (8, 'White', 'Lisa', 'H', '1987-08-08', 8000.00),
  (9, 'Black', 'Kevin', 'I', '1988-09-09', 9000.00),
  (10, 'Blue', 'Nancy', 'J', '1989-10-10', 10000.00);
