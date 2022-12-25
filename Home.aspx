<%@ Page Title="Home" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="MTN.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
        <%-- CSS--%>
    <link href="css/flexboxgrid.css" rel="stylesheet" />
    <link href="css/style.css" rel="stylesheet" />
    <script src="js/signup.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <!--SHOW-CASE-->
        <section class="showcase" id="showcase">
            <div class="container">
                <div class="ad">
                        <h2>We Need Connection</h2>
                        <p>Lorem ipsum dolor sit amet consectetur adipisicing elit. Et, modi.</p>
                </div>
            </div>
        </section>
    <!--FEATURES-->
    <section class="features" id="features">
        <div class="container">
            <div class="cont">
                <a href="#">
                    <div class="fts">
                        <img src="img/Bulk-SMS.png" alt="Bulk">
                        <h2>Bulk SMS</h2>
                        <p>Reach your audience</p>
                    </div>
                </a>
                <a href="#">
                    <div class="fts">
                        <img src="img/Calculate-your-data.png" alt="calc">
                        <h2>Speed Calculator</h2>
                        <p>Calculate your data</p>
                    </div>
                </a>
                <a href="#">
                    <div class="fts">
                        <img src="img/Reserve-your-number.png" alt="reserve">
                        <h2>Reserve your number</h2>
                        <p>Choose your mobile number</p>
                    </div>
                </a>
            </div>
        </div>
    </section>
    <!--OFFERS-->
    <script src="js/signup.js"></script>
    <section class="offers" id="offers">
        <div class="container">
            <div class="cont">
                <h1>OFFERS</h1>
                <a href="#">
                    <div class="offer">
                        <img src="img/MTN Kiosk.png" alt="kiosk">
                        <h2>MTN Kiosk</h2>
                    </div>
                </a>
                <a href="#">
                    <div class="offer">
                        <img src="img/radio app.jpg" alt="radio">
                        <h2>Radio app</h2>
                    </div>
                </a>
                <a href="#">
                    <div class="offer">
                        <img src="img/website banner-Recovered.jpg" alt="banner">
                        <h2>Website banner-recovered</h2>
                    </div>
                </a>
            </div>
        </div>
    </section>
    <%-- JAVASCRIPT--%>
    <script src="js/signup.js"></script>
</asp:Content>
