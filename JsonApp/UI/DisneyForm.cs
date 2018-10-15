using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JsonApp
{
    public partial class DisneyForm : Form
    {
        public DisneyForm(string path)
        {
            InitializeComponent();
            var deserialise = new GetTheData();
            var jsonData = deserialise.deserialise(path);
            disneyData = jsonData;
        }

        public List<Disney> disneyData { get; set; }

        private void ascBtn_Click(object sender, EventArgs e)
        {
            YearView.Items.Clear();
            var ascList = disneyData.OrderBy(x => x.yr).ToList();
            foreach (var item in ascList)
            {
                var fullDetails = string.Format($"{item.yr}: {item.mv}, {item.rt}, {item.len}");
                YearView.Items.Add(fullDetails);
            } 
        }

        private void descBtn_Click(object sender, EventArgs e)
        {
            YearView.Items.Clear();
            var ascList = disneyData.OrderByDescending(x => x.yr).ToList();
            foreach (var item in ascList)
            {
                var fullDetails = string.Format($"{item.yr}: {item.mv}, {item.rt}, {item.len}");
                YearView.Items.Add(fullDetails);
            }
        }
    }
}
