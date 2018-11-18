/// <reference path="../tsScripts/jquery/jquery.d.ts" />
"use strict";

var formSelectorLocation = "form#addLocationForm";
let btnSaveLocation = $("#btnSaveLocation");
let resultLocation = $("#divResult");

class SeminarLocation {
    save() {
        const url = "/Location/Add";
        const formData = $(formSelectorLocation).serialize();
        $.post(url,
            formData,
            data => {
                resultLocation.html(data);
            }).fail(response => {
            resultLocation.html(response.responseText);
        });
        event.preventDefault();
            }
}

let seminarLocation = new SeminarLocation();
$(document).ready(() => {
    bindEventsLocation();
});


function bindEventsLocation() {
    btnSaveLocation.click("click",
        event => {
            if ($("#addLocationForm").valid()) {
                // Stop the form reloading.
                event.preventDefault();
                seminarLocation.save();
            }
        });

}