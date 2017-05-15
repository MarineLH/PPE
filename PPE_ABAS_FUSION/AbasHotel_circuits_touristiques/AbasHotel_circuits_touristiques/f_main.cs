using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using Dapper;
using System.Globalization;

namespace PPE_ABAS_Circuits
{
    /// <summary>
    /// class du formulaire "f_main" -> application globale
    /// </summary>
    public partial class f_main : Form
    {

        //public static string MySQLConnectionString = "Server=romainvaleye.ovh;Database=abas_db;Uid=abas_user;Pwd=3c51713e-534e-4a1d-bc8e-e51c29d3014e;";

        public Batiment bat_choisi;
        public static string nom_circuit;
        public static string tauxTva;
        public static int id_circuit;
        public static string circuitResaTrue;
        public static int id_statutEtape;
        public static DateTime circuit_date_choisie;

        /// <summary>
        /// initialise les composants de la class f_main
        /// </summary>
        public f_main()
        {
            InitializeComponent();
           // resaCircuitNbParticipants.KeyPress += new KeyPressEventHandler(resaCircuitNbParticipants_KeyPress);
        }
        /// <summary>
        /// initialise les composants de la class f_main une fois le Batiment choisi (en fonction de sa localisation)
        /// </summary>
        /// <param name="batiment_choisi">le batiment choisi</param>
        public f_main(Batiment batiment_choisi)
        {
            InitializeComponent();
            bat_choisi = batiment_choisi;

        }

        /// <summary>
        /// fonction qui se déclenche en chargement de f_main
        /// </summary>
        /// <param name="sender">objet qui soulève l'évènement</param>
        /// <param name="e">instance d'EventArgs incluant un objet qui hérite de EventArgs</param>
        private void f_main_Load(object sender, EventArgs e)
        {
            lb_hotel_choisi.Text = "Bienvenue sur le logiciel d'" + bat_choisi.bat_libelle;

            int hotel_choisi_id = bat_choisi.bat_id;

            IEnumerable<CircuitTouristique> circuits;
            IEnumerable<TVA> tvas;
            IEnumerable<CircuitStatutEtape> statutEtapesCircuit;
            

            // se connecte à la DB en utilisant les données précédemment mentionnées
            using (MySqlConnection connection = new MySqlConnection(Globals.MySQLConnectionString))
            {

                string sql = "select * from CircuitTouristique where Hotel_hotel_bat_id = @hotel_ident";
                circuits = connection.Query<CircuitTouristique>(sql, new { hotel_ident = hotel_choisi_id });

                string getTVA = "select * from TVA";
                tvas = connection.Query<TVA>(getTVA);

                string getEtapeStatus = "select * from CircuitStatutEtape";
                statutEtapesCircuit = connection.Query<CircuitStatutEtape>(getEtapeStatus);

               
            }
            // récupère le taux des tvas et ajoute cette liste à la comboBox
            foreach (TVA tva in tvas)
            {
                cbAddCirTVA.Items.Add(tva).ToString();
            }
            // récupère le libelle des statuts et ajoute cette liste à la comboBox
            foreach (CircuitStatutEtape statut in statutEtapesCircuit)
            {
                addEtapeStatut.Items.Add(statut);
            }
            


            // récupère les libellés des circuits et ajoute cette liste à la comboBox
            foreach (CircuitTouristique cir in circuits)
            {
                choose_cir_cb.Items.Add(cir);
                resaChooseCircuit.Items.Add(cir);
                addetapeChooseCircuit.Items.Add(cir);
            }
            getReservations();
        }

