/// <reference path="../tsScripts/jquery/jquery.d.ts" />
"use strict";
var formSelectorLocation = "form#addLocationForm";
var btnSaveLocation = $("#btnSaveLocation");
var resultLocation = $("#divResult");
var SeminarLocation = /** @class */ (function () {
    function SeminarLocation() {
    }
    SeminarLocation.prototype.save = function () {
        var url = "/Location/Add";
        var formData = $(formSelectorLocation).serialize();
        $.post(url, formData, function (data) {
            resultLocation.html(data);
        }).fail(function (response) {
            resultLocation.html(response.responseText);
        });
        event.preventDefault();
    };
    return SeminarLocation;
}());
var seminarLocation = new SeminarLocation();
$(document).ready(function () {
    bindEventsLocation();
});
function bindEventsLocation() {
    btnSaveLocation.click("click", function (event) {
        if ($("#addLocationForm").valid()) {
            // Stop the form reloading.
            event.preventDefault();
            seminarLocation.save();
        }
    });
}
//# sourceMappingURL=seminarlocation.js.map