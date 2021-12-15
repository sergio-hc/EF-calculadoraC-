using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        int a = Convert.ToInt32(TextBox1.Text);
        int b = Convert.ToInt32(TextBox2.Text);
        int r;

        ClassLibrary1.Class1 c1 = new ClassLibrary1.Class1();
        r = c1.suma(a, b);
        TextBox3.Text = r.ToString();
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        int a = Convert.ToInt32(TextBox1.Text);
        int b = Convert.ToInt32(TextBox2.Text);
        int r;

        ClassLibrary1.Class2 c2 = new ClassLibrary1.Class2();
        r = c2.resta(a, b);
        TextBox3.Text = r.ToString();
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        int a = Convert.ToInt32(TextBox1.Text);
        int b = Convert.ToInt32(TextBox2.Text);
        int r;

        ClassLibrary1.Class3 c3 = new ClassLibrary1.Class3();
        r = c3.multipli(a, b);
        TextBox3.Text = r.ToString();
    }

    protected void Button4_Click(object sender, EventArgs e)
    {
        int a = Convert.ToInt32(TextBox1.Text);
        int b = Convert.ToInt32(TextBox2.Text);
        int r;

        ClassLibrary1.Class4 c4 = new ClassLibrary1.Class4();
        r = c4.div(a, b);
        TextBox3.Text = r.ToString();
    }
}