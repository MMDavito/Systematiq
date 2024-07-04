# Changing connection-strings:
If your connectionstrings does not fully match mine, then you will need to change them in:<br> 
./CommonConfigs/appsettings.json<br>


# On change of **/Entities:
Navigate into Entities and execute following command in terminal:<br>
dotnet ef migrations add InitialMigration

Followed by:<br>
dotnet ef database update

# To run the application:
1. Install all nuget packages.
2. Open a terminal and navigate into Entities and execute following command in terminal:<br>dotnet ef database update
3. Open visual studio and start the application using this button:<br> ![Execute/run-button](./Images/run_button.png)