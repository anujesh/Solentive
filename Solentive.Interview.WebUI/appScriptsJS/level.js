/// <reference path="../tsScripts/jquery/jquery.d.ts" />
"use strict";
var formSelectorLevel = "form#addLevelForm";
var btnSaveLevel = $("#btnSaveLevel");
var resultLevel = $("#divResultLevel");
var Level = /** @class */ (function () {
    function Level() {
    }
    Level.prototype.saveLevel = function () {
        var url = "/Level/Add";
        var formData = $(formSelectorLevel).serialize();
        $.post(url, formData, function (data) {
            resultLevel.html(data);
        }).fail(function (response) {
            resultLevel.html(response.responseText);
        });
        event.preventDefault();
    };
    return Level;
}());
var level = new Level();
$(document).ready(function () {
    bindEventsLevel();
});
function bindEventsLevel() {
    btnSaveLevel.click("click", function (event) {
        if ($("#addLevelForm").valid()) {
            // Stop the form reloading.
            event.preventDefault();
            level.saveLevel();
        }
    });
}
//# sourceMappingURL=level.js.map