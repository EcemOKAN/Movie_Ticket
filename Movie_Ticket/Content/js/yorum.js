$(function(){


    var show_per_page = 6;

    var number_of_items = $('.yorumajaxliste').children().size();

    var number_of_pages = Math.ceil(number_of_items/show_per_page);

    $('#current_page').val(0);
    $('#show_per_page').val(show_per_page);

    var navigation_html = '';
    var current_link = 0;
    while(number_of_pages > current_link){
        navigation_html += '<li><a class="page_link" href="javascript:go_to_page(' + current_link +')" longdesc="' + current_link +'">'+ (current_link + 1) +'</a></li>';
        current_link++;
    }

    $('.page_navigation').html(navigation_html);


    $('.page_navigation .page_link:first').addClass('active_page');

    $('.yorumajaxliste').children().css('display', 'none');

    $('.yorumajaxliste').children().slice(0, show_per_page).css('display', 'block');


});

function go_to_page(page_num){

    var show_per_page = parseInt($('#show_per_page').val());


    start_from = page_num * show_per_page;

    end_on = start_from + show_per_page;

    $('.yorumajaxliste').children().css('display', 'none').slice(start_from, end_on).css('display', 'block');

    $('.page_link[longdesc=' + page_num +']').addClass('active_page').siblings('.active_page').removeClass('active_page');

    $('#current_page').val(page_num);

}
