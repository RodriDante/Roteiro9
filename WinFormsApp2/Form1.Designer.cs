namespace WinFormsApp2
{
    partial class Form1
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
            ListBox listUsuarios;
            textNome = new TextBox();
            btnSalvar = new Button();
            btnListar = new Button();
            listUsuarios = new ListBox();
            SuspendLayout();
            // 
            // listUsuarios
            // 
            listUsuarios.FormattingEnabled = true;
            listUsuarios.ItemHeight = 15;
            listUsuarios.Location = new Point(12, 234);
            listUsuarios.Name = "listUsuarios";
            listUsuarios.Size = new Size(172, 154);
            listUsuarios.TabIndex = 3;
            // 
            // textNome
            // 
            textNome.Location = new Point(84, 59);
            textNome.Name = "textNome";
            textNome.Size = new Size(100, 23);
            textNome.TabIndex = 0;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(371, 59);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(96, 28);
            btnSalvar.TabIndex = 1;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += button1_Click;
            // 
            // btnListar
            // 
            btnListar.Location = new Point(471, 155);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(91, 28);
            btnListar.TabIndex = 2;
            btnListar.Text = "Listar";
            btnListar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(741, 450);
            Controls.Add(listUsuarios);
            Controls.Add(btnListar);
            Controls.Add(btnSalvar);
            Controls.Add(textNome);
            Name = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textNome;
        private Button btnSalvar;
        private Button btnListar;
        private ListBox listUsuarios;
    }
}
