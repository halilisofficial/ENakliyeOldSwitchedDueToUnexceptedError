var button = document.getElementById("scroll_to_top_button");
var scrollThreshold = 300; // Eşik değeri (100 piksel)

// Sayfayı aşağı kaydırdıkça butonu görünür hale getir
window.onscroll = function () {
    if (document.body.scrollTop > scrollThreshold || document.documentElement.scrollTop > scrollThreshold) {
        button.style.display = "block";
    } else {
        button.style.display = "none";
    }
};

function scrollToTop() {
    window.scrollTo({ top: 0, behavior: 'smooth' });
}