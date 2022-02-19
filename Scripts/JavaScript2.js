function checkForEmptyFields() {


    var userName = document.getElementById("userNameField").value;
    var password = document.getElementById("passwordField").value;
    if (userName == "" || password == "") {
        alert("Please Enter All Fields");
    }
}
function checkForEmptyFields4() {


    var gumnam = document.getElementById("gumnam").value;
    if (gumnam == "") {
        alert("Please Enter All Fields");
    }
}
function checkForEmptyFields2() {

    var age = document.getElementById("age").value;
    ValidateEmail();
    allownums(age);
    phonenumbers();
}
function ValidateEmail() {
    var email = document.getElementById("email").value;
    if (/^\w+([\.-]?\w+)*@\w+([\.-]?\w+)*(\.\w{2,3})+$/.test(email)) {
        return (true)
    }
    alert("You have entered an invalid email address!")
    return (false)
}
function allownums(a) {

    if (a <= 0 || a >= 100)
        alert("invalid Age")
}
function phonenumbers() {
    var phoneno = /^\(?([0-9]{4})\)?[-]?([0-9]{7})$/;
    var phonenumber = document.getElementById("phonenumber").value;
    if (phonenumber.match(phoneno)) {
        return true;
    }
    else {
        alert("Invalid Phonenumber");
        return false;
    }
}

function checkForEmptyFields3() {


    var type = document.getElementById("test_type").value;
    var name = document.getElementById("test_name").value;
    var amount = document.getElementById("amount").value;
    if (type == "" || name == "" || amount == "") {
        alert("Please Enter All Fields");
    }
}