"use strict"; //嚴格模式 避免不小心疏忽
var i = 10;
var i = 20;
console.log(i); //重複宣告 就算進入嚴格模式也不會error
//==============================
("use strict");
var i;
console.log(i);
//==============================
("use strict");
console.log(1, m);
var m = 10;
console.log(2, m);
