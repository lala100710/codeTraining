function greeting(inpiut){
    switch (inpiut) {
        case 0:
            console.log("hello");
            break;
        case 1:
            console.log("hi");
        default:
            throw "只接受0,1其中一個";
            break;
    }
}
greeting(0);
greeting(1);
greeting(2);
