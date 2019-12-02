const MongoClient = require("mongodb").MongoClient;
const assert = require("assert");
let players = require("./players");
let teams = require("./teams");
let insertDocuments = require("./insertDocs");
let addIDandPic = require("./addIDandPic");

const url = "mongodb://localhost:28017";

const dbName = "bball";
const teamsCollection = "teams";
const playersCollection = "players";

teams.forEach(addIDandPic);
players.forEach(addIDandPic);

const client = new MongoClient(url);

client.connect(function(err) {
  assert.equal(null, err);
  console.log("Connected successfully to server");

  //creates the db
  const db = client.db(dbName);

  insertDocuments(db, teamsCollection, teams);
  insertDocuments(db, playersCollection, players);

  client.close();
});
