// "use strict";
console.log(Math.PI);
console.log(Math.sqrt(2));

with(Math){          //使用"use strict"; 無法
    console.log(Math.PI);
    console.log(Math.sqrt(2)); 
}