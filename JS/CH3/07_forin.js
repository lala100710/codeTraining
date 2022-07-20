var book={title:"js",price:2000};
// console.log(typeof book);//object
// console.log(book.title,book.price);
// console.log(book["title"],book["price"]);
//----------------------------------------------------------
for (const key in book) {
console.log(key,typeof key);
console.log(key,book[key]);
}
//----------------------------------------------------------
var ar=[1,4,3,7,11];

console.log(ar[0]);
for (const key in ar) {
   console.log(key,ar[key]);
}