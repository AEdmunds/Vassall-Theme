
$ = jQuery ## reset $ var within funciton

getColors = (name)->
    if name is "black"
        return "#000000" 
    if name is "white"
        return "#ffffff" 
    if name is "yellow" 
        return "#ffff00"         
    if name is "blue"
        return "#ddddff" 
    if name is "cream"  
        return "#ffffdd"
    if name is "pink"
        return "#ffdddd"
    


## function to resize text
resizeText = (multiplier) ->
    if document.body.style.fontSize is ""
        document.body.style.fontSize = "0.8em";
    document.body.style.fontSize = parseFloat(document.body.style.fontSize) + (multiplier * 0.1) + "em"

 
setCookie = (cname, cvalue, exdays)->
    d = new Date()
    d.setTime(d.getTime() + (exdays*24*60*60*1000))
    expires = "expires="+ d.toUTCString()
    document.cookie = cname + "=" + cvalue + ";" + expires + ";path=/"

getCookie = (cname)->
    name = cname + "=";
    ca = document.cookie.split(';');
    for i in [0..ca.length]
        c = ca[i]
        if c isnt undefined
            c = c.substring(1) while c.startsWith(' ')
            if c.indexOf(name) == 0
                return c.substring(name.length,c.length)
    
    return "";


$('.text-size-smaller').click ->
    resizeText(-1)
    return false

$('.text-size-bigger').click ->
    resizeText(1)
    return false

$('.text-size-reset').click ->
    document.body.style.fontSize = "0.8em";
    return false

setContrast = (newContrast)->
     ## get logo 
    if newContrast.startsWith("black")
        newLogo = '//dotneststatic.com/media/vcconferences/MediaTheme/Content/img/vassall-logo-bw.gif' 
                      
    else
        newLogo = '//dotneststatic.com/media/vcconferences/MediaTheme/Content/img/vassall-logo.png'

    ## set colours         
    colours = newContrast.split('-on-') 
    
    data =  
        backcolor: getColors(colours[1]) 
        forecolor: getColors(colours[0])
        logo: newLogo
        message: newContrast.substring(0,5)
           
    setCookie("contrast", newContrast, 600)

    changeContrast(data)


$("#cycle-contrast").click ->
  ## get contrast
    currentContrast = getCookie("contrast")
    if currentContrast is ""  
        newContrast = "black-on-white"
    else
        contratsArray = ["black-on-white","black-on-yellow","black-on-blue","black-on-pink","black-on-cream","white-on-black","yellow-on-black","reset-contrast"]
        index = contratsArray.indexOf(currentContrast)
        if index > 6
            newIndex = 0
        else 
            newIndex = index + 1     
        newContrast = contratsArray[newIndex]
   
    setContrast(newContrast)
    console.log newContrast
    return false 

$("#reset-contrast").click ->
    setContrast("reset-contrast")
    return false 


$("#cycle-contrast-form #contrast").click ->
    window.location = $("#contrast-link").val()
    return false

$('.btn-contrast').click ->
    newContrast = this.id    
    setContrast(newContrast)
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
    

