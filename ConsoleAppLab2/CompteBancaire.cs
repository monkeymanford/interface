
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLab2
{
    public class CompteBancaire
    {
        private int noCompte;
        private string nomClient;
        private float solde;
        private int nbOpérations;

        private static float tauxInteret = 0.1f;
        private static float fraisExtra = 0.05f;

        public CompteBancaire(int noCompte, string nomClient, float solde)
        {
            this.noCompte = noCompte;
            this.nomClient = nomClient;
            this.solde = solde;
            this.nbOpérations = 0;
        }

        public int NoCompte
        {
            get { return noCompte; }
            set { noCompte = value; }
        }

        public string NomClient
        {
            get { return nomClient; }
            set { nomClient = value; }
        }

        public float Solde
        {
            get { return solde; }
            set { solde = value; }
        }

        public void Deposer(float montant)
        {
            solde += montant;
            nbOpérations++;
        }
        public void Retirer(float montant)
        {
            solde -= montant;
            nbOpérations++;
        }

        public void transférer(CompteBancaire c,float montant)
        {
            Retirer(montant);
            c.Deposer(montant);
        }

        public float intérets()
        {
            return solde * tauxInteret / 100;
        }

        public float Frais()
        {
            if (nbOpérations <= 5)
                return 0;
            return (nbOpérations - 5) * fraisExtra;
        }

        public void FinMois()
        {
            solde += intérets();
            solde -= Frais();
            nbOpérations = 0;
        }
    }
}
