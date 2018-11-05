using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sistema.Models;

namespace Sistema.Data
{
    public class DbInitializer
    {
        public static void Initialize(SistemaContext context)
        {
            context.Database.EnsureCreated();

            //Busca si existen registros en la tabla categoria
            if (context.Categoria.Any())
            {
                return;
            }

            //Instancia del modelo categoria
            var categorias = new Categoria[]
            {
                //La coma es para separar objetos
                new Categoria{Nombre="Programación",Descripcion="Cursos de Programación",Estado=true },
                new Categoria{Nombre="Diseño Gráfico",Descripcion="Cursos de Diseño Gráfico",Estado=true }
            };//el punto y coma es para terminar de declarar el vector de categorias

            //bucle foreach para recorrer todo el vector categorias
            //Declara objeto c que haga instancia en la clase categoria para recorrer el vector categorias
            foreach (Categoria c in categorias)
            {
                context.Categoria.Add(c);//para agregar 
            }
            context.SaveChanges();
        }   
        
    }
}
