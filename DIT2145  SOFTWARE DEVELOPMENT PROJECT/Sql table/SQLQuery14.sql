CREATE TABLE Loans (
    loan_id INT IDENTITY PRIMARY KEY,
    user_id INT NOT NULL,
    copy_id INT NOT NULL,
    loan_date DATE NOT NULL,
    return_date DATE,
    status VARCHAR(10) NOT NULL,
    FOREIGN KEY (user_id) REFERENCES Users(user_id),
    FOREIGN KEY (copy_id) REFERENCES Copies(copy_id)
);
