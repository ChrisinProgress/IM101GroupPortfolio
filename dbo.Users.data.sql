CREATE TABLE Users (
    UserID INT PRIMARY KEY IDENTITY,
    Username VARCHAR(50) NOT NULL UNIQUE,
    UserPassword VARCHAR(255) NOT NULL
);

-- Test accounts
INSERT INTO Users (Username, UserPassword) VALUES ('Cruz', '1234');
INSERT INTO Users (Username, UserPassword) VALUES ('Lim', '0987');
INSERT INTO Users (Username, UserPassword) VALUES ('Vicente','1234');
INSERT INTO Users (Username, UserPassword) VALUES ('Ranola','pogi');



USE DatabaseGroupOne;
SELECT * FROM Users;


DROP TABLE Users;