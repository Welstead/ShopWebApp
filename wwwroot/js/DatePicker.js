$(function () {

    function WireUpDatePicker()
    {
        const addMonths = 2;
        var currDate = new Date();
        $('.datepicker').datepicker(
            {
                dateFormat: 'dd-mm-yy',
                minDate: currDate, //Sets minimum date to today so you cant pick a date in the past
                maxDate: AddSubtractMonths(currDate, addMonths) //Sets max date to 2 months in the future
            }
        );
    }
    WireUpDatePicker()

});