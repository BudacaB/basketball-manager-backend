module.exports = function(db, collectionName, docs) {
  const collection = db.collection(collectionName);
  collection.insertMany(docs, function(err, result) {
    if (result) {
      Promise.resolve(result).then(function(value) {
        console.log(value);
      });
    } else {
      Promise.reject(err).then(function(error) {
        console.log(error);
      });
    }
  });
  return collection.countDocuments();
};
