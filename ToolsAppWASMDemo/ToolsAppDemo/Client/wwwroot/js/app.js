

window.toolsAppDemo = {};

window.toolsAppDemo.doIt = function () {
  console.log("did it");
};

window.toolsAppDemo.ucase = function (someString) {
  return String(someString).toUpperCase();
};

window.toolsAppDemo.setFocus = function (control) {
  control.focus();
};

window.toolsAppDemo.setupColorsRefresh = function (dotNetHelper) {

  console.log("setup colors refresh");

  $("#refresh-colors-button").click(function () {
    console.log("called refresh colors button");
    return dotNetHelper.invokeMethodAsync("All").then(colors => console.log(colors));
  });

};


//if (window.confirm("Are you sure you want to do this?")) {
//  console.log("yes, i do");
//} else {
//  console.log("no, i don't");
//}