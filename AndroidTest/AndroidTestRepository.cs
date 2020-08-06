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

namespace AndroidTest
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the AndroidTestRepository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    [RepositoryFolder("842f6ac9-a86f-4939-9a8f-2e8db93d9162")]
    public partial class AndroidTestRepository : RepoGenBaseFolder
    {
        static AndroidTestRepository instance = new AndroidTestRepository();
        AndroidTestRepositoryFolders.ComVodafoneViewerAppFolder _comvodafoneviewer;

        /// <summary>
        /// Gets the singleton class instance representing the AndroidTestRepository element repository.
        /// </summary>
        [RepositoryFolder("842f6ac9-a86f-4939-9a8f-2e8db93d9162")]
        public static AndroidTestRepository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public AndroidTestRepository() 
            : base("AndroidTestRepository", "/", null, 0, false, "842f6ac9-a86f-4939-9a8f-2e8db93d9162", ".\\RepositoryImages\\AndroidTestRepository842f6ac9.rximgres")
        {
            _comvodafoneviewer = new AndroidTestRepositoryFolders.ComVodafoneViewerAppFolder(this);
        }

#region Variables

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("842f6ac9-a86f-4939-9a8f-2e8db93d9162")]
        public virtual RepoItemInfo SelfInfo
        {
            get
            {
                return _selfInfo;
            }
        }

        /// <summary>
        /// The ComVodafoneViewer folder.
        /// </summary>
        [RepositoryFolder("40db7e37-5839-4436-9b34-2863656fb47c")]
        public virtual AndroidTestRepositoryFolders.ComVodafoneViewerAppFolder ComVodafoneViewer
        {
            get { return _comvodafoneviewer; }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    public partial class AndroidTestRepositoryFolders
    {
        /// <summary>
        /// The ComVodafoneViewerAppFolder folder.
        /// </summary>
        [RepositoryFolder("40db7e37-5839-4436-9b34-2863656fb47c")]
        public partial class ComVodafoneViewerAppFolder : RepoGenBaseFolder
        {
            AndroidTestRepositoryFolders.ContentFolder _content;
            AndroidTestRepositoryFolders.LoginActivityFolder _loginactivity;
            RepoItemInfo _buttonok_clickInfo;
            RepoItemInfo _homeInfo;
            RepoItemInfo _viewoptions_clickInfo;
            RepoItemInfo _logout_homepageInfo;
            RepoItemInfo _passworcInfo;
            RepoItemInfo _connect_button1Info;

            /// <summary>
            /// Creates a new ComVodafoneViewer  folder.
            /// </summary>
            public ComVodafoneViewerAppFolder(RepoGenBaseFolder parentFolder) :
                    base("ComVodafoneViewer", "/mobileapp[@title='com.vodafone.viewer']", parentFolder, 30000, null, false, "40db7e37-5839-4436-9b34-2863656fb47c", "")
            {
                _content = new AndroidTestRepositoryFolders.ContentFolder(this);
                _loginactivity = new AndroidTestRepositoryFolders.LoginActivityFolder(this);
                _buttonok_clickInfo = new RepoItemInfo(this, "ButtonOK_Click", "form[@title='(none)']/container[@rid='content']//button[@resourceid='R.string.yes']", 30000, null, "a750f3fb-ca75-477f-9262-f52d4f142711");
                _homeInfo = new RepoItemInfo(this, "Home", "form[@title='HomeScreenActivity']/androidelement[@rid='content']/androidelement/androidelement[1]/androidelement[1]/androidelement[2]/container[1]/container[@containertype='Linear']/text", 30000, null, "c4370b5a-0254-475d-9312-aa8da3ff834c");
                _viewoptions_clickInfo = new RepoItemInfo(this, "ViewOptions_Click", "form[@title='HomeScreenActivity']/androidelement[@rid='content']/androidelement/androidelement[1]/androidelement[1]/androidelement[1]/container[@containertype='Relative']/picture", 30000, null, "6dd36ce4-575b-4bb2-9765-bfa691e52e22");
                _logout_homepageInfo = new RepoItemInfo(this, "Logout_Homepage", "form[@title='(none)']/androidelement/androidelement/androidelement[5]/container[@rid='content']/container[@containertype='Relative']/text[@rid='title']", 30000, null, "024f333e-cedc-46f3-8e94-03952f424d71");
                _passworcInfo = new RepoItemInfo(this, "Passworc", "form[@title='Enter the password']/container[@rid='content']/androidelement/container[3]/container[@rid='custom']/androidelement/androidelement[2]/container[@containertype='Frame']/text", 30000, null, "a55bc788-449f-48e9-90e7-4c673ef1d8a4");
                _connect_button1Info = new RepoItemInfo(this, "Connect_Button1", "form[@title='Enter the password']/container[@rid='content']//button[@rid='button1']", 30000, null, "a4ea7417-fef9-461f-8e54-55a09dac9495");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("40db7e37-5839-4436-9b34-2863656fb47c")]
            public virtual Ranorex.MobileApp Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.MobileApp>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("40db7e37-5839-4436-9b34-2863656fb47c")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The ButtonOK_Click item.
            /// </summary>
            [RepositoryItem("a750f3fb-ca75-477f-9262-f52d4f142711")]
            public virtual Ranorex.Button ButtonOK_Click
            {
                get
                {
                    return _buttonok_clickInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The ButtonOK_Click item info.
            /// </summary>
            [RepositoryItemInfo("a750f3fb-ca75-477f-9262-f52d4f142711")]
            public virtual RepoItemInfo ButtonOK_ClickInfo
            {
                get
                {
                    return _buttonok_clickInfo;
                }
            }

            /// <summary>
            /// The Home item.
            /// </summary>
            [RepositoryItem("c4370b5a-0254-475d-9312-aa8da3ff834c")]
            public virtual Ranorex.Text Home
            {
                get
                {
                    return _homeInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The Home item info.
            /// </summary>
            [RepositoryItemInfo("c4370b5a-0254-475d-9312-aa8da3ff834c")]
            public virtual RepoItemInfo HomeInfo
            {
                get
                {
                    return _homeInfo;
                }
            }

            /// <summary>
            /// The ViewOptions_Click item.
            /// </summary>
            [RepositoryItem("6dd36ce4-575b-4bb2-9765-bfa691e52e22")]
            public virtual Ranorex.Picture ViewOptions_Click
            {
                get
                {
                    return _viewoptions_clickInfo.CreateAdapter<Ranorex.Picture>(true);
                }
            }

            /// <summary>
            /// The ViewOptions_Click item info.
            /// </summary>
            [RepositoryItemInfo("6dd36ce4-575b-4bb2-9765-bfa691e52e22")]
            public virtual RepoItemInfo ViewOptions_ClickInfo
            {
                get
                {
                    return _viewoptions_clickInfo;
                }
            }

            /// <summary>
            /// The Logout_Homepage item.
            /// </summary>
            [RepositoryItem("024f333e-cedc-46f3-8e94-03952f424d71")]
            public virtual Ranorex.Text Logout_Homepage
            {
                get
                {
                    return _logout_homepageInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The Logout_Homepage item info.
            /// </summary>
            [RepositoryItemInfo("024f333e-cedc-46f3-8e94-03952f424d71")]
            public virtual RepoItemInfo Logout_HomepageInfo
            {
                get
                {
                    return _logout_homepageInfo;
                }
            }

            /// <summary>
            /// The Passworc item.
            /// </summary>
            [RepositoryItem("a55bc788-449f-48e9-90e7-4c673ef1d8a4")]
            public virtual Ranorex.Text Passworc
            {
                get
                {
                    return _passworcInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The Passworc item info.
            /// </summary>
            [RepositoryItemInfo("a55bc788-449f-48e9-90e7-4c673ef1d8a4")]
            public virtual RepoItemInfo PassworcInfo
            {
                get
                {
                    return _passworcInfo;
                }
            }

            /// <summary>
            /// The Connect_Button1 item.
            /// </summary>
            [RepositoryItem("a4ea7417-fef9-461f-8e54-55a09dac9495")]
            public virtual Ranorex.Button Connect_Button1
            {
                get
                {
                    return _connect_button1Info.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The Connect_Button1 item info.
            /// </summary>
            [RepositoryItemInfo("a4ea7417-fef9-461f-8e54-55a09dac9495")]
            public virtual RepoItemInfo Connect_Button1Info
            {
                get
                {
                    return _connect_button1Info;
                }
            }

            /// <summary>
            /// The Content folder.
            /// </summary>
            [RepositoryFolder("91dfa71d-15c5-4d20-92e0-885aad056474")]
            public virtual AndroidTestRepositoryFolders.ContentFolder Content
            {
                get { return _content; }
            }

            /// <summary>
            /// The LoginActivity folder.
            /// </summary>
            [RepositoryFolder("23bd5afe-2c3a-4575-8736-41c59a90bcec")]
            public virtual AndroidTestRepositoryFolders.LoginActivityFolder LoginActivity
            {
                get { return _loginactivity; }
            }
        }

        /// <summary>
        /// The ContentFolder folder.
        /// </summary>
        [RepositoryFolder("91dfa71d-15c5-4d20-92e0-885aad056474")]
        public partial class ContentFolder : RepoGenBaseFolder
        {
            RepoItemInfo _next_clickInfo;
            RepoItemInfo _enterusernameInfo;
            RepoItemInfo _enterpasswordInfo;

            /// <summary>
            /// Creates a new Content  folder.
            /// </summary>
            public ContentFolder(RepoGenBaseFolder parentFolder) :
                    base("Content", "form[@title>'Enter the username and password']/container[@rid='content']", parentFolder, 30000, null, false, "91dfa71d-15c5-4d20-92e0-885aad056474", "")
            {
                _next_clickInfo = new RepoItemInfo(this, "Next_Click", ".//button[@rid='button1']", 30000, null, "df4b588e-345a-4e91-8502-8528bf85aabd");
                _enterusernameInfo = new RepoItemInfo(this, "EnterUsername", "androidelement/container[3]/container[@rid='custom']//text", 30000, null, "7ae6f278-059e-44d5-845c-755c715f502c");
                _enterpasswordInfo = new RepoItemInfo(this, "EnterPassword", "androidelement/container[3]/container[@rid='custom']/androidelement/androidelement[2]/container[@containertype='Frame']/text", 30000, null, "96260d2d-3041-4400-bc4a-d23a370d6b3f");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("91dfa71d-15c5-4d20-92e0-885aad056474")]
            public virtual Ranorex.Container Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Container>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("91dfa71d-15c5-4d20-92e0-885aad056474")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The Next_Click item.
            /// </summary>
            [RepositoryItem("df4b588e-345a-4e91-8502-8528bf85aabd")]
            public virtual Ranorex.Button Next_Click
            {
                get
                {
                    return _next_clickInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The Next_Click item info.
            /// </summary>
            [RepositoryItemInfo("df4b588e-345a-4e91-8502-8528bf85aabd")]
            public virtual RepoItemInfo Next_ClickInfo
            {
                get
                {
                    return _next_clickInfo;
                }
            }

            /// <summary>
            /// The EnterUsername item.
            /// </summary>
            [RepositoryItem("7ae6f278-059e-44d5-845c-755c715f502c")]
            public virtual Ranorex.Text EnterUsername
            {
                get
                {
                    return _enterusernameInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The EnterUsername item info.
            /// </summary>
            [RepositoryItemInfo("7ae6f278-059e-44d5-845c-755c715f502c")]
            public virtual RepoItemInfo EnterUsernameInfo
            {
                get
                {
                    return _enterusernameInfo;
                }
            }

            /// <summary>
            /// The EnterPassword item.
            /// </summary>
            [RepositoryItem("96260d2d-3041-4400-bc4a-d23a370d6b3f")]
            public virtual Ranorex.Text EnterPassword
            {
                get
                {
                    return _enterpasswordInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The EnterPassword item info.
            /// </summary>
            [RepositoryItemInfo("96260d2d-3041-4400-bc4a-d23a370d6b3f")]
            public virtual RepoItemInfo EnterPasswordInfo
            {
                get
                {
                    return _enterpasswordInfo;
                }
            }
        }

        /// <summary>
        /// The LoginActivityFolder folder.
        /// </summary>
        [RepositoryFolder("23bd5afe-2c3a-4575-8736-41c59a90bcec")]
        public partial class LoginActivityFolder : RepoGenBaseFolder
        {
            RepoItemInfo _manage_clickInfo;
            RepoItemInfo _connect_clickInfo;
            RepoItemInfo _edit_clickInfo;

            /// <summary>
            /// Creates a new LoginActivity  folder.
            /// </summary>
            public LoginActivityFolder(RepoGenBaseFolder parentFolder) :
                    base("LoginActivity", "form[@title='LoginActivity']", parentFolder, 30000, null, false, "23bd5afe-2c3a-4575-8736-41c59a90bcec", "")
            {
                _manage_clickInfo = new RepoItemInfo(this, "Manage_Click", ".//container[@containertype='Linear']/?/?/button[@text='manage']", 30000, null, "3e8cdcf2-9a37-47d4-b3a5-71caaa480530");
                _connect_clickInfo = new RepoItemInfo(this, "Connect_Click", "androidelement[@rid='content']//container[@containertype='Frame']/androidelement/container[@containertype='Relative']/container[@containertype='Relative']/button[@text='Connect']", 30000, null, "8e20d2fd-36f5-4901-92ff-99895fb0c762");
                _edit_clickInfo = new RepoItemInfo(this, "Edit_Click", "androidelement[@rid='content']//container[@containertype='Frame']/androidelement/container[@containertype='Relative']/container[@containertype='Relative']/button[@text='Edit']", 30000, null, "e4ffa61b-4fef-409c-b4ea-265a02e1fac7");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("23bd5afe-2c3a-4575-8736-41c59a90bcec")]
            public virtual Ranorex.Form Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Form>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("23bd5afe-2c3a-4575-8736-41c59a90bcec")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The Manage_Click item.
            /// </summary>
            [RepositoryItem("3e8cdcf2-9a37-47d4-b3a5-71caaa480530")]
            public virtual Ranorex.Button Manage_Click
            {
                get
                {
                    return _manage_clickInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The Manage_Click item info.
            /// </summary>
            [RepositoryItemInfo("3e8cdcf2-9a37-47d4-b3a5-71caaa480530")]
            public virtual RepoItemInfo Manage_ClickInfo
            {
                get
                {
                    return _manage_clickInfo;
                }
            }

            /// <summary>
            /// The Connect_Click item.
            /// </summary>
            [RepositoryItem("8e20d2fd-36f5-4901-92ff-99895fb0c762")]
            public virtual Ranorex.Button Connect_Click
            {
                get
                {
                    return _connect_clickInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The Connect_Click item info.
            /// </summary>
            [RepositoryItemInfo("8e20d2fd-36f5-4901-92ff-99895fb0c762")]
            public virtual RepoItemInfo Connect_ClickInfo
            {
                get
                {
                    return _connect_clickInfo;
                }
            }

            /// <summary>
            /// The Edit_Click item.
            /// </summary>
            [RepositoryItem("e4ffa61b-4fef-409c-b4ea-265a02e1fac7")]
            public virtual Ranorex.Button Edit_Click
            {
                get
                {
                    return _edit_clickInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The Edit_Click item info.
            /// </summary>
            [RepositoryItemInfo("e4ffa61b-4fef-409c-b4ea-265a02e1fac7")]
            public virtual RepoItemInfo Edit_ClickInfo
            {
                get
                {
                    return _edit_clickInfo;
                }
            }
        }

    }
#pragma warning restore 0436
}
