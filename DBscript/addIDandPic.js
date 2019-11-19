module.exports = function(doc, index) {
  let picsUrl = "https://budaca-bball.s3.eu-central-1.amazonaws.com";
  doc._id = index;

  if (doc.name === "Lakers" || doc.name === "Warriors") {
    doc.pic = picsUrl + `/${doc.name}`.toLocaleLowerCase() + ".png";
  } else {
    doc.pic =
      picsUrl +
      `/${doc.team}`.toLocaleLowerCase() +
      `/${doc.firstname}`.toLocaleLowerCase() +
      ".png";
  }
};
