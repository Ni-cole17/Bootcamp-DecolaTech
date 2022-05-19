var mode = true;

function Change_mode(){
    if(mode == true){
        console.log("Aqui");
        btn = document.getElementById("dark-mode");
        footer = document.getElementById("foot-dark-mode");
        btn.innerHTML = "Light Mode";
        document.body.style.backgroundColor = "black";
        document.getElementById("page-title").innerHTML = "Dark Mode ON";
        btn.setAttribute("id","light-mode");
        footer.setAttribute("id","foot-light-mode");
        document.getElementById("page-title").style.color = "white";
        mode = false
    }
    else{
        btn = document.getElementById("light-mode");
        btn.innerHTML = "Dark Mode";
        footer = document.getElementById("foot-light-mode");
        document.body.style.backgroundColor = "#e5e8e8";
        document.getElementById("page-title").innerHTML = "Light Mode ON";
        btn.setAttribute("id","dark-mode");
        footer.setAttribute("id","foot-dark-mode");
        document.getElementById("page-title").style.color = "#4e545c";
        mode = true
    }
}