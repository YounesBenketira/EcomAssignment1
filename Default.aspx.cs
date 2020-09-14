using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

namespace EcomAssignment1
{
    public partial class Default : System.Web.UI.Page
    {
        private int slideShowImageIndex = 2;

        protected void Page_Load(object sender, EventArgs e)
        {
            switch (slideShowImageIndex)
            {
                case 0: // Monkey
                    imgHomeImage.ImageUrl = "~/Images/elephants.jpg";
                    slide1.BackColor = System.Drawing.Color.OrangeRed;
                    break;
                case 1:
                    imgHomeImage.ImageUrl = "~/Images/wierdDeers.jpg";
                    slide2.BackColor = System.Drawing.Color.OrangeRed;
                    break;
                case 2:
                    imgHomeImage.ImageUrl = "~/Images/Monkey.jpg";
                    slide3.BackColor = System.Drawing.Color.OrangeRed;
                    break;
                default:
                    break;
            }

            // Card labels
            Label[] cardLabels = new Label[] { cardHeader0, cardHeader1, cardHeader2, cardTitle0, cardTitle1, cardTitle2, cardDesc0, cardDesc1, cardDesc2 };
            for(int i = 0; i < 3; i++)
            {
                WebText cardText = WebText.RetrieveText(i + 1);
                cardLabels[i].Text = cardText.Header;
                cardLabels[i + 3].Text = cardText.Title;
                cardLabels[i + 6].Text = cardText.Desc;
            }

            // Main Title
            WebText homeText = WebText.RetrieveText(4);
            labelHomeImage.Text = homeText.Header;
            labelHomeImage2.Text = homeText.Title;
            titleDesc.Text = homeText.Desc;

        }
        protected void Page_Unload(object sender, EventArgs e)
        {
            WebText.DisposeTextDatabase();
        }

        protected void SlideOnePressed(object sender, EventArgs e)
        {
            imgHomeImage.ImageUrl = "~/Images/elephants.jpg";
            slide1.BackColor = System.Drawing.Color.OrangeRed;
            slide2.BackColor = System.Drawing.Color.White;
            slide3.BackColor = System.Drawing.Color.White;
        }

        protected void SlideTwoPressed(object sender, EventArgs e)
        {
            imgHomeImage.ImageUrl = "~/Images/wierdDeers.jpg";
            slide2.BackColor = System.Drawing.Color.OrangeRed;
            slide1.BackColor = System.Drawing.Color.White;
            slide3.BackColor = System.Drawing.Color.White;
        }

        protected void SlideThreePressed(object sender, EventArgs e)
        {
            imgHomeImage.ImageUrl = "~/Images/Monkey.jpg";
            slide3.BackColor = System.Drawing.Color.OrangeRed;
            slide2.BackColor = System.Drawing.Color.White;
            slide1.BackColor = System.Drawing.Color.White;
        }
    }
}