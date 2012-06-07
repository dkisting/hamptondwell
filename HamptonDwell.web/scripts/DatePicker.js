(function ($) {

    var methods = {
        init: function (options) {
            return this.each(function (index) {
                var dateHTML = "<select>";
                var monthHTML = "<select>";
                var yearHTML;
                for (var i = 1; i <= 31; i++) {
                    dateHTML += "<option>" + i + "</option>";
                }
                dateHTML += "</select>";
                var monthNames = new Array("January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December");
                for (var i = 0; i < 12; i++) {
                    monthHTML += "<option value='" + (i + 1) + "'>" + monthNames[i] + "</option>";
                }
                monthHTML += "</select>";
                var defaults = { prev: 3, next: 3 };
                var options = $.extend(defaults, options);
                var dt = new Date();
                yearHTML = "<select>";
                for (var i = dt.getFullYear() - options.prev; i <= dt.getFullYear() + options.next; i++) {
                    yearHTML += "<option>" + i + "</option>";
                }
                yearHTML += "</select>";
                $(this).append(dateHTML);
                $(this).append(monthHTML);
                $(this).append(yearHTML);
            });
        },
        setDate: function (value) {
            return this.each(function (index) {
                var dt = value.split("/");
                var i = 0;
                $(this).children().each(function () {
                    $(this).val(dt[i]);
                    i++;
                })
            })
        },
        getDate: function () {
            var dt = new Array();
            this.each(function (index) {
                var i = 0;
                $(this).children().each(function () {
                    dt[i] = $(this).val();
                    i++;
                })
            })
            return dt.join("/");
        }
    };

    $.fn.DatePicker = function (method) {
        if (methods[method]) {
            return methods[method].apply(this, Array.prototype.slice.call(arguments, 1));
        } else if (typeof method === 'object' || !method) {
            return methods.init.apply(this, arguments);
        } else {
            $.error('Method ' + method + ' does not exist on jQuery.DatePicker');
        }

    };
})(jQuery);
