﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccess
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class QuizAppDBEntities : DbContext
    {
        public QuizAppDBEntities()
            : base("name=QuizAppDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AnswerChoices> AnswerChoices { get; set; }
        public virtual DbSet<Categories> Categories { get; set; }
        public virtual DbSet<QuestionLevels> QuestionLevels { get; set; }
        public virtual DbSet<Questions> Questions { get; set; }
        public virtual DbSet<SubCategories> SubCategories { get; set; }
    }
}
