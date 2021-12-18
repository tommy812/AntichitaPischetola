using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AntichitaPischetola.Models
{
    public class Prodotto
    {
        [DisplayName("Prodotto ID")]
        public int Id { get; set; }
        [Required]
        [DisplayName("Nome Prodotto")]
        public string NomeProdotto{ get; set; }
        [Required]
        [DisplayName("Categoria Prodotto")]
        public string CategoriaProdotto { get; set; }
        [Required]
        [DisplayName("Descrizione Prodotto")]
        public string DescrizioneProdotto { get; set; }
        [Required]
        [DisplayName("Anno Prodotto")]
        public DateTime AnnoProdotto { get; set; }
        [DisplayName("Peso Prodotto")]
        public Decimal PesoProdotto { get; set; }
        [DisplayName("AltezzaProdotto")]
        public Decimal AltezzaProdotto { get; set; }
        [DisplayName("Larghezza Spedizione")]
        public Decimal LarghezzaProdotto { get; set; }
        [Required]
        [DisplayName("Prezzo Prodotto")]
        [DataType(DataType.Currency)]
        public Decimal PrezzoProdotto { get; set; }
        [DisplayName("Prezzo Spedizione")]
        [DataType(DataType.Currency)]
        public Decimal PrezzoSpedizione { get; set; }
        public string PhotoURL { get; set; }
    }
}
