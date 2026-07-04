using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using PhotoArchive.Collections;
using PhotoArchive.Entities;

namespace PhotoArchive.Query.EntityQuery
{
    internal class LuogoQuery
    {
        private DataQueryProcessor _db;
        private string _text = "";

        public LuogoQuery(DataQueryProcessor db)
        {
            _db = db;
        }

        public Luoghi? ExecuteDataQuery()
        {
            _text = _db.GetTextToSearch();
            var _list_luoghi = new Luoghi();
            try
            {
                var _ctrl = new ControlQueryText().ControlTextToSearch(_text);
                if (!_ctrl)
                {
                    throw new ArgumentException("Il nome non è valido per la ricerca SQL.");
                }

                using (SqlConnection conn = new SqlConnection(_db.GetConnectionString()))
                {
                    string query = _db.GetQueryToSend();
                    SqlCommand cmd = new SqlCommand(query, conn);

                    switch (_db.GetParameter())
                    {
                        case "Citta'":
                            cmd.Parameters.Add("@city", SqlDbType.Text);
                            cmd.Parameters["@city"].Value = "%" + _text + "%";
                            break;
                        case "Descrizione":
                            cmd.Parameters.Add("@description", SqlDbType.Text);
                            cmd.Parameters["@description"].Value = "%" + _text + "%";
                            break;
                    }

                    conn.Open();

                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            Luogo p = new Luogo(
                                            !dr.IsDBNull(0) ? dr.GetInt32(0) : -1,
                                            !dr.IsDBNull(1) ? dr.GetString(1) : string.Empty,
                                            !dr.IsDBNull(2) ? dr.GetString(2) : string.Empty);
                            _list_luoghi.Add(p);
                        }
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                // show exception 
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            _list_luoghi.SortByName();
            return _list_luoghi;
        }
    }
}
