module.exports = function(db, docs) {
  const collection = db.collection("players");
  docs.forEach(function(doc) {
    collection.insertOne(doc, function(err, result) {
      return new Promise(function(resolve, reject) {
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
