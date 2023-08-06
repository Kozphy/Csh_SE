function longTimeWork(workFine = true, errorMessage = "test") {
    return new Promise( (resolve, reject) => {
        setTimeout( () => {
            (workFine) ? resolve(200) : reject(errorMessage);
        }, 1000);
    })
}

// async function usingLongTimeWork() {
//     var result = await longTimeWork(true, "test");
//     console.log(result);
// }

async function usingLongTimeWork() {
    try {
        var result = await longTimeWork(false, "test");
        console.log(result);
    }
    catch (e) {
        console.log(e);
    }
    
}

usingLongTimeWork();
