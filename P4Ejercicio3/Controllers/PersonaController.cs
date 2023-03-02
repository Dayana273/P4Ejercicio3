using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using P4Ejercicio3.Datos;

namespace P4Ejercicio3.Controllers
{
    public class PersonaController : ContentPage
    {
        readonly SQLiteAsyncConnection _Connection;
        public PersonaController(string DBPath)
        {
            _Connection = new SQLiteAsyncConnection(DBPath);
            _Connection.CreateTableAsync<Datos.Personas>();

        }
        public Task<int> SavePerson(Datos.Personas personas)
        {
            if (personas.Id != 0)
                return _Connection.UpdateAsync(personas);
            else
                return _Connection.InsertAsync(personas);
        }

        // READ one
        public Task<Datos.Personas> GetPerson(int pid)
        {
            return _Connection.Table<Datos.Personas>()
                .Where(i => i.Id == pid)
                .FirstOrDefaultAsync();
        }

        // read para la lista de empleados 
        public Task<List<Datos.Personas>> GetlistPerson()
        {
            return _Connection.Table<Datos.Personas>().ToListAsync();
        }

        public Task<int> DeleteEmple(Datos. Personas personas)
        {
            //delete
            return _Connection.DeleteAsync(personas);
        }

    }






}
