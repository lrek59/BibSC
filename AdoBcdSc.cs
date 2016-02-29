using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data.Entity.Core.Objects;

namespace WindowsFormsBiblio
{
    public class AdoBcdSc
    {
        private static bcdStChristopheEntities1 bddSc = new bcdStChristopheEntities1();
        private static Exemplaire ex;
        private static DateTime dateN = DateTime.Now;
        private static Resum res;
        public static bcdStChristopheEntities1 BddSc
        {
            get
            {
                return bddSc;
            }

            set
            {
                bddSc = value;
            }
        }
        private static Personne pers;
        private static Int64 idPers; // ID personne
        public static List<EMPRUNTS> listE = new List<EMPRUNTS>(); // Liste des emprunts en cours 
        public static Int64 idEx; // ID exemplaire
        static int cpErr=0; // Compteur des erreurs de restitution


        // Methodes //

        // SCAN DU LIVRE //

        public static void ScanLivre(Int64 idExempl)
        {
            idEx = idExempl;
            ex = new Exemplaire();
            ex = BddSc.Exemplaire.Find(idExempl); // Recherche de l'exemplaire dans la table EXEMPLAIRE

            //ex.DateEmprunt = null; // Init de la date

            if (ex != null) // L'exemplaire est connu
            {
                ex.DateEmprunt = null; // Init de la date

                if (ex.IdPersonne != null) // RETOUR
                {
                    idPers = Convert.ToInt64(ex.IdPersonne); // Recuperation de l'ID personne
                    ex.IdPersonne = null; // Lance le Trigger en entrant Null dans IdPersonne
                    BddSc.SaveChanges();

                    // utilisation de la vue RESUM //
                    res = new Resum();
                    res = BddSc.Resum.Find(idExempl);

                    pers = new Personne();
                    pers = BddSc.Personne.Find(idPers);

                    // Mise à jour des infos sur la fenêtre de résumé //
                    FormBibSC.formRes.MajRetour(pers.Nom, pers.Prenom, pers.NomClasse, res.Titre, res.Nomauteur);
                    //------------------------------------------------//

                }

                else
                {
                    if (Application.OpenForms["formRestit"] != null) // !! Pas d'emprunt enregistré pour cet exemplaire !! 
                    {
                        cpErr++;
                        MessageBox.Show("Cet exemplaire n'a pas été enregistré dans les emprunts, si il s'agit appuyez sur Emprunter", "Erreur !", MessageBoxButtons.OK);
                        Application.OpenForms["formRestit"].Dispose();
                    }

                    if (cpErr!=0)
                    {
                        // On fait quoi ?????
                    }

                    // C EST UN EMPRUNT // 

                    // utilisation de la vue RESUM //
                    res = new Resum();
                    res = BddSc.Resum.Find(idExempl);
                    //-----------------------------//

                    // Mise à jour des infos sur la fenêtre de résumé //
                    FormBibSC.formRes.MajResumL(res.Titre, res.Nomauteur);
                    //------------------------------------------------//
                }

                FormBibSC.scanL = true; // Scan du livre terminé
            }
            else
            {
                // L'exemplaire n'existe pas 
                FormBibSC.scanL = false;
            }

        }

        // SCAN DE L ELEVE //

        public static void ScanEleve(Int32 idPers)
        {
            pers = new Personne();
            pers = BddSc.Personne.Find(idPers); // Recherche de l'élève dans la table PERSONNE

            if (pers != null) // La personne existe
            {
                FormBibSC.scanP = true; // Scan du l'élève Ok

                // Mise à jour des infos sur la fenêtre de résumé //
                FormBibSC.formRes.MajResumP(pers.Nom, pers.Prenom, pers.NomClasse);
                //------------------------------------------------//
            }
            else
            {
                // La personne n'existe pas !
            }

        }

        //ENREGISTREMENT DE L'EMPRUNT //

        public static void EnrEmprunt(int idPers, Int64 idExempl, DateTime datEmp)
        {
            ex.IdPersonne = idPers;
            ex.DateEmprunt = datEmp;
            BddSc.SaveChanges(); // Enregistrement des modifications dans la base      

        }

        // LISTE EMPRUNTS EN COURS // 

        public static List<EMPRUNTS> ListEmp(string select)
        {
            //List<EMPRUNTS> listE = new List<EMPRUNTS>();
            listE = BddSc.EMPRUNTS.SqlQuery("SELECT * from EMPRUNTS where NOMCLASSE = '" + select + "'").ToList();
            return listE;
        }


        // Fermeture de la connexion //

        public static void Dispose()
        {
            BddSc.Dispose();
        }
    }
}
