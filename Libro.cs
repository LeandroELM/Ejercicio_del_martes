using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica
{
    public  class Libro
    {
        string ISBN;
        string titulo ;
        string autor ;
        int NPag;

        public Libro()
        {
        }

        public Libro(string iSBN, string titulo, string autor, int nPag)
        {
            ISBN = iSBN;
            this.titulo = titulo;
            this.autor = autor;
            NPag = nPag;
        }

        public string ISBN1 
        {
            get => ISBN;
            set => ISBN = value; 
        }
        public string Titulo 
        { 
            get => titulo; 
            set => titulo = value;
        }
        public string Autor
        {
            get => autor;
            set => autor = value; 
        }
        public int NPag1 
        {
            get => NPag;
            set => NPag = value;
        }


        private void Mostrar() 
        {
            Libro obj=new Libro();

            obj.ISBN1 = ISBN;
            obj.NPag1= NPag1;
            obj.Autor= Autor;
            obj.Titulo= Titulo;
        }

    }
}
