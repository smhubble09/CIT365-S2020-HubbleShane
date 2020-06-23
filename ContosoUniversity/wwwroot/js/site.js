// Write your JavaScript code.

if (location.pathname !== "/")
    $("li>a[href*='" + location.pathname + "']").addClass("current");
else
    $('.home-page').addClass("current");