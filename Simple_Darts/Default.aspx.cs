using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dartboard;

namespace Simple_Darts
{
    public partial class Default : System.Web.UI.Page
    {
        Random _random = new Random();

        Dart _dart1 = new Dart(_random);
        Dart _dart2 = new Dart(_random);
        Dart _dart3 = new Dart(_random);

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
            }
        }

        protected void throwButton_Click(object sender, EventArgs e)
        {
            throwResultLabel.Text = $"Dart 1: {_dart1.Throw()}<br/>" +
                                    $"Dart 2: {_dart2.Throw()}<br/>" +
                                    $"Dart 3: {_dart3.Throw()}";
        }
    }
}