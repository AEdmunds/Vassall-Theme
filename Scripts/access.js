(function() {
  var $, changeContrast;

  $ = jQuery;

  $('.text-size').click(function() {
    $.post($('#set-text-size-form')[0].action, 'submitButton=' + this.id, function(data) {
      return document.body.style.fontSize = data.emsize + "em";
    });
    return false;
  });

  $("#cycle-contrast").click(function() {
    $.post($('#cycle-contrast-form')[0].action, 'submitButton=' + this.id, function(data) {
      return changeContrast(data);
    });
    return false;
  });

  $("#cycle-contrast-form #contrast").click(function() {
    window.location = $("#contrast-link").val();
    return false;
  });

  $('.btn-contrast').click(function() {
    $.post($('#set-contrast-form')[0].action, 'submitButton=' + this.id, function(data) {
      return changeContrast(data);
    });
    return false;
  });

  changeContrast = function(data) {
    if (data.message === "reset") {
      $('body').css({
        "background": "#fff"
      });
      $('body, p').css({
        "color": "#666666"
      });
      $('a').css({
        "color": "#2773ae"
      });
      $('h1, h2, h3, h4, h5, h6').css({
        "color": "#333333"
      });
      $('.navbar .nav > li a').css({
        "color": "#333333"
      });
      $('.navbar .container, .navbar .nav .active > a').css({
        "background": "#FFFFFF"
      });
      return $('.logo img').attr('src', data.logo);
    } else {
      $('body, .navbar .container, .navbar .nav .active > a').css({
        "background": data.backcolor
      });
      $('body, h1, h2, h3, h4, h5, h6, p, a, .navbar .nav > li a').css({
        "color": data.forecolor
      });
      return $('.logo img')[0].src = data.logo;
    }
  };

}).call(this);
