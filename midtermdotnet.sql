-- Create the database
CREATE DATABASE midtermdotnet;
GO
-- Use the database
USE midtermdotnet;
GO
-- Table structure for table 'certificates'
CREATE TABLE certificates (
  id VARCHAR(255) PRIMARY KEY,
  title VARCHAR(255),
  description VARCHAR(255),
  issue_date DATE,
  expiry_date DATE,
  organization_name VARCHAR(255),
  isValid BIT,
  sid VARCHAR(255),
  createdAt DATETIME DEFAULT CURRENT_TIMESTAMP,
  updatedAt DATETIME
);

-- Table structure for table 'loginhistory'
CREATE TABLE loginhistory (
  id INT IDENTITY(0,1) PRIMARY KEY,
  email VARCHAR(255),
  history DATETIME DEFAULT CURRENT_TIMESTAMP
);

-- Table structure for table 'students'
CREATE TABLE students (
  id VARCHAR(255) PRIMARY KEY,
  name VARCHAR(255),
  dob DATE,
  gender VARCHAR(255),
  eduType VARCHAR(255),
  className VARCHAR(255),
  department VARCHAR(255),
  major VARCHAR(255),
  courseYear VARCHAR(255),
  createdAt DATETIME DEFAULT CURRENT_TIMESTAMP,
  updatedAt DATETIME
);

-- Table structure for table 'users'
CREATE TABLE users (
  email VARCHAR(255) PRIMARY KEY,
  password VARCHAR(255),
  name VARCHAR(255),
  age INT,
  dob DATE,
  phone VARCHAR(255),
  status VARCHAR(255) DEFAULT 'Normal',
  role VARCHAR(255) DEFAULT 'Employee',
  createdAt DATETIME DEFAULT CURRENT_TIMESTAMP,
  updatedAt DATETIME
);

-- Insert data into 'users' table
INSERT INTO users (email, password, name, age, dob, phone, status, role, createdAt, updatedAt)
VALUES ('admin@gmail.com', '$2a$10$OLpsmv5Jpd6PdJfkGFOMSOPICFC0N/xXez4FzxNKLk243DKKhmXqa', 'Admin', 20, '2003-12-05', '1234567890', 'Normal', 'Admin', GETDATE(), NULL);
-- password: 123123123

-- Add foreign key constraints
ALTER TABLE certificates
ADD CONSTRAINT certificates_fk_sid
FOREIGN KEY (sid)
REFERENCES students (id);

ALTER TABLE loginhistory
ADD CONSTRAINT loginhistory_fk_email
FOREIGN KEY (email)
REFERENCES users (email);

GO
CREATE TABLE Department (
	departId VARCHAR(255) PRIMARY KEY,
	departName VARCHAR(255),
	departmentCode VARCHAR(255)
);

GO
CREATE TABLE Class (
	classId VARCHAR(255) PRIMARY KEY,
	numOfStudents int,
	department VARCHAR(255),
	eduType VARCHAR(255),
	FOREIGN KEY (department)
	REFERENCES Department (departId)
);
GO
CREATE TABLE Major (
	majorId VARCHAR(255) PRIMARY KEY,
	majorName VARCHAR(255),
	department VARCHAR(255),
	FOREIGN KEY (department)
	REFERENCES Department (departId)
);

GO
ALTER TABLE students
ADD CONSTRAINT students_fk_department
FOREIGN KEY (department)
REFERENCES Department (departId);
GO
ALTER TABLE students
ADD CONSTRAINT students_fk_major
FOREIGN KEY (major)
REFERENCES Major (majorId);

GO

INSERT INTO Department (departId, departName, departmentCode)
VALUES ('IT', 'Information Techonology', '5'), ('F&B', 'Finace and Banking', '3'), ('E&EE', 'Electrical & Electronic Enigeering', '2'); 

GO

INSERT INTO Major (majorId, majorName, department)
VALUES
    ('CS', 'Computer Science', 'IT'),
    ('SE', 'Software Engineering', 'IT'),
	('NE', 'Networking Engineering', 'IT'),
	('MKT', 'Marketing', 'F&B')
GO

INSERT INTO Class (classId, numOfStudents, department)
VALUES
    ('C1', 30, 'IT'),
    ('C2', 25, 'F&B'),
	('C3', 30, 'E&EE')

GO
