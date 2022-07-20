try {
    //runtime error
    console.log(1);
    console.log(a);
    console.log(2);
} catch (error) {
    console.log("error :"+error.message+new Date()); //錯誤被清除
    throw error; //產生錯誤
}finally{
    console.log("finally");
}
console.log("end");
