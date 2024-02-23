using System;
using System.Web.UI.WebControls;

namespace U4_BW1_LL
{
    public partial class AcquistoAbbonamento : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["tipoAbbonamento"] != null)
            {
                // estraggo l'oggetto abbonamento dalla sessione
                Abbonamento nuovoAbbonamento = (Abbonamento)Session["tipoAbbonamento"];

                string tipoAbbonamento = nuovoAbbonamento.tipoAbbonamento;
                double costo_abbonamento = nuovoAbbonamento.costoAbbonamento;
                int durata_abbonamento = nuovoAbbonamento.durataAbbonamento;

                p1.InnerHtml = $"hai scelto l'abbonamento {tipoAbbonamento}";
                p2.InnerHtml = $"il costo è di {costo_abbonamento} euro";
                p3.InnerHtml = $"la durata è di {durata_abbonamento} mesi";
            }
            else
            {

                Response.Redirect("Default.aspx");
            }
        }

        protected void confermaAcquistoAbbonamento_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (btn.Text == "Si")
            {
                //procedi con acquisto abbonamento
            }

            if (btn.Text == "No")
            {
                // cancella coppia chiave valore ["tipoAbbonamento"] dalla sessione e torna alla pagine profilo 
                Session.Remove("tipoAbbonamento");

                if (Session["tipoAbbonamento"] == null)
                {
                    Response.Redirect("ProfilePage.aspx");
                }
                else
                {
                    Response.Write("Errore nella cancellazione della sessione");
                }
            }
        }

        protected void controlloSessione(object sender, EventArgs e)
        {
            foreach (string key in Session.Keys)
            {
                object value = Session[key];
                Response.Write($"Chiave: {key}, Valore: {value}");
            }

        }
    }
}