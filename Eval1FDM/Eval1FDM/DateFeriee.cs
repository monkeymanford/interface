using System;
namespace Eval1FDM
{
    public class DateFeriee
    {
        public Ferie jourFerie;
        private DateTime date;

        public DateFeriee(Ferie jourFerie, DateTime date)
        {
            this.jourFerie = jourFerie;
            this.date = date;
        }

        public string GetTitre()
        {
            return jourFerie.GetTitre();
        }

        public string JourSemaine()
        {
            switch (date.DayOfWeek)
            {
                case DayOfWeek.Monday: return "Lundi";
                case DayOfWeek.Tuesday: return "Mardi";
                case DayOfWeek.Wednesday: return "Mercredi";
                case DayOfWeek.Thursday: return "Jeudi";
                case DayOfWeek.Friday: return "Vendredi";
                case DayOfWeek.Saturday: return "Samedi";
                case DayOfWeek.Sunday: return "Dimanche";
                default: return "";
            }
        }

        public string DateLongue()
        {
            return date.Day + " " + Mois() +", " + date.Year;
        }

        public string Mois()
        {
            switch (date.Month)
            {
                case 1: return "Janvier";
                case 2: return "Février";
                case 3: return "Mars";
                case 4: return "Avril";
                case 5: return "Mai";
                case 6: return "Juin";
                case 7: return "Juillet";
                case 8: return "Août";
                case 9: return "Septembre";
                case 10: return "Octobre";
                case 11: return "Novembre";
                case 12: return "Décembre";
                default: return "";
            }
        }
    }
}
