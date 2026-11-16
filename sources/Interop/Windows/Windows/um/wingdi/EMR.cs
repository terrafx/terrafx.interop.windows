// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public partial struct EMR
{
    /// <include file='EMR.xml' path='doc/member[@name="EMR.iType"]/*' />
    [NativeTypeName("DWORD")]
    public uint iType;

    /// <include file='EMR.xml' path='doc/member[@name="EMR.nSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint nSize;

    /// <include file='EMR.xml' path='doc/member[@name="EMR.EMR_HEADER"]/*' />
    [NativeTypeName("#define EMR_HEADER 1")]
    public const int EMR_HEADER = 1;

    /// <include file='EMR.xml' path='doc/member[@name="EMR.EMR_POLYBEZIER"]/*' />
    [NativeTypeName("#define EMR_POLYBEZIER 2")]
    public const int EMR_POLYBEZIER = 2;

    /// <include file='EMR.xml' path='doc/member[@name="EMR.EMR_POLYGON"]/*' />
    [NativeTypeName("#define EMR_POLYGON 3")]
    public const int EMR_POLYGON = 3;

    /// <include file='EMR.xml' path='doc/member[@name="EMR.EMR_POLYLINE"]/*' />
    [NativeTypeName("#define EMR_POLYLINE 4")]
    public const int EMR_POLYLINE = 4;

    /// <include file='EMR.xml' path='doc/member[@name="EMR.EMR_POLYBEZIERTO"]/*' />
    [NativeTypeName("#define EMR_POLYBEZIERTO 5")]
    public const int EMR_POLYBEZIERTO = 5;

    /// <include file='EMR.xml' path='doc/member[@name="EMR.EMR_POLYLINETO"]/*' />
    [NativeTypeName("#define EMR_POLYLINETO 6")]
    public const int EMR_POLYLINETO = 6;

    /// <include file='EMR.xml' path='doc/member[@name="EMR.EMR_POLYPOLYLINE"]/*' />
    [NativeTypeName("#define EMR_POLYPOLYLINE 7")]
    public const int EMR_POLYPOLYLINE = 7;

    /// <include file='EMR.xml' path='doc/member[@name="EMR.EMR_POLYPOLYGON"]/*' />
    [NativeTypeName("#define EMR_POLYPOLYGON 8")]
    public const int EMR_POLYPOLYGON = 8;

    /// <include file='EMR.xml' path='doc/member[@name="EMR.EMR_SETWINDOWEXTEX"]/*' />
    [NativeTypeName("#define EMR_SETWINDOWEXTEX 9")]
    public const int EMR_SETWINDOWEXTEX = 9;

    /// <include file='EMR.xml' path='doc/member[@name="EMR.EMR_SETWINDOWORGEX"]/*' />
    [NativeTypeName("#define EMR_SETWINDOWORGEX 10")]
    public const int EMR_SETWINDOWORGEX = 10;

    /// <include file='EMR.xml' path='doc/member[@name="EMR.EMR_SETVIEWPORTEXTEX"]/*' />
    [NativeTypeName("#define EMR_SETVIEWPORTEXTEX 11")]
    public const int EMR_SETVIEWPORTEXTEX = 11;

    /// <include file='EMR.xml' path='doc/member[@name="EMR.EMR_SETVIEWPORTORGEX"]/*' />
    [NativeTypeName("#define EMR_SETVIEWPORTORGEX 12")]
    public const int EMR_SETVIEWPORTORGEX = 12;

    /// <include file='EMR.xml' path='doc/member[@name="EMR.EMR_SETBRUSHORGEX"]/*' />
    [NativeTypeName("#define EMR_SETBRUSHORGEX 13")]
    public const int EMR_SETBRUSHORGEX = 13;

    /// <include file='EMR.xml' path='doc/member[@name="EMR.EMR_EOF"]/*' />
    [NativeTypeName("#define EMR_EOF 14")]
    public const int EMR_EOF = 14;

    /// <include file='EMR.xml' path='doc/member[@name="EMR.EMR_SETPIXELV"]/*' />
    [NativeTypeName("#define EMR_SETPIXELV 15")]
    public const int EMR_SETPIXELV = 15;

    /// <include file='EMR.xml' path='doc/member[@name="EMR.EMR_SETMAPPERFLAGS"]/*' />
    [NativeTypeName("#define EMR_SETMAPPERFLAGS 16")]
    public const int EMR_SETMAPPERFLAGS = 16;

    /// <include file='EMR.xml' path='doc/member[@name="EMR.EMR_SETMAPMODE"]/*' />
    [NativeTypeName("#define EMR_SETMAPMODE 17")]
    public const int EMR_SETMAPMODE = 17;

    /// <include file='EMR.xml' path='doc/member[@name="EMR.EMR_SETBKMODE"]/*' />
    [NativeTypeName("#define EMR_SETBKMODE 18")]
    public const int EMR_SETBKMODE = 18;

    /// <include file='EMR.xml' path='doc/member[@name="EMR.EMR_SETPOLYFILLMODE"]/*' />
    [NativeTypeName("#define EMR_SETPOLYFILLMODE 19")]
    public const int EMR_SETPOLYFILLMODE = 19;

    /// <include file='EMR.xml' path='doc/member[@name="EMR.EMR_SETROP2"]/*' />
    [NativeTypeName("#define EMR_SETROP2 20")]
    public const int EMR_SETROP2 = 20;

    /// <include file='EMR.xml' path='doc/member[@name="EMR.EMR_SETSTRETCHBLTMODE"]/*' />
    [NativeTypeName("#define EMR_SETSTRETCHBLTMODE 21")]
    public const int EMR_SETSTRETCHBLTMODE = 21;

    /// <include file='EMR.xml' path='doc/member[@name="EMR.EMR_SETTEXTALIGN"]/*' />
    [NativeTypeName("#define EMR_SETTEXTALIGN 22")]
    public const int EMR_SETTEXTALIGN = 22;

    /// <include file='EMR.xml' path='doc/member[@name="EMR.EMR_SETCOLORADJUSTMENT"]/*' />
    [NativeTypeName("#define EMR_SETCOLORADJUSTMENT 23")]
    public const int EMR_SETCOLORADJUSTMENT = 23;

    /// <include file='EMR.xml' path='doc/member[@name="EMR.EMR_SETTEXTCOLOR"]/*' />
    [NativeTypeName("#define EMR_SETTEXTCOLOR 24")]
    public const int EMR_SETTEXTCOLOR = 24;

    /// <include file='EMR.xml' path='doc/member[@name="EMR.EMR_SETBKCOLOR"]/*' />
    [NativeTypeName("#define EMR_SETBKCOLOR 25")]
    public const int EMR_SETBKCOLOR = 25;

    /// <include file='EMR.xml' path='doc/member[@name="EMR.EMR_OFFSETCLIPRGN"]/*' />
    [NativeTypeName("#define EMR_OFFSETCLIPRGN 26")]
    public const int EMR_OFFSETCLIPRGN = 26;

    /// <include file='EMR.xml' path='doc/member[@name="EMR.EMR_MOVETOEX"]/*' />
    [NativeTypeName("#define EMR_MOVETOEX 27")]
    public const int EMR_MOVETOEX = 27;

    /// <include file='EMR.xml' path='doc/member[@name="EMR.EMR_SETMETARGN"]/*' />
    [NativeTypeName("#define EMR_SETMETARGN 28")]
    public const int EMR_SETMETARGN = 28;

    /// <include file='EMR.xml' path='doc/member[@name="EMR.EMR_EXCLUDECLIPRECT"]/*' />
    [NativeTypeName("#define EMR_EXCLUDECLIPRECT 29")]
    public const int EMR_EXCLUDECLIPRECT = 29;

    /// <include file='EMR.xml' path='doc/member[@name="EMR.EMR_INTERSECTCLIPRECT"]/*' />
    [NativeTypeName("#define EMR_INTERSECTCLIPRECT 30")]
    public const int EMR_INTERSECTCLIPRECT = 30;

    /// <include file='EMR.xml' path='doc/member[@name="EMR.EMR_SCALEVIEWPORTEXTEX"]/*' />
    [NativeTypeName("#define EMR_SCALEVIEWPORTEXTEX 31")]
    public const int EMR_SCALEVIEWPORTEXTEX = 31;

    /// <include file='EMR.xml' path='doc/member[@name="EMR.EMR_SCALEWINDOWEXTEX"]/*' />
    [NativeTypeName("#define EMR_SCALEWINDOWEXTEX 32")]
    public const int EMR_SCALEWINDOWEXTEX = 32;

    /// <include file='EMR.xml' path='doc/member[@name="EMR.EMR_SAVEDC"]/*' />
    [NativeTypeName("#define EMR_SAVEDC 33")]
    public const int EMR_SAVEDC = 33;

    /// <include file='EMR.xml' path='doc/member[@name="EMR.EMR_RESTOREDC"]/*' />
    [NativeTypeName("#define EMR_RESTOREDC 34")]
    public const int EMR_RESTOREDC = 34;

    /// <include file='EMR.xml' path='doc/member[@name="EMR.EMR_SETWORLDTRANSFORM"]/*' />
    [NativeTypeName("#define EMR_SETWORLDTRANSFORM 35")]
    public const int EMR_SETWORLDTRANSFORM = 35;

    /// <include file='EMR.xml' path='doc/member[@name="EMR.EMR_MODIFYWORLDTRANSFORM"]/*' />
    [NativeTypeName("#define EMR_MODIFYWORLDTRANSFORM 36")]
    public const int EMR_MODIFYWORLDTRANSFORM = 36;

    /// <include file='EMR.xml' path='doc/member[@name="EMR.EMR_SELECTOBJECT"]/*' />
    [NativeTypeName("#define EMR_SELECTOBJECT 37")]
    public const int EMR_SELECTOBJECT = 37;

    /// <include file='EMR.xml' path='doc/member[@name="EMR.EMR_CREATEPEN"]/*' />
    [NativeTypeName("#define EMR_CREATEPEN 38")]
    public const int EMR_CREATEPEN = 38;

    /// <include file='EMR.xml' path='doc/member[@name="EMR.EMR_CREATEBRUSHINDIRECT"]/*' />
    [NativeTypeName("#define EMR_CREATEBRUSHINDIRECT 39")]
    public const int EMR_CREATEBRUSHINDIRECT = 39;

    /// <include file='EMR.xml' path='doc/member[@name="EMR.EMR_DELETEOBJECT"]/*' />
    [NativeTypeName("#define EMR_DELETEOBJECT 40")]
    public const int EMR_DELETEOBJECT = 40;

    /// <include file='EMR.xml' path='doc/member[@name="EMR.EMR_ANGLEARC"]/*' />
    [NativeTypeName("#define EMR_ANGLEARC 41")]
    public const int EMR_ANGLEARC = 41;

    /// <include file='EMR.xml' path='doc/member[@name="EMR.EMR_ELLIPSE"]/*' />
    [NativeTypeName("#define EMR_ELLIPSE 42")]
    public const int EMR_ELLIPSE = 42;

    /// <include file='EMR.xml' path='doc/member[@name="EMR.EMR_RECTANGLE"]/*' />
    [NativeTypeName("#define EMR_RECTANGLE 43")]
    public const int EMR_RECTANGLE = 43;

    /// <include file='EMR.xml' path='doc/member[@name="EMR.EMR_ROUNDRECT"]/*' />
    [NativeTypeName("#define EMR_ROUNDRECT 44")]
    public const int EMR_ROUNDRECT = 44;

    /// <include file='EMR.xml' path='doc/member[@name="EMR.EMR_ARC"]/*' />
    [NativeTypeName("#define EMR_ARC 45")]
    public const int EMR_ARC = 45;

    /// <include file='EMR.xml' path='doc/member[@name="EMR.EMR_CHORD"]/*' />
    [NativeTypeName("#define EMR_CHORD 46")]
    public const int EMR_CHORD = 46;

    /// <include file='EMR.xml' path='doc/member[@name="EMR.EMR_PIE"]/*' />
    [NativeTypeName("#define EMR_PIE 47")]
    public const int EMR_PIE = 47;

    /// <include file='EMR.xml' path='doc/member[@name="EMR.EMR_SELECTPALETTE"]/*' />
    [NativeTypeName("#define EMR_SELECTPALETTE 48")]
    public const int EMR_SELECTPALETTE = 48;

    /// <include file='EMR.xml' path='doc/member[@name="EMR.EMR_CREATEPALETTE"]/*' />
    [NativeTypeName("#define EMR_CREATEPALETTE 49")]
    public const int EMR_CREATEPALETTE = 49;

    /// <include file='EMR.xml' path='doc/member[@name="EMR.EMR_SETPALETTEENTRIES"]/*' />
    [NativeTypeName("#define EMR_SETPALETTEENTRIES 50")]
    public const int EMR_SETPALETTEENTRIES = 50;

    /// <include file='EMR.xml' path='doc/member[@name="EMR.EMR_RESIZEPALETTE"]/*' />
    [NativeTypeName("#define EMR_RESIZEPALETTE 51")]
    public const int EMR_RESIZEPALETTE = 51;

    /// <include file='EMR.xml' path='doc/member[@name="EMR.EMR_REALIZEPALETTE"]/*' />
    [NativeTypeName("#define EMR_REALIZEPALETTE 52")]
    public const int EMR_REALIZEPALETTE = 52;

    /// <include file='EMR.xml' path='doc/member[@name="EMR.EMR_EXTFLOODFILL"]/*' />
    [NativeTypeName("#define EMR_EXTFLOODFILL 53")]
    public const int EMR_EXTFLOODFILL = 53;

    /// <include file='EMR.xml' path='doc/member[@name="EMR.EMR_LINETO"]/*' />
    [NativeTypeName("#define EMR_LINETO 54")]
    public const int EMR_LINETO = 54;

    /// <include file='EMR.xml' path='doc/member[@name="EMR.EMR_ARCTO"]/*' />
    [NativeTypeName("#define EMR_ARCTO 55")]
    public const int EMR_ARCTO = 55;

    /// <include file='EMR.xml' path='doc/member[@name="EMR.EMR_POLYDRAW"]/*' />
    [NativeTypeName("#define EMR_POLYDRAW 56")]
    public const int EMR_POLYDRAW = 56;

    /// <include file='EMR.xml' path='doc/member[@name="EMR.EMR_SETARCDIRECTION"]/*' />
    [NativeTypeName("#define EMR_SETARCDIRECTION 57")]
    public const int EMR_SETARCDIRECTION = 57;

    /// <include file='EMR.xml' path='doc/member[@name="EMR.EMR_SETMITERLIMIT"]/*' />
    [NativeTypeName("#define EMR_SETMITERLIMIT 58")]
    public const int EMR_SETMITERLIMIT = 58;

    /// <include file='EMR.xml' path='doc/member[@name="EMR.EMR_BEGINPATH"]/*' />
    [NativeTypeName("#define EMR_BEGINPATH 59")]
    public const int EMR_BEGINPATH = 59;

    /// <include file='EMR.xml' path='doc/member[@name="EMR.EMR_ENDPATH"]/*' />
    [NativeTypeName("#define EMR_ENDPATH 60")]
    public const int EMR_ENDPATH = 60;

    /// <include file='EMR.xml' path='doc/member[@name="EMR.EMR_CLOSEFIGURE"]/*' />
    [NativeTypeName("#define EMR_CLOSEFIGURE 61")]
    public const int EMR_CLOSEFIGURE = 61;

    /// <include file='EMR.xml' path='doc/member[@name="EMR.EMR_FILLPATH"]/*' />
    [NativeTypeName("#define EMR_FILLPATH 62")]
    public const int EMR_FILLPATH = 62;

    /// <include file='EMR.xml' path='doc/member[@name="EMR.EMR_STROKEANDFILLPATH"]/*' />
    [NativeTypeName("#define EMR_STROKEANDFILLPATH 63")]
    public const int EMR_STROKEANDFILLPATH = 63;

    /// <include file='EMR.xml' path='doc/member[@name="EMR.EMR_STROKEPATH"]/*' />
    [NativeTypeName("#define EMR_STROKEPATH 64")]
    public const int EMR_STROKEPATH = 64;

    /// <include file='EMR.xml' path='doc/member[@name="EMR.EMR_FLATTENPATH"]/*' />
    [NativeTypeName("#define EMR_FLATTENPATH 65")]
    public const int EMR_FLATTENPATH = 65;

    /// <include file='EMR.xml' path='doc/member[@name="EMR.EMR_WIDENPATH"]/*' />
    [NativeTypeName("#define EMR_WIDENPATH 66")]
    public const int EMR_WIDENPATH = 66;

    /// <include file='EMR.xml' path='doc/member[@name="EMR.EMR_SELECTCLIPPATH"]/*' />
    [NativeTypeName("#define EMR_SELECTCLIPPATH 67")]
    public const int EMR_SELECTCLIPPATH = 67;

    /// <include file='EMR.xml' path='doc/member[@name="EMR.EMR_ABORTPATH"]/*' />
    [NativeTypeName("#define EMR_ABORTPATH 68")]
    public const int EMR_ABORTPATH = 68;

    /// <include file='EMR.xml' path='doc/member[@name="EMR.EMR_GDICOMMENT"]/*' />
    [NativeTypeName("#define EMR_GDICOMMENT 70")]
    public const int EMR_GDICOMMENT = 70;

    /// <include file='EMR.xml' path='doc/member[@name="EMR.EMR_FILLRGN"]/*' />
    [NativeTypeName("#define EMR_FILLRGN 71")]
    public const int EMR_FILLRGN = 71;

    /// <include file='EMR.xml' path='doc/member[@name="EMR.EMR_FRAMERGN"]/*' />
    [NativeTypeName("#define EMR_FRAMERGN 72")]
    public const int EMR_FRAMERGN = 72;

    /// <include file='EMR.xml' path='doc/member[@name="EMR.EMR_INVERTRGN"]/*' />
    [NativeTypeName("#define EMR_INVERTRGN 73")]
    public const int EMR_INVERTRGN = 73;

    /// <include file='EMR.xml' path='doc/member[@name="EMR.EMR_PAINTRGN"]/*' />
    [NativeTypeName("#define EMR_PAINTRGN 74")]
    public const int EMR_PAINTRGN = 74;

    /// <include file='EMR.xml' path='doc/member[@name="EMR.EMR_EXTSELECTCLIPRGN"]/*' />
    [NativeTypeName("#define EMR_EXTSELECTCLIPRGN 75")]
    public const int EMR_EXTSELECTCLIPRGN = 75;

    /// <include file='EMR.xml' path='doc/member[@name="EMR.EMR_BITBLT"]/*' />
    [NativeTypeName("#define EMR_BITBLT 76")]
    public const int EMR_BITBLT = 76;

    /// <include file='EMR.xml' path='doc/member[@name="EMR.EMR_STRETCHBLT"]/*' />
    [NativeTypeName("#define EMR_STRETCHBLT 77")]
    public const int EMR_STRETCHBLT = 77;

    /// <include file='EMR.xml' path='doc/member[@name="EMR.EMR_MASKBLT"]/*' />
    [NativeTypeName("#define EMR_MASKBLT 78")]
    public const int EMR_MASKBLT = 78;

    /// <include file='EMR.xml' path='doc/member[@name="EMR.EMR_PLGBLT"]/*' />
    [NativeTypeName("#define EMR_PLGBLT 79")]
    public const int EMR_PLGBLT = 79;

    /// <include file='EMR.xml' path='doc/member[@name="EMR.EMR_SETDIBITSTODEVICE"]/*' />
    [NativeTypeName("#define EMR_SETDIBITSTODEVICE 80")]
    public const int EMR_SETDIBITSTODEVICE = 80;

    /// <include file='EMR.xml' path='doc/member[@name="EMR.EMR_STRETCHDIBITS"]/*' />
    [NativeTypeName("#define EMR_STRETCHDIBITS 81")]
    public const int EMR_STRETCHDIBITS = 81;

    /// <include file='EMR.xml' path='doc/member[@name="EMR.EMR_EXTCREATEFONTINDIRECTW"]/*' />
    [NativeTypeName("#define EMR_EXTCREATEFONTINDIRECTW 82")]
    public const int EMR_EXTCREATEFONTINDIRECTW = 82;

    /// <include file='EMR.xml' path='doc/member[@name="EMR.EMR_EXTTEXTOUTA"]/*' />
    [NativeTypeName("#define EMR_EXTTEXTOUTA 83")]
    public const int EMR_EXTTEXTOUTA = 83;

    /// <include file='EMR.xml' path='doc/member[@name="EMR.EMR_EXTTEXTOUTW"]/*' />
    [NativeTypeName("#define EMR_EXTTEXTOUTW 84")]
    public const int EMR_EXTTEXTOUTW = 84;

    /// <include file='EMR.xml' path='doc/member[@name="EMR.EMR_POLYBEZIER16"]/*' />
    [NativeTypeName("#define EMR_POLYBEZIER16 85")]
    public const int EMR_POLYBEZIER16 = 85;

    /// <include file='EMR.xml' path='doc/member[@name="EMR.EMR_POLYGON16"]/*' />
    [NativeTypeName("#define EMR_POLYGON16 86")]
    public const int EMR_POLYGON16 = 86;

    /// <include file='EMR.xml' path='doc/member[@name="EMR.EMR_POLYLINE16"]/*' />
    [NativeTypeName("#define EMR_POLYLINE16 87")]
    public const int EMR_POLYLINE16 = 87;

    /// <include file='EMR.xml' path='doc/member[@name="EMR.EMR_POLYBEZIERTO16"]/*' />
    [NativeTypeName("#define EMR_POLYBEZIERTO16 88")]
    public const int EMR_POLYBEZIERTO16 = 88;

    /// <include file='EMR.xml' path='doc/member[@name="EMR.EMR_POLYLINETO16"]/*' />
    [NativeTypeName("#define EMR_POLYLINETO16 89")]
    public const int EMR_POLYLINETO16 = 89;

    /// <include file='EMR.xml' path='doc/member[@name="EMR.EMR_POLYPOLYLINE16"]/*' />
    [NativeTypeName("#define EMR_POLYPOLYLINE16 90")]
    public const int EMR_POLYPOLYLINE16 = 90;

    /// <include file='EMR.xml' path='doc/member[@name="EMR.EMR_POLYPOLYGON16"]/*' />
    [NativeTypeName("#define EMR_POLYPOLYGON16 91")]
    public const int EMR_POLYPOLYGON16 = 91;

    /// <include file='EMR.xml' path='doc/member[@name="EMR.EMR_POLYDRAW16"]/*' />
    [NativeTypeName("#define EMR_POLYDRAW16 92")]
    public const int EMR_POLYDRAW16 = 92;

    /// <include file='EMR.xml' path='doc/member[@name="EMR.EMR_CREATEMONOBRUSH"]/*' />
    [NativeTypeName("#define EMR_CREATEMONOBRUSH 93")]
    public const int EMR_CREATEMONOBRUSH = 93;

    /// <include file='EMR.xml' path='doc/member[@name="EMR.EMR_CREATEDIBPATTERNBRUSHPT"]/*' />
    [NativeTypeName("#define EMR_CREATEDIBPATTERNBRUSHPT 94")]
    public const int EMR_CREATEDIBPATTERNBRUSHPT = 94;

    /// <include file='EMR.xml' path='doc/member[@name="EMR.EMR_EXTCREATEPEN"]/*' />
    [NativeTypeName("#define EMR_EXTCREATEPEN 95")]
    public const int EMR_EXTCREATEPEN = 95;

    /// <include file='EMR.xml' path='doc/member[@name="EMR.EMR_POLYTEXTOUTA"]/*' />
    [NativeTypeName("#define EMR_POLYTEXTOUTA 96")]
    public const int EMR_POLYTEXTOUTA = 96;

    /// <include file='EMR.xml' path='doc/member[@name="EMR.EMR_POLYTEXTOUTW"]/*' />
    [NativeTypeName("#define EMR_POLYTEXTOUTW 97")]
    public const int EMR_POLYTEXTOUTW = 97;

    /// <include file='EMR.xml' path='doc/member[@name="EMR.EMR_SETICMMODE"]/*' />
    [NativeTypeName("#define EMR_SETICMMODE 98")]
    public const int EMR_SETICMMODE = 98;

    /// <include file='EMR.xml' path='doc/member[@name="EMR.EMR_CREATECOLORSPACE"]/*' />
    [NativeTypeName("#define EMR_CREATECOLORSPACE 99")]
    public const int EMR_CREATECOLORSPACE = 99;

    /// <include file='EMR.xml' path='doc/member[@name="EMR.EMR_SETCOLORSPACE"]/*' />
    [NativeTypeName("#define EMR_SETCOLORSPACE 100")]
    public const int EMR_SETCOLORSPACE = 100;

    /// <include file='EMR.xml' path='doc/member[@name="EMR.EMR_DELETECOLORSPACE"]/*' />
    [NativeTypeName("#define EMR_DELETECOLORSPACE 101")]
    public const int EMR_DELETECOLORSPACE = 101;

    /// <include file='EMR.xml' path='doc/member[@name="EMR.EMR_GLSRECORD"]/*' />
    [NativeTypeName("#define EMR_GLSRECORD 102")]
    public const int EMR_GLSRECORD = 102;

    /// <include file='EMR.xml' path='doc/member[@name="EMR.EMR_GLSBOUNDEDRECORD"]/*' />
    [NativeTypeName("#define EMR_GLSBOUNDEDRECORD 103")]
    public const int EMR_GLSBOUNDEDRECORD = 103;

    /// <include file='EMR.xml' path='doc/member[@name="EMR.EMR_PIXELFORMAT"]/*' />
    [NativeTypeName("#define EMR_PIXELFORMAT 104")]
    public const int EMR_PIXELFORMAT = 104;

    /// <include file='EMR.xml' path='doc/member[@name="EMR.EMR_RESERVED_105"]/*' />
    [NativeTypeName("#define EMR_RESERVED_105 105")]
    public const int EMR_RESERVED_105 = 105;

    /// <include file='EMR.xml' path='doc/member[@name="EMR.EMR_RESERVED_106"]/*' />
    [NativeTypeName("#define EMR_RESERVED_106 106")]
    public const int EMR_RESERVED_106 = 106;

    /// <include file='EMR.xml' path='doc/member[@name="EMR.EMR_RESERVED_107"]/*' />
    [NativeTypeName("#define EMR_RESERVED_107 107")]
    public const int EMR_RESERVED_107 = 107;

    /// <include file='EMR.xml' path='doc/member[@name="EMR.EMR_RESERVED_108"]/*' />
    [NativeTypeName("#define EMR_RESERVED_108 108")]
    public const int EMR_RESERVED_108 = 108;

    /// <include file='EMR.xml' path='doc/member[@name="EMR.EMR_RESERVED_109"]/*' />
    [NativeTypeName("#define EMR_RESERVED_109 109")]
    public const int EMR_RESERVED_109 = 109;

    /// <include file='EMR.xml' path='doc/member[@name="EMR.EMR_RESERVED_110"]/*' />
    [NativeTypeName("#define EMR_RESERVED_110 110")]
    public const int EMR_RESERVED_110 = 110;

    /// <include file='EMR.xml' path='doc/member[@name="EMR.EMR_COLORCORRECTPALETTE"]/*' />
    [NativeTypeName("#define EMR_COLORCORRECTPALETTE 111")]
    public const int EMR_COLORCORRECTPALETTE = 111;

    /// <include file='EMR.xml' path='doc/member[@name="EMR.EMR_SETICMPROFILEA"]/*' />
    [NativeTypeName("#define EMR_SETICMPROFILEA 112")]
    public const int EMR_SETICMPROFILEA = 112;

    /// <include file='EMR.xml' path='doc/member[@name="EMR.EMR_SETICMPROFILEW"]/*' />
    [NativeTypeName("#define EMR_SETICMPROFILEW 113")]
    public const int EMR_SETICMPROFILEW = 113;

    /// <include file='EMR.xml' path='doc/member[@name="EMR.EMR_ALPHABLEND"]/*' />
    [NativeTypeName("#define EMR_ALPHABLEND 114")]
    public const int EMR_ALPHABLEND = 114;

    /// <include file='EMR.xml' path='doc/member[@name="EMR.EMR_SETLAYOUT"]/*' />
    [NativeTypeName("#define EMR_SETLAYOUT 115")]
    public const int EMR_SETLAYOUT = 115;

    /// <include file='EMR.xml' path='doc/member[@name="EMR.EMR_TRANSPARENTBLT"]/*' />
    [NativeTypeName("#define EMR_TRANSPARENTBLT 116")]
    public const int EMR_TRANSPARENTBLT = 116;

    /// <include file='EMR.xml' path='doc/member[@name="EMR.EMR_RESERVED_117"]/*' />
    [NativeTypeName("#define EMR_RESERVED_117 117")]
    public const int EMR_RESERVED_117 = 117;

    /// <include file='EMR.xml' path='doc/member[@name="EMR.EMR_GRADIENTFILL"]/*' />
    [NativeTypeName("#define EMR_GRADIENTFILL 118")]
    public const int EMR_GRADIENTFILL = 118;

    /// <include file='EMR.xml' path='doc/member[@name="EMR.EMR_RESERVED_119"]/*' />
    [NativeTypeName("#define EMR_RESERVED_119 119")]
    public const int EMR_RESERVED_119 = 119;

    /// <include file='EMR.xml' path='doc/member[@name="EMR.EMR_RESERVED_120"]/*' />
    [NativeTypeName("#define EMR_RESERVED_120 120")]
    public const int EMR_RESERVED_120 = 120;

    /// <include file='EMR.xml' path='doc/member[@name="EMR.EMR_COLORMATCHTOTARGETW"]/*' />
    [NativeTypeName("#define EMR_COLORMATCHTOTARGETW 121")]
    public const int EMR_COLORMATCHTOTARGETW = 121;

    /// <include file='EMR.xml' path='doc/member[@name="EMR.EMR_CREATECOLORSPACEW"]/*' />
    [NativeTypeName("#define EMR_CREATECOLORSPACEW 122")]
    public const int EMR_CREATECOLORSPACEW = 122;

    /// <include file='EMR.xml' path='doc/member[@name="EMR.EMR_MIN"]/*' />
    [NativeTypeName("#define EMR_MIN 1")]
    public const int EMR_MIN = 1;

    /// <include file='EMR.xml' path='doc/member[@name="EMR.EMR_MAX"]/*' />
    [NativeTypeName("#define EMR_MAX 122")]
    public const int EMR_MAX = 122;
}
