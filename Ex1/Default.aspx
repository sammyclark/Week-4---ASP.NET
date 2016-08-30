<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.12.4/jquery.min.js"></script>
    <script src="http://ajax.aspnetcdn.com/ajax/jQuery/jquery-1.12.4.min.js"></script>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>My first ASP.NET Web Forms Page</h1>
        <asp:Label ID="Label1" runat="server" Text="Please type in your name: "></asp:Label>
        <asp:TextBox ID="TextBoxName" runat="server"></asp:TextBox>
        <asp:Button ID="ButtonName" runat="server" Text="Click me" OnClick="ButtonName_Click" />
        <br />
        <br />
        <asp:Label ID="LabelNameOutput" runat="server" Text=""></asp:Label>
        <br />
        <br />
        <asp:Label ID="LabelCheckbox" runat="server" Text="Please check or uncheck the box"></asp:Label>
        <br />
        <br />
        <asp:CheckBox ID="CheckBox1" runat="server" />
        <br />
        <br />
        <asp:Button ID="CheckboxButton" runat="server" Text="Check box button" OnClick="CheckboxButton_Click" />
        <br />
        <br />
        <asp:Label ID="Checkboxoutput" runat="server" Text=""></asp:Label>
        <br />
        <br />
        <asp:Label ID="LabelRadio" runat="server" Text="Please click the radio button"></asp:Label>
        <br />
        <br />
        <asp:RadioButton ID="RadioButton1" runat="server" />
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="RadioButton Button" OnClick="Button1_Click" />
        <br />
        <br />
        <asp:Label ID="LabelRadioOutput" runat="server" Text=""></asp:Label>
        <br />
        <br />
        <asp:Label ID="ListLabel" runat="server" Text="Please click one of the radio buttons in the list"></asp:Label>
        <br />
        <br />
        <asp:RadioButtonList ID="RadioButtonList1" runat="server">
            <asp:ListItem>Radio Button 1</asp:ListItem>
            <asp:ListItem>Radio Button 2</asp:ListItem>
            <asp:ListItem>Radio Button 3</asp:ListItem>
        </asp:RadioButtonList>
        <br />
        <br />
        <asp:Button ID="RBListButton" runat="server" Text="RadioButton List Button" OnClick="RBListButton_Click" />
        <br />
        <br />
        <asp:Label ID="RBoutput" runat="server" Text=""></asp:Label>
        <br />
        <br />
        <h1>Crib sheet examples</h1>
        <asp:LinkButton ID="LinkButton1" runat="server" link href="https://justit.itslearning.com/">This is a link</asp:LinkButton>
        <br />
        <br />
        <p>Click the image to go to a website</p>
        <br />
        <asp:HyperLink ID="HyperLink1" runat="server" imageurl="http://i1.mirror.co.uk/incoming/article7731571.ece/ALTERNATES/s298/Pokemon-charmander.png" NavigateUrl = "https://justit.itslearning.com/"></asp:HyperLink>
        <br />
        <br />
        <p>This is a multiline textbox</p>
        <br />
        <asp:TextBox ID="TextBox1" runat="server" TextMode="MultiLine"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button2" runat="server" Text="Text box button" OnClick="Button2_Click" />
        <br />
        <br />
        <asp:Label ID="TextboxOutput" runat="server" Text=""></asp:Label>
        <br />
        <p>Please enter an email address</p>
        <br />
        <asp:TextBox ID="EmailInput" runat="server"></asp:TextBox>
        <asp:Button ID="EmailButton" runat="server" Text="Email Button" OnClick="EmailButton_Click" />
        <br />
        <br />
        <asp:Label ID="ValidEmail" runat="server" Text=""></asp:Label>
        <asp:CustomValidator ID="CustomValidator1" runat="server" ErrorMessage="This is not a valid email. Please use an email address that contains an @ symbol"></asp:CustomValidator>
        <br />
        <p>This is a calendar control</p>
        <br />
        <asp:Calendar ID="Calendar1" runat="server" OnSelectionChanged="Calendar1_SelectionChanged"></asp:Calendar>
        <br />
        <asp:Label ID="CalLabel" runat="server" Text=""></asp:Label>
        <br />
        <p>Choose your favourite language from the drop down list</p>
        <br />
        <asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem>Java</asp:ListItem>
            <asp:ListItem>C#</asp:ListItem>
            <asp:ListItem Value="Visual Basic">Visual Basic</asp:ListItem>
        </asp:DropDownList>
        <br />
        <asp:Button ID="DDList" runat="server" Text="Go" OnClick="DDList_Click" />
        <asp:Label ID="DDLabel" runat="server" Text=""></asp:Label>
        <br />
        <br />
        <p>Select all the ice creams you like from this list</p>
        <br />
        <asp:CheckBoxList ID="CheckBoxList1" runat="server">
            <asp:ListItem>Chocolate</asp:ListItem>
            <asp:ListItem>Vanilla</asp:ListItem>
            <asp:ListItem>Raspberry</asp:ListItem>
            <asp:ListItem>Coconut</asp:ListItem>
        </asp:CheckBoxList>
        <br />
        <asp:Button ID="FaveAdd" runat="server" Text="Add faves" OnClick="FaveAdd_Click" />
        <br />
        <asp:Label ID="Faves" runat="server" Text=""></asp:Label>
    </div>
    </form>
</body>
</html>
