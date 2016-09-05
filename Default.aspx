<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    
    <title>Hangman Game</title>
    <meta charset="utf-8"/> 
    <meta name="viewport" content="width=device-width, initial-scale=1"/>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />

</head>
<body>
    <form id="form1" runat="server">
    <div>

        
    <div class="panel panel-heading text-center"><h1>Hangman </h1> </div>
            </div>
       
        <div class="panel panel-heading text-center">
        <asp:Image Visible="true" ID="Image1" runat="server" src="Untitled-1.jpg"  />
        <asp:Image Visible="false" ID="Image2" runat="server" src="Untitled-2.jpg"  />
        <asp:Image Visible="false" ID="Image3" runat="server" src="Untitled-3.jpg"  />
        <asp:Image Visible="false" ID="Image4" runat="server" src="Untitled-4.jpg"  />
        <asp:Image Visible="false" ID="Image5" runat="server" src="Untitled-5.jpg"  />
        <asp:Image Visible="false" ID="Image6" runat="server" src="Untitled-6.jpg"  />
        <asp:Image Visible="false" ID="Image7" runat="server" src="Untitled-7.jpg"  />
        <asp:Image Visible="false" ID="Image8" runat="server" src="Untitled-8.jpg"  />
       
        <br />
        <br />

        <asp:Label ID="WordResult" runat="server" Text="" ></asp:Label>
        <br />
        <asp:Label ID="TestWord" runat="server" Text="TestLetter"></asp:Label>
        <br />
        <asp:Label ID="Test2" runat="server" Text=""></asp:Label>
        <br />
        <br />
        </div>
        <div class="panel panel-heading text-center">
        <asp:Button ID="Button1" runat="server" Text="A" OnCommand="LetterGuessed" />
        <asp:Button ID="Button2" runat="server" Text="B" OnCommand="LetterGuessed" />
        <asp:Button ID="Button3" runat="server" Text="C" OnCommand="LetterGuessed"/>
        <asp:Button ID="Button4" runat="server" Text="D" OnCommand="LetterGuessed"/>
        <asp:Button ID="Button5" runat="server" Text="E" OnCommand="LetterGuessed"/>
        <asp:Button ID="Button6" runat="server" Text="F" OnCommand="LetterGuessed"/>
        <asp:Button ID="Button7" runat="server" Text="G" OnCommand="LetterGuessed"/>
        <asp:Button ID="Button8" runat="server" Text="H" OnCommand="LetterGuessed"/>
        <asp:Button ID="Button9" runat="server" Text="I" OnCommand="LetterGuessed"/>
        <asp:Button ID="Button10" runat="server" Text="J" OnCommand="LetterGuessed"/>
        <asp:Button ID="Button11" runat="server" Text="K" OnCommand="LetterGuessed"/>
        <asp:Button ID="Button12" runat="server" Text="L" OnCommand="LetterGuessed"/>
        <asp:Button ID="Button13" runat="server" Text="M" OnCommand="LetterGuessed"/>
        <br />
        <br />
        <asp:Button ID="Button14" runat="server" Text="N" OnCommand="LetterGuessed"/>
        <asp:Button ID="Button15" runat="server" Text="O" OnCommand="LetterGuessed"/>
        <asp:Button ID="Button16" runat="server" Text="P" OnCommand="LetterGuessed"/>
        <asp:Button ID="Button17" runat="server" Text="Q" OnCommand="LetterGuessed"/>
        <asp:Button ID="Button18" runat="server" Text="R" OnCommand="LetterGuessed"/>
        <asp:Button ID="Button19" runat="server" Text="S" OnCommand="LetterGuessed"/>
        <asp:Button ID="Button20" runat="server" Text="T" OnCommand="LetterGuessed"/>
        <asp:Button ID="Button21" runat="server" Text="U" OnCommand="LetterGuessed"/>
        <asp:Button ID="Button22" runat="server" Text="V" OnCommand="LetterGuessed"/>
        <asp:Button ID="Button23" runat="server" Text="W" OnCommand="LetterGuessed"/>
        <asp:Button ID="Button24" runat="server" Text="X" OnCommand="LetterGuessed"/>
        <asp:Button ID="Button25" runat="server" Text="Y" OnCommand="LetterGuessed"/>
        <asp:Button ID="Button26" runat="server" Text="Z" OnCommand="LetterGuessed"/>
        <br />
        <br />
        <asp:Button ID="ButtonWord" runat="server" Text="New Word" OnCommand="ButtonWord_Click"/>
        <br />
        <br />
       </div>
    </div>
    </form>
</body>
</html>
