<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InteractiveLyric.aspx.cs" Inherits="InteractiveLyrics.InteractiveLyric" %>

<!DOCTYPE html>
<style>
	.stanza_green {
		color: green;
	}
	.stanza_blue {
		color: blue;
	}
	.stanza_orange {
		color: orange;
	}

</style>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    Today is <asp:Literal ID="LtlDate" runat="server" ></asp:Literal><br />
    <asp:Literal ID="LtlGreeting" runat="server" ></asp:Literal>
		<hr />
		Enter Animals (separated by commas) :
		<asp:TextBox ID="TxtAnimals" runat="server"></asp:TextBox><br />
		Enter Sounds (separated by commas) :
		<asp:TextBox ID="TxtSounds" runat="server"></asp:TextBox><br />

		Text Colour
		<label for="TxtAnimals" class="label">Text Colour:</label>
		<asp:RadioButton ID="RbBlue" runat="server" Text="Blue" GroupName="color" Checked="true"/>
		<asp:RadioButton ID="RbGreen" runat="server" Text="Green" GroupName="color"/>
		<asp:RadioButton ID="RbOrange" runat="server" Text="Orange" GroupName="color"></asp:RadioButton>
		<asp:Button ID="btnGenerate" runat="server" Text="Generate" OnClick="btnGenerate_Click"/>

		<asp:Literal ID="ltlLyrics" runat="server" ></asp:Literal>
		<br />

    </div>
    </form>
</body>
</html>
