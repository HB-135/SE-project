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
    public partial class MasterPlanAdd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SaveButton_Click(object sender, EventArgs e)
        {
            // Extract values from the form
            string selectedCollege = college.SelectedValue;
            string selectedDepartment = department.SelectedValue;
            string degreeInArabic = degreeArabic.Text;
            string degreeInEnglish = degreeEnglish.Text;

            string idplanNumber1 = planNumber1.Text;
            string idplanNumber2 = planNumber2.Text;
            string idplanNumber3 = planNumber3.Text;
            string idplanNumber4 = planNumber4.Text;
            string idplanNumber5 = planNumber5.Text;
            string idplanNumber6 = planNumber6.Text;

            string idFirstPriorityDegree1 = FirstPriorityDegree1.Text;
            string idSecondPriorityDegree1 = SecondPriorityDegree1.Text;
            string idCustomTextBox = CustomTextBox.Text;
            string idTextBox1 = TextBox1.Text;

            string idSubjectNumber1 = SubjectNumber1.Text;
            string idSubjectNumber2 = SubjectNumber2.Text;
            string idSubjectNumber3 = SubjectNumber3.Text;
            string idSubjectNumber4 = SubjectNumber4.Text;
            string idSubjectNumber5 = SubjectNumber5.Text;
            string idSubjectNumber6 = SubjectNumber6.Text;

            string idStyledTextBox = StyledTextBox.Text;
            string idOptionalSubject1 = OptionalSubject1.Text;
            string idOptionalSubject2 = OptionalSubject2.Text;
            string idOptionalSubject3 = OptionalSubject3.Text;
            string idOptionalSubject4 = OptionalSubject4.Text;
            string idOptionalSubject5 = OptionalSubject5.Text;
            string idOptionalSubject6 = OptionalSubject6.Text;

            string idStyledTextBox50px = StyledTextBox50px.Text;
            string idTextBox50px1 = TextBox50px1.Text;
            string idTextBox50px2 = TextBox50px2.Text;
            string idTextBox2 = TextBox2.Text;



            // Construct the connection string (adjust as needed)
            string connectionString = "Data Source=LAPTOP-P9J5GESD\\SQLEXPRESS;Initial Catalog=asplogin;Integrated Security=True;TrustServerCertificate=True";

            // Insert data into the database
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = @"
            INSERT INTO MasterPlans (
                College, 
                Department, 
                DegreeArabic, 
                DegreeEnglish, 
                PlanNumber1, 
                PlanNumber2, 
                PlanNumber3, 
                PlanNumber4, 
                PlanNumber5, 
                PlanNumber6,
                FirstPriorityDegree1,
                FirstPriorityDegree2,
                allhours,
                mandatoryhours,
                SubjectNumber1,
                SubjectNumber2,
                SubjectNumber3,
                SubjectNumber4,
                SubjectNumber5,
                SubjectNumber6,
                optionalhours,
                OptionalSubject1,
                OptionalSubject2,
                OptionalSubject3,
                OptionalSubject4,
                OptionalSubject5,
                OptionalSubject6,
                proficiencySuccess,
                unimessage,
                unimessagenum,
                notes
            ) 
            VALUES (
                @College, 
                @Department, 
                @DegreeArabic, 
                @DegreeEnglish, 
                @PlanNumber1, 
                @PlanNumber2, 
                @PlanNumber3, 
                @PlanNumber4, 
                @PlanNumber5, 
                @PlanNumber6,
                @FirstPriorityDegree1,
                @FirstPriorityDegree2,
                @allhours,
                @mandatoryhours,
                @SubjectNumber1,
                @SubjectNumber2,
                @SubjectNumber3,
                @SubjectNumber4,
                @SubjectNumber5,
                @SubjectNumber6,
                @optionalhours,
                @OptionalSubject1,
                @OptionalSubject2,
                @OptionalSubject3,
                @OptionalSubject4,
                @OptionalSubject5,
                @OptionalSubject6,
                @proficiencySuccess,
                @unimessage,
                @unimessagenum,
                @notes
            )";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    // Pass the selected values of the DropDownList controls
                    cmd.Parameters.AddWithValue("@College", selectedCollege);
                    cmd.Parameters.AddWithValue("@Department", selectedDepartment);
                    cmd.Parameters.AddWithValue("@DegreeArabic", degreeInArabic);
                    cmd.Parameters.AddWithValue("@DegreeEnglish", degreeInEnglish);

                    cmd.Parameters.AddWithValue("@PlanNumber1", idplanNumber1);
                    cmd.Parameters.AddWithValue("@PlanNumber2", idplanNumber2);
                    cmd.Parameters.AddWithValue("@PlanNumber3", idplanNumber3);
                    cmd.Parameters.AddWithValue("@PlanNumber4", idplanNumber4);
                    cmd.Parameters.AddWithValue("@PlanNumber5", idplanNumber5);
                    cmd.Parameters.AddWithValue("@PlanNumber6", idplanNumber6);

                    cmd.Parameters.AddWithValue("@FirstPriorityDegree1", idFirstPriorityDegree1);
                    cmd.Parameters.AddWithValue("@FirstPriorityDegree2", idSecondPriorityDegree1);
                    cmd.Parameters.AddWithValue("@allhours", idCustomTextBox); // Make sure the column name is correct
                    cmd.Parameters.AddWithValue("@mandatoryhours", idTextBox1); // Make sure the column name is correct

                    cmd.Parameters.AddWithValue("@SubjectNumber1", idSubjectNumber1);
                    cmd.Parameters.AddWithValue("@SubjectNumber2", idSubjectNumber2);
                    cmd.Parameters.AddWithValue("@SubjectNumber3", idSubjectNumber3);
                    cmd.Parameters.AddWithValue("@SubjectNumber4", idSubjectNumber4);
                    cmd.Parameters.AddWithValue("@SubjectNumber5", idSubjectNumber5);
                    cmd.Parameters.AddWithValue("@SubjectNumber6", idSubjectNumber6);

                    cmd.Parameters.AddWithValue("@optionalhours", idStyledTextBox); // Make sure the column name is correct
                    cmd.Parameters.AddWithValue("@OptionalSubject1", idOptionalSubject1);
                    cmd.Parameters.AddWithValue("@OptionalSubject2", idOptionalSubject2);
                    cmd.Parameters.AddWithValue("@OptionalSubject3", idOptionalSubject3);
                    cmd.Parameters.AddWithValue("@OptionalSubject4", idOptionalSubject4);
                    cmd.Parameters.AddWithValue("@OptionalSubject5", idOptionalSubject5);
                    cmd.Parameters.AddWithValue("@OptionalSubject6", idOptionalSubject6);

                    cmd.Parameters.AddWithValue("@proficiencySuccess", idStyledTextBox50px); // Make sure the column name is correct
                    cmd.Parameters.AddWithValue("@unimessage", idTextBox50px1); // Make sure the column name is correct
                    cmd.Parameters.AddWithValue("@unimessagenum", idTextBox50px2); // Make sure the column name is correct
                    cmd.Parameters.AddWithValue("@notes", idTextBox2); // Make sure the column name is correct

                    // Add parameters for other form values

                    cmd.ExecuteNonQuery();
                }
            }

            // Optionally, show a success message or redirect the user
            Response.Write("<script>alert('Data saved successfully.');</script>");
        }

    }
}