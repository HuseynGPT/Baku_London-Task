using Baku_London.Properties;

namespace Baku_London
{
    public partial class Form1 : Form
    {

        Label clockForBaku = new();
        Label clockForLondon = new();

        public Form1()
        {
            InitializeComponent();
        }


        private void Baku_Click(object sender, EventArgs e)
        {
            clockForLondon.Visible = false;
            clockForBaku.Visible = true;
            this.Text = "Baku Clock";

            BackgroundImage = Resources.aze_flaq_for_bvackgroun;
            clockForBaku.Text = DateTime.Now.ToString("hh:mm:ss");
            clockForBaku.Location = new(button1.Location.X, button1.Location.Y - 40);
            clockForBaku.Size = new(button1.Size.Width, button1.Size.Height);
            clockForBaku.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Controls.Add(clockForBaku);


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void London_Click(object sender, EventArgs e)
        {
            clockForBaku.Visible = false;
            clockForLondon.Visible = true;
            this.Text = "London Clock";
            BackgroundImage = Resources.LONDON_IMAGE_FOR_TASK;
            clockForLondon.Text = DateTime.Now.ToString("hh:mm:ss");
            clockForLondon.Location = new(button2.Location.X, button2.Location.Y - 40);
            clockForLondon.Size = new(button1.Size.Width, button1.Size.Height);
            clockForLondon.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Controls.Add(clockForLondon);

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.clockForBaku.Text = DateTime.Now.ToString("HH:mm:ss");

        }


        private void timer2_Tick(object sender, EventArgs e)
        {
            this.clockForLondon.Text = DateTime.Now.AddHours(-3).ToString("HH:mm:ss");
        }
    }
}