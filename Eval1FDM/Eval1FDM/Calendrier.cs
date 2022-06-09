using System;
using System.Collections.Generic;

namespace Eval1FDM
{
    public class Calendrier
    {
        private int annee;
        private List<DateFeriee> listeDatesFeriees;

        public Calendrier(int annee)
        {
            this.annee = annee;
        }

        public AjoutDateFeriee(DateFeriee dateFeriee)
        {
            listeDatesFeriees.Add(dateFeriee);
        }
    }
}
