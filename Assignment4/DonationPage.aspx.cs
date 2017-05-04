using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DonationPage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["userKey"] == null)
        {
            Response.Redirect("Default.aspx");
        }
    }

    protected void SubmitButton_Click(object sender, EventArgs e)
    {
        Community_AssistEntities db = new Community_AssistEntities();
        Donation a = new Donation();
        DonationTextBox.Text = DonationTextBox.ToString();
        a.DonationAmount = Decimal.Parse(DonationTextBox.Text);

        db.Donations.Add(a);
        db.SaveChanges();

        Response.Redirect("DonationList.aspx");
    }
}