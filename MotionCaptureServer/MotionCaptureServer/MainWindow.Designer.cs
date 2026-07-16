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
            tabPage2 = new TabPage();
            tabWindow.SuspendLayout();
            SuspendLayout();
            // 
            // tabWindow
            // 
            tabWindow.Controls.Add(tabMicroBit);
            tabWindow.Controls.Add(tabPage2);
            tabWindow.Dock = DockStyle.Fill;
            tabWindow.Location = new Point(0, 0);
            tabWindow.Name = "tabWindow";
            tabWindow.SelectedIndex = 0;
            tabWindow.Size = new Size(800, 450);
            tabWindow.TabIndex = 0;
            // 
            // tabMicroBit
            // 
            tabMicroBit.Location = new Point(4, 24);
            tabMicroBit.Name = "tabMicroBit";
            tabMicroBit.Padding = new Padding(3);
            tabMicroBit.Size = new Size(792, 422);
            tabMicroBit.TabIndex = 0;
            tabMicroBit.Text = "Micro:bit connection";
            tabMicroBit.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(192, 72);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabWindow);
            Name = "MainWindow";
            Text = "Form1";
            tabWindow.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabWindow;
        private TabPage tabMicroBit;
        private TabPage tabPage2;
    }
}
