# BumbleBeeAdminCreator

About This Console Application

------------------------------

This console application serves as a utility for the **BumbleBee Foundation Client App**, specifically designed to simplify the process of creating SQL scripts to add new Admin users to the database. It is a companion tool for a larger standalone production application.

### Purpose

The primary purpose of this app is to generate an SQL `INSERT` statement for adding a new Admin user to the database. It ensures that the sensitive information, such as passwords, is securely hashed before being added to the SQL script. This reduces the risk of exposing plaintext passwords while creating database entries.

### Console Output Usage

When you run the console application, you will:

1\.  Provide details for the new Admin user, including email, plaintext password, first name, and last name.

2\.  The app will hash the password securely using SHA-256.

3\.  It will generate an SQL script with the provided details, which can then be copied and executed in the SSMS database management system.

Once the generated SQL script has been run in SSMS, the plaintext password and email address can be used to log into the client app as an admin
