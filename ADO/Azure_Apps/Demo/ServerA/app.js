var express = require("express");
var app = express();
app.listen(3000);

app.use(express.static("public"));

app.get("/getData", function (req, res) {
    res.send(' {"id": 3, "qty": 100 } ')
})
