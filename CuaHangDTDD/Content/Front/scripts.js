// JavaScript Document

// Scroll-Top
$j(window).load(function(){
 // hide #back-top first
 $j("#back-top").hide();
 var w;
 setW()
 $j(window).resize(setW)
 function setW() {
	w=$j(window).width(); 
	var m_left=10;
	if (w>1160) {
		m_left=~~(w-1160)/2;
	}
	$j('#back-top').css({left:m_left})
 }
 // fade in #back-top
 $j(function () {
  $j(window).scroll(function () {
   if ($j(this).scrollTop() > 200) {
    $j('#back-top').fadeIn();
   } else {
    $j('#back-top').fadeOut();
   }
  });
  // scroll body to 0px on click
  $j('#back-top a').click(function () {
   $j('body,html').animate({
    scrollTop: 0
   }, 800);
   return false;
  });
 });
});

// Pretty Photo


$j(document).ready(function(){
	/*$j("#vmMainPage h3 , #vmMainPage h2 ").wrapInner("<span />").wrapInner("<span />");
		$j('.module_new h3').each(function() {
            var hd = jQuery(this).html();
            var index = hd.indexOf(' ');
            if(index == -1) {
                index = hd.length;
            }
            $j(this).html('<em>' + hd.substring(0, index) + '</em>' + hd.substring(index, hd.length));
        });					*/		
		// cart				
	/*$j(function() {
		var offset = $j("#cart").offset();
		var topPadding = 135;
		$j(window).scroll(function() {
		if ($j(window).scrollTop() > offset.top) {
		$j("#cart").stop().animate({marginTop: $j(window).scrollTop() - offset.top + topPadding});
		}
		else {$j("#cart").stop().animate({marginTop: 0});};});
		});*/
	
	if ($j('.vmCartDetails > div').hasClass('vmRowTwo')) {
			$j('.vmCartContainer1').css({width:'100%'})
		} else {
	    //$j('.vmCartContainer1').css({width:'135px'})	
	    $j('.vmCartContainer1').css({ width: 'auto' })//quocdunginfo
		}									
$j("#product_list a[rel^='prettyPhoto']").prettyPhoto({
			slideshow:false,
			theme:'facebook',
			animationSpeed:'normal',
			overlay_gallery: false
		});
		$j("#product_list2 a[rel^='prettyPhoto']").prettyPhoto({
			slideshow:false,
			theme:'facebook',
			animationSpeed:'normal',
			overlay_gallery: false
		});	
		$j(".thumbnailListContainer a[rel^='prettyPhoto']").prettyPhoto({
			slideshow:false,
			theme:'facebook',
			animationSpeed:'normal',
			overlay_gallery: false
		});	
		$j(".Fly a[rel^='prettyPhoto']").prettyPhoto({
			slideshow:false,
			theme:'facebook',
			animationSpeed:'normal',
			overlay_gallery: false
		});	
		
	// Releted Products end Featured
	
	 var cont_left = $j(".featured .featuredBorder ,.extra-releted");
        $j(".product_image_container a img").hover(function() {
            // hover in
            $j(this).parent().parent().css("z-index", 1);
            $j(this).animate({
               height: "182",
               width: "130",
               left: "-=10",
               top: "-=10"
            }, "fast");
        }, function() {
            // hover out
            $j(this).parent().parent().css("z-index", 0);
            $j(this).animate({
                height: "154",
                width: "110",
                left: "+=10",
               top: "+=10"
            }, "fast");
        });	
});

// JavaScript Docum
$j(document).ready(function(){
							
		// Tabs Fly-page					
		if ($j('.for_video > div').hasClass('video')) {
			$j('#tab5').css({display:'block'})
		} else {
			$j('#tab5').css({display:'none'})	
		}
		//accordion begin
	    $j("#accordion dt").eq(0).addClass("active");
	    $j("#accordion dd").eq(0).show();
	    $j("#accordion dt").click(function(){
	        $j(this).next("#accordion dd").slideToggle("slow")
	        .siblings("#accordion dd:visible").slideUp("slow");
	        $j(this).toggleClass("active");
	        $j(this).siblings("#accordion dt").removeClass("active");
	        return false;
	    });
		//When page loads...
		$j(".tab_content").hide(); //Hide all content
		$j("ul.tabs li:first").addClass("active").show(); //Activate first tab
		$j(".tab_content:first").show(); //Show first tab content
		
		//On Click Event
		$j("ul.tabs li").click(function() {
			$j("ul.tabs li").removeClass("active"); //Remove any "active" class
			$j(this).addClass("active"); //Add "active" class to selected tab
			$j(".tab_content").hide(); //Hide all tab content
			var activeTab = $j(this).find("a").attr("href"); //Find the href attribute value to identify the active tab + content
			$j(activeTab).fadeIn(); //Fade in the active ID content
			var tab_act=activeTab+' '+'.browse_'+activeTab.slice(-1);
			$j(tab_act).css({display:'block'});
			return false;
		});
		var n;
		$j('.tabs li').each(function(e){
			if ($j(this).hasClass('active')) {n=e}					  
		})
		var tab_act=$j('.tabs').eq(n).find('a').attr('href')
		if (tab_act) {tab_act=tab_act+' '+'.browse_'+tab_act.slice(-1);}
		$j(tab_act).css({display:'block'});
	});