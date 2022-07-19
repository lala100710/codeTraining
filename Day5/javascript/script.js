
        function btnOk_Click(){
            var n=parseInt(document.getElementById("txtN").value);
            var d1=document.getElementById("div1");
            d1.innerHTML="";
            for(var i=0;i<=n;i++){
                for(var j=1;j<=i;j++)
                    d1.innerHTML+="*";
                 d1.innerHTML+="<br />";
            }
        }
