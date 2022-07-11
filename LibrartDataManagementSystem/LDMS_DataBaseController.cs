﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;



//// Pull or clone muna kayo lagi sa master branch bago kayo gumawa sa mga branches nyo


/// <summary>
/// 
/// </summary>

namespace LibrartDataManagementSystem
{
    class LDMS_DataBaseController
    {
        string ConnectString = "datasource = localhost; username = root; password=; database = library_data_management_system;";//databasesample;";
        //string ConnectString = "datasource = sql6.freemysqlhosting.net; username = sql6505213; password=3xepDlsiuM; database = sql6505213; port = 3306";//databasesample;";
        MySqlConnection connectDB;
        MySqlCommand cmd;
        MySqlDataAdapter da;

        public DataTable dt;
        int result;
        
        
        public bool IsDataBaseOpen()
        {
            bool success;
            connectDB = new MySqlConnection(ConnectString);
            try
            {
                connectDB.Open();
                success = true;
            }
            catch
            {
                success = false;
            }
            return success;
        }

        public bool connectDB_And_ExecuteNonQuery(string execute_SQL_StateMent)
        {
            bool success;

            connectDB = new MySqlConnection(ConnectString);

            try
            {
                connectDB.Open();
                cmd = new MySqlCommand(execute_SQL_StateMent, connectDB);
                //cmd.Connection = connectDB;
                //cmd.CommandText = sqlStrCommand;
                result = cmd.ExecuteNonQuery();

                success = true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Failed! " + e.Message);
                success = false;
            }
            finally
            {
                connectDB.Close();
            }
            return success;

            //sqlCommandDB(sqlStrCommand);

        }


        /// <summary>
        /// insert method base on the statement
        /// </summary>
        /// <param name="insert_SQL_StateMent">sql statement to use</param>
        public bool insert_DBMethod(string insert_SQL_StateMent)
        {
            return connectDB_And_ExecuteNonQuery(insert_SQL_StateMent);
        }
        //*/    

        public bool update_DBMethod(string update_SQL_StateMent)
        {
            return connectDB_And_ExecuteNonQuery(update_SQL_StateMent);
        }

        public bool delete_DBMethod(string delete_SQL_StateMent)
        {
            return connectDB_And_ExecuteNonQuery(delete_SQL_StateMent);
        }



        public void insert_To_tbl_borrower(string Borrower_First_Name, string Borrower_Middle_Name, string Borrower_Last_Name, string Borrower_Gender, string Borrower_Address, string Borrower_Contact_Number, /*Datetime*/ string Borrower_BirthDate, string Borrower_Type_of_Valid_ID)
        {
            


            /*
            string sqlStrCommand = "Insert into main (Name, age, address, Gender, isTraveled, isCloseContact, symptomsList, celNumber, eMailAddress) values " +
                    "('" + myCTInfo.name + "', " + myCTInfo.age + ", '" + myCTInfo.address + "', '" + myCTInfo.gender + "', '" + myCTInfo.isTraveledStr + "', '" + myCTInfo.isClosedContact +
                    "', '" + myCTInfo.symptomList + "', '" + myCTInfo.cellNumber + "', '" + myCTInfo.eMail + "')";

            */

            ////////

            string singleQuoteChar = "'";

            string table_Name = "tbl_borrower";
            string table_Columns = "(Borrower_First_Name, Borrower_Middle_Name, Borrower_Last_Name, Borrower_Gender, Borrower_Address, Borrower_Contact_Number, Borrower_BirthDate, Borrower_Type_of_Valid_ID)";
            string table_Column_Values = "(" +
                singleQuoteChar + Borrower_First_Name + singleQuoteChar + ", " +
                singleQuoteChar + Borrower_Middle_Name + singleQuoteChar + ", " +
                singleQuoteChar + Borrower_Last_Name + singleQuoteChar + ", " +
                singleQuoteChar + Borrower_Gender + singleQuoteChar + ", " +
                singleQuoteChar + Borrower_Address + singleQuoteChar + ", " +
                singleQuoteChar + Borrower_Contact_Number + singleQuoteChar + ", " +
                singleQuoteChar + Borrower_BirthDate + singleQuoteChar + ", " +
                singleQuoteChar + Borrower_Type_of_Valid_ID + singleQuoteChar + 
                ")";
            
            ///////////

            string insert_SQL_StateMent = "Insert into "+ table_Name + " " + table_Columns +"  values " + table_Column_Values;

            insert_DBMethod(insert_SQL_StateMent);

            return;
        }
           
