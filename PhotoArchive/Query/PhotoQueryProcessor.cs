using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using PhotoArchive.Collections;
using PhotoArchive.Entities;
using PhotoArchive.Query.EntityQuery;

namespace PhotoArchive.Query
{
    internal class PhotoQueryProcessor
    {
        private IEntity _entity;
        private string _entity_to_query;
        private string _photo_query;
        private string _conn_string;

        public PhotoQueryProcessor(IEntity entity,string entityToQuery, string photoQuery, string connString)
        {
            _entity = entity;
            _entity_to_query = entityToQuery;
            _photo_query = photoQuery;
            _conn_string = connString;
        }

        public void CallPhotoQuery()
        {

            try
            {
                using (SqlConnection conn = new SqlConnection(_conn_string))
                {
                    SqlCommand cmd = new SqlCommand(_photo_query, conn);
                    switch (_entity_to_query)
                    {
                        case "Politico":
                            cmd.Parameters.Add("@id_politico", SqlDbType.Int);
                            cmd.Parameters["@id_politico"].Value = _entity.GetID();
                            break;
                        case "Sportivo":
                            cmd.Parameters.Add("@id_sportivo", SqlDbType.Int);
                            cmd.Parameters["@id_sportivo"].Value = _entity.GetID();
                            break;
                        case "Artista":
                            cmd.Parameters.Add("@id_artista", SqlDbType.Int);
                            cmd.Parameters["@id_artista"].Value = _entity.GetID();
                            break;
                        case "Luogo":
                            cmd.Parameters.Add("@id_luogo", SqlDbType.Int);
                            cmd.Parameters["@id_luogo"].Value = _entity.GetID();
                            break;
                    }

                    conn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            // leggete la documentazione
                            // https://learn.microsoft.com/en-us/dotnet/api/system.data.sqlclient.sqldatareader.getbytes?view=netframework-4.7.2&devlangs=csharp&f1url=%3FappId%3DDev16IDEF1%26l%3DEN-US%26k%3Dk(System.Data.SqlClient.SqlDataReader.GetBytes)%3Bk(TargetFrameworkMoniker-.NETFramework%2CVersion%253Dv4.7.2)%3Bk(DevLang-csharp)%26rd%3Dtrue
                            if (!dr.IsDBNull(0))
                            {
                                long len = dr.GetBytes(0, 0, null, 0, 0);
                                byte[] data = new byte[len];
                                // il cast a int su len non causera' problemi per immagini
                                // inferiori ai 2 Giba bytes di lunghezza. Per immagini
                                // di lunghezza superiori serve un loop che chiama
                                // opportunamente GetBytes();
                                dr.GetBytes(0, 0, data, 0, (int)len);
                                // uso un memory stream dal buffer ritornato dalla query
                                // per ottenere una immagine grafica
                                MemoryStream ms = new MemoryStream(data);
                                Image photo = Image.FromStream(ms);
                                _entity.AddPhoto(photo);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // show exception 
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