        public void getReservations()
        {
            // récupération des réservations et des infos de clients
            using (MySqlConnection connection = new MySqlConnection(Globals.MySQLConnectionString))
            {
                IEnumerable<Client> clients = connection.Query<Client>("select * from Client");
                IEnumerable<Reservation> Lesreservations = connection.Query<Reservation>("select * from Reservation");


                // pour chaque client, récupère les réservations lui appartenant
                foreach (Client cli in clients)
                {
                    foreach (Reservation res in Lesreservations)
                    {
                        if (cli.cli_id == res.Client_cli_id)
                        {

                            DateTime start = res.res_date;
                            DateTime end = res.res_dateSortie;
                            DateTime now = DateTime.Now;



                            // n'affiche que les réservations à venir, ou en cours
                            if ((now > start) && (now < end) || (now < end) && (now < start))
                            {
                                string dateReservation = String.Format("{0:dd/MM/yyyy}", res.res_date);
                                string dateFinReservation = String.Format("{0:dd/MM/yyyy}", res.res_dateSortie);
                                string res_id = res.res_id.ToString();

                                // vérifie si une réservation de circuit touristique existe pour la période de séjour (réservation) d'un client
                                if (res.CircuitTouristique_cir_id == 0)
                                {
                                    circuitResaTrue = "non";
                                }
                                else
                                {
                                    circuitResaTrue = "oui";
                                }

                                string[] arrayInter = new string[] { " ", cli.cli_nom, cli.cli_prenom, dateReservation, dateFinReservation, circuitResaTrue, cli.cli_tel, cli.cli_mail, res_id };

                                // ajout des informations client et réservation dans la listeView : listViewClients
                                ListViewItem itm;
                                itm = new ListViewItem(arrayInter);
                                listViewClients.Items.Add(itm);
                            }
                        }


                    }
                }

            }
            clientAlreadyHaveResa.Visible = false;
        }


        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void réservationsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        /// <summary>
        /// fonction qui s'active lorsque l'index (le circuit choisi dans la comboBox change)
        /// </summary>
        /// <param name="sender">objet qui soulève l'évènement</param>
        /// <param name="e">instance d'EventArgs incluant un objet qui hérite de EventArgs</param>
        private void choose_cir_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            CircuitTouristique cir_choisi;
            CircuitEtape cir_choisi_etape;
            TVA Latva;
            int nbPlacesReserv;

            // vérifie si un circuit est choisit

            if (choose_cir_cb.SelectedIndex > -1)
            {
                nom_circuit = choose_cir_cb.SelectedItem.ToString();
                circuit_date_choisie = dateTimePickerCircuitResa.Value;

                // sélectionne les informations relatives au circuit touristique choisi
                using (MySqlConnection connection = new MySqlConnection(Globals.MySQLConnectionString))
                {
                    string getCircuitChoisi = "select * from CircuitTouristique where cir_libelle=@libelle";
                    string getTva = "select * from TVA inner join CircuitTouristique on CircuitTouristique.TVA_tva_id = TVA.tva_id where tva_id =@Latva";
                    string getNbPlacesResev = "select SUM(nbParticipantsCircuit)AS nbParticipantsCircuit_total from Reservation where date_circuit = @date_circuit and CircuitTouristique_cir_id = @circuit_choisi and CircuitTouristique_cir_id";

                    cir_choisi = connection.Query<CircuitTouristique>(getCircuitChoisi, new { libelle = nom_circuit }).FirstOrDefault();

                    DateTime date_circuit = circuit_date_choisie;
                    int circuit_choisi = cir_choisi.cir_id;

                    dynamic result = connection.Query(getNbPlacesResev, new { date_circuit = circuit_date_choisie.ToString("yyyy-MM-dd"), circuit_choisi = circuit_choisi }).Single();

                    if (result.nbParticipantsCircuit_total == null)
                    {
                        nbPlacesReserv = 0;
                    }
                    else
                    {
                        nbPlacesReserv = (int)result.nbParticipantsCircuit_total;
                    }
                    //nbPlacesReserv = result.Count == null ? 0 : (int)result.Count;

                    int nbPlacesRestantes = cir_choisi.cir_nb_participants_max - nbPlacesReserv;
                    labelCircuitNbPlaces.Text = nbPlacesRestantes.ToString();
                    labelCircuitNbPlaces.Visible = true;



                    int tva_choisie = cir_choisi.TVA_tva_id;
                    Latva = connection.Query<TVA>(getTva, new { Latva = tva_choisie }).FirstOrDefault();
                    float prixTTC = Latva.tva_taux * cir_choisi.cir_prixUHT + cir_choisi.cir_prixUHT;


                    labelDateDebVal.Visible = true;
                    labelDateFinVal.Visible = true;
                    labelCircuitPrixTTC.Visible = true;

                    labelDateDebVal.Text = String.Format("{0:dd/MM/yyyy}", cir_choisi.cir_debut_val);
                    labelDateFinVal.Text = String.Format("{0:dd/MM/yyyy}", cir_choisi.cir_fin_val);
                    labelCircuitPrixTTC.Text = prixTTC + " €";


                }

                groupBoxEtape.Text = nom_circuit;

                id_circuit = cir_choisi.cir_id;

                listViewCircuits.Items.Clear();

                // sélectionne les étapes relatives au circuit touristique choisi
                using (MySqlConnection connection = new MySqlConnection(Globals.MySQLConnectionString))
                {
                    string etapes = "select * from CircuitEtape where etape_cir_id=@id";
                    string statutEtape = "select * from CircuitStatutEtape ";

                    cir_choisi_etape = connection.Query<CircuitEtape>(etapes, new { id = id_circuit }).FirstOrDefault();

                    IEnumerable<CircuitEtape> circuitEtape = connection.Query<CircuitEtape>(etapes, new { id = id_circuit });
                    IEnumerable<CircuitStatutEtape> circuitStatutEtape = connection.Query<CircuitStatutEtape>(statutEtape);


                    // pour chaque étape du circuit touristique choisi remplit la listeView avec les informations de l'étape
                    foreach (CircuitEtape etp in circuitEtape)
                    {
                        foreach (CircuitStatutEtape stat in circuitStatutEtape)
                        {
                            if (etp.CircuitStatutEtape_etape_statut_id == stat.etape_statut_id)
                            {
                                string[] arrayInter = new string[] { etp.etape_libelle, etp.etape_heure_depart.ToString(), etp.etape_duree.ToString() + " heures", etp.etape_description, stat.statut};

                                //Ajout de ces informations
                                ListViewItem itm;
                                itm = new ListViewItem(arrayInter);
                                listViewCircuits.Items.Add(itm);
                            }
                        }
                    }

                }
            }
            else
            {

                labelDateDebVal.Visible = false;
                labelDateFinVal.Visible = false;
                labelCircuitNbPlaces.Visible = false;
                labelCircuitPrixTTC.Visible = false;
            }
        }

