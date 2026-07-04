using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using PhotoArchive.Collections;
using PhotoArchive.Entities;
using static System.Net.Mime.MediaTypeNames;

namespace PhotoArchive.Query.EntityQuery
{
    internal class PoliticoQuery
    {
        private DataQueryProcessor _db;
        private string _text = "";

        public PoliticoQuery(DataQueryProcessor db)
        {
            _db = db;
        }

        public Politici? ExecuteDataQuery()
        {
            _text = _db.GetTextToSearch();
            var _list_politici = new Politici();
            try
            {
                if (_db.GetParameter() is not ("Nato fra il" or "Attivo dal"))
                {
                    var _ctrl = new ControlQueryText().ControlTextToSearch(_text);
                    if (!_ctrl)
                    {
                        throw new ArgumentException("Il nome non è valido per la ricerca SQL.");
                    }
                }

                using (SqlConnection conn = new SqlConnection(_db.GetConnectionString()))
                {
                    string query = _db.GetQueryToSend();
                    SqlCommand cmd = new SqlCommand(query, conn);

                    switch (_db.GetParameter())
                    {
                        case "Nome":
                            cmd.Parameters.Add("@name", SqlDbType.Text);
                            cmd.Parameters["@name"].Value = "%" + _text + "%";
                            break;
                        case "Cognome":
                            cmd.Parameters.Add("@surname", SqlDbType.Text);
                            cmd.Parameters["@surname"].Value = "%" + _text + "%";
                            break;
                        case "Partito":
                            cmd.Parameters.Add("@party", SqlDbType.Text);
                            cmd.Parameters["@party"].Value = "%" + _text + "%";
                            break;
                        case "Nato fra il":
                            cmd.Parameters.Add("@date_b", SqlDbType.Date);
                            cmd.Parameters.Add("@date_d", SqlDbType.Date);
                            cmd.Parameters["@date_b"].Value = _db.GetDateBirth();
                            cmd.Parameters["@date_d"].Value = _db.GetDateDeath();
                            break;
                        case "Attivo dal":
                            cmd.Parameters.Add("@date_in", SqlDbType.Date);
                            cmd.Parameters.Add("@date_out", SqlDbType.Date);
                            cmd.Parameters["@date_in"].Value = _db.GetDateStart();
                            cmd.Parameters["@date_out"].Value = _db.GetDateEnd();
                            break;
                    }

                    conn.Open();
       
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            Politico p = new Politico(
                                            !dr.IsDBNull(0) ? dr.GetInt32(0) : -1,
                                            !dr.IsDBNull(1) ? dr.GetString(1) : string.Empty,
                                            !dr.IsDBNull(2) ? dr.GetString(2) : string.Empty,
                                            !dr.IsDBNull(3) ? dr.GetString(3) : string.Empty,
                                            !dr.IsDBNull(4) ? dr.GetString(4) : string.Empty,
                                            !dr.IsDBNull(5) ? dr.GetDateTime(5) : DateTime.MinValue.Date,
                                            !dr.IsDBNull(6) ? dr.GetDateTime(6) : DateTime.MinValue.Date,
                                            !dr.IsDBNull(7) ? dr.GetDateTime(7) : DateTime.MinValue.Date,
                                            !dr.IsDBNull(8) ? dr.GetDateTime(8) : DateTime.MinValue.Date);
                            _list_politici.Add(p);
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
            _list_politici.SortByName();
            return _list_politici;
        }
    }
}
