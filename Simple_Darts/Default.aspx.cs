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

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                HideControls();
            }
        }

        protected void startButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nameTextBox.Text))
                return;
            var threeHundred = new Game(nameTextBox.Text);
            nameTextBox.Enabled = false;
            startButton.Enabled = false;
            DisplayControls();
        }

        private void HideControls()
        {
            dart1Label.Visible = false;
            dart1ResultLabel.Visible = false;
            dart1Button.Visible = false;
            dart2Label.Visible = false;
            dart2ResultLabel.Visible = false;
            dart2Button.Visible = false;
            dart3Label.Visible = false;
            dart3ResultLabel.Visible = false;
            dart3Button.Visible = false;
            humanScoreLabel.Visible = false;
            humanScoreResultLabel.Visible = false;
            computerScoreLabel.Visible = false;
            computerScoreResultLabel.Visible = false;
        }

        private void DisplayControls()
        {
            dart1Label.Visible = true;
            dart1ResultLabel.Visible = true;
            dart1Button.Visible = true;
            dart2Label.Visible = true;
            dart2ResultLabel.Visible = true;
            dart2Button.Visible = true;
            dart3Label.Visible = true;
            dart3ResultLabel.Visible = true;
            dart3Button.Visible = true;
            humanScoreLabel.Visible = true;
            humanScoreResultLabel.Visible = true;
            computerScoreLabel.Visible = true;
            computerScoreResultLabel.Visible = true;
        }
    }
}