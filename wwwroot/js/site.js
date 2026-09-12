// Small enhancement: keyboard navigation between questions on the details page.
document.addEventListener("keydown", function (e) {
    if (e.key === "ArrowRight") {
        const next = document.querySelector(".nav-btn:last-child");
        if (next && next.tagName === "A") next.click();
    }
    if (e.key === "ArrowLeft") {
        const prev = document.querySelector(".nav-btn:first-child");
        if (prev && prev.tagName === "A") prev.click();
    }
});
