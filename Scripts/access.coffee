
$ = jQuery ## reset $ var within funciton

## funciton to resize text
## $.fn.resizeText = (multiplier) ->
##    if document.body.style.fontSize is ""
##        document.body.style.fontSize = "0.8em";
##    document.body.style.fontSize = parseFloat(document.body.style.fontSize) + (multiplier * 0.1) + "em"

## generic function to change site contrast 
## ToDo: persist this to session or cookie for whole site via ajax request 

$('.text-size').click ->
    $.post $('#set-text-size-form')[0].action, 'submitButton=' + this.id, (data)-> 
        document.body.style.fontSize = data.emsize + "em"
    return false


$("#cycle-contrast").click ->
    $.post $('#cycle-contrast-form')[0].action, 'submitButton=' + this.id, (data)->
        changeContrast(data)
    return false 

$("#cycle-contrast-form #contrast").click ->
    window.location = $("#contrast-link").val()
    return false

$('.btn-contrast').click ->    
    $.post $('#set-contrast-form')[0].action, 'submitButton=' + this.id, (data)->
        changeContrast(data)
    return false 

changeContrast = (data) ->
    if data.message is "reset"
        $('body').css
            "background":"#fff"
        $('body, p').css
            "color":"#666666"
        $('a').css
            "color":"#2773ae"
        $('h1, h2, h3, h4, h5, h6').css 
            "color":"#333333"
        $('.navbar .nav > li a').css
            "color":"#333333"
        $('.navbar .container, .navbar .nav .active > a').css
            "background":"#FFFFFF"
        $('.logo img').attr('src', data.logo)
    else
        $('body, .navbar .container, .navbar .nav .active > a').css
            "background":data.backcolor
        $('body, h1, h2, h3, h4, h5, h6, p, a, .navbar .nav > li a').css
            "color":data.forecolor
        $('.logo img')[0].src = data.logo
    
## bic calender 

##months = ["January", "Febuary ", "March", "April", "May", "June", "July", "August", "Setember", "October", "November", "December"];
##days = ["M", "T", "W", "T", "F", "S", "S"];

##$('#booking-calendar').bic_calendar
##    nombresMes: months
##    dias: days
##    req_ajax: 
##        type: 'get',
##        url: 'calendarDates'
