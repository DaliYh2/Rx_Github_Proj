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

namespace MyTest3
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the MyTest3Repository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    [RepositoryFolder("180fd5b3-e23e-4e60-ae6b-5df3d8e3efb2")]
    public partial class MyTest3Repository : RepoGenBaseFolder
    {
        static MyTest3Repository instance = new MyTest3Repository();
        MyTest3RepositoryFolders.ApplicationUnderTestAppFolder _applicationundertest;

        /// <summary>
        /// Gets the singleton class instance representing the MyTest3Repository element repository.
        /// </summary>
        [RepositoryFolder("180fd5b3-e23e-4e60-ae6b-5df3d8e3efb2")]
        public static MyTest3Repository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public MyTest3Repository() 
            : base("MyTest3Repository", "/", null, 0, false, "180fd5b3-e23e-4e60-ae6b-5df3d8e3efb2", ".\\RepositoryImages\\MyTest3Repository180fd5b3.rximgres")
        {
            _applicationundertest = new MyTest3RepositoryFolders.ApplicationUnderTestAppFolder(this);
        }

#region Variables

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("180fd5b3-e23e-4e60-ae6b-5df3d8e3efb2")]
        public virtual RepoItemInfo SelfInfo
        {
            get
            {
                return _selfInfo;
            }
        }

        /// <summary>
        /// The ApplicationUnderTest folder.
        /// </summary>
        [RepositoryFolder("187d2f98-7076-4c92-b90f-897167047a87")]
        public virtual MyTest3RepositoryFolders.ApplicationUnderTestAppFolder ApplicationUnderTest
        {
            get { return _applicationundertest; }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    public partial class MyTest3RepositoryFolders
    {
        /// <summary>
        /// The ApplicationUnderTestAppFolder folder.
        /// </summary>
        [RepositoryFolder("187d2f98-7076-4c92-b90f-897167047a87")]
        public partial class ApplicationUnderTestAppFolder : RepoGenBaseFolder
        {

            /// <summary>
            /// Creates a new ApplicationUnderTest  folder.
            /// </summary>
            public ApplicationUnderTestAppFolder(RepoGenBaseFolder parentFolder) :
                    base("ApplicationUnderTest", "/dom[@domain='www.ranorex.com']", parentFolder, 30000, null, false, "187d2f98-7076-4c92-b90f-897167047a87", "")
            {
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("187d2f98-7076-4c92-b90f-897167047a87")]
            public virtual Ranorex.WebDocument Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.WebDocument>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("187d2f98-7076-4c92-b90f-897167047a87")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }
        }

    }
#pragma warning restore 0436
}
