<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>The Quiz</h1>
        <p>Question 1</p>
        <asp:RadioButtonList ID="RadioButtonList1" runat="server">
            <asp:ListItem Value="correct">a</asp:ListItem>
            <asp:ListItem>b</asp:ListItem>
            <asp:ListItem>c</asp:ListItem>
            <asp:ListItem>d</asp:ListItem>
            <asp:ListItem>e</asp:ListItem>
        </asp:RadioButtonList>
        <p>Question 2</p>
        <asp:RadioButtonList ID="RadioButtonList2" runat="server">
            <asp:ListItem>a</asp:ListItem>
            <asp:ListItem>b</asp:ListItem>
            <asp:ListItem>c</asp:ListItem>
            <asp:ListItem Value="correct">d</asp:ListItem>
            <asp:ListItem>e</asp:ListItem>
        </asp:RadioButtonList>
        <p>Question 3</p>
        <asp:RadioButtonList ID="RadioButtonList3" runat="server">
            <asp:ListItem>a</asp:ListItem>
            <asp:ListItem>b</asp:ListItem>
            <asp:ListItem Value="correct">c</asp:ListItem>
            <asp:ListItem>d</asp:ListItem>
            <asp:ListItem>e</asp:ListItem>
        </asp:RadioButtonList>
        <p>Question 4</p>
        <asp:RadioButtonList ID="RadioButtonList4" runat="server">
            <asp:ListItem>a</asp:ListItem>
            <asp:ListItem Value="correct">b</asp:ListItem>
            <asp:ListItem>c</asp:ListItem>
            <asp:ListItem>d</asp:ListItem>
            <asp:ListItem>e</asp:ListItem>
        </asp:RadioButtonList>
        <p>Question 5</p>
        <asp:RadioButtonList ID="RadioButtonList5" runat="server">
            <asp:ListItem Value="correct">a</asp:ListItem>
            <asp:ListItem>b</asp:ListItem>
            <asp:ListItem>c</asp:ListItem>
            <asp:ListItem>d</asp:ListItem>
            <asp:ListItem>e</asp:ListItem>
        </asp:RadioButtonList>
        <p>Question 6</p>
        <asp:RadioButtonList ID="RadioButtonList6" runat="server">
            <asp:ListItem>a</asp:ListItem>
            <asp:ListItem>b</asp:ListItem>
            <asp:ListItem>c</asp:ListItem>
            <asp:ListItem>d</asp:ListItem>
            <asp:ListItem Value="correct">e</asp:ListItem>
        </asp:RadioButtonList>
        <p>Question 7</p>
        <asp:RadioButtonList ID="RadioButtonList7" runat="server">
            <asp:ListItem>a</asp:ListItem>
            <asp:ListItem>b</asp:ListItem>
            <asp:ListItem Value="correct">c</asp:ListItem>
            <asp:ListItem>d</asp:ListItem>
            <asp:ListItem>e</asp:ListItem>
        </asp:RadioButtonList>
        <p>Question 8</p>
        <asp:RadioButtonList ID="RadioButtonList8" runat="server">
            <asp:ListItem>a</asp:ListItem>
            <asp:ListItem Value="correct">b</asp:ListItem>
            <asp:ListItem>c</asp:ListItem>
            <asp:ListItem>d</asp:ListItem>
            <asp:ListItem>e</asp:ListItem>
        </asp:RadioButtonList>
        <p>Question 9</p>
        <asp:RadioButtonList ID="RadioButtonList9" runat="server">
            <asp:ListItem>a</asp:ListItem>
            <asp:ListItem>b</asp:ListItem>
            <asp:ListItem>c</asp:ListItem>
            <asp:ListItem Value="correct">d</asp:ListItem>
            <asp:ListItem>e</asp:ListItem>
        </asp:RadioButtonList>
        <p>Question 10</p>
        <asp:RadioButtonList ID="RadioButtonList10" runat="server">
            <asp:ListItem>a</asp:ListItem>
            <asp:ListItem>b</asp:ListItem>
            <asp:ListItem>c</asp:ListItem>
            <asp:ListItem>d</asp:ListItem>
            <asp:ListItem Value="correct">e</asp:ListItem>
        </asp:RadioButtonList>
        <asp:Button ID="submitAns" runat="server" Text="Submit" OnClick="submitAns_Click" />      
        <br />  
        <asp:Label ID="correctLabel" runat="server" Text=""></asp:Label>
        <br />
        <br />
        <asp:Label ID="incorrectLabel" runat="server" Text=""></asp:Label>
        <br />
        <asp:Label ID="ansLabel" runat="server" Text=""></asp:Label>

    </div>
    </form>
</body>
</html>