        public void insert_To_tbl_book(string Book_Tittle, string Book_Author, string Book_Genre, /*DateTime*/ string Book_Year_Published, string Book_Publisher, int Book_Number_Of_Quantity)
        {

            ////////

            string singleQuoteChar = "'";

            string table_Name = "tbl_book";
            string table_Columns = "(Book_Tittle, Book_Author, Book_Genre, Book_Year_Published, Book_Publisher, Book_Number_Of_Quantity)";
            //string table_Columns = "(Book_Tittle, Book_Author, Book_Genre,  Book_Publisher, Book_Number_Of_Quantity)";
            string table_Column_Values = "(" +
                singleQuoteChar + Book_Tittle + singleQuoteChar + ", " +
                singleQuoteChar + Book_Author + singleQuoteChar + ", " +
                singleQuoteChar + Book_Genre + singleQuoteChar + ", " +
                singleQuoteChar + Book_Year_Published + singleQuoteChar + ", " +
                singleQuoteChar + Book_Publisher + singleQuoteChar + ", " +
                Book_Number_Of_Quantity +
                ")";

            ///////////

            string insert_SQL_StateMent = "Insert into " + table_Name + " " + table_Columns + "  values " + table_Column_Values;

            insert_DBMethod(insert_SQL_StateMent);

            return;
        }


        public bool is_Book_ID_Exist(int Book_ID)
        {
            string query = $"SELECT Book_ID FROM `tbl_book` WHERE `Book_ID` = \"{Book_ID}\"";
            List<List<string>> Book_ID_2D_List = select_DBMethod_return_2DList_Table_Records(query);
            if((Book_ID_2D_List.Count != 0) && (Book_ID_2D_List[0][0].Equals(Book_ID.ToString())))
            {
               // MessageBox.Show("Book_ID tama");

                return true;
            }
            else
            {
                //MessageBox.Show("Book_ID mali");

                return false;
            }    
        }

        public bool is_Borrower_ID_Exist(int Borrower_ID)
        {
            string query = $"SELECT Borrower_ID FROM `tbl_borrower` WHERE `Borrower_ID` = \"{Borrower_ID}\"";
            List<List<string>> Borrower_ID_2D_List = select_DBMethod_return_2DList_Table_Records(query);
            if ((Borrower_ID_2D_List.Count != 0) && (Borrower_ID_2D_List[0][0].Equals(Borrower_ID.ToString())))
            {
                //MessageBox.Show("Borrower_ID tama");

                return true;
            }
            else
            {
                //MessageBox.Show("Borrower_ID mali");

                return false;
            }
        }

