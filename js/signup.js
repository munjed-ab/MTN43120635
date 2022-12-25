
var header=document.getElementById("main-header");
window.addEventListener('scroll',function(){
  header.classList.toggle("scrolling", window.scrollY > 0)
})



var button = document.querySelector('.loginbtn');
button.addEventListener('click', () => {
    var element = document.querySelector('.loginbar');
    if (element.style.display === 'block')
    {
        element.style.display = 'none';
    }else{
        element.style.display = 'block';
    }
});


function checkName(id)
{
    dom=document.getElementById(id);
    if(dom.value.search(/^[A-Z][A-Za-z]*$/)!=0)
    {
        alert(`Wrong Input for ${dom.value}`);
        dom.focus();
        dom.select();
        return false;
    }
    return true;
}

function checkNumber()
{
  var nm = document.getElementById('number');  
  if(nm.value.search(/^\(?(963)\)?([0-9]{9})?/)!=0)
  {
      alert("number must start with 963");
      nm.focus();
      nm.select();
      return false;
  } 
  else{
      return true;
  }
  
}


function checkEmail() {
    var email = document.getElementById('email');
    var filter = /^[a-z0-9]+@[a-z]+\.[a-z]{2,3}$/;
    if (!filter.test(email.value)) {
        alert('Please provide a valid email address');
        email.focus;
        
        return false;
    }
}
function ValidateEmail()
{
    var email = document.getElementById('email');
    var mailformat = /^\w+([\.-]?\w+)*@\w+([\.-]?\w+)*(\.\w{2,3})+$/;
    if(email.value.match(mailformat))
    {
        return true;
    }
    else
    {
        alert("You have entered an invalid email address!");
        return false;
    }   
}
function verifyPassword() {  
    var pw = document.getElementById('password').value;  
    if(pw == "") {
       document.getElementById("imsg").style.visibility="visible";  
       document.getElementById("imsg").innerHTML = "Fill the password please!";  
       pw.focus();
       pw.select();
       return false;  
    }  
    if(pw.length < 8) {  
       document.getElementById("imsg").style.visibility="visible";
       document.getElementById("imsg").innerHTML = "Password length must be atleast 8 characters!";  
       pw.focus();
       pw.select();
       return false;  
    }  
    if(pw.length > 15) {  
       document.getElementById("imsg").style.visibility="visible";
       document.getElementById("imsg").innerHTML = "Password length must not exceed 15 characters!";  
       pw.focus();
       pw.select();
       return false;  
    }
    if(pw.search(/^(?=.*[0-9])(?=.*[!@#$%^&*])[a-zA-Z0-9!@#$%^&*]{6,16}$/)!=0)
    {
        document.getElementById("imsg").style.visibility="visible";
        document.getElementById("imsg").innerHTML = "password should contain at least : 1 capital letter ,1 digit";
    }
    else{
        document.getElementById("imsg").style.visibility="hidden";
    }
  } 

  function checkTwoPass()
  {
    var pass1=document.getElementById('password');
    var pass2=document.getElementById('rpassword');
    if(pass1.value!=pass2.value)
    {
        alert("the two passwords does not match, please try again");
        pass2.focus();
        pass2.select();
        return false;
    }
    else{
        return true;
    }
  }
/**




 


*/


