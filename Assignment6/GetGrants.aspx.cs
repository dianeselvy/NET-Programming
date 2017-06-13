using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class GetGrants : System.Web.UI.Page
{
    GrantReference.GrantServiceClient sc =
        new GrantReference.GrantServiceClient();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
            FillPersonList();
    }

    protected void UserDropDownList_SelectedIndexChanged(object sender, EventArgs e)
    {
        GrantReference.GrantRequest[] grants =
            sc.GetGrantsByPerson(UserDropDownList.SelectedItem.Text);
        GridView1.DataSource = grants;
        GridView1.DataBind();
    }

    protected void FillPersonList()
    {
        string[] people = sc.GetPeople();
        UserDropDownList.DataSource = people;
        UserDropDownList.DataBind();
        ListItem item = new ListItem("Choose User");
        UserDropDownList.Items.Insert(0, item);
    }
}
