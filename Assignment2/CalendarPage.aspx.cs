using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CalendarPage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Calendar1_SelectionChanged(object sender, EventArgs e)
    {
        string myDate = Calendar1.SelectedDate.ToShortDateString();
        string aprilfools = "4/1/2017";
        string taxday = "4/15/2017";
        string dayofCannabis = "4/20/2017";
        string earthday = "4/22/2017";
        string jellybeanDay = "4/22/2017";
        string beverageday = "5/6/2017";

        if (myDate.Equals(aprilfools))
        {
            Label1.Text = "April Fools!";
            Label2.Text = Calendar1.SelectedDate.ToShortDateString();
        }
        else if (myDate.Equals(taxday))
        {
            Label1.Text = "It's tax day!";
            Label2.Text = Calendar1.SelectedDate.ToShortDateString();
        }
        else if (myDate.Equals(dayofCannabis))
        {
            Label1.Text = "It's 4/20!! 	&#128684;";
            Label2.Text = Calendar1.SelectedDate.ToShortDateString();
        }
        else if (myDate.Equals(earthday))
        {
            Label1.Text = "Happy earth day!";
            Label2.Text = "It's jelllybean day too!!";
        }
        else if (myDate.Equals(beverageday))
        {
            Label2.Text = "It's national beverage day!";
            Label2.Text = Calendar1.SelectedDate.ToShortDateString();
        }
        else
        {
            Label1.Text = Calendar1.SelectedDate.ToShortDateString();
            Label2.Text = Calendar1.SelectedDate.ToShortDateString();
        }
        //Label1.Text = DateTime.Now.ToString();
    }
}