        /// <summary>
        /// fonction qui s'active lorsque l'index (élément sélectionné) dans la listView : listViewClients change
        /// </summary>
        /// <param name="sender">objet qui soulève l'évènement</param>
        /// <param name="e">instance d'EventArgs incluant un objet qui hérite de EventArgs</param>
        private void listViewClients_SelectedIndexChanged(object sender, EventArgs e)
        {
            CircuitTouristique cir_choisi;

            // vérifie si au moins un élément est sélectionné dans la listView
            if (listViewClients.SelectedItems.Count > 0)
            {
                ListViewItem item = listViewClients.SelectedItems[0];

                // vérifie si un élément est sélectionnée, si non : change le caractère indiquant la sélection, indique les informations du 
                // client sélectionné dans le formulaire de réservation d'un circuit touristique
                if (item.SubItems[0].Text == " ")
                {
                    clientAlreadyHaveResa.Visible = false;

                    item.SubItems[0].Text = "X";

                    if (item.SubItems[5].Text == "oui")
                    {
                        int résa = Int32.Parse(item.SubItems[8].Text);
                        using (MySqlConnection connection = new MySqlConnection(Globals.MySQLConnectionString))
                        {
                            string sqlString = SQLQueries.getCircuitFromReservations;
                            cir_choisi = connection.Query<CircuitTouristique>(sqlString, new { res_id = résa }).FirstOrDefault();


                            clientAlreadyHaveResa.Text = "Ce client a déjà une réservation : " + cir_choisi.cir_libelle;
                            clientAlreadyHaveResa.Visible = true;
                        }

                      //  clientAlreadyHaveResa.Text = "Ce client a déjà une réservation";
                       // clientAlreadyHaveResa.Visible = true;

                        selectCircuitResa.Visible = false;
                        ResaCircuitJour.Visible = false;
                        resaChooseCircuit.Visible = false;
                        dateTimePickerClientsResa.Visible = false;
                        btnAddResa.Visible = false;
                        chooseNbParticipants.Visible = false;
                        numericUpDown1.Visible = false;

                        

                        clientChoisiNom.Text = item.SubItems[1].Text;
                        clientChoisiPrenom.Text = item.SubItems[2].Text;
                        clientChoisiEmail.Text = item.SubItems[7].Text;
                        clientChoisiTel.Text = item.SubItems[6].Text;
                        résaID.Text = item.SubItems[8].Text;

                        

                        //getCircuitFromReservations

                        //          dateTimePickerClientsResa.MinDate = DateTime.Parse(item.SubItems[3].Text);
                        //     dateTimePickerClientsResa.MaxDate = DateTime.Parse(item.SubItems[4].Text);


                    }
                    else
                    {
                        clientAlreadyHaveResa.Visible = false;

                        selectCircuitResa.Visible = true;
                        ResaCircuitJour.Visible = true;
                        resaChooseCircuit.Visible = true;
                        dateTimePickerClientsResa.Visible = true;
                        btnAddResa.Visible = true;
                        chooseNbParticipants.Visible = true;
                        numericUpDown1.Visible = true;



                        clientChoisiNom.Text = item.SubItems[1].Text;
                        clientChoisiPrenom.Text = item.SubItems[2].Text;
                        clientChoisiEmail.Text = item.SubItems[7].Text;
                        clientChoisiTel.Text = item.SubItems[6].Text;
                        résaID.Text = item.SubItems[8].Text;

                        dateTimePickerClientsResa.MinDate = DateTime.Parse(item.SubItems[3].Text);
                        dateTimePickerClientsResa.MaxDate = DateTime.Parse(item.SubItems[4].Text);

                    }


                }
                // sinon si reclique sur la sélection ou pas de ligne sélectionnée : laisse vide le formulaire de réservation d'un circuit
                // touristique
                else
                {
                    item.SubItems[0].Text = " ";
                    clientChoisiNom.Text = string.Empty;
                    clientChoisiPrenom.Text = string.Empty;
                    clientChoisiEmail.Text = string.Empty;
                    clientChoisiTel.Text = string.Empty;
                    résaID.Text = string.Empty;
                    clientAlreadyHaveResa.Visible = false;


                }

            }
            // si pas d'élément selectionné : laisse le formulaire de réservation de circuit touristique vide
            else
            {
                clientChoisiNom.Text = string.Empty;
                clientChoisiPrenom.Text = string.Empty;
                clientChoisiEmail.Text = string.Empty;
                clientChoisiTel.Text = string.Empty;
                résaID.Text = string.Empty;
                clientAlreadyHaveResa.Visible = false;
            }

            //     string cli_choisi_nom = clientChoisiNom.Text;
            //    string cli_chois_prenom = clientChoisiPrenom.Text;


        }

