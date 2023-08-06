var express = require('express');
var router = express.Router();

router.get('/getModel', function(req, res, next) {
  var fs = require("fs");
  var s = fs.readFileSync("./model.json")
  res.send(s);
});

router.post('/setModel', function(req, res, next) {
  var modelData = {
    model_topology: req.body.model_topology,
    weight_specs: req.body.weight_specs,
    weight_data: req.body.weight_data,
    model_metadata: req.body.model_metadata,
    info: req.body.info
  };

  var fileContent = JSON.stringify(modelData);
  var fs = require("fs");
  fs.writeFileSync("./model.json", fileContent);
  res.send("OK");
});

module.exports = router;
