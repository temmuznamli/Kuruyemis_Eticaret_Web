using System.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ornekSite.Entity
{
    public class DataInitializer:DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            var kategoriler = new List<Category>()
            {
                new Category() {Name="KURU YEMİŞLER", Description="Kuruyemişler"},
                new Category() {Name="KURU MEYVELER", Description="Kurumeyveler"},
                new Category() {Name="ŞEKERLEMELER", Description="Şekerlemeler"}
            };
            foreach (var kategori in kategoriler)
            {
                context.Categories.Add(kategori);
            }
            context.SaveChanges();
            var urunler = new List<Product>()
            {
                new Product() {Name="Fıstık", Description="Fıstık",Price=30,Stock=100,IsHome=true,IsApproved=true,IsFeatured=true,Slider=true,CategoryId=1,image="1.jpg"},
                new Product() {Name="Fındık", Description="Fındık",Price=40,Stock=100,IsHome=true,IsApproved=true,IsFeatured=true,Slider=true,CategoryId=1,image="2.jpg"},
                new Product() {Name="Kaju", Description="Kaju",Price=50,Stock=125,IsHome=true,IsApproved=true,IsFeatured=false,Slider=false,CategoryId=1,image="3.jpg"},
                new Product() {Name="Badem", Description="Badem",Price=30,Stock=75,IsHome=true,IsApproved=true,IsFeatured=false,Slider=false,CategoryId=1,image="4.jpg"},
                new Product() {Name="Ceviz", Description="Ceviz",Price=40,Stock=50,IsHome=true,IsApproved=true,IsFeatured=false,Slider=false,CategoryId=1,image="5.jpg"},
                new Product() {Name="Leblebi", Description="Leblebi",Price=15,Stock=250,IsHome=false,IsApproved=true,IsFeatured=true,Slider=false,CategoryId=1,image="6.jpg"},
                new Product() {Name="KARIŞIK KURUYEMİŞLER", Description="Karışık",Price=75,Stock=500,IsHome=true,IsApproved=true,IsFeatured=true,Slider=true,CategoryId=1,image="7.jpg"},

                new Product() {Name="Hurma", Description="Hurma",Price=25,Stock=150,IsHome=true,IsApproved=true,IsFeatured=true,Slider=true,CategoryId=2,image="8.jpg"},
                new Product() {Name="Kayısı", Description="Kuru Kayısı",Price=30,Stock=75,IsHome=true,IsApproved=true,IsFeatured=false,Slider=false,CategoryId=2,image="9.jpg"},
                new Product() {Name="İncir", Description="Kuru İncir",Price=30,Stock=75,IsHome=true,IsApproved=true,IsFeatured=false,Slider=false,CategoryId=2,image="10.jpg"},
                new Product() {Name="Üzüm", Description="Kuru Üzüm",Price=20,Stock=100,IsHome=true,IsApproved=true,IsFeatured=true,Slider=false,CategoryId=2,image="11.jpg"},

                new Product() {Name="Lokum", Description="Lokum",Price=20,Stock=250,IsHome=true,IsApproved=true,IsFeatured=true,Slider=true,CategoryId=3,image="12.jpg"},
                new Product() {Name="Pestil", Description="Pestil",Price=30,Stock=75,IsHome=true,IsApproved=true,IsFeatured=false,Slider=false,CategoryId=3,image="13.jpg"},
                new Product() {Name="Cezerye", Description="Cezerye",Price=65,Stock=30,IsHome=true,IsApproved=true,IsFeatured=false,Slider=false,CategoryId=3,image="14.jpg"},

            };
            foreach (var urun in urunler)
            {
                context.Products.Add(urun);
            }
            context.SaveChanges();
            base.Seed(context);
        }
    }
}