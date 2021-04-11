namespace Scientific_Calculator
{
    partial class ScientificCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScientificCalculator));
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSquare = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnEqual = new System.Windows.Forms.Button();
            this.btnDOT = new System.Windows.Forms.Button();
            this.btnModulo = new System.Windows.Forms.Button();
            this.btnDivision = new System.Windows.Forms.Button();
            this.btnMultiplication = new System.Windows.Forms.Button();
            this.btnSubtraction = new System.Windows.Forms.Button();
            this.btnSquareRoot = new System.Windows.Forms.Button();
            this.btnTAN = new System.Windows.Forms.Button();
            this.btnCOS = new System.Windows.Forms.Button();
            this.btnSIN = new System.Windows.Forms.Button();
            this.btnNo0 = new System.Windows.Forms.Button();
            this.btnNo9 = new System.Windows.Forms.Button();
            this.btnNo8 = new System.Windows.Forms.Button();
            this.btnNo7 = new System.Windows.Forms.Button();
            this.btnNo6 = new System.Windows.Forms.Button();
            this.btnNo5 = new System.Windows.Forms.Button();
            this.btnNo4 = new System.Windows.Forms.Button();
            this.btnNo3 = new System.Windows.Forms.Button();
            this.btnNo2 = new System.Windows.Forms.Button();
            this.btnNo1 = new System.Windows.Forms.Button();
            this.btnAddition = new System.Windows.Forms.Button();
            this.btnlog = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDisplay
            // 
            this.txtDisplay.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisplay.Location = new System.Drawing.Point(10, 29);
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtDisplay.Size = new System.Drawing.Size(353, 26);
            this.txtDisplay.TabIndex = 0;
            this.txtDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDisplay.TextAlignChanged += new System.EventHandler(this.txtDisplay_TextChanged);
            this.txtDisplay.TextChanged += new System.EventHandler(this.txtDisplay_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnlog);
            this.panel1.Controls.Add(this.btnSquare);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.btnEqual);
            this.panel1.Controls.Add(this.btnDOT);
            this.panel1.Controls.Add(this.btnModulo);
            this.panel1.Controls.Add(this.btnDivision);
            this.panel1.Controls.Add(this.btnMultiplication);
            this.panel1.Controls.Add(this.btnSubtraction);
            this.panel1.Controls.Add(this.btnAddition);
            this.panel1.Controls.Add(this.btnSquareRoot);
            this.panel1.Controls.Add(this.btnTAN);
            this.panel1.Controls.Add(this.btnCOS);
            this.panel1.Controls.Add(this.btnSIN);
            this.panel1.Controls.Add(this.btnNo0);
            this.panel1.Controls.Add(this.btnNo9);
            this.panel1.Controls.Add(this.btnNo8);
            this.panel1.Controls.Add(this.btnNo7);
            this.panel1.Controls.Add(this.btnNo6);
            this.panel1.Controls.Add(this.btnNo5);
            this.panel1.Controls.Add(this.btnNo4);
            this.panel1.Controls.Add(this.btnNo3);
            this.panel1.Controls.Add(this.btnNo2);
            this.panel1.Controls.Add(this.btnNo1);
            this.panel1.Location = new System.Drawing.Point(0, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(377, 233);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnSquare
            // 
            this.btnSquare.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSquare.Location = new System.Drawing.Point(183, 116);
            this.btnSquare.Name = "btnSquare";
            this.btnSquare.Size = new System.Drawing.Size(56, 46);
            this.btnSquare.TabIndex = 25;
            this.btnSquare.Text = "x^y";
            this.btnSquare.UseVisualStyleBackColor = true;
            this.btnSquare.Click += new System.EventHandler(this.btnSquare_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(183, 12);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(56, 46);
            this.btnClear.TabIndex = 24;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnEqual
            // 
            this.btnEqual.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEqual.Location = new System.Drawing.Point(114, 168);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(46, 46);
            this.btnEqual.TabIndex = 23;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = true;
            this.btnEqual.Click += new System.EventHandler(this.btnEqual_Click);
            // 
            // btnDOT
            // 
            this.btnDOT.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDOT.Location = new System.Drawing.Point(10, 168);
            this.btnDOT.Name = "btnDOT";
            this.btnDOT.Size = new System.Drawing.Size(46, 46);
            this.btnDOT.TabIndex = 22;
            this.btnDOT.Text = ".";
            this.btnDOT.UseVisualStyleBackColor = true;
            this.btnDOT.Click += new System.EventHandler(this.btnDOT_Click);
            // 
            // btnModulo
            // 
            this.btnModulo.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModulo.Location = new System.Drawing.Point(305, 117);
            this.btnModulo.Name = "btnModulo";
            this.btnModulo.Size = new System.Drawing.Size(56, 46);
            this.btnModulo.TabIndex = 21;
            this.btnModulo.Text = "%";
            this.btnModulo.UseVisualStyleBackColor = true;
            this.btnModulo.Click += new System.EventHandler(this.btnModulo_Click);
            // 
            // btnDivision
            // 
            this.btnDivision.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivision.Location = new System.Drawing.Point(307, 64);
            this.btnDivision.Name = "btnDivision";
            this.btnDivision.Size = new System.Drawing.Size(56, 46);
            this.btnDivision.TabIndex = 20;
            this.btnDivision.Text = "/";
            this.btnDivision.UseVisualStyleBackColor = true;
            this.btnDivision.Click += new System.EventHandler(this.btnDivision_Click);
            // 
            // btnMultiplication
            // 
            this.btnMultiplication.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiplication.Location = new System.Drawing.Point(307, 12);
            this.btnMultiplication.Name = "btnMultiplication";
            this.btnMultiplication.Size = new System.Drawing.Size(56, 46);
            this.btnMultiplication.TabIndex = 19;
            this.btnMultiplication.Text = "*";
            this.btnMultiplication.UseVisualStyleBackColor = true;
            this.btnMultiplication.Click += new System.EventHandler(this.btnMultiplication_Click);
            // 
            // btnSubtraction
            // 
            this.btnSubtraction.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubtraction.Location = new System.Drawing.Point(245, 12);
            this.btnSubtraction.Name = "btnSubtraction";
            this.btnSubtraction.Size = new System.Drawing.Size(56, 46);
            this.btnSubtraction.TabIndex = 18;
            this.btnSubtraction.Text = "-";
            this.btnSubtraction.UseVisualStyleBackColor = true;
            this.btnSubtraction.Click += new System.EventHandler(this.btnSubtraction_Click);
            // 
            // btnSquareRoot
            // 
            this.btnSquareRoot.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSquareRoot.Location = new System.Drawing.Point(245, 117);
            this.btnSquareRoot.Name = "btnSquareRoot";
            this.btnSquareRoot.Size = new System.Drawing.Size(56, 46);
            this.btnSquareRoot.TabIndex = 15;
            this.btnSquareRoot.Text = "√";
            this.btnSquareRoot.UseVisualStyleBackColor = true;
            this.btnSquareRoot.Click += new System.EventHandler(this.btnSquareRoot_Click);
            // 
            // btnTAN
            // 
            this.btnTAN.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTAN.Location = new System.Drawing.Point(307, 169);
            this.btnTAN.Name = "btnTAN";
            this.btnTAN.Size = new System.Drawing.Size(56, 46);
            this.btnTAN.TabIndex = 13;
            this.btnTAN.Text = "tan";
            this.btnTAN.UseVisualStyleBackColor = true;
            this.btnTAN.Click += new System.EventHandler(this.btnTAN_Click);
            // 
            // btnCOS
            // 
            this.btnCOS.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCOS.Location = new System.Drawing.Point(245, 169);
            this.btnCOS.Name = "btnCOS";
            this.btnCOS.Size = new System.Drawing.Size(56, 46);
            this.btnCOS.TabIndex = 12;
            this.btnCOS.Text = "cos";
            this.btnCOS.UseVisualStyleBackColor = true;
            this.btnCOS.Click += new System.EventHandler(this.btnCOS_Click);
            // 
            // btnSIN
            // 
            this.btnSIN.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSIN.Location = new System.Drawing.Point(183, 168);
            this.btnSIN.Name = "btnSIN";
            this.btnSIN.Size = new System.Drawing.Size(56, 46);
            this.btnSIN.TabIndex = 11;
            this.btnSIN.Text = "sin";
            this.btnSIN.UseVisualStyleBackColor = true;
            this.btnSIN.Click += new System.EventHandler(this.btnSIN_Click);
            // 
            // btnNo0
            // 
            this.btnNo0.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNo0.Location = new System.Drawing.Point(62, 168);
            this.btnNo0.Name = "btnNo0";
            this.btnNo0.Size = new System.Drawing.Size(46, 46);
            this.btnNo0.TabIndex = 10;
            this.btnNo0.Text = "0";
            this.btnNo0.UseVisualStyleBackColor = true;
            this.btnNo0.Click += new System.EventHandler(this.btnNo0_Click);
            // 
            // btnNo9
            // 
            this.btnNo9.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNo9.Location = new System.Drawing.Point(114, 116);
            this.btnNo9.Name = "btnNo9";
            this.btnNo9.Size = new System.Drawing.Size(46, 46);
            this.btnNo9.TabIndex = 9;
            this.btnNo9.Text = "9";
            this.btnNo9.UseVisualStyleBackColor = true;
            this.btnNo9.Click += new System.EventHandler(this.btnNo9_Click);
            // 
            // btnNo8
            // 
            this.btnNo8.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNo8.Location = new System.Drawing.Point(62, 116);
            this.btnNo8.Name = "btnNo8";
            this.btnNo8.Size = new System.Drawing.Size(46, 46);
            this.btnNo8.TabIndex = 8;
            this.btnNo8.Text = "8";
            this.btnNo8.UseVisualStyleBackColor = true;
            this.btnNo8.Click += new System.EventHandler(this.btnNo8_Click);
            // 
            // btnNo7
            // 
            this.btnNo7.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNo7.Location = new System.Drawing.Point(10, 116);
            this.btnNo7.Name = "btnNo7";
            this.btnNo7.Size = new System.Drawing.Size(46, 46);
            this.btnNo7.TabIndex = 7;
            this.btnNo7.Text = "7";
            this.btnNo7.UseVisualStyleBackColor = true;
            this.btnNo7.Click += new System.EventHandler(this.btnNo7_Click);
            // 
            // btnNo6
            // 
            this.btnNo6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNo6.Location = new System.Drawing.Point(114, 64);
            this.btnNo6.Name = "btnNo6";
            this.btnNo6.Size = new System.Drawing.Size(46, 46);
            this.btnNo6.TabIndex = 6;
            this.btnNo6.Text = "6";
            this.btnNo6.UseVisualStyleBackColor = true;
            this.btnNo6.Click += new System.EventHandler(this.btnNo6_Click);
            // 
            // btnNo5
            // 
            this.btnNo5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNo5.Location = new System.Drawing.Point(62, 64);
            this.btnNo5.Name = "btnNo5";
            this.btnNo5.Size = new System.Drawing.Size(46, 46);
            this.btnNo5.TabIndex = 5;
            this.btnNo5.Text = "5";
            this.btnNo5.UseVisualStyleBackColor = true;
            this.btnNo5.Click += new System.EventHandler(this.btnNo5_Click);
            // 
            // btnNo4
            // 
            this.btnNo4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNo4.Location = new System.Drawing.Point(10, 64);
            this.btnNo4.Name = "btnNo4";
            this.btnNo4.Size = new System.Drawing.Size(46, 46);
            this.btnNo4.TabIndex = 4;
            this.btnNo4.Text = "4";
            this.btnNo4.UseVisualStyleBackColor = true;
            this.btnNo4.Click += new System.EventHandler(this.btnNo4_Click);
            // 
            // btnNo3
            // 
            this.btnNo3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNo3.Location = new System.Drawing.Point(114, 12);
            this.btnNo3.Name = "btnNo3";
            this.btnNo3.Size = new System.Drawing.Size(46, 46);
            this.btnNo3.TabIndex = 3;
            this.btnNo3.Text = "3";
            this.btnNo3.UseVisualStyleBackColor = true;
            this.btnNo3.Click += new System.EventHandler(this.btnNo3_Click);
            // 
            // btnNo2
            // 
            this.btnNo2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNo2.Location = new System.Drawing.Point(62, 12);
            this.btnNo2.Name = "btnNo2";
            this.btnNo2.Size = new System.Drawing.Size(46, 46);
            this.btnNo2.TabIndex = 2;
            this.btnNo2.Text = "2";
            this.btnNo2.UseVisualStyleBackColor = true;
            this.btnNo2.Click += new System.EventHandler(this.btnNo2_Click);
            // 
            // btnNo1
            // 
            this.btnNo1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNo1.Location = new System.Drawing.Point(10, 12);
            this.btnNo1.Name = "btnNo1";
            this.btnNo1.Size = new System.Drawing.Size(46, 46);
            this.btnNo1.TabIndex = 1;
            this.btnNo1.Text = "1";
            this.btnNo1.UseVisualStyleBackColor = true;
            this.btnNo1.Click += new System.EventHandler(this.btnNo1_Click);
            // 
            // btnAddition
            // 
            this.btnAddition.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddition.Location = new System.Drawing.Point(183, 64);
            this.btnAddition.Name = "btnAddition";
            this.btnAddition.Size = new System.Drawing.Size(56, 46);
            this.btnAddition.TabIndex = 17;
            this.btnAddition.Text = "+";
            this.btnAddition.UseVisualStyleBackColor = true;
            this.btnAddition.Click += new System.EventHandler(this.btnAddition_Click);
            // 
            // btnlog
            // 
            this.btnlog.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlog.Location = new System.Drawing.Point(245, 64);
            this.btnlog.Name = "btnlog";
            this.btnlog.Size = new System.Drawing.Size(56, 46);
            this.btnlog.TabIndex = 26;
            this.btnlog.Text = "log";
            this.btnlog.UseVisualStyleBackColor = true;
            this.btnlog.Click += new System.EventHandler(this.btnlog_Click);
            // 
            // ScientificCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 312);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtDisplay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ScientificCalculator";
            this.Text = "Scientific Calculator";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnNo0;
        private System.Windows.Forms.Button btnNo9;
        private System.Windows.Forms.Button btnNo8;
        private System.Windows.Forms.Button btnNo7;
        private System.Windows.Forms.Button btnNo6;
        private System.Windows.Forms.Button btnNo5;
        private System.Windows.Forms.Button btnNo4;
        private System.Windows.Forms.Button btnNo3;
        private System.Windows.Forms.Button btnNo2;
        private System.Windows.Forms.Button btnNo1;
        private System.Windows.Forms.Button btnSquareRoot;
        private System.Windows.Forms.Button btnTAN;
        private System.Windows.Forms.Button btnCOS;
        private System.Windows.Forms.Button btnSIN;
        private System.Windows.Forms.Button btnModulo;
        private System.Windows.Forms.Button btnDivision;
        private System.Windows.Forms.Button btnMultiplication;
        private System.Windows.Forms.Button btnSubtraction;
        private System.Windows.Forms.Button btnEqual;
        private System.Windows.Forms.Button btnDOT;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSquare;
        private System.Windows.Forms.Button btnlog;
        private System.Windows.Forms.Button btnAddition;
    }
}

