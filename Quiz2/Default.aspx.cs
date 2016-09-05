using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    private int rightAns = 0;
    //created rightAns variable for correct answer counter
     
    List<RadioButtonList> allQuestions = new List<RadioButtonList>();
    //created list for radio buttons 


    protected void Page_Load(object sender, EventArgs e)
    {
        allQuestions.Add(RadioButtonList1);
        allQuestions.Add(RadioButtonList2);
        allQuestions.Add(RadioButtonList3);
        allQuestions.Add(RadioButtonList4);
        allQuestions.Add(RadioButtonList5);
        allQuestions.Add(RadioButtonList6);
        allQuestions.Add(RadioButtonList7);
        allQuestions.Add(RadioButtonList8);
        allQuestions.Add(RadioButtonList9);
        allQuestions.Add(RadioButtonList10);
        //added radio buttons to list

        inside.Visible = false;
        outside.Visible = false;
        ErrorDisplay.Visible = false;
        //sets the progress panel and error message to invisible before the quiz has been done
    }

    protected void submitAns_Click(object sender, EventArgs e)
    {
        
            foreach (RadioButtonList r in allQuestions)
            {
              if(r.SelectedValue!="")
                    //makes sure that the following if loop cannot be run without selecting radioboxes
                { 
                    if (r.SelectedItem.Value == "correct")
                    {
                    rightAns++;
                    correctLabel.Text = "Correct answers: " + rightAns + " out of 10";  
                    }       
                    else if (r.SelectedItem.Value != "correct")
                    {
                    incorrectLabel.Text += r.SelectedItem + " was incorrect." + "<br/>";
                    // marks the correct answers and informs you which answers are incorrect
                    }
                }
              else
                {
                    ErrorDisplay.Visible = true;
                    ErrorMessage.Text = "You should probably attempt all the questions. <br> Such is the beauty of multiple choice";
                    //snarky panel displays when you haven't answered all the questions
                }
              }

            if (rightAns == 10) 
                        {
                            ansLabel.Text = "Congratulations. You got every answer correct";
                            outside.Visible = true;
                            inside.Visible = true;
                            inside.Style.Add("width", "100px");                         
                        } //everything works but this
                        else if ((rightAns == 9) || (rightAns == 8))
                        {
                            ansLabel.Text = "Well done. You're almost good at this.";
                            outside.Visible = true;
                            inside.Visible = true;
                            inside.Style.Add("width", "75px");
                        }
                        else if ((rightAns <= 7) && (rightAns > 5))
                        {
                            ansLabel.Text = "So close...but so far";
                            outside.Visible = true;
                            inside.Visible = true;
                            inside.Style.Add("width", "75px");
                        }
                        else if (rightAns == 5)
                        {
                            ansLabel.Text = "Exactly half. How mediocre.";
                            outside.Visible = true;
                            inside.Visible = true;
                            inside.Style.Add("width", "50px");
                        }
                        else if ((rightAns < 5) && (rightAns >= 3))
                        {
                            ansLabel.Text = "You should brush up a little bit more";
                            outside.Visible = true;
                            inside.Visible = true;
                            inside.Style.Add("width", "25px");
                        }
                        else if ((rightAns == 1) || (rightAns == 2))
                        {
                            ansLabel.Text = "This score is bad and you should feel bad";
                            outside.Visible = true;
                            inside.Visible = true;
                            inside.Style.Add("width", "10px"); 
                        }        
                        else
                        {
                            ansLabel.Text = "Are you serious? Did you actually get a zero?! Wow!";
                            outside.Visible = true;                                                        
                        }
                        // judges your score (harshly) and displays the progress panel
        } 

    }

