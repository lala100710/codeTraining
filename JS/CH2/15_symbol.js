let s=Symbol();
console.log(s, typeof s);

let s2=Symbol("aaa");
let s3=Symbol("aaa");
console.log(s2 ==s3);
console.log(s2,s3);