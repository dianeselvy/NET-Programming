using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{

    string[,] books = new string[5, 2];
    protected void Page_Load(object sender, EventArgs e)
    {

        books[0, 0] = "John Steinbeck";
        books[0, 1] = "Grapes of Wrath";
        books[1, 0] = "Ray Bradbury";
        books[1, 1] = "The Martian Chronicles";
        books[2, 0] = "Isaac Asimov";
        books[2, 1] = "iRobot";
        books[3, 0] = "JRR Tolkien";
        books[3, 1] = "The Hobbit";
        books[4, 0] = "Ray Bradbury";
        books[4, 1] = "Something Wicked This Way Comes";

        if(IsPostBack==true)
        FillAuthor();
    
    }

    protected void FillAuthor()
    {
        for (int i = 0; i<5; i++)
        {
            AuthorsDropDownList.Items.Add(books[i, 0]);
        }
        ListItem item = new ListItem("Choose an author");
        AuthorsDropDownList.Items.Insert(0, item);
    }

    protected void AuthorsDropDownList_SelectedIndexChanged(object sender, EventArgs e)
    {
        ResultLabel.Text = "";
        string author;
        author = AuthorsDropDownList.SelectedItem.Text;
        for(int i = 0; i < 5; i++)
        {
            if(books[i,0].Equals(author))
            {
                ResultLabel.Text += books[i, 1] + "<br />";
            }
        } 
    }
}