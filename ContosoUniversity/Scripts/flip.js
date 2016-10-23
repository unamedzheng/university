
$(function () {
    var $obj1 = $(".clour1");   
    var $obj2 = $(".clour2");    
    var $obj3 = $(".clour3");
    addflip($obj1);
    addflip($obj2);
    addflip($obj3);
});
function addflip(obj) {
    obj.hover(function () {
        flip(obj);
    });
};
function flip(obj) {
    obj.addClass('flipInY');
    obj.addClass('animated');
    //function为闭包，用于将$(".clour")传进程序延迟执行
    setTimeout(function () { obj.removeClass('flipInY'); }, 1000);
};