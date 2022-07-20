var ar=[1,3,4,6,7,11];
console.log(Symbol.iterator in ar);//true

for(const i of ar){
    console.log(i);
}
//===================================
var book={title:"js",price:2000};
//console.log(Symbol.iterator in book); //false

for (const i of book) {
    console.log(i);
}
//===================================
var s="hello";
console.log(typeof s); //string
console.log(Symbol.iterator in s);  //true
for (const i of s) { //auto boxing 
    console.log(i);
}
//-----------------------
var s=new String("Hello"); 
console.log(typeof s); //object
console.log(Symbol.iterator in s); //true
for (const i of s) {
    console.log(i);
}