﻿using System.Data;
using System.Data.SqlClient;
using U1___Problema_5.Modelos;

namespace U1___Problema_5.Datos.Repositorios
{
    public class FormaPagoRepository : Repository<FormaPago>
    {
        public FormaPagoRepository() : base()
        {

        }
        public override bool Eliminar(FormaPago o)
        {
            throw new NotImplementedException();
        }

        public override bool Guardar(FormaPago o)
        {
            throw new NotImplementedException();
        }

        public override FormaPago ObtenerPorId(int id)
        {
            FormaPago formaPago = new FormaPago();
            DataTable dtFormaPago = _helper.EjecutarSP("SP_RECUPERAR_FORMAS_PAGO_POR_ID", new SqlParameter("@id", id));
            if (dtFormaPago != null && dtFormaPago.Rows.Count > 0)
            {
                foreach (DataRow row in dtFormaPago.Rows)
                {
                    formaPago.Id = (int)row["id"];
                    formaPago.Nombre = (string)row["nombre"];
                }
            }
            return formaPago;
        }

        public override List<FormaPago> ObtenerTodos()
        {
            throw new NotImplementedException();
        }
    }
}