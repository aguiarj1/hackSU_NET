// Write your JavaScript code.

var totalCredits = 0;
var classesTaking = new Array();

function myFunction(creditsNum, resName) {
    if (resName.className == "btn btn-outline-primary") {
        classesTaking.push(resName.id);
        totalCredits += creditsNum;
        document.getElementById("demo").innerHTML = totalCredits;
        //document.getElementById("demo1").innerHTML = "Remaining credits you need to take: " + remainCredits;
        document.getElementById(resName.id).setAttribute("class", "btn btn-primary");

    } else {

        //todo remove from array
        var index = classesTaking.indexOf(resName.id);
        if (index != -1) {
            classesTaking.splice(index, 1);
        }



        totalCredits -= creditsNum;
        document.getElementById("demo").innerHTML = totalCredits;
        var remainCredits = 45 - totalCredits;
        //document.getElementById("demo1").innerHTML = "Remaining credits you need to take: " + remainCredits;
        document.getElementById(resName.id).setAttribute("class", "btn btn-outline-primary");
    }
    //req1
    if (classesTaking.includes("physical_database_design_&_opt") && classesTaking.includes("security_in_computing")) {
        document.getElementById("req1").innerHTML = "<del>Need to take Pyhysical Databases and Security</del>";
        //document.getElementById("req1").setAttribute("class", "alert alert-success");
    } else {
        document.getElementById("req1").innerHTML = "Need to take Pyhysical Databases and Security";
    }

    //req2
    if (classesTaking.includes("data_structures_and_algorithms") || classesTaking.includes("comp_system_principles_2") || classesTaking.includes("fund_of_software_engineerring")) {
        document.getElementById("req2").innerHTML = "<del>Need to take one of the following: fund of soft<br /> engineering, comp system principles 2, or data structures and algorithms</del>";
        //document.getElementById("req2").setAttribute("class", "alert alert-success");
    } else {
        //document.getElementById("req2").setAttribute("class", "");
        document.getElementById("req2").innerHTML = "Need to take one of the following: fund of soft<br /> engineering, comp system principles 2, or data structures and algorithms";
    }

}
