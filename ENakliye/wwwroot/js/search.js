document.getElementById("searchButton").addEventListener("click", function textValidation() {
    var searchInput = document.getElementById("searchInput").value;
    if (searchInput.trim() === "") {//search bara bo� de�er girilirse
        return false;
    } else {
        // girilen de�er i�in arama i�lemi
        return true;
    }
});
