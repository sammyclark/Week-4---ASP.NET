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
    }

    protected void submitAns_Click(object sender, EventArgs e)
    {
        {
            foreach (RadioButtonList r in allQuestions)
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

                    if (rightAns == 10)
                    {
                       ansLabel.Text = "Congratulations. You got every answer correct";
                    }
                    else if ((rightAns <= 9) && (rightAns >= 6))
                    {
                        ansLabel.Text = "Well done. You got most of the answers correct";
                    }
                    else if ((rightAns <= 5) && (rightAns >= 3))
                    {
                        ansLabel.Text = "You could brush up a little bit more";
                    }
                    else
                    {
                        ansLabel.Text = "This score is bad and you should feel bad";
                    }
                    // judges your score
                }          
            }
            
        } 

    }

}