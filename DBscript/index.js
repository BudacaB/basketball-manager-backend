const MongoClient = require("mongodb").MongoClient;
const assert = require("assert");
let players = require("./players");
let teams = require("./teams");
let insertDocuments = require("./insertDocs");
let makeDocMongoCompatible = require("./makeDocMongoCompatible");

const url = "mongodb://localhost:28017";

const dbName = "bball";
const teamsCollection = "teams";
const playersCollection = "players";

teams.forEach(makeDocMongoCompatible);
players.forEach(makeDocMongoCompatible);

const client = new MongoClient(url);

client.connect(function(err) {
  assert.equal(null, err);
  console.log("Connected successfully to server");

  const db = client.db(dbName);

  insertDocuments(db, teamsCollection, teams).then(collectionCount =>
    console.log("Teams count = " + collectionCount)
  );
  insertDocuments(db, playersCollection, players).then(collectionCount =>
    console.log("Players count = " + collectionCount)
  );

  client.close();
});
