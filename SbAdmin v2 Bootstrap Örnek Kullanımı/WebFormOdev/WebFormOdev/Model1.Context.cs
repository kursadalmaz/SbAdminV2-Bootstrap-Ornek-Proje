//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebFormOdev
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class sirketEntities : DbContext
    {
        public sirketEntities()
            : base("name=sirketEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<birim> birims { get; set; }
        public virtual DbSet<cocuk> cocuks { get; set; }
        public virtual DbSet<gorevlendirme> gorevlendirmes { get; set; }
        public virtual DbSet<il> ils { get; set; }
        public virtual DbSet<ilce> ilces { get; set; }
        public virtual DbSet<Kategoriler> Kategorilers { get; set; }
        public virtual DbSet<personel> personels { get; set; }
        public virtual DbSet<proje> projes { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Tedarikciler> Tedarikcilers { get; set; }
        public virtual DbSet<unvan> unvans { get; set; }
        public virtual DbSet<Urunler> Urunlers { get; set; }
    
        public virtual int sp_alterdiagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_creatediagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_dropdiagram(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_renamediagram(string diagramname, Nullable<int> owner_id, string new_diagramname)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var new_diagramnameParameter = new_diagramname != null ?
                new ObjectParameter("new_diagramname", new_diagramname) :
                new ObjectParameter("new_diagramname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter);
        }
    
        public virtual int sp_upgraddiagrams()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_upgraddiagrams");
        }
    
        public virtual ObjectResult<spgeturun_Result> spgeturun()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spgeturun_Result>("spgeturun");
        }
    
        public virtual int spguncelle(Nullable<int> vurunid, string vurunadi, Nullable<int> vtedid, Nullable<int> vkatid)
        {
            var vurunidParameter = vurunid.HasValue ?
                new ObjectParameter("vurunid", vurunid) :
                new ObjectParameter("vurunid", typeof(int));
    
            var vurunadiParameter = vurunadi != null ?
                new ObjectParameter("vurunadi", vurunadi) :
                new ObjectParameter("vurunadi", typeof(string));
    
            var vtedidParameter = vtedid.HasValue ?
                new ObjectParameter("vtedid", vtedid) :
                new ObjectParameter("vtedid", typeof(int));
    
            var vkatidParameter = vkatid.HasValue ?
                new ObjectParameter("vkatid", vkatid) :
                new ObjectParameter("vkatid", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spguncelle", vurunidParameter, vurunadiParameter, vtedidParameter, vkatidParameter);
        }
    
        public virtual ObjectResult<spurunara_Result> spurunara(string urunadi)
        {
            var urunadiParameter = urunadi != null ?
                new ObjectParameter("urunadi", urunadi) :
                new ObjectParameter("urunadi", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spurunara_Result>("spurunara", urunadiParameter);
        }
    
        public virtual int spurunekle(string vurunad, Nullable<int> vtedid, Nullable<int> vkatid)
        {
            var vurunadParameter = vurunad != null ?
                new ObjectParameter("vurunad", vurunad) :
                new ObjectParameter("vurunad", typeof(string));
    
            var vtedidParameter = vtedid.HasValue ?
                new ObjectParameter("vtedid", vtedid) :
                new ObjectParameter("vtedid", typeof(int));
    
            var vkatidParameter = vkatid.HasValue ?
                new ObjectParameter("vkatid", vkatid) :
                new ObjectParameter("vkatid", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spurunekle", vurunadParameter, vtedidParameter, vkatidParameter);
        }
    
        public virtual int spurunsilme(Nullable<int> vurunid)
        {
            var vurunidParameter = vurunid.HasValue ?
                new ObjectParameter("vurunid", vurunid) :
                new ObjectParameter("vurunid", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spurunsilme", vurunidParameter);
        }
    }
}
