CREATE TABLE Users (
    user_id INT PRIMARY KEY,
    name VARCHAR(100) NOT NULL,
    gender CHAR(10) NOT NULL,
    nic VARCHAR(15) NOT NULL UNIQUE,
    address VARCHAR(255) NOT NULL,
    type VARCHAR(10) NOT NULL
);

