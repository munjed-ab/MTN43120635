<%@ Page Title="Profile" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="userprofile.aspx.cs" Inherits="MTN.userprofile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="css/style.css" rel="stylesheet" />
    <script src="js/signup.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <section class="profile">
        <div class="usrprofile">
            
                <div class="usrphoto">
                    <img src="img/userprofile.png" alt="">
                    <h2 class="usrname">USER</h2>
                </div>
                <div class="usrinfo">
                    
                    <div class="name">
                        <h2>NAME:</h2>
                        
                        <asp:TextBox class="outinfo" ID="TextBox1" runat="server" ReadOnly="True"></asp:TextBox>

                        <asp:TextBox class="outinfo" ID="TextBox2" runat="server" ReadOnly="True"></asp:TextBox>
                    </div>
                    <hr>
                    <div class="usrage">
                        <h2>AGE:</h2>
                        <asp:TextBox class="outinfo" ID="TextBox3" runat="server" ReadOnly="True"></asp:TextBox>
                    </div>
                    <hr>
                    <div class="number">
                        <h2>NUMBER:</h2>
                        <asp:TextBox class="outinfo" ID="TextBox4" runat="server" ReadOnly="True"></asp:TextBox>
                    </div>
                    <hr>
                    <div class="city">
                        <h2>CITY:</h2>
                        <asp:TextBox class="outinfo" ID="TextBox5" runat="server" ReadOnly="True"></asp:TextBox>
                    </div>
                    <hr>
                    <div class="email">
                        <h2>EMAIL:</h2>
                        <asp:TextBox class="outinfo" ID="TextBox6" runat="server" ReadOnly="True"></asp:TextBox>
                    </div>
                    <div class="password">
                        <h2>PASSWORD:</h2>
                        <asp:TextBox class="outinfo" ID="TextBox9" runat="server" ReadOnly="True"></asp:TextBox>
                    </div>
                </div>
        
        </div>
        <div class="billquery">
            <div class="container">
                <h1>ENTER YOUR NUMBER </h1>
                <br>
                <div class="searchbar">
                    <asp:TextBox ID="TextBox7" runat="server" placeholder="search..." ></asp:TextBox>
                    <asp:Button OnClick="findBill" class="signupbtn" ID="Button1" runat="server" Text="Button" UseSubmitBehavior="false" />
                </div>
                <div class="bill">
                    <h2>Your bill is: </h2>
                    <br>
                    <asp:TextBox ID="TextBox8" runat="server" ReadOnly="True" BackColor="Black" ForeColor="#009900"></asp:TextBox>
                </div>
            </div>
        </div>

    </section>

</asp:Content>
