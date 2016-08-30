using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Application_Start(object sender, EventArgs e)
    {
        string JQueryVer = "1.7.1";
        ScriptManager.ScriptResourceMapping.AddDefinition("jquery", new ScriptResourceDefinition
        {
            Path = "~/Scripts/jquery-" + JQueryVer + ".min.js",
            DebugPath = "~/Scripts/jquery-" + JQueryVer + ".js",
            CdnPath = "http://ajax.aspnetcdn.com/ajax/jQuery/jquery-" + JQueryVer + ".min.js",
            CdnDebugPath = "http://ajax.aspnetcdn.com/ajax/jQuery/jquery-" + JQueryVer + ".js",
            CdnSupportsSecureConnection = true,
            LoadSuccessExpression = "window.jQuery"
        });
    }
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void ButtonName_Click(object sender, EventArgs e)
    {
        LabelNameOutput.Text = "Hello, " + TextBoxName.Text;
    }

    protected void CheckboxButton_Click(object sender, EventArgs e)
    {
        if (CheckBox1.Checked)
            Checkboxoutput.Text = "The box is checked";
        else
            Checkboxoutput.Text = "The checkbox is not checked";
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        if (RadioButton1.Checked)
            LabelRadioOutput.Text = "The button is checked";
        else
            LabelRadioOutput.Text = "The button is not checked";

    }

    protected void RBListButton_Click(object sender, EventArgs e)
    {
        if (RadioButtonList1.SelectedItem != null)
            RBoutput.Text = RadioButtonList1.SelectedItem.Text;
        else
            RBoutput.Text = "No button has been seleceted";
           
    }


    protected void Button2_Click(object sender, EventArgs e)
    {
        TextboxOutput.Text = "You have typed " + TextBox1.Text.Length + " characters"; 
    }

    protected void EmailButton_Click(object sender, EventArgs e)
    {
        if (EmailInput.Text.Contains("@"))
            ValidEmail.Text = "This is a valid email address";
        else
            /* CustomValidator1.Text = "This is not a valid email. Please use an email address that contains an @ symbol";*/
           ValidEmail.Text = "This is not a valid email. Please use an email address that contains an @ symbol";
    }

    protected void Calendar1_SelectionChanged(object sender, EventArgs e)
    {
        CalLabel.Text = "The selected date is: " + Calendar1.SelectedDate;
    }

    protected void DDList_Click(object sender, EventArgs e)
    {
        DDLabel.Text = "Your favourite language is: " + DropDownList1.SelectedItem.Text;
    }



    protected void FaveAdd_Click(object sender, EventArgs e)
    {
        Faves.Text = ""; 

        foreach (ListItem ice in CheckBoxList1.Items)
        {
            if (ice.Selected == true)
            {
                Faves.Text += "You have selected " + ice + " <br/> ";
                
            }
        }
    }
}