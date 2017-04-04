# SqlDepedencyAndSignalR
Using SqlDependency adn SignalR for a Dashboard

This spike uses Sql Dependency to monitor any changes to the database. If changes are detected, sql dependency will 
inform signalR which will update the web with any changes that occurred to the database.

Getting Started: 
In order to get started with the project the following needs to be setup:

1. On the front-end project under the Repository folder, run the script file on database.sql to generate the database
2. Run the 2nd script enablesqldependency.sql to authorize and enable broker on the database which will be monitored
3. Update the connection string on web config file.

