using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeMan
{
    public partial class Bootloader : Form
    {
        public int PercentComplete { get; set; }

        public Bootloader()
        {
            InitializeComponent();

        }

        Task ProcessImport(List<string> data, IProgress<Bootloader> progress)
        {
            int index = 1;
            int totalProgress = data.Count;
            var progressReport = new Bootloader();
            return Task.Run(() =>
            {
                for (int i = 0; i < totalProgress; i++)
                {
                    progressReport.PercentComplete = index++ * 100 / totalProgress;
                    progress.Report(progressReport);
                    Thread.Sleep(15);
                }
            });
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            //Init data
            List<string> list = new List<string>();
            for (int i = 0; i < 1000; i++)
                list.Add(i.ToString());
            lbProcess.Text = "Working...";
            var progressReport = new Progress<Bootloader>();
            progressReport.ProgressChanged += (o, report) =>
            {
                //Update your percentage
                lbProcess.Text = string.Format("{0}%", report.PercentComplete);
                ProgressBar.Value = report.PercentComplete;
                ProgressBar.Update();
                //lbProcess.BackColor = System.Drawing.Color.Transparent;
            };
            //Process import data
            ProcessImport(list, progressReport);
            lbProcess.Text = "Done !!!";
        }

        private void Bootloader_Shown(object sender, EventArgs e)
        {
            ProgressBar.ProgressMaxColor = Main.BTNColor;
            ProgressBar.ProgressMinColor = Main.TableRowColor;
        }

        private void btnEntry_Click(object sender, EventArgs e)
        {

        }
    }
}
