using System.Reflection.Metadata.Ecma335;
using System.Windows.Forms.VisualStyles;

namespace GPA_Cal;

public partial class GPA_Calc : Form
{
    public GPA_Calc()
    {
        InitializeComponent();
    }

    // Converting Grade to Grade Points
    private static double Grade_to_GradePoint(string Grade)
    {
        if ((Grade == "A+") | (Grade == "A"))
        {
            return 4.00;
        }
        else if (Grade == "A-")
        {
            return 3.70;
        }
        else if (Grade == "B+")
        {
            return 3.30;
        }
        else if (Grade == "B")
        {
            return 3.00;
        }
        else if (Grade == "B-")
        {
            return 2.70;
        }
        else if (Grade == "C+")
        {
            return 2.30;
        }
        else if (Grade == "C")
        {
            return 2.00;
        }
        else if (Grade == "C-")
        {
            return 1.70;
        }
        else if (Grade == "D")
        {
            return 1.00;
        }
        else
        {
            return 0.00;
        }
    }

    private static double GPA_Calculator(double Maths, double CS, double Elec, double Mech, double Fluid, double Mat)
    {
        // Credit Points for each module
        int Maths_CP = 3, CS_CP = 3, Elec_CP = 2, Mech_CP = 2, Fluid_CP = 2, Mat_CP = 2;

        double Sum = Maths * Maths_CP + CS * CS_CP + Elec * Elec_CP + Mech * Mech_CP + Fluid * Fluid_CP + Mat * Mat_CP;

        int Total_CP = Maths_CP + CS_CP + Elec_CP + Mech_CP + Fluid_CP + Mat_CP;

        double GPA = Sum / Total_CP;

        return GPA;
    }

    private void Cal_Button_Click(object sender, EventArgs e)
    {
        // Extracting all the Grade Points from Grades

        double Maths = 0, CS = 0, Elec = 0, Mech = 0, Fluid = 0, Mat = 0;

        if (Grade_Maths.SelectedItem != null)
        {
            Maths = Grade_to_GradePoint(Grade_Maths.SelectedItem.ToString());
        }
        else
        {
            MessageBox.Show("Please select all the grades");
            return;
        }

        if (Grade_CS.SelectedItem != null)
        {
            CS = Grade_to_GradePoint(Grade_CS.SelectedItem.ToString());
        }
        else
        {
            MessageBox.Show("Please select all the grades");
            return;
        }

        if (Grade_Elec.SelectedItem != null)
        {
            Elec = Grade_to_GradePoint(Grade_Elec.SelectedItem.ToString());
        }
        else
        {
            MessageBox.Show("Please select all the grades");
            return;
        }

        if (Grade_Mech.SelectedItem != null)
        {
            Mech = Grade_to_GradePoint(Grade_Mech.SelectedItem.ToString());
        }
        else
        {
            MessageBox.Show("Please select all the grades");
            return;
        }

        if (Grade_Fluid.SelectedItem != null)
        {
            Fluid = Grade_to_GradePoint(Grade_Fluid.SelectedItem.ToString());
        }
        else
        {
            MessageBox.Show("Please select all the grades");
            return;
        }

        if (Grade_Mat.SelectedItem != null)
        {
            Mat = Grade_to_GradePoint(Grade_Mat.SelectedItem.ToString());
        }
        else
        {
            MessageBox.Show("Please select all the grades");
            return;
        }

        // Calculating GPA
        string GPA = GPA_Calculator(Maths, CS, Elec, Mech, Fluid, Mat).ToString("F2");

        Result.Text = "GPA = " + GPA;
        return;
    
    }
}
