var i = 10; //全域變數golbal

function f1() {
  var j = 20; //local
  if (true) {
    var m = 30;
    console.log(1, i, j, m);
  }
  console.log(2, i, j, m);
}
f1();
console.log(3, i, m);