        private void cb_client_circuit_choisi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePickerClientsResa_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnAddResa_Click(object sender, EventArgs e)
        {
            if (resaChooseCircuit.SelectedIndex > -1)
            {
                int res_id = Int32.Parse(résaID.Text);
                int cir_id = ((CircuitTouristique)resaChooseCircuit.SelectedItem).cir_id;
                DateTime cir_date = dateTimePickerClientsResa.Value;

                int lesPartis = Int32.Parse(numericUpDown1.Value.ToString());
                
               // if (Extension.IsNumeric(resaCircuitNbParticipants.Text))
               // {
                    
                //    int nb_parti = Int32.Parse(resaCircuitNbParticipants.Text);

                    using (MySqlConnection connection = new MySqlConnection(Globals.MySQLConnectionString))
                    {

                        string sqlString = SQLQueries.hotelCircuitReservation;
                        connection.Query(sqlString, new { res_id = res_id, cir_id = cir_id, cir_date = cir_date, nb_parti = lesPartis });
                        MessageBox.Show("La réservation du circuit a bien été effectuée !");
                    }
                    listViewClients.Items.Clear();
                    getReservations();
               // }
              //  else
               // {
              //     MessageBox.Show("Veuillez entrer un chiffre valide pour le nombre de participants ");
               // }
                
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un circuit touristique à réserver.");
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void page_ajouter_reservation_Click(object sender, EventArgs e)
        {

        }
        private void page_circuits_touristiques_Click(object sender, EventArgs e)
        {

        }

        

        private void cbAddCirTVA_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void resaChooseCircuit_SelectedIndexChanged(object sender, EventArgs e)
        {
            numericUpDown1.Maximum = 3;
        }

        private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void dateTimePickerCircuitResa_ValueChanged(object sender, EventArgs e)
        {
            CircuitTouristique cir_choisi;
            int nbPlacesReserv;

            // vérifie si un circuit est choisit

            if (choose_cir_cb.SelectedIndex > -1)
            {
                nom_circuit = choose_cir_cb.SelectedItem.ToString();
                circuit_date_choisie = dateTimePickerCircuitResa.Value;

                // sélectionne les informations relatives au circuit touristique choisi
                using (MySqlConnection connection = new MySqlConnection(Globals.MySQLConnectionString))
                {
                    string getCircuitChoisi = "select * from CircuitTouristique where cir_libelle=@libelle";
                    string getNbPlacesResev = "select SUM(nbParticipantsCircuit)AS nbParticipantsCircuit_total from Reservation where date_circuit = @date_circuit and CircuitTouristique_cir_id = @circuit_choisi and CircuitTouristique_cir_id";

                    cir_choisi = connection.Query<CircuitTouristique>(getCircuitChoisi, new { libelle = nom_circuit }).FirstOrDefault();

                    DateTime date_circuit = circuit_date_choisie;
                    int circuit_choisi = cir_choisi.cir_id;

                    dynamic result = connection.Query(getNbPlacesResev, new { date_circuit = circuit_date_choisie.ToString("yyyy-MM-dd"), circuit_choisi = circuit_choisi }).Single();

                    if (result.nbParticipantsCircuit_total == null)
                    {
                        nbPlacesReserv = 0;
                    }
                    else
                    {
                        nbPlacesReserv = (int)result.nbParticipantsCircuit_total;
                    }
                 
                    int nbPlacesRestantes = cir_choisi.cir_nb_participants_max - nbPlacesReserv;
                    labelCircuitNbPlaces.Text = nbPlacesRestantes.ToString();
                    labelCircuitNbPlaces.Visible = true;

                    labelDateDebVal.Visible = true;
                    labelDateFinVal.Visible = true;
                    labelCircuitPrixTTC.Visible = true;
       


                }
            }

        }


        private void resaCircuitNbParticipants_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void resaCircuitNbParticipants_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btAddCir_Click(object sender, EventArgs e)
        {
            string cir_libelle = tbAddCirLibelle.Text;
            string cir_desc = tbAddCirDesc.Text;
            string cir_langues = tbAddCirLangues.Text;
            DateTime cir_deb_val = dateTimePickerDebValCir.Value;
            DateTime cir_fin_val = dateTimePickerFinValCir.Value;


            if (Extension.IsNumeric(tbAddCirNbPart.Text) && Extension.IsNumeric(tbAddCirPrix.Text))
            {
                int cir_nb_part_max = Int32.Parse(tbAddCirNbPart.Text);
                float cir_prix = Single.Parse(tbAddCirPrix.Text);

                int cir_tva = ((TVA)cbAddCirTVA.SelectedItem).tva_id;
                int cir_hotel_bat_id = bat_choisi.bat_id;

                using (MySqlConnection connection = new MySqlConnection(Globals.MySQLConnectionString))
                {

                    string sqlString = SQLQueries.addNewCircuit;
                    connection.Query(sqlString, new { cir_libelle = cir_libelle, cir_desc = cir_desc, cir_langues = cir_langues, cir_deb_val = cir_deb_val, cir_fin_val = cir_fin_val, cir_nb_part_max = cir_nb_part_max, cir_prix = cir_prix, cir_tva = cir_tva, cir_hotel_bat_id = cir_hotel_bat_id });
                    MessageBox.Show("La création du circuit a bien été effectuée !");
                }
            }
            else
            {
                MessageBox.Show("Veuillez entrer un chiffre valide");
            }


        }

        private void btAddEtape_Click(object sender, EventArgs e)
        {
            if (addetapeChooseCircuit.SelectedIndex > -1)
            {
            
                if (string.IsNullOrWhiteSpace(tbAddEtapeLibelle.Text) || string.IsNullOrWhiteSpace(tbAddEtapeDesc.Text))
                {
                    MessageBox.Show("Veuillez remplir tous les champs au format requis");
                }
                else if (Extension.IsNumeric(tbAddEtapeDuree.Text) && addEtapeStatut.SelectedIndex > -1)
                {
                    string etape_libelle = tbAddEtapeLibelle.Text;
                    string etape_desc = tbAddEtapeDesc.Text;

                    DateTime etape_heure_dep = dateTimePickerEtapeHeureDep.Value;
                    int cir_id = ((CircuitTouristique)addetapeChooseCircuit.SelectedItem).cir_id;
                    int etape_statut = ((CircuitStatutEtape)addEtapeStatut.SelectedItem).etape_statut_id;
                    int etape_duree = Int32.Parse(tbAddEtapeDuree.Text);

                    using (MySqlConnection connection = new MySqlConnection(Globals.MySQLConnectionString))
                    {

                        string sqlString = SQLQueries.addNewEtape;
                        connection.Query(sqlString, new { etp_libelle = etape_libelle, etp_desc = etape_desc, etp_heure_dep = etape_heure_dep, etp_duree = etape_duree, etp_etp_statut = etape_statut, etp_cir_id = cir_id });
                        MessageBox.Show("La création de l'étape a bien été effectuée !");
                    }
                    
                }

    

            }
        }

        private void addetapeChooseCircuit_SelectedIndexChanged(object sender, EventArgs e)
        {
            CircuitEtape cir_choisi_etape;
            CircuitTouristique cir_choisi;

            //IEnumerable<CircuitEtape> etapesNumeros;

            if (addetapeChooseCircuit.SelectedIndex > -1)
            {
                nom_circuit = addetapeChooseCircuit.SelectedItem.ToString();

                using (MySqlConnection connection = new MySqlConnection(Globals.MySQLConnectionString))
                {
                    string getCircuitChoisi = "select * from CircuitTouristique where cir_libelle=@libelle";
                    cir_choisi = connection.Query<CircuitTouristique>(getCircuitChoisi, new { libelle = nom_circuit }).FirstOrDefault();

                    int circuit_choisi = cir_choisi.cir_id;
                    id_circuit = cir_choisi.cir_id;

                    addCirEtapeListView.Items.Clear();

                    string etapes = "select * from CircuitEtape where etape_cir_id=@id";
                    string statutEtape = "select * from CircuitStatutEtape ";

                    cir_choisi_etape = connection.Query<CircuitEtape>(etapes, new { id = id_circuit }).FirstOrDefault();



                    IEnumerable<CircuitEtape> circuitEtape = connection.Query<CircuitEtape>(etapes, new { id = id_circuit });
                    IEnumerable<CircuitStatutEtape> circuitStatutEtape = connection.Query<CircuitStatutEtape>(statutEtape);

                    // pour chaque étape du circuit touristique choisi remplit la listeView avec les informations de l'étape
                    foreach (CircuitEtape etp in circuitEtape)
                    {
                        foreach (CircuitStatutEtape stat in circuitStatutEtape)
                        {

                            if (etp.CircuitStatutEtape_etape_statut_id == stat.etape_statut_id)
                            {
                                string[] arrayInter = new string[] { etp.etape_libelle, etp.etape_heure_depart.ToString(), stat.statut };

                                //Ajout de ces informations
                                ListViewItem itm;
                                itm = new ListViewItem(arrayInter);
                                addCirEtapeListView.Items.Add(itm);
                            }


                        }

                    }

                }                
            }
        }

        private void cir_names_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void AddCircuit_Click(object sender, EventArgs e)
        {

        }

        private void addEtapeLabelNumero_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void clientChoisiEmail_Click(object sender, EventArgs e)
        {

        }

        private void addResaSuppButton_Click(object sender, EventArgs e)
        {

        }

        private void modifCirChooseCircuit_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (modifCirChooseCircuit.SelectedIndex > -1)
            {

                IEnumerable<CircuitTouristique> circuits;
                IEnumerable<TVA> tvas;
                IEnumerable<CircuitStatutEtape> statutEtapesCircuit;


                // se connecte à la DB en utilisant les données précédemment mentionnées
                using (MySqlConnection connection = new MySqlConnection(Globals.MySQLConnectionString))
                {

                    string sql = "select * from CircuitTouristique";
                    circuits = connection.Query<CircuitTouristique>(sql);

                    string getTVA = "select * from TVA";
                    tvas = connection.Query<TVA>(getTVA);

                    string getEtapeStatus = "select * from CircuitStatutEtape";
                    statutEtapesCircuit = connection.Query<CircuitStatutEtape>(getEtapeStatus);


                }
                // récupère le taux des tvas et ajoute cette liste à la comboBox
                foreach (TVA tva in tvas)
                {
                    cbAddCirTVA.Items.Add(tva).ToString();
                }
                // récupère le libelle des statuts et ajoute cette liste à la comboBox
                foreach (CircuitStatutEtape statut in statutEtapesCircuit)
                {
                    addEtapeStatut.Items.Add(statut);
                }



                // récupère les libellés des circuits et ajoute cette liste à la comboBox
                foreach (CircuitTouristique cir in circuits)
                {
                    choose_cir_cb.Items.Add(cir);
                    resaChooseCircuit.Items.Add(cir);
                    addetapeChooseCircuit.Items.Add(cir);
                }

            }
        }
    }

    public static class Extension
    {
        public static bool IsNumeric(this string s)
        {
            float output;
            return float.TryParse(s, out output);
        }
    }
}

