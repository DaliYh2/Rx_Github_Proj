﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace git_demo
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the git_demoRepository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    [RepositoryFolder("7436e000-de95-4e26-b220-3d0fcae51892")]
    public partial class git_demoRepository : RepoGenBaseFolder
    {
        static git_demoRepository instance = new git_demoRepository();

        /// <summary>
        /// Gets the singleton class instance representing the git_demoRepository element repository.
        /// </summary>
        [RepositoryFolder("7436e000-de95-4e26-b220-3d0fcae51892")]
        public static git_demoRepository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public git_demoRepository() 
            : base("git_demoRepository", "/", null, 0, false, "7436e000-de95-4e26-b220-3d0fcae51892", ".\\RepositoryImages\\git_demoRepository7436e000.rximgres")
        {
        }

#region Variables

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("7436e000-de95-4e26-b220-3d0fcae51892")]
        public virtual RepoItemInfo SelfInfo
        {
            get
            {
                return _selfInfo;
            }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    public partial class git_demoRepositoryFolders
    {
    }
#pragma warning restore 0436
}
