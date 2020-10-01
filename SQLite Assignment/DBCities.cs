using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLite_Assignment
{
    class DBCities
    {
        private const string CONNECTION_STRING = "Data Source = population.db";
        private const string CITIES_TABLE = "Cities";
        private const string CITY_COLUMN = "City";
        private const string POPULATION_COLUMN = "Population";
        private const string CITY_PARAMETER = "@city";
        private const string POPULATION_PARAMETER = "@population";

        private SQLiteConnection conn;
        private SQLiteCommand comm;
        private SQLiteDataAdapter da;
        private DataSet ds;
        private string SQL;

        private string mLastStatus;

        public string LastStatus
        {
            get { return mLastStatus; }
        }

        public DataTable GetAllCities()
        {
            SQL = "SELECT * FROM " + CITIES_TABLE + " ORDER BY " + CITY_COLUMN;

            try
            {
                using (conn = new SQLiteConnection(CONNECTION_STRING))
                {
                    conn.Open();

                    using (da = new SQLiteDataAdapter(SQL, conn))
                    {
                        using (ds = new DataSet())
                        {
                            ds.Clear();
                            da.Fill(ds);
                            return ds.Tables[0];
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public bool TestDatabaseConnection()
        {
            bool result = true;

            try
            {
                using (conn = new SQLiteConnection(CONNECTION_STRING))
                {
                    conn.Open();
                }
            }
            catch (Exception ex)
            {
                result = false;
                mLastStatus = "Error opening database";
            }

            return result;
        }

        public bool AddCity(string pCity, double pPopulation)
        {
            bool result = true;

            SQL = "INSERT INTO " + CITIES_TABLE + "(" + CITY_COLUMN + ", " + POPULATION_COLUMN + ")" +
                "VALUES(" + CITY_PARAMETER + "," + POPULATION_PARAMETER + ");";

            try
            {
                using (conn = new SQLiteConnection(CONNECTION_STRING))
                {
                    conn.Open();

                    using (comm = new SQLiteCommand(SQL, conn))
                    {
                        comm.Parameters.AddWithValue(CITY_PARAMETER, pCity);
                        comm.Parameters.AddWithValue(POPULATION_PARAMETER, pPopulation);

                        comm.ExecuteNonQuery();
                        mLastStatus = "Record added to database";
                    }
                }
            }
            catch (Exception ex)
            {
                result = false;
                mLastStatus = "Error adding to database";
            }

            return result;
        } //end AddEmployee

        public bool DeleteCity(string pCity)
        {
            bool result = true;

            SQL = "DELETE FROM " + CITIES_TABLE + " WHERE " + CITY_COLUMN + " = " + CITY_PARAMETER;

            try
            {
                using (conn = new SQLiteConnection(CONNECTION_STRING))
                {
                    conn.Open();

                    using (comm = new SQLiteCommand(SQL, conn))
                    {
                        comm.Parameters.AddWithValue(CITY_PARAMETER, pCity);
                        if (comm.ExecuteNonQuery() > 0)
                        {
                            mLastStatus = "Record deleted";
                        }
                        else
                        {
                            mLastStatus = "No record with that ID number";
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                result = false;
                mLastStatus = "Error deleting";
            }

            return result;
        }

        public bool EditCity(string pCity, double pPopulation)
        {
            bool result = true;

            SQL = "UPDATE " + CITIES_TABLE + " SET " + CITY_COLUMN +
                " = " + CITY_PARAMETER + ", " + POPULATION_COLUMN + " = " + POPULATION_PARAMETER +
                " WHERE " + CITY_COLUMN + " = " + CITY_PARAMETER;

            try
            {
                using (conn = new SQLiteConnection(CONNECTION_STRING))
                {
                    conn.Open();

                    using (comm = new SQLiteCommand(SQL, conn))
                    {
                        comm.Parameters.AddWithValue(CITY_PARAMETER, pCity);
                        comm.Parameters.AddWithValue(POPULATION_PARAMETER, pPopulation);

                        comm.ExecuteNonQuery();
                        mLastStatus = "Record updated";
                    }
                }
            }
            catch (Exception ex)
            {
                result = false;
                mLastStatus = "Error updating record";
            }

            return result;
        } //end EditCity

        public DataTable FindByName(string pCity)
        {
            SQL = "SELECT * FROM " + CITIES_TABLE + " WHERE " + CITY_COLUMN + " = " + CITY_PARAMETER;

            try
            {
                using (conn = new SQLiteConnection(CONNECTION_STRING))
                {
                    conn.Open();

                    using (da = new SQLiteDataAdapter(SQL, conn))
                    {
                        da.SelectCommand.Parameters.AddWithValue(CITY_PARAMETER, pCity);

                        using (ds = new DataSet())
                        {
                            ds.Clear();
                            da.Fill(ds);
                            return ds.Tables[0];
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        
        public int GetPopulationTotal()
        {
            SQL = "SELECT SUM(" + POPULATION_COLUMN + ") FROM " + CITIES_TABLE;

            using (conn = new SQLiteConnection(CONNECTION_STRING))
            {
                conn.Open();

                using (comm = new SQLiteCommand(SQL, conn))
                {
                    return Convert.ToInt32(comm.ExecuteScalar());
                }
            }
        }

        public int GetPopulationAverage()
        {
            SQL = "SELECT AVG(" + POPULATION_COLUMN + ") FROM " + CITIES_TABLE;

            using (conn = new SQLiteConnection(CONNECTION_STRING))
            {
                conn.Open();

                using (comm = new SQLiteCommand(SQL, conn))
                {
                    return Convert.ToInt32(comm.ExecuteScalar());
                }
            }
        }
    }

}
