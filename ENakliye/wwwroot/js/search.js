document.getElementById("searchButton").addEventListener("click", function () {
    var searchInput = document.getElementById("searchInput").value;

    // XSS sald�r�lar�n� engellemek i�in kullan�c� giri�ini escape eder.
    var sanitizedInput = escapeHtml(searchInput);

    if (sanitizedInput.trim() === "") {
        // Arama �ubu�u bo�sa i�lem yapma
        return false;
    } else {
        // Sanitize edilmi� de�er i�in arama i�lemi
        return true;
    }
});

// Bu i�lev XSS sald�r�lar�n� �nlemek i�in kullan�c� girdisini temizler.
function escapeHtml(text) {
    var map = {
        '&': '&amp;',
        '<': '&lt;',
        '>': '&gt;',
        '"': '&quot;',
        "'": '&#039;'
    };

    return text.replace(/[&<>"']/g, function (m) {
        return map[m];
    });
}
