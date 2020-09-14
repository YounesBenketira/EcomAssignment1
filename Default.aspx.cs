using System;
using System.Data;
using System.Data.SqlClient;

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

            // Card example, pulling text from database
            WebText infoCardOne = WebText.RetrieveText(1);
            infoCardHeader.Text = infoCardOne.Header;
            infoCardDesc.Text = infoCardOne.Desc;
            infoCardTitle.Text = infoCardOne.Title;
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