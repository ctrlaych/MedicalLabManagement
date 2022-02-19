using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;


namespace DBLP.Models
{
    public class CRUD
    {
        public static string connectionString = "data source=localhost; Initial Catalog=DBLP;Integrated Security=true";

        public static int TLogin(string userid, string password)
        {

            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd;
            int result = 0;

            try
            {
                cmd = new SqlCommand("dbo.Signin_Teachnician1", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("@input_username3", SqlDbType.NVarChar, 40).Value = userid;
                cmd.Parameters.Add("@input_password3", SqlDbType.NVarChar, 40).Value = password;
                cmd.Parameters.Add("@id3", SqlDbType.NVarChar, 40).Value = 0;

                cmd.Parameters.Add("@status3", SqlDbType.Int).Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                result = Convert.ToInt32(cmd.Parameters["@status3"].Value);



            }

            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());
                result = -1; //-1 will be interpreted as "error while connecting with the database."
            }
            finally
            {
                con.Close();
            }
            return result;

        }
        public static int deactive_tech(string tech_id)
        {

            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd;
            int result = 0;

            try
            {
                cmd = new SqlCommand("dbo.deactivate_technician", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("@input_id8", SqlDbType.Int).Value = tech_id;
                cmd.Parameters.Add("@status", SqlDbType.Int).Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                result = Convert.ToInt32(cmd.Parameters["@status"].Value);
            }

            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());
                result = -1; //-1 will be interpreted as "error while connecting with the database."
            }
            finally
            {
                con.Close();
            }
            return result;

        }

        public static int sCheck(string userid)
        {

            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd;
            int result = 0;

            try
            {
                cmd = new SqlCommand("dbo.sessionCheck", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("@input_username3", SqlDbType.NVarChar, 40).Value = userid;
                cmd.Parameters.Add("@id3", SqlDbType.NVarChar, 40).Value = 0;

                cmd.Parameters.Add("@status3", SqlDbType.Int).Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                result = Convert.ToInt32(cmd.Parameters["@status3"].Value);



            }

            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());
                result = -1; //-1 will be interpreted as "error while connecting with the database."
            }
            finally
            {
                con.Close();
            }
            return result;

        }

        public static int deactive(string password3, string id)
        {

            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd;
            int result = 0;

            try
            {
                cmd = new SqlCommand("dbo.client_deactivate", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("@password", SqlDbType.NVarChar, 40).Value = password3;
                cmd.Parameters.Add("@input_username", SqlDbType.NVarChar, 40).Value = id;
                cmd.Parameters.Add("@status", SqlDbType.Int).Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                result = Convert.ToInt32(cmd.Parameters["@status"].Value);
            }

            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());
                result = -1; //-1 will be interpreted as "error while connecting with the database."
            }
            finally
            {
                con.Close();
            }
            return result;

        }
        public static int deactive_client(string clientid)
        {

            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd;
            int result = 0;

            try
            {
                cmd = new SqlCommand("dbo.deactivate_client", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("@input_id", SqlDbType.Int).Value = clientid;
                cmd.Parameters.Add("@status", SqlDbType.Int).Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                result = Convert.ToInt32(cmd.Parameters["@status"].Value);
            }

            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());
                result = -1; //-1 will be interpreted as "error while connecting with the database."
            }
            finally
            {
                con.Close();
            }
            return result;

        }
        public static int deactive_test(string testid)
        {

            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd;
            int result = 0;

            try
            {
                cmd = new SqlCommand("dbo.activate_test", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("@input_id8  ", SqlDbType.Int).Value = testid;
                cmd.Parameters.Add("@status", SqlDbType.Int).Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                result = Convert.ToInt32(cmd.Parameters["@status"].Value);
            }

            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());
                result = -1; //-1 will be interpreted as "error while connecting with the database."
            }
            finally
            {
                con.Close();
            }
            return result;

        }
        public static int active_tech(string techid)
        {

            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd;
            int result = 0;

            try
            {
                cmd = new SqlCommand("dbo.activate_technician", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("@input_id8", SqlDbType.Int).Value = techid;
                cmd.Parameters.Add("@status", SqlDbType.Int).Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                result = Convert.ToInt32(cmd.Parameters["@status"].Value);
            }

            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());
                result = -1; //-1 will be interpreted as "error while connecting with the database."
            }
            finally
            {
                con.Close();
            }
            return result;

        }
        public static int active_client(string clientid)
        {

            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd;
            int result = 0;

            try
            {
                cmd = new SqlCommand("dbo.activate_client", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("@input_id", SqlDbType.Int).Value = clientid;
                cmd.Parameters.Add("@status", SqlDbType.Int).Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                result = Convert.ToInt32(cmd.Parameters["@status"].Value);
            }

            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());
                result = -1; //-1 will be interpreted as "error while connecting with the database."
            }
            finally
            {
                con.Close();
            }
            return result;

        }
        public static int active_test(string testid)
        {

            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd;
            int result = 0;

            try
            {
                cmd = new SqlCommand("dbo.deactivate_test1", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("@input_id9 ", SqlDbType.Int).Value = testid;
                cmd.Parameters.Add("@status", SqlDbType.Int).Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                result = Convert.ToInt32(cmd.Parameters["@status"].Value);
            }

            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());
                result = -1; //-1 will be interpreted as "error while connecting with the database."
            }
            finally
            {
                con.Close();
            }
            return result;

        }

        public static int Add_test(string Testtype, string TestName, string Amount)
        {

            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd;
            int result = 0;

            try
            {
                cmd = new SqlCommand("dbo.add_test1", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("@test_typeNEW", SqlDbType.NVarChar, 50).Value = Testtype;
                cmd.Parameters.Add("@test_nameNEW", SqlDbType.NVarChar, 50).Value = TestName;
                cmd.Parameters.Add("@amountNEW", SqlDbType.Int).Value = Amount;

                cmd.Parameters.Add("@status", SqlDbType.Int).Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                result = Convert.ToInt32(cmd.Parameters["@status"].Value);



            }

            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());
                result = -1; //-1 will be interpreted as "error while connecting with the database."
            }
            finally
            {
                con.Close();
            }
            return result;

        }

        public static int CLogin(string userid, string password)
        {

            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd;
            int result = 0;

            try
            {
                cmd = new SqlCommand("dbo.Signin_Client1", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("@input_username1", SqlDbType.NVarChar, 40).Value = userid;
                cmd.Parameters.Add("@input_password1", SqlDbType.NVarChar, 40).Value = password;


                cmd.Parameters.Add("@status1", SqlDbType.Int).Direction = ParameterDirection.Output;

                cmd.ExecuteNonQuery();
                result = Convert.ToInt32(cmd.Parameters["@status1"].Value);
            }

            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());
                result = -1; //-1 will be interpreted as "error while connecting with the database."
            }
            finally
            {
                con.Close();
            }
            return result;

        }

        public static int CSignup(string userid, string password, string firstname, string lastname, int age, string email, string address, string phonenumber, string Gender, string Bloodgroup)
        {

            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd;
            int result = 0;

            try
            {
                cmd = new SqlCommand("dbo.Signup_Client", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("@input_firstname", SqlDbType.NVarChar, 20).Value = firstname;
                cmd.Parameters.Add("@input_lastname", SqlDbType.NVarChar, 20).Value = lastname;
                cmd.Parameters.Add("@input_gender", SqlDbType.Char).Value = Gender;
                cmd.Parameters.Add("@input_age", SqlDbType.Int).Value = age;
                cmd.Parameters.Add("@input_phonenumber", SqlDbType.NVarChar, 12).Value = phonenumber;
                cmd.Parameters.Add("@input_address", SqlDbType.NVarChar, 200).Value = address;
                cmd.Parameters.Add("@input_bloodgroup", SqlDbType.NVarChar, 3).Value = Bloodgroup;
                cmd.Parameters.Add("@input_account_formation_date", SqlDbType.Date).Value = "2-2-2121";
                cmd.Parameters.Add("@input_username", SqlDbType.NVarChar, 40).Value = userid;
                cmd.Parameters.Add("@input_password", SqlDbType.NVarChar, 40).Value = password;
                cmd.Parameters.Add("@input_email", SqlDbType.NVarChar, 40).Value = email;
                cmd.Parameters.Add("@input_status", SqlDbType.Int).Value = 1;

                cmd.Parameters.Add("@status", SqlDbType.Int).Direction = ParameterDirection.Output;

                cmd.ExecuteNonQuery();
                result = Convert.ToInt32(cmd.Parameters["@status"].Value);



            }

            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());
                result = -1; //-1 will be interpreted as "error while connecting with the database."
            }
            finally
            {
                con.Close();
            }
            return result;

        }
        public static int TSignup(string userid2, string password2, string firstname2, string lastname2, int age2, string email2, string address2, string phonenumber2, string Gender2, string techtype2)
        {

            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd;
            int result = 0;

            try
            {
                cmd = new SqlCommand("dbo.Signup_Technincian1", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("@input_firstname2", SqlDbType.NVarChar, 20).Value = firstname2;
                cmd.Parameters.Add("@input_lastname2", SqlDbType.NVarChar, 20).Value = lastname2;
                cmd.Parameters.Add("@input_gender2", SqlDbType.Char).Value = Gender2;
                cmd.Parameters.Add("@input_age2", SqlDbType.Int).Value = age2;
                cmd.Parameters.Add("@input_phonenumber2", SqlDbType.NVarChar, 12).Value = phonenumber2;
                cmd.Parameters.Add("@input_address2", SqlDbType.NVarChar, 200).Value = address2;
                cmd.Parameters.Add("@input_hire_date", SqlDbType.Date).Value = "2-2-2121";
                cmd.Parameters.Add("@input_info", SqlDbType.NVarChar, 50).Value = techtype2;
                cmd.Parameters.Add("@input_username2", SqlDbType.NVarChar, 40).Value = userid2;
                cmd.Parameters.Add("@input_password2", SqlDbType.NVarChar, 40).Value = password2;
                cmd.Parameters.Add("@input_email2", SqlDbType.NVarChar, 40).Value = email2;
                cmd.Parameters.Add("@input_status2", SqlDbType.Int).Value = 1;

                cmd.Parameters.Add("@status", SqlDbType.Int).Direction = ParameterDirection.Output;

                cmd.ExecuteNonQuery();
                result = Convert.ToInt32(cmd.Parameters["@status"].Value);



            }

            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());
                result = -1; //-1 will be interpreted as "error while connecting with the database."
            }
            finally
            {
                con.Close();
            }
            return result;

        }

        public static Client getClient(string username)
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd;

            try
            {
                cmd = new SqlCommand("Viewclient", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("@username", SqlDbType.NVarChar, 50).Value = username;

                SqlDataReader rdr = cmd.ExecuteReader();


                if (rdr.Read())
                {

                    Client client = new Client();
                    client.firstname = rdr["first_name"].ToString();
                    client.lastname = rdr["last_name"].ToString();
                    client.age = rdr["age"].ToString();
                    client.Account_formation_date = rdr["Account_formation_date"].ToString();
                    client.address = rdr["address"].ToString();
                    client.bloodgroup = rdr["bloodgroup"].ToString();
                    client.email = rdr["email"].ToString();
                    client.gender = rdr["gender"].ToString();
                    client.password = rdr["password"].ToString();
                    client.username = rdr["username"].ToString();
                    client.phone_number = rdr["phone_number"].ToString();
                    rdr.Close();
                    con.Close();
                    return client;

                }


                rdr.Close();
                con.Close();
                return null;

            }

            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());
                return null;

            }


        }

        public static Tech getTech(string usernameT)
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd;

            try
            {
                cmd = new SqlCommand("Viewtech", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("@usernameT", SqlDbType.NVarChar, 50).Value = usernameT;

                SqlDataReader rdr = cmd.ExecuteReader();


                if (rdr.Read())
                {

                    Tech tech = new Tech();
                    tech.firstname = rdr["first_name"].ToString();
                    tech.lastname = rdr["last_name"].ToString();
                    tech.age = rdr["age"].ToString();
                    tech.info = rdr["info"].ToString();
                    tech.address = rdr["address"].ToString();
                    tech.hire_date = rdr["hire_date"].ToString();
                    tech.email = rdr["email"].ToString();
                    tech.gender = rdr["gender"].ToString();
                    tech.password = rdr["password"].ToString();
                    tech.username = rdr["username"].ToString();
                    tech.phone_number = rdr["phone_number"].ToString();
                    rdr.Close();
                    con.Close();

                    return tech;

                }


                rdr.Close();
                con.Close();
                return null;

            }

            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());
                return null;

            }


        }

        public static List<allClient> getAllClient()
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd;

            try
            {
                cmd = new SqlCommand("dbo.view_clients", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                SqlDataReader rdr = cmd.ExecuteReader();

                List<allClient> list = new List<allClient>();
                while (rdr.Read())
                {
                    allClient user = new allClient();

                    user.id = rdr["client_id"].ToString();
                    user.firstname = rdr["first_name"].ToString();
                    user.lastname = rdr["last_name"].ToString();
                    user.email = rdr["email"].ToString();
                    user.phone_number = rdr["phone_number"].ToString();
                    user.status = rdr["status"].ToString();
                    list.Add(user);
                }
                rdr.Close();
                con.Close();

                return list;


            }

            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());
                return null;

            }

        }

        public static List<allTech> getAllTech()
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd;

            try
            {
                cmd = new SqlCommand("dbo.view_technicians", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                SqlDataReader rdr = cmd.ExecuteReader();

                List<allTech> list = new List<allTech>();
                while (rdr.Read())
                {
                    allTech user = new allTech();

                    user.id = rdr["technician_id"].ToString();
                    user.firstname = rdr["first_name"].ToString();
                    user.lastname = rdr["last_name"].ToString();
                    user.email = rdr["email"].ToString();
                    user.phone_number = rdr["phone_number"].ToString();
                    user.status = rdr["status"].ToString();
                    list.Add(user);
                }
                rdr.Close();
                con.Close();

                return list;


            }

            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());
                return null;

            }

        }
        public static List<allTest> getAllTest()
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd;

            try
            {
                cmd = new SqlCommand("dbo.view_all_test_administrator", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                SqlDataReader rdr = cmd.ExecuteReader();

                List<allTest> list = new List<allTest>();
                while (rdr.Read())
                {
                    allTest user = new allTest();

                    user.id = rdr["test_id"].ToString();
                    user.name = rdr["test_name"].ToString();
                    user.amount = rdr["amount"].ToString();
                    user.type = rdr["test_type"].ToString();
                    user.status = rdr["status"].ToString();
                    list.Add(user);
                }
                rdr.Close();
                con.Close();

                return list;


            }

            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());
                return null;

            }

        }
        public static List<appointments> getallappointment()
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd;

            try
            {
                cmd = new SqlCommand("dbo.view_all_appointments_administrator", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                SqlDataReader rdr = cmd.ExecuteReader();

                List<appointments> list = new List<appointments>();
                while (rdr.Read())
                {
                    appointments user = new appointments();

                    user.c_id = rdr["client_id"].ToString();
                    user.tech_id = rdr["technician_id"].ToString();
                    user.t_name = rdr["test_name"].ToString();
                    user.ap_time = rdr["appointment_time"].ToString();
                    user.date = rdr["date"].ToString();
                    list.Add(user);
                }
                rdr.Close();
                con.Close();

                return list;


            }

            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());
                return null;

            }

        }

        public static List<allpayments> getallpayments()
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd;

            try
            {
                cmd = new SqlCommand("dbo.view_payments", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                SqlDataReader rdr = cmd.ExecuteReader();

                List<allpayments> list = new List<allpayments>();
                while (rdr.Read())
                {
                    allpayments user = new allpayments();

                    user.c_id = rdr["client_id"].ToString();
                    user.p_id = rdr["payment_id"].ToString();
                    user.test_name = rdr["test_name"].ToString();
                    user.amount = rdr["amount"].ToString();
                    user.date = rdr["date"].ToString();
                    list.Add(user);
                }
                rdr.Close();
                con.Close();

                return list;


            }

            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());
                return null;

            }

        }
        public static List<tech_test> view_tect_test(string id)
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd;

            try
            {
                cmd = new SqlCommand("dbo.view_tech_tests", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("@input_username", SqlDbType.NVarChar, 40).Value = id;
                SqlDataReader rdr = cmd.ExecuteReader();

                List<tech_test> list = new List<tech_test>();
                while (rdr.Read())
                {
                    tech_test user = new tech_test();
                    user.t_id = rdr["test_name"].ToString();
                    list.Add(user);
                }
                rdr.Close();
                con.Close();

                return list;


            }

            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());
                return null;

            }

        }
        public static int get_tech_id(string id)
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd;
            int result;
            try
            {
                cmd = new SqlCommand("dbo.give_tech_id", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("@input_username", SqlDbType.NVarChar, 40).Value = id;
                cmd.Parameters.Add("@ret", SqlDbType.Int).Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                result = Convert.ToInt32(cmd.Parameters["@ret"].Value);
                con.Close();
                return result;
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());
                return -1;
            }
        }
        public static int get_client_id(string id)
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd;
            int result;
            try
            {
                cmd = new SqlCommand("dbo.give_client_id", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("@input_username", SqlDbType.NVarChar, 40).Value = id;
                cmd.Parameters.Add("@ret", SqlDbType.Int).Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                result = Convert.ToInt32(cmd.Parameters["@ret"].Value);
                con.Close();
                return result;
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());
                return -1;
            }
        }
        public static List<tech_pend_appoint> tech_pend_app(int result)
        {


            SqlConnection con2 = new SqlConnection(connectionString);
            con2.Open();
            SqlCommand cmd2;

            try
            {
                cmd2 = new SqlCommand("dbo.pending_appointments_tech", con2);
                cmd2.CommandType = System.Data.CommandType.StoredProcedure;
                cmd2.Parameters.Add("@input_id6", SqlDbType.Int).Value = result;
                cmd2.Parameters.Add("@date", SqlDbType.Date).Value = "2-2-2222";
                cmd2.Parameters.Add("@current_time", SqlDbType.Time).Value = "2:2:2";
                SqlDataReader rdr2 = cmd2.ExecuteReader();


                List<tech_pend_appoint> list = new List<tech_pend_appoint>();
                while (rdr2.Read())
                {
                    tech_pend_appoint user = new tech_pend_appoint();
                    user.testname = rdr2["test_name"].ToString();
                    user.ap_time = rdr2["appointment_time"].ToString();
                    user.ap_date = rdr2["date"].ToString();
                    list.Add(user);
                }

                rdr2.Close();
                con2.Close();
                return list;
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());
                return null;
            }

        }

        public static List<tech_pend_appoint> tech_prev_app(int result)
        {


            SqlConnection con2 = new SqlConnection(connectionString);
            con2.Open();
            SqlCommand cmd2;

            try
            {
                cmd2 = new SqlCommand("dbo.view_all_appointments_tech", con2);
                cmd2.CommandType = System.Data.CommandType.StoredProcedure;
                cmd2.Parameters.Add("@input_id6", SqlDbType.Int).Value = result;
                SqlDataReader rdr2 = cmd2.ExecuteReader();


                List<tech_pend_appoint> list = new List<tech_pend_appoint>();
                while (rdr2.Read())
                {
                    tech_pend_appoint user = new tech_pend_appoint();
                    user.testname = rdr2["test_name"].ToString();
                    user.ap_time = rdr2["appointment_time"].ToString();
                    user.ap_date = rdr2["date"].ToString();
                    list.Add(user);
                }

                rdr2.Close();
                con2.Close();
                return list;
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());
                return null;
            }

        }
        public static List<tech_appp> tech_pend_app5(int result)
        {


            SqlConnection con2 = new SqlConnection(connectionString);
            con2.Open();
            SqlCommand cmd2;

            try
            {
                cmd2 = new SqlCommand("dbo.view_all_reports_tech", con2);
                cmd2.CommandType = System.Data.CommandType.StoredProcedure;
                cmd2.Parameters.Add("@date", SqlDbType.Date).Value = "2-2-2222";
                cmd2.Parameters.Add("@current_time", SqlDbType.Time).Value = "2:2:2";
                cmd2.Parameters.Add("@input_technician_id", SqlDbType.Int).Value = result;
                SqlDataReader rdr2 = cmd2.ExecuteReader();


                List<tech_appp> list = new List<tech_appp>();
                while (rdr2.Read())
                {
                    tech_appp user = new tech_appp();
                    user.testname = rdr2["test_name"].ToString();
                    user.client_id = rdr2["client_id"].ToString();
                    user.ap_time = rdr2["appointment_time"].ToString();
                    user.ap_date = rdr2["date"].ToString();
                    list.Add(user);
                }

                rdr2.Close();
                con2.Close();
                return list;
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());
                return null;
            }

        }

        public static int Deliver_rep(int id)
        {

            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd;
            int result = 0;

            try
            {
                cmd = new SqlCommand("dbo.deliver_reports", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("@date", SqlDbType.Date).Value = "2-2-2222";
                cmd.Parameters.Add("@current_time", SqlDbType.Time).Value = "2:2:2";
                cmd.Parameters.Add("@input_technician_id", SqlDbType.Int).Value = id;

                cmd.Parameters.Add("@status", SqlDbType.Int).Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                result = Convert.ToInt32(cmd.Parameters["@status"].Value);



            }

            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());
                result = -1; //-1 will be interpreted as "error while connecting with the database."
            }
            finally
            {
                con.Close();
            }
            return result;

        }

        public static List<tech_pend_appoint> tech_today_app(int result)
        {


            SqlConnection con2 = new SqlConnection(connectionString);
            con2.Open();
            SqlCommand cmd2;

            try
            {
                cmd2 = new SqlCommand("dbo.pending_today_appointments_tech", con2);
                cmd2.CommandType = System.Data.CommandType.StoredProcedure;
                cmd2.Parameters.Add("@input_id6", SqlDbType.Int).Value = result;
                SqlDataReader rdr2 = cmd2.ExecuteReader();


                List<tech_pend_appoint> list = new List<tech_pend_appoint>();
                while (rdr2.Read())
                {
                    tech_pend_appoint user = new tech_pend_appoint();
                    user.testname = rdr2["test_name"].ToString();
                    user.ap_time = rdr2["appointment_time"].ToString();
                    user.ap_date = rdr2["date"].ToString();
                    list.Add(user);
                }

                rdr2.Close();
                con2.Close();
                return list;
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());
                return null;
            }

        }


        public static int cancel_ap(int id)
        {

            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd;
            int result = 0;

            try
            {
                cmd = new SqlCommand("dbo.cancel_today_appointments", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("@input_id5", SqlDbType.Int).Value = id;
                cmd.Parameters.Add("@date", SqlDbType.Date).Value = "2020-5-20";
                cmd.Parameters.Add("@status", SqlDbType.Int).Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                result = Convert.ToInt32(cmd.Parameters["@status"].Value);



            }

            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());
                result = -1; //-1 will be interpreted as "error while connecting with the database."
            }
            finally
            {
                con.Close();
            }
            return result;

        }

        public static List<displaytest> dispotest()
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd;

            try
            {
                cmd = new SqlCommand("dbo.view_tests", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                SqlDataReader rdr = cmd.ExecuteReader();

                List<displaytest> list = new List<displaytest>();
                while (rdr.Read())
                {
                    displaytest user = new displaytest();
                    user.name = rdr["test_name"].ToString();
                    list.Add(user);
                }
                rdr.Close();
                con.Close();

                return list;


            }

            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());
                return null;

            }

        }
        public static int Add_op(int id, string testname)
        {

            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd;
            int result = 0;

            try
            {
                cmd = new SqlCommand("dbo.add_appoinment", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("@input_client_id", SqlDbType.Int).Value = id;
                cmd.Parameters.Add("@input_test_name", SqlDbType.NVarChar, 20).Value = testname;
                cmd.Parameters.Add("@test_id", SqlDbType.Int).Value = 0;
                cmd.Parameters.Add("@test_type", SqlDbType.NVarChar, 50).Value = "";
                cmd.Parameters.Add("@technician_id", SqlDbType.Int).Value = 0;
                cmd.Parameters.Add("@appointment_time", SqlDbType.Time).Value = "2:2:2";
                cmd.Parameters.Add("@end_time", SqlDbType.Time).Value = "2:2:2";
                cmd.Parameters.Add("@date", SqlDbType.Date).Value = "2-2-2222";

                cmd.Parameters.Add("@status", SqlDbType.Int).Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                result = Convert.ToInt32(cmd.Parameters["@status"].Value);



            }

            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());
                result = -1; //-1 will be interpreted as "error while connecting with the database."
            }
            finally
            {
                con.Close();
            }
            return result;

        }

        public static List<c_appointment> client_all_app(int result)
        {


            SqlConnection con2 = new SqlConnection(connectionString);
            con2.Open();
            SqlCommand cmd2;

            try
            {
                cmd2 = new SqlCommand("dbo.view_all_Appointments", con2);
                cmd2.CommandType = System.Data.CommandType.StoredProcedure;
                cmd2.Parameters.Add("@input_id2", SqlDbType.Int).Value = result;
                SqlDataReader rdr2 = cmd2.ExecuteReader();


                List<c_appointment> list = new List<c_appointment>();
                while (rdr2.Read())
                {
                    c_appointment user = new c_appointment();
                    user.test_name = rdr2["test_name"].ToString();
                    user.ap_time = rdr2["appointment_time"].ToString();
                    user.date = rdr2["date"].ToString();
                    list.Add(user);
                }

                rdr2.Close();
                con2.Close();
                return list;
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());
                return null;
            }

        }

        public static List<c_appointment> client_today_app(int result)
        {


            SqlConnection con2 = new SqlConnection(connectionString);
            con2.Open();
            SqlCommand cmd2;

            try
            {
                cmd2 = new SqlCommand("dbo.view_pending_appointments", con2);
                cmd2.CommandType = System.Data.CommandType.StoredProcedure;
                cmd2.Parameters.Add("@input_id2", SqlDbType.Int).Value = result;
                cmd2.Parameters.Add("@date", SqlDbType.Date).Value = "2-2-2222";
                cmd2.Parameters.Add("@current_time", SqlDbType.Time).Value = "2:2:2";
                SqlDataReader rdr2 = cmd2.ExecuteReader();


                List<c_appointment> list = new List<c_appointment>();
                while (rdr2.Read())
                {
                    c_appointment user = new c_appointment();
                    user.test_name = rdr2["test_name"].ToString();
                    user.ap_time = rdr2["appointment_time"].ToString();
                    user.date = rdr2["date"].ToString();
                    list.Add(user);
                }

                rdr2.Close();
                con2.Close();
                return list;
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());
                return null;
            }

        }

        public static List<viewreports> Reports(int result)
        {


            SqlConnection con2 = new SqlConnection(connectionString);
            con2.Open();
            SqlCommand cmd2;

            try
            {
                cmd2 = new SqlCommand("dbo.view_report", con2);
                cmd2.CommandType = System.Data.CommandType.StoredProcedure;
                cmd2.Parameters.Add("@input_id9", SqlDbType.Int).Value = result;
                SqlDataReader rdr2 = cmd2.ExecuteReader();


                List<viewreports> list = new List<viewreports>();
                while (rdr2.Read())
                {
                    viewreports user = new viewreports();
                    user.testname = rdr2["test_name"].ToString();
                    user.ap_time = rdr2["appointment_time"].ToString();
                    user.ap_date = rdr2["date"].ToString();
                    list.Add(user);
                }

                rdr2.Close();
                con2.Close();
                return list;
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());
                return null;
            }

        }

        public static int delete_ap(int id)
        {

            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd;
            int result = 0;

            try
            {
                cmd = new SqlCommand("dbo.delete_appointment", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("@input_id1", SqlDbType.Int).Value = id;
                cmd.Parameters.Add("@current_time", SqlDbType.Time).Value = "2:2:2";
                cmd.Parameters.Add("@date", SqlDbType.Date).Value = "2-2-2";
                cmd.Parameters.Add("@status", SqlDbType.Int).Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                result = Convert.ToInt32(cmd.Parameters["@status"].Value);



            }

            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());
                result = -1; //-1 will be interpreted as "error while connecting with the database."
            }
            finally
            {
                con.Close();
            }
            return result;

        }
    }
}