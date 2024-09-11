﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U1___Problema_5.Datos.Repositorios
{
    abstract class Repository<TObject> : IRepository<TObject>
    {
        private DBHelper _helper;
        public Repository()
        {
            _helper = DBHelper.ObtenerInstancia();
        }
        public abstract bool Eliminar(int id);
        public abstract List<TObject> ObtenerTodos();
        public abstract TObject ObtenerPorId(int id);
        public abstract bool Guardar(TObject o);
    }
}
