CREATE TABLE Reservations (
    reservation_id INT IDENTITY(1,1) PRIMARY KEY,

    user_id INT NOT NULL,
    book_id INT NOT NULL,

    reservation_date DATETIME DEFAULT GETDATE(),
    status VARCHAR(20) DEFAULT 'Pending',

    CONSTRAINT FK_Reservation_User
        FOREIGN KEY (user_id) REFERENCES Users(user_id),

    CONSTRAINT FK_Reservation_Book
        FOREIGN KEY (book_id) REFERENCES Books(book_id)
);