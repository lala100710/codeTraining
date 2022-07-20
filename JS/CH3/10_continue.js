for(let i=0;i<5;i++){
    for(let j=0;j<4;j++){
        console.log(i,j);
    }
}
//===================================
for(let i=0;i<5;i++){
    for(let j=0;j<4;j++){
        if(j==2)continue;
        console.log(i,j);
    }
}
//===================================
xxx:for(let i=0;i<5;i++){
    for(let j=0;j<4;j++){
        if(j==2)continue xxx;
        console.log(i,j);
    }
}

