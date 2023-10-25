document.getElementById("searchButton").addEventListener("click", function textValidation() {
    var searchInput = document.getElementById("searchInput").value;
    if (searchInput.trim() === "") {//search bara boþ deðer girilirse
        return false;
    } else {
        // girilen deðer için arama iþlemi
        return true;
    }
});
