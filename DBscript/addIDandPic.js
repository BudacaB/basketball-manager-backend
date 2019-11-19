module.exports = function(doc, index) {
  let picsUrl = "https://budaca-bball.s3.eu-central-1.amazonaws.com";
  doc._id = index;

  if (doc.name === "Lakers" || doc.name === "Warriors") {
    doc.pic = picsUrl + `/${doc.name}`.toLowerCase() + ".png";
  } else {
    doc.pic =
      picsUrl +
      `/${doc.team}`.toLowerCase() +
      `/${doc.firstname}`.toLowerCase() +
      ".png";
  }
};
