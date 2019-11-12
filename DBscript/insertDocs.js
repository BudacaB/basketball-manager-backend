module.exports = function(db, collectionName, docs) {
  const collection = db.collection(collectionName);
  collection.insertMany(docs, function(err, result) {
    if (result) {
      return Promise.resolve("Added succesfully").then(function(value) {
        console.log(value);
      });
    } else {
      return Promise.reject(err).then(function(error) {
        console.log(error);
      });
    }
  });
  collection.countDocuments().then(function(value) {
    console.log(`${collectionName} count = ` + value);
  });
};
