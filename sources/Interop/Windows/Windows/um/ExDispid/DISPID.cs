// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ExDispid.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class DISPID
{
    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_BEFORENAVIGATE"]/*' />
    [NativeTypeName("#define DISPID_BEFORENAVIGATE 100")]
    public const int DISPID_BEFORENAVIGATE = 100;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_NAVIGATECOMPLETE"]/*' />
    [NativeTypeName("#define DISPID_NAVIGATECOMPLETE 101")]
    public const int DISPID_NAVIGATECOMPLETE = 101;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_STATUSTEXTCHANGE"]/*' />
    [NativeTypeName("#define DISPID_STATUSTEXTCHANGE 102")]
    public const int DISPID_STATUSTEXTCHANGE = 102;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_QUIT"]/*' />
    [NativeTypeName("#define DISPID_QUIT 103")]
    public const int DISPID_QUIT = 103;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_DOWNLOADCOMPLETE"]/*' />
    [NativeTypeName("#define DISPID_DOWNLOADCOMPLETE 104")]
    public const int DISPID_DOWNLOADCOMPLETE = 104;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_COMMANDSTATECHANGE"]/*' />
    [NativeTypeName("#define DISPID_COMMANDSTATECHANGE 105")]
    public const int DISPID_COMMANDSTATECHANGE = 105;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_DOWNLOADBEGIN"]/*' />
    [NativeTypeName("#define DISPID_DOWNLOADBEGIN 106")]
    public const int DISPID_DOWNLOADBEGIN = 106;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_NEWWINDOW"]/*' />
    [NativeTypeName("#define DISPID_NEWWINDOW 107")]
    public const int DISPID_NEWWINDOW = 107;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_PROGRESSCHANGE"]/*' />
    [NativeTypeName("#define DISPID_PROGRESSCHANGE 108")]
    public const int DISPID_PROGRESSCHANGE = 108;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_WINDOWMOVE"]/*' />
    [NativeTypeName("#define DISPID_WINDOWMOVE 109")]
    public const int DISPID_WINDOWMOVE = 109;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_WINDOWRESIZE"]/*' />
    [NativeTypeName("#define DISPID_WINDOWRESIZE 110")]
    public const int DISPID_WINDOWRESIZE = 110;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_WINDOWACTIVATE"]/*' />
    [NativeTypeName("#define DISPID_WINDOWACTIVATE 111")]
    public const int DISPID_WINDOWACTIVATE = 111;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_PROPERTYCHANGE"]/*' />
    [NativeTypeName("#define DISPID_PROPERTYCHANGE 112")]
    public const int DISPID_PROPERTYCHANGE = 112;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_TITLECHANGE"]/*' />
    [NativeTypeName("#define DISPID_TITLECHANGE 113")]
    public const int DISPID_TITLECHANGE = 113;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_TITLEICONCHANGE"]/*' />
    [NativeTypeName("#define DISPID_TITLEICONCHANGE 114")]
    public const int DISPID_TITLEICONCHANGE = 114;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_FRAMEBEFORENAVIGATE"]/*' />
    [NativeTypeName("#define DISPID_FRAMEBEFORENAVIGATE 200")]
    public const int DISPID_FRAMEBEFORENAVIGATE = 200;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_FRAMENAVIGATECOMPLETE"]/*' />
    [NativeTypeName("#define DISPID_FRAMENAVIGATECOMPLETE 201")]
    public const int DISPID_FRAMENAVIGATECOMPLETE = 201;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_FRAMENEWWINDOW"]/*' />
    [NativeTypeName("#define DISPID_FRAMENEWWINDOW 204")]
    public const int DISPID_FRAMENEWWINDOW = 204;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_BEFORENAVIGATE2"]/*' />
    [NativeTypeName("#define DISPID_BEFORENAVIGATE2 250")]
    public const int DISPID_BEFORENAVIGATE2 = 250;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_NEWWINDOW2"]/*' />
    [NativeTypeName("#define DISPID_NEWWINDOW2 251")]
    public const int DISPID_NEWWINDOW2 = 251;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_NAVIGATECOMPLETE2"]/*' />
    [NativeTypeName("#define DISPID_NAVIGATECOMPLETE2 252")]
    public const int DISPID_NAVIGATECOMPLETE2 = 252;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_ONQUIT"]/*' />
    [NativeTypeName("#define DISPID_ONQUIT 253")]
    public const int DISPID_ONQUIT = 253;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_ONVISIBLE"]/*' />
    [NativeTypeName("#define DISPID_ONVISIBLE 254")]
    public const int DISPID_ONVISIBLE = 254;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_ONTOOLBAR"]/*' />
    [NativeTypeName("#define DISPID_ONTOOLBAR 255")]
    public const int DISPID_ONTOOLBAR = 255;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_ONMENUBAR"]/*' />
    [NativeTypeName("#define DISPID_ONMENUBAR 256")]
    public const int DISPID_ONMENUBAR = 256;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_ONSTATUSBAR"]/*' />
    [NativeTypeName("#define DISPID_ONSTATUSBAR 257")]
    public const int DISPID_ONSTATUSBAR = 257;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_ONFULLSCREEN"]/*' />
    [NativeTypeName("#define DISPID_ONFULLSCREEN 258")]
    public const int DISPID_ONFULLSCREEN = 258;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_DOCUMENTCOMPLETE"]/*' />
    [NativeTypeName("#define DISPID_DOCUMENTCOMPLETE 259")]
    public const int DISPID_DOCUMENTCOMPLETE = 259;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_ONTHEATERMODE"]/*' />
    [NativeTypeName("#define DISPID_ONTHEATERMODE 260")]
    public const int DISPID_ONTHEATERMODE = 260;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_ONADDRESSBAR"]/*' />
    [NativeTypeName("#define DISPID_ONADDRESSBAR 261")]
    public const int DISPID_ONADDRESSBAR = 261;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_WINDOWSETRESIZABLE"]/*' />
    [NativeTypeName("#define DISPID_WINDOWSETRESIZABLE 262")]
    public const int DISPID_WINDOWSETRESIZABLE = 262;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_WINDOWCLOSING"]/*' />
    [NativeTypeName("#define DISPID_WINDOWCLOSING 263")]
    public const int DISPID_WINDOWCLOSING = 263;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_WINDOWSETLEFT"]/*' />
    [NativeTypeName("#define DISPID_WINDOWSETLEFT 264")]
    public const int DISPID_WINDOWSETLEFT = 264;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_WINDOWSETTOP"]/*' />
    [NativeTypeName("#define DISPID_WINDOWSETTOP 265")]
    public const int DISPID_WINDOWSETTOP = 265;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_WINDOWSETWIDTH"]/*' />
    [NativeTypeName("#define DISPID_WINDOWSETWIDTH 266")]
    public const int DISPID_WINDOWSETWIDTH = 266;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_WINDOWSETHEIGHT"]/*' />
    [NativeTypeName("#define DISPID_WINDOWSETHEIGHT 267")]
    public const int DISPID_WINDOWSETHEIGHT = 267;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_CLIENTTOHOSTWINDOW"]/*' />
    [NativeTypeName("#define DISPID_CLIENTTOHOSTWINDOW 268")]
    public const int DISPID_CLIENTTOHOSTWINDOW = 268;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_SETSECURELOCKICON"]/*' />
    [NativeTypeName("#define DISPID_SETSECURELOCKICON 269")]
    public const int DISPID_SETSECURELOCKICON = 269;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_FILEDOWNLOAD"]/*' />
    [NativeTypeName("#define DISPID_FILEDOWNLOAD 270")]
    public const int DISPID_FILEDOWNLOAD = 270;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_NAVIGATEERROR"]/*' />
    [NativeTypeName("#define DISPID_NAVIGATEERROR 271")]
    public const int DISPID_NAVIGATEERROR = 271;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_PRIVACYIMPACTEDSTATECHANGE"]/*' />
    [NativeTypeName("#define DISPID_PRIVACYIMPACTEDSTATECHANGE 272")]
    public const int DISPID_PRIVACYIMPACTEDSTATECHANGE = 272;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_NEWWINDOW3"]/*' />
    [NativeTypeName("#define DISPID_NEWWINDOW3 273")]
    public const int DISPID_NEWWINDOW3 = 273;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_VIEWUPDATE"]/*' />
    [NativeTypeName("#define DISPID_VIEWUPDATE 281")]
    public const int DISPID_VIEWUPDATE = 281;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_SETPHISHINGFILTERSTATUS"]/*' />
    [NativeTypeName("#define DISPID_SETPHISHINGFILTERSTATUS 282")]
    public const int DISPID_SETPHISHINGFILTERSTATUS = 282;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_WINDOWSTATECHANGED"]/*' />
    [NativeTypeName("#define DISPID_WINDOWSTATECHANGED 283")]
    public const int DISPID_WINDOWSTATECHANGED = 283;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_NEWPROCESS"]/*' />
    [NativeTypeName("#define DISPID_NEWPROCESS 284")]
    public const int DISPID_NEWPROCESS = 284;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_THIRDPARTYURLBLOCKED"]/*' />
    [NativeTypeName("#define DISPID_THIRDPARTYURLBLOCKED 285")]
    public const int DISPID_THIRDPARTYURLBLOCKED = 285;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_REDIRECTXDOMAINBLOCKED"]/*' />
    [NativeTypeName("#define DISPID_REDIRECTXDOMAINBLOCKED 286")]
    public const int DISPID_REDIRECTXDOMAINBLOCKED = 286;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_WEBWORKERSTARTED"]/*' />
    [NativeTypeName("#define DISPID_WEBWORKERSTARTED 288")]
    public const int DISPID_WEBWORKERSTARTED = 288;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_WEBWORKERFINISHED"]/*' />
    [NativeTypeName("#define DISPID_WEBWORKERFINISHED 289")]
    public const int DISPID_WEBWORKERFINISHED = 289;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_BEFORESCRIPTEXECUTE"]/*' />
    [NativeTypeName("#define DISPID_BEFORESCRIPTEXECUTE 290")]
    public const int DISPID_BEFORESCRIPTEXECUTE = 290;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_PRINTTEMPLATEINSTANTIATION"]/*' />
    [NativeTypeName("#define DISPID_PRINTTEMPLATEINSTANTIATION 225")]
    public const int DISPID_PRINTTEMPLATEINSTANTIATION = 225;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_PRINTTEMPLATETEARDOWN"]/*' />
    [NativeTypeName("#define DISPID_PRINTTEMPLATETEARDOWN 226")]
    public const int DISPID_PRINTTEMPLATETEARDOWN = 226;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_UPDATEPAGESTATUS"]/*' />
    [NativeTypeName("#define DISPID_UPDATEPAGESTATUS 227")]
    public const int DISPID_UPDATEPAGESTATUS = 227;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_WINDOWREGISTERED"]/*' />
    [NativeTypeName("#define DISPID_WINDOWREGISTERED 200")]
    public const int DISPID_WINDOWREGISTERED = 200;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_WINDOWREVOKED"]/*' />
    [NativeTypeName("#define DISPID_WINDOWREVOKED 201")]
    public const int DISPID_WINDOWREVOKED = 201;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_RESETFIRSTBOOTMODE"]/*' />
    [NativeTypeName("#define DISPID_RESETFIRSTBOOTMODE 1")]
    public const int DISPID_RESETFIRSTBOOTMODE = 1;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_RESETSAFEMODE"]/*' />
    [NativeTypeName("#define DISPID_RESETSAFEMODE 2")]
    public const int DISPID_RESETSAFEMODE = 2;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_REFRESHOFFLINEDESKTOP"]/*' />
    [NativeTypeName("#define DISPID_REFRESHOFFLINEDESKTOP 3")]
    public const int DISPID_REFRESHOFFLINEDESKTOP = 3;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_ADDFAVORITE"]/*' />
    [NativeTypeName("#define DISPID_ADDFAVORITE 4")]
    public const int DISPID_ADDFAVORITE = 4;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_ADDCHANNEL"]/*' />
    [NativeTypeName("#define DISPID_ADDCHANNEL 5")]
    public const int DISPID_ADDCHANNEL = 5;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_ADDDESKTOPCOMPONENT"]/*' />
    [NativeTypeName("#define DISPID_ADDDESKTOPCOMPONENT 6")]
    public const int DISPID_ADDDESKTOPCOMPONENT = 6;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_ISSUBSCRIBED"]/*' />
    [NativeTypeName("#define DISPID_ISSUBSCRIBED 7")]
    public const int DISPID_ISSUBSCRIBED = 7;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_NAVIGATEANDFIND"]/*' />
    [NativeTypeName("#define DISPID_NAVIGATEANDFIND 8")]
    public const int DISPID_NAVIGATEANDFIND = 8;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_IMPORTEXPORTFAVORITES"]/*' />
    [NativeTypeName("#define DISPID_IMPORTEXPORTFAVORITES 9")]
    public const int DISPID_IMPORTEXPORTFAVORITES = 9;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_AUTOCOMPLETESAVEFORM"]/*' />
    [NativeTypeName("#define DISPID_AUTOCOMPLETESAVEFORM 10")]
    public const int DISPID_AUTOCOMPLETESAVEFORM = 10;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_AUTOSCAN"]/*' />
    [NativeTypeName("#define DISPID_AUTOSCAN 11")]
    public const int DISPID_AUTOSCAN = 11;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_AUTOCOMPLETEATTACH"]/*' />
    [NativeTypeName("#define DISPID_AUTOCOMPLETEATTACH 12")]
    public const int DISPID_AUTOCOMPLETEATTACH = 12;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_SHOWBROWSERUI"]/*' />
    [NativeTypeName("#define DISPID_SHOWBROWSERUI 13")]
    public const int DISPID_SHOWBROWSERUI = 13;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_ADDSEARCHPROVIDER"]/*' />
    [NativeTypeName("#define DISPID_ADDSEARCHPROVIDER 14")]
    public const int DISPID_ADDSEARCHPROVIDER = 14;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_RUNONCESHOWN"]/*' />
    [NativeTypeName("#define DISPID_RUNONCESHOWN 15")]
    public const int DISPID_RUNONCESHOWN = 15;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_SKIPRUNONCE"]/*' />
    [NativeTypeName("#define DISPID_SKIPRUNONCE 16")]
    public const int DISPID_SKIPRUNONCE = 16;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_CUSTOMIZESETTINGS"]/*' />
    [NativeTypeName("#define DISPID_CUSTOMIZESETTINGS 17")]
    public const int DISPID_CUSTOMIZESETTINGS = 17;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_SQMENABLED"]/*' />
    [NativeTypeName("#define DISPID_SQMENABLED 18")]
    public const int DISPID_SQMENABLED = 18;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_PHISHINGENABLED"]/*' />
    [NativeTypeName("#define DISPID_PHISHINGENABLED 19")]
    public const int DISPID_PHISHINGENABLED = 19;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_BRANDIMAGEURI"]/*' />
    [NativeTypeName("#define DISPID_BRANDIMAGEURI 20")]
    public const int DISPID_BRANDIMAGEURI = 20;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_SKIPTABSWELCOME"]/*' />
    [NativeTypeName("#define DISPID_SKIPTABSWELCOME 21")]
    public const int DISPID_SKIPTABSWELCOME = 21;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_DIAGNOSECONNECTION"]/*' />
    [NativeTypeName("#define DISPID_DIAGNOSECONNECTION 22")]
    public const int DISPID_DIAGNOSECONNECTION = 22;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_CUSTOMIZECLEARTYPE"]/*' />
    [NativeTypeName("#define DISPID_CUSTOMIZECLEARTYPE 23")]
    public const int DISPID_CUSTOMIZECLEARTYPE = 23;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_ISSEARCHPROVIDERINSTALLED"]/*' />
    [NativeTypeName("#define DISPID_ISSEARCHPROVIDERINSTALLED 24")]
    public const int DISPID_ISSEARCHPROVIDERINSTALLED = 24;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_ISSEARCHMIGRATED"]/*' />
    [NativeTypeName("#define DISPID_ISSEARCHMIGRATED 25")]
    public const int DISPID_ISSEARCHMIGRATED = 25;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_DEFAULTSEARCHPROVIDER"]/*' />
    [NativeTypeName("#define DISPID_DEFAULTSEARCHPROVIDER 26")]
    public const int DISPID_DEFAULTSEARCHPROVIDER = 26;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_RUNONCEREQUIREDSETTINGSCOMPLETE"]/*' />
    [NativeTypeName("#define DISPID_RUNONCEREQUIREDSETTINGSCOMPLETE 27")]
    public const int DISPID_RUNONCEREQUIREDSETTINGSCOMPLETE = 27;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_RUNONCEHASSHOWN"]/*' />
    [NativeTypeName("#define DISPID_RUNONCEHASSHOWN 28")]
    public const int DISPID_RUNONCEHASSHOWN = 28;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_SEARCHGUIDEURL"]/*' />
    [NativeTypeName("#define DISPID_SEARCHGUIDEURL 29")]
    public const int DISPID_SEARCHGUIDEURL = 29;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_ADDSERVICE"]/*' />
    [NativeTypeName("#define DISPID_ADDSERVICE 30")]
    public const int DISPID_ADDSERVICE = 30;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_ISSERVICEINSTALLED"]/*' />
    [NativeTypeName("#define DISPID_ISSERVICEINSTALLED 31")]
    public const int DISPID_ISSERVICEINSTALLED = 31;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_ADDTOFAVORITESBAR"]/*' />
    [NativeTypeName("#define DISPID_ADDTOFAVORITESBAR 32")]
    public const int DISPID_ADDTOFAVORITESBAR = 32;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_BUILDNEWTABPAGE"]/*' />
    [NativeTypeName("#define DISPID_BUILDNEWTABPAGE 33")]
    public const int DISPID_BUILDNEWTABPAGE = 33;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_SETRECENTLYCLOSEDVISIBLE"]/*' />
    [NativeTypeName("#define DISPID_SETRECENTLYCLOSEDVISIBLE 34")]
    public const int DISPID_SETRECENTLYCLOSEDVISIBLE = 34;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_SETACTIVITIESVISIBLE"]/*' />
    [NativeTypeName("#define DISPID_SETACTIVITIESVISIBLE 35")]
    public const int DISPID_SETACTIVITIESVISIBLE = 35;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_CONTENTDISCOVERYRESET"]/*' />
    [NativeTypeName("#define DISPID_CONTENTDISCOVERYRESET 36")]
    public const int DISPID_CONTENTDISCOVERYRESET = 36;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_INPRIVATEFILTERINGENABLED"]/*' />
    [NativeTypeName("#define DISPID_INPRIVATEFILTERINGENABLED 37")]
    public const int DISPID_INPRIVATEFILTERINGENABLED = 37;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_SUGGESTEDSITESENABLED"]/*' />
    [NativeTypeName("#define DISPID_SUGGESTEDSITESENABLED 38")]
    public const int DISPID_SUGGESTEDSITESENABLED = 38;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_ENABLESUGGESTEDSITES"]/*' />
    [NativeTypeName("#define DISPID_ENABLESUGGESTEDSITES 39")]
    public const int DISPID_ENABLESUGGESTEDSITES = 39;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_NAVIGATETOSUGGESTEDSITES"]/*' />
    [NativeTypeName("#define DISPID_NAVIGATETOSUGGESTEDSITES 40")]
    public const int DISPID_NAVIGATETOSUGGESTEDSITES = 40;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_SHOWTABSHELP"]/*' />
    [NativeTypeName("#define DISPID_SHOWTABSHELP 41")]
    public const int DISPID_SHOWTABSHELP = 41;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_SHOWINPRIVATEHELP"]/*' />
    [NativeTypeName("#define DISPID_SHOWINPRIVATEHELP 42")]
    public const int DISPID_SHOWINPRIVATEHELP = 42;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_ISSITEMODE"]/*' />
    [NativeTypeName("#define DISPID_ISSITEMODE 43")]
    public const int DISPID_ISSITEMODE = 43;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_SETSITEMODEICONOVERLAY"]/*' />
    [NativeTypeName("#define DISPID_SETSITEMODEICONOVERLAY 44")]
    public const int DISPID_SETSITEMODEICONOVERLAY = 44;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_CLEARSITEMODEICONOVERLAY"]/*' />
    [NativeTypeName("#define DISPID_CLEARSITEMODEICONOVERLAY 45")]
    public const int DISPID_CLEARSITEMODEICONOVERLAY = 45;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_UPDATETHUMBNAILBUTTON"]/*' />
    [NativeTypeName("#define DISPID_UPDATETHUMBNAILBUTTON 46")]
    public const int DISPID_UPDATETHUMBNAILBUTTON = 46;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_SETTHUMBNAILBUTTONS"]/*' />
    [NativeTypeName("#define DISPID_SETTHUMBNAILBUTTONS 47")]
    public const int DISPID_SETTHUMBNAILBUTTONS = 47;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_ADDTHUMBNAILBUTTONS"]/*' />
    [NativeTypeName("#define DISPID_ADDTHUMBNAILBUTTONS 48")]
    public const int DISPID_ADDTHUMBNAILBUTTONS = 48;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_ADDSITEMODE"]/*' />
    [NativeTypeName("#define DISPID_ADDSITEMODE 49")]
    public const int DISPID_ADDSITEMODE = 49;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_SETSITEMODEPROPERTIES"]/*' />
    [NativeTypeName("#define DISPID_SETSITEMODEPROPERTIES 50")]
    public const int DISPID_SETSITEMODEPROPERTIES = 50;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_SITEMODECREATEJUMPLIST"]/*' />
    [NativeTypeName("#define DISPID_SITEMODECREATEJUMPLIST 51")]
    public const int DISPID_SITEMODECREATEJUMPLIST = 51;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_SITEMODEADDJUMPLISTITEM"]/*' />
    [NativeTypeName("#define DISPID_SITEMODEADDJUMPLISTITEM 52")]
    public const int DISPID_SITEMODEADDJUMPLISTITEM = 52;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_SITEMODECLEARJUMPLIST"]/*' />
    [NativeTypeName("#define DISPID_SITEMODECLEARJUMPLIST 53")]
    public const int DISPID_SITEMODECLEARJUMPLIST = 53;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_SITEMODEADDBUTTONSTYLE"]/*' />
    [NativeTypeName("#define DISPID_SITEMODEADDBUTTONSTYLE 54")]
    public const int DISPID_SITEMODEADDBUTTONSTYLE = 54;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_SITEMODESHOWBUTTONSTYLE"]/*' />
    [NativeTypeName("#define DISPID_SITEMODESHOWBUTTONSTYLE 55")]
    public const int DISPID_SITEMODESHOWBUTTONSTYLE = 55;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_SITEMODESHOWJUMPLIST"]/*' />
    [NativeTypeName("#define DISPID_SITEMODESHOWJUMPLIST 56")]
    public const int DISPID_SITEMODESHOWJUMPLIST = 56;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_ADDTRACKINGPROTECTIONLIST"]/*' />
    [NativeTypeName("#define DISPID_ADDTRACKINGPROTECTIONLIST 57")]
    public const int DISPID_ADDTRACKINGPROTECTIONLIST = 57;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_SITEMODEACTIVATE"]/*' />
    [NativeTypeName("#define DISPID_SITEMODEACTIVATE 58")]
    public const int DISPID_SITEMODEACTIVATE = 58;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_ISSITEMODEFIRSTRUN"]/*' />
    [NativeTypeName("#define DISPID_ISSITEMODEFIRSTRUN 59")]
    public const int DISPID_ISSITEMODEFIRSTRUN = 59;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_TRACKINGPROTECTIONENABLED"]/*' />
    [NativeTypeName("#define DISPID_TRACKINGPROTECTIONENABLED 60")]
    public const int DISPID_TRACKINGPROTECTIONENABLED = 60;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_ACTIVEXFILTERINGENABLED"]/*' />
    [NativeTypeName("#define DISPID_ACTIVEXFILTERINGENABLED 61")]
    public const int DISPID_ACTIVEXFILTERINGENABLED = 61;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_PROVISIONNETWORKS"]/*' />
    [NativeTypeName("#define DISPID_PROVISIONNETWORKS 62")]
    public const int DISPID_PROVISIONNETWORKS = 62;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_REPORTSAFEURL"]/*' />
    [NativeTypeName("#define DISPID_REPORTSAFEURL 63")]
    public const int DISPID_REPORTSAFEURL = 63;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_SITEMODEREFRESHBADGE"]/*' />
    [NativeTypeName("#define DISPID_SITEMODEREFRESHBADGE 64")]
    public const int DISPID_SITEMODEREFRESHBADGE = 64;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_SITEMODECLEARBADGE"]/*' />
    [NativeTypeName("#define DISPID_SITEMODECLEARBADGE 65")]
    public const int DISPID_SITEMODECLEARBADGE = 65;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_DIAGNOSECONNECTIONUILESS"]/*' />
    [NativeTypeName("#define DISPID_DIAGNOSECONNECTIONUILESS 66")]
    public const int DISPID_DIAGNOSECONNECTIONUILESS = 66;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_LAUNCHNETWORKCLIENTHELP"]/*' />
    [NativeTypeName("#define DISPID_LAUNCHNETWORKCLIENTHELP 67")]
    public const int DISPID_LAUNCHNETWORKCLIENTHELP = 67;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_CHANGEDEFAULTBROWSER"]/*' />
    [NativeTypeName("#define DISPID_CHANGEDEFAULTBROWSER 68")]
    public const int DISPID_CHANGEDEFAULTBROWSER = 68;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_STOPPERIODICUPDATE"]/*' />
    [NativeTypeName("#define DISPID_STOPPERIODICUPDATE 69")]
    public const int DISPID_STOPPERIODICUPDATE = 69;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_STARTPERIODICUPDATE"]/*' />
    [NativeTypeName("#define DISPID_STARTPERIODICUPDATE 70")]
    public const int DISPID_STARTPERIODICUPDATE = 70;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_CLEARNOTIFICATION"]/*' />
    [NativeTypeName("#define DISPID_CLEARNOTIFICATION 71")]
    public const int DISPID_CLEARNOTIFICATION = 71;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_ENABLENOTIFICATIONQUEUE"]/*' />
    [NativeTypeName("#define DISPID_ENABLENOTIFICATIONQUEUE 72")]
    public const int DISPID_ENABLENOTIFICATIONQUEUE = 72;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_PINNEDSITESTATE"]/*' />
    [NativeTypeName("#define DISPID_PINNEDSITESTATE 73")]
    public const int DISPID_PINNEDSITESTATE = 73;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_LAUNCHINTERNETOPTIONS"]/*' />
    [NativeTypeName("#define DISPID_LAUNCHINTERNETOPTIONS 74")]
    public const int DISPID_LAUNCHINTERNETOPTIONS = 74;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_STARTPERIODICUPDATEBATCH"]/*' />
    [NativeTypeName("#define DISPID_STARTPERIODICUPDATEBATCH 75")]
    public const int DISPID_STARTPERIODICUPDATEBATCH = 75;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_ENABLENOTIFICATIONQUEUESQUARE"]/*' />
    [NativeTypeName("#define DISPID_ENABLENOTIFICATIONQUEUESQUARE 76")]
    public const int DISPID_ENABLENOTIFICATIONQUEUESQUARE = 76;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_ENABLENOTIFICATIONQUEUEWIDE"]/*' />
    [NativeTypeName("#define DISPID_ENABLENOTIFICATIONQUEUEWIDE 77")]
    public const int DISPID_ENABLENOTIFICATIONQUEUEWIDE = 77;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_ENABLENOTIFICATIONQUEUELARGE"]/*' />
    [NativeTypeName("#define DISPID_ENABLENOTIFICATIONQUEUELARGE 78")]
    public const int DISPID_ENABLENOTIFICATIONQUEUELARGE = 78;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_SCHEDULEDTILENOTIFICATION"]/*' />
    [NativeTypeName("#define DISPID_SCHEDULEDTILENOTIFICATION 79")]
    public const int DISPID_SCHEDULEDTILENOTIFICATION = 79;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_REMOVESCHEDULEDTILENOTIFICATION"]/*' />
    [NativeTypeName("#define DISPID_REMOVESCHEDULEDTILENOTIFICATION 80")]
    public const int DISPID_REMOVESCHEDULEDTILENOTIFICATION = 80;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_STARTBADGEUPDATE"]/*' />
    [NativeTypeName("#define DISPID_STARTBADGEUPDATE 81")]
    public const int DISPID_STARTBADGEUPDATE = 81;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_STOPBADGEUPDATE"]/*' />
    [NativeTypeName("#define DISPID_STOPBADGEUPDATE 82")]
    public const int DISPID_STOPBADGEUPDATE = 82;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_ISMETAREFERRERAVAILABLE"]/*' />
    [NativeTypeName("#define DISPID_ISMETAREFERRERAVAILABLE 83")]
    public const int DISPID_ISMETAREFERRERAVAILABLE = 83;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_SETEXPERIMENTALFLAG"]/*' />
    [NativeTypeName("#define DISPID_SETEXPERIMENTALFLAG 84")]
    public const int DISPID_SETEXPERIMENTALFLAG = 84;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_GETEXPERIMENTALFLAG"]/*' />
    [NativeTypeName("#define DISPID_GETEXPERIMENTALFLAG 85")]
    public const int DISPID_GETEXPERIMENTALFLAG = 85;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_SETEXPERIMENTALVALUE"]/*' />
    [NativeTypeName("#define DISPID_SETEXPERIMENTALVALUE 86")]
    public const int DISPID_SETEXPERIMENTALVALUE = 86;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_GETEXPERIMENTALVALUE"]/*' />
    [NativeTypeName("#define DISPID_GETEXPERIMENTALVALUE 87")]
    public const int DISPID_GETEXPERIMENTALVALUE = 87;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_HASNEEDIEAUTOLAUNCHFLAG"]/*' />
    [NativeTypeName("#define DISPID_HASNEEDIEAUTOLAUNCHFLAG 88")]
    public const int DISPID_HASNEEDIEAUTOLAUNCHFLAG = 88;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_GETNEEDIEAUTOLAUNCHFLAG"]/*' />
    [NativeTypeName("#define DISPID_GETNEEDIEAUTOLAUNCHFLAG 89")]
    public const int DISPID_GETNEEDIEAUTOLAUNCHFLAG = 89;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_SETNEEDIEAUTOLAUNCHFLAG"]/*' />
    [NativeTypeName("#define DISPID_SETNEEDIEAUTOLAUNCHFLAG 90")]
    public const int DISPID_SETNEEDIEAUTOLAUNCHFLAG = 90;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_LAUNCHIE"]/*' />
    [NativeTypeName("#define DISPID_LAUNCHIE 91")]
    public const int DISPID_LAUNCHIE = 91;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_RESETEXPERIMENTALFLAGS"]/*' />
    [NativeTypeName("#define DISPID_RESETEXPERIMENTALFLAGS 92")]
    public const int DISPID_RESETEXPERIMENTALFLAGS = 92;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_GETCVLISTDATA"]/*' />
    [NativeTypeName("#define DISPID_GETCVLISTDATA 93")]
    public const int DISPID_GETCVLISTDATA = 93;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_GETCVLISTLOCALDATA"]/*' />
    [NativeTypeName("#define DISPID_GETCVLISTLOCALDATA 94")]
    public const int DISPID_GETCVLISTLOCALDATA = 94;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_GETEMIELISTDATA"]/*' />
    [NativeTypeName("#define DISPID_GETEMIELISTDATA 95")]
    public const int DISPID_GETEMIELISTDATA = 95;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_GETEMIELISTLOCALDATA"]/*' />
    [NativeTypeName("#define DISPID_GETEMIELISTLOCALDATA 96")]
    public const int DISPID_GETEMIELISTLOCALDATA = 96;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_OPENFAVORITESPANE"]/*' />
    [NativeTypeName("#define DISPID_OPENFAVORITESPANE 97")]
    public const int DISPID_OPENFAVORITESPANE = 97;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_OPENFAVORITESSETTINGS"]/*' />
    [NativeTypeName("#define DISPID_OPENFAVORITESSETTINGS 98")]
    public const int DISPID_OPENFAVORITESSETTINGS = 98;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_LAUNCHINHVSI"]/*' />
    [NativeTypeName("#define DISPID_LAUNCHINHVSI 99")]
    public const int DISPID_LAUNCHINHVSI = 99;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_GETNEEDHVSIAUTOLAUNCHFLAG"]/*' />
    [NativeTypeName("#define DISPID_GETNEEDHVSIAUTOLAUNCHFLAG 100")]
    public const int DISPID_GETNEEDHVSIAUTOLAUNCHFLAG = 100;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_SETNEEDHVSIAUTOLAUNCHFLAG"]/*' />
    [NativeTypeName("#define DISPID_SETNEEDHVSIAUTOLAUNCHFLAG 101")]
    public const int DISPID_SETNEEDHVSIAUTOLAUNCHFLAG = 101;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_HASNEEDHVSIAUTOLAUNCHFLAG"]/*' />
    [NativeTypeName("#define DISPID_HASNEEDHVSIAUTOLAUNCHFLAG 102")]
    public const int DISPID_HASNEEDHVSIAUTOLAUNCHFLAG = 102;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_GETOSSKU"]/*' />
    [NativeTypeName("#define DISPID_GETOSSKU 103")]
    public const int DISPID_GETOSSKU = 103;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_SETMSDEFAULTS"]/*' />
    [NativeTypeName("#define DISPID_SETMSDEFAULTS 104")]
    public const int DISPID_SETMSDEFAULTS = 104;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_SHELLUIHELPERLAST"]/*' />
    [NativeTypeName("#define DISPID_SHELLUIHELPERLAST 105")]
    public const int DISPID_SHELLUIHELPERLAST = 105;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_ADVANCEERROR"]/*' />
    [NativeTypeName("#define DISPID_ADVANCEERROR 10")]
    public const int DISPID_ADVANCEERROR = 10;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_RETREATERROR"]/*' />
    [NativeTypeName("#define DISPID_RETREATERROR 11")]
    public const int DISPID_RETREATERROR = 11;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_CANADVANCEERROR"]/*' />
    [NativeTypeName("#define DISPID_CANADVANCEERROR 12")]
    public const int DISPID_CANADVANCEERROR = 12;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_CANRETREATERROR"]/*' />
    [NativeTypeName("#define DISPID_CANRETREATERROR 13")]
    public const int DISPID_CANRETREATERROR = 13;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_GETERRORLINE"]/*' />
    [NativeTypeName("#define DISPID_GETERRORLINE 14")]
    public const int DISPID_GETERRORLINE = 14;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_GETERRORCHAR"]/*' />
    [NativeTypeName("#define DISPID_GETERRORCHAR 15")]
    public const int DISPID_GETERRORCHAR = 15;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_GETERRORCODE"]/*' />
    [NativeTypeName("#define DISPID_GETERRORCODE 16")]
    public const int DISPID_GETERRORCODE = 16;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_GETERRORMSG"]/*' />
    [NativeTypeName("#define DISPID_GETERRORMSG 17")]
    public const int DISPID_GETERRORMSG = 17;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_GETERRORURL"]/*' />
    [NativeTypeName("#define DISPID_GETERRORURL 18")]
    public const int DISPID_GETERRORURL = 18;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_GETDETAILSSTATE"]/*' />
    [NativeTypeName("#define DISPID_GETDETAILSSTATE 19")]
    public const int DISPID_GETDETAILSSTATE = 19;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_SETDETAILSSTATE"]/*' />
    [NativeTypeName("#define DISPID_SETDETAILSSTATE 20")]
    public const int DISPID_SETDETAILSSTATE = 20;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_GETPERERRSTATE"]/*' />
    [NativeTypeName("#define DISPID_GETPERERRSTATE 21")]
    public const int DISPID_GETPERERRSTATE = 21;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_SETPERERRSTATE"]/*' />
    [NativeTypeName("#define DISPID_SETPERERRSTATE 22")]
    public const int DISPID_SETPERERRSTATE = 22;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_GETALWAYSSHOWLOCKSTATE"]/*' />
    [NativeTypeName("#define DISPID_GETALWAYSSHOWLOCKSTATE 23")]
    public const int DISPID_GETALWAYSSHOWLOCKSTATE = 23;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_FAVSELECTIONCHANGE"]/*' />
    [NativeTypeName("#define DISPID_FAVSELECTIONCHANGE 1")]
    public const int DISPID_FAVSELECTIONCHANGE = 1;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_SELECTIONCHANGE"]/*' />
    [NativeTypeName("#define DISPID_SELECTIONCHANGE 2")]
    public const int DISPID_SELECTIONCHANGE = 2;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_DOUBLECLICK"]/*' />
    [NativeTypeName("#define DISPID_DOUBLECLICK 3")]
    public const int DISPID_DOUBLECLICK = 3;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_INITIALIZED"]/*' />
    [NativeTypeName("#define DISPID_INITIALIZED 4")]
    public const int DISPID_INITIALIZED = 4;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_MOVESELECTIONUP"]/*' />
    [NativeTypeName("#define DISPID_MOVESELECTIONUP 1")]
    public const int DISPID_MOVESELECTIONUP = 1;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_MOVESELECTIONDOWN"]/*' />
    [NativeTypeName("#define DISPID_MOVESELECTIONDOWN 2")]
    public const int DISPID_MOVESELECTIONDOWN = 2;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_RESETSORT"]/*' />
    [NativeTypeName("#define DISPID_RESETSORT 3")]
    public const int DISPID_RESETSORT = 3;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_NEWFOLDER"]/*' />
    [NativeTypeName("#define DISPID_NEWFOLDER 4")]
    public const int DISPID_NEWFOLDER = 4;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_SYNCHRONIZE"]/*' />
    [NativeTypeName("#define DISPID_SYNCHRONIZE 5")]
    public const int DISPID_SYNCHRONIZE = 5;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_IMPORT"]/*' />
    [NativeTypeName("#define DISPID_IMPORT 6")]
    public const int DISPID_IMPORT = 6;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_EXPORT"]/*' />
    [NativeTypeName("#define DISPID_EXPORT 7")]
    public const int DISPID_EXPORT = 7;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_INVOKECONTEXTMENU"]/*' />
    [NativeTypeName("#define DISPID_INVOKECONTEXTMENU 8")]
    public const int DISPID_INVOKECONTEXTMENU = 8;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_MOVESELECTIONTO"]/*' />
    [NativeTypeName("#define DISPID_MOVESELECTIONTO 9")]
    public const int DISPID_MOVESELECTIONTO = 9;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_SUBSCRIPTIONSENABLED"]/*' />
    [NativeTypeName("#define DISPID_SUBSCRIPTIONSENABLED 10")]
    public const int DISPID_SUBSCRIPTIONSENABLED = 10;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_CREATESUBSCRIPTION"]/*' />
    [NativeTypeName("#define DISPID_CREATESUBSCRIPTION 11")]
    public const int DISPID_CREATESUBSCRIPTION = 11;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_DELETESUBSCRIPTION"]/*' />
    [NativeTypeName("#define DISPID_DELETESUBSCRIPTION 12")]
    public const int DISPID_DELETESUBSCRIPTION = 12;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_SETROOT"]/*' />
    [NativeTypeName("#define DISPID_SETROOT 13")]
    public const int DISPID_SETROOT = 13;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_ENUMOPTIONS"]/*' />
    [NativeTypeName("#define DISPID_ENUMOPTIONS 14")]
    public const int DISPID_ENUMOPTIONS = 14;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_SELECTEDITEM"]/*' />
    [NativeTypeName("#define DISPID_SELECTEDITEM 15")]
    public const int DISPID_SELECTEDITEM = 15;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_ROOT"]/*' />
    [NativeTypeName("#define DISPID_ROOT 16")]
    public const int DISPID_ROOT = 16;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_DEPTH"]/*' />
    [NativeTypeName("#define DISPID_DEPTH 17")]
    public const int DISPID_DEPTH = 17;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_MODE"]/*' />
    [NativeTypeName("#define DISPID_MODE 18")]
    public const int DISPID_MODE = 18;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_FLAGS"]/*' />
    [NativeTypeName("#define DISPID_FLAGS 19")]
    public const int DISPID_FLAGS = 19;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_TVFLAGS"]/*' />
    [NativeTypeName("#define DISPID_TVFLAGS 20")]
    public const int DISPID_TVFLAGS = 20;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_NSCOLUMNS"]/*' />
    [NativeTypeName("#define DISPID_NSCOLUMNS 21")]
    public const int DISPID_NSCOLUMNS = 21;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_COUNTVIEWTYPES"]/*' />
    [NativeTypeName("#define DISPID_COUNTVIEWTYPES 22")]
    public const int DISPID_COUNTVIEWTYPES = 22;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_SETVIEWTYPE"]/*' />
    [NativeTypeName("#define DISPID_SETVIEWTYPE 23")]
    public const int DISPID_SETVIEWTYPE = 23;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_SELECTEDITEMS"]/*' />
    [NativeTypeName("#define DISPID_SELECTEDITEMS 24")]
    public const int DISPID_SELECTEDITEMS = 24;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_EXPAND"]/*' />
    [NativeTypeName("#define DISPID_EXPAND 25")]
    public const int DISPID_EXPAND = 25;

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_UNSELECTALL"]/*' />
    [NativeTypeName("#define DISPID_UNSELECTALL 26")]
    public const int DISPID_UNSELECTALL = 26;
}
