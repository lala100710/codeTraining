let i=2**53;
console.log(i);
console.log(i+1);
//Cannot mix BigInt and other types, use explicit conversions
// console.log(BigInt(i)+1);
console.log(BigInt(i)+BigInt(1)); 
console.log(BigInt(i)+1n);

var j=9007199254740993;
console.log(j);
var m=9007199254740993n;
console.log(m);