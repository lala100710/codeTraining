for(let i=0;i<5;i++){
    for(let j=0;j<4;j++){
        console.log(i,j);
    }
}
//===================================
for(let i=0;i<5;i++){
    for(let j=0;j<4;j++){
        if(j==2)break;
        console.log(i,j);
    }
}
//===================================
xxx:for(let i=0;i<5;i++){
    for(let j=0;j<4;j++){
        if(j==2)break xxx;
        console.log(i,j);
    }
}
//===================================
xxx:
// console.log(1);
for(let i=0;i<5;i++){
    for(let j=0;j<4;j++){
        if(j==2)break xxx;
        console.log(i,j);
    }
}

