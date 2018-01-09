$(function () {
      // Updates partial view when searching for ingredients
      var ajaxFormSubmit = function () {
            var $form = $(this);

            var options = {
                  url: $form.attr("action"),
                  type: $form.attr("method"),
                  data: $form.serialize()
            };
            $ajax(options).done(function (data) {
                  // $target = target to update with new data
                  var $target = $(form.attr("data-otf-target"));
                  $target.replaceWith(data);
            });
            return false
      };
});