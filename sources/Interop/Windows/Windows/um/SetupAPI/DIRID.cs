// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class DIRID
{
    /// <include file='DIRID.xml' path='doc/member[@name="DIRID.DIRID_ABSOLUTE"]/*' />
    [NativeTypeName("#define DIRID_ABSOLUTE -1")]
    public const int DIRID_ABSOLUTE = -1;

    /// <include file='DIRID.xml' path='doc/member[@name="DIRID.DIRID_ABSOLUTE_16BIT"]/*' />
    [NativeTypeName("#define DIRID_ABSOLUTE_16BIT 0xffff")]
    public const int DIRID_ABSOLUTE_16BIT = 0xffff;

    /// <include file='DIRID.xml' path='doc/member[@name="DIRID.DIRID_NULL"]/*' />
    [NativeTypeName("#define DIRID_NULL 0")]
    public const int DIRID_NULL = 0;

    /// <include file='DIRID.xml' path='doc/member[@name="DIRID.DIRID_SRCPATH"]/*' />
    [NativeTypeName("#define DIRID_SRCPATH 1")]
    public const int DIRID_SRCPATH = 1;

    /// <include file='DIRID.xml' path='doc/member[@name="DIRID.DIRID_WINDOWS"]/*' />
    [NativeTypeName("#define DIRID_WINDOWS 10")]
    public const int DIRID_WINDOWS = 10;

    /// <include file='DIRID.xml' path='doc/member[@name="DIRID.DIRID_SYSTEM"]/*' />
    [NativeTypeName("#define DIRID_SYSTEM 11")]
    public const int DIRID_SYSTEM = 11;

    /// <include file='DIRID.xml' path='doc/member[@name="DIRID.DIRID_DRIVERS"]/*' />
    [NativeTypeName("#define DIRID_DRIVERS 12")]
    public const int DIRID_DRIVERS = 12;

    /// <include file='DIRID.xml' path='doc/member[@name="DIRID.DIRID_IOSUBSYS"]/*' />
    [NativeTypeName("#define DIRID_IOSUBSYS DIRID_DRIVERS")]
    public const int DIRID_IOSUBSYS = 12;

    /// <include file='DIRID.xml' path='doc/member[@name="DIRID.DIRID_DRIVER_STORE"]/*' />
    [NativeTypeName("#define DIRID_DRIVER_STORE 13")]
    public const int DIRID_DRIVER_STORE = 13;

    /// <include file='DIRID.xml' path='doc/member[@name="DIRID.DIRID_INF"]/*' />
    [NativeTypeName("#define DIRID_INF 17")]
    public const int DIRID_INF = 17;

    /// <include file='DIRID.xml' path='doc/member[@name="DIRID.DIRID_HELP"]/*' />
    [NativeTypeName("#define DIRID_HELP 18")]
    public const int DIRID_HELP = 18;

    /// <include file='DIRID.xml' path='doc/member[@name="DIRID.DIRID_FONTS"]/*' />
    [NativeTypeName("#define DIRID_FONTS 20")]
    public const int DIRID_FONTS = 20;

    /// <include file='DIRID.xml' path='doc/member[@name="DIRID.DIRID_VIEWERS"]/*' />
    [NativeTypeName("#define DIRID_VIEWERS 21")]
    public const int DIRID_VIEWERS = 21;

    /// <include file='DIRID.xml' path='doc/member[@name="DIRID.DIRID_COLOR"]/*' />
    [NativeTypeName("#define DIRID_COLOR 23")]
    public const int DIRID_COLOR = 23;

    /// <include file='DIRID.xml' path='doc/member[@name="DIRID.DIRID_APPS"]/*' />
    [NativeTypeName("#define DIRID_APPS 24")]
    public const int DIRID_APPS = 24;

    /// <include file='DIRID.xml' path='doc/member[@name="DIRID.DIRID_SHARED"]/*' />
    [NativeTypeName("#define DIRID_SHARED 25")]
    public const int DIRID_SHARED = 25;

    /// <include file='DIRID.xml' path='doc/member[@name="DIRID.DIRID_BOOT"]/*' />
    [NativeTypeName("#define DIRID_BOOT 30")]
    public const int DIRID_BOOT = 30;

    /// <include file='DIRID.xml' path='doc/member[@name="DIRID.DIRID_SYSTEM16"]/*' />
    [NativeTypeName("#define DIRID_SYSTEM16 50")]
    public const int DIRID_SYSTEM16 = 50;

    /// <include file='DIRID.xml' path='doc/member[@name="DIRID.DIRID_SPOOL"]/*' />
    [NativeTypeName("#define DIRID_SPOOL 51")]
    public const int DIRID_SPOOL = 51;

    /// <include file='DIRID.xml' path='doc/member[@name="DIRID.DIRID_SPOOLDRIVERS"]/*' />
    [NativeTypeName("#define DIRID_SPOOLDRIVERS 52")]
    public const int DIRID_SPOOLDRIVERS = 52;

    /// <include file='DIRID.xml' path='doc/member[@name="DIRID.DIRID_USERPROFILE"]/*' />
    [NativeTypeName("#define DIRID_USERPROFILE 53")]
    public const int DIRID_USERPROFILE = 53;

    /// <include file='DIRID.xml' path='doc/member[@name="DIRID.DIRID_LOADER"]/*' />
    [NativeTypeName("#define DIRID_LOADER 54")]
    public const int DIRID_LOADER = 54;

    /// <include file='DIRID.xml' path='doc/member[@name="DIRID.DIRID_PRINTPROCESSOR"]/*' />
    [NativeTypeName("#define DIRID_PRINTPROCESSOR 55")]
    public const int DIRID_PRINTPROCESSOR = 55;

    /// <include file='DIRID.xml' path='doc/member[@name="DIRID.DIRID_DEFAULT"]/*' />
    [NativeTypeName("#define DIRID_DEFAULT DIRID_SYSTEM")]
    public const int DIRID_DEFAULT = 11;

    /// <include file='DIRID.xml' path='doc/member[@name="DIRID.DIRID_COMMON_STARTMENU"]/*' />
    [NativeTypeName("#define DIRID_COMMON_STARTMENU 16406")]
    public const int DIRID_COMMON_STARTMENU = 16406;

    /// <include file='DIRID.xml' path='doc/member[@name="DIRID.DIRID_COMMON_PROGRAMS"]/*' />
    [NativeTypeName("#define DIRID_COMMON_PROGRAMS 16407")]
    public const int DIRID_COMMON_PROGRAMS = 16407;

    /// <include file='DIRID.xml' path='doc/member[@name="DIRID.DIRID_COMMON_STARTUP"]/*' />
    [NativeTypeName("#define DIRID_COMMON_STARTUP 16408")]
    public const int DIRID_COMMON_STARTUP = 16408;

    /// <include file='DIRID.xml' path='doc/member[@name="DIRID.DIRID_COMMON_DESKTOPDIRECTORY"]/*' />
    [NativeTypeName("#define DIRID_COMMON_DESKTOPDIRECTORY 16409")]
    public const int DIRID_COMMON_DESKTOPDIRECTORY = 16409;

    /// <include file='DIRID.xml' path='doc/member[@name="DIRID.DIRID_COMMON_FAVORITES"]/*' />
    [NativeTypeName("#define DIRID_COMMON_FAVORITES 16415")]
    public const int DIRID_COMMON_FAVORITES = 16415;

    /// <include file='DIRID.xml' path='doc/member[@name="DIRID.DIRID_COMMON_APPDATA"]/*' />
    [NativeTypeName("#define DIRID_COMMON_APPDATA 16419")]
    public const int DIRID_COMMON_APPDATA = 16419;

    /// <include file='DIRID.xml' path='doc/member[@name="DIRID.DIRID_PROGRAM_FILES"]/*' />
    [NativeTypeName("#define DIRID_PROGRAM_FILES 16422")]
    public const int DIRID_PROGRAM_FILES = 16422;

    /// <include file='DIRID.xml' path='doc/member[@name="DIRID.DIRID_SYSTEM_X86"]/*' />
    [NativeTypeName("#define DIRID_SYSTEM_X86 16425")]
    public const int DIRID_SYSTEM_X86 = 16425;

    /// <include file='DIRID.xml' path='doc/member[@name="DIRID.DIRID_PROGRAM_FILES_X86"]/*' />
    [NativeTypeName("#define DIRID_PROGRAM_FILES_X86 16426")]
    public const int DIRID_PROGRAM_FILES_X86 = 16426;

    /// <include file='DIRID.xml' path='doc/member[@name="DIRID.DIRID_PROGRAM_FILES_COMMON"]/*' />
    [NativeTypeName("#define DIRID_PROGRAM_FILES_COMMON 16427")]
    public const int DIRID_PROGRAM_FILES_COMMON = 16427;

    /// <include file='DIRID.xml' path='doc/member[@name="DIRID.DIRID_PROGRAM_FILES_COMMONX86"]/*' />
    [NativeTypeName("#define DIRID_PROGRAM_FILES_COMMONX86 16428")]
    public const int DIRID_PROGRAM_FILES_COMMONX86 = 16428;

    /// <include file='DIRID.xml' path='doc/member[@name="DIRID.DIRID_COMMON_TEMPLATES"]/*' />
    [NativeTypeName("#define DIRID_COMMON_TEMPLATES 16429")]
    public const int DIRID_COMMON_TEMPLATES = 16429;

    /// <include file='DIRID.xml' path='doc/member[@name="DIRID.DIRID_COMMON_DOCUMENTS"]/*' />
    [NativeTypeName("#define DIRID_COMMON_DOCUMENTS 16430")]
    public const int DIRID_COMMON_DOCUMENTS = 16430;

    /// <include file='DIRID.xml' path='doc/member[@name="DIRID.DIRID_USER"]/*' />
    [NativeTypeName("#define DIRID_USER 0x8000")]
    public const int DIRID_USER = 0x8000;
}
