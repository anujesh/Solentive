/// <reference path="../tsScripts/jquery/jquery.d.ts" />
"use strict";

var formSelectorTrack = "form#addTrackForm";
let btnSaveTrack = $("#btnSaveTrack");
let result = $("#divResultTrack");

class Track {
    save() {
        const url = "/Track/Add";
        const formData = $(formSelectorTrack).serialize();
        $.post(url,
            formData,
            data => {
                result.html(data);
            }).fail(response => {
            result.html(response.responseText);
        });
        // Stop the form reloading.
        event.preventDefault();
    }
}

let track = new Track();
$(document).ready(() => {
    bindEventsTrack();
});


function bindEventsTrack() {
    btnSaveTrack.click("click",
        event => {
            if ($("#addTrackForm").valid()) {
                // Stop the form reloading.
                event.preventDefault();
                track.save();
            }
        });
}