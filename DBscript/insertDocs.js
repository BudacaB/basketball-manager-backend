module.exports = function(db, collectionName, docs) {
  const collection = db.collection(collectionName);

  let addDocs = () => {
    return new Promise((resolve, reject) => {
      collection.insertMany(docs, function(err, result) {
        if (result) {
          resolve(console.log(result));
        } else {
          reject(console.log(err));
        }
      });
    });
  };

  (async () => {
    await addDocs();
  })();

  return collection.countDocuments();

  // collection.insertMany(docs, function(err, result) {
  //   if (result) {
  //     console.log(result);
  //   } else {
  //     console.log(err);
  //   }
  // });
  // return collection.countDocuments();
};
