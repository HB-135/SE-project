using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;


namespace LoginForm
{
    public partial class DiplomaPlanAdd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SaveButton_Click(object sender, EventArgs e)
        {
            string idCollegeconcerned = Collegeconcerned.Text;
            string iddepartmentresponsible = departmentresponsible.Text;
            string iddegreeArabic = degreeArabic.Text;
            string iddegreeEnglish = degreeEnglish.Text;
                   
            string idsymbol = symbol.Text;
            string iddepartment = department.Text;
                   
            string idFirstpriority = Firstpriority.Text;
            string idSecondpriority = Secondpriority.Text;

            string idr1planNumber1 = r1planNumber1.Text;
            string idr1planNumber2 = r1planNumber2.Text;
            string idr1planNumber3 = r1planNumber3.Text;
            string idr1planNumber4 = r1planNumber4.Text;
            string idr1planNumber5 = r1planNumber5.Text;
                   
            string idr2planNumber1 = r2planNumber1.Text;
            string idr2planNumber2 = r2planNumber2.Text;
            string idr2planNumber3 = r2planNumber3.Text;
            string idr2planNumber4 = r2planNumber4.Text;
            string idr2planNumber5 = r2planNumber5.Text;
                   
            string idr3planNumber1 = r3planNumber1.Text;
            string idr3planNumber2 = r3planNumber2.Text;
            string idr3planNumber3 = r3planNumber3.Text;
            string idr3planNumber4 = r3planNumber4.Text;
            string idr3planNumber5 = r3planNumber5.Text;
                   
            string idr4planNumber1 = r4planNumber1.Text;
            string idr4planNumber2 = r4planNumber2.Text;
            string idr4planNumber3 = r4planNumber3.Text;
            string idr4planNumber4 = r4planNumber4.Text;
            string idr4planNumber5 = r4planNumber5.Text;
                   
            string idr5planNumber1 = r5planNumber1.Text;
            string idr5planNumber2 = r5planNumber2.Text;
            string idr5planNumber3 = r5planNumber3.Text;
            string idr5planNumber4 = r5planNumber4.Text;
            string idr5planNumber5 = r5planNumber5.Text;
                   
            string idr6planNumber1 = r6planNumber1.Text;
            string idr6planNumber2 = r6planNumber2.Text;
            string idr6planNumber3 = r6planNumber3.Text;
            string idr6planNumber4 = r6planNumber4.Text;
            string idr6planNumber5 = r6planNumber5.Text;
                   
            string idr7planNumber1 = r7planNumber1.Text;
            string idr7planNumber2 = r7planNumber2.Text;
            string idr7planNumber3 = r7planNumber3.Text;
            string idr7planNumber4 = r7planNumber4.Text;
            string idr7planNumber5 = r7planNumber5.Text;
                   
            string idr8planNumber1 = r8planNumber1.Text;
            string idr8planNumber2 = r8planNumber2.Text;
            string idr8planNumber3 = r8planNumber3.Text;
            string idr8planNumber4 = r8planNumber4.Text;
            string idr8planNumber5 = r8planNumber5.Text;
                   
            string idtotal1 = total1.Text;
            string idtotal2 = total2.Text;
            string idtotal3 = total3.Text;
            

            string connectionString = "Data Source=LAPTOP-P9J5GESD\\SQLEXPRESS;Initial Catalog=asplogin;Integrated Security=True;TrustServerCertificate=True";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"
    INSERT INTO DiplomaPlans (
        CollegeConcerned, DepartmentResponsible, DegreeArabic, DegreeEnglish, 
        Symbol, Department, 
        FirstPriority, SecondPriority,
        R1PlanNumber1, R1PlanNumber2, R1PlanNumber3, R1PlanNumber4, R1PlanNumber5,
        R2PlanNumber1, R2PlanNumber2, R2PlanNumber3, R2PlanNumber4, R2PlanNumber5,
        R3PlanNumber1, R3PlanNumber2, R3PlanNumber3, R3PlanNumber4, R3PlanNumber5,
        R4PlanNumber1, R4PlanNumber2, R4PlanNumber3, R4PlanNumber4, R4PlanNumber5,
        R5PlanNumber1, R5PlanNumber2, R5PlanNumber3, R5PlanNumber4, R5PlanNumber5,
        R6PlanNumber1, R6PlanNumber2, R6PlanNumber3, R6PlanNumber4, R6PlanNumber5,
        R7PlanNumber1, R7PlanNumber2, R7PlanNumber3, R7PlanNumber4, R7PlanNumber5,
        R8PlanNumber1, R8PlanNumber2, R8PlanNumber3, R8PlanNumber4, R8PlanNumber5,
        Total1, Total2, Total3
    ) 
    VALUES (
        @CollegeConcerned, @DepartmentResponsible, @DegreeArabic, @DegreeEnglish, 
        @Symbol, @Department, 
        @FirstPriority, @SecondPriority,
        @R1PlanNumber1, @R1PlanNumber2, @R1PlanNumber3, @R1PlanNumber4, @R1PlanNumber5,
        @R2PlanNumber1, @R2PlanNumber2, @R2PlanNumber3, @R2PlanNumber4, @R2PlanNumber5,
        @R3PlanNumber1, @R3PlanNumber2, @R3PlanNumber3, @R3PlanNumber4, @R3PlanNumber5,
        @R4PlanNumber1, @R4PlanNumber2, @R4PlanNumber3, @R4PlanNumber4, @R4PlanNumber5,
        @R5PlanNumber1, @R5PlanNumber2, @R5PlanNumber3, @R5PlanNumber4, @R5PlanNumber5,
        @R6PlanNumber1, @R6PlanNumber2, @R6PlanNumber3, @R6PlanNumber4, @R6PlanNumber5,
        @R7PlanNumber1, @R7PlanNumber2, @R7PlanNumber3, @R7PlanNumber4, @R7PlanNumber5,
        @R8PlanNumber1, @R8PlanNumber2, @R8PlanNumber3, @R8PlanNumber4, @R8PlanNumber5,
        @Total1, @Total2, @Total3
    )";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    // General Information
                    cmd.Parameters.AddWithValue("@CollegeConcerned", idCollegeconcerned);
                    cmd.Parameters.AddWithValue("@DepartmentResponsible", iddepartmentresponsible);
                    cmd.Parameters.AddWithValue("@DegreeArabic", iddegreeArabic);
                    cmd.Parameters.AddWithValue("@DegreeEnglish", iddegreeEnglish);

