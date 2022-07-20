var d=new Date();
d.setHours(d.getHours()-4);
var hr=d.getHours();
console.log(hr);

var greeting=hr>12?"午安":"早安";
console.log(greeting);
if(hr>11){
    greeting="午安";
}else{
    greeting="早安";
}
console.log(hr,greeting);