﻿// Generated by IcedCoffeeScript 108.0.11
(function() {
  var $, changeContrast, getColors, getCookie, resizeText, setContrast, setCookie;

  $ = jQuery;

  getColors = function(name) {
    if (name === "black") {
      return "#000000";
    }
    if (name === "white") {
      return "#ffffff";
    }
    if (name === "yellow") {
      return "#ffff00";
    }
    if (name === "blue") {
      return "#ddddff";
    }
    if (name === "cream") {
      return "#ffffdd";
    }
    if (name === "pink") {
      return "#ffdddd";
    }
  };

  resizeText = function(multiplier) {
    if (document.body.style.fontSize === "") {
      document.body.style.fontSize = "0.8em";
    }
    return document.body.style.fontSize = parseFloat(document.body.style.fontSize) + (multiplier * 0.1) + "em";
  };

  setCookie = function(cname, cvalue, exdays) {
    var d, expires;
    d = new Date();
    d.setTime(d.getTime() + (exdays * 24 * 60 * 60 * 1000));
    expires = "expires=" + d.toUTCString();
    return document.cookie = cname + "=" + cvalue + ";" + expires + ";path=/";
  };

  getCookie = function(cname) {
    var c, ca, i, name, _i, _ref;
    name = cname + "=";
    ca = document.cookie.split(';');
    for (i = _i = 0, _ref = ca.length; 0 <= _ref ? _i <= _ref : _i >= _ref; i = 0 <= _ref ? ++_i : --_i) {
      c = ca[i];
      if (c !== void 0) {
        while (c.startsWith(' ')) {
          c = c.substring(1);
        }
        if (c.indexOf(name) === 0) {
          return c.substring(name.length, c.length);
        }
      }
    }
    return "";
  };

  $('.text-size-smaller').click(function() {
    resizeText(-1);
    return false;
  });

  $('.text-size-bigger').click(function() {
    resizeText(1);
    return false;
  });

  $('.text-size-reset').click(function() {
    document.body.style.fontSize = "0.8em";
    return false;
  });

  setContrast = function(newContrast) {
    var colours, data, newLogo;
    if (newContrast.startsWith("black")) {
      newLogo = '//dotneststatic.com/media/vcconferences/MediaTheme/Content/img/vassall-logo-bw.gif';
    } else {
      newLogo = '//dotneststatic.com/media/vcconferences/MediaTheme/Content/img/vassall-logo.pn';
    }
    colours = newContrast.split('-on-');
    data = {
      backcolor: getColors(colours[1]),
      forecolor: getColors(colours[0]),
      logo: newLogo,
      message: newContrast.substring(0, 5)
    };
    setCookie("contrast", newContrast, 600);
    return changeContrast(data);
  };

  $("#cycle-contrast").click(function() {
    var contratsArray, currentContrast, index, newContrast, newIndex;
    currentContrast = getCookie("contrast");
    if (currentContrast === "") {
      newContrast = "black-on-white";
    } else {
      contratsArray = ["black-on-white", "black-on-yellow", "black-on-blue", "black-on-pink", "black-on-cream", "white-on-black", "yellow-on-black", "reset-contrast"];
      index = contratsArray.indexOf(currentContrast);
      if (index > 6) {
        newIndex = 0;
      } else {
        newIndex = index + 1;
      }
      newContrast = contratsArray[newIndex];
    }
    setContrast(newContrast);
    console.log(newContrast);
    return false;
  });

  $("#reset-contrast").click(function() {
    setContrast("reset-contrast");
    return false;
  });

  $("#cycle-contrast-form #contrast").click(function() {
    window.location = $("#contrast-link").val();
    return false;
  });

  $('.btn-contrast').click(function() {
    var newContrast;
    newContrast = this.id;
    setContrast(newContrast);
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
