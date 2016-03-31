-- Created by Vertabelo (http://vertabelo.com)
-- Last modification date: 2016-03-24 14:20:26.752




-- tables
-- Table: Batiment
CREATE TABLE Batiment (
    bat_id int  NOT NULL IDENTITY,
    bat_adl1 varchar(250)  NOT NULL,
    bat_adl2 varchar(250)  NULL,
    bat_adcp varchar(10)  NOT NULL,
    bat_adville varchar(250)  NOT NULL,
    bat_tel char(10)  NOT NULL,
    bat_mailcontact varchar(250)  NOT NULL,
    bat_libelle varchar(150)  NOT NULL,
    CONSTRAINT Batiment_pk PRIMARY KEY  (bat_id)
)
;





-- Table: Chambre
CREATE TABLE Chambre (
    ch_id int  NOT NULL,
    ch_prixUbase numeric(14,2)  NOT NULL,
    Etage_etage_id int  NOT NULL,
    Etage_Hotel_hotel_bat_id int  NOT NULL,
    CONSTRAINT Chambre_pk PRIMARY KEY  (ch_id,Etage_etage_id,Etage_Hotel_hotel_bat_id)
)
;





-- Table: CircuitTouristique
CREATE TABLE CircuitTouristique (
    cir_id int  NOT NULL IDENTITY,
    cir_libelle varchar(250)  NOT NULL,
    cir_description varchar(1024)  NOT NULL,
    cir_duree int  NOT NULL,
    cir_tarifTTC numeric(14,2)  NOT NULL,
    Hotel_hotel_bat_id int  NOT NULL,
    CONSTRAINT CircuitTouristique_pk PRIMARY KEY  (cir_id)
)
;





-- Table: Client
CREATE TABLE Client (
    cli_id int  NOT NULL IDENTITY,
    cli_nom varchar(250)  NOT NULL,
    cli_prenom varchar(250)  NOT NULL,
    cli_adl1 varchar(250)  NOT NULL,
    cli_adl2 varchar(250)  NULL,
    cli_adcp varchar(10)  NOT NULL,
    cli_adville varchar(250)  NOT NULL,
    cli_tel char(10)  NOT NULL,
    cli_mail varchar(250)  NOT NULL,
    CONSTRAINT Client_pk PRIMARY KEY  (cli_id)
)
;





-- Table: Date
CREATE TABLE Date (
    Date date  NOT NULL,
    CONSTRAINT Date_pk PRIMARY KEY  (Date)
)
;





-- Table: Domaine
CREATE TABLE Domaine (
    dom_id int  NOT NULL IDENTITY,
    dom_libelle varchar(250)  NOT NULL,
    CONSTRAINT Domaine_pk PRIMARY KEY  (dom_id)
)
;





-- Table: Etage
CREATE TABLE Etage (
    etage_id int  NOT NULL,
    Hotel_hotel_bat_id int  NOT NULL,
    CONSTRAINT Etage_pk PRIMARY KEY  (etage_id,Hotel_hotel_bat_id)
)
;





-- Table: Facture
CREATE TABLE Facture (
    fa_id int  NOT NULL IDENTITY,
    fa_date datetime  NOT NULL,
    CONSTRAINT Facture_pk PRIMARY KEY  (fa_id)
)
;





-- Table: Heure
CREATE TABLE Heure (
    Heure time(14)  NOT NULL,
    CONSTRAINT Heure_pk PRIMARY KEY  (Heure)
)
;





-- Table: Hotel
CREATE TABLE Hotel (
    nb_etoiles int  NOT NULL,
    hotel_bat_id int  NOT NULL,
    CONSTRAINT Hotel_pk PRIMARY KEY  (hotel_bat_id)
)
;





-- Table: Lit
CREATE TABLE Lit (
    lit_id int  NOT NULL IDENTITY,
    lit_nbPlaces int  NOT NULL,
    CONSTRAINT Lit_pk PRIMARY KEY  (lit_id)
)
;





-- Table: Personnel
CREATE TABLE Personnel (
    pers_id int  NOT NULL IDENTITY,
    pers_nom varchar(250)  NOT NULL,
    pers_prenom varchar(250)  NOT NULL,
    pers_adl1 varchar(250)  NOT NULL,
    pers_adl2 varchar(250)  NULL,
    pers_adcp varchar(10)  NOT NULL,
    pers_adville varchar(250)  NOT NULL,
    pers_tel char(10)  NOT NULL,
    pers_telp char(10)  NULL,
    pers_mail varchar(250)  NOT NULL,
    pers_homme bit  NOT NULL,
    Batiment_bat_id int  NOT NULL,
    pers_superieur int  NULL,
    CONSTRAINT Personnel_pk PRIMARY KEY  (pers_id)
)
;





-- Table: ProduitsAnnexes
CREATE TABLE ProduitsAnnexes (
    prod_id int  NOT NULL IDENTITY,
    prod_libelle varchar(250)  NOT NULL,
    prod_PUHT numeric(14,2)  NOT NULL,
    TVA_tva_id int  NOT NULL,
    CONSTRAINT ProduitsAnnexes_pk PRIMARY KEY  (prod_id)
)
;





-- Table: Reservation
CREATE TABLE Reservation (
    res_id int  NOT NULL IDENTITY,
    res_date datetime  NOT NULL,
    res_nbJours int  NOT NULL,
    Client_cli_id int  NOT NULL,
    CircuitTouristique_cir_id int  NULL,
    Chambre_ch_id int  NOT NULL,
    Chambre_Etage_etage_id int  NOT NULL,
    Chambre_Etage_Hotel_hotel_bat_id int  NOT NULL,
    Voiture_voit_id int  NULL,
    Facture_fa_id int  NULL,
    CONSTRAINT Reservation_pk PRIMARY KEY  (res_id)
)
;





-- Table: Restaurant
CREATE TABLE Restaurant (
    resto_bat_id int  NOT NULL,
    CONSTRAINT Restaurant_pk PRIMARY KEY  (resto_bat_id)
)
;





-- Table: TVA
CREATE TABLE TVA (
    tva_id int  NOT NULL IDENTITY,
    tva_taux decimal(8,2)  NOT NULL,
    CONSTRAINT TVA_pk PRIMARY KEY  (tva_id)
)
;





-- Table: "Table"
CREATE TABLE "Table" (
    tab_id int  NOT NULL,
    tab_nbPlaces int  NOT NULL,
    Restaurant_resto_bat_id int  NOT NULL,
    CONSTRAINT Table_pk PRIMARY KEY  (tab_id,Restaurant_resto_bat_id)
)
;





-- Table: Voiture
CREATE TABLE Voiture (
    voit_id int  NOT NULL IDENTITY,
    voit_marque varchar(150)  NOT NULL,
    voit_modele varchar(150)  NOT NULL,
    voit_immat varchar(10)  NOT NULL,
    voit_km numeric(14,2)  NOT NULL,
    voit_tarifUHT numeric(14,2)  NOT NULL,
    Hotel_hotel_bat_id int  NOT NULL,
    TVA_tva_id int  NOT NULL,
    CONSTRAINT Voiture_pk PRIMARY KEY  (voit_id)
)
;





-- Table: contenir
CREATE TABLE contenir (
    quantite int  NOT NULL,
    Chambre_ch_id int  NOT NULL,
    Chambre_Etage_etage_id int  NOT NULL,
    Chambre_Etage_Hotel_hotel_bat_id int  NOT NULL,
    Lit_lit_id int  NOT NULL,
    CONSTRAINT contenir_pk PRIMARY KEY  (Chambre_ch_id,Chambre_Etage_etage_id,Chambre_Etage_Hotel_hotel_bat_id,Lit_lit_id)
)
;





-- Table: habiliter
CREATE TABLE habiliter (
    date_certification date  NOT NULL,
    Personnel_pers_id int  NOT NULL,
    Domaine_dom_id int  NOT NULL,
    CONSTRAINT habiliter_pk PRIMARY KEY  (Personnel_pers_id,Domaine_dom_id)
)
;





-- Table: proposer
CREATE TABLE proposer (
    quantite int  NOT NULL,
    Chambre_ch_id int  NOT NULL,
    Chambre_Etage_etage_id int  NOT NULL,
    Chambre_Etage_Hotel_hotel_bat_id int  NOT NULL,
    ProduitsAnnexes_prod_id int  NOT NULL,
    CONSTRAINT proposer_pk PRIMARY KEY  (Chambre_ch_id,Chambre_Etage_etage_id,Chambre_Etage_Hotel_hotel_bat_id,ProduitsAnnexes_prod_id)
)
;





-- Table: reserverRestaurant
CREATE TABLE reserverRestaurant (
    Client_cli_id int  NOT NULL,
    Heure_Heure time(14)  NOT NULL,
    Date_Date date  NOT NULL,
    Table_tab_id int  NOT NULL,
    Table_Restaurant_resto_bat_id int  NOT NULL,
    CONSTRAINT reserverRestaurant_pk PRIMARY KEY  (Client_cli_id,Heure_Heure,Date_Date)
)
;









-- foreign keys
-- Reference:  Chambre_Etage (table: Chambre)

ALTER TABLE Chambre ADD CONSTRAINT Chambre_Etage 
    FOREIGN KEY (Etage_etage_id,Etage_Hotel_hotel_bat_id)
    REFERENCES Etage (etage_id,Hotel_hotel_bat_id)
;

-- Reference:  CircuitTouristique_Hotel (table: CircuitTouristique)

ALTER TABLE CircuitTouristique ADD CONSTRAINT CircuitTouristique_Hotel 
    FOREIGN KEY (Hotel_hotel_bat_id)
    REFERENCES Hotel (hotel_bat_id)
;

-- Reference:  Etage_Hotel (table: Etage)

ALTER TABLE Etage ADD CONSTRAINT Etage_Hotel 
    FOREIGN KEY (Hotel_hotel_bat_id)
    REFERENCES Hotel (hotel_bat_id)
;

-- Reference:  Hotel_Batiment (table: Hotel)

ALTER TABLE Hotel ADD CONSTRAINT Hotel_Batiment 
    FOREIGN KEY (hotel_bat_id)
    REFERENCES Batiment (bat_id)
;

-- Reference:  Personnel_Batiment (table: Personnel)

ALTER TABLE Personnel ADD CONSTRAINT Personnel_Batiment 
    FOREIGN KEY (Batiment_bat_id)
    REFERENCES Batiment (bat_id)
;

-- Reference:  Personnel_Personnel (table: Personnel)

ALTER TABLE Personnel ADD CONSTRAINT Personnel_Personnel 
    FOREIGN KEY (pers_superieur)
    REFERENCES Personnel (pers_id)
;

-- Reference:  ProduitsAnnexes_TVA (table: ProduitsAnnexes)

ALTER TABLE ProduitsAnnexes ADD CONSTRAINT ProduitsAnnexes_TVA 
    FOREIGN KEY (TVA_tva_id)
    REFERENCES TVA (tva_id)
;

-- Reference:  Reservation_Chambre (table: Reservation)

ALTER TABLE Reservation ADD CONSTRAINT Reservation_Chambre 
    FOREIGN KEY (Chambre_ch_id,Chambre_Etage_etage_id,Chambre_Etage_Hotel_hotel_bat_id)
    REFERENCES Chambre (ch_id,Etage_etage_id,Etage_Hotel_hotel_bat_id)
;

-- Reference:  Reservation_CircuitTouristique (table: Reservation)

ALTER TABLE Reservation ADD CONSTRAINT Reservation_CircuitTouristique 
    FOREIGN KEY (CircuitTouristique_cir_id)
    REFERENCES CircuitTouristique (cir_id)
;

-- Reference:  Reservation_Client (table: Reservation)

ALTER TABLE Reservation ADD CONSTRAINT Reservation_Client 
    FOREIGN KEY (Client_cli_id)
    REFERENCES Client (cli_id)
;

-- Reference:  Reservation_Facture (table: Reservation)

ALTER TABLE Reservation ADD CONSTRAINT Reservation_Facture 
    FOREIGN KEY (Facture_fa_id)
    REFERENCES Facture (fa_id)
;

-- Reference:  Reservation_Voiture (table: Reservation)

ALTER TABLE Reservation ADD CONSTRAINT Reservation_Voiture 
    FOREIGN KEY (Voiture_voit_id)
    REFERENCES Voiture (voit_id)
;

-- Reference:  Restaurant_Batiment (table: Restaurant)

ALTER TABLE Restaurant ADD CONSTRAINT Restaurant_Batiment 
    FOREIGN KEY (resto_bat_id)
    REFERENCES Batiment (bat_id)
;

-- Reference:  Table_Restaurant (table: "Table")

ALTER TABLE "Table" ADD CONSTRAINT Table_Restaurant 
    FOREIGN KEY (Restaurant_resto_bat_id)
    REFERENCES Restaurant (resto_bat_id)
;

-- Reference:  Voiture_Hotel (table: Voiture)

ALTER TABLE Voiture ADD CONSTRAINT Voiture_Hotel 
    FOREIGN KEY (Hotel_hotel_bat_id)
    REFERENCES Hotel (hotel_bat_id)
;

-- Reference:  Voiture_TVA (table: Voiture)

ALTER TABLE Voiture ADD CONSTRAINT Voiture_TVA 
    FOREIGN KEY (TVA_tva_id)
    REFERENCES TVA (tva_id)
;

-- Reference:  contenir_Chambre (table: contenir)

ALTER TABLE contenir ADD CONSTRAINT contenir_Chambre 
    FOREIGN KEY (Chambre_ch_id,Chambre_Etage_etage_id,Chambre_Etage_Hotel_hotel_bat_id)
    REFERENCES Chambre (ch_id,Etage_etage_id,Etage_Hotel_hotel_bat_id)
;

-- Reference:  contenir_Lit (table: contenir)

ALTER TABLE contenir ADD CONSTRAINT contenir_Lit 
    FOREIGN KEY (Lit_lit_id)
    REFERENCES Lit (lit_id)
;

-- Reference:  habiliter_Domaine (table: habiliter)

ALTER TABLE habiliter ADD CONSTRAINT habiliter_Domaine 
    FOREIGN KEY (Domaine_dom_id)
    REFERENCES Domaine (dom_id)
;

-- Reference:  habiliter_Personnel (table: habiliter)

ALTER TABLE habiliter ADD CONSTRAINT habiliter_Personnel 
    FOREIGN KEY (Personnel_pers_id)
    REFERENCES Personnel (pers_id)
;

-- Reference:  proposer_Chambre (table: proposer)

ALTER TABLE proposer ADD CONSTRAINT proposer_Chambre 
    FOREIGN KEY (Chambre_ch_id,Chambre_Etage_etage_id,Chambre_Etage_Hotel_hotel_bat_id)
    REFERENCES Chambre (ch_id,Etage_etage_id,Etage_Hotel_hotel_bat_id)
;

-- Reference:  proposer_ProduitsAnnexes (table: proposer)

ALTER TABLE proposer ADD CONSTRAINT proposer_ProduitsAnnexes 
    FOREIGN KEY (ProduitsAnnexes_prod_id)
    REFERENCES ProduitsAnnexes (prod_id)
;

-- Reference:  reserverRestaurant_Client (table: reserverRestaurant)

ALTER TABLE reserverRestaurant ADD CONSTRAINT reserverRestaurant_Client 
    FOREIGN KEY (Client_cli_id)
    REFERENCES Client (cli_id)
;

-- Reference:  reserverRestaurant_Date (table: reserverRestaurant)

ALTER TABLE reserverRestaurant ADD CONSTRAINT reserverRestaurant_Date 
    FOREIGN KEY (Date_Date)
    REFERENCES Date (Date)
;

-- Reference:  reserverRestaurant_Heure (table: reserverRestaurant)

ALTER TABLE reserverRestaurant ADD CONSTRAINT reserverRestaurant_Heure 
    FOREIGN KEY (Heure_Heure)
    REFERENCES Heure (Heure)
;

-- Reference:  reserverRestaurant_Table (table: reserverRestaurant)

ALTER TABLE reserverRestaurant ADD CONSTRAINT reserverRestaurant_Table 
    FOREIGN KEY (Table_tab_id,Table_Restaurant_resto_bat_id)
    REFERENCES "Table" (tab_id,Restaurant_resto_bat_id)
;





-- End of file.

