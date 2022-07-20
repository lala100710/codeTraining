try {
    //runtime error
    console.log(1);
    console.log(a);
    console.log(2);
} catch (error) {
    console.log(error.message); //錯誤被清除
}
console.log("end");
