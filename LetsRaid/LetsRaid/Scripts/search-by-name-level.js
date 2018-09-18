$(document).ready(function () {
    $('#SearchByName').keyup(function () {
        var tr = $('#NamesFromTable tbody tr'); //use tr not td
        if ($(this).val().length >= 2) {
            var inputdata = $.trim($("#SearchByName").val());
            $('#errmsg').hide();
            var noName = true;
            var val = $.trim(this.value).toLowerCase();

            el = tr.filter(function () {
                return this.innerHTML.toLowerCase().indexOf(val) >= 0;
            }); // <==== closest("tr") removed
            if (el.length >= 1) {
                noName = false;
            }
            //now you fadeIn/Out every row not every cell
            tr.not(el).fadeOut();
            el.fadeIn();
            if (noName)
                if (inputdata !== '') {
                    $('#errmsg').html('No Results Matched').show();
                }
                else {
                    $('#errmsg').hide();
                }
        }
        else {
            tr.fadeIn(); //show all if length does not match the required number of characters
            $('#errmsg').hide();
        }

    })
});