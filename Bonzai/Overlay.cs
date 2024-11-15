using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bonzai
{
    public partial class Overlay : Form
    {
        private System.Windows.Forms.Timer timer;

        public Overlay()
        {
            InitializeComponent();

            timer = new System.Windows.Forms.Timer();
            timer.Interval = 100; // Fetch data every 1 second.
            timer.Tick += async (s, e) => await FetchAPIData.UpdateDataAsync();
            timer.Tick += async (s, e) => await UpdateData();
            timer.Start();
        }

        public async Task UpdateData() 
        {

            if (FetchAPIData.blue_points <= 9)
            {
                BLUESCORE.Text = ("0" + FetchAPIData.blue_points);
            }
            else
            {
                BLUESCORE.Text = FetchAPIData.blue_points.ToString();
            }

            if (FetchAPIData.orange_points <= 9)
            {
                ORANGESCORE.Text = ("0" + FetchAPIData.orange_points);
            }
            else
            {
                ORANGESCORE.Text = FetchAPIData.orange_points.ToString();
            }

            TIME.Text = FetchAPIData.game_clock_display;
        }
    }
}
