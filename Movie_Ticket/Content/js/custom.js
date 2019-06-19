$(function(){


    $(".Slider").owlCarousel(    {
        items: 7,
        slideSpeed: 1000,
        autoplay: true,
        nav: false,
        lazyLoad : true,
        responsive: false,
        pagination: false,
        autoPlay : 4000,
    });

    $(".KFilm").owlCarousel(    {
        items: 5,
        slideSpeed: 1500,
        autoplay: true,
        nav: false,
        lazyLoad : true,
        responsive: false,
        pagination: false,
        autoPlay : 3000,
    });


    $(".avatardegis").change(function(event){
        var input = $(event.currentTarget);
        var file = input[0].files[0];
        var reader = new FileReader();
        reader.onload = function(e){
            image_base64 = e.target.result;
            $(".avataronizle").attr("src",image_base64);
        };
        reader.readAsDataURL(file);
    });

    if ( $.isFunction($.fn.dataTable) ) {
        $('table.datatablems').dataTable({
            "ordering": false,
            "info": false,
            "language": {
                "url": "Content/plugins/datatable/dataTable_Turkish.json"
            }
        });
    }





});