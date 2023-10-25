document.getElementById("searchButton").addEventListener("click", function () {
    var searchInput = document.getElementById("searchInput").value;

    // XSS saldýrýlarýný engellemek için kullanýcý giriþini escape eder.
    var sanitizedInput = escapeHtml(searchInput);

    if (sanitizedInput.trim() === "") {
        // Arama çubuðu boþsa iþlem yapma
        return false;
    } else {
        // Sanitize edilmiþ deðer için arama iþlemi
        return true;
    }
});

// Bu iþlev XSS saldýrýlarýný önlemek için kullanýcý girdisini temizler.
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
