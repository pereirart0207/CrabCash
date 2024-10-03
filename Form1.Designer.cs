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
            comboBoxGroups = new ComboBox();
            label2 = new Label();
            textBoxBuyInfo = new TextBox();
            labelAmount = new Label();
            textBoxAmount = new TextBox();
            tabPageGroup = new TabPage();
            labelEuro = new Label();
            btnGroupEdit = new Button();
            buttonNew = new Button();
            labelDestinatedAmount = new Label();
            textBoxDestinatedAmount = new TextBox();
            labelPriority = new Label();
            btnDeleteGroup = new Button();
            label5 = new Label();
            listBoxGroups = new ListBox();
            btnAddGroup = new Button();
            comboBoxpriority = new ComboBox();
            label4 = new Label();
            textBoxGroupName = new TextBox();
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
            tabControl1.Location = new Point(10, 9);
            tabControl1.Margin = new Padding(3, 2, 3, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(304, 250);
            tabControl1.TabIndex = 0;
            // 
            // tabPageOutput
            // 
            tabPageOutput.Controls.Add(btnAddBuy);
            tabPageOutput.Controls.Add(labelGroup);
            tabPageOutput.Controls.Add(comboBoxGroups);
            tabPageOutput.Controls.Add(label2);
            tabPageOutput.Controls.Add(textBoxBuyInfo);
            tabPageOutput.Controls.Add(labelAmount);
            tabPageOutput.Controls.Add(textBoxAmount);
            tabPageOutput.Location = new Point(4, 24);
            tabPageOutput.Margin = new Padding(3, 2, 3, 2);
            tabPageOutput.Name = "tabPageOutput";
            tabPageOutput.Padding = new Padding(3, 2, 3, 2);
            tabPageOutput.Size = new Size(296, 222);
            tabPageOutput.TabIndex = 0;
            tabPageOutput.Text = "Gastos";
            tabPageOutput.UseVisualStyleBackColor = true;
            // 
            // btnAddBuy
            // 
            btnAddBuy.Location = new Point(13, 170);
            btnAddBuy.Margin = new Padding(3, 2, 3, 2);
            btnAddBuy.Name = "btnAddBuy";
            btnAddBuy.Size = new Size(265, 34);
            btnAddBuy.TabIndex = 6;
            btnAddBuy.Text = "Agregar Gasto";
            btnAddBuy.UseVisualStyleBackColor = true;
            btnAddBuy.Click += btnAddBuy_Click;
            // 
            // labelGroup
            // 
            labelGroup.AutoSize = true;
            labelGroup.Location = new Point(100, 7);
            labelGroup.Name = "labelGroup";
            labelGroup.Size = new Size(40, 15);
            labelGroup.TabIndex = 5;
            labelGroup.Text = "Grupo";
            // 
            // comboBoxGroups
            // 
            comboBoxGroups.FormattingEnabled = true;
            comboBoxGroups.Location = new Point(102, 23);
            comboBoxGroups.Margin = new Padding(3, 2, 3, 2);
            comboBoxGroups.Name = "comboBoxGroups";
            comboBoxGroups.Size = new Size(176, 23);
            comboBoxGroups.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 58);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 3;
            label2.Text = "Descripción";
            // 
            // textBoxBuyInfo
            // 
            textBoxBuyInfo.Location = new Point(13, 76);
            textBoxBuyInfo.Margin = new Padding(3, 2, 3, 2);
            textBoxBuyInfo.Multiline = true;
            textBoxBuyInfo.Name = "textBoxBuyInfo";
            textBoxBuyInfo.Size = new Size(266, 76);
            textBoxBuyInfo.TabIndex = 2;
            // 
            // labelAmount
            // 
            labelAmount.AutoSize = true;
            labelAmount.Location = new Point(11, 7);
            labelAmount.Name = "labelAmount";
            labelAmount.Size = new Size(43, 15);
            labelAmount.TabIndex = 1;
            labelAmount.Text = "Monto";
            // 
            // textBoxAmount
            // 
            textBoxAmount.Location = new Point(13, 24);
            textBoxAmount.Margin = new Padding(3, 2, 3, 2);
            textBoxAmount.Name = "textBoxAmount";
            textBoxAmount.Size = new Size(56, 23);
            textBoxAmount.TabIndex = 0;
            textBoxAmount.KeyPress += textBoxAmount_KeyPress;
            // 
            // tabPageGroup
            // 
            tabPageGroup.Controls.Add(labelEuro);
            tabPageGroup.Controls.Add(btnGroupEdit);
            tabPageGroup.Controls.Add(buttonNew);
            tabPageGroup.Controls.Add(labelDestinatedAmount);
            tabPageGroup.Controls.Add(textBoxDestinatedAmount);
            tabPageGroup.Controls.Add(labelPriority);
            tabPageGroup.Controls.Add(btnDeleteGroup);
            tabPageGroup.Controls.Add(label5);
            tabPageGroup.Controls.Add(listBoxGroups);
            tabPageGroup.Controls.Add(btnAddGroup);
            tabPageGroup.Controls.Add(comboBoxpriority);
            tabPageGroup.Controls.Add(label4);
            tabPageGroup.Controls.Add(textBoxGroupName);
            tabPageGroup.Location = new Point(4, 24);
            tabPageGroup.Margin = new Padding(3, 2, 3, 2);
            tabPageGroup.Name = "tabPageGroup";
            tabPageGroup.Padding = new Padding(3, 2, 3, 2);
            tabPageGroup.Size = new Size(296, 222);
            tabPageGroup.TabIndex = 1;
            tabPageGroup.Text = "Grupos";
            tabPageGroup.UseVisualStyleBackColor = true;
            // 
            // labelEuro
            // 
            labelEuro.AutoSize = true;
            labelEuro.Location = new Point(80, 84);
            labelEuro.Name = "labelEuro";
            labelEuro.Size = new Size(13, 15);
            labelEuro.TabIndex = 13;
            labelEuro.Text = "€";
            // 
            // btnGroupEdit
            // 
            btnGroupEdit.Location = new Point(16, 196);
            btnGroupEdit.Margin = new Padding(3, 2, 3, 2);
            btnGroupEdit.Name = "btnGroupEdit";
            btnGroupEdit.Size = new Size(51, 22);
            btnGroupEdit.TabIndex = 12;
            btnGroupEdit.Text = "Editar";
            btnGroupEdit.UseVisualStyleBackColor = true;
            btnGroupEdit.Click += btnGroupEdit_Click;
            // 
            // buttonNew
            // 
            buttonNew.Location = new Point(177, 65);
            buttonNew.Margin = new Padding(3, 2, 3, 2);
            buttonNew.Name = "buttonNew";
            buttonNew.Size = new Size(102, 37);
            buttonNew.TabIndex = 11;
            buttonNew.Text = "Nuevo";
            buttonNew.UseVisualStyleBackColor = true;
            buttonNew.Click += buttonNew_Click;
            // 
            // labelDestinatedAmount
            // 
            labelDestinatedAmount.AutoSize = true;
            labelDestinatedAmount.Location = new Point(16, 62);
            labelDestinatedAmount.Name = "labelDestinatedAmount";
            labelDestinatedAmount.Size = new Size(60, 15);
            labelDestinatedAmount.TabIndex = 9;
            labelDestinatedAmount.Text = "Destinado";
            // 
            // textBoxDestinatedAmount
            // 
            textBoxDestinatedAmount.Enabled = false;
            textBoxDestinatedAmount.Location = new Point(16, 80);
            textBoxDestinatedAmount.Margin = new Padding(3, 2, 3, 2);
            textBoxDestinatedAmount.Name = "textBoxDestinatedAmount";
            textBoxDestinatedAmount.Size = new Size(62, 23);
            textBoxDestinatedAmount.TabIndex = 8;
            textBoxDestinatedAmount.KeyPress += textBoxDestinatedAmount_KeyPress;
            // 
            // labelPriority
            // 
            labelPriority.AutoSize = true;
            labelPriority.Location = new Point(177, 13);
            labelPriority.Name = "labelPriority";
            labelPriority.Size = new Size(30, 15);
            labelPriority.TabIndex = 7;
            labelPriority.Text = "Tipo";
            // 
            // btnDeleteGroup
            // 
            btnDeleteGroup.Location = new Point(228, 198);
            btnDeleteGroup.Margin = new Padding(3, 2, 3, 2);
            btnDeleteGroup.Name = "btnDeleteGroup";
            btnDeleteGroup.Size = new Size(51, 22);
            btnDeleteGroup.TabIndex = 6;
            btnDeleteGroup.Text = "Borrar";
            btnDeleteGroup.UseVisualStyleBackColor = true;
            btnDeleteGroup.Click += btnDeleteGroup_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 111);
            label5.Name = "label5";
            label5.Size = new Size(45, 15);
            label5.TabIndex = 5;
            label5.Text = "Grupos";
            // 
            // listBoxGroups
            // 
            listBoxGroups.FormattingEnabled = true;
            listBoxGroups.ItemHeight = 15;
            listBoxGroups.Location = new Point(16, 130);
            listBoxGroups.Margin = new Padding(3, 2, 3, 2);
            listBoxGroups.Name = "listBoxGroups";
            listBoxGroups.Size = new Size(265, 64);
            listBoxGroups.TabIndex = 4;
            listBoxGroups.SelectedIndexChanged += listBoxGroups_SelectedIndexChanged;
            // 
            // btnAddGroup
            // 
            btnAddGroup.Location = new Point(177, 64);
            btnAddGroup.Margin = new Padding(3, 2, 3, 2);
            btnAddGroup.Name = "btnAddGroup";
            btnAddGroup.Size = new Size(102, 37);
            btnAddGroup.TabIndex = 3;
            btnAddGroup.Text = "Agregar";
            btnAddGroup.UseVisualStyleBackColor = true;
            btnAddGroup.Click += btnAddGroup_Click;
            // 
            // comboBoxpriority
            // 
            comboBoxpriority.Enabled = false;
            comboBoxpriority.FormattingEnabled = true;
            comboBoxpriority.Items.AddRange(new object[] { "Prioritario", "Manejable" });
            comboBoxpriority.Location = new Point(177, 29);
            comboBoxpriority.Margin = new Padding(3, 2, 3, 2);
            comboBoxpriority.Name = "comboBoxpriority";
            comboBoxpriority.Size = new Size(104, 23);
            comboBoxpriority.TabIndex = 2;
            comboBoxpriority.Text = "Prioritario";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 13);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 1;
            label4.Text = "Nombre";
            // 
            // textBoxGroupName
            // 
            textBoxGroupName.Enabled = false;
            textBoxGroupName.Location = new Point(16, 30);
            textBoxGroupName.Margin = new Padding(3, 2, 3, 2);
            textBoxGroupName.Name = "textBoxGroupName";
            textBoxGroupName.Size = new Size(156, 23);
            textBoxGroupName.TabIndex = 0;
            // 
            // tabPageInput
            // 
            tabPageInput.Controls.Add(button1);
            tabPageInput.Controls.Add(labelMotive);
            tabPageInput.Controls.Add(textBox4);
            tabPageInput.Controls.Add(label6);
            tabPageInput.Controls.Add(textBoxMonthAmount);
            tabPageInput.Location = new Point(4, 24);
            tabPageInput.Margin = new Padding(3, 2, 3, 2);
            tabPageInput.Name = "tabPageInput";
            tabPageInput.Padding = new Padding(3, 2, 3, 2);
            tabPageInput.Size = new Size(296, 222);
            tabPageInput.TabIndex = 2;
            tabPageInput.Text = "Entrada";
            tabPageInput.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(181, 182);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(101, 30);
            button1.TabIndex = 6;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = true;
            // 
            // labelMotive
            // 
            labelMotive.AutoSize = true;
            labelMotive.Location = new Point(91, 7);
            labelMotive.Name = "labelMotive";
            labelMotive.Size = new Size(45, 15);
            labelMotive.TabIndex = 5;
            labelMotive.Text = "Motivo";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(94, 24);
            textBox4.Margin = new Padding(3, 2, 3, 2);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(189, 23);
            textBox4.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(8, 7);
            label6.Name = "label6";
            label6.Size = new Size(49, 15);
            label6.TabIndex = 3;
            label6.Text = "Importe";
            // 
            // textBoxMonthAmount
            // 
            textBoxMonthAmount.Location = new Point(10, 24);
            textBoxMonthAmount.Margin = new Padding(3, 2, 3, 2);
            textBoxMonthAmount.Name = "textBoxMonthAmount";
            textBoxMonthAmount.Size = new Size(70, 23);
            textBoxMonthAmount.TabIndex = 2;
            // 
            // labelSaving
            // 
            labelSaving.AutoSize = true;
            labelSaving.Location = new Point(14, 266);
            labelSaving.Name = "labelSaving";
            labelSaving.Size = new Size(49, 15);
            labelSaving.TabIndex = 1;
            labelSaving.Text = "Ahorros";
            labelSaving.Click += labelSaving_Click;
            // 
            // labelSVG
            // 
            labelSVG.AutoSize = true;
            labelSVG.Font = new Font("Segoe UI", 23F);
            labelSVG.Location = new Point(10, 280);
            labelSVG.Name = "labelSVG";
            labelSVG.Size = new Size(93, 42);
            labelSVG.TabIndex = 2;
            labelSVG.Text = "0.00€";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(157, 280);
            label1.Name = "label1";
            label1.Size = new Size(101, 15);
            label1.TabIndex = 3;
            label1.Text = "Gastos asumibles:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(157, 308);
            label3.Name = "label3";
            label3.Size = new Size(91, 15);
            label3.TabIndex = 4;
            label3.Text = "Gastos posibles:";
            // 
            // labelAsGastos
            // 
            labelAsGastos.AutoSize = true;
            labelAsGastos.Location = new Point(267, 280);
            labelAsGastos.Name = "labelAsGastos";
            labelAsGastos.Size = new Size(34, 15);
            labelAsGastos.TabIndex = 5;
            labelAsGastos.Text = "0.00€";
            // 
            // labelPosGastos
            // 
            labelPosGastos.AutoSize = true;
            labelPosGastos.Location = new Point(267, 307);
            labelPosGastos.Name = "labelPosGastos";
            labelPosGastos.Size = new Size(34, 15);
            labelPosGastos.TabIndex = 6;
            labelPosGastos.Text = "0.00€";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(326, 336);
            Controls.Add(labelPosGastos);
            Controls.Add(labelAsGastos);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(labelSVG);
            Controls.Add(labelSaving);
            Controls.Add(tabControl1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "CrabCash";
            Activated += Form1_Activated;
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
        private TextBox textBoxBuyInfo;
        private Label labelAmount;
        private TextBox textBoxAmount;
        private TabPage tabPageInput;
        private Label labelGroup;
        private ComboBox comboBoxGroups;
        private Button btnAddBuy;
        private Label labelSaving;
        private Label labelSVG;
        private Label label1;
        private Label label3;
        private ComboBox comboBoxpriority;
        private Label label4;
        private TextBox textBoxGroupName;
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
        private Label labelAsGastos;
        private Label labelPosGastos;
        private Button buttonNew;
        private Button btnGroupEdit;
        private Label labelEuro;
    }
}
