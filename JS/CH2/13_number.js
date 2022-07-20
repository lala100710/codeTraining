var m;
var n = m + 1; //NaN
console.log(n, n == NaN, isNaN(n));
//----------------------------------------------
console.log(Number("")); //0
console.log(Number("100")); //100
console.log(Number("a100")); //NaN
console.log(Number(true)); //1
console.log(Number(false)); //0
console.log(Number(null)); //0
console.log(Number(undefined)); //NaN
console.log(Number(Math)); //NaN
//----------------------------------------------
console.log(parseInt("100.6"));
console.log(parseFloat("100.6"));
//----------------------------------------------
console.log(Number("100px")); //NaN
console.log(parseInt("100px")); //100
console.log(parseInt("A100px")); //NaN

console.log("120" + 50);//12050
console.log("120" - 50);//70
console.log(Number("120") + 50);//170
console.log(+"120" + 50);//170
console.log(120 + +"50");//170
//----------------------------------------------
let s="$2,000";
let i=parseInt(s);
console.log(i); //NaN
//reg101
let reg=new RegExp("[$,]","g");
let regs=/[$,]/g;
let result=s.replace(reg,"");
console.log(result);
console.log(typeof result);
console.log(+result+50);

