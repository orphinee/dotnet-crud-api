﻿using System.ComponentModel.DataAnnotations;

namespace dotnet_crud_api.Models.Entities
{
    public class Kategori
    {
        public int Id { get; set; }  
        public string Nama { get; set; }
        public ICollection<Produk> Produk { get; set; }
    }
}
