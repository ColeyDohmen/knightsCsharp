  
USE knightscoley;

CREATE TABLE castles
(
    id INT AUTO_INCREMENT,
    name VARCHAR(255) NOT NULL UNIQUE,
    description VARCHAR(255),
    

    PRIMARY KEY (id)

);

INSERT INTO castles
(name, description)
VALUES
("castle", "it's gray")

Get All of a collection
SELECT * FROM castles;