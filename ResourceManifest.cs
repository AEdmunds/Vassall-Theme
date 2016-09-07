////using Orchard.UI.Resources;


//using Orchard.UI.Resources;

//public class ResourceManifest : IResourceManifestProvider {
   
//    public void BuildManifests(ResourceManifestBuilder builder) {
//        var manifest = builder.Add();

//        // styles
//        manifest.DefineStyle("bootstrap").SetUrl("bootstrap.min.css", "bootstrap.css");
//        manifest.DefineStyle("color_scheme").SetUrl("color_scheme.css");
//        manifest.DefineStyle("custom").SetUrl("custom.css");
//        manifest.DefineStyle("fancy-style").SetUrl("fancy-style.css");
//        manifest.DefineStyle("flexslider").SetUrl("flexslider.css");

//        // fonts 
//        manifest.DefineStyle("google-fonts").SetUrl("local-google-fonts.css")
//            .SetCdn("http://fonts.googleapis.com/css?family=Open+Sans:400,400italic,600,600italic,700,700italic");
//        manifest.DefineStyle("font-awesome-ie7").SetUrl("font-awesome-ie7.css");
//        manifest.DefineStyle("font-awesome").SetUrl("font-awesome.css");

//        manifest.DefineStyle("IE-fix").SetUrl("IE-fix.css");
//        manifest.DefineStyle("isotope").SetUrl("isotope.css");
//        manifest.DefineStyle("jqeury.countdown").SetUrl("jqeury.countdown.css");
//        manifest.DefineStyle("jquery.fancybox-1.3.4").SetUrl("jquery.fancybox-1.3.4.css");
//        manifest.DefineStyle("jquery.fancybox").SetUrl("jquery.fancybox.css");
//        manifest.DefineStyle("responsive").SetUrl("responsive.css");
//        manifest.DefineStyle("rs-plugin-settings").SetUrl("rs-plugin/css/settings.css");
//        manifest.DefineStyle("rs-responsive").SetUrl("rs-responsive.css");
//        manifest.DefineStyle("style").SetUrl("style.css");
//        manifest.DefineStyle("styler").SetUrl("styler.css");
//        manifest.DefineStyle("overwrite").SetUrl("overwrite.css");
//        manifest.DefineStyle("bic-cal").SetUrl("bic_calendar.css");


//        // define contrast sytle 
//        manifest.DefineScript("black-on-white").SetUrl("contrast/black-on-white.css");
//        manifest.DefineScript("black-on-blue").SetUrl("contrast/black-on-blue.css");
//        manifest.DefineScript("black-on-cream").SetUrl("contrast/black-on-cream.css");
//        manifest.DefineScript("black-on-pink").SetUrl("contrast/black-on-pink.css");
//        manifest.DefineScript("black-on-yellow").SetUrl("contrast/black-on-yellow.css");
//        manifest.DefineScript("white-on-black").SetUrl("contrast/white-on-black.css");
//        manifest.DefineScript("yellow-on-black").SetUrl("contrast/yellow-on-black.css");


//        // scripts
//        manifest.DefineScript("jquery.1.7.2").SetUrl("https://ajax.googleapis.com/ajax/libs/jquery/1.7.2/jquery.min.js");
//        manifest.DefineScript("jquery-ui").SetUrl("jquery-ui.min.js").SetDependencies("jquery.1.7.2");
//        manifest.DefineScript("bootstrap").SetUrl("bootstrap.js").SetDependencies("jquery.1.7.2");
//        manifest.DefineScript("style-switcher").SetUrl("style-switcher/style-switcher.js").SetDependencies("jquery.1.7.2");
//        manifest.DefineScript("jquery.flexslider").SetUrl("jquery.flexslider-min.js").SetDependencies("jquery.1.7.2");
//        manifest.DefineScript("jquery.isotope").SetUrl("jquery.isotope.js").SetDependencies("jquery.1.7.2");
//        manifest.DefineScript("jquery.fancybox.pack").SetUrl("jquery.fancybox.pack.js?v=1.3.4").SetDependencies("jquery.1.7.2");
//        manifest.DefineScript("rs-plugin").SetUrl("rs-plugin/jquery.themepunch.plugins.min.js").SetDependencies("jquery.1.7.2");
//        manifest.DefineScript("rs-plugin-revolution").SetUrl("rs-plugin/jquery.themepunch.revolution.js").SetDependencies("jquery.1.7.2");
//        manifest.DefineScript("revolution").SetUrl("revolution.custom.js").SetDependencies("jquery.1.7.2");
//        manifest.DefineScript("custom").SetUrl("custom.js").SetDependencies("jquery.1.7.2");
//        manifest.DefineScript("access").SetUrl("access.js").SetDependencies("jquery.1.7.2");
//        manifest.DefineScript("bic-cal").SetUrl("bic_calendar.js").SetDependencies("jquery.1.7.2");


//    }
//}