<%@ Page Title="Admin Management" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="adminmanagement.aspx.cs" Inherits="MTN.adminmanagement" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
    <link href="css/style.css" rel="stylesheet" />
    <link href="css/flexboxgrid.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!--ADMIN-->
   
    <section class="profile">
        <div class="usrprofile">
                <div class="admphoto">
                    <img src="img/adminprofile.png" alt="">
                    <h2 class="admname">Wellcome, Admin</h2>
                </div>
                <div class="adminfo">
                    
                    <div>
                        <h2>Enter the number :</h2>
                        <asp:TextBox type="number" class="num" ID="num" name="num" runat="server"></asp:TextBox>
                    </div>
                    <hr>
                    <div>
                        <h2>Enter the Bill:</h2>
                        <asp:TextBox type="number" class="billing" ID="billing" name="billing" runat="server"></asp:TextBox>
                    </div>
                    <hr>
                    <div class="billbtn">
                        <asp:Button Enabled="true" OnClick="bill_click" ID="billbtn" runat="server" Text="Bill" Width="50%" ForeColor="Black" Font-Size="X-Large" Font-Bold="True" BorderWidth="0px" BorderStyle="None" BackColor="White" UseSubmitBehavior="False" />
                    </div>
                        
                </div>
        
            </div>
        <div class="usrdata" style="background-color:white">
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" EnableCaching="True" ConflictDetection="OverwriteChanges" ConnectionString="Data Source=DR-BASH;Initial Catalog=master;Integrated Security=True" SelectCommand="select UserName,  UserNumber,  UserBill from UserData ;"></asp:SqlDataSource>
           <div>
               <div>
                   <asp:GridView class="table table-striped table-bordered" ID="GridView1" runat="server" DataSourceID="SqlDataSource1" DataKeyNames="UserName,UserNumber,UserBill" Caption="USER DATA" RowStyle-BorderColor="White" RowStyle-BackColor="RoyalBlue" SortedDescendingHeaderStyle-BackColor="#085EBD" SelectedRowStyle-BackColor="Black" RowStyle-ForeColor="White" RowStyle-BorderStyle="NotSet" HeaderStyle-BackColor="#FFCC00" Font-Bold="True" ForeColor="RoyalBlue"></asp:GridView>
               </div>
           </div>
           

        </div>

        </section>
        
    <script src="js/signup.js"></script>

</asp:Content>
