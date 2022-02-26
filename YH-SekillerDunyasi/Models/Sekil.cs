using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YH_SekillerDunyasi.Models
{
    public abstract class Sekil
    {
        public Sekil()
        {
        }
        public Sekil(int x, int y, int genislik, int yukseklik, Color renk)
        {
            X = x;
            Y = y;
            Genislik = genislik;
            Yukseklik = yukseklik;
            Renk = renk;
        }
        public decimal Saydamlik { get; set; }
        public abstract string Tur { get; }
        public int X { get; set; }
        public int Y { get; set; }
        public int Genislik { get; set; }
        public int Yukseklik { get; set; }
        public Color Renk { get; set; } = Color.Black;
        public abstract double Alan();
        public abstract double Cevre();
        public abstract void Ciz(Graphics g);
        public override string ToString()
        {
            return $"{Tur}([{X},{Y}] {Genislik}x{Yukseklik} Renk:{Renk} Alan:{Alan():n2} Çevre:{Cevre():n2})";
        }
    }
}
