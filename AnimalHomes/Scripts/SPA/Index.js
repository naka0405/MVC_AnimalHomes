$('#animals').click(function () {
    $.ajax({
        type: 'GET',
        url: '/api/Test',
        success: function (data) {
            var result = '<ul>';
            for (var item in data)
            {
                result += " <li>" + item.Id + "</li>"
                result += "<li>" + item.Name+"</li>"
                //<li>i.Name</li>
                // <li>i.Age</li>
            }
            var endResult = result + "<ul>";
            

        },
        error: function (msg) {
            alert('Server error', msg);
        }
    });
})