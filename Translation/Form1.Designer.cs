
namespace Translation
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBoxFrom = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBoxTo = new System.Windows.Forms.RichTextBox();
            this.richTextBoxFrom = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxTo = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonConvert = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.richTextBoxTo, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.richTextBoxFrom, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.55556F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.44444F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(732, 503);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.comboBoxFrom);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(360, 92);
            this.panel2.TabIndex = 5;
            // 
            // comboBoxFrom
            // 
            this.comboBoxFrom.FormattingEnabled = true;
            this.comboBoxFrom.Items.AddRange(new object[] {
            "English",
            "Russian",
            "Azerbaijan",
            "Ukraine"});
            this.comboBoxFrom.Location = new System.Drawing.Point(129, 44);
            this.comboBoxFrom.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.comboBoxFrom.Name = "comboBoxFrom";
            this.comboBoxFrom.Size = new System.Drawing.Size(218, 24);
            this.comboBoxFrom.TabIndex = 2;
            this.comboBoxFrom.SelectedIndexChanged += new System.EventHandler(this.comboBoxFrom_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 22.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(9, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "From : ";
            // 
            // richTextBoxTo
            // 
            this.richTextBoxTo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxTo.Location = new System.Drawing.Point(373, 112);
            this.richTextBoxTo.Margin = new System.Windows.Forms.Padding(7, 14, 14, 14);
            this.richTextBoxTo.Name = "richTextBoxTo";
            this.richTextBoxTo.Size = new System.Drawing.Size(345, 377);
            this.richTextBoxTo.TabIndex = 3;
            this.richTextBoxTo.Text = "";
            // 
            // richTextBoxFrom
            // 
            this.richTextBoxFrom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxFrom.Location = new System.Drawing.Point(14, 112);
            this.richTextBoxFrom.Margin = new System.Windows.Forms.Padding(14, 14, 7, 14);
            this.richTextBoxFrom.Name = "richTextBoxFrom";
            this.richTextBoxFrom.Size = new System.Drawing.Size(345, 377);
            this.richTextBoxFrom.TabIndex = 0;
            this.richTextBoxFrom.Text = "";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.comboBoxTo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(369, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(360, 92);
            this.panel1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 22.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(38, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 46);
            this.label2.TabIndex = 3;
            this.label2.Text = "To : ";
            // 
            // comboBoxTo
            // 
            this.comboBoxTo.FormattingEnabled = true;
            this.comboBoxTo.Items.AddRange(new object[] {
            "English",
            "Russian",
            "Azerbaijan",
            "Ukraine"});
            this.comboBoxTo.Location = new System.Drawing.Point(116, 44);
            this.comboBoxTo.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.comboBoxTo.Name = "comboBoxTo";
            this.comboBoxTo.Size = new System.Drawing.Size(235, 24);
            this.comboBoxTo.TabIndex = 1;
            this.comboBoxTo.SelectedIndexChanged += new System.EventHandler(this.comboBoxFrom_SelectedIndexChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.buttonConvert);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 444);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(732, 59);
            this.panel3.TabIndex = 2;
            // 
            // buttonConvert
            // 
            this.buttonConvert.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttonConvert.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonConvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonConvert.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonConvert.Location = new System.Drawing.Point(299, 13);
            this.buttonConvert.Name = "buttonConvert";
            this.buttonConvert.Size = new System.Drawing.Size(133, 32);
            this.buttonConvert.TabIndex = 0;
            this.buttonConvert.Text = "Convert";
            this.toolTip1.SetToolTip(this.buttonConvert, resources.GetString("buttonConvert.ToolTip"));
            this.buttonConvert.UseVisualStyleBackColor = false;
            this.buttonConvert.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(732, 503);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(650, 450);
            this.Name = "Form1";
            this.Text = "Translation";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RichTextBox richTextBoxTo;
        private System.Windows.Forms.RichTextBox richTextBoxFrom;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBoxTo;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonConvert;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxFrom;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

