$('#Animals').click(function () {
    $.ajax({
        type: 'GET',
        url: '/api/Test',
        success: function (data) {
            var result = '<ul>';


            for (var item of data) {
                result += "<li>" + "Id:" + item.Id + "Name:" + item.Name + "Age:" + item.Age + "</li>"
                //result += "<li>" +  + "</li>"
                //result += "<li>" +  + "</li>"
            }
            var endResult = result + "<ul>";
            $('.list-container').empty().append(endResult);
        },
        error: function (msg) {
            alert('Server error', msg);
        }
    })
});

    $('#AnimalsJson').click(function () {
        $.ajax({
            type: 'GET',
            url: '/api/Animal',
            success: function (data) {
                //var result = '<ul>';


                //for (var item of data) {
                //    result += "<li>" + "Id:" + item.Id + "Name:" + item.Name + "Age:" + item.Age + "</li>"
                //    //result += "<li>" +  + "</li>"
                //    //result += "<li>" +  + "</li>"
                //}
                //var endResult = result + "<ul>";
                $('.list-container').empty().append(data);
            },
            error: function (msg) {
                alert('Server error', msg);
            }
        })

    });
