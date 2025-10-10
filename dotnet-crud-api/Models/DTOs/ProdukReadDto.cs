using Microsoft.EntityFrameworkCore;

namespace dotnet_crud_api.Models.DTOs
{
    public class ProdukReadDto
    {
        public int Id { get; set; }
        public string Nama { get; set; }
        public decimal Harga { get; set; }
        public string KategoriNama { get; set; }
    }

}
