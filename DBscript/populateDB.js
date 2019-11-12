const MongoClient = require("mongodb").MongoClient;
const assert = require("assert");
let players = require("./initDBplayers");

const url = "mongodb://localhost:28017";

const dbName = "team";

const client = new MongoClient(url);

client.connect(function(err) {
  assert.equal(null, err);
  console.log("Connected successfully to server");

  const db = client.db(dbName);

  insertDocuments(db);

  client.close();
});

const insertDocuments = function(db) {
  const collection = db.collection("players");
  players.forEach(function(player) {
    collection.insertOne(player, function(err, result) {
      return new Promise(function(resolve, reject) {
        assert.equal(err, null);
        resolve("Player inserted successfully!");
        reject(err);
      })
        .then(function(value) {
          console.log(value);
        })
        .catch(function(reason) {
          console.log(reason);
        });
    });
  });
  collection.countDocuments().then(function(value) {
    console.log("Player count = " + value);
  });
};