                    // Symbol and Department
                    cmd.Parameters.AddWithValue("@Symbol", idsymbol);
                    cmd.Parameters.AddWithValue("@Department", iddepartment);

                    // Priorities
                    cmd.Parameters.AddWithValue("@FirstPriority", idFirstpriority);
                    cmd.Parameters.AddWithValue("@SecondPriority", idSecondpriority);

                    // Plan Numbers R1 to R8
                    cmd.Parameters.AddWithValue("@R1PlanNumber1", idr1planNumber1);
                    cmd.Parameters.AddWithValue("@R1PlanNumber2", idr1planNumber2);
                    cmd.Parameters.AddWithValue("@R1PlanNumber3", idr1planNumber3);
                    cmd.Parameters.AddWithValue("@R1PlanNumber4", idr1planNumber4);
                    cmd.Parameters.AddWithValue("@R1PlanNumber5", idr1planNumber5);

                    cmd.Parameters.AddWithValue("@R2PlanNumber1", idr2planNumber1);
                    cmd.Parameters.AddWithValue("@R2PlanNumber2", idr2planNumber2);
                    cmd.Parameters.AddWithValue("@R2PlanNumber3", idr2planNumber3);
                    cmd.Parameters.AddWithValue("@R2PlanNumber4", idr2planNumber4);
                    cmd.Parameters.AddWithValue("@R2PlanNumber5", idr2planNumber5);

                    cmd.Parameters.AddWithValue("@R3PlanNumber1", idr3planNumber1);
                    cmd.Parameters.AddWithValue("@R3PlanNumber2", idr3planNumber2);
                    cmd.Parameters.AddWithValue("@R3PlanNumber3", idr3planNumber3);
                    cmd.Parameters.AddWithValue("@R3PlanNumber4", idr3planNumber4);
                    cmd.Parameters.AddWithValue("@R3PlanNumber5", idr3planNumber5);

                    cmd.Parameters.AddWithValue("@R4PlanNumber1", idr4planNumber1);
                    cmd.Parameters.AddWithValue("@R4PlanNumber2", idr4planNumber2);
                    cmd.Parameters.AddWithValue("@R4PlanNumber3", idr4planNumber3);
                    cmd.Parameters.AddWithValue("@R4PlanNumber4", idr4planNumber4);
                    cmd.Parameters.AddWithValue("@R4PlanNumber5", idr4planNumber5);

                    cmd.Parameters.AddWithValue("@R5PlanNumber1", idr5planNumber1);
                    cmd.Parameters.AddWithValue("@R5PlanNumber2", idr5planNumber2);
                    cmd.Parameters.AddWithValue("@R5PlanNumber3", idr5planNumber3);
                    cmd.Parameters.AddWithValue("@R5PlanNumber4", idr5planNumber4);
                    cmd.Parameters.AddWithValue("@R5PlanNumber5", idr5planNumber5);

                    cmd.Parameters.AddWithValue("@R6PlanNumber1", idr6planNumber1);
                    cmd.Parameters.AddWithValue("@R6PlanNumber2", idr6planNumber2);
                    cmd.Parameters.AddWithValue("@R6PlanNumber3", idr6planNumber3);
                    cmd.Parameters.AddWithValue("@R6PlanNumber4", idr6planNumber4);
                    cmd.Parameters.AddWithValue("@R6PlanNumber5", idr6planNumber5);

                    cmd.Parameters.AddWithValue("@R7PlanNumber1", idr7planNumber1);
                    cmd.Parameters.AddWithValue("@R7PlanNumber2", idr7planNumber2);
                    cmd.Parameters.AddWithValue("@R7PlanNumber3", idr7planNumber3);
                    cmd.Parameters.AddWithValue("@R7PlanNumber4", idr7planNumber4);
                    cmd.Parameters.AddWithValue("@R7PlanNumber5", idr7planNumber5);

                    cmd.Parameters.AddWithValue("@R8PlanNumber1", idr8planNumber1);
                    cmd.Parameters.AddWithValue("@R8PlanNumber2", idr8planNumber2);
                    cmd.Parameters.AddWithValue("@R8PlanNumber3", idr8planNumber3);
                    cmd.Parameters.AddWithValue("@R8PlanNumber4", idr8planNumber4);
                    cmd.Parameters.AddWithValue("@R8PlanNumber5", idr8planNumber5);

                    // Total Values
                    cmd.Parameters.AddWithValue("@Total1", idtotal1);
                    cmd.Parameters.AddWithValue("@Total2", idtotal2);
                    cmd.Parameters.AddWithValue("@Total3", idtotal3);

                    cmd.ExecuteNonQuery();
                }

            }

            Response.Write("<script>alert('Data saved successfully.');</script>");
        }
    }
}