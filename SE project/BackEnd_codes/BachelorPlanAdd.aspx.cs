using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Data.SqlTypes;

namespace LoginForm
{
    public partial class BachelorPlanAdd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SaveButton_Click(object sender, EventArgs e)
        {
            string idCollege = college.Text;
            string iddepartment = department.Text;
            string iddegreeArabic = degreeArabic.Text;
            string iddegreeEnglish = degreeEnglish.Text;

            string idplanName = planName.Text;
            string idtotalhours = totalhours.Text;
            string idunireq = unireq.Text;
            string idcollegereq = collegereq.Text;
            string idmajorhours = majorhours.Text;
            string idcompulsorydeptreq = compulsorydeptreq.Text;
            string idoptionaldeptreq = optionaldeptreq.Text;
            string idtotal = total.Text;
                   
            string iddeptsymbol = deptsymbol.Text;
            string iddeptname = deptname.Text;
                   
            string iddomainsymbol = domainsymbol.Text;
            string idmajortitle = majortitle.Text;
                   
            string idallhours = allhours.Text;
            string idcompulsoryhours = compulsoryhours.Text;
                   
            string idcommunityservice = communityservice.Text;
            string idcomputerexam = computerexam.Text;
            string idarabicexam = arabicexam.Text;
            string idenglishexam = englishexam.Text;
                   
            string idmilitaryscience = militaryscience.Text;
            string idNationalculture = Nationalculture.Text;
            string idEthicsandhumanvalues = Ethicsandhumanvalues.Text;
            string idLeadershipinnovation = Leadershipinnovation.Text;
            string idLifeandpracticalskills = Lifeandpracticalskills.Text;
            string idIntroductiontophilosophy = Introductiontophilosophy.Text;
                   
            string idislamic = islamic.Text;
            string idArabIslamiccivilization = ArabIslamiccivilization.Text;
            string idjordanhistory = jordanhistory.Text;
            string idMothersofbooks = Mothersofbooks.Text;
            string idJerusalem = Jerusalem.Text;
                   
            string idEnvironmentalcultureanddevelopment = Environmentalcultureanddevelopment.Text;
            string idIslamicculture = Islamicculture.Text;
            string idHealthculture = Healthculture.Text;
            string idLegalculture = Legalculture.Text;
            string idPhysicalculture = Physicalculture.Text;

            string idEcommerce = Ecommerce.Text;
            string idSocialmedia = Socialmedia.Text;
            string idArtappreciation = Artappreciation.Text;
            string idForeignlanguage = Foreignlanguage.Text;
            string idSpecialtopic = Specialtopic.Text;

            string idcollegehours = collegehours.Text;
            string idcollegecompulsoryhours = collegecompulsoryhours.Text;

            string idcompulsorySubjectNumber1 = compulsorySubjectNumber1.Text;
            string idcompulsorySubjectNumber2 = compulsorySubjectNumber2.Text;
            string idcompulsorySubjectNumber3 = compulsorySubjectNumber3.Text;
            string idcompulsorySubjectNumber4 = compulsorySubjectNumber4.Text;
            string idcompulsorySubjectNumber5 = compulsorySubjectNumber5.Text;
            string idcompulsorySubjectNumber6 = compulsorySubjectNumber6.Text;

            string idoptionalhours = optionalhours.Text;

            string idoptionalSubjectNumber1 = optionalSubjectNumber1.Text;
            string idoptionalSubjectNumber2 = optionalSubjectNumber2.Text;
            string idoptionalSubjectNumber3 = optionalSubjectNumber3.Text;
            string idoptionalSubjectNumber4 = optionalSubjectNumber4.Text;
            string idoptionalSubjectNumber5 = optionalSubjectNumber5.Text;
            string idoptionalSubjectNumber6 = optionalSubjectNumber6.Text;

            string idallmajorhours = allmajorhours.Text;
            string idcompulsorymajorhours = compulsorymajorhours.Text;

            string idcompulsorymajorNumber1 = compulsorymajorNumber1.Text;
            string idcompulsorymajorNumber2 = compulsorymajorNumber2.Text;
            string idcompulsorymajorNumber3 = compulsorymajorNumber3.Text;
            string idcompulsorymajorNumber4 = compulsorymajorNumber4.Text;
            string idcompulsorymajorNumber5 = compulsorymajorNumber5.Text;
            string idcompulsorymajorNumber6 = compulsorymajorNumber6.Text;

            string idoptionalmajorhours = optionalmajorhours.Text;

            string idoptionalmajorNumber1 = optionalmajorNumber1.Text;
            string idoptionalmajorNumber2 = optionalmajorNumber2.Text;
            string idoptionalmajorNumber3 = optionalmajorNumber3.Text;
            string idoptionalmajorNumber4 = optionalmajorNumber4.Text;
            string idoptionalmajorNumber5 = optionalmajorNumber5.Text;
            string idoptionalmajorNumber6 = optionalmajorNumber6.Text;

            
            string idotherNumber1 = otherNumber1.Text;
            string idotherNumber2 = otherNumber2.Text;
            string idotherNumber3 = otherNumber3.Text;
            string idotherNumber4 = otherNumber4.Text;
            string idotherNumber5 = otherNumber5.Text;
            string idotherNumber6 = otherNumber6.Text;

            string iddescribe = describe.Text;

            string connectionString = "Data Source=LAPTOP-P9J5GESD\\SQLEXPRESS;Initial Catalog=asplogin;Integrated Security=True;TrustServerCertificate=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = @"
    INSERT INTO BachelorPlans (
        College, Department, DegreeArabic, DegreeEnglish, 
        PlanName, TotalHours, UniReq, CollegeReq, MajorHours, CompulsoryDeptReq, OptionalDeptReq, Total, 
        DeptSymbol, DeptName, 
        DomainSymbol, MajorTitle, 
        AllHours, CompulsoryHours, 
        CommunityService, ComputerExam, ArabicExam, EnglishExam, 
        MilitaryScience, NationalCulture, EthicsAndHumanValues, LeadershipInnovation, LifeAndPracticalSkills, IntroductionToPhilosophy, 
        Islamic, ArabIslamicCivilization, JordanHistory, MothersOfBooks, Jerusalem, 
        EnvironmentalCultureAndDevelopment, IslamicCulture, HealthCulture, LegalCulture, PhysicalCulture, 
        Ecommerce, SocialMedia, ArtAppreciation, ForeignLanguage, SpecialTopic, 
        CollegeHours, CollegeCompulsoryHours, 
        CompulsorySubjectNumber1, CompulsorySubjectNumber2, CompulsorySubjectNumber3, CompulsorySubjectNumber4, CompulsorySubjectNumber5, CompulsorySubjectNumber6, 
        OptionalHours, 
        OptionalSubjectNumber1, OptionalSubjectNumber2, OptionalSubjectNumber3, OptionalSubjectNumber4, OptionalSubjectNumber5, OptionalSubjectNumber6, 
        AllMajorHours, CompulsoryMajorHours, 
        CompulsoryMajorNumber1, CompulsoryMajorNumber2, CompulsoryMajorNumber3, CompulsoryMajorNumber4, CompulsoryMajorNumber5, CompulsoryMajorNumber6, 
        OptionalMajorHours, 
        OptionalMajorNumber1, OptionalMajorNumber2, OptionalMajorNumber3, OptionalMajorNumber4, OptionalMajorNumber5, OptionalMajorNumber6, 
        OtherNumber1, OtherNumber2, OtherNumber3, OtherNumber4, OtherNumber5, OtherNumber6, 
        Describe
    ) 
    VALUES (
        @College, @Department, @DegreeArabic, @DegreeEnglish, 
        @PlanName, @TotalHours, @UniReq, @CollegeReq, @MajorHours, @CompulsoryDeptReq, @OptionalDeptReq, @Total, 
        @DeptSymbol, @DeptName, 
        @DomainSymbol, @MajorTitle, 
        @AllHours, @CompulsoryHours, 
        @CommunityService, @ComputerExam, @ArabicExam, @EnglishExam, 
        @MilitaryScience, @NationalCulture, @EthicsAndHumanValues, @LeadershipInnovation, @LifeAndPracticalSkills, @IntroductionToPhilosophy, 
        @Islamic, @ArabIslamicCivilization, @JordanHistory, @MothersOfBooks, @Jerusalem, 
        @EnvironmentalCultureAndDevelopment, @IslamicCulture, @HealthCulture, @LegalCulture, @PhysicalCulture, 
        @Ecommerce, @SocialMedia, @ArtAppreciation, @ForeignLanguage, @SpecialTopic, 
        @CollegeHours, @CollegeCompulsoryHours, 
        @CompulsorySubjectNumber1, @CompulsorySubjectNumber2, @CompulsorySubjectNumber3, @CompulsorySubjectNumber4, @CompulsorySubjectNumber5, @CompulsorySubjectNumber6, 
        @OptionalHours, 
        @OptionalSubjectNumber1, @OptionalSubjectNumber2, @OptionalSubjectNumber3, @OptionalSubjectNumber4, @OptionalSubjectNumber5, @OptionalSubjectNumber6, 
        @AllMajorHours, @CompulsoryMajorHours, 
        @CompulsoryMajorNumber1, @CompulsoryMajorNumber2, @CompulsoryMajorNumber3, @CompulsoryMajorNumber4, @CompulsoryMajorNumber5, @CompulsoryMajorNumber6, 
        @OptionalMajorHours, 
        @OptionalMajorNumber1, @OptionalMajorNumber2, @OptionalMajorNumber3, @OptionalMajorNumber4, @OptionalMajorNumber5, @OptionalMajorNumber6, 
        @OtherNumber1, @OtherNumber2, @OtherNumber3, @OtherNumber4, @OtherNumber5, @OtherNumber6, 
        @Describe
    )";


                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    // General College and Department Information
                    cmd.Parameters.AddWithValue("@College", idCollege);
                    cmd.Parameters.AddWithValue("@Department", iddepartment);
                    cmd.Parameters.AddWithValue("@DegreeArabic", iddegreeArabic);
                    cmd.Parameters.AddWithValue("@DegreeEnglish", iddegreeEnglish);

                    // Plan Information
                    cmd.Parameters.AddWithValue("@PlanName", idplanName);
                    cmd.Parameters.AddWithValue("@TotalHours", idtotalhours);
                    cmd.Parameters.AddWithValue("@UniReq", idunireq);
                    cmd.Parameters.AddWithValue("@CollegeReq", idcollegereq);
                    cmd.Parameters.AddWithValue("@MajorHours", idmajorhours);
                    cmd.Parameters.AddWithValue("@CompulsoryDeptReq", idcompulsorydeptreq);
                    cmd.Parameters.AddWithValue("@OptionalDeptReq", idoptionaldeptreq);
                    cmd.Parameters.AddWithValue("@Total", idtotal);

                    // Department Symbols and Titles
                    cmd.Parameters.AddWithValue("@DeptSymbol", iddeptsymbol);
                    cmd.Parameters.AddWithValue("@DeptName", iddeptname);

                    // Domain Information
                    cmd.Parameters.AddWithValue("@DomainSymbol", iddomainsymbol);
                    cmd.Parameters.AddWithValue("@MajorTitle", idmajortitle);

                    // Hours Information
                    cmd.Parameters.AddWithValue("@AllHours", idallhours);
                    cmd.Parameters.AddWithValue("@CompulsoryHours", idcompulsoryhours);

                    // Exam Requirements
                    cmd.Parameters.AddWithValue("@CommunityService", idcommunityservice);
                    cmd.Parameters.AddWithValue("@ComputerExam", idcomputerexam);
                    cmd.Parameters.AddWithValue("@ArabicExam", idarabicexam);
                    cmd.Parameters.AddWithValue("@EnglishExam", idenglishexam);

                    // Courses and Subjects
                    cmd.Parameters.AddWithValue("@MilitaryScience", idmilitaryscience);
                    cmd.Parameters.AddWithValue("@NationalCulture", idNationalculture);
                    cmd.Parameters.AddWithValue("@EthicsAndHumanValues", idEthicsandhumanvalues);
                    cmd.Parameters.AddWithValue("@LeadershipInnovation", idLeadershipinnovation);
                    cmd.Parameters.AddWithValue("@LifeAndPracticalSkills", idLifeandpracticalskills);
                    cmd.Parameters.AddWithValue("@IntroductionToPhilosophy", idIntroductiontophilosophy);

                    // Islamic Studies
                    cmd.Parameters.AddWithValue("@Islamic", idislamic);
                    cmd.Parameters.AddWithValue("@ArabIslamicCivilization", idArabIslamiccivilization);
                    cmd.Parameters.AddWithValue("@JordanHistory", idjordanhistory);
                    cmd.Parameters.AddWithValue("@MothersOfBooks", idMothersofbooks);
                    cmd.Parameters.AddWithValue("@Jerusalem", idJerusalem);

                    // Cultural and Legal Subjects
                    cmd.Parameters.AddWithValue("@EnvironmentalCultureAndDevelopment", idEnvironmentalcultureanddevelopment);
                    cmd.Parameters.AddWithValue("@IslamicCulture", idIslamicculture);
                    cmd.Parameters.AddWithValue("@HealthCulture", idHealthculture);
                    cmd.Parameters.AddWithValue("@LegalCulture", idLegalculture);
                    cmd.Parameters.AddWithValue("@PhysicalCulture", idPhysicalculture);

                    // Additional Topics
                    cmd.Parameters.AddWithValue("@Ecommerce", idEcommerce);
                    cmd.Parameters.AddWithValue("@SocialMedia", idSocialmedia);
                    cmd.Parameters.AddWithValue("@ArtAppreciation", idArtappreciation);
                    cmd.Parameters.AddWithValue("@ForeignLanguage", idForeignlanguage);
                    cmd.Parameters.AddWithValue("@SpecialTopic", idSpecialtopic);

