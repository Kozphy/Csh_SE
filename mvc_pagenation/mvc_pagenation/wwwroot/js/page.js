let lastPageBtn = document.querySelector(".lastPageBtn");
let totalPage = await GetTotalPage();

async function GetTotalPage() {
    try {
        let res = await axios.get("http://localhost:5011/Home/GetDbTableTotalPage")
        if (res.status == 200) {
            return res.data
        }
    } catch (ex) {
        console.log(ex);
    }
}

function RenderPagination(c, m) {
    let current = c,
        last = m,
        delta = 2,
        left = current - delta,
        right = current + delta + 1,
        range = ['<li class="page-item"><a class="page-link" href="#">Previous</a></li>',
            '<li class="page-item"><a class="page-link" href="#">Next</a></li>'
        ],
        rangeWithDots = [],
        l;

    for (let i = 1; i <= last; i++) {
        if (i == 1 || i == last || i >= left && i < right) {
            range.splice(range.length - 1, 0, `<li class="page-item"><a class="page-link" href="#">${i}</a></li>`
            );
        }
    }
    console.log(range);


    for (let i of range) {
        if (l) {
            if (i - l === 2) {
                rangeWithDots.push(l + 1);
            } else if (i - l !== 1) {
                rangeWithDots.push('...');
            }
        }

        rangeWithDots.push(i);
        l = i;
    }

    rangeWithDots = rangeWithDots.join("");
    return rangeWithDots;
}

let pagination = document.querySelector(".pagination");

let res = RenderPagination(1, 10);
console.log(res)
pagination.insertAdjacentHTML('beforeend', res);

lastPageBtn.addEventListener("click", async function (e) {

});

