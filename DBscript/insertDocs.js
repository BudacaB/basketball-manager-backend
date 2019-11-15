module.exports = function(db, collectionName, docs) {
  const collection = db.collection(collectionName);
  collection.insertMany(docs, function(err, result) {
    if (result) {
      console.log(result);
    } else {
      console.log(err);
    }
  });
  return collection.countDocuments();
};
