namespace MotionCaptureServer
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabWindow = new TabControl();
            tabMicroBit = new TabPage();
            tableLayoutPanel1 = new TableLayoutPanel();
            lblCOMPortStatus = new Label();
            label3 = new Label();
            label2 = new Label();
            lstCOMPorts = new ListBox();
            label1 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnCOMConnect = new Button();
            btnCOMDisconnect = new Button();
            btnCOMRefresh = new Button();
            tabGraphs = new TabPage();
            graphLiveView = new ScottPlot.WinForms.FormsPlot();
            tabWindow.SuspendLayout();
            tabMicroBit.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            tabGraphs.SuspendLayout();
            SuspendLayout();
            // 
            // tabWindow
            // 
            tabWindow.Controls.Add(tabMicroBit);
            tabWindow.Controls.Add(tabGraphs);
            tabWindow.Dock = DockStyle.Fill;
            tabWindow.Location = new Point(0, 0);
            tabWindow.Name = "tabWindow";
            tabWindow.SelectedIndex = 0;
            tabWindow.Size = new Size(1024, 632);
            tabWindow.TabIndex = 0;
            // 
            // tabMicroBit
            // 
            tabMicroBit.Controls.Add(tableLayoutPanel1);
            tabMicroBit.Location = new Point(4, 24);
            tabMicroBit.Name = "tabMicroBit";
            tabMicroBit.Padding = new Padding(3);
            tabMicroBit.Size = new Size(1016, 604);
            tabMicroBit.TabIndex = 0;
            tabMicroBit.Text = "Micro:bit connection";
            tabMicroBit.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15.01272F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 84.98728F));
            tableLayoutPanel1.Controls.Add(lblCOMPortStatus, 1, 2);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(lstCOMPorts, 1, 0);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1010, 598);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // lblCOMPortStatus
            // 
            lblCOMPortStatus.AutoSize = true;
            lblCOMPortStatus.Location = new Point(154, 583);
            lblCOMPortStatus.Name = "lblCOMPortStatus";
            lblCOMPortStatus.Size = new Size(96, 15);
            lblCOMPortStatus.TabIndex = 6;
            lblCOMPortStatus.Text = "No data received";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 583);
            label3.Name = "label3";
            label3.Size = new Size(32, 15);
            label3.TabIndex = 5;
            label3.Text = "Stats";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 544);
            label2.Name = "label2";
            label2.Size = new Size(115, 15);
            label2.TabIndex = 2;
            label2.Text = "Connection controls";
            // 
            // lstCOMPorts
            // 
            lstCOMPorts.Dock = DockStyle.Fill;
            lstCOMPorts.FormattingEnabled = true;
            lstCOMPorts.ItemHeight = 15;
            lstCOMPorts.Location = new Point(154, 3);
            lstCOMPorts.Name = "lstCOMPorts";
            lstCOMPorts.Size = new Size(853, 538);
            lstCOMPorts.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(87, 15);
            label1.TabIndex = 1;
            label1.Text = "USB COM port:";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.Controls.Add(btnCOMConnect);
            flowLayoutPanel1.Controls.Add(btnCOMDisconnect);
            flowLayoutPanel1.Controls.Add(btnCOMRefresh);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(154, 547);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(853, 33);
            flowLayoutPanel1.TabIndex = 4;
            // 
            // btnCOMConnect
            // 
            btnCOMConnect.Location = new Point(3, 3);
            btnCOMConnect.Name = "btnCOMConnect";
            btnCOMConnect.Size = new Size(122, 27);
            btnCOMConnect.TabIndex = 3;
            btnCOMConnect.Text = "&Connect";
            btnCOMConnect.UseVisualStyleBackColor = true;
            btnCOMConnect.Click += btnCOMConnect_Click;
            // 
            // btnCOMDisconnect
            // 
            btnCOMDisconnect.Location = new Point(131, 3);
            btnCOMDisconnect.Name = "btnCOMDisconnect";
            btnCOMDisconnect.Size = new Size(122, 27);
            btnCOMDisconnect.TabIndex = 4;
            btnCOMDisconnect.Text = "&Disconnect";
            btnCOMDisconnect.UseVisualStyleBackColor = true;
            // 
            // btnCOMRefresh
            // 
            btnCOMRefresh.Location = new Point(259, 3);
            btnCOMRefresh.Name = "btnCOMRefresh";
            btnCOMRefresh.Size = new Size(122, 27);
            btnCOMRefresh.TabIndex = 5;
            btnCOMRefresh.Text = "&Refresh";
            btnCOMRefresh.UseVisualStyleBackColor = true;
            btnCOMRefresh.Click += btnCOMRefresh_Click;
            // 
            // tabGraphs
            // 
            tabGraphs.Controls.Add(graphLiveView);
            tabGraphs.Location = new Point(4, 24);
            tabGraphs.Name = "tabGraphs";
            tabGraphs.Padding = new Padding(3);
            tabGraphs.Size = new Size(1016, 604);
            tabGraphs.TabIndex = 1;
            tabGraphs.Text = "Motion Capture";
            tabGraphs.UseVisualStyleBackColor = true;
            // 
            // graphLiveView
            // 
            graphLiveView.Dock = DockStyle.Fill;
            graphLiveView.Location = new Point(3, 3);
            graphLiveView.Name = "graphLiveView";
            graphLiveView.Size = new Size(1010, 598);
            graphLiveView.TabIndex = 0;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1024, 632);
            Controls.Add(tabWindow);
            Name = "MainWindow";
            Text = "Microbit Motion Capture Streamer";
            Load += MainWindow_Load;
            tabWindow.ResumeLayout(false);
            tabMicroBit.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            tabGraphs.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabWindow;
        private TabPage tabMicroBit;
        private TabPage tabGraphs;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label2;
        private ListBox lstCOMPorts;
        private Label label1;
        private Button btnCOMConnect;
        private Label lblCOMPortStatus;
        private Label label3;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnCOMDisconnect;
        private Button btnCOMRefresh;
        private ScottPlot.WinForms.FormsPlot graphLiveView;
    }
}
