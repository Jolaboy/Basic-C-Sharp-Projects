document.addEventListener("DOMContentLoaded", () => {
    const box = document.getElementById("box");
    let position = 0;
    let direction = 1;

    setInterval(() => {
        if (position >= 300 || position <= 0) direction *= -1;
        position += direction * 5;
        box.style.left = position + "px";
    }, 30);
});