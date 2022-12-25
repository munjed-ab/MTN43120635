<%@ Page Title="Sign Up" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="SignUp.aspx.cs" Inherits="MTN.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="css/style.css" rel="stylesheet" />
    <script src="js/signup.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section id="signUpForm" class="signUpForm">
        <div class="container">
            <div class="">
                <div class="">
                    <h2><span class="primary-text">Sign</span> Up </h2>
                    <br>
                    <p>Please use this form to Sign Up</p>
                        <div style="padding-top: 10px;">
                        <asp:DropDownList class="signbox" name="surname"  ID="surname" runat="server">
                            <asp:ListItem text="Surename" Value="0"></asp:ListItem>
                            <asp:ListItem text="Mr." Value="1"></asp:ListItem>
                            <asp:ListItem text="Ms." Value="2"></asp:ListItem>
                            <asp:ListItem text="Miss" Value="3"></asp:ListItem>
                            <asp:ListItem text="Gentlemen" Value="4"></asp:ListItem>
                        </asp:DropDownList>
                        </div>

                   
                        <div>
                            <label for="fname">First Name</label><br> 
                            <asp:TextBox class="signbox" name="fname" ID="fname" OnTextChanged="checkName"  placeholder="First Name" runat="server" AutoPostBack="true"></asp:TextBox>
                        </div>
                        <div style="font-weight:100;color:rgb(133, 163, 0)"  >the first name should be capitalize ex: Ahmad</div>
                        <div >
                            <label for="lname">Last Name</label><br>
                            <asp:TextBox class="signbox" name="lname" ID="lname"   placeholder="Last Name" runat="server" OnTextChanged="checkName" AutoPostBack="true"></asp:TextBox>
                        </div>
                        <div style="font-weight:100;color:rgb(133, 163, 0)"  >the last name should be capitalize ex: Khaled</div>
                        <div >
                            <label for="username">Username</label><br>
                            <asp:TextBox class="signbox"  name="username" ID="username"  placeholder="User Name" runat="server"></asp:TextBox>
                        </div>
                        <div>
                            <label for="age">Age</label><br>
                            <asp:TextBox class="signbox" name="age" ID="age"  placeholder="Age" runat="server"  TextMode="Number" MaxLength="2"></asp:TextBox>
                        </div>
                        <div style="font-weight:100;color:rgb(133, 163, 0)"  >age must be over 14</div>
                        <div>
                            <label for="number">Number</label><br>
                            <asp:TextBox class="signbox"  name="number" ID="number"  placeholder="Number" runat="server" OnTextChanged="checkNumber" AutoPostBack="true"  TextMode="Number"  MaxLength="13"></asp:TextBox>
                        </div>
                        <div style="font-weight:100;color:rgb(133, 163, 0)"  >the number must start with 963</div>
                        <div>
                            <label for="city">City</label><br>
                            <asp:TextBox class="signbox" name="city" ID="city"  placeholder="City" runat="server"></asp:TextBox>
                        </div>
                        <div>
                            <label for="email">Email</label><br>
                             <asp:TextBox class="signbox"  name="email" ID="email"   placeholder="email@example.com" runat="server"  TextMode="Email"></asp:TextBox>                           
                        </div>
                        <div>
                            <label for="password">Password</label><br>
                            <asp:TextBox class="signbox" name="password" ID="password"  placeholder="password" runat="server"   TextMode="Password"></asp:TextBox>
                        </div>
                        <div style="font-weight:100;color:rgb(133, 163, 0);visibility: visible;"id="imsg"></div>
                        <div>
                            <label for="rpassword">Repeat Password</label><br>
                            <asp:TextBox class="signbox"  name="rpassword" ID="rpassword"  placeholder="repeat password" runat="server"   TextMode="Password"></asp:TextBox>
                        </div>
                        <div>
                            <label for="terms">I agree to the terms and conditions</label>
                            <asp:CheckBox type="checkbox" ID="terms" name="terms" runat="server" required="required" />
                        </div>
                        <br>
                        <div>
                            <asp:Button OnClick="Button_Click" class="signupbtn"  ID="button" name="button" runat="server" Text="Sign Up" Font-Bold="True"  UseSubmitBehavior="false" />
                        </div>

                </div>
                
            </div>
        </div>
    </section>
    <script src="js/signup.js"></script>
</asp:Content>
