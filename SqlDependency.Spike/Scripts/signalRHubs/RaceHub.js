$(function () {

    // Connecting to the hub
    var notifications = $.connection.scheduleHub;

    // Create a function that the hub can call to broadcast messages.
    notifications.client.updateRaceSchedule = function () {
        GetSchedules()
    };

    // Start the connection.
    $.connection.hub.start().done(function () {
     
        GetSchedules();
    }).fail(function (e) {
        alert(e);
    });
});


function GetSchedules() {

    var tbl = $('#racesTable');

    $.ajax({
        url: '/home/GetLatestSchedules',
        contentType: 'application/html ; charset:utf-8',
        type: 'GET',
        dataType: 'html'
    }).success(function (result) {
        tbl.empty().append(result);
    }).error(function () {

    });
}