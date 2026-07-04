using System.Diagnostics.Eventing.Reader;
using System.Drawing.Text;
using System.Windows.Forms;
using PhotoArchive.Collections;
using PhotoArchive.Entities;
using PhotoArchive.Query;
using PhotoArchive.Utils;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PhotoArchive.UI
{
    public partial class FormGUI : Form
    {
        private string _localHostName = "KK-Laptop-01"; // LocalHost da cambiare per l'installazione su di un'altra macchina
        /*
         * utilizza questa query nel database per trovare il nome del LocalHost
         * 
         * use ArchivioFotografico
         * SELECT SERVERPROPERTY('MachineName') AS ServerName;
         */

        private SearchPlaceholderText _search_placeholder_text;

        private string _entity_to_query;
        private string _parameter_to_query;

        private string _conn_string;

        private Politici? _list_politici;
        private Sportivi? _list_sportivi;
        private Artisti? _list_artisti;
        private Luoghi? _list_luoghi;

        private IEntityCollection? _list_entity;
        private IEntity? _curr_entity;

        public FormGUI()
        {
            InitializeComponent();
            _disableAllNavigationButtons();

            this.AcceptButton = bSubmitToDatabase;
            ActiveControl = rb_ric_poli;
            ActiveControl = rb_ric_name;

            _entity_to_query = rb_ric_poli.Text;
            _parameter_to_query = rb_ric_name.Text;
            _search_placeholder_text = new SearchPlaceholderText(" il ", "nome", " del ", "politico");
            _curr_entity = null;
            // see https://www.connectionstrings.com/sql-server/
            _conn_string = $@"Server = {_localHostName}; Database = ArchivioFotografico; Trusted_Connection = True; TrustServerCertificate=True";
        }

        private void bSubmitToDatabase_Click(object sender, EventArgs e)
        {
            ActiveControl = bSubmitToDatabase;
            _disableAllNavigationButtons();
            _clearResults();

            DataQueryBuilder dqb = new DataQueryBuilder(_entity_to_query, _parameter_to_query);
            string data_query = dqb.GetDataQuery();

            DataQueryProcessor r_data = new DataQueryProcessor(_entity_to_query,
                                                    _parameter_to_query,
                                                    this.tb_ric_1.Text,
                                                    this.dtp_ric_dateB.Value,
                                                    this.dtp_ric_dateD.Value,
                                                    this.dtp_ric_dateIN.Value,
                                                    this.dtp_ric_dateOUT.Value,
                                                    data_query,
                                                    _conn_string
                                                    );

            switch (_entity_to_query)
            {
                case "Politico":
                    _list_politici = (Politici?)r_data.CallDataQuery();
                    _list_entity = _list_politici;
                    break;
                case "Sportivo":
                    _list_sportivi = (Sportivi?)r_data.CallDataQuery();
                    _list_entity = _list_sportivi;
                    break;
                case "Artista":
                    _list_artisti = (Artisti?)r_data.CallDataQuery();
                    _list_entity = _list_artisti;
                    break;
                case "Luogo":
                    _list_luoghi = (Luoghi?)r_data.CallDataQuery();
                    _list_entity = _list_luoghi;
                    break;
            }
            
            if (_list_entity != null)
            {
                if (_list_entity.GetCount() > 0)
                {
                    IEntity? _entity = _list_entity.GetFirst();
                    if (_entity != null)
                    {
                        _attach_photos(_list_entity);
                        _curr_entity = _entity;
                        ShowEntity(_curr_entity);
                        _enableNavigationButtons();
                    }
                }
                tb_data_count.Text = _list_entity.ShowCount();
            }
            else
            {
                this.tb_data_count.Text = "Ricerca non valida!";
                return;
            }
        }

        void _attach_photos(IEntityCollection _list_entity)
        {
            if (_list_entity != null)
            {
                for (IEntity? _entity = _list_entity.GetFirst(); _entity != null; _entity = _list_entity.GetNext())
                {
                    _attach_photo(_entity);
                }
                _list_entity.GetFirst();
                _enableFotoButtons();
            }
        }

        void _attach_photo(IEntity entity)
        {
            PhotoQueryBuilder pqb = new PhotoQueryBuilder(_entity_to_query);
            string photo_query = pqb.GetPhotoQuery();
            PhotoQueryProcessor r_photo = new(entity, _entity_to_query, photo_query, _conn_string);
            r_photo.CallPhotoQuery();
        }

        void ShowEntity(IEntity entity)
        {
            var data = entity.GetDisplayData();
            pictureBox1.Image = entity.GetFirstPhoto();
            tb_dataF_1.Text = data.GetValueOrDefault("tb_dataF_1", "");
            tb_dataF_2.Text = data.GetValueOrDefault("tb_dataF_2", "");
            tb_dataF_3.Text = data.GetValueOrDefault("tb_dataF_3", "");
            tb_dataF_4.Text = data.GetValueOrDefault("tb_dataF_4", "");
            tb_dataF_5_1.Text = data.GetValueOrDefault("tb_dataF_5_1", "");
            tb_dataF_5_2.Text = data.GetValueOrDefault("tb_dataF_5_2", "");
            tb_dataF_6.Text = data.GetValueOrDefault("tb_dataF_6", "");
            tb_dataF_7.Text = data.GetValueOrDefault("tb_dataF_7", "");
            tb_dataF_8.Text = data.GetValueOrDefault("tb_dataF_8", "");
            if (_list_entity != null)
            {
                tb_n_result.Text = (_list_entity.GetNCurrent() + "/" + _list_entity.GetCount()).ToString();
                tb_n_photo.Text = (entity.GetNPhoto() + "/" + entity.GetCountPhoto()).ToString();
            }
        }

        private void _clearResults()
        {
            _list_politici = null;
            tb_dataF_1.Text = "";
            tb_dataF_2.Text = "";
            tb_dataF_3.Text = "";
            tb_dataF_4.Text = "";
            tb_dataF_5_1.Text = "";
            tb_dataF_5_2.Text = "";
            tb_dataF_6.Text = "";
            tb_dataF_7.Text = "";
            tb_dataF_8.Text = "";
            tb_n_result.Text = "";
            tb_n_photo.Text = "";
        }

        private void rb_ric_poli_CheckedChanged(object sender, EventArgs e)
        {
            rb_ric_name.Checked = true;
            _search_placeholder_text.SetGenre("politico");
            _search_placeholder_text.SetArticle1(" il ");
            _search_placeholder_text.SetArticle2(" del ");
            rb_ric_name.Text = "Nome";
            l_dataF_name.Text = rb_ric_name.Text;
            rb_ric_surn.Visible = true;
            rb_ric_surn.Text = "Cognome";
            rb_ric_prof.Visible = true;
            rb_ric_prof.Text = "Partito";
            rb_ric_team.Visible = false;
            rb_ric_life.Visible = true;
            dtp_ric_dateB.Visible = true;
            l_ric_1.Visible = true;
            dtp_ric_dateD.Visible = true;
            rb_ric_care.Visible = true;
            dtp_ric_dateIN.Visible = true;
            l_ric_2.Visible = true;
            dtp_ric_dateOUT.Visible = true;
            l_dataF_surn.Visible = true;
            l_dataF_surn.Text = "Cognome";
            tb_dataF_2.Visible = true;
            l_dataF_prof.Visible = true;
            l_dataF_prof.Text = "Partito";
            tb_dataF_3.Visible = true;
            l_dataF_team.Visible = false;
            tb_dataF_4.Visible = false;
            l_dataF_care.Visible = true;
            tb_dataF_5_1.Visible = true;
            l_dataF_1.Visible = true;
            tb_dataF_5_2.Visible = true;
            l_dataF_birt.Visible = true;
            tb_dataF_6.Visible = true;
            l_dataF_deat.Visible = true;
            tb_dataF_7.Visible = true;
            l_dataF_desc.Visible = false;
            tb_dataF_8.Visible = false;
            tb_ric_1.PlaceholderText = _search_placeholder_text.GetPlaceHolder();
            _parameter_to_query = rb_ric_name.Text;
            _entity_to_query = rb_ric_poli.Text;
        }

        private void rb_ric_spor_CheckedChanged(object sender, EventArgs e)
        {
            rb_ric_name.Checked = true;
            _search_placeholder_text.SetGenre("sportivo");
            _search_placeholder_text.SetArticle1(" il ");
            _search_placeholder_text.SetArticle2(" dello ");
            rb_ric_name.Text = "Nome";
            l_dataF_name.Text = rb_ric_name.Text;
            rb_ric_surn.Visible = true;
            rb_ric_surn.Text = "Cognome";
            rb_ric_prof.Visible = true;
            rb_ric_prof.Text = "Sport";
            rb_ric_team.Visible = true;
            rb_ric_life.Visible = true;
            dtp_ric_dateB.Visible = true;
            l_ric_1.Visible = true;
            dtp_ric_dateD.Visible = true;
            rb_ric_care.Visible = false;
            dtp_ric_dateIN.Visible = false;
            l_ric_2.Visible = false;
            dtp_ric_dateOUT.Visible = false;
            l_dataF_surn.Visible = true;
            l_dataF_surn.Text = "Cognome";
            tb_dataF_2.Visible = true;
            l_dataF_prof.Visible = true;
            l_dataF_prof.Text = "Sport";
            tb_dataF_3.Visible = true;
            l_dataF_team.Visible = true;
            tb_dataF_4.Visible = true;
            l_dataF_care.Visible = false;
            tb_dataF_5_1.Visible = false;
            l_dataF_1.Visible = false;
            tb_dataF_5_2.Visible = false;
            l_dataF_birt.Visible = true;
            tb_dataF_6.Visible = true;
            l_dataF_deat.Visible = true;
            tb_dataF_7.Visible = true;
            l_dataF_desc.Visible = false;
            tb_dataF_8.Visible = false;
            tb_ric_1.PlaceholderText = _search_placeholder_text.GetPlaceHolder();
            _parameter_to_query = rb_ric_name.Text;
            _entity_to_query = rb_ric_spor.Text;
        }

        private void rb_ric_arti_CheckedChanged(object sender, EventArgs e)
        {
            rb_ric_name.Checked = true;
            _search_placeholder_text.SetGenre("artista");
            _search_placeholder_text.SetArticle1(" il ");
            _search_placeholder_text.SetArticle2(" dell'");
            rb_ric_name.Text = "Nome";
            l_dataF_name.Text = rb_ric_name.Text;
            rb_ric_surn.Visible = true;
            rb_ric_surn.Text = "Cognome";
            rb_ric_prof.Visible = true;
            rb_ric_prof.Text = "Attivita'";
            rb_ric_team.Visible = false;
            rb_ric_life.Visible = true;
            dtp_ric_dateB.Visible = true;
            l_ric_1.Visible = true;
            dtp_ric_dateD.Visible = true;
            rb_ric_care.Visible = false;
            dtp_ric_dateIN.Visible = false;
            l_ric_2.Visible = false;
            dtp_ric_dateOUT.Visible = false;
            l_dataF_surn.Visible = true;
            l_dataF_surn.Text = "Cognome";
            tb_dataF_2.Visible = true;
            l_dataF_prof.Visible = true;
            l_dataF_prof.Text = "Attivita'";
            tb_dataF_3.Visible = true;
            l_dataF_team.Visible = false;
            tb_dataF_4.Visible = false;
            l_dataF_care.Visible = false;
            tb_dataF_5_1.Visible = false;
            l_dataF_1.Visible = false;
            tb_dataF_5_2.Visible = false;
            l_dataF_birt.Visible = true;
            tb_dataF_6.Visible = true;
            l_dataF_deat.Visible = true;
            tb_dataF_7.Visible = true;
            l_dataF_desc.Visible = false;
            tb_dataF_8.Visible = false;
            tb_ric_1.PlaceholderText = _search_placeholder_text.GetPlaceHolder();
            _parameter_to_query = rb_ric_name.Text;
            _entity_to_query = rb_ric_arti.Text;
        }

        private void rb_ric_luog_CheckedChanged(object sender, EventArgs e)
        {
            rb_ric_name.Checked = true;
            _search_placeholder_text.SetGenre("luogo");
            _search_placeholder_text.SetArticle1(" il ");
            _search_placeholder_text.SetArticle2(" del ");
            rb_ric_name.Text = "Citta'";
            l_dataF_name.Text = rb_ric_name.Text;
            rb_ric_surn.Visible = true;
            rb_ric_surn.Text = "Descrizione";
            rb_ric_prof.Visible = false;
            rb_ric_team.Visible = false;
            rb_ric_life.Visible = false;
            dtp_ric_dateB.Visible = false;
            l_ric_1.Visible = false;
            dtp_ric_dateD.Visible = false;
            rb_ric_care.Visible = false;
            dtp_ric_dateIN.Visible = false;
            l_ric_2.Visible = false;
            dtp_ric_dateOUT.Visible = false;
            l_dataF_surn.Visible = false;
            tb_dataF_2.Visible = false;
            l_dataF_care.Visible = false;
            l_dataF_prof.Visible = false;
            tb_dataF_3.Visible = false;
            l_dataF_team.Visible = false;
            tb_dataF_4.Visible = false;
            l_dataF_care.Visible = false;
            tb_dataF_5_1.Visible = false;
            l_dataF_1.Visible = false;
            tb_dataF_5_2.Visible = false;
            l_dataF_birt.Visible = false;
            tb_dataF_6.Visible = false;
            l_dataF_deat.Visible = false;
            tb_dataF_7.Visible = false;
            l_dataF_desc.Visible = true;
            tb_dataF_8.Visible = true;
            tb_ric_1.PlaceholderText = _search_placeholder_text.GetPlaceHolder();
            _parameter_to_query = rb_ric_name.Text;
            _entity_to_query = rb_ric_luog.Text;
        }
        private void rb_ric_name_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_ric_name.Checked)
            {
                tb_ric_1.Enabled = true;
                _search_placeholder_text.SetArticle1(" il ");
                _search_placeholder_text.SetTipo("nome");
                tb_ric_1.PlaceholderText = _search_placeholder_text.GetPlaceHolder();
                _parameter_to_query = rb_ric_name.Text;
                ResetDate();
            }
        }

        private void rb_ric_surn_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_ric_surn.Checked)
            {
                tb_ric_1.Enabled = true;
                _search_placeholder_text.SetTipo(rb_ric_surn.Text.ToLower());
                _search_placeholder_text.SetArticle1(" il ");
                if (rb_ric_spor.Checked)
                {
                    _search_placeholder_text.SetArticle2(" dello ");
                }
                else if (rb_ric_luog.Checked)
                {
                    _search_placeholder_text.SetArticle1(" parole descrittive");
                    _search_placeholder_text.SetTipo("");
                }
                tb_ric_1.PlaceholderText = _search_placeholder_text.GetPlaceHolder();
                _parameter_to_query = rb_ric_surn.Text;
                ResetDate();
            }
        }

        private void rb_ric_prof_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_ric_prof.Checked)
            {
                tb_ric_1.Enabled = true;
                _search_placeholder_text.SetTipo(rb_ric_prof.Text.ToLower());
                if (rb_ric_spor.Checked)
                {
                    _search_placeholder_text.SetArticle1(" lo ");
                    _search_placeholder_text.SetArticle2(" praticato dallo ");
                }
                else if (rb_ric_arti.Checked)
                {
                    _search_placeholder_text.SetArticle1(" l'");
                }
                tb_ric_1.PlaceholderText = _search_placeholder_text.GetPlaceHolder();
                _parameter_to_query = rb_ric_prof.Text;
                ResetDate();
            }
        }

        private void rb_ric_team_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_ric_team.Checked)
            {
                tb_ric_1.Enabled = true;
                _search_placeholder_text.SetTipo(rb_ric_team.Text.ToLower());
                _search_placeholder_text.SetArticle1(" la ");
                _search_placeholder_text.SetArticle2(" dello ");
                tb_ric_1.PlaceholderText = _search_placeholder_text.GetPlaceHolder();
                _parameter_to_query = rb_ric_team.Text;
                ResetDate();
            }
        }

        private void rb_ric_life_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_ric_life.Checked)
            {
                dtp_ric_dateB.Enabled = true;
                dtp_ric_dateD.Enabled = true;
                tb_ric_1.PlaceholderText = "Seleziona le date";
                tb_ric_1.Enabled = false;
                _parameter_to_query = rb_ric_life.Text;
            }
            else
            {
                dtp_ric_dateB.Enabled = false;
                dtp_ric_dateD.Enabled = false;
            }
        }

        private void rb_ric_care_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_ric_care.Checked)
            {
                dtp_ric_dateIN.Enabled = true;
                dtp_ric_dateOUT.Enabled = true;
                dtp_ric_dateB.Enabled = false;
                dtp_ric_dateD.Enabled = false;
                tb_ric_1.PlaceholderText = "Seleziona le date";
                tb_ric_1.Enabled = false;
                _parameter_to_query = rb_ric_care.Text;
            }
            else
            {
                dtp_ric_dateIN.Enabled = false;
                dtp_ric_dateOUT.Enabled = false;
            }
        }

        private void ResetDate()
        {
            dtp_ric_dateB.Value = DateTime.Today;
            dtp_ric_dateD.Value = DateTime.Today;
            dtp_ric_dateIN.Value = DateTime.Today;
            dtp_ric_dateOUT.Value = DateTime.Today;
        }

        private void _disableAllNavigationButtons()
        {
            this.bt_pre_result.Enabled = false;
            this.bt_next_result.Enabled = false;
            _disableFotoButtons();
        }

        private void _disableFotoButtons()
        {
            this.bt_pre_photo.Enabled = false;
            this.bt_next_photo.Enabled = false;
        }

        private void _enableNavigationButtons()
        {
            this.bt_pre_result.Enabled = true;
            this.bt_next_result.Enabled = true;
        }

        private void _enableFotoButtons()
        {
            this.bt_pre_photo.Enabled = true;
            this.bt_next_photo.Enabled = true;
        }

        private void bt_pre_result_Click(object sender, EventArgs e)
        {
            if (_list_entity != null)
            {
                IEntity? _entity = _list_entity.GetPrevious();
                if (_entity == null)
                {
                    MessageBox.Show("Non ci sono piu' risultati da visualizzare",
                        "Attenzione !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                _curr_entity = _entity;
                ShowEntity(_curr_entity);
            }
        }

        private void bt_next_result_Click(object sender, EventArgs e)
        {
            if (_list_entity != null)
            {
                IEntity? _entity = _list_entity.GetNext();
                if (_entity == null)
                {
                    MessageBox.Show("Non ci sono piu' risultati da visualizzare",
                        "Attenzione !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                _curr_entity = _entity;
                ShowEntity(_curr_entity);
            }
        }

        private void bt_pre_photo_Click(object sender, EventArgs e)
        {
            if (_curr_entity != null)
            {
                Image? image = _curr_entity.GetPrevPhoto();
                if (null == image)
                {
                    MessageBox.Show("Non ci sono piu' foto per questo politico da visualizzare",
                        "Attenzione !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                this.pictureBox1.Image = image;
                tb_n_photo.Text = (_curr_entity.GetNPhoto() + "/" + _curr_entity.GetCountPhoto()).ToString();
            }
        }

        private void bt_next_photo_Click(object sender, EventArgs e)
        {
            if (_curr_entity != null)
            {
                Image? image = _curr_entity.GetNextPhoto();
                if (null == image)
                {
                    MessageBox.Show("Non ci sono piu' foto per questo politico da visualizzare",
                        "Attenzione !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                this.pictureBox1.Image = image;
                tb_n_photo.Text = (_curr_entity.GetNPhoto() + "/" + _curr_entity.GetCountPhoto()).ToString();
            }
        }
    }
}