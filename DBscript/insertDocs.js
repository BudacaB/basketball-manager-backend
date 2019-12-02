module.exports = function(db, collectionName, docs) {
  const collection = db.collection(collectionName);

  return collection.insertMany(docs, function(err, result) {
    if (result) {
      console.log(result);
    } else {
      console.log(err);
    }
  });

  // collection.insertMany(docs, function(err, result) {
  //   if (result) {
  //     console.log(result);
  //   } else {
  //     console.log(err);
  //   }
  // });
  // return collection.countDocuments();
};