                    // College Requirements
                    cmd.Parameters.AddWithValue("@CollegeHours", idcollegehours);
                    cmd.Parameters.AddWithValue("@CollegeCompulsoryHours", idcollegecompulsoryhours);

                    // Compulsory Subjects
                    cmd.Parameters.AddWithValue("@CompulsorySubjectNumber1", idcompulsorySubjectNumber1);
                    cmd.Parameters.AddWithValue("@CompulsorySubjectNumber2", idcompulsorySubjectNumber2);
                    cmd.Parameters.AddWithValue("@CompulsorySubjectNumber3", idcompulsorySubjectNumber3);
                    cmd.Parameters.AddWithValue("@CompulsorySubjectNumber4", idcompulsorySubjectNumber4);
                    cmd.Parameters.AddWithValue("@CompulsorySubjectNumber5", idcompulsorySubjectNumber5);
                    cmd.Parameters.AddWithValue("@CompulsorySubjectNumber6", idcompulsorySubjectNumber6);

                    // Optional Subjects
                    cmd.Parameters.AddWithValue("@OptionalHours", idoptionalhours);
                    cmd.Parameters.AddWithValue("@OptionalSubjectNumber1", idoptionalSubjectNumber1);
                    cmd.Parameters.AddWithValue("@OptionalSubjectNumber2", idoptionalSubjectNumber2);
                    cmd.Parameters.AddWithValue("@OptionalSubjectNumber3", idoptionalSubjectNumber3);
                    cmd.Parameters.AddWithValue("@OptionalSubjectNumber4", idoptionalSubjectNumber4);
                    cmd.Parameters.AddWithValue("@OptionalSubjectNumber5", idoptionalSubjectNumber5);
                    cmd.Parameters.AddWithValue("@OptionalSubjectNumber6", idoptionalSubjectNumber6);

                    // Major Hours
                    cmd.Parameters.AddWithValue("@AllMajorHours", idallmajorhours);
                    cmd.Parameters.AddWithValue("@CompulsoryMajorHours", idcompulsorymajorhours);

                    // Compulsory Major Subjects
                    cmd.Parameters.AddWithValue("@CompulsoryMajorNumber1", idcompulsorymajorNumber1);
                    cmd.Parameters.AddWithValue("@CompulsoryMajorNumber2", idcompulsorymajorNumber2);
                    cmd.Parameters.AddWithValue("@CompulsoryMajorNumber3", idcompulsorymajorNumber3);
                    cmd.Parameters.AddWithValue("@CompulsoryMajorNumber4", idcompulsorymajorNumber4);
                    cmd.Parameters.AddWithValue("@CompulsoryMajorNumber5", idcompulsorymajorNumber5);
                    cmd.Parameters.AddWithValue("@CompulsoryMajorNumber6", idcompulsorymajorNumber6);

                    // Optional Major Subjects
                    cmd.Parameters.AddWithValue("@OptionalMajorHours", idoptionalmajorhours);
                    cmd.Parameters.AddWithValue("@OptionalMajorNumber1", idoptionalmajorNumber1);
                    cmd.Parameters.AddWithValue("@OptionalMajorNumber2", idoptionalmajorNumber2);
                    cmd.Parameters.AddWithValue("@OptionalMajorNumber3", idoptionalmajorNumber3);
                    cmd.Parameters.AddWithValue("@OptionalMajorNumber4", idoptionalmajorNumber4);
                    cmd.Parameters.AddWithValue("@OptionalMajorNumber5", idoptionalmajorNumber5);
                    cmd.Parameters.AddWithValue("@OptionalMajorNumber6", idoptionalmajorNumber6);

                    // Other Numbers and Description
                    cmd.Parameters.AddWithValue("@OtherNumber1", idotherNumber1);
                    cmd.Parameters.AddWithValue("@OtherNumber2", idotherNumber2);
                    cmd.Parameters.AddWithValue("@OtherNumber3", idotherNumber3);
                    cmd.Parameters.AddWithValue("@OtherNumber4", idotherNumber4);
                    cmd.Parameters.AddWithValue("@OtherNumber5", idotherNumber5);
                    cmd.Parameters.AddWithValue("@OtherNumber6", idotherNumber6);

                    cmd.Parameters.AddWithValue("@Describe", iddescribe);


                    cmd.ExecuteNonQuery();
                }

            }

            Response.Write("<script>alert('Data saved successfully.');</script>");
        }

    }
}