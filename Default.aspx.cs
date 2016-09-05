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
        //Include post back statement in the load page, to load random words onto the page.
        if (!IsPostBack) 
        {
            loadwords();
        }
    }

    //make private static variables! otherwise its not gonna work
    private static int wrongGuesses = 0;
    private static string current = "";
    private static string copyCurrent = "";
    private static string[] words;
    private static string[] readText;
    private static List<Button> btn;




    protected void ButtonWord_Click (object sender, EventArgs e)
    {

        //Alphabetical buttons are all linked together in the list.
        btn = new List<Button>()
        {
            Button1, Button2, Button3, Button4, Button5,Button6, Button7, Button8, Button9, Button10, Button11, Button12,
            Button13, Button14, Button15, Button16, Button17, Button18, Button19, Button20, Button21, Button22, Button23,
            Button24, Button25, Button26 }; 
     

        //Enable Alphabet buttons with the press of New Button, once its enabled the buttons go grey and aren't allowed to be reused until the new game.
        foreach (Button b in btn)
        { 
            b.Enabled = true; //make sure its set to true
           

        }
        SetupWordChoice(); //return it to word randomly selected.

    }

    //get the words randomly selected from the path file and chnage it to a string, so it can be read by the program.
    protected void loadwords()
    {
        char[] delimiterChars = { ',' }; //all the words are seperated by the comma, and is read by each line, if it's not seperated, the file end up being unrecognized. 

       readText = File.ReadAllLines(System.IO.Path.Combine
           (System.AppDomain.CurrentDomain.BaseDirectory, @"Test/words.txt")); //make sure the file is in correct folder
        //make sure all the spaces and the wording are correct

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
        displayCopy(); //display the correct word

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
        //enable the buttons pressed
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

            }
            displayCopy();
        }
  
        else 
        {
            //if the user guesses the answer wrong, the wrong guess gets incremented and a new picture shows up.
            wrongGuesses++;
            imageCase();

            //user gets 7 guesses until the game finished
            if(wrongGuesses == 7)
            {
                Test2.Text = "Such a shame, you Lost!";
            }
          
        }
        //however, if the user gets the word correct, they win
        if (copyCurrent.Equals(current))
        {
            Test2.Text = "Yay, you won!!!";
        }

        TestWord.Text = choice.Text;
    }

    protected void imageCase()
    {
       // create switch statement, for each image, for every new case, enable previous image
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
        
        SetupWordChoice();
    }

    

}




