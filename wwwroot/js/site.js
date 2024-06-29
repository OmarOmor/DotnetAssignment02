// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function showMembers() {

    var member = document.getElementById("members");
    var equipment = document.getElementById("equipments");
    var equipedMembers = document.getElementById("equipped-members");

    member.style.display = "block";
    equipment.style.display = "none";
    equipedMembers.style.display = "none";
}


function showEquipments() {
    var member = document.getElementById("members");
    var equipment = document.getElementById("equipments");
    var equipedMembers = document.getElementById("equipped-members");

    
    equipment.style.display = "block";
    member.style.display = "none";
    equipedMembers.style.display = "none";
}


function showEquippedMembers() {
    var member = document.getElementById("members");
    var equipment = document.getElementById("equipments");
    var equipedMembers = document.getElementById("equipped-members");

    equipedMembers.style.display = "block";
    equipment.style.display = "none";
    member.style.display = "none";

}