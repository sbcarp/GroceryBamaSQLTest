CREATE DEFINER=`grocerybama.admin`@`localhost` PROCEDURE `Login`(in p_username varchar(50), in p_password varchar(50))
BEGIN
    DECLARE USERCOUNT INT;
 
    SELECT COUNT(username) INTO USERCOUNT
    FROM userexample 
    WHERE username=p_username AND password=p_password;
 
    IF (USERCOUNT != 1) THEN 
        SIGNAL SQLSTATE '45000'
            SET MESSAGE_TEXT = 'User not found', MYSQL_ERRNO = 1002;
	END IF;
	
    SELECT fname, lname, username, role
    FROM userexample 
    WHERE username=p_username AND password=p_password;
END