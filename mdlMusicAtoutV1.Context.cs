﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MusicAtoutV1
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class connectMusicAtout : DbContext
    {
        public connectMusicAtout()
            : base("name=connectMusicAtout")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<BATIMENT> BATIMENT { get; set; }
        public virtual DbSet<SALLE> SALLE { get; set; }
        public virtual DbSet<TYPEOEUVRE> TYPEOEUVRE { get; set; }
        public virtual DbSet<VILLE> VILLE { get; set; }
    }
}
