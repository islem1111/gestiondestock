﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using BEL;

namespace DAL
{
    public class Pièce_de_rechangeDAO
    {
        public static bool Insert_Pièce_de_rechange (string TAG, string libellé, float prix, string image, string fournisseur,DateTime Date_réception)
        {
            string requete = String.Format("insert into Pièce_de_rechange (TAG,libellé,prix,image,fournisseur,Date_réception )" +
                " values ('{0}','{1}','{2}','{3}','{4}','{5}');", TAG, libellé, prix, image, fournisseur, Date_réception);
            return utils.miseajour(requete);
        }

        public static bool Update_Pièce_de_rechange(string TAG, string libellé, float prix, string image, string fournisseur, DateTime Date_réception)
        {
            string requete = String.Format("update Pièce_de_rechange set libellé='{0}',prix='{1}',image='{2}',fournisseur={3},Date_réception={4}" +
                "  where TAG={5};", libellé, prix, image, fournisseur, Date_réception,TAG);
            return utils.miseajour(requete);
        }
    }
}
