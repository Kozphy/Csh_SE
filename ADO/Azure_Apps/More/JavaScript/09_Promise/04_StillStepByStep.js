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
    var total = 0;
    var result1 = await happy(200, 2000);
    console.log(result1);
    var result2 = await sad(-100, 3000);
    console.log(result2);
    total = result1 + result2;
    console.log("total:", total);
}

living();


