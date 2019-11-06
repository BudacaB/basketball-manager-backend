1. tech

- MongoDB
- .net core - rest api https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-web-api?view=aspnetcore-3.0&tabs=visual-studio
- frontend - angular

2. app - defined user stories:

- as a user, i can use the app to manage my team and see a dashboard of various actions to do with the team
- as a team manager (TM) I can create new players with player attributes, list all players in a team
- as TM, I can compare players one with another and see a stats dashboard "versus" style, with player attributes below their photos
- as TM, I can see and edit the player salaries, thus affecting their morale, performance etc
- as TM, I can "plan" (schedule) or cancel matches with other teams in a calendar
- as TM, I can simulate "passage of time" with a function in game, so that the match is played and results are shown
- as TM, I can manage travel schedules, travel costs, destinations, etc for the team
- as TM, I can hire and fire teamplayers
- as TM, I can see statistics with overview of player results and attributes changing over time

---

- DB - Redis ; Oracle ; MongoDB ; Orient
- Pivotal Cloud Foundry for microservice containerziation

How to think up an app backend <-> frontend
Check Cloud Foundry ; rest api ; microservices

Rest API

- https://www.youtube.com/watch?v=HeXQ98sogs8&list=PLWPirh4EWFpGRdVZcQCzeTXFBNSTDAdQX
- https://www.youtube.com/watch?v=7YcW25PHnAA

microservices - services that run constantly - run in containers

FE calls 1 microservice called BFF - gateway to other private services

---

1. Install Bootstrap latest in FE
2. BE - this up to 'Add model Class' -> https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-web-api?view=aspnetcore-3.0&tabs=visual-studio
3. Docker Hub - https://hub.docker.com/_/mongo - run a local MongoDB
   - https://medium.com/@kritner/getting-started-on-mongodb-with-net-core-89022de0ca29
     - MongoDB.Driver NuGet Package
     - https://docs.mongodb.com/ecosystem/drivers/csharp/#installation

FE up and running on port 4200 locally

MongoDB running locally on wtv port

.NetCore Api running -> install NuGet for MongoDB

4. Player Model class

- https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/adding-model?view=aspnetcore-3.0&tabs=visual-studio

- https://www.espn.com/nba/team/roster/_/name/lal/los-angeles-lakers

- Also stamina, speed, strength, injured (boolean)

5. Make new controller in BE - TeamController - write manually (google how to create .Net Api controller / use weatherforecast)

- /ListTeamPlayers - to call - return empty array
- Make a method ListTeamPlayers - get array of players

6. Make NodeJS console app -> called with 'node myApp.js'

- populateDB.js
- insert script for each player
- database driver https://mongodb.github.io/node-mongodb-native/
- display outcome with Promise - 'players inserted successfully! player count = X'

7. Create container with my script - create docker file in Alpine linux

- docker file - pull alpine / copy all project files for populateDB.js script from local path inside to image / run script
- check docs
- both mongo and script containers run manually and work

8. Check Docker Compose docs - how to start 2 services - MongoDB and the populateDB.js script

---

Extra read:

- https://expressjs.com/en/guide/writing-middleware.html
- https://docs.microsoft.com/en-us/aspnet/core/fundamentals/startup?view=aspnetcore-3.0
