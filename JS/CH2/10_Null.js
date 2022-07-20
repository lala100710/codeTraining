console.log(100 == "100"); //true  先做轉換
console.log(100 === "100"); //false 反之

console.log(null == undefined); //true
console.log(null === undefined); //false

var i = null;
i += 1; //i有轉成0 後再進行+
console.log(i);

console.log(Number(null)); //0 強制轉換
console.log(0 == null); //false  null / undefined 例外 不會強制轉換
