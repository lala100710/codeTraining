let i=0,j=0;
console.log(100,++i,j++);
console.log(200,i,j);
//==================================================
let y="0";
y+=1;
console.log(y);//01
//==================================================
var v="0";
v++;
console.log(v);//1
//==================================================
console.log(true && true);
console.log(true &&false);
console.log(true ||false);
console.log(false ||false);
console.log(!true);
//==================================================
//帶入boolean函式
console.log(0 || 1);//帶入boolean 函式 0是false 1是true
console.log(null || "aaa");//aaa
console.log("aaa" || null );
console.log(Bolean(0));//false
console.log(Bolean(1)); //true
console.log(Bolean(null));//false
console.log(Bolean("aaa"));//true
//==================================================
var ia;
ia=ia||100;
console.log(ia+200);
//==================================================
var c=50;
var c=c||100;
console.log(c+200);