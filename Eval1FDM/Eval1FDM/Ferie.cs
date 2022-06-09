using System;
namespace Eval1FDM
{
    public class Ferie
    {
        private string titre;
        private string regleCalcul;
        private int Code;

        public Ferie(string titre, string regleCalcul)
        {
            this.titre = titre;
            this.regleCalcul = regleCalcul;
        }

        public Ferie(int Code, string titre, string regleCalcul)
        {
            this.Code = Code;
            this.titre = titre;
            this.regleCalcul = regleCalcul;
        }

        public override string ToString()
        {
            return titre + ": " + regleCalcul;
        }

        public string GetTitre() => titre;
        public int GetCode() => Code;

    }
}
