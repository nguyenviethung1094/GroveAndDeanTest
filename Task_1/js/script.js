function openMenu() {
    $('.menu').toggle("slide");
    $('#menu-mask').toggle("slide");
}

function toggleSearch() {
    $('#search-icon').toggleClass('fa-times');
    $('.home-button').fadeToggle(0);
    $('.search').fadeToggle(0);
}

function toggleOptions() {
    $('.more-options').slideToggle();
}