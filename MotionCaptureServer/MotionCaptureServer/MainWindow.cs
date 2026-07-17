namespace MotionCaptureServer
{
    public partial class MainWindow : Form
    {
        MotionCapture m = new MotionCapture();
        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Window loaded event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainWindow_Load(object sender, EventArgs e)
        {
            UpdatePorts();
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
            string portName = lstCOMPorts.SelectedItem.ToString();
            m.Connect(portName, (data) =>
            {
                Invoke(() => {
                    lblCOMPortStatus.Text = $"Connected to {portName}. Packets received: {m.PacketsReceived}. Last: {data}";
                });
            });
        }
    }
}
