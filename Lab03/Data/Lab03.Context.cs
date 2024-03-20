﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Lab03.Data
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class P5_Lab03Entities : DbContext
    {
        public P5_Lab03Entities()
            : base("name=P5_Lab03Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
    
        public virtual ObjectResult<spConsultarCantones_Result> spConsultarCantones()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spConsultarCantones_Result>("spConsultarCantones");
        }
    
        public virtual ObjectResult<spConsultarCantonesPorProvinciaId_Result> spConsultarCantonesPorProvinciaId(Nullable<int> idProvincia)
        {
            var idProvinciaParameter = idProvincia.HasValue ?
                new ObjectParameter("idProvincia", idProvincia) :
                new ObjectParameter("idProvincia", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spConsultarCantonesPorProvinciaId_Result>("spConsultarCantonesPorProvinciaId", idProvinciaParameter);
        }
    
        public virtual ObjectResult<spConsultarCantonPorId_Result> spConsultarCantonPorId(Nullable<int> idCanton)
        {
            var idCantonParameter = idCanton.HasValue ?
                new ObjectParameter("idCanton", idCanton) :
                new ObjectParameter("idCanton", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spConsultarCantonPorId_Result>("spConsultarCantonPorId", idCantonParameter);
        }
    
        public virtual ObjectResult<spConsultarDistritoPorId_Result> spConsultarDistritoPorId(Nullable<int> idDistrito)
        {
            var idDistritoParameter = idDistrito.HasValue ?
                new ObjectParameter("idDistrito", idDistrito) :
                new ObjectParameter("idDistrito", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spConsultarDistritoPorId_Result>("spConsultarDistritoPorId", idDistritoParameter);
        }
    
        public virtual ObjectResult<spConsultarDistritos_Result> spConsultarDistritos()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spConsultarDistritos_Result>("spConsultarDistritos");
        }
    
        public virtual ObjectResult<spConsultarProvinciaPorId_Result> spConsultarProvinciaPorId(Nullable<int> idProvincia)
        {
            var idProvinciaParameter = idProvincia.HasValue ?
                new ObjectParameter("idProvincia", idProvincia) :
                new ObjectParameter("idProvincia", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spConsultarProvinciaPorId_Result>("spConsultarProvinciaPorId", idProvinciaParameter);
        }
    
        public virtual ObjectResult<spConsultarProvincias_Result> spConsultarProvincias()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spConsultarProvincias_Result>("spConsultarProvincias");
        }
    
        public virtual int spCrearCanton(Nullable<int> idProvincia, string nombre, Nullable<System.DateTime> fechaCreacion)
        {
            var idProvinciaParameter = idProvincia.HasValue ?
                new ObjectParameter("idProvincia", idProvincia) :
                new ObjectParameter("idProvincia", typeof(int));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("nombre", nombre) :
                new ObjectParameter("nombre", typeof(string));
    
            var fechaCreacionParameter = fechaCreacion.HasValue ?
                new ObjectParameter("fechaCreacion", fechaCreacion) :
                new ObjectParameter("fechaCreacion", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spCrearCanton", idProvinciaParameter, nombreParameter, fechaCreacionParameter);
        }
    
        public virtual int spCrearDistrito(Nullable<int> idCanton, string nombre, Nullable<System.DateTime> fechaCreacion)
        {
            var idCantonParameter = idCanton.HasValue ?
                new ObjectParameter("idCanton", idCanton) :
                new ObjectParameter("idCanton", typeof(int));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("nombre", nombre) :
                new ObjectParameter("nombre", typeof(string));
    
            var fechaCreacionParameter = fechaCreacion.HasValue ?
                new ObjectParameter("fechaCreacion", fechaCreacion) :
                new ObjectParameter("fechaCreacion", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spCrearDistrito", idCantonParameter, nombreParameter, fechaCreacionParameter);
        }
    
        public virtual int spCrearProvincia(string nombre, Nullable<System.DateTime> fechaCreacion)
        {
            var nombreParameter = nombre != null ?
                new ObjectParameter("nombre", nombre) :
                new ObjectParameter("nombre", typeof(string));
    
            var fechaCreacionParameter = fechaCreacion.HasValue ?
                new ObjectParameter("fechaCreacion", fechaCreacion) :
                new ObjectParameter("fechaCreacion", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spCrearProvincia", nombreParameter, fechaCreacionParameter);
        }
    
        public virtual int spEditarCanton(Nullable<int> idCanton, Nullable<int> idProvincia, string nombre, string estado)
        {
            var idCantonParameter = idCanton.HasValue ?
                new ObjectParameter("idCanton", idCanton) :
                new ObjectParameter("idCanton", typeof(int));
    
            var idProvinciaParameter = idProvincia.HasValue ?
                new ObjectParameter("idProvincia", idProvincia) :
                new ObjectParameter("idProvincia", typeof(int));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("nombre", nombre) :
                new ObjectParameter("nombre", typeof(string));
    
            var estadoParameter = estado != null ?
                new ObjectParameter("estado", estado) :
                new ObjectParameter("estado", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spEditarCanton", idCantonParameter, idProvinciaParameter, nombreParameter, estadoParameter);
        }
    
        public virtual int spEditarDistrito(Nullable<int> idDistrito, Nullable<int> idCanton, string nombre, string estado)
        {
            var idDistritoParameter = idDistrito.HasValue ?
                new ObjectParameter("idDistrito", idDistrito) :
                new ObjectParameter("idDistrito", typeof(int));
    
            var idCantonParameter = idCanton.HasValue ?
                new ObjectParameter("idCanton", idCanton) :
                new ObjectParameter("idCanton", typeof(int));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("nombre", nombre) :
                new ObjectParameter("nombre", typeof(string));
    
            var estadoParameter = estado != null ?
                new ObjectParameter("estado", estado) :
                new ObjectParameter("estado", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spEditarDistrito", idDistritoParameter, idCantonParameter, nombreParameter, estadoParameter);
        }
    
        public virtual int spEditarProvincia(Nullable<int> idProvincia, string nombre, string estado)
        {
            var idProvinciaParameter = idProvincia.HasValue ?
                new ObjectParameter("idProvincia", idProvincia) :
                new ObjectParameter("idProvincia", typeof(int));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("nombre", nombre) :
                new ObjectParameter("nombre", typeof(string));
    
            var estadoParameter = estado != null ?
                new ObjectParameter("estado", estado) :
                new ObjectParameter("estado", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spEditarProvincia", idProvinciaParameter, nombreParameter, estadoParameter);
        }
    
        public virtual int spEliminarCanton(Nullable<int> idCanton)
        {
            var idCantonParameter = idCanton.HasValue ?
                new ObjectParameter("idCanton", idCanton) :
                new ObjectParameter("idCanton", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spEliminarCanton", idCantonParameter);
        }
    
        public virtual int spEliminarDistrito(Nullable<int> idDistrito)
        {
            var idDistritoParameter = idDistrito.HasValue ?
                new ObjectParameter("idDistrito", idDistrito) :
                new ObjectParameter("idDistrito", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spEliminarDistrito", idDistritoParameter);
        }
    
        public virtual int spEliminarProvincia(Nullable<int> idProvincia)
        {
            var idProvinciaParameter = idProvincia.HasValue ?
                new ObjectParameter("idProvincia", idProvincia) :
                new ObjectParameter("idProvincia", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spEliminarProvincia", idProvinciaParameter);
        }
    }
}
