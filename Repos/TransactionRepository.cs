using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using Atestat.Models;

namespace Atestat.Transactions
{
    class TransactionRepository
    {

        private string connectionString =
            @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=db_transactions.mdb";

        public DataTable GetCategories()
        {
            var dt = new DataTable();

            string sql = "SELECT CategoryID, CategoryName FROM db_categories";

            using (var conn = new OleDbConnection(connectionString))
            {
                conn.Open();
                using (var cmd = new OleDbCommand(sql, conn))
                {
                    using (var adapter = new OleDbDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }

            return dt;
        }

        public void InsertTransaction(TransactionModel transaction)
        {
            string sql = @"
                INSERT INTO db_transactions 
                    ([DateOfTransaction], [TransactionType], [CategoryID], [Amount], [Note])
                VALUES
                    (@DateOfTransaction, @TransactionType, @CategoryID, @Amount, @Note)";

            using (var conn = new OleDbConnection(connectionString))
            {
                conn.Open();
                using (var cmd = new OleDbCommand(sql, conn))
                {
                    // Make sure you add parameters in the same order 
                    // they appear in the VALUES(...) clause:
                    cmd.Parameters.Add("@DateOfTransaction", OleDbType.Date).Value = transaction.DateOfTransaction;
                    cmd.Parameters.Add("@TransactionType", OleDbType.VarChar, 50).Value = transaction.TransactionType;
                    cmd.Parameters.Add("@CategoryID", OleDbType.Integer).Value = transaction.CategoryID;
                    cmd.Parameters.Add("@Amount", OleDbType.Double).Value = Convert.ToDouble(transaction.Amount);
                    cmd.Parameters.Add("@Note", OleDbType.VarChar, 255).Value = string.IsNullOrEmpty(transaction.Note) ? (object)DBNull.Value : transaction.Note;


                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Similar pattern for ReadTransaction, UpdateTransaction, DeleteTransaction:
        //public TransactionModel ReadTransaction(int transactionId)
        //{
        //    // ...
        //    // Return a TransactionModel
        //}

        //public void UpdateTransaction(TransactionModel transaction)
        //{
        //    // ...
        //}

        public void DeleteTransaction(int transactionId)
        {
            // Trebuie sa gasesti un mod de a selecta tranzactia pe care vr sa o stergi
            // si sa apelezi functia cu id-ul ei ca parametru

            string del = @"
                DELETE FROM [db_transactions] WHERE TransactionID = @TransactionID";
            
            using (var conn = new OleDbConnection(connectionString))
            {
                conn.Open();
                using (var cmd = new OleDbCommand(del, conn))
                {
                    cmd.Parameters.Add("@TransactionID", OleDbType.Integer).Value = transactionId;
                    int rowsAffected = cmd.ExecuteNonQuery();

                    // Check if a record was actually deleted
                    if(rowsAffected == 0)
                    {
                        throw new Exception("No record found with the specified TransactionID");
                    }
                }
            }
        }

        public DataTable LoadTransactions()
        {
            //string sql = "SELECT [DateOfTransaction], [TransactionType], [CategoryID], [Amount], [Note] FROM [db_transactions]" +
            //    "ORDER BY [DateOfTransaction] DESC";

            string load = "SELECT " +
                "t.DateOfTransaction," +
                "t.TransactionType," +
                "c.CategoryName," +
                "t.Amount," +
                "t.Note " +
                "FROM [db_transactions] t INNER JOIN [db_categories] c ON t.CategoryID = c.CategoryID"
                +" ORDER BY DateOfTransaction DESC";

            DataTable dt = new DataTable();

            try
            {
                using (OleDbConnection conn = new OleDbConnection(connectionString))
                {
                    conn.Open();
                    using (OleDbCommand cmd = new OleDbCommand(load, conn))
                    {
                        using (OleDbDataAdapter adapter = new OleDbDataAdapter(cmd))
                        {
                            
                            adapter.Fill(dt);
                            
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }

            return dt;
        }
    }
}
