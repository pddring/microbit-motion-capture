using ScottPlot.Plottables;
using System.Text.RegularExpressions;

namespace MotionCaptureServer
{
    public partial class MainWindow : Form
    {
        MotionCapture m = new MotionCapture();
        public MainWindow()
        {
            InitializeComponent();
        }

        DataStreamer plotY;
        DataStreamer plotZ;
        DataStreamer plotX;

        /// <summary>
        /// Window loaded event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainWindow_Load(object sender, EventArgs e)
        {
            UpdatePorts();
            plotX = graphLiveView.Plot.Add.DataStreamer(100);
            plotY = graphLiveView.Plot.Add.DataStreamer(100);
            plotZ = graphLiveView.Plot.Add.DataStreamer(100);
        }

        /// <summary>
        /// Updates the list of available COM ports in the lstCOMPorts ListBox.
        /// </summary>
        public void UpdatePorts()
        {
            lstCOMPorts.Items.Clear();
            lstCOMPorts.Items.AddRange(m.DetectMicrobitPorts());
        }

        /// <summary>
        /// Update ports button event hander.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCOMRefresh_Click(object sender, EventArgs e)
        {
            UpdatePorts();
        }

        private void btnCOMConnect_Click(object sender, EventArgs e)
        {
            if (lstCOMPorts.SelectedItem == null)
            {
                lblCOMPortStatus.Text = "Please select a COM port to connect.";
                return;
            }
            string portName = lstCOMPorts.SelectedItem.ToString();
            Regex r = new Regex("([0-9A-Z]+) ([0-9-]+) ([0-9-]+) ([0-9-]+)");
            try
            {
                m.Connect(portName, (data) =>
                {
                    Match match = r.Match(data);
                    if(match.Success) {
                        
                        string id = match.Groups[1].Value;
                        int x = int.Parse(match.Groups[2].Value);
                        int y = int.Parse(match.Groups[3].Value);
                        int z = int.Parse(match.Groups[4].Value);
                        Invoke(() =>
                        {
                            lblCOMPortStatus.Text = $"Connected to {portName}. Packets received: {m.PacketsReceived}. Last: {data}";
                            plotX.Add(x);
                            plotY.Add(y);
                            plotZ.Add(z);
                            graphLiveView.Refresh();
                        });
                    } else {
                        Invoke(() => {
                            lblCOMPortStatus.Text = $"Invalid data on {portName}: {data}";
                        });
                    }
                    
                });
                lblCOMPortStatus.Text = $"Connected to {portName}";
            }
            catch (Exception ex)
            {
                lblCOMPortStatus.Text = $"Error connecting to {portName}: {ex.Message}";
            }
        }
    }
}
