
namespace MyCalculator
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.controlPanel = new System.Windows.Forms.Panel();
            this.btnPinActivate = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblOperation = new System.Windows.Forms.Label();
            this.tbxInput = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblPrevInput = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.btnMult = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_Comma = new System.Windows.Forms.Button();
            this.btn_3 = new System.Windows.Forms.Button();
            this.btn_9 = new System.Windows.Forms.Button();
            this.btn_6 = new System.Windows.Forms.Button();
            this.btnClearPrev = new System.Windows.Forms.Button();
            this.btn_0 = new System.Windows.Forms.Button();
            this.btn_2 = new System.Windows.Forms.Button();
            this.btn_8 = new System.Windows.Forms.Button();
            this.btn_5 = new System.Windows.Forms.Button();
            this.btnSqrt = new System.Windows.Forms.Button();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.btn_1 = new System.Windows.Forms.Button();
            this.btn_4 = new System.Windows.Forms.Button();
            this.btn_7 = new System.Windows.Forms.Button();
            this.btnChangeSign = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btn_Equal = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnShowAdvanced = new System.Windows.Forms.Button();
            this.panelAdvanced = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.rbRadian = new System.Windows.Forms.RadioButton();
            this.rbDegree = new System.Windows.Forms.RadioButton();
            this.panel14 = new System.Windows.Forms.Panel();
            this.btnExp = new System.Windows.Forms.Button();
            this.btn1DivideByX = new System.Windows.Forms.Button();
            this.btтRoot3 = new System.Windows.Forms.Button();
            this.btnFactorial = new System.Windows.Forms.Button();
            this.panel13 = new System.Windows.Forms.Panel();
            this.btnSquare = new System.Windows.Forms.Button();
            this.btnAbs = new System.Windows.Forms.Button();
            this.btnLog = new System.Windows.Forms.Button();
            this.btnLn = new System.Windows.Forms.Button();
            this.panel11 = new System.Windows.Forms.Panel();
            this.btnRoot3 = new System.Windows.Forms.Button();
            this.btn10PowN = new System.Windows.Forms.Button();
            this.btn2PowN = new System.Windows.Forms.Button();
            this.btnRootN = new System.Windows.Forms.Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.btnPowN = new System.Windows.Forms.Button();
            this.btnCTg = new System.Windows.Forms.Button();
            this.btnCos_1 = new System.Windows.Forms.Button();
            this.btnCos = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btnPI = new System.Windows.Forms.Button();
            this.btnTg = new System.Windows.Forms.Button();
            this.btnSin_1 = new System.Windows.Forms.Button();
            this.btnSin = new System.Windows.Forms.Button();
            this.controlPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panelAdvanced.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // controlPanel
            // 
            this.controlPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(51)))), ((int)(((byte)(75)))));
            this.controlPanel.Controls.Add(this.btnPinActivate);
            this.controlPanel.Controls.Add(this.btnMinimize);
            this.controlPanel.Controls.Add(this.btnExit);
            this.controlPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.controlPanel.Location = new System.Drawing.Point(0, 0);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(250, 28);
            this.controlPanel.TabIndex = 0;
            this.controlPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.controlPanel_MouseDown);
            this.controlPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.controlPanel_MouseMove);
            // 
            // btnPinActivate
            // 
            this.btnPinActivate.FlatAppearance.BorderSize = 0;
            this.btnPinActivate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPinActivate.Image = ((System.Drawing.Image)(resources.GetObject("btnPinActivate.Image")));
            this.btnPinActivate.Location = new System.Drawing.Point(0, 0);
            this.btnPinActivate.Name = "btnPinActivate";
            this.btnPinActivate.Size = new System.Drawing.Size(28, 28);
            this.btnPinActivate.TabIndex = 9;
            this.btnPinActivate.UseVisualStyleBackColor = true;
            this.btnPinActivate.Click += new System.EventHandler(this.btnPinActivate_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.Location = new System.Drawing.Point(194, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(28, 28);
            this.btnMinimize.TabIndex = 9;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(222, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(28, 28);
            this.btnExit.TabIndex = 11;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.panel2.Controls.Add(this.lblOperation);
            this.panel2.Controls.Add(this.tbxInput);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 120);
            this.panel2.TabIndex = 1;
            // 
            // lblOperation
            // 
            this.lblOperation.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblOperation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblOperation.Location = new System.Drawing.Point(0, 38);
            this.lblOperation.Name = "lblOperation";
            this.lblOperation.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.lblOperation.Size = new System.Drawing.Size(250, 33);
            this.lblOperation.TabIndex = 3;
            this.lblOperation.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tbxInput
            // 
            this.tbxInput.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.tbxInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.tbxInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxInput.Font = new System.Drawing.Font("Lucida Console", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(124)))), ((int)(((byte)(191)))));
            this.tbxInput.Location = new System.Drawing.Point(1, 87);
            this.tbxInput.MaxLength = 10;
            this.tbxInput.Name = "tbxInput";
            this.tbxInput.ReadOnly = true;
            this.tbxInput.Size = new System.Drawing.Size(246, 29);
            this.tbxInput.TabIndex = 2;
            this.tbxInput.Text = "0";
            this.tbxInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbxInput.TextChanged += new System.EventHandler(this.tbxInput_TextChanged);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(64)))));
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 36);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(250, 2);
            this.panel6.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.lblPrevInput);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(0);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(50);
            this.panel5.Size = new System.Drawing.Size(250, 36);
            this.panel5.TabIndex = 0;
            // 
            // lblPrevInput
            // 
            this.lblPrevInput.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPrevInput.Location = new System.Drawing.Point(-2, 0);
            this.lblPrevInput.Name = "lblPrevInput";
            this.lblPrevInput.Size = new System.Drawing.Size(235, 36);
            this.lblPrevInput.TabIndex = 0;
            this.lblPrevInput.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(55)))), ((int)(((byte)(82)))));
            this.panel3.Controls.Add(this.btnAdd);
            this.panel3.Controls.Add(this.btnSub);
            this.panel3.Controls.Add(this.btnMult);
            this.panel3.Controls.Add(this.btnDivide);
            this.panel3.Location = new System.Drawing.Point(165, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(85, 285);
            this.panel3.TabIndex = 5;
            // 
            // btnAdd
            // 
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Location = new System.Drawing.Point(0, 210);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(85, 70);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Tag = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BaseOperationInvoke);
            // 
            // btnSub
            // 
            this.btnSub.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSub.FlatAppearance.BorderSize = 0;
            this.btnSub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSub.Image = ((System.Drawing.Image)(resources.GetObject("btnSub.Image")));
            this.btnSub.Location = new System.Drawing.Point(0, 140);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(85, 70);
            this.btnSub.TabIndex = 3;
            this.btnSub.Tag = "-";
            this.btnSub.UseVisualStyleBackColor = true;
            this.btnSub.Click += new System.EventHandler(this.BaseOperationInvoke);
            // 
            // btnMult
            // 
            this.btnMult.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMult.FlatAppearance.BorderSize = 0;
            this.btnMult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMult.Image = ((System.Drawing.Image)(resources.GetObject("btnMult.Image")));
            this.btnMult.Location = new System.Drawing.Point(0, 70);
            this.btnMult.Name = "btnMult";
            this.btnMult.Size = new System.Drawing.Size(85, 70);
            this.btnMult.TabIndex = 3;
            this.btnMult.Tag = "x";
            this.btnMult.UseVisualStyleBackColor = true;
            this.btnMult.Click += new System.EventHandler(this.BaseOperationInvoke);
            // 
            // btnDivide
            // 
            this.btnDivide.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDivide.FlatAppearance.BorderSize = 0;
            this.btnDivide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDivide.Image = ((System.Drawing.Image)(resources.GetObject("btnDivide.Image")));
            this.btnDivide.Location = new System.Drawing.Point(0, 0);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(85, 70);
            this.btnDivide.TabIndex = 3;
            this.btnDivide.Tag = "÷";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.BaseOperationInvoke);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btn_Comma);
            this.panel4.Controls.Add(this.btn_3);
            this.panel4.Controls.Add(this.btn_9);
            this.panel4.Controls.Add(this.btn_6);
            this.panel4.Controls.Add(this.btnClearPrev);
            this.panel4.Controls.Add(this.btn_0);
            this.panel4.Controls.Add(this.btn_2);
            this.panel4.Controls.Add(this.btn_8);
            this.panel4.Controls.Add(this.btn_5);
            this.panel4.Controls.Add(this.btnSqrt);
            this.panel4.Controls.Add(this.btnClearAll);
            this.panel4.Controls.Add(this.btn_1);
            this.panel4.Controls.Add(this.btn_4);
            this.panel4.Controls.Add(this.btn_7);
            this.panel4.Controls.Add(this.btnChangeSign);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(165, 285);
            this.panel4.TabIndex = 4;
            // 
            // btn_Comma
            // 
            this.btn_Comma.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_Comma.FlatAppearance.BorderSize = 0;
            this.btn_Comma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Comma.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Comma.Location = new System.Drawing.Point(110, 229);
            this.btn_Comma.Name = "btn_Comma";
            this.btn_Comma.Size = new System.Drawing.Size(55, 55);
            this.btn_Comma.TabIndex = 0;
            this.btn_Comma.Tag = ",";
            this.btn_Comma.Text = ",";
            this.btn_Comma.UseVisualStyleBackColor = true;
            this.btn_Comma.Click += new System.EventHandler(this.InputComma);
            // 
            // btn_3
            // 
            this.btn_3.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_3.FlatAppearance.BorderSize = 0;
            this.btn_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_3.Location = new System.Drawing.Point(110, 172);
            this.btn_3.Name = "btn_3";
            this.btn_3.Size = new System.Drawing.Size(55, 55);
            this.btn_3.TabIndex = 0;
            this.btn_3.Tag = "3";
            this.btn_3.Text = "3";
            this.btn_3.UseVisualStyleBackColor = true;
            this.btn_3.Click += new System.EventHandler(this.NumberClick);
            // 
            // btn_9
            // 
            this.btn_9.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_9.FlatAppearance.BorderSize = 0;
            this.btn_9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_9.Location = new System.Drawing.Point(110, 58);
            this.btn_9.Name = "btn_9";
            this.btn_9.Size = new System.Drawing.Size(55, 55);
            this.btn_9.TabIndex = 0;
            this.btn_9.Tag = "9";
            this.btn_9.Text = "9";
            this.btn_9.UseVisualStyleBackColor = true;
            this.btn_9.Click += new System.EventHandler(this.NumberClick);
            // 
            // btn_6
            // 
            this.btn_6.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_6.FlatAppearance.BorderSize = 0;
            this.btn_6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_6.Location = new System.Drawing.Point(110, 115);
            this.btn_6.Name = "btn_6";
            this.btn_6.Size = new System.Drawing.Size(55, 55);
            this.btn_6.TabIndex = 0;
            this.btn_6.Tag = "6";
            this.btn_6.Text = "6";
            this.btn_6.UseVisualStyleBackColor = true;
            this.btn_6.Click += new System.EventHandler(this.NumberClick);
            // 
            // btnClearPrev
            // 
            this.btnClearPrev.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnClearPrev.FlatAppearance.BorderSize = 0;
            this.btnClearPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearPrev.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClearPrev.Image = ((System.Drawing.Image)(resources.GetObject("btnClearPrev.Image")));
            this.btnClearPrev.Location = new System.Drawing.Point(110, 1);
            this.btnClearPrev.Name = "btnClearPrev";
            this.btnClearPrev.Size = new System.Drawing.Size(55, 55);
            this.btnClearPrev.TabIndex = 0;
            this.btnClearPrev.Tag = "clearOne";
            this.btnClearPrev.UseVisualStyleBackColor = true;
            this.btnClearPrev.Click += new System.EventHandler(this.ClearLast);
            // 
            // btn_0
            // 
            this.btn_0.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_0.FlatAppearance.BorderSize = 0;
            this.btn_0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_0.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_0.Location = new System.Drawing.Point(55, 229);
            this.btn_0.Name = "btn_0";
            this.btn_0.Size = new System.Drawing.Size(55, 55);
            this.btn_0.TabIndex = 0;
            this.btn_0.Tag = "0";
            this.btn_0.Text = "0";
            this.btn_0.UseVisualStyleBackColor = true;
            this.btn_0.Click += new System.EventHandler(this.NumberClick);
            // 
            // btn_2
            // 
            this.btn_2.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_2.FlatAppearance.BorderSize = 0;
            this.btn_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_2.Location = new System.Drawing.Point(55, 172);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(55, 55);
            this.btn_2.TabIndex = 0;
            this.btn_2.Tag = "2";
            this.btn_2.Text = "2";
            this.btn_2.UseVisualStyleBackColor = true;
            this.btn_2.Click += new System.EventHandler(this.NumberClick);
            // 
            // btn_8
            // 
            this.btn_8.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_8.FlatAppearance.BorderSize = 0;
            this.btn_8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_8.Location = new System.Drawing.Point(55, 58);
            this.btn_8.Name = "btn_8";
            this.btn_8.Size = new System.Drawing.Size(55, 55);
            this.btn_8.TabIndex = 0;
            this.btn_8.Tag = "8";
            this.btn_8.Text = "8";
            this.btn_8.UseVisualStyleBackColor = true;
            this.btn_8.Click += new System.EventHandler(this.NumberClick);
            // 
            // btn_5
            // 
            this.btn_5.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_5.FlatAppearance.BorderSize = 0;
            this.btn_5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_5.Location = new System.Drawing.Point(55, 115);
            this.btn_5.Name = "btn_5";
            this.btn_5.Size = new System.Drawing.Size(55, 55);
            this.btn_5.TabIndex = 0;
            this.btn_5.Tag = "5";
            this.btn_5.Text = "5";
            this.btn_5.UseVisualStyleBackColor = true;
            this.btn_5.Click += new System.EventHandler(this.NumberClick);
            // 
            // btnSqrt
            // 
            this.btnSqrt.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSqrt.FlatAppearance.BorderSize = 0;
            this.btnSqrt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSqrt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSqrt.Location = new System.Drawing.Point(0, 229);
            this.btnSqrt.Name = "btnSqrt";
            this.btnSqrt.Size = new System.Drawing.Size(55, 55);
            this.btnSqrt.TabIndex = 0;
            this.btnSqrt.Tag = "sqrt";
            this.btnSqrt.Text = "√x";
            this.btnSqrt.UseVisualStyleBackColor = true;
            this.btnSqrt.Click += new System.EventHandler(this.AnvancedOperationInvoke);
            // 
            // btnClearAll
            // 
            this.btnClearAll.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnClearAll.FlatAppearance.BorderSize = 0;
            this.btnClearAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearAll.Font = new System.Drawing.Font("Segoe UI Historic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearAll.Location = new System.Drawing.Point(55, 1);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(55, 55);
            this.btnClearAll.TabIndex = 0;
            this.btnClearAll.Tag = "clear";
            this.btnClearAll.Text = "С";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.ClearAll);
            // 
            // btn_1
            // 
            this.btn_1.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_1.FlatAppearance.BorderSize = 0;
            this.btn_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_1.Location = new System.Drawing.Point(0, 172);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(55, 55);
            this.btn_1.TabIndex = 0;
            this.btn_1.Tag = "1";
            this.btn_1.Text = "1";
            this.btn_1.UseVisualStyleBackColor = true;
            this.btn_1.Click += new System.EventHandler(this.NumberClick);
            // 
            // btn_4
            // 
            this.btn_4.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_4.FlatAppearance.BorderSize = 0;
            this.btn_4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_4.Location = new System.Drawing.Point(0, 115);
            this.btn_4.Name = "btn_4";
            this.btn_4.Size = new System.Drawing.Size(55, 55);
            this.btn_4.TabIndex = 0;
            this.btn_4.Tag = "4";
            this.btn_4.Text = "4";
            this.btn_4.UseVisualStyleBackColor = true;
            this.btn_4.Click += new System.EventHandler(this.NumberClick);
            // 
            // btn_7
            // 
            this.btn_7.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_7.FlatAppearance.BorderSize = 0;
            this.btn_7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_7.Location = new System.Drawing.Point(0, 58);
            this.btn_7.Name = "btn_7";
            this.btn_7.Size = new System.Drawing.Size(55, 55);
            this.btn_7.TabIndex = 0;
            this.btn_7.Tag = "7";
            this.btn_7.Text = "7";
            this.btn_7.UseVisualStyleBackColor = true;
            this.btn_7.Click += new System.EventHandler(this.NumberClick);
            // 
            // btnChangeSign
            // 
            this.btnChangeSign.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnChangeSign.FlatAppearance.BorderSize = 0;
            this.btnChangeSign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnChangeSign.Location = new System.Drawing.Point(0, 1);
            this.btnChangeSign.Name = "btnChangeSign";
            this.btnChangeSign.Size = new System.Drawing.Size(55, 55);
            this.btnChangeSign.TabIndex = 0;
            this.btnChangeSign.Tag = "±";
            this.btnChangeSign.Text = "±";
            this.btnChangeSign.UseVisualStyleBackColor = true;
            this.btnChangeSign.Click += new System.EventHandler(this.AnvancedOperationInvoke);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 148);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 285);
            this.panel1.TabIndex = 6;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btn_Equal);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 433);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(250, 50);
            this.panel7.TabIndex = 7;
            // 
            // btn_Equal
            // 
            this.btn_Equal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(138)))), ((int)(((byte)(12)))));
            this.btn_Equal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Equal.FlatAppearance.BorderSize = 0;
            this.btn_Equal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Equal.Image = ((System.Drawing.Image)(resources.GetObject("btn_Equal.Image")));
            this.btn_Equal.Location = new System.Drawing.Point(0, 0);
            this.btn_Equal.Name = "btn_Equal";
            this.btn_Equal.Size = new System.Drawing.Size(250, 50);
            this.btn_Equal.TabIndex = 0;
            this.btn_Equal.UseVisualStyleBackColor = false;
            this.btn_Equal.Click += new System.EventHandler(this.btn_Equal_Click);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.btnShowAdvanced);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel8.Location = new System.Drawing.Point(0, 765);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(250, 15);
            this.panel8.TabIndex = 8;
            // 
            // btnShowAdvanced
            // 
            this.btnShowAdvanced.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(50)))), ((int)(((byte)(10)))));
            this.btnShowAdvanced.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnShowAdvanced.FlatAppearance.BorderSize = 0;
            this.btnShowAdvanced.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowAdvanced.Image = global::MyCalculator.Properties.Resources.expand_arrow_15px;
            this.btnShowAdvanced.Location = new System.Drawing.Point(0, 0);
            this.btnShowAdvanced.Name = "btnShowAdvanced";
            this.btnShowAdvanced.Size = new System.Drawing.Size(250, 15);
            this.btnShowAdvanced.TabIndex = 0;
            this.btnShowAdvanced.UseVisualStyleBackColor = false;
            this.btnShowAdvanced.Click += new System.EventHandler(this.btnShowAdvanced_Click);
            // 
            // panelAdvanced
            // 
            this.panelAdvanced.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(55)))), ((int)(((byte)(82)))));
            this.panelAdvanced.Controls.Add(this.panel12);
            this.panelAdvanced.Controls.Add(this.panel14);
            this.panelAdvanced.Controls.Add(this.panel13);
            this.panelAdvanced.Controls.Add(this.panel11);
            this.panelAdvanced.Controls.Add(this.panel10);
            this.panelAdvanced.Controls.Add(this.panel9);
            this.panelAdvanced.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAdvanced.Location = new System.Drawing.Point(0, 483);
            this.panelAdvanced.Name = "panelAdvanced";
            this.panelAdvanced.Size = new System.Drawing.Size(250, 282);
            this.panelAdvanced.TabIndex = 9;
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.rbRadian);
            this.panel12.Controls.Add(this.rbDegree);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel12.Location = new System.Drawing.Point(0, 235);
            this.panel12.Margin = new System.Windows.Forms.Padding(1);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(250, 47);
            this.panel12.TabIndex = 7;
            // 
            // rbRadian
            // 
            this.rbRadian.AutoSize = true;
            this.rbRadian.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbRadian.Location = new System.Drawing.Point(136, 11);
            this.rbRadian.Name = "rbRadian";
            this.rbRadian.Size = new System.Drawing.Size(102, 24);
            this.rbRadian.TabIndex = 0;
            this.rbRadian.Text = "Радианы";
            this.rbRadian.UseVisualStyleBackColor = true;
            // 
            // rbDegree
            // 
            this.rbDegree.AutoSize = true;
            this.rbDegree.Checked = true;
            this.rbDegree.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbDegree.Location = new System.Drawing.Point(8, 11);
            this.rbDegree.Name = "rbDegree";
            this.rbDegree.Size = new System.Drawing.Size(98, 24);
            this.rbDegree.TabIndex = 0;
            this.rbDegree.TabStop = true;
            this.rbDegree.Text = "Градусы";
            this.rbDegree.UseVisualStyleBackColor = true;
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.btnExp);
            this.panel14.Controls.Add(this.btn1DivideByX);
            this.panel14.Controls.Add(this.btтRoot3);
            this.panel14.Controls.Add(this.btnFactorial);
            this.panel14.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel14.Location = new System.Drawing.Point(0, 188);
            this.panel14.Margin = new System.Windows.Forms.Padding(1);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(250, 47);
            this.panel14.TabIndex = 6;
            // 
            // btnExp
            // 
            this.btnExp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExp.FlatAppearance.BorderSize = 0;
            this.btnExp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExp.Location = new System.Drawing.Point(186, 0);
            this.btnExp.Name = "btnExp";
            this.btnExp.Size = new System.Drawing.Size(64, 47);
            this.btnExp.TabIndex = 4;
            this.btnExp.Text = "exp(x)";
            this.btnExp.UseVisualStyleBackColor = true;
            this.btnExp.Click += new System.EventHandler(this.AnvancedOperationInvoke);
            // 
            // btn1DivideByX
            // 
            this.btn1DivideByX.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn1DivideByX.FlatAppearance.BorderSize = 0;
            this.btn1DivideByX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1DivideByX.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn1DivideByX.Location = new System.Drawing.Point(124, 0);
            this.btn1DivideByX.Name = "btn1DivideByX";
            this.btn1DivideByX.Size = new System.Drawing.Size(62, 47);
            this.btn1DivideByX.TabIndex = 3;
            this.btn1DivideByX.Text = "1/x";
            this.btn1DivideByX.UseVisualStyleBackColor = true;
            this.btn1DivideByX.Click += new System.EventHandler(this.AnvancedOperationInvoke);
            // 
            // btтRoot3
            // 
            this.btтRoot3.Dock = System.Windows.Forms.DockStyle.Left;
            this.btтRoot3.FlatAppearance.BorderSize = 0;
            this.btтRoot3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btтRoot3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btтRoot3.Location = new System.Drawing.Point(62, 0);
            this.btтRoot3.Name = "btтRoot3";
            this.btтRoot3.Size = new System.Drawing.Size(62, 47);
            this.btтRoot3.TabIndex = 2;
            this.btтRoot3.Text = "³√x";
            this.btтRoot3.UseVisualStyleBackColor = true;
            this.btтRoot3.Click += new System.EventHandler(this.AnvancedOperationInvoke);
            // 
            // btnFactorial
            // 
            this.btnFactorial.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnFactorial.FlatAppearance.BorderSize = 0;
            this.btnFactorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFactorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnFactorial.Location = new System.Drawing.Point(0, 0);
            this.btnFactorial.Name = "btnFactorial";
            this.btnFactorial.Size = new System.Drawing.Size(62, 47);
            this.btnFactorial.TabIndex = 1;
            this.btnFactorial.Text = "x!";
            this.btnFactorial.UseVisualStyleBackColor = true;
            this.btnFactorial.Click += new System.EventHandler(this.AnvancedOperationInvoke);
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.btnSquare);
            this.panel13.Controls.Add(this.btnAbs);
            this.panel13.Controls.Add(this.btnLog);
            this.panel13.Controls.Add(this.btnLn);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel13.Location = new System.Drawing.Point(0, 141);
            this.panel13.Margin = new System.Windows.Forms.Padding(1);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(250, 47);
            this.panel13.TabIndex = 5;
            // 
            // btnSquare
            // 
            this.btnSquare.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSquare.FlatAppearance.BorderSize = 0;
            this.btnSquare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSquare.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSquare.Location = new System.Drawing.Point(186, 0);
            this.btnSquare.Name = "btnSquare";
            this.btnSquare.Size = new System.Drawing.Size(64, 47);
            this.btnSquare.TabIndex = 3;
            this.btnSquare.Text = "x²";
            this.btnSquare.UseVisualStyleBackColor = true;
            this.btnSquare.Click += new System.EventHandler(this.AnvancedOperationInvoke);
            // 
            // btnAbs
            // 
            this.btnAbs.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAbs.FlatAppearance.BorderSize = 0;
            this.btnAbs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbs.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAbs.Location = new System.Drawing.Point(124, 0);
            this.btnAbs.Name = "btnAbs";
            this.btnAbs.Size = new System.Drawing.Size(62, 47);
            this.btnAbs.TabIndex = 2;
            this.btnAbs.Text = "|x|";
            this.btnAbs.UseVisualStyleBackColor = true;
            this.btnAbs.Click += new System.EventHandler(this.AnvancedOperationInvoke);
            // 
            // btnLog
            // 
            this.btnLog.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnLog.FlatAppearance.BorderSize = 0;
            this.btnLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLog.Location = new System.Drawing.Point(62, 0);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(62, 47);
            this.btnLog.TabIndex = 1;
            this.btnLog.Text = "log";
            this.btnLog.UseVisualStyleBackColor = true;
            this.btnLog.Click += new System.EventHandler(this.AnvancedOperationInvoke);
            // 
            // btnLn
            // 
            this.btnLn.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnLn.FlatAppearance.BorderSize = 0;
            this.btnLn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLn.Location = new System.Drawing.Point(0, 0);
            this.btnLn.Name = "btnLn";
            this.btnLn.Size = new System.Drawing.Size(62, 47);
            this.btnLn.TabIndex = 0;
            this.btnLn.Text = "ln";
            this.btnLn.UseVisualStyleBackColor = true;
            this.btnLn.Click += new System.EventHandler(this.AnvancedOperationInvoke);
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.btnRoot3);
            this.panel11.Controls.Add(this.btn10PowN);
            this.panel11.Controls.Add(this.btn2PowN);
            this.panel11.Controls.Add(this.btnRootN);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel11.Location = new System.Drawing.Point(0, 94);
            this.panel11.Margin = new System.Windows.Forms.Padding(1);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(250, 47);
            this.panel11.TabIndex = 3;
            // 
            // btnRoot3
            // 
            this.btnRoot3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRoot3.FlatAppearance.BorderSize = 0;
            this.btnRoot3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoot3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRoot3.Location = new System.Drawing.Point(186, 0);
            this.btnRoot3.Name = "btnRoot3";
            this.btnRoot3.Size = new System.Drawing.Size(64, 47);
            this.btnRoot3.TabIndex = 3;
            this.btnRoot3.Text = "x³";
            this.btnRoot3.UseVisualStyleBackColor = true;
            this.btnRoot3.Click += new System.EventHandler(this.AnvancedOperationInvoke);
            // 
            // btn10PowN
            // 
            this.btn10PowN.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn10PowN.FlatAppearance.BorderSize = 0;
            this.btn10PowN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn10PowN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn10PowN.Location = new System.Drawing.Point(124, 0);
            this.btn10PowN.Name = "btn10PowN";
            this.btn10PowN.Size = new System.Drawing.Size(62, 47);
            this.btn10PowN.TabIndex = 2;
            this.btn10PowN.Text = "10ⁿ";
            this.btn10PowN.UseVisualStyleBackColor = true;
            this.btn10PowN.Click += new System.EventHandler(this.AnvancedOperationInvoke);
            // 
            // btn2PowN
            // 
            this.btn2PowN.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn2PowN.FlatAppearance.BorderSize = 0;
            this.btn2PowN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2PowN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn2PowN.Location = new System.Drawing.Point(62, 0);
            this.btn2PowN.Name = "btn2PowN";
            this.btn2PowN.Size = new System.Drawing.Size(62, 47);
            this.btn2PowN.TabIndex = 1;
            this.btn2PowN.Text = "2ⁿ";
            this.btn2PowN.UseVisualStyleBackColor = true;
            this.btn2PowN.Click += new System.EventHandler(this.AnvancedOperationInvoke);
            // 
            // btnRootN
            // 
            this.btnRootN.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnRootN.FlatAppearance.BorderSize = 0;
            this.btnRootN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRootN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRootN.Location = new System.Drawing.Point(0, 0);
            this.btnRootN.Name = "btnRootN";
            this.btnRootN.Size = new System.Drawing.Size(62, 47);
            this.btnRootN.TabIndex = 0;
            this.btnRootN.Tag = "ⁿ√x";
            this.btnRootN.Text = "ⁿ√x";
            this.btnRootN.UseVisualStyleBackColor = true;
            this.btnRootN.Click += new System.EventHandler(this.BaseOperationInvoke);
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.btnPowN);
            this.panel10.Controls.Add(this.btnCTg);
            this.panel10.Controls.Add(this.btnCos_1);
            this.panel10.Controls.Add(this.btnCos);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel10.Location = new System.Drawing.Point(0, 47);
            this.panel10.Margin = new System.Windows.Forms.Padding(1);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(250, 47);
            this.panel10.TabIndex = 2;
            // 
            // btnPowN
            // 
            this.btnPowN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPowN.FlatAppearance.BorderSize = 0;
            this.btnPowN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPowN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPowN.Location = new System.Drawing.Point(186, 0);
            this.btnPowN.Name = "btnPowN";
            this.btnPowN.Size = new System.Drawing.Size(64, 47);
            this.btnPowN.TabIndex = 3;
            this.btnPowN.Tag = "xⁿ";
            this.btnPowN.Text = "xⁿ";
            this.btnPowN.UseVisualStyleBackColor = true;
            this.btnPowN.Click += new System.EventHandler(this.BaseOperationInvoke);
            // 
            // btnCTg
            // 
            this.btnCTg.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCTg.FlatAppearance.BorderSize = 0;
            this.btnCTg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCTg.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCTg.Location = new System.Drawing.Point(124, 0);
            this.btnCTg.Name = "btnCTg";
            this.btnCTg.Size = new System.Drawing.Size(62, 47);
            this.btnCTg.TabIndex = 2;
            this.btnCTg.Text = "ctg";
            this.btnCTg.UseVisualStyleBackColor = true;
            this.btnCTg.Click += new System.EventHandler(this.AnvancedOperationInvoke);
            // 
            // btnCos_1
            // 
            this.btnCos_1.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCos_1.FlatAppearance.BorderSize = 0;
            this.btnCos_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCos_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCos_1.Location = new System.Drawing.Point(62, 0);
            this.btnCos_1.Name = "btnCos_1";
            this.btnCos_1.Size = new System.Drawing.Size(62, 47);
            this.btnCos_1.TabIndex = 1;
            this.btnCos_1.Text = "cos⁻¹";
            this.btnCos_1.UseVisualStyleBackColor = true;
            this.btnCos_1.Click += new System.EventHandler(this.AnvancedOperationInvoke);
            // 
            // btnCos
            // 
            this.btnCos.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCos.FlatAppearance.BorderSize = 0;
            this.btnCos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCos.Location = new System.Drawing.Point(0, 0);
            this.btnCos.Name = "btnCos";
            this.btnCos.Size = new System.Drawing.Size(62, 47);
            this.btnCos.TabIndex = 0;
            this.btnCos.Text = "cos";
            this.btnCos.UseVisualStyleBackColor = true;
            this.btnCos.Click += new System.EventHandler(this.AnvancedOperationInvoke);
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.btnPI);
            this.panel9.Controls.Add(this.btnTg);
            this.panel9.Controls.Add(this.btnSin_1);
            this.panel9.Controls.Add(this.btnSin);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Margin = new System.Windows.Forms.Padding(1);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(250, 47);
            this.panel9.TabIndex = 1;
            // 
            // btnPI
            // 
            this.btnPI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPI.FlatAppearance.BorderSize = 0;
            this.btnPI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPI.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPI.Location = new System.Drawing.Point(186, 0);
            this.btnPI.Name = "btnPI";
            this.btnPI.Size = new System.Drawing.Size(64, 47);
            this.btnPI.TabIndex = 3;
            this.btnPI.Text = "π";
            this.btnPI.UseVisualStyleBackColor = true;
            this.btnPI.Click += new System.EventHandler(this.btnPI_Click);
            // 
            // btnTg
            // 
            this.btnTg.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnTg.FlatAppearance.BorderSize = 0;
            this.btnTg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTg.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTg.Location = new System.Drawing.Point(124, 0);
            this.btnTg.Name = "btnTg";
            this.btnTg.Size = new System.Drawing.Size(62, 47);
            this.btnTg.TabIndex = 2;
            this.btnTg.Text = "tg";
            this.btnTg.UseVisualStyleBackColor = true;
            this.btnTg.Click += new System.EventHandler(this.AnvancedOperationInvoke);
            // 
            // btnSin_1
            // 
            this.btnSin_1.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSin_1.FlatAppearance.BorderSize = 0;
            this.btnSin_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSin_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSin_1.Location = new System.Drawing.Point(62, 0);
            this.btnSin_1.Name = "btnSin_1";
            this.btnSin_1.Size = new System.Drawing.Size(62, 47);
            this.btnSin_1.TabIndex = 1;
            this.btnSin_1.Text = "sin⁻¹";
            this.btnSin_1.UseVisualStyleBackColor = true;
            this.btnSin_1.Click += new System.EventHandler(this.AnvancedOperationInvoke);
            // 
            // btnSin
            // 
            this.btnSin.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSin.FlatAppearance.BorderSize = 0;
            this.btnSin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSin.Location = new System.Drawing.Point(0, 0);
            this.btnSin.Name = "btnSin";
            this.btnSin.Size = new System.Drawing.Size(62, 47);
            this.btnSin.TabIndex = 0;
            this.btnSin.Text = "sin";
            this.btnSin.UseVisualStyleBackColor = true;
            this.btnSin.Click += new System.EventHandler(this.AnvancedOperationInvoke);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(51)))), ((int)(((byte)(75)))));
            this.ClientSize = new System.Drawing.Size(250, 780);
            this.Controls.Add(this.panelAdvanced);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.controlPanel);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Калькулятор";
            this.TopMost = true;
            this.controlPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panelAdvanced.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.panel14.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel controlPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnMult;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnClearPrev;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Button btnChangeSign;
        private System.Windows.Forms.Button btn_Comma;
        private System.Windows.Forms.Button btn_3;
        private System.Windows.Forms.Button btn_9;
        private System.Windows.Forms.Button btn_6;
        private System.Windows.Forms.Button btn_0;
        private System.Windows.Forms.Button btn_2;
        private System.Windows.Forms.Button btn_8;
        private System.Windows.Forms.Button btn_5;
        private System.Windows.Forms.Button btnSqrt;
        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.Button btn_4;
        private System.Windows.Forms.Button btn_7;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnPinActivate;
        private System.Windows.Forms.TextBox tbxInput;
        private System.Windows.Forms.Label lblOperation;
        private System.Windows.Forms.Label lblPrevInput;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btn_Equal;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btnShowAdvanced;
        private System.Windows.Forms.Panel panelAdvanced;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button btnSin;
        private System.Windows.Forms.Button btnPI;
        private System.Windows.Forms.Button btnTg;
        private System.Windows.Forms.Button btnSin_1;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Button btn1DivideByX;
        private System.Windows.Forms.Button btтRoot3;
        private System.Windows.Forms.Button btnFactorial;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Button btnSquare;
        private System.Windows.Forms.Button btnAbs;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.Button btnLn;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Button btnRoot3;
        private System.Windows.Forms.Button btn10PowN;
        private System.Windows.Forms.Button btn2PowN;
        private System.Windows.Forms.Button btnRootN;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button btnPowN;
        private System.Windows.Forms.Button btnCTg;
        private System.Windows.Forms.Button btnCos_1;
        private System.Windows.Forms.Button btnCos;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.RadioButton rbRadian;
        private System.Windows.Forms.RadioButton rbDegree;
        private System.Windows.Forms.Button btnExp;
    }
}

