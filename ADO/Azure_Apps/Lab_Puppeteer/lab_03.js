const puppeteer = require('puppeteer');

// function delay(time) {
//     return new Promise(function(resolve) { 
//         setTimeout(resolve, time)
//     });
// }

async function main () {
    const browser = await puppeteer.launch({headless: false});
    const page = await browser.newPage();
    await page.goto('https://en.wikipedia.org/wiki/Wiki', {waitUntil: 'networkidle2'});
    await page.focus("#searchInput");
    await page.keyboard.type('earth');
    (await page.$("#searchButton")).click();
    // await delay(1000);
    // await page.keyboard.press('ArrowDown');
    // await page.keyboard.press('\n');
    // await delay(1000);
    // await page.screenshot({path: 'example.png'});
    // await browser.close();
}

main();
