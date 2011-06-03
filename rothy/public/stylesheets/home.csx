/* Base style - quick fix*/
a.block { cursor: pointer; display: block; }

#main { width: 100%; min-width: 980px; margin: 0 0 10px; clear: both; color: #76797c; overflow: hidden; }
#content,
#main .content,
#headlines,
#homefooter { width: 980px; margin: 0 auto 10px; padding:0; }

/* BILLBOARD */
#billboard { text-align:center; }
#billboard h1,
#billboard h2 { line-height:1; }
#billboard h1 img,
#billboard h2 img { display:block; margin:0 auto; }

#promosets { position: relative; width: 100%; height: 776px; }
#promosets .promoset { position: absolute; top: 0; left: 0; }

/* PROMOS */
.promos { position: relative; width: 992px; height: 155px; margin-top: 56px; margin-left: -12px; _width: 1005px; _margin-left: -24px; _margin-right: -20px; }
.promos div.promo-links { display: inline; float: left; width: 236px; height: 155px; margin: 0 12px 0 0; }
.promos div.promo-links { position: relative; }
.promos div.promo-links a { float: none; width: auto; height: auto; margin: 0; }
.promos div.promo-links span { display: block; position: absolute; top:30px; left: 9px; text-align: center; font-size: 11px; line-height: 15px; color: #636363; }

.promos a { position: relative; float: left; height: 155px; width: 236px; margin-left: 12px; z-index: 0; }


/* TICKER */
#headlines { position:absolute; margin-top:-196px; }
#ticker { min-height: 26px; margin-bottom: 15px; background: #f6f6f6 url(http://images.apple.com/euro/home/elements/ticker_btm_grey.gif) no-repeat 0 100%; /*position: relative;*/ _height: 26px;}
#ticker p { line-height: 16px; width: 100%; padding-top: 5px; padding-bottom: 0.2em; background: url(http://images.apple.com/euro/home/elements/ticker_top_grey.gif) no-repeat 0 0; float: left; margin-bottom: 3px; }
#ticker a#ticker-headline { width: 12.5em; margin-right: 1em; color: #565656; font-weight: bold; text-align: center; border-right: 1px solid #808080; display: block; float: left; }
#ticker a#news-headline { padding-left: 15px; color: #a1a5a9; float: right; }
#ticker a { color: #6e6e6e; text-decoration: none; }
#ticker a#news-link { position: relative; z-index: 10; }

/* HOMEFOOTER */
#homefooter p.left a { margin-right: 0; }
#homefooter p.left { width: 50%; float: left; text-align: left; text-indent: 10px; }
#homefooter p.right { width: 50%; float: right; }
#homefooter p.links { border: 1px solid #e5e5e5; border-width: 1px 0; padding: .5em 0; margin: 1.5em 0 2em; }
#homefooter .sosumi p { margin-bottom: 0; }

/* HOMEFOOTER */
#homefooter { margin: 0 auto 22px; text-align: center; font-size: 10px; color: #6e6e6e; }
#homefooter .piped a { border-color: #ccc; }

#homefooter #links { border: 1px solid #e5e5e5; border-width: 1px 0; padding: .5em 0; margin: 1.5em 0 2em; zoom: 1; }
#homefooter #links:after { content: "."; display: block; height: 0; clear: both; visibility: hidden; }
#homefooter #links p { margin-bottom: 0; }
#homefooter #links p.left { float: left; width: auto; text-align: left; text-indent: 10px; }
#homefooter #links ul.right { float: right; padding-right: 10px; margin-bottom: 0; }
#homefooter #links ul.piped a { padding-left: .5em; margin-left: .5em; }

#homefooter .sosumi { clear: both; }
#homefooter .sosumi p { margin-bottom: 0; }
#homefooter .sosumi p.copyright { display: inline; padding-right: 0.75em; } 
#homefooter .sosumi ul.piped { display: inline; display: -moz-inline-box; *display: inline; margin-bottom: 0; padding-right: 0.75em;}
#homefooter .sosumi ul.piped li { float: none; }
#homefooter .sosumi ul.piped li a.first { margin-right: -0.2em; }

/* WORLDWIDE */
#worldwide { background: url(http://images.apple.com/euro/home/elements/home-bg-choosecountry.gif) repeat-x 0 100%; border: 1px solid #e3e3e3; display: inline; padding: 10px 0 8px; position: relative; text-align: left; width: 200px; border-radius: 3px; -webkit-border-radius: 3px; -moz-border-radius: 3px; -o-border-radius: 3px; -khtml-border-radius: 3px; }
#worldwide { *height: 26px; *top: 3px; *margin-left: 10px; *top: 6px; *padding: 0; zoom: 1; }
#worldwide a { height: 30px; padding: 3px 10px 3px 5px; width: 100%; *padding: 0 10px 0 5px; }
#worldwide a:hover { text-decoration: none; }
#worldwide a img { position: relative; top: 5px; padding: 0 5px 0 0; *float: left; *padding: 0; *top: 0; *margin: 2px 0 2px 3px; }
#worldwide a span.more { background: url(http://images.apple.com/euro/global/elements/arrows/morearrow_08c.gif) no-repeat 100% 50%; border-left: 1px solid #e3e3e3; cursor: pointer; display: inline-block; line-height: 30px; margin: -5px 0; padding: 0 10px 0 5px; position: relative; top: 0; }
#worldwide a span.more { *display: inline; *margin-top: 4px; *top: 0; zoom: 1; *line-height: 20px; }

#ticker-rss-link {display: none;}
