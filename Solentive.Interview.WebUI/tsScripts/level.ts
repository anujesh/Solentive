/// <reference path="../tsScripts/jquery/jquery.d.ts" />
"use strict";

let formSelectorLevel = "form#addLevelForm";
let btnSaveLevel = $("#btnSaveLevel");
let resultLevel = $("#divResultLevel");

class Level {
    saveLevel() {
        const url = "/Level/Add";
        const formData = $(formSelectorLevel).serialize();
        $.post(url,
            formData,
            data => {
                resultLevel.html(data);
            }).fail(response => {
            resultLevel.html(response.responseText);
        });
        event.preventDefault();
    }
}


let level = new Level();
$(document).ready(() => {
    bindEventsLevel();
});

function bindEventsLevel() {
    btnSaveLevel.click("click",
        event => {
            if ($("#addLevelForm").valid()) {
                // Stop the form reloading.
                event.preventDefault();
                level.saveLevel();
            }
        });
}