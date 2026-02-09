using Microsoft.EntityFrameworkCore;
using MvcCoreEF.Models;

namespace MvcCoreEF.Data
{
    public class HospitalContext: DbContext
    {
        //El contructor recibira las opciones para este contexto,
        //La clase que recibe es DbContextOptions<Context>
        public HospitalContext
            (DbContextOptions<HospitalContext> options): base(options)
        {}
        //DEBEMOS TENER UNA COLECCION POR CADA MODEL
        // DICHA COLECCION DEBE SER DE TIPO DbSet<T>
        public DbSet<Hospital> Hospitales { get; set; }
    }
}
