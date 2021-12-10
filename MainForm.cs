using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SvgColorCorrector
{
    public partial class MainForm : Form
    {
        private Point m_point = Point.Empty;

        public MainForm()
        {
            InitializeComponent();
            m_progressBar.Maximum = 100;
        }

        private void CorrectTheFile(string path)
        {
            try
            {
                m_progressBar.Value = 5;
              
                XDocument document = XDocument.Load(path);
                if (document == null || document.Nodes().Count() == 0)
                    return;

                foreach (var percentage in ConversionUtils.FixSvgColorElements(document))
                    m_progressBar.Value = percentage;

                string pathToSave = Utils.GetPath<SaveFileDialog>("Please select the directory to save:");

                if (string.IsNullOrWhiteSpace(pathToSave))
                    return;
                
                m_textBoxPath.Text = pathToSave;
                document.Save(pathToSave);
                m_labelStatus.Text = "Completed.";
            }
            catch (Exception ex)
            {
                m_labelStatus.Text = "Error occured!";
                MessageBox.Show(Utils.GetExceptionMessages(ex));
            }
            finally
            {
                m_progressBar.Value = 100;
            }
        }

        private void ConvertFile()
        {
            string path = Utils.GetPath<OpenFileDialog>("Please select the SVG file to correct:");

            if (string.IsNullOrWhiteSpace(path))
                return;

            m_textBoxPath.Text = path;

            CorrectTheFile(path);
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;

            m_point = e.Location;
        }

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (m_point == Point.Empty)
                return;

            int diffX = e.Location.X - m_point.X;
            int diffY = e.Location.Y - m_point.Y;
            Location = new Point(Location.X + diffX, Location.Y + diffY);
        }

        private void MainForm_MouseUp(object sender, MouseEventArgs e) => m_point = Point.Empty;

        private void ButtonStart_Click(object sender, EventArgs e) => ConvertFile();

        private void ButtonExit_Click(object sender, EventArgs e) => Close();
    }
}
