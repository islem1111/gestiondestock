using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using BEL;

namespace DAL
{
   public class Matière_PremièreDAO
    {
        public static bool Insert_MatièrePremière(string TAG, string libellé, float prix, string image, string fournisseur)
        {
            string requete = String.Format("insert into Matière_Première (TAG,libellé,prix,image,fournisseur )" +
                " values ('{0}','{1}','{2}','{3}','{4}');", TAG, libellé, prix, image, fournisseur);
            return utils.miseajour(requete);
        }

        public static bool Update_Matière_Première(string TAG, string libellé, float prix, string image, string fournisseur)
        {
            string requete = String.Format("update Matière_Première set libellé='{0}',prix='{1}',image='{2}',fournisseur={3}" +
                "  where TAG={4};", libellé, prix, image, fournisseur,TAG);
            return utils.miseajour(requete);
        }
    }
}
