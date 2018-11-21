/// <reference path="../tsScripts/jquery/jquery.d.ts" />
"use strict";
var formSelectorTrack = "form#addTrackForm";
var btnSaveTrack = $("#btnSaveTrack");
var result = $("#divResultTrack");
var Track = /** @class */ (function () {
    function Track() {
    }
    Track.prototype.save = function () {
        var url = "/Track/Add";
        var formData = $(formSelectorTrack).serialize();
        $.post(url, formData, function (data) {
            result.html(data);
        }).fail(function (response) {
            result.html(response.responseText);
        });
        // Stop the form reloading.
        event.preventDefault();
    };
    return Track;
}());
var track = new Track();
$(document).ready(function () {
    bindEventsTrack();
});
function bindEventsTrack() {
    btnSaveTrack.click("click", function (event) {
        if ($("#addTrackForm").valid()) {
            // Stop the form reloading.
            event.preventDefault();
            track.save();
        }
    });
}
//# sourceMappingURL=track.js.map