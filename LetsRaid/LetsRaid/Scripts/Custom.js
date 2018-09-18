//Live Search....
    $(document).ready(function () {
        function Contains(text_one, text_two) {
            if (text_one.indexOf(text_two) != -1)
                return true;
        }
            $("#Search").keyup(function () {

                var searchText = $("#Search").val().toLowerCase();

                $(".Search").each(function () {
                    if (!Contains($(this).text().toLowerCase(), searchText)) {
                        $(this).hide();
                    }
                    else {
                        $(this).show();
                    }
            });
        });       
});

