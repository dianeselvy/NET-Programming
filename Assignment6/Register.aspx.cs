using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Register : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void SubmitButton_Click(object sender, EventArgs e)
    {
        string first = FirstNameTextBox.Text;
        string last = LastNameTextBox.Text;
        string email = EmailTextBox.Text;
        string password = ConfirmTextBox.Text;
        string apartment = ApartmentNumberTextBox.Text;
        string city = CityTextBox.Text;
        string state = StateTextBox.Text;
        string zip = ZipTextBox.Text;
        string homePhone = HomeNumberTextBox.Text;
        string workPhone = WorkNumberTextBox.Text;


        GrantReference.GrantServiceClient sc =
            new GrantReference.GrantServiceClient();
        GrantReference.Person pers = new GrantReference.Person();
        pers.PersonLastName = last;
        pers.PersonFirstName = first;
        pers.PersonEmail = email;

        GrantReference.PersonAddress a = new GrantReference.PersonAddress();
        a.PersonAddressApt = apartment;
        a.PersonAddressCity = city;
        a.PersonAddressState = state;
        a.PersonAddressZip = zip;

        GrantReference.Contact c = new GrantReference.Contact();
        c.ContactNumber = homePhone;
        c.ContactNumber = workPhone;


        bool result = sc.RegisterPerson(pers, a, c);
        if (result)
        {
            Response.Redirect("Default.aspx");
        }
        else
        {
            ErrorLabel.Text = "Something went horribly wrong";
        }

    }
}
