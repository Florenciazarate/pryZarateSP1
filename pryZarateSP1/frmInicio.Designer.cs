namespace pryZarateSP1
{
    partial class frmInicio
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicio));
            btn1 = new Button();
            lbl1 = new Label();
            SuspendLayout();
            // 
            // btn1
            // 
            btn1.BackColor = Color.SeaShell;
            btn1.Font = new Font("Yu Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn1.Location = new Point(213, 140);
            btn1.Name = "btn1";
            btn1.Size = new Size(86, 39);
            btn1.TabIndex = 0;
            btn1.Text = "Aceptar";
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += btn1_Click;
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Font = new Font("Candara", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl1.Location = new Point(123, 89);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(266, 33);
            lbl1.TabIndex = 1;
            lbl1.Text = "Bienvenido al sistema";
            // 
            // frmInicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tan;
            ClientSize = new Size(504, 281);
            Controls.Add(lbl1);
            Controls.Add(btn1);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmInicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bienvenido";
            Load += frmInicio_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn1;
        private Label lbl1;
        private ToolStripMenuItem bienvenidoToolStripMenuItem;
    }
}