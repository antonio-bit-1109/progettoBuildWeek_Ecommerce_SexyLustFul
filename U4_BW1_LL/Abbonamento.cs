namespace U4_BW1_LL
{
    public class Abbonamento
    {
        public string tipoAbbonamento { get; set; }
        public double costoAbbonamento { get; set; }
        public int durataAbbonamento { get; set; }

        public Abbonamento(string tipoAbbonamento, int costoAbbonamento, int durataAbbonamento)
        {
            this.tipoAbbonamento = tipoAbbonamento;
            this.costoAbbonamento = costoAbbonamento;
            this.durataAbbonamento = durataAbbonamento;
        }
    }
}