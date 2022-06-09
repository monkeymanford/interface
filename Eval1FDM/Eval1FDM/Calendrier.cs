using System;
using System.Collections.Generic;

namespace Eval1FDM
{
    public class Calendrier
    {
        private int annee;
        private List<DateFeriee> listeDatesFeriees = new List<DateFeriee>();

        public Calendrier(int annee)
        {
            this.annee = annee;
        }

        public void AjoutDateFeriee(DateFeriee dateFeriee)
        {
            listeDatesFeriees.Add(dateFeriee);
        }

        public List<DateFeriee> GetListDatesFeriees()
        {
            return listeDatesFeriees;
        }
    }
}
