﻿#pragma checksum "C:\Users\DELL\source\repos\music_asignment\music_asignment\Pages\CreateSongPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "D95044F92171BE829A99BB384CA0C214B665665A27221C27A6A05C42A9CDEF98"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace music_asignment.Pages
{
    partial class CreateSongPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // Pages\CreateSongPage.xaml line 22
                {
                    this.name = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 3: // Pages\CreateSongPage.xaml line 23
                {
                    this.checkName = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 4: // Pages\CreateSongPage.xaml line 25
                {
                    this.description = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 5: // Pages\CreateSongPage.xaml line 26
                {
                    this.checkDescription = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 6: // Pages\CreateSongPage.xaml line 27
                {
                    this.singer = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 7: // Pages\CreateSongPage.xaml line 28
                {
                    this.checkSinger = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 8: // Pages\CreateSongPage.xaml line 29
                {
                    this.author = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 9: // Pages\CreateSongPage.xaml line 30
                {
                    this.checkAuthor = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 10: // Pages\CreateSongPage.xaml line 31
                {
                    this.thumbnail = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 11: // Pages\CreateSongPage.xaml line 35
                {
                    this.createThumbnail = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.createThumbnail).Click += this.Button_CreateThumbnail;
                }
                break;
            case 12: // Pages\CreateSongPage.xaml line 36
                {
                    this.deleteThumbnail = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.deleteThumbnail).Click += this.Button_DeleteThumbnail;
                }
                break;
            case 13: // Pages\CreateSongPage.xaml line 37
                {
                    this.checkThumbnail = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 14: // Pages\CreateSongPage.xaml line 38
                {
                    this.link = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 15: // Pages\CreateSongPage.xaml line 39
                {
                    this.createSong = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.createSong).Click += this.Button_AddSong;
                }
                break;
            case 16: // Pages\CreateSongPage.xaml line 40
                {
                    this.deleteSong = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.deleteSong).Click += this.Button_DeleteSong;
                }
                break;
            case 17: // Pages\CreateSongPage.xaml line 41
                {
                    this.checkLink = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 18: // Pages\CreateSongPage.xaml line 45
                {
                    this.waitingRespone = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 19: // Pages\CreateSongPage.xaml line 43
                {
                    global::Windows.UI.Xaml.Controls.Button element19 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element19).Click += this.Button_CreateSong;
                }
                break;
            case 20: // Pages\CreateSongPage.xaml line 33
                {
                    this.imageThumbnail = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

