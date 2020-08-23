// MATCH HEIGHTS
$(function() {
    $(".match-height").matchHeight({
        byRow: true
    });
});
$(window).bind('load resize', function () {
    $(".match-height").matchHeight({
        byRow: true
    });
});



$(document).ready(function () {
  // BOOTSTRAP ACCORDION LINKING
  var getUrlParameter = function getUrlParameter(sParam) {
      var sPageURL = window.location.search.substring(1),
          sURLVariables = sPageURL.split('&'),
          sParameterName,
          i;

      for (i = 0; i < sURLVariables.length; i++) {
          sParameterName = sURLVariables[i].split('=');

          if (sParameterName[0] === sParam) {
              return sParameterName[1] === undefined ? true : decodeURIComponent(sParameterName[1]);
          }
      }
  };
  var itemId = getUrlParameter('item');
  if (itemId) {
      $("#collapse-item-" + itemId).collapse('show');
  }
});