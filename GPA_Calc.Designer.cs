using System.Diagnostics.Tracing;

namespace GPA_Cal;

    partial class GPA_Calc
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
        this.Grade_Maths = new System.Windows.Forms.ComboBox();
        this.Grade_CS = new System.Windows.Forms.ComboBox();
        this.Grade_Elec = new System.Windows.Forms.ComboBox();
        this.Grade_Mech = new System.Windows.Forms.ComboBox();
        this.Grade_Fluid = new System.Windows.Forms.ComboBox();
        this.Grade_Mat = new System.Windows.Forms.ComboBox();
        this.Maths_Text = new System.Windows.Forms.Label();
        this.CS_Text = new System.Windows.Forms.Label();
        this.Elec_Text = new System.Windows.Forms.Label();
        this.Mech_Text = new System.Windows.Forms.Label();
        this.Fluid_Text = new System.Windows.Forms.Label();
        this.Mat_Text = new System.Windows.Forms.Label();
        this.Cal_Button = new System.Windows.Forms.Button();
        this.Result = new System.Windows.Forms.Label();
        this.SuspendLayout();

     //
     // Main_Form
     //
        this.BackColor = System.Drawing.SystemColors.ControlLight;
        this.FormBorderStyle = FormBorderStyle.FixedSingle;
        this.MaximizeBox = false;
        this.KeyPreview =  true;
        this.Size = new System.Drawing.Size(320,436);
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text =  "GPA Calculator";
        this.Icon = new Icon("Assets/cal.ico");
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.Controls.Add(this.Grade_Maths);
        this.Controls.Add(this.Grade_CS);
        this.Controls.Add(this.Grade_Elec);
        this.Controls.Add(this.Grade_Mech);
        this.Controls.Add(this.Grade_Fluid);
        this.Controls.Add(this.Grade_Mat);
        this.Controls.Add(this.Maths_Text);
        this.Controls.Add(this.CS_Text);
        this.Controls.Add(this.Elec_Text);
        this.Controls.Add(this.Mech_Text);
        this.Controls.Add(this.Fluid_Text);
        this.Controls.Add(this.Mat_Text);
        this.Controls.Add(this.Cal_Button);
        this.Controls.Add(this.Result);
        this.ResumeLayout(false);
        

        string[] DropList = {"A+", "A", "A-", "B+", "B", "B-", "C+", "C", "C-", "D", "F"}; 

        // Alightment
        int LeftAlign = 24;
        int TopAlign = 28;
        int ShiftX = 125;
        int ShiftY = 45;

        //
        // Grade_Maths
        //
        this.Grade_Maths.ItemHeight = 20;
        this.Grade_Maths.Text =  "--Select--";
        this.Grade_Maths.Location = new System.Drawing.Point(LeftAlign + ShiftX,TopAlign - 4);
        this.Grade_Maths.TabIndex = 1;
        this.Grade_Maths.Items.AddRange(DropList);
        //
        // Grade_CS
        //
        this.Grade_CS.ItemHeight = 20;
        this.Grade_CS.Text =  "--Select--";
        this.Grade_CS.Location = new System.Drawing.Point(LeftAlign + ShiftX,this.Grade_Maths.Location.Y + ShiftY);
        this.Grade_CS.TabIndex = 2;
        this.Grade_CS.Items.AddRange(DropList);
        //
        // Grade_Elec
        //
        this.Grade_Elec.ItemHeight = 20;
        this.Grade_Elec.Text =  "--Select--";
        this.Grade_Elec.Location = new System.Drawing.Point(LeftAlign + ShiftX,this.Grade_CS.Location.Y + ShiftY);
        this.Grade_Elec.TabIndex = 3;
        this.Grade_Elec.Items.AddRange(DropList);
        //
        // Grade_Mech
        //
        this.Grade_Mech.ItemHeight = 20;
        this.Grade_Mech.Text =  "--Select--";
        this.Grade_Mech.Location = new System.Drawing.Point(LeftAlign + ShiftX,this.Grade_Elec.Location.Y + ShiftY);
        this.Grade_Mech.TabIndex = 4;
        this.Grade_Mech.Items.AddRange(DropList);
        //
        // Grade_Fluid
        //
        this.Grade_Fluid.ItemHeight = 20;
        this.Grade_Fluid.Text =  "--Select--";
        this.Grade_Fluid.Location = new System.Drawing.Point(LeftAlign + ShiftX,this.Grade_Mech.Location.Y + ShiftY);
        this.Grade_Fluid.TabIndex = 5;
        this.Grade_Fluid.Items.AddRange(DropList);
        //
        // Grade_Mat
        //
        this.Grade_Mat.ItemHeight = 20;
        this.Grade_Mat.Text =  "--Select--";
        this.Grade_Mat.Location = new System.Drawing.Point(LeftAlign + ShiftX,this.Grade_Fluid.Location.Y + ShiftY);
        this.Grade_Mat.TabIndex = 6;
        this.Grade_Mat.Items.AddRange(DropList);
        //
        // Maths_Text
        //
        this.Maths_Text.AutoSize =  true;
        this.Maths_Text.Text =  "Mathematics";
        this.Maths_Text.BackColor = System.Drawing.SystemColors.ControlLight;
        this.Maths_Text.Location = new System.Drawing.Point(LeftAlign,TopAlign);
        this.Maths_Text.Size = new System.Drawing.Size(94,20);
        this.Maths_Text.TabIndex = 7;
        //
        // CS_Text
        //
        this.CS_Text.AutoSize =  true;
        this.CS_Text.Text =  "Programming";
        this.CS_Text.BackColor = System.Drawing.SystemColors.ControlLight;
        this.CS_Text.Location = new System.Drawing.Point(LeftAlign,Maths_Text.Location.Y + ShiftY);
        this.CS_Text.Size = new System.Drawing.Size(100,20);
        this.CS_Text.TabIndex = 8;
        //
        // Elec_Text
        //
        this.Elec_Text.AutoSize =  true;
        this.Elec_Text.Text =  "Electrical";
        this.Elec_Text.BackColor = System.Drawing.SystemColors.ControlLight;
        this.Elec_Text.Location = new System.Drawing.Point(LeftAlign,CS_Text.Location.Y + ShiftY);
        this.Elec_Text.Size = new System.Drawing.Size(69,20);
        this.Elec_Text.TabIndex = 9;
        //
        // Mech_Text
        //
        this.Mech_Text.AutoSize =  true;
        this.Mech_Text.Text =  "Mechanics";
        this.Mech_Text.BackColor = System.Drawing.SystemColors.ControlLight;
        this.Mech_Text.Location = new System.Drawing.Point(LeftAlign,Elec_Text.Location.Y + ShiftY);
        this.Mech_Text.Size = new System.Drawing.Size(78,20);
        this.Mech_Text.TabIndex = 10;
        //
        // Fluid_Text
        //
        this.Fluid_Text.AutoSize =  true;
        this.Fluid_Text.Text =  "Fluid";
        this.Fluid_Text.BackColor = System.Drawing.SystemColors.ControlLight;
        this.Fluid_Text.Location = new System.Drawing.Point(LeftAlign,Mech_Text.Location.Y + ShiftY);
        this.Fluid_Text.Size = new System.Drawing.Size(41,20);
        this.Fluid_Text.TabIndex = 11;
        //
        // Mat_Text
        //
        this.Mat_Text.AutoSize =  true;
        this.Mat_Text.Text =  "Material";
        this.Mat_Text.BackColor = System.Drawing.SystemColors.ControlLight;
        this.Mat_Text.Location = new System.Drawing.Point(LeftAlign,Fluid_Text.Location.Y + ShiftY);
        this.Mat_Text.Size = new System.Drawing.Size(64,20);
        this.Mat_Text.TabIndex = 12;
        //
        // Cal_Button
        //
        this.Cal_Button.BackColor = System.Drawing.SystemColors.ActiveCaption;
        this.Cal_Button.Text =  "Calculate";
        this.Cal_Button.Size = new System.Drawing.Size(112,40);
        this.Cal_Button.Location = new System.Drawing.Point((this.ClientSize.Width - this.Cal_Button.Size.Width)/2, Mat_Text.Location.Y + ShiftY);
        this.Cal_Button.TabIndex = 13;
        this.Cal_Button.Click += Cal_Button_Click;
        //
        // Result
        //
        this.Result.AutoSize =  true;
        this.Result.BackColor = System.Drawing.SystemColors.ControlLight;
        this.Result.Size = new System.Drawing.Size(0,20);
        this.Result.Location = new System.Drawing.Point(this.Cal_Button.Location.X + 18, Cal_Button.Location.Y + ShiftY + 5);
        this.Result.TabIndex = 14;

    } 

    #endregion 

    private System.Windows.Forms.ComboBox Grade_Maths;
    private System.Windows.Forms.ComboBox Grade_CS;
    private System.Windows.Forms.ComboBox Grade_Elec;
    private System.Windows.Forms.ComboBox Grade_Mech;
    private System.Windows.Forms.ComboBox Grade_Fluid;
    private System.Windows.Forms.ComboBox Grade_Mat;
    private System.Windows.Forms.Label Maths_Text;
    private System.Windows.Forms.Label CS_Text;
    private System.Windows.Forms.Label Elec_Text;
    private System.Windows.Forms.Label Mech_Text;
    private System.Windows.Forms.Label Fluid_Text;
    private System.Windows.Forms.Label Mat_Text;
    private System.Windows.Forms.Button Cal_Button;
    private System.Windows.Forms.Label Result;
}

