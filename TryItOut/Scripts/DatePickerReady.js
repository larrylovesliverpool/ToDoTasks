
if (!Modernizr.inputtypes.date) {
    $(function () {

        $(".datecontrol").datepicker({
            format: 'dd/mm/yyyy',
            autoclose: true,
            orientation: 'left bottom'
        });

    });
}

/* Eof */