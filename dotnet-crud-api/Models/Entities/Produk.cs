using System.ComponentModel.DataAnnotations;

namespace dotnet_crud_api.Models.Entities
{
    public class Produk
    {
        public int Id { get; set; }  
        [Required]  
        public string Nama { get; set; }
        public decimal Harga { get; set; }  
        public int Kategorild { get; set; }  
        public Kategori Kategori { get; set; }
        public DateTime TanggalDibuat { get; set; } 
    }
}
