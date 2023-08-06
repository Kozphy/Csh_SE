var express = require("express");
var app = express();
app.listen(5000);

// npm install cors
var cors = require("cors"); 
app.use(cors());  // access-control-allow-origin: *

app.get("/getData", function (req, res) {
    res.send(' {"id": 3, "qty": 200 } ')
})
