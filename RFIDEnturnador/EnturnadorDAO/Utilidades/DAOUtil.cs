using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Reflection;
using System.Data.Objects.DataClasses;
using System.Data.Objects;


namespace EnturnadorDAO.Utilidades
{
    /// <summary>
    /// Clase con métodos utilitarios
    /// </summary>
    public class DAOUtil
    {

        /// <summary>
        /// Crea propiedades de una colección recibida
        /// </summary>
        /// <typeparam name="T">Tipo de la colección</typeparam>
        /// <param name="varlist">Colección recibida</param>
        /// <returns>Tabla con las propiedades de la colección</returns>
        internal static DataTable ToDataTable<T>(this IEnumerable<T> varlist)
        {
            DataTable dtReturn = new DataTable();
            // column names
            PropertyInfo[] oProps = null;
            if (varlist == null) return dtReturn;
            foreach (T rec in varlist)
            {
                // Use reflection to get property names, to create table, Only first time, others will follow
                if (oProps == null)
                {
                    oProps = ((Type)rec.GetType()).GetProperties();
                    foreach (PropertyInfo pi in oProps)
                    {
                        Type colType = pi.PropertyType;
                        if (colType.IsGenericType && colType.GetGenericTypeDefinition() == typeof(Nullable<>))
                        {
                            colType = colType.GetGenericArguments()[0];
                        }
                        dtReturn.Columns.Add(new DataColumn(pi.Name, colType));
                    }
                }
                DataRow dr = dtReturn.NewRow();
                foreach (PropertyInfo pi in oProps)
                {
                    dr[pi.Name] = pi.GetValue(rec, null) == null ? DBNull.Value :
                    pi.GetValue(rec, null);
                }
                dtReturn.Rows.Add(dr);
            }
            return dtReturn;
        }

        /// <summary>
        /// Agrega al contexto la entidad que le llega y le aplica las modificaciones que tiene con respecto al objeto que esta en el repositorio
        /// </summary>
        /// <param name="context">Contexto agregado a la entidad</param>
        /// <param name="objectDetached">Entidad a la que se le agrega el contexto</param>
        public static void AttachUpdated(this ObjectContext context, EntityObject objectDetached)
        {
            if (context == null)
                throw new Exception("context no puede ser null");
            if (objectDetached == null)
                throw new Exception("objectDetached no puede ser null");

            if ((objectDetached.EntityState == EntityState.Detached) || (objectDetached.EntityState == EntityState.Modified))
            {
                object currentEntityInDb = null;

                if (context.TryGetObjectByKey(objectDetached.EntityKey, out currentEntityInDb))
                {
                    context.ApplyCurrentValues(objectDetached.EntityKey.EntitySetName, objectDetached);
                    //(CDLTLL)Apply property changes to all referenced entities in context
                    //context.ApplyReferencePropertyChanges((IEntityWithRelationships)objectDetached, (IEntityWithRelationships)currentEntityInDb); //Custom extensor method
                }
                else
                {
                    throw new ObjectNotFoundException();
                }
            }
        }


    }
}
