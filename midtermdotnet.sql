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
  imgPath VARCHAR(255),
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
  eduType INT,
  classId VARCHAR(255),
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
  avatarPath VARCHAR(255),
  createdAt DATETIME DEFAULT CURRENT_TIMESTAMP,
  updatedAt DATETIME
);

-- Insert data into 'users' table
INSERT INTO users (email, password, name, age, dob, phone, status, role, avatarPath, createdAt, updatedAt)
VALUES ('admin@gmail.com', '$2a$10$JRgRBsQYUrgocwjkVISZ4eTS6eryy9XEM5hhQ2dF9GRW6XBvhDCrC', 'Admin', 20, '2003-12-05', '1234567890', NULL, 'Admin', NULL, GETDATE(), NULL);

-- Add foreign key constraints
ALTER TABLE certificates
ADD CONSTRAINT certificates_fk_sid
FOREIGN KEY (sid)
REFERENCES students (id);

ALTER TABLE loginhistory
ADD CONSTRAINT loginhistory_fk_email
FOREIGN KEY (email)
REFERENCES users (email);
