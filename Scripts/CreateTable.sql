DROP TABLE IF EXISTS todoitems;

CREATE TABLE todoitems (
    id INT PRIMARY KEY,
    title VARCHAR(255) NOT NULL,
    deadline DATE,
    important BIT,
    completed BIT DEFAULT 0
);