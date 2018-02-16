using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace AlwaysOnBG
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Timer_Manager objTimer = new Timer_Manager();       
        private void BG_Start_Click(object sender, EventArgs e)
        {
            objTimer.Create_Timer(100, Event_One);
            objTimer.Start(0);
        }

        private void BG_End_Click(object sender, EventArgs e)
        {
            objTimer.Stop(0);
        }

        private void Event_One(object sender, System.Timers.ElapsedEventArgs e)
        {
            Debug.WriteLine("On");
        }

    }
}
