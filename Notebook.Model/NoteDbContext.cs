// --------------------------------------------------------------------------------------------------------------------
// <copyright company="" file="NoteDbContext">
//  
// </copyright>
// <summary>
//   Date: 2017-09-05
//   The app.
// </summary>
// 
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Notebook.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class NoteDbContext : DbContext
    {
        #region Private fields

        #endregion

        #region Constructors
        public NoteDbContext() { }

        public NoteDbContext(DbContextOptions<NoteDbContext> options) : base(options)
        {
        }

        #endregion

        #region Private implementation
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {

            var envs = Environment.GetEnvironmentVariables();
            
            var host = envs["DBHOST"] ?? "localhost";
            var port = envs["DBPORT"] ?? "3306";
            var password = envs["DBPASSWORD"] ?? "mysecret";

            options.UseMySql($"server={host};userid=root;pwd={password};port={port};database=notes");
        }
        #endregion

        #region Properties
        public DbSet<Note> Notes { get; set; }
        #endregion

        #region Public interface

        #endregion
    }
}