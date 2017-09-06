// --------------------------------------------------------------------------------------------------------------------
// <copyright company="" file="Note">
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

namespace Notebook.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class Note
    {
        #region Private fields

        #endregion

        #region Constructors

        public Note()
        {
        }

        #endregion

        #region Private implementation

        #endregion

        #region Properties
        public int NoteId { get; set; }
        public DateTime Created { get; set; }
        public String NoteText { get; set; }
        #endregion


        #region Public interface

        #endregion
    }
}   