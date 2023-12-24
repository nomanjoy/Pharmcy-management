using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_Management_Application
{
    public partial class Dashboard : Form
    {
        //Fields
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
        //Constructor
        public Dashboard()
        {
            InitializeComponent();
            random = new Random();
        }

        //Methods
        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.Colorlist.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.Colorlist.Count);
            }
            tempIndex = index;
            string color = ThemeColor.Colorlist[index];
            return ColorTranslator.FromHtml(color);
        }
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Vrinda", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    panelTitleBar.BackColor = color;
                    panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Vrinda", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }




        private void button1_Click_1(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnorders_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btncustomer_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void LogoPannel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnReporting_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btnnotifications_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btnsettings_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        
    }
}
