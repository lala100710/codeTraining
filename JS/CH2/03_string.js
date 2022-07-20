"use strict";
var i = 10;
function f1() {
  j = 20; //如沒進嚴格模式就會變成global 變數
  console.log(1, i, j);
}
f1();
console.log(2, i, j);