        //*
        public bool insert_To_tbl_borrowed_book(int Book_ID, int Borrower_ID, string Borrowed_Book_Date_Borrowed, string Borrowed_Book_Due_Date, string Borrowed_Book_Due_Status, string Borrowed_Book_Date_Returned, int Borrowed_Book_Number_of_Copies)
        {

            ////////

            if ((is_Book_ID_Exist(Book_ID)) && (is_Borrower_ID_Exist(Borrower_ID)))
            {

                //MessageBox.Show("Pumasok dito tama Book_ID at Borrower_ID");

                string singleQuoteChar = "'";

                string table_Name = "tbl_borrowed_book";
                string table_Columns = "(Book_ID, Borrower_ID, Borrowed_Book_Date_Borrowed, Borrowed_Book_Due_Date, Borrowed_Book_Due_Status, Borrowed_Book_Date_Returned, Borrowed_Book_Number_of_Copies)";
                //string table_Columns = "(Book_Tittle, Book_Author, Book_Genre,  Book_Publisher, Book_Number_Of_Quantity)";
                string table_Column_Values = "(" +
                    Book_ID + ", " +
                    Borrower_ID + ", " +
                    singleQuoteChar + Borrowed_Book_Date_Borrowed + singleQuoteChar + ", " +
                    singleQuoteChar + Borrowed_Book_Due_Date + singleQuoteChar + ", " +
                    singleQuoteChar + Borrowed_Book_Due_Status + singleQuoteChar + ", " +
                    singleQuoteChar + Borrowed_Book_Date_Returned + singleQuoteChar + ", " +
                    Borrowed_Book_Number_of_Copies +
                    ")";

                ///////////

                string insert_SQL_StateMent = "Insert into " + table_Name + " " + table_Columns + "  values " + table_Column_Values;

                return insert_DBMethod(insert_SQL_StateMent);
            }
            else
            {
                //MessageBox.Show("di Pumasok dito tama Book_ID at Borrower_ID");
                return false;
            }

            
        }
        //*/
        public List<List<string>> select_DBMethod_return_2DList_Table_Records(string select_SQL_StateMent)
        {
            connectDB = new MySqlConnection(ConnectString);

            List<List<string>> select_Query_Result_2D_Liist = new List<List<string>>();
            try
            {
                connectDB.Open();
                cmd = new MySqlCommand(select_SQL_StateMent, connectDB);
                MySqlDataReader tableReader = cmd.ExecuteReader();

                while (tableReader.Read())
                {
                    List<string> rowRecord_StrList = new List<string>();

                    for (int i = 0; i < tableReader.FieldCount; i++)
                    {
                        rowRecord_StrList.Add(tableReader.GetValue(i).ToString());
                    }
                 
                    select_Query_Result_2D_Liist.Add(rowRecord_StrList);
                }
            }
            catch (Exception e)
            {

                return null;
            }
            finally
            {
                connectDB.Close();
            }

            return select_Query_Result_2D_Liist;
        }

        public List<List<string>> select_ALL_Form_tbl_borrower()
        {

            //sqlStrCommand = "Select * From main";
            
            
            string singleQuoteChar = "'";

            string table_Name = "tbl_borrower";
            /*
            string table_Columns = "(Borrower_Last_Name, Borrower_First_Name, Borrower_Middle_Name, Borrower_Name, Borrower_Address, Borrower_Contact_Number, Borrower_Age, Borrower_Type_of_Valid_ID)";
            string table_Column_Values = "(" +
                singleQuoteChar + Borrower_Last_Name + singleQuoteChar + ", " +
                singleQuoteChar + Borrower_First_Name + singleQuoteChar + ", " +
                singleQuoteChar + Borrower_Middle_Name + singleQuoteChar + ", " +
                singleQuoteChar + Borrower_Name + singleQuoteChar + ", " +
                singleQuoteChar + Borrower_Address + singleQuoteChar + ", " +
                singleQuoteChar + Borrower_Contact_Number + singleQuoteChar + ", " +
                Borrower_Age + ", " +
                singleQuoteChar + Borrower_Type_of_Valid_ID + singleQuoteChar +
                ")";
            //*/
            ///////////

            string select_SQL_StateMent = "Select * From " + table_Name;


            return select_DBMethod_return_2DList_Table_Records(select_SQL_StateMent);
        }


        public List<List<string>> selectbakalla()
        {
            string table_Name = "tbl_borrower";

            string select_SQL_StateMent = "Select Borrower_Last_Name from " + table_Name + "where Borrower_Last_Name = Tan";

            return select_DBMethod_return_2DList_Table_Records(select_SQL_StateMent);

        }
    }

}
