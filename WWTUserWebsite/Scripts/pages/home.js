wwt.home = (function () {
  var api = {
    init: init
  };

  function init() {
    $(window).on('resize contentchange', resize);
    resize(true);
  }

  function resize() {
    var winW = $(window).width();

    $('.home-features img.img-responsive').css({
      marginLeft: (winW < 750 && winW > 582) ? (winW - 580) / 2 : 0
    });
  };

  return api;
})()
