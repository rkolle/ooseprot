/* RESET */
html,body,div,ul,ol,li,dl,dt,dd,h1,h2,h3,h4,h5,h6,pre,form,p,blockquote,fieldset,input,abbr,article,aside,command,details,figcaption,figure,footer,header,hgroup,mark,meter,nav,output,progress,section,summary,time { margin: 0; padding: 0; }
h1,h2,h3,h4,h5,h6,pre,code,address,caption,cite,code,em,strong,th,figcaption { font-size: 1em; font-weight: normal; font-style: normal; }
fieldset,iframe { border: none; }
caption,th { text-align: left; }
table { border-collapse: collapse; border-spacing: 0; }
article,aside,footer,header,hgroup,nav,section,figure,figcaption { display: block; }

/*Navigation*/
#globalheader #globalnav li a span {
	background-image:url(/de/global/nav/images/globalnav_text.png);
	_background-image:url(/de/global/nav/images/globalnav_text.gif);
}


#globalheader.svg        #globalnav li a span { background-image:url(/de/global/nav/images/globalnav_text.svg); }
#globalheader.decelerate #globalnav li a span,
#globalheader.ios3       #globalnav li a span { background-image:url(/de/global/nav/images/globalnav_text.png); }


/* LAYOUT */
html { background-color:#fff; }


.clear { clear: both; }
.clearer { clear: both; display: block; margin: 0; padding: 0; height: 0; line-height: 1px; font-size: 1px; }

img, .search-wrapper .left, .search-wrapper .right, ul.sp-results li.viewall a, ul.sp-results li .replacementimg, 
#globalfooter #breadcrumbs, #globalfooter #breadcrumbs span, #directorynav .capbottom, 
#productheader h1 a, #productheader h2 a, #main .maincap { behavior: url(/global/scripts/lib/iepngfix.htc); }

img { border: 0; }

img.left { float: left; margin: 2px 20px 16px 0; }
img.right { float: right; margin: 2px 0 16px 20px; }
img.across { margin: 2px 0 16px 0; }
img.flushleft { margin-left: -20px; }
img.flushright { margin-right: -20px; }

.replaced { display: block; width: 1px; height: 1px; outline: none; overflow: hidden; text-indent: -9999px; }
#omniture, #top { position: absolute; top: 0; }
#container { width: 980px; margin: 0 auto; position: relative; }
#main { width: 100%; position: relative; }
#content { padding: 18px 20px; position: relative; color: #333; }
#breadcrumb { clear: both; text-align: center; margin: 18px auto; clear: both; font-size: 10px; color: #686868; }


.content { background: #fff; border: 1px solid; border-color: #e5e5e5 #dbdbdb #d2d2d2; -webkit-box-shadow: rgba(0,0,0,0.3) 0 1px 3px; -moz-box-shadow: rgba(0,0,0,0.3) 0 1px 3px; box-shadow: rgba(0,0,0,0.3) 0 1px 3px; }
.content:nth-child(1n) { border: none; } /* reset border for smart browsers */

.content,
.rounded,
.article .box { border-radius: 4px; -webkit-border-radius: 4px; -moz-border-radius: 4px; -o-border-radius: 4px; -khtml-border-radius: 4px; }

.graybox,
.callout { border-radius: 7px; -webkit-border-radius: 7px; -moz-border-radius: 7px; -o-border-radius: 7px; -khtml-border-radius: 7px; }

.roundedtop { border-radius: 4px 4px 0 0; -webkit-border-top-left-radius:4px; -webkit-border-top-right-radius:4px; -moz-border-radius: 4px 4px 0 0; -o-border-radius: 4px 4px 0 0; -khtml-border-radius: 4px 4px 0 0; }
.roundedbottom { border-radius: 0 0 4px 4px; -webkit-border-bottom-left-radius:4px; -webkit-border-bottom-right-radius:4px; -moz-border-radius: 0 0 4px 4px; -o-border-radius: 0 0 4px 4px; -khtml-border-radius: 0 0 4px 4px; }
.roundedright { border-radius: 0 4px 4px 0; -webkit-border-top-right-radius:4px; -webkit-border-bottom-right-radius:4px; -moz-border-radius: 0 4px 4px 0; -o-border-radius: 0 4px 4px 0; -khtml-border-radius: 0 4px 4px 0; }
.roundedleft { border-radius: 4px 0 0 4px; -webkit-border-top-left-radius:4px; -webkit-border-bottom-left-radius:4px; -moz-border-radius: 4px 0 0 4px; -o-border-radius: 4px 0 0 4px; -khtml-border-radius: 4px 0 0 4px; }
.roundedtopleft { border-radius:4px 0 0; -webkit-border-top-left-radius:4px; -moz-border-radius:4px 0 0; -o-border-radius:4px 0 0; -khtml-border-radius:4px 0 0; }
.roundedtopright { border-radius: 0 4px 0 0; -webkit-border-top-right-radius:4px; -moz-border-radius:0 4px 0 0; -o-border-radius:0 4px 0 0; -khtml-border-radius: 0 4px 0 0; }
.roundedbottomleft { border-radius: 0 0 0 4px; -webkit-border-bottom-left-radius:4px; -moz-border-radius: 0 0 0 4px; -o-border-radius: 0 0 0 4px; -khtml-border-radius: 0 0 0 4px; }
.roundedbottomright { border-radius: 0 0 4px 0; -webkit-border-bottom-right-radius:4px; -moz-border-radius: 0 0 4px 0; -o-border-radius: 0 0 4px 0; -khtml-border-radius: 0 0 4px 0; }

/* GRID */
.column { float: left; }
.grid2col, .grid2cola, .grid2colb, .grid2colc, .grid2cold, .grid2cole, .grid2colf, .grid3col, .grid3cola, .grid4col, .grid5col, .grid6col { width: 100%; }

.grid2col .column { width: 49%; }
.grid2col .grid2col .column { width: 47.8%; }
.grid3col .grid2col .column { width: 46%; }
.grid4col .grid2col .column { width: 45%; }

.grid2cola .column.first { width: 66%; }
.grid2cola .column.last { width: 32%; }

.grid2colb .column.first { width: 74.9%; }
.grid2colb .column.last { width: 23%; }

.grid2colc .column.first { width: 32%; }
.grid2colc .column.last { width: 66%; }

.grid2cold .column.first { width: 23%; }
.grid2cold .column.last { width: 74.9%; }

.grid2cole .column.first { width: 79%; }
.grid2cole .column.last { width: 19%; }

.grid2colf .column.first { width: 19%; }
.grid2colf .column.last { width: 79%; }

.grid3col .column { width: 32%; margin-left: 2%; }
.grid2col .grid3col .column { width: 31%; }

.grid3cola .column { width: 58%; margin-left: 2%; }
.grid3cola .column.first,
.grid3cola .column.last { width: 19%; }

.grid4col .column { width: 23%; margin-left: 3%; }

.grid5col .column { width: 18.4%; margin-left: 2%; }

.grid6col .column { width: 15%; margin-left: 2%; }

.column.first, .column.last { margin-left: 0 !important; }
.column.last { float: right !important; }

p.last, ul.last, ol.last, li.last { _width: auto !important; _float: none !important; }

#container:after, #content:after, .grid2col:after, .grid2cola:after, .grid2colb:after, .grid2colc:after, .grid2cold:after, .grid2cole:after, .grid2colf:after, .grid3col:after, .grid3cola:after, .grid4col:after, .grid5col:after, .grid6col:after { content: "."; display: block; height: 0; clear: both; visibility: hidden; }
#container, #content, .grid2col, .grid2cola, .grid2colb, .grid2colc, .grid2cold, .grid2cole, .grid2colf, .grid3col, .grid3cola, .grid4col, .grid5col, .grid6col { zoom: 1; }

/* TYPE */
body { font: 12px/18px "Lucida Grande", "Lucida Sans Unicode", Helvetica, Arial, Verdana, sans-serif; background-color: transparent; color: #333; -webkit-font-smoothing: antialiased; }


a { color: #08c; }
a:link, a:visited, a:active { text-decoration: none; }
a:hover { text-decoration: underline; }
a.block { display: block; cursor: pointer; }
a.block span,
a.block em { color:#08c; cursor: pointer; }
a.block:hover { text-decoration: none; }
a.block:hover span,
a.block:hover em { color: #08c; text-decoration: underline; }
a.more, em.more, span.more { white-space: nowrap; padding-right: 10px; background: url(/euro/global/elements/arrows/morearrow_08c.gif) no-repeat 100% 50%; cursor: pointer; zoom: 1; }
a.external, em.external, span.external { white-space: nowrap; padding-right: 15px; background: url(/euro/global/elements/icons/external10x10.gif) no-repeat 100% 49%; cursor: pointer; zoom: 1; }
a[rel="external"] { white-space: nowrap; padding-right: 15px; background: url(/euro/global/elements/icons/external10x10.gif) no-repeat 100% 49%; cursor: pointer; zoom: 1; }
em.more, span.more, em.external, span.external { color:#08c; font-style: normal; cursor: pointer; }
.nowrap { white-space:nowrap; }
strong, b { font-weight: bold; }
em, i, cite { font-style: italic; }
sup { padding-left: 1px; font-size: 10px !important; font-weight: normal !important; vertical-align: baseline; position: relative; bottom: 0.33em; _position: static !important; }
sup, sup a { color:#666; }
sup a:hover { color:#08c; text-decoration:none; }
abbr { border: 0; }
.sosumi { font-size: 10px !important; line-height:1.5; color:#888; }
.sosumi_features { font-size: 10px !important; line-height:1.5; color:#888; }

h1,h2,h3,h4,h5,h6,strong { color:#000; }
h1,h2,h3,h4 { font-weight: bold; }
h2,h3,h4 { line-height: 18px; }
h1,h2 { margin-bottom: 18px; }
h1 { font-size: 24px; line-height: 36px; }
h2 { font-size: 16px; }
h3 { font-size: 1em; }
h4 { font-size: 10px; }

p { margin-bottom: 18px; }
p.intro { color: #888; font-size: 16px; line-height: 22px; font-weight: normal; }
.more { text-align: right; }

ul { list-style: none outside; }
ol { margin-bottom: 18px; list-style: decimal; margin-left: 2.2em; }
ul.square,
ul.circle { margin-left: 2em; margin-bottom: 18px; }
ul.square { list-style: square outside; }
ul.circle { list-style: circle outside; }
ul ul.circle,
ul ul.square { margin-top: 4px; margin-bottom: 5px; }
ol.sosumi { margin-left: 0; padding-left: 2em; *padding-left: 2.2em; }

a.pdf { background: url(/euro/global/elements/icons/globaliconpdf12x12.gif) 0 0.4em no-repeat; display: block; padding-left: 20px; }
a.html { background: url(/euro/global/elements/icons/globaliconhtml12x12.gif) 0 0.4em no-repeat; display: block; padding-left: 20px; }
a.qt { background: url(/euro/global/elements/icons/globaliconqt12x12.gif) 0 0.4em no-repeat; display: block; padding-left: 20px; }
a.ical { background: url(/euro/global/elements/icons/globaliconical12x12.gif) 0 0.4em no-repeat; display: block; padding-left: 20px; }
a.dl { background: url(/euro/global/elements/icons/globalicondl11x10.gif) 0 0.4em no-repeat; display: block; padding-left: 20px; }
a.dmg { background: url(/euro/global/elements/icons/globalicondmg12x12.gif) 0 0.4em no-repeat; display: block; padding-left: 20px; }
a.zip { background: url(/euro/global/elements/icons/globaliconzip12x12.gif) 0 0.4em no-repeat; display: block; padding-left: 20px; }
a.keynote { background: url(/euro/global/elements/icons/globaliconkeynote12x12.gif) 0 0.4em no-repeat; display: block; padding-left: 20px; }
a.audio { background: url(/euro/global/elements/icons/globaliconaudio12x12.gif) 0 0.4em no-repeat; display: block; padding-left: 20px; }

.last { margin-bottom: 0; }
#main .sidebar { font-size: 10px; line-height: 18px; color:#333; }
#main .callout { font-size: 11px; line-height: 18px; margin-bottom: 18px; }

body.specs #main { font-size: 11px; line-height: 16px; }

/* PIPED LINKS */
.piped { display: block; zoom: 1; }
.piped:after { content: "."; display: block; height: 0; clear: both; visibility: hidden; }
.piped li { float: left; display: inline; }
.piped a { border-left: 1px solid #797c80; padding: 0 0 0 0.75em; margin-left: 0.75em; }
.piped a.first { border-left: 0 !important; padding-left: 0; margin-left: 0 !important; }

/*--- Global Footer (legacy) ---*/
#globalfooter .gf-buy { float: left; width: 60%; margin: 18px 0 9px; }
#globalfooter .gf-links { float: right; margin: 18px 0 9px; }
#globalfooter .gf-links a { padding: 0 10px; white-space: nowrap; }
#globalfooter .gf-links a.last { padding-right: 0; _float: none !important; width: auto !important; }

/*--- Global Footer ---*/
#globalfooter { width: 980px; color: #888; font-size: 10px; margin: 18px auto 0; padding-bottom: 36px; text-align: left !important; }
#globalfooter a { color: #08c; }
#globalfooter p { margin-bottom: 1em; }
#globalfooter p.gf-buy { float: left; width: 52%; margin: 18px 0 9px 3px; }
#globalfooter ul.piped a { padding: 0 0 0 1.5em; margin-left: 1.5em; border-left: 1px solid #d0d0d0; }
#globalfooter .gf-links { float: right; margin: 18px 3px 9px 0; }
#globalfooter .gf-sosumi { clear: both; width: 100%; border-top: 1px solid #ddd; padding-top: 9px; }
#globalfooter .gf-sosumi a { padding: 0 10px; }
#globalfooter .gf-sosumi p { float: left; margin-left: 3px; }
#globalfooter form { margin: 18px 10px; }
#globalfooter .search-wrapper { margin: 0 auto; }
#globalfooter .search-wrapper input.prettysearch { margin-left: 10px; }
#globalfooter ul.piped a.contact_us { padding-right: 1.5em; border-right: 1px solid #d0d0d0; }
#globalfooter ul.piped a.choose { margin-left: 0; border: 0; }
#globalfooter ul.piped a.choose img { vertical-align: middle; margin-top: -5px; *position: relative; }

/*--- Breadcrumbs (legacy) ---*/
#globalfooter #breadcrumbs { font-size: 11px; color: #444; background: url(/euro/global/nav/images/breadcrumb_bg.png) no-repeat; overflow: hidden; height: 36px; line-height: 34px; font-weight: bold; text-shadow: 0 1px 0 #fff; }
#globalfooter #breadcrumbs a { color: #444; text-decoration: none; float: left; padding: 0 10px; margin-left: -10px; *position: relative; _cursor: hand; }
#globalfooter #breadcrumbs a:hover { color: #333; text-decoration: none !important; }
#globalfooter #breadcrumbs a.home { margin: 0; width: 15px; height: 0; padding-top: 36px; overflow: hidden; }
#globalfooter #breadcrumbs span { float: left; width: 9px; margin: 0 10px 0 0; height: 0; padding-top: 34px; margin-top: 1px; overflow: hidden; background: url(/euro/global/nav/images/breadcrumb_sep.png) no-repeat; }

/*--- Breadcrumbs ---*/
#globalfooter ol#breadcrumbs { font-size: 11px; color: #444; background: url(/euro/global/nav/images/breadcrumb_bg.png) no-repeat; height: 36px; line-height: 34px; margin: 0; list-style: none; font-weight: bold; text-shadow: 2px 2px 1px #fff; behavior: url(/global/scripts/lib/iepngfix.htc); }
#globalfooter ol#breadcrumbs li { float: left; margin: 0; padding: 0 0 0 20px; background: url(/euro/global/nav/images/breadcrumb_sep_20080909.png) no-repeat; }
#globalfooter ol#breadcrumbs li a { float: left; color: #444; text-decoration: none; padding: 0 10px; margin-left: -10px; }
#globalfooter ol#breadcrumbs li a:hover { color: #333; text-decoration: none; }
#globalfooter ol#breadcrumbs li.home { background: none; margin: 0; padding: 0; }
#globalfooter ol#breadcrumbs li.home a { margin: 0; padding: 0 10px; width: 15px; text-indent: -9999px; overflow: hidden; }

/*--- BREADORY ---*/
#breadory {
	border: 1px solid #ddd; width: 978px; margin: 0 auto;
	-moz-border-radius: 4px;
	-webkit-border-radius: 4px;
}
#globalfooter #breadory ol#breadcrumbs { background: none; clear: both; float: none; height: 3em; line-height: 3em; font-size: 11px; color: #666; margin: 0; list-style: none; font-weight: bold; text-shadow: 2px 2px 1px #fff; }
#breadory ol#breadcrumbs li { background: none; float: left; margin: 0; padding: 0 0 0 1em; }
#breadory ol#breadcrumbs li a { float: left; color: #666; text-decoration: none; padding: 0 1.75em 0 0; margin-left: 0px; background: url(/euro/global//nav/images/breadcrumb_separator.png) no-repeat 100% 50%; }
#breadory ol#breadcrumbs li a:hover { color: #333; text-decoration: none; }
#breadory ol#breadcrumbs li.home { background: none; margin: 0; padding: 0; }
#breadory ol#breadcrumbs li.home a { background: url(/euro/global//nav/images/breadcrumb_home.png) no-repeat 1.25em 50%; margin: 0; padding: 0 0 0 1.25em; width: 30px; text-indent: -9999px; overflow: hidden; }
#breadory ol#breadcrumbs li.home a:hover { background-image: url(/euro/global//nav/images/breadcrumb_home_over.png); }

#breadory #directorynav { background: none; clear: both; float: none; margin-top: 0; }
#breadory #directorynav .capbottom { height: 0; font-size: 1px; _display: none; }

/* PRODUCTHEADER */{ float: left; width: 9px; margin: 0 10px 0 0; position: relative; height: 0; padding-top: 34px; margin-top: 1px; overflow: hidden; background: url(/euro/global/nav/images/breadcrumb_sep.png) no-repeat; behavior: url(/global/scripts/lib/iepngfix.htc); }

/*--- Directory Nav ---*/
#directorynav { font-size: 11px; background: url(/euro/global/nav/images/directory_bg.png) repeat-y; border-top: 1px solid #e5e5e5; float: left; width: 100%; position: relative; margin-top: -4px; }
#directorynav .column { width: 122px; padding: 9px 0 4px 18px; }
#directorynav .column.last { float: left !important; padding-right: 0; }
#directorynav h3 { color: #666; margin: 0; font-size: 1em; line-height: 18px; font-weight: bold; }
#directorynav h3.standalone { margin-bottom: 18px; }
#directorynav a { color: #888; text-decoration: none; display: block; zoom: 1; }
#directorynav h3.standalone a:link,
#directorynav h3.standalone a:visited { color: #444; }
#directorynav a:hover { color: #333 !important; text-decoration: none !important; }
#directorynav .capbottom { clear: both; position: relative; top: 5px; _top: 12px; height: 5px; width: 980px; background: url(/euro/global/nav/images/directory_capbg.png) no-repeat; behavior: url(/global/scripts/lib/iepngfix.htc); }
#directorynav ul { margin-bottom: 0; padding-bottom: 9px; }
#directorynav .column { width: 120px; }
#directorynav.mac #dn-cola { width: 120px; }
#directorynav.mac #dn-colb { width: 115px; }
#directorynav.mac #dn-cold { width: 110px; }
#directorynav.mac #dn-colg { width: 130px; }
#directorynav.ipad .column { width: 190px; padding: 9px 0 0 54px; }

#directorynav.iphone .column { width: 224px; }
/* OLD STYLING*/
#directorynav.iphone .column,
#directorynav.ipoditunes .column,
#directorynav.ipod .column,
#directorynav.itunes .column { width: 190px; padding: 9px 0 0 54px; }
/* DIRECTORY NAV CUSTOM WIDTHS */
.gf-900 #directorynav .column { width: 120px; }
.gf-980 #directorynav.mac #dn-cola { width: 135px; }
.gf-980 #directorynav.mac #dn-colb { width: 112px; }
.gf-980 #directorynav.mac #dn-cold { width: 110px; }
.gf-980 #directorynav.mac #dn-colg { width: 130px; }

#directorynav.ipoditunes .productred { font-size: 9px; white-space: nowrap; }

/* PRODUCTHEADER */
#productheader { padding: 1em 0 0.2em; overflow: hidden; width: 980px; margin: 0 auto; *position: relative; *height: 39px; }
#productheader h1, 
#productheader h2 { height:32px; line-height: 32px; display: inline; float: left; margin: 1px 0 6px 8px; padding: 0; margin-bottom: 6px !important; }
#productheader h1 a, 
#productheader h2 a { line-height: 32px; background-position: 0 0; background-repeat: no-repeat; color: #888; display: block; font-weight: normal; height: 32px; position: relative; outline: none; text-decoration: none; text-indent: -9999px; behavior: url(/global/scripts/lib/iepngfix.htc); }
body#overview #productheader h1 a, 
body#overview #productheader h2 a { cursor: default; }

#productheader ul { display: inline; float: right; margin: 0; }
#productheader ul li { display: inline; }
#productheader ul li a { color: #333; float: left !important; margin-top: 1em; margin-left: 15px !important; margin-right: 8px; padding: 0; text-decoration: none; }
#productheader ul li a:hover { color: #08c; }

#productheader a.buynow,
#productheader a.joinnow, 
#productheader a.preorder,
#productheader a.howtobuy,
#productheader a.freetrial,
#productheader a.howtoapply,
#productheader a.downloadnow, 
#productheader a.upgradenow,
#productheader a.tryamac,
#productheader a.notifyme { height: 25px; margin: 0.7em 0 0 20px; background-position: 0 0; background-repeat: no-repeat; display: block; float: right; position: relative; text-decoration: none; text-indent: -9999px; outline: none; overflow: hidden; behavior: url(/global/scripts/lib/iepngfix.htc); }

/* XX Specific */
#productheader a.buynow { width: 90px; background-image: url(/de/global/elements/buttons/buynows.png); _background-image: url(/de/global/elements/buttons/buynows.gif); }

#productheader a.joinnow { width: 99px; background-image: url(/de/global/elements/buttons/joinnow.png); }
#productheader a.preorder_blue { background-image:url(/de/global/elements/buttons/preorder_blue.png); width:97px; }
#productheader a.preorder { width: 120px; background-image: url(/de/global/elements/buttons/preorder.png); }
#productheader a.howtobuy { width: 108px; background-image: url(/de/global/elements/buttons/howtobuys.png); }
#productheader a.howtoapply { width: 74px; background-image: url(/de/global/elements/buttons/howtoapplys.png); }
#productheader a.freetrial { width: 90px; background-image: url(/de/global/elements/buttons/freetrials.png); }
#productheader a.downloadnow, #productheader span.downloadnow { width: 108px; background-image: url(/de/global/elements/buttons/downloadnows.png); }
#productheader a.upgradenow { width: 104px; background-image: url(/de/global/elements/buttons/upgradenows.png); }
#productheader a.tryamac, #productheader span.tryamac { width: 77px; background-image: url(/de/global/elements/buttons/tryamacs.png); _background-image: url(/de/global/elements/buttons/tryamacs.gif); }
#productheader a.notifyme { width: 105px; background-image: url(/de/global/elements/buttons/notifymes_de.png); _background-image: url(/de/global/elements/buttons/notifymes_de.gif); }
#productheader a.preorder { width: 100px; background-image: url(/de/global/elements/buttons/preorders.png); _background-image: url(/de/global/elements/buttons/preorders.gif); }

#productheader a.buynow, #productheader span.buynow,
#productheader a.ordernow, #productheader span.ordernow,
#productheader a.joinnow, #productheader span.joinnow,
#productheader a.preorder, #productheader span.preorder,
#productheader a.preorder_blue, #productheader span.preorder_blue,
#productheader a.howtobuy, #productheader span.howtobuy,
#productheader a.howtoapply, #productheader span.howtoapply,
#productheader a.freetrial, #productheader span.freetrial,
#productheader a.downloadnow, #productheader span.downloadnow,
#productheader a.upgradenow, #productheader span.upgradenow,
#productheader a.tryamac, #productheader span.tryamac { height: 25px; margin: 0.7em 0 0 20px; background-position: 0 0; background-repeat: no-repeat; display: block; float: right; position: relative; text-decoration: none; text-indent: -9999px; outline: none; overflow: hidden; }

#productheader a.buynow:hover, #productheader a.buynow:focus,
#productheader a.ordernow:hover, #productheader a.ordernow:focus,
#productheader a.joinnow:hover, #productheader a.joinnow:focus,
#productheader a.preorder:hover, #productheader a.preorder:focus,
#productheader a.howtoapply:hover, #productheader a.howtoapply:focus,
#productheader a.freetrial:hover, #productheader a.freetrial:focus,
#productheader a.downloadnow:hover, #productheader a.downloadnow:focus,
#productheader a.upgradenow:hover, #productheader a.upgradenow:focus,
#productheader a.tryamac:hover, #productheader a.tryamac:focus,
#productheader a.notifyme:hover, #productheader a.notifyme:focus { background-position: 0 -25px; }

.upgradenows { background-image: url(./../elements/buttons/buynows.png); _background-image: url(./../elements/buttons/buynows.gif); width: 104px; }
.buynows { background-image: url(./../elements/buttons/buynows.png); _background-image: url(./../elements/buttons/buynows.gif); width: 90px; }
span.upgradenows,
span.buynows { background-position: 0 -75px; }
.buynows { height: 25px; background-position: 0 0; background-repeat: no-repeat; display: block; text-decoration: none; text-indent: -9999px; overflow: hidden; }
a.buynows:hover { background-position: 0 -25px; }
a.buynows:active { background-position: 0 -50px; }
#productheader a.upgradenows, #productheader span.upgradenows, 
#productheader a.buynows, #productheader span.buynows { height: 25px; margin: 0.7em 0 0 20px; background-position: 0 0; background-repeat: no-repeat; display: block; float: right; position: relative; text-decoration: none; text-indent: -9999px; outline: none; overflow: hidden; }
#productheader a.upgradenows:hover, #productheader a.upgradenows:focus,
#productheader a.buynows:hover, #productheader a.buynows:focus { background-position: 0 -25px; }
#productheader a.upgradenows:active,
#productheader a.buynows:active { background-position: 0 -50px; }

#productheader a.buynow:active,
#productheader a.ordernow:active,
#productheader a.joinnow:active,
#productheader a.preorder:active,
#productheader a.howtobuy:active,
#productheader a.freetrial:active,
#productheader a.howtoapply:active,
#productheader a.downloadnow:active,
#productheader a.upgradenow:active,
#productheader a.tryamac:active,
#productheader a.notifyme:active { background-position: 0 -50px; }

#productheader span.upgradenows,
#productheader span.buynows,
#productheader span.buynow,
#productheader span.ordernow,
#productheader span.joinnow,
#productheader span.preorder,
#productheader span.howtobuy,
#productheader span.howtoapply,
#productheader span.freetrial,
#productheader span.downloadnow,
#productheader span.upgradenow,
#productheader span.tryamac,
#productheader span.notifyme { background-position: 0 -75px; }


/* promofooter */
#promofooter { width:984px; margin:18px auto 0; padding-top:17px; background:url(/euro/promos/images/promofooter_top.png) no-repeat; zoom:1; _background-image:url(/euro/promos/images/promofooter_top.gif); }
#promofooter #promos { width:980px; margin-bottom:0; padding:0 2px 4px; background:url(/euro/promos/images/promofooter_bottom.png) no-repeat 0 100%; zoom:1; _background-image:url(/euro/promos/images/promofooter_bottom.gif); }
#promofooter #promos:after { content:'.'; display:block; height:0; clear:both; visibility:hidden; }
#promofooter #promos li.promo { position:relative; float:left; width:244px; min-height:15em; _height:15em; padding-right:1px; margin-top:-16px; }
#promofooter #promos li.promo a { color:#777; }
#promofooter #promos li.promo:hover a { color:#08c; text-decoration:none; }

#promofooter #promos img { display:block; }

#promofooter #promos h4 a,
#promofooter #promos p a,
#promofooter #promos ul { display:block; padding-left:15px; padding-right:12px; text-align:left; z-index:101; *position:relative; }

#promofooter #promos h4 a { font-size:18px; font-weight:normal; padding-top:15px; }
#promofooter #promos p { margin-bottom:0; }
#promofooter #promos p a { font-size:11px; line-height:16px; }
#promofooter #promos a.image { height:180px; position:absolute; bottom:0; z-index:100; }

#promofooter #promos .promo.left p a { width:110px; }
#promofooter #promos .promo.right p a { width:105px; left:121px; }
#promofooter #promos .promo.center p a { text-align:center; }

#promofooter #promos li.buy { position:relative; float:left; width:244px; padding-right:1px; margin-top:-17px; color:#777; }
#promofooter #promos li.buy ul { font-size:11px; line-height:1.4; }

/* PRINT */
@media print {
	body, #main, #content { color: #000 !important; }
	a, a:link, a:visited { color: #000 !important; text-decoration:none !important; }
	#tabs, #globalheader, #globalfooter, #directorynav, .noprint, .hide { display: none !important; }
	#main a.pdf, #main a.html, #main a.qt, #main a.ical, #main a.dl, #main a.dmg, #main a.zip, #main a.keynote, #main a.audio { padding-left: 0 !important; background-image: none !important; }
}

/* iPhone */
@media screen and (max-device-width: 480px) { html { -webkit-text-size-adjust: none; } }
