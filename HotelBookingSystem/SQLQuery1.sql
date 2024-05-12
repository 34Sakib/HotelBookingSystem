CREATE TABLE users(
id INT PRIMARY KEY IDENTITY(1,1),
username VARCHAR(MAX),
phone VARCHAR(MAX),
email VARCHAR(MAX),
password VARCHAR(MAX),
userType VARCHAR(MAX),
date_register Date
)

SELECT * FROM users

DROP TABLE users

CREATE TABLE hotels(
id INT PRIMARY KEY IDENTITY(1,1),
hotelname VARCHAR(MAX),
city VARCHAR(MAX),
cost VARCHAR(MAX),
package VARCHAR(MAX),
date_register Date,
image VARCHAR(MAX)
)

SELECT * FROM hotels
DELETE FROM hotels

ALTER TABLE hotels
ADD delete_date VARCHAR(MAX);


CREATE TABLE bookings (
    booking_id INT PRIMARY KEY IDENTITY(1,1),
    user_id INT,
    hotel_id INT,
    check_in_date DATE
)



SELECT * FROM bookings
DELETE FROM bookings

CREATE TABLE payments (
    payment_id INT PRIMARY KEY IDENTITY(1,1),
    user_id INT,
    booking_id INT,
    payment_method VARCHAR(MAX),
    payment_amount INT,
    payment_date DATE
)

SELECT * FROM payments
DELETE FROM payments
DROP TABLE payments


CREATE TABLE reviews (
    review_id INT PRIMARY KEY IDENTITY(1,1),
    user_id INT,
    hotel_id INT,
    rating INT,
    comment VARCHAR(MAX),
    review_date DATE
)

SELECT * FROM reviews
DROP TABLE reviews