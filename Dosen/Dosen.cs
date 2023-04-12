using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dosen
{
    internal class Dosen
    {
        public int id { get; set; }
        public string nama { get; set; }
        public int nik { get; set; }
        public string gender { get; set; }
        public string course { get; set; }
        public Dosen()
        {
            this.id = 1;
            this.nama = "Irfan";
            this.nik = 5666;
            this.gender = "Netral";
            this.course = "Ilmu Hitam";
        }
        public void attDosen(string nama, int nik)
        {
            this.nama = nama;
            this.nik = nik;
        }

        public void addCourse(string course)
        {
            this.course += this.course + "," + course;
        }
        public void display()
        {
            Console.WriteLine("ID : " + id);
            Console.WriteLine("Nama : " + nama);
            Console.WriteLine("NIK : " + nik);
            Console.WriteLine("Jensis Kelamin : " + gender);
            Console.WriteLine("Mata Kuliah : " + course);
        }
    }
}
