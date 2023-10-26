/**
 * bu fonksiyon partial viewi belirli alana yüklemeyi sağlar
 * @param {any} controllerLocation partial viewı yönetecek olan controller konumunu belirtir
 * örnek:/Home/LoadPartialView?partialViewName=_PartialViewFreightExchange
 * partialViewName Home controllerdaki LoadPartialView'ın aldığı string değişkendir
 * @param {any} contentAreaId
 * partial viewin ekleneceği bölgenin idsini belirler
 * örnek:#home_best_services_changable_content_div
 * bu bölgenin div olması önerilir
 */
function loadPartialView(controllerLocation, contentAreaId) {
    $.get(controllerLocation, function (data) {
        $(contentAreaId).html(data);
    });
}