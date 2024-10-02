namespace CrabCash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            tabControl1 = new TabControl();
            tabPageOutput = new TabPage();
            btnAddBuy = new Button();
            labelGroup = new Label();
            comboBox1 = new ComboBox();
            label2 = new Label();
            textBox2 = new TextBox();
            labelAmount = new Label();
            textBox1 = new TextBox();
            tabPageGroup = new TabPage();
            comboBox3 = new ComboBox();
            labelDestinatedAmount = new Label();
            textBoxDestinatedAmount = new TextBox();
            labelPriority = new Label();
            btnDeleteGroup = new Button();
            label5 = new Label();
            listBoxGroups = new ListBox();
            btnAddGroup = new Button();
            comboBox2 = new ComboBox();
            label4 = new Label();
            textBox3 = new TextBox();
            tabPageInput = new TabPage();
            button1 = new Button();
            labelMotive = new Label();
            textBox4 = new TextBox();
            label6 = new Label();
            textBoxMonthAmount = new TextBox();
            labelSaving = new Label();
            labelSVG = new Label();
            label1 = new Label();
            label3 = new Label();
            labelAsGastos = new Label();
            labelPosGastos = new Label();
            tabControl1.SuspendLayout();
            tabPageOutput.SuspendLayout();
            tabPageGroup.SuspendLayout();
            tabPageInput.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageOutput);
            tabControl1.Controls.Add(tabPageGroup);
            tabControl1.Controls.Add(tabPageInput);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(348, 333);
            tabControl1.TabIndex = 0;
            // 
            // tabPageOutput
            // 
            tabPageOutput.Controls.Add(btnAddBuy);
            tabPageOutput.Controls.Add(labelGroup);
            tabPageOutput.Controls.Add(comboBox1);
            tabPageOutput.Controls.Add(label2);
            tabPageOutput.Controls.Add(textBox2);
            tabPageOutput.Controls.Add(labelAmount);
            tabPageOutput.Controls.Add(textBox1);
            tabPageOutput.Location = new Point(4, 29);
            tabPageOutput.Name = "tabPageOutput";
            tabPageOutput.Padding = new Padding(3);
            tabPageOutput.Size = new Size(340, 300);
            tabPageOutput.TabIndex = 0;
            tabPageOutput.Text = "Gastos";
            tabPageOutput.UseVisualStyleBackColor = true;
            // 
            // btnAddBuy
            // 
            btnAddBuy.Location = new Point(15, 226);
            btnAddBuy.Name = "btnAddBuy";
            btnAddBuy.Size = new Size(303, 45);
            btnAddBuy.TabIndex = 6;
            btnAddBuy.Text = "Agregar Gasto";
            btnAddBuy.UseVisualStyleBackColor = true;
            // 
            // labelGroup
            // 
            labelGroup.AutoSize = true;
            labelGroup.Location = new Point(114, 9);
            labelGroup.Name = "labelGroup";
            labelGroup.Size = new Size(50, 20);
            labelGroup.TabIndex = 5;
            labelGroup.Text = "Grupo";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(117, 31);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(201, 28);
            comboBox1.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 78);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 3;
            label2.Text = "Descripción";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(15, 101);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(303, 100);
            textBox2.TabIndex = 2;
            // 
            // labelAmount
            // 
            labelAmount.AutoSize = true;
            labelAmount.Location = new Point(12, 9);
            labelAmount.Name = "labelAmount";
            labelAmount.Size = new Size(53, 20);
            labelAmount.TabIndex = 1;
            labelAmount.Text = "Monto";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(15, 32);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(64, 27);
            textBox1.TabIndex = 0;
            // 
            // tabPageGroup
            // 
            tabPageGroup.Controls.Add(comboBox3);
            tabPageGroup.Controls.Add(labelDestinatedAmount);
            tabPageGroup.Controls.Add(textBoxDestinatedAmount);
            tabPageGroup.Controls.Add(labelPriority);
            tabPageGroup.Controls.Add(btnDeleteGroup);
            tabPageGroup.Controls.Add(label5);
            tabPageGroup.Controls.Add(listBoxGroups);
            tabPageGroup.Controls.Add(btnAddGroup);
            tabPageGroup.Controls.Add(comboBox2);
            tabPageGroup.Controls.Add(label4);
            tabPageGroup.Controls.Add(textBox3);
            tabPageGroup.Location = new Point(4, 29);
            tabPageGroup.Name = "tabPageGroup";
            tabPageGroup.Padding = new Padding(3);
            tabPageGroup.Size = new Size(340, 300);
            tabPageGroup.TabIndex = 1;
            tabPageGroup.Text = "Grupos";
            tabPageGroup.UseVisualStyleBackColor = true;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "€", "%" });
            comboBox3.Location = new Point(94, 106);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(44, 28);
            comboBox3.TabIndex = 10;
            comboBox3.Text = "€";
            // 
            // labelDestinatedAmount
            // 
            labelDestinatedAmount.AutoSize = true;
            labelDestinatedAmount.Location = new Point(18, 83);
            labelDestinatedAmount.Name = "labelDestinatedAmount";
            labelDestinatedAmount.Size = new Size(77, 20);
            labelDestinatedAmount.TabIndex = 9;
            labelDestinatedAmount.Text = "Destinado";
            // 
            // textBoxDestinatedAmount
            // 
            textBoxDestinatedAmount.Location = new Point(18, 106);
            textBoxDestinatedAmount.Name = "textBoxDestinatedAmount";
            textBoxDestinatedAmount.Size = new Size(70, 27);
            textBoxDestinatedAmount.TabIndex = 8;
            // 
            // labelPriority
            // 
            labelPriority.AutoSize = true;
            labelPriority.Location = new Point(202, 17);
            labelPriority.Name = "labelPriority";
            labelPriority.Size = new Size(39, 20);
            labelPriority.TabIndex = 7;
            labelPriority.Text = "Tipo";
            // 
            // btnDeleteGroup
            // 
            btnDeleteGroup.Location = new Point(261, 264);
            btnDeleteGroup.Name = "btnDeleteGroup";
            btnDeleteGroup.Size = new Size(58, 29);
            btnDeleteGroup.TabIndex = 6;
            btnDeleteGroup.Text = "Borrar";
            btnDeleteGroup.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 148);
            label5.Name = "label5";
            label5.Size = new Size(56, 20);
            label5.TabIndex = 5;
            label5.Text = "Grupos";
            // 
            // listBoxGroups
            // 
            listBoxGroups.FormattingEnabled = true;
            listBoxGroups.Location = new Point(18, 174);
            listBoxGroups.Name = "listBoxGroups";
            listBoxGroups.Size = new Size(302, 84);
            listBoxGroups.TabIndex = 4;
            // 
            // btnAddGroup
            // 
            btnAddGroup.Location = new Point(163, 85);
            btnAddGroup.Name = "btnAddGroup";
            btnAddGroup.Size = new Size(156, 49);
            btnAddGroup.TabIndex = 3;
            btnAddGroup.Text = "Agregar";
            btnAddGroup.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Prioritario", "Manejable" });
            comboBox2.Location = new Point(202, 39);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(118, 28);
            comboBox2.TabIndex = 2;
            comboBox2.Text = "Prioritario";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 17);
            label4.Name = "label4";
            label4.Size = new Size(64, 20);
            label4.TabIndex = 1;
            label4.Text = "Nombre";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(18, 40);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(178, 27);
            textBox3.TabIndex = 0;
            // 
            // tabPageInput
            // 
            tabPageInput.Controls.Add(button1);
            tabPageInput.Controls.Add(labelMotive);
            tabPageInput.Controls.Add(textBox4);
            tabPageInput.Controls.Add(label6);
            tabPageInput.Controls.Add(textBoxMonthAmount);
            tabPageInput.Location = new Point(4, 29);
            tabPageInput.Name = "tabPageInput";
            tabPageInput.Padding = new Padding(3);
            tabPageInput.Size = new Size(340, 300);
            tabPageInput.TabIndex = 2;
            tabPageInput.Text = "Entrada";
            tabPageInput.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(207, 242);
            button1.Name = "button1";
            button1.Size = new Size(115, 40);
            button1.TabIndex = 6;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = true;
            // 
            // labelMotive
            // 
            labelMotive.AutoSize = true;
            labelMotive.Location = new Point(104, 9);
            labelMotive.Name = "labelMotive";
            labelMotive.Size = new Size(56, 20);
            labelMotive.TabIndex = 5;
            labelMotive.Text = "Motivo";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(107, 32);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(215, 27);
            textBox4.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(9, 9);
            label6.Name = "label6";
            label6.Size = new Size(62, 20);
            label6.TabIndex = 3;
            label6.Text = "Importe";
            // 
            // textBoxMonthAmount
            // 
            textBoxMonthAmount.Location = new Point(12, 32);
            textBoxMonthAmount.Name = "textBoxMonthAmount";
            textBoxMonthAmount.Size = new Size(79, 27);
            textBoxMonthAmount.TabIndex = 2;
            // 
            // labelSaving
            // 
            labelSaving.AutoSize = true;
            labelSaving.Location = new Point(16, 354);
            labelSaving.Name = "labelSaving";
            labelSaving.Size = new Size(61, 20);
            labelSaving.TabIndex = 1;
            labelSaving.Text = "Ahorros";
            labelSaving.Click += labelSaving_Click;
            // 
            // labelSVG
            // 
            labelSVG.AutoSize = true;
            labelSVG.Font = new Font("Segoe UI", 23F);
            labelSVG.Location = new Point(12, 374);
            labelSVG.Name = "labelSVG";
            labelSVG.Size = new Size(114, 52);
            labelSVG.TabIndex = 2;
            labelSVG.Text = "0.00€";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(179, 374);
            label1.Name = "label1";
            label1.Size = new Size(126, 20);
            label1.TabIndex = 3;
            label1.Text = "Gastos asumibles:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(179, 410);
            label3.Name = "label3";
            label3.Size = new Size(115, 20);
            label3.TabIndex = 4;
            label3.Text = "Gastos posibles:";
            // 
            // labelAsGastos
            // 
            labelAsGastos.AutoSize = true;
            labelAsGastos.Location = new Point(305, 374);
            labelAsGastos.Name = "labelAsGastos";
            labelAsGastos.Size = new Size(44, 20);
            labelAsGastos.TabIndex = 5;
            labelAsGastos.Text = "0.00€";
            // 
            // labelPosGastos
            // 
            labelPosGastos.AutoSize = true;
            labelPosGastos.Location = new Point(305, 406);
            labelPosGastos.Name = "labelPosGastos";
            labelPosGastos.Size = new Size(44, 20);
            labelPosGastos.TabIndex = 6;
            labelPosGastos.Text = "0.00€";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(372, 435);
            Controls.Add(labelPosGastos);
            Controls.Add(labelAsGastos);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(labelSVG);
            Controls.Add(labelSaving);
            Controls.Add(tabControl1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "CrabCash";
            tabControl1.ResumeLayout(false);
            tabPageOutput.ResumeLayout(false);
            tabPageOutput.PerformLayout();
            tabPageGroup.ResumeLayout(false);
            tabPageGroup.PerformLayout();
            tabPageInput.ResumeLayout(false);
            tabPageInput.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPageOutput;
        private TabPage tabPageGroup;
        private Label label2;
        private TextBox textBox2;
        private Label labelAmount;
        private TextBox textBox1;
        private TabPage tabPageInput;
        private Label labelGroup;
        private ComboBox comboBox1;
        private Button btnAddBuy;
        private Label labelSaving;
        private Label labelSVG;
        private Label label1;
        private Label label3;
        private ComboBox comboBox2;
        private Label label4;
        private TextBox textBox3;
        private Button btnAddGroup;
        private ListBox listBoxGroups;
        private Button btnDeleteGroup;
        private Label label5;
        private Label labelPriority;
        private Label label6;
        private TextBox textBoxMonthAmount;
        private Button button1;
        private Label labelMotive;
        private TextBox textBox4;
        private Label labelDestinatedAmount;
        private TextBox textBoxDestinatedAmount;
        private ComboBox comboBox3;
        private Label labelAsGastos;
        private Label labelPosGastos;
    }
}
