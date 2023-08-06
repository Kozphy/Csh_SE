function happy(data, timeCount) {
    return new Promise( function (resolve, reject) {
        setTimeout(function () {
            resolve(data);
        }, timeCount)
    })
}

function sad(data, timeCount) {
    return new Promise( function (resolve, reject) {
        setTimeout(function () {
            resolve(data);
        }, timeCount)
    })
}


async function living() {
    let [result1, result2] = 
      await Promise.all([happy(200, 2000), sad(-100, 3000)]);

    var total = result1 + result2;
    console.log("total:", total);
}

living();

