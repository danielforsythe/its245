using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;
using System.Data.OleDb;

namespace MyFinalTabbed
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\relliMnoraA\\Desktop\\Fall 2017\\TeamProjectDB.accdb";
            List<string> nameList = new List<string>();

            using (OleDbConnection pubConnection = new OleDbConnection(connString))
            {
                OleDbCommand cmd = pubConnection.CreateCommand();
                pubConnection.Open();

                cmd.CommandText = "SELECT PatientID, PtLastName, PtFirstName FROM PatientTable";
                cmd.Connection = pubConnection;
                OleDbDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cmbPatientID.Items.Add(reader[0].ToString() + " " + reader[1].ToString() + ", " + reader[2].ToString());
                }
                reader.Close();
            }

            //Disable all fields
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            textBox6.Enabled = false;
            textBox7.Enabled = false;
            textBox8.Enabled = false;
            textBox9.Enabled = false;
            textBox10.Enabled = false;
            textBox11.Enabled = false;
            textBox12.Enabled = false;
            textBox13.Enabled = false;
            textBox14.Enabled = false;
            textBox15.Enabled = false;
            textBox16.Enabled = false;
            textBox17.Enabled = false;
            textBox18.Enabled = false;
            textBox20.Enabled = false;
            textBox21.Enabled = false;
            textBox22.Enabled = false;
            textBox23.Enabled = false;
            textBox24.Enabled = false;
            textBox25.Enabled = false;
            textBox27.Enabled = false;
            textBox28.Enabled = false;
            textBox29.Enabled = false;
            textBox30.Enabled = false;
            textBox31.Enabled = false;
            textBox32.Enabled = false;
            textBox33.Enabled = false;
            textBox34.Enabled = false;
            textBox35.Enabled = false;
            textBox37.Enabled = false;
            textBox38.Enabled = false;
            textBox39.Enabled = false;
            textBox40.Enabled = false;
            textBox41.Enabled = false;
            textBox42.Enabled = false;
            textBox43.Enabled = false;
            textBox44.Enabled = false;
            textBox46.Enabled = false;
            textBox47.Enabled = false;
            textBox48.Enabled = false;
            textBox49.Enabled = false;
            textBox50.Enabled = false;
            textBox53.Enabled = false;
            textBox54.Enabled = false;
            textBox55.Enabled = false;
            textBox56.Enabled = false;
            textBox57.Enabled = false;
            textBox58.Enabled = false;
            textBox59.Enabled = false;
            textBox60.Enabled = false;
            textBox61.Enabled = false;
            textBox62.Enabled = false;
            textBox63.Enabled = false;
            textBox64.Enabled = false;
            textBox65.Enabled = false;
            textBox66.Enabled = false;
            textBox67.Enabled = false;
            textBox68.Enabled = false;
            textBox69.Enabled = false;
            textBox70.Enabled = false;
            textBox71.Enabled = false;
            textBox72.Enabled = false;
            textBox73.Enabled = false;
            textBox74.Enabled = false;
            textBox75.Enabled = false;
            textBox76.Enabled = false;
            textBox77.Enabled = false;
            textBox78.Enabled = false;
            textBox79.Enabled = false;
            textBox80.Enabled = false;
            textBox81.Enabled = false;
            textBox82.Enabled = false;
            textBox83.Enabled = false;
            textBox84.Enabled = false;
            textBox85.Enabled = false;
            textBox86.Enabled = false;
            textBox87.Enabled = false;
            textBox88.Enabled = false;
            textBox89.Enabled = false;
            textBox90.Enabled = false;
            textBox91.Enabled = false;
            textBox92.Enabled = false;
            textBox93.Enabled = false;
            textBox94.Enabled = false;
            textBox95.Enabled = false;
            textBox97.Enabled = false;
            textBox98.Enabled = false;
            textBox99.Enabled = false;
            textBox102.Enabled = false;
            textBox103.Enabled = false;
            textBox104.Enabled = false;
            textBox106.Enabled = false;
            textBox107.Enabled = false;
            textBox108.Enabled = false;
            textBox109.Enabled = false;
            textBox111.Enabled = false;
            textBox112.Enabled = false;
            textBox113.Enabled = false;
            textBox114.Enabled = false;
            textBox115.Enabled = false;
            textBox117.Enabled = false;
            textBox118.Enabled = false;
            textBox119.Enabled = false;
            textBox122.Enabled = false;
            textBox123.Enabled = false;
            textBox124.Enabled = false;
            textBox125.Enabled = false;
            textBox126.Enabled = false;
            textBox127.Enabled = false;
            textBox128.Enabled = false;
            textBox129.Enabled = false;
            textBox130.Enabled = false;
            textBox131.Enabled = false;
            textBox132.Enabled = false;
            textBox133.Enabled = false;
            textBox134.Enabled = false;
            textBox135.Enabled = false;
            textBox137.Enabled = false;
            textBox138.Enabled = false;
            textBox139.Enabled = false;
            textBox140.Enabled = false;
            textBox141.Enabled = false;
            dateTimePicker1.Enabled = false;
            dateTimePicker2.Enabled = false;
            dateTimePicker3.Enabled = false;
            dateTimePicker4.Enabled = false;
            dateTimePicker5.Enabled = false;
            dateTimePicker6.Enabled = false;
            dateTimePicker7.Enabled = false;
            dateTimePicker8.Enabled = false;
            dateTimePicker9.Enabled = false;
            dateTimePicker10.Enabled = false;
            dateTimePicker11.Enabled = false;
            dateTimePicker12.Enabled = false;
            dateTimePicker13.Enabled = false;
            dateTimePicker14.Enabled = false;
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            string testString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\relliMnoraA\\Desktop\\Fall 2017\\TeamProjectDB.accdb";
            List<string> nameList = new List<string>();
            

            using (OleDbConnection pubConnection = new OleDbConnection(testString))
            {
                OleDbCommand cmd = pubConnection.CreateCommand();
                pubConnection.Open();

                string PatientID;
                PatientID = cmbPatientID.Text.Substring(0, 1);
                cmd.CommandText = "SELECT PatientID, OldID, PtLastName, PtPreviousLastName, PtFirstName, HomeAddress1, HomeAddress2, HomeCity, HomeState, HomeZip, Country, Citizenship, PtHomePhone, EmergencyPhoneNumber, PtHomeFax, Pager, EmailAddress, PtSSN, DOB, Gender, EthnicAssociation, Religion, MaritalStatus, EmplomentStatus, HospitalMRN, DateOfExpire, Referral, CurrentPrimaryHCPId, Specialist1, Specialist2, Specialist3, Specialist4, OriginalStaffHCPId, Active, Comments, DateEntered, BusinessPhone, BusinessFax, SubscriberRelationship, EmployerID, NextOfKinID, PtMiddleInitial, NextOfKinRelationshipToPt, NoticeOfPrcticePrivacy, NPPDate, Suffix, Deleted FROM PatientTable WHERE PatientID = " + PatientID;
                cmd.Connection = pubConnection;
                OleDbDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    label1.Text = (reader[0].ToString() + " | " + reader[2].ToString() + ", " + reader[4].ToString());
                    textBox1.Text = reader[0].ToString();
                    textBox1.Text = reader[0].ToString();
                    textBox2.Text = reader[1].ToString();
                    textBox3.Text = reader[2].ToString();
                    textBox4.Text = reader[3].ToString();
                    textBox5.Text = reader[4].ToString();
                    textBox6.Text = reader[5].ToString();
                    textBox7.Text = reader[6].ToString();
                    textBox8.Text = reader[7].ToString();
                    textBox9.Text = reader[8].ToString();
                    textBox10.Text = reader[9].ToString();
                    textBox11.Text = reader[10].ToString();
                    textBox12.Text = reader[11].ToString();
                    textBox13.Text = reader[12].ToString();
                    textBox14.Text = reader[13].ToString();
                    textBox15.Text = reader[14].ToString();
                    textBox16.Text = reader[15].ToString();
                    textBox17.Text = reader[16].ToString();
                    textBox18.Text = reader[17].ToString();
                    dateTimePicker1.Text = reader[18].ToString();
                    textBox20.Text = reader[19].ToString();
                    textBox21.Text = reader[20].ToString();
                    textBox22.Text = reader[21].ToString();
                    textBox23.Text = reader[22].ToString();
                    textBox24.Text = reader[23].ToString();
                    textBox25.Text = reader[24].ToString();
                    dateTimePicker2.Text = reader[25].ToString();
                    textBox27.Text = reader[26].ToString();
                    textBox28.Text = reader[27].ToString();
                    textBox29.Text = reader[28].ToString();
                    textBox30.Text = reader[29].ToString();
                    textBox31.Text = reader[30].ToString();
                    textBox32.Text = reader[31].ToString();
                    textBox33.Text = reader[32].ToString();
                    textBox34.Text = reader[33].ToString();
                    textBox35.Text = reader[34].ToString();
                    dateTimePicker3.Text = reader[35].ToString();
                    textBox37.Text = reader[36].ToString();
                    textBox38.Text = reader[37].ToString();
                    textBox39.Text = reader[38].ToString();
                    textBox40.Text = reader[39].ToString();
                    textBox41.Text = reader[40].ToString();
                    textBox42.Text = reader[41].ToString();
                    textBox43.Text = reader[42].ToString();
                    textBox44.Text = reader[43].ToString();
                    dateTimePicker4.Text = reader[44].ToString();
                    textBox46.Text = reader[45].ToString();
                    textBox47.Text = reader[46].ToString();
                }
                reader.Close();

                cmd.CommandText = "SELECT AllergyID, PatientID, Allergen, AllergyStartDate, AllergyEndDate, AllergyDescription, AllergyHRF, Deleted FROM AllergyHistoryTable WHERE PatientID = " + PatientID;
                cmd.Connection = pubConnection;
                OleDbDataReader allergyreader = cmd.ExecuteReader();

                while (allergyreader.Read())
                {
                    textBox48.Text = allergyreader[0].ToString();
                    textBox49.Text = allergyreader[1].ToString();
                    textBox50.Text = allergyreader[2].ToString();
                    dateTimePicker5.Text = allergyreader[3].ToString();
                    dateTimePicker6.Text = allergyreader[4].ToString();
                    textBox53.Text = allergyreader[5].ToString();
                    textBox54.Text = allergyreader[6].ToString();
                    textBox55.Text = allergyreader[7].ToString();
                }
                allergyreader.Close();

                cmd.CommandText = "SELECT FamilyID, PatientID, FamilyName, Relation, Alive, LivesWithPatient, MajorDisorder, SpecificTypeDisorder, DisorderHRF, Deleted FROM FamilyHistoryTable WHERE PatientID = " + PatientID;
                cmd.Connection = pubConnection;
                OleDbDataReader familyreader = cmd.ExecuteReader();

                while (familyreader.Read())
                {
                    textBox56.Text = familyreader[0].ToString();
                    textBox57.Text = familyreader[1].ToString();
                    textBox58.Text = familyreader[2].ToString();
                    textBox59.Text = familyreader[3].ToString();
                    textBox60.Text = familyreader[4].ToString();
                    textBox61.Text = familyreader[5].ToString();
                    textBox62.Text = familyreader[6].ToString();
                    textBox63.Text = familyreader[7].ToString();
                    textBox64.Text = familyreader[8].ToString();
                    textBox65.Text = familyreader[9].ToString();
                }
                familyreader.Close();

                cmd.CommandText = "SELECT GeneralMedicalHistoryID, PatientID, MaritalStatus, Education, GrowthAndDevelopment, Pregnancies, BehavioralHistory, Tobacco, TobaccoHRF, TobaccorQuantity, TobaccoDuration, Alcohol, AlcoholHRF, AlcoholQuantity, AlcoholDuration, Drug, DrugHRF, DrugType, DrugDuration, Dietary, DietaryHRF, Travel, TravelHRF, BloodType, Rh, MedicalHistoryNotes, HxObtainedBy, HxConfirmedByHCP, UnableToObtainHxReason, Deleted, LMPDate, LMPStatus, LMP, Pregnant, PregnancyDueDate, EDC, NumberOfChildren, NumberOfPregnancies, LMPEstMethod, LMPDateApprox, MenstrualAmtNormalYes, MenstrualAmtNormalNo, MensesMonthlyYes, MensesMonthlyNo, MensesPriorDate, MensesFreq, MenarcheAgeOfOnset, OnBCPAtConeptionYes, OnBCPAtConceptionNo, HospitalOfDelivery, EGA FROM GeneralMedicalHistoryTable WHERE PatientID=" + PatientID;
                cmd.Connection = pubConnection;
                OleDbDataReader generalmedicalreader = cmd.ExecuteReader();

                while (generalmedicalreader.Read())
                {
                    textBox66.Text = generalmedicalreader[0].ToString();
                    textBox67.Text = generalmedicalreader[1].ToString();
                    textBox68.Text = generalmedicalreader[2].ToString();
                    textBox69.Text = generalmedicalreader[3].ToString();
                    textBox70.Text = generalmedicalreader[4].ToString();
                    textBox71.Text = generalmedicalreader[5].ToString();
                    textBox72.Text = generalmedicalreader[6].ToString();
                    textBox73.Text = generalmedicalreader[7].ToString();
                    textBox74.Text = generalmedicalreader[8].ToString();
                    textBox75.Text = generalmedicalreader[9].ToString();
                    textBox76.Text = generalmedicalreader[10].ToString();
                    textBox77.Text = generalmedicalreader[11].ToString();
                    textBox78.Text = generalmedicalreader[12].ToString();
                    textBox79.Text = generalmedicalreader[13].ToString();
                    textBox80.Text = generalmedicalreader[14].ToString();
                    textBox81.Text = generalmedicalreader[15].ToString();
                    textBox82.Text = generalmedicalreader[16].ToString();
                    textBox83.Text = generalmedicalreader[17].ToString();
                    textBox84.Text = generalmedicalreader[18].ToString();
                    textBox85.Text = generalmedicalreader[19].ToString();
                    textBox86.Text = generalmedicalreader[20].ToString();
                    textBox87.Text = generalmedicalreader[21].ToString();
                    textBox88.Text = generalmedicalreader[22].ToString();
                    textBox89.Text = generalmedicalreader[23].ToString();
                    textBox90.Text = generalmedicalreader[24].ToString();
                    textBox91.Text = generalmedicalreader[25].ToString();
                    textBox92.Text = generalmedicalreader[26].ToString();
                    textBox93.Text = generalmedicalreader[27].ToString();
                    textBox94.Text = generalmedicalreader[28].ToString();
                    textBox95.Text = generalmedicalreader[29].ToString();
                    dateTimePicker10.Text = generalmedicalreader[30].ToString();
                    textBox97.Text = generalmedicalreader[31].ToString();
                    textBox98.Text = generalmedicalreader[32].ToString();
                    textBox99.Text = generalmedicalreader[33].ToString();
                    dateTimePicker11.Text = generalmedicalreader[34].ToString();
                    dateTimePicker12.Text = generalmedicalreader[35].ToString();
                    textBox102.Text = generalmedicalreader[36].ToString();
                    textBox103.Text = generalmedicalreader[37].ToString();
                    textBox104.Text = generalmedicalreader[38].ToString();
                    dateTimePicker13.Text = generalmedicalreader[39].ToString();
                    textBox106.Text = generalmedicalreader[40].ToString();
                    textBox107.Text = generalmedicalreader[41].ToString();
                    textBox108.Text = generalmedicalreader[42].ToString();
                    textBox109.Text = generalmedicalreader[43].ToString();
                    dateTimePicker14.Text = generalmedicalreader[44].ToString();
                    textBox111.Text = generalmedicalreader[45].ToString();
                    textBox112.Text = generalmedicalreader[46].ToString();
                    textBox113.Text = generalmedicalreader[47].ToString();
                    textBox114.Text = generalmedicalreader[48].ToString();
                    textBox115.Text = generalmedicalreader[49].ToString();
                    textBox115.Text = generalmedicalreader[50].ToString();
                }
                generalmedicalreader.Close();

                cmd.CommandText = "SELECT ImmunizationID, PatientID, Vaccine, ImmunizationDate, ExperationDate, Delivery, Comments, HCPId, Deleted FROM ImmunizationHistoryTable WHERE PatientID = " + PatientID;
                cmd.Connection = pubConnection;
                OleDbDataReader immunizationreader = cmd.ExecuteReader();

                while (immunizationreader.Read())
                {
                    textBox117.Text = immunizationreader[0].ToString();
                    textBox118.Text = immunizationreader[1].ToString();
                    textBox119.Text = immunizationreader[2].ToString();
                    dateTimePicker8.Text = immunizationreader[3].ToString();
                    dateTimePicker9.Text = immunizationreader[4].ToString();
                    textBox122.Text = immunizationreader[5].ToString();
                    textBox123.Text = immunizationreader[6].ToString();
                    textBox124.Text = immunizationreader[7].ToString();
                    textBox125.Text = immunizationreader[8].ToString();
                }
                immunizationreader.Close();

                cmd.CommandText = "SELECT MedicationID, CurrentMedicationID, PatientID, Medication, PrescriptionQuantity, PrescriptionQuantityUnits, Refills, RefillPeriod, Generic, PrescriptionHCP, PrescriptionDate, PharmacyID, Deleted, Instructions, PrescriptionMedsAmount, PrescriptionMedsUnit FROM PatientMedicationsTable WHERE PatientID = " + PatientID;
                cmd.Connection = pubConnection;
                OleDbDataReader medicationsreader = cmd.ExecuteReader();

                while (medicationsreader.Read())
                {
                    textBox126.Text = medicationsreader[0].ToString();
                    textBox127.Text = medicationsreader[1].ToString();
                    textBox128.Text = medicationsreader[2].ToString();
                    textBox129.Text = medicationsreader[3].ToString();
                    textBox130.Text = medicationsreader[4].ToString();
                    textBox131.Text = medicationsreader[5].ToString();
                    textBox132.Text = medicationsreader[6].ToString();
                    textBox133.Text = medicationsreader[7].ToString();
                    textBox134.Text = medicationsreader[8].ToString();
                    textBox135.Text = medicationsreader[9].ToString();
                    dateTimePicker7.Text = medicationsreader[10].ToString();
                    textBox137.Text = medicationsreader[11].ToString();
                    textBox138.Text = medicationsreader[12].ToString();
                    textBox139.Text = medicationsreader[13].ToString();
                    textBox140.Text = medicationsreader[14].ToString();
                    textBox141.Text = medicationsreader[15].ToString();
                }
                medicationsreader.Close();
            }
        }

        //accidental clicks
        private void textBox38_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage6_Click(object sender, EventArgs e)
        {

        }


        //Enable all fields
        private void button2_Click(object sender, EventArgs e)
        {
                textBox1.Enabled = true;
                textBox2.Enabled = true;
                textBox3.Enabled = true;
                textBox4.Enabled = true;
                textBox5.Enabled = true;
                textBox6.Enabled = true;
                textBox7.Enabled = true;
                textBox8.Enabled = true;
                textBox9.Enabled = true;
                textBox10.Enabled = true;
                textBox11.Enabled = true;
                textBox12.Enabled = true;
                textBox13.Enabled = true;
                textBox14.Enabled = true;
                textBox15.Enabled = true;
                textBox16.Enabled = true;
                textBox17.Enabled = true;
                textBox18.Enabled = true;
                textBox20.Enabled = true;
                textBox21.Enabled = true;
                textBox22.Enabled = true;
                textBox23.Enabled = true;
                textBox24.Enabled = true;
                textBox25.Enabled = true;
                textBox27.Enabled = true;
                textBox28.Enabled = true;
                textBox29.Enabled = true;
                textBox30.Enabled = true;
                textBox31.Enabled = true;
                textBox32.Enabled = true;
                textBox33.Enabled = true;
                textBox34.Enabled = true;
                textBox35.Enabled = true;
                textBox37.Enabled = true;
                textBox38.Enabled = true;
                textBox39.Enabled = true;
                textBox40.Enabled = true;
                textBox41.Enabled = true;
                textBox42.Enabled = true;
                textBox43.Enabled = true;
                textBox44.Enabled = true;
                textBox46.Enabled = true;
                textBox47.Enabled = true;
                textBox48.Enabled = true;
                textBox49.Enabled = true;
                textBox50.Enabled = true;
                textBox53.Enabled = true;
                textBox54.Enabled = true;
                textBox55.Enabled = true;
                textBox56.Enabled = true;
                textBox57.Enabled = true;
                textBox58.Enabled = true;
                textBox59.Enabled = true;
                textBox60.Enabled = true;
                textBox61.Enabled = true;
                textBox62.Enabled = true;
                textBox63.Enabled = true;
                textBox64.Enabled = true;
                textBox65.Enabled = true;
                textBox66.Enabled = true;
                textBox67.Enabled = true;
                textBox68.Enabled = true;
                textBox69.Enabled = true;
                textBox70.Enabled = true;
                textBox71.Enabled = true;
                textBox72.Enabled = true;
                textBox73.Enabled = true;
                textBox74.Enabled = true;
                textBox75.Enabled = true;
                textBox76.Enabled = true;
                textBox77.Enabled = true;
                textBox78.Enabled = true;
                textBox79.Enabled = true;
                textBox80.Enabled = true;
                textBox81.Enabled = true;
                textBox82.Enabled = true;
                textBox83.Enabled = true;
                textBox84.Enabled = true;
                textBox85.Enabled = true;
                textBox86.Enabled = true;
                textBox87.Enabled = true;
                textBox88.Enabled = true;
                textBox89.Enabled = true;
                textBox90.Enabled = true;
                textBox91.Enabled = true;
                textBox92.Enabled = true;
                textBox93.Enabled = true;
                textBox94.Enabled = true;
                textBox95.Enabled = true;
                textBox97.Enabled = true;
                textBox98.Enabled = true;
                textBox99.Enabled = true;
                textBox102.Enabled = true;
                textBox103.Enabled = true;
                textBox104.Enabled = true;
                textBox106.Enabled = true;
                textBox107.Enabled = true;
                textBox108.Enabled = true;
                textBox109.Enabled = true;
                textBox111.Enabled = true;
                textBox112.Enabled = true;
                textBox113.Enabled = true;
                textBox114.Enabled = true;
                textBox115.Enabled = true;
                textBox117.Enabled = true;
                textBox118.Enabled = true;
                textBox119.Enabled = true;
                textBox122.Enabled = true;
                textBox123.Enabled = true;
                textBox124.Enabled = true;
                textBox125.Enabled = true;
                textBox126.Enabled = true;
                textBox127.Enabled = true;
                textBox128.Enabled = true;
                textBox129.Enabled = true;
                textBox130.Enabled = true;
                textBox131.Enabled = true;
                textBox132.Enabled = true;
                textBox133.Enabled = true;
                textBox134.Enabled = true;
                textBox135.Enabled = true;
                textBox137.Enabled = true;
                textBox138.Enabled = true;
                textBox139.Enabled = true;
                textBox140.Enabled = true;
                textBox141.Enabled = true;
                dateTimePicker1.Enabled = true;
                dateTimePicker2.Enabled = true;
                dateTimePicker3.Enabled = true;
                dateTimePicker4.Enabled = true;
                dateTimePicker5.Enabled = true;
                dateTimePicker6.Enabled = true;
                dateTimePicker7.Enabled = true;
                dateTimePicker8.Enabled = true;
                dateTimePicker9.Enabled = true;
                dateTimePicker10.Enabled = true;
                dateTimePicker11.Enabled = true;
                dateTimePicker12.Enabled = true;
                dateTimePicker13.Enabled = true;
                dateTimePicker14.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string testString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\relliMnoraA\\Desktop\\Fall 2017\\TeamProjectDB.accdb";
            List<string> nameList = new List<string>();

            using (OleDbConnection pubConnection = new OleDbConnection(testString))
            {
                OleDbCommand cmd = pubConnection.CreateCommand();
                pubConnection.Open();

                string PatientID;
                PatientID = cmbPatientID.Text.Substring(0, 1);
                cmd.CommandText = "INSERT INTO PatientTable (OldID, PtLastName, PtPreviousLastName, PtFirstName, HomeAddress1, HomeAddress2, HomeCity, HomeState, HomeZip, Country, Citizenship, PtHomePhone, EmergencyPhoneNumber, PtHomeFax, Pager, EmailAddress, PtSSN, DOB, Gender, EthnicAssociation, Religion, MaritalStatus, EmplomentStatus, HospitalMRN, DateOfExpire, Referral, CurrentPrimaryHCPId, Specialist1, Specialist2, Specialist3, Specialist4, OriginalStaffHCPId, Active, Comments, DateEntered, BusinessPhone, BusinessFax, SubscriberRelationship, EmployerID, NextOfKinID, PtMiddleInitial, NextOfKinRelationshipToPt, NoticeOfPrcticePrivacy, NPPDate, Suffix, Deleted) VALUES (@OldID, @PtLastName, @PtPreviousLastName, @PtFirstName, @HomeAddress1, @HomeAddress2, @HomeCity, @HomeState, @HomeZip, @Country, @Citizenship, @PtHomePhone, @EmergencyPhoneNumber, @PtHomeFax, @Pager, @EmailAddress, @PtSSN, @DOB, @Gender, @EthnicAssociation, @Religion, @MaritalStatus, @EmplomentStatus, @HospitalMRN, @DateOfExpire, @Referral, @CurrentPrimaryHCPId, @Specialist1, @Specialist2, @Specialist3, @Specialist4, @OriginalStaffHCPId, @Active, @Comments, @DateEntered, @BusinessPhone, @BusinessFax, @SubscriberRelationship, @EmployerID, @NextOfKinID, @PtMiddleInitial, @NextOfKinRelationshipToPt, @NoticeOfPrcticePrivacy, @NPPDate, @Suffix, @Deleted) WHERE PatientID = " + PatientID;
                cmd.Connection = pubConnection;
                OleDbDataReader reader = cmd.ExecuteReader();

                cmd.Parameters.Add("@OldID", OleDbType.VarChar).Value = Convert.ToInt32(textBox2.Text);
                cmd.Parameters.Add("@PtLastName", OleDbType.VarChar).Value = textBox3.Text;
                cmd.Parameters.Add("@PtPreviousLastName", OleDbType.VarChar).Value = textBox4.Text;
                cmd.Parameters.Add("@PtFirstName", OleDbType.VarChar).Value = textBox5.Text;
                cmd.Parameters.Add("@HomeAddress1", OleDbType.VarChar).Value = textBox6.Text;
                cmd.Parameters.Add("@HomeAddress2", OleDbType.VarChar).Value = textBox7.Text;
                cmd.Parameters.Add("@HomeCity", OleDbType.VarChar).Value = textBox8.Text;
                cmd.Parameters.Add("@HomeState", OleDbType.VarChar).Value = textBox9.Text;
                cmd.Parameters.Add("@HomeZip", OleDbType.VarChar).Value = textBox10.Text;
                cmd.Parameters.Add("@Country", OleDbType.VarChar).Value = textBox11.Text;
                cmd.Parameters.Add("@Citizenship", OleDbType.VarChar).Value = textBox12.Text;
                cmd.Parameters.Add("@PtHomePhone", OleDbType.VarChar).Value = textBox13.Text;
                cmd.Parameters.Add("@EmergencyPhoneNumber", OleDbType.VarChar).Value = textBox14.Text;
                cmd.Parameters.Add("@PtHomeFax", OleDbType.VarChar).Value = textBox15.Text;
                cmd.Parameters.Add("@Pager", OleDbType.VarChar).Value = textBox16.Text;
                cmd.Parameters.Add("@EmailAddress", OleDbType.VarChar).Value = textBox17.Text;
                cmd.Parameters.Add("@PtSSN", OleDbType.VarChar).Value = textBox18.Text;
                cmd.Parameters.Add("@DOB", OleDbType.VarChar).Value = dateTimePicker1.Text;
                cmd.Parameters.Add("@Gender", OleDbType.VarChar).Value = textBox20.Text;
                cmd.Parameters.Add("@EthnicAssociation", OleDbType.VarChar).Value = textBox21.Text;
                cmd.Parameters.Add("@Religion", OleDbType.VarChar).Value = textBox22.Text;
                cmd.Parameters.Add("@MaritalStatus", OleDbType.VarChar).Value = textBox23.Text;
                cmd.Parameters.Add("@EmplomentStatus", OleDbType.VarChar).Value = textBox24.Text;
                cmd.Parameters.Add("@HospitalMRN", OleDbType.VarChar).Value = textBox25.Text;
                cmd.Parameters.Add("@DateOfExpire", OleDbType.VarChar).Value = dateTimePicker2.Text;
                cmd.Parameters.Add("@Referral", OleDbType.VarChar).Value = textBox27.Text;
                cmd.Parameters.Add("@CurrentPrimaryHCPId", OleDbType.VarChar).Value = textBox28.Text;
                cmd.Parameters.Add("@Specialist1", OleDbType.VarChar).Value = textBox29.Text;
                cmd.Parameters.Add("@Specialist2", OleDbType.VarChar).Value = textBox30.Text;
                cmd.Parameters.Add("@Specialist3", OleDbType.VarChar).Value = textBox31.Text;
                cmd.Parameters.Add("@Specialist4", OleDbType.VarChar).Value = textBox32.Text;
                cmd.Parameters.Add("@OriginalStaffHCPId", OleDbType.VarChar).Value = textBox33.Text;
                cmd.Parameters.Add("@Active", OleDbType.VarChar).Value = textBox34.Text;
                cmd.Parameters.Add("@Comments", OleDbType.VarChar).Value = textBox35.Text;
                cmd.Parameters.Add("@BusinessPhone", OleDbType.VarChar).Value = textBox37.Text;
                cmd.Parameters.Add("@DateEntered", OleDbType.VarChar).Value = dateTimePicker3.Text;
                cmd.Parameters.Add("@SubscriberRelationship", OleDbType.VarChar).Value = textBox39.Text;
                cmd.Parameters.Add("@EmployerID", OleDbType.VarChar).Value = textBox40.Text;
                cmd.Parameters.Add("@NextOfKinID", OleDbType.VarChar).Value = textBox41.Text;
                cmd.Parameters.Add("@PtMiddleInitial", OleDbType.VarChar).Value = textBox42.Text;
                cmd.Parameters.Add("@NextOfKinRelationshipToPt", OleDbType.VarChar).Value = textBox43.Text;
                cmd.Parameters.Add("@NoticeOfPrcticePrivacy", OleDbType.VarChar).Value = textBox44.Text;
                cmd.Parameters.Add("@NPPDate", OleDbType.VarChar).Value = dateTimePicker4.Text;
                cmd.Parameters.Add("@Suffix", OleDbType.VarChar).Value = textBox46.Text;
                cmd.Parameters.Add("@Deleted", OleDbType.VarChar).Value = textBox47.Text;
                cmd.Parameters.Add("@BusinessFax", OleDbType.VarChar).Value = textBox38.Text;

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Added");
                    pubConnection.Close();
                }
                catch (OleDbException ex)
                {
                    MessageBox.Show(ex.Source);
                    pubConnection.Close();
                }

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string testString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\relliMnoraA\\Desktop\\Fall 2017\\TeamProjectDB.accdb";
            List<string> nameList = new List<string>();

            using (OleDbConnection pubConnection = new OleDbConnection(testString))
            {

                OleDbCommand cmd = pubConnection.CreateCommand();
                pubConnection.Open();
                MessageBox.Show("Connection Succeeded");

                cmd.Connection = pubConnection;

                int id = Convert.ToInt32(textBox1.Text);
                cmd.CommandText = "UPDATE PatientTable SET DELETED = TRUE Where PatientID=@id";
                cmd.Parameters.AddWithValue("@id", id);

                cmd.CommandText = "UPDATE AllergyHistoryTable SET DELETED = TRUE Where AllergyID=@id";
                cmd.Parameters.AddWithValue("@id", id);

                cmd.CommandText = "UPDATE FamiliyHistoryTable SET DELETED = TRUE Where FamilyID=@id";
                cmd.Parameters.AddWithValue("@id", id);

                cmd.CommandText = "UPDATE GeneralMedicalHistoryTable SET DELETED = TRUE Where GeneralMedicalHistoryID=@id";
                cmd.Parameters.AddWithValue("@id", id);

                cmd.CommandText = "UPDATE ImmunizationHistoryTable SET DELETED = TRUE Where ImmunizationID=@id";
                cmd.Parameters.AddWithValue("@id", id);

                cmd.CommandText = "UPDATE PatientMedicationsTable SET DELETED = TRUE Where ImmunizationID=@id";
                cmd.Parameters.AddWithValue("@id", id);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Record deleted.");
            }
        }
    }
}
