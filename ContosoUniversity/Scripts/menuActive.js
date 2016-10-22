function active(i){
    $("#topnav li").removeClass("active");
    $("#topnav li:eq("+i+")").addClass("active");
}