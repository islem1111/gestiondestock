using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using BEL;

namespace DAL
{
    public class produit_finiDAO
    {
        public static bool Insert_produitfini(string TAG, string libellé, float prix, string image, float qte_dispo, float qte_entrée, float qte_sortie)
        {
            string requete = String.Format("insert into produit fini ( TAG,libellé, prix, image, qte_dispo,qte_entrée,qte_sortie)" +
                " values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}');", TAG, libellé, prix, image, qte_dispo, qte_entrée, qte_sortie);
            return utils.miseajour(requete);
        }

        public static bool Update_produitfini(string TAG, string libellé, float prix, string image, float qte_dispo, float qte_entrée, float qte_sortie)
        {
            string requete = String.Format("update produit fini set libellé='{0}',prix='{1}',image='{2}',qte_dispo='{3}',qte_entrée='{4}',qte_sortie='{5}'" +
                "  where TAG={6};", libellé, prix, image, qte_dispo, qte_entrée, qte_sortie,TAG);
            return utils.miseajour(requete);
        }
    }
}
