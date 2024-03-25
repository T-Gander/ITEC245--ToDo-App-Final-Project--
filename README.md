1. In order to setup this project you will need a fresh SQL database hosted somewhere and .Net 8 installed.
2. Upon loading the project, navigate to appsettings.json and update the connection string to your database details.
3. After configuring your connection string correctly run the following two commands to setup the database schema: update-database -Context ApplicationDbContext update-database -Context ToDoAppDbContext
4. The app should launch correctly. You will need to register an account to use the application functionality. Only Admins are able to create tasks. If a user requires admin privelages, the admin password on registration is "superuser".
5. For multiple users, ensure the connection string in appsettings.json points to the computer with the database hosted.
6. Enjoy!
