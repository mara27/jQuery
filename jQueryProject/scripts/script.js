$(document).ready(function () {
    var lista;
    $("#getList").click(function () {
        $.ajax({
            url: "/Home/GetList",
            dataType: "Json",
            contentType: "application/json",
            success: function (data) {
                alert("Datele au fost primite!");
                lista = data;
                populareTabel();
            },
            error: function () {
                alert("Datele nu au fost primite!");
            }
        });
    });

    function populareTabel() {
        $("#tabel1").css("visibility", "visible");
        $("#bodyt1").empty();
        for (var i = 0; i < lista.length; i++)
            $("#tabel1").append("<tr>" + "<td>" + lista[i].Nume + "</td>" +
                "<td>" + lista[i].Varsta + "</td>" +
                "<td>" + lista[i].Descriere + "</td>" +
                "<td>" + '<button type="button" id="show">' + "Show" + "</button>" + "</tr>");
    }

    $("#submit").click(function () {
        var nume = $("#nume").val();
        var varsta = $("#varsta").val();
        var descriere = $("#descriere").val();
       // var gorila = { Nume: nume, Varsta: varsta, Descriere: descriere };

        var animal = new Object();
        animal.Nume = nume;
        animal.Varsta = varsta;
        animal.Descriere = descriere;

        $.ajax({
            url: "/Home/Insert",
            type: "POST",
            data: JSON.stringify(animal),
            dataType: "json",
            contentType: "application/json",
            success: function () {
                alert("Datele au fost trimise!");
                $("#getList").trigger("click");
            },
            error: function () {
                alert("Datele NU au fost trimise!");
            }
        });
    });
    
    var details;

    $("#show").click(function () {
        $.ajax({
            url: "/Home/ShowDetails",
            dataType: "Json",
            contentType: "application/json",
            success: function (data) {
                alert("Datele din tabel au fost primite!");
                details = data;
                showDetails();
            },
            error: function () {
                alert("Datele din tabel NU au fost primite");
            }

        });
    });

    function showDetails() {
        $("#details").empty();
        for (var i = 0; i < details.length; i++)
            $("#details").append("<p>" + details[i] + "</p>");
    }
});