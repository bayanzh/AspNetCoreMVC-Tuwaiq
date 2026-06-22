const btn = document.querySelector(".btn-outline-secondary");

btn.addEventListener("click", function () {
    this.classList.toggle("btn-danger");
    this.classList.toggle("btn-outline-secondary");
});