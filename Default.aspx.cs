using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;



public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack) 
        {
            loadwords();
        }
       
    }


    //add all properties of images together
    //private Bitmap [] hangImages = {   };
    //assing private int to wring guesses
    private static int wrongGuesses = 0;
    //private int rightGuesses = 0;
    private static string current = "";
    private static string copyCurrent = "";
    private static string[] words;
    private static string[] readText;
    //private string lblword;
    private static List<Button> btn;




    protected void ButtonWord_Click (object sender, EventArgs e)
    {


        btn = new List<Button>()
        {
            Button1, Button2, Button3, Button4, Button5,Button6, Button7, Button8, Button9, Button10, Button11, Button12,
            Button13, Button14, Button15, Button16, Button17, Button18, Button19, Button20, Button21, Button22, Button23,
            Button24, Button25, Button26 }; 
     
        //Button btn = sender as Button;
        //TestWord.Text = "";
        //Enable Alphabet buttons with the press of New Button
        foreach (Button b in btn)
        {
            b.Enabled = true;
           

        }
        SetupWordChoice();

    }


    protected void loadwords()
    {
        char[] delimiterChars = { ',' };

       readText = File.ReadAllLines(System.IO.Path.Combine
           (System.AppDomain.CurrentDomain.BaseDirectory, @"Test/words.txt"));

        words = new string[readText.Length];
        int index = 0;
        foreach (string s in readText)
        {
            string[] line = s.Split(delimiterChars);
            words[index++] = line[0];
        }
        SetupWordChoice();
    }

    protected void SetupWordChoice()
    {
        //making a guess
        wrongGuesses = 0;
        //Image reset, goes back to Image 1
        Image8.Visible = false; Image2.Visible = false; Image3.Visible = false; Image4.Visible = false;
        Image5.Visible = false; Image6.Visible = false; Image7.Visible = false; Image1.Visible = true;

        //reset the final message
      

        // hangImage1.Image = hangImages[wrongGuesses];
        int guessIndex = (new Random()).Next(words.Length); //generates random number for the words 
        current = words[guessIndex];

        TestWord.Text = current;
        //reset the message of results 
        Test2.Text = "";

        //make a copy of a guess
        copyCurrent = "";
        for (int index = 0; index < current.Length; index++)
        {
            copyCurrent += "_";
        }
        displayCopy();

    }
    //display to the label above function
    protected void displayCopy()
    {
        WordResult.Text = "";

        for (int index = 0; index < copyCurrent.Length; index++)
        {
            WordResult.Text += copyCurrent.Substring(index, 1);
            WordResult.Text += " ";
           


        }
    }



    protected void LetterGuessed (object sender, EventArgs e)
    {
        Button choice = sender as Button;
        choice.Enabled = false;

       

        if (current.Contains(choice.Text))
        {
            char[] temp = copyCurrent.ToCharArray();
            char[] find = current.ToCharArray();
            char guessChar = choice.Text.ElementAt(0);

            for (int index = 0; index < find.Length; index++)
            {
                if (find[index] == guessChar)
                {
                    temp[index] = guessChar;
                }
                copyCurrent = new string(temp);


                //change it up to find and display the found letter otherwise 

            }
            displayCopy();
        }
  
        else 
        {
            wrongGuesses++;
            imageCase();

            if(wrongGuesses == 7)
            {
                Test2.Text = "Such a shame, you Lost!";
            }
          
        }

        if (copyCurrent.Equals(current))
        {
            Test2.Text = "Yay, you won!!!";
        }

        TestWord.Text = choice.Text;
    }

    protected void imageCase()
    {
       // if (!Page.IsValid) return;
        switch (wrongGuesses)
        {

            case 1:
                Image1.Visible = false;
                Image2.Visible = true;
                break;
            case 2:
                Image2.Visible = false;
                Image3.Visible = true;
                break;
            case 3:
                Image3.Visible = false;
                Image4.Visible = true;
                break;
            case 4:
                Image4.Visible = false;
                Image5.Visible = true;
                break;
            case 5:
                Image5.Visible = false;
                Image6.Visible = true;
                break;
            case 6:
                Image6.Visible = false;
                Image7.Visible = true;
                break;
            case 7:
                Image7.Visible = false;
                Image8.Visible = true;
                break;
            default:
                break;

        }
    }


    //Form application
    protected void form1_Load(object sender, EventArgs e)
    {
        //ButtonWord();
        SetupWordChoice();
    }

    

}




