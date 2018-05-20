﻿$(function() {
    $( "#slider-range" ).slider({
      range: true,
      min: 150000,
      max: 20000000,
      values: [ 250000, 1500000 ],
      slide: function( event, ui ) {
          $("#amount").val("₹" + ui.values[0].toLocaleString('en-IN') + " - ₹" + ui.values[1].toLocaleString('en-IN'));
      }
    });
    $("#amount").val("₹" + $("#slider-range").slider("values", 0).toLocaleString('en-IN') +
      " - ₹" + $("#slider-range").slider("values", 1).toLocaleString('en-IN'));
  });

	var container = $('.grid').isotope({
		itemSelector: '.col-xs-12',
		getSortData: {
			name: '.name',
			price: '.price parseInt'
		}
	});
	$('.alphSort').on('click', function(e){
		e.preventDefault();
		container.isotope({ sortBy: 'name'});
	});
	$('.prcBtnH').on('click', function(e){
		e.preventDefault();
		container.isotope({ sortBy: 'price', sortAscending: false});
	});
	$('.prcBtnL').on('click', function(e){
		e.preventDefault();
		container.isotope({ sortBy: 'price', sortAscending: true});
	});
	$('.prcBtnR').on('click',function(e){
		e.preventDefault();
		container.isotope({sortBy:'random'});
	});
	$('.prcBtnO').on('click',function(e){
		e.preventDefault();
		container.isotope({sortBy:'original-order'});
	});

$('#btnRM').click(function(){
    $('#readmore').animate({height:'322px'}, 500);
});
$('#btnRL').click(function(){
	$('#readmore').animate({height:'0px'}, 500);
});
$('#btnRM2').click(function(){
    $('#readmore2').animate({height:'322px'}, 500);
});
$('#btnRL2').click(function(){
	$('#readmore2').animate({height:'0px'}, 500);
});

	$(function () {
  $("#mydd a").on('click',function (e) {
  	e.preventDefault();
    $("#dropdownMenu1").html($(this).html() + ' <span class="downicon"></span>');
  });
});

$(function () {
  $("#mydd2 a").on('click',function (e) {
  	e.preventDefault();
    $("#dropdownMenu2").html($(this).html() + ' <span class="downicon"></span>');
  });
});
$(function () {
  $("#mydd3 a").on('click',function (e) {
  	e.preventDefault();
    $("#dropdownMenu3").html($(this).html() + ' <span class="downicon"></span>');
  });
});