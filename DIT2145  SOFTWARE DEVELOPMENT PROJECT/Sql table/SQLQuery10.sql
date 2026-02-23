CREATE TABLE Loans (
    loan_id INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    user_id INT NOT NULL,             -- Must match Users.user_id type
    copy_id INT NOT NULL,             -- Must match Copies.copy_id type
    loan_date DATE NOT NULL,          -- Date when loan starts
    return_date DATE NULL,            -- Date when book is returned (nullable)
    status VARCHAR(20) NOT NULL,      -- e.g., 'issued', 'returned', 'overdue'
    FOREIGN KEY (user_id) REFERENCES Users(user_id),
    FOREIGN KEY (copy_id) REFERENCES Copies(copy_id)
);
