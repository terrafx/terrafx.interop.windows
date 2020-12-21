namespace TerraFX.Samples.WinForms
{
    partial class DXPanel
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Name = "UserControl1";
            this.ClientSizeChanged += DXPanel_ClientSizeChanged;
            this.KeyDown += DXPanel_KeyDown;
            this.KeyUp += DXPanel_KeyUp;
            this.ResumeLayout(false);
        }

        #endregion
    }
}
