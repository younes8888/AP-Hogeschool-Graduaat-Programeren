const addBtnEl = document.querySelector(".add-box");
const removeBtnEl = document.querySelector(".remove-box");
const boxEl = document.querySelector(".box");
const containerEl = document.querySelector(".container");

addBtnEl.addEventListener("click", (e) => {
    const newBoxEl = boxEl.cloneNode(true);
    containerEl.appendChild(newBoxEl);
});

removeBtnEl.addEventListener("click", (e) => {
    const boxEls = document.querySelectorAll(".box");
    if (boxEls.length > 0) {
        const lastBoxEl = boxEls[boxEls.length - 1];
        containerEl.removeChild(lastBoxEl);
    }
});