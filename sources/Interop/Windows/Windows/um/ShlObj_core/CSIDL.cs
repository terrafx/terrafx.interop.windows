// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShlObj_core.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class CSIDL
{
    /// <include file='CSIDL.xml' path='doc/member[@name="CSIDL.CSIDL_DESKTOP"]/*' />
    [NativeTypeName("#define CSIDL_DESKTOP 0x0000")]
    public const int CSIDL_DESKTOP = 0x0000;

    /// <include file='CSIDL.xml' path='doc/member[@name="CSIDL.CSIDL_INTERNET"]/*' />
    [NativeTypeName("#define CSIDL_INTERNET 0x0001")]
    public const int CSIDL_INTERNET = 0x0001;

    /// <include file='CSIDL.xml' path='doc/member[@name="CSIDL.CSIDL_PROGRAMS"]/*' />
    [NativeTypeName("#define CSIDL_PROGRAMS 0x0002")]
    public const int CSIDL_PROGRAMS = 0x0002;

    /// <include file='CSIDL.xml' path='doc/member[@name="CSIDL.CSIDL_CONTROLS"]/*' />
    [NativeTypeName("#define CSIDL_CONTROLS 0x0003")]
    public const int CSIDL_CONTROLS = 0x0003;

    /// <include file='CSIDL.xml' path='doc/member[@name="CSIDL.CSIDL_PRINTERS"]/*' />
    [NativeTypeName("#define CSIDL_PRINTERS 0x0004")]
    public const int CSIDL_PRINTERS = 0x0004;

    /// <include file='CSIDL.xml' path='doc/member[@name="CSIDL.CSIDL_PERSONAL"]/*' />
    [NativeTypeName("#define CSIDL_PERSONAL 0x0005")]
    public const int CSIDL_PERSONAL = 0x0005;

    /// <include file='CSIDL.xml' path='doc/member[@name="CSIDL.CSIDL_FAVORITES"]/*' />
    [NativeTypeName("#define CSIDL_FAVORITES 0x0006")]
    public const int CSIDL_FAVORITES = 0x0006;

    /// <include file='CSIDL.xml' path='doc/member[@name="CSIDL.CSIDL_STARTUP"]/*' />
    [NativeTypeName("#define CSIDL_STARTUP 0x0007")]
    public const int CSIDL_STARTUP = 0x0007;

    /// <include file='CSIDL.xml' path='doc/member[@name="CSIDL.CSIDL_RECENT"]/*' />
    [NativeTypeName("#define CSIDL_RECENT 0x0008")]
    public const int CSIDL_RECENT = 0x0008;

    /// <include file='CSIDL.xml' path='doc/member[@name="CSIDL.CSIDL_SENDTO"]/*' />
    [NativeTypeName("#define CSIDL_SENDTO 0x0009")]
    public const int CSIDL_SENDTO = 0x0009;

    /// <include file='CSIDL.xml' path='doc/member[@name="CSIDL.CSIDL_BITBUCKET"]/*' />
    [NativeTypeName("#define CSIDL_BITBUCKET 0x000a")]
    public const int CSIDL_BITBUCKET = 0x000a;

    /// <include file='CSIDL.xml' path='doc/member[@name="CSIDL.CSIDL_STARTMENU"]/*' />
    [NativeTypeName("#define CSIDL_STARTMENU 0x000b")]
    public const int CSIDL_STARTMENU = 0x000b;

    /// <include file='CSIDL.xml' path='doc/member[@name="CSIDL.CSIDL_MYDOCUMENTS"]/*' />
    [NativeTypeName("#define CSIDL_MYDOCUMENTS CSIDL_PERSONAL")]
    public const int CSIDL_MYDOCUMENTS = 0x0005;

    /// <include file='CSIDL.xml' path='doc/member[@name="CSIDL.CSIDL_MYMUSIC"]/*' />
    [NativeTypeName("#define CSIDL_MYMUSIC 0x000d")]
    public const int CSIDL_MYMUSIC = 0x000d;

    /// <include file='CSIDL.xml' path='doc/member[@name="CSIDL.CSIDL_MYVIDEO"]/*' />
    [NativeTypeName("#define CSIDL_MYVIDEO 0x000e")]
    public const int CSIDL_MYVIDEO = 0x000e;

    /// <include file='CSIDL.xml' path='doc/member[@name="CSIDL.CSIDL_DESKTOPDIRECTORY"]/*' />
    [NativeTypeName("#define CSIDL_DESKTOPDIRECTORY 0x0010")]
    public const int CSIDL_DESKTOPDIRECTORY = 0x0010;

    /// <include file='CSIDL.xml' path='doc/member[@name="CSIDL.CSIDL_DRIVES"]/*' />
    [NativeTypeName("#define CSIDL_DRIVES 0x0011")]
    public const int CSIDL_DRIVES = 0x0011;

    /// <include file='CSIDL.xml' path='doc/member[@name="CSIDL.CSIDL_NETWORK"]/*' />
    [NativeTypeName("#define CSIDL_NETWORK 0x0012")]
    public const int CSIDL_NETWORK = 0x0012;

    /// <include file='CSIDL.xml' path='doc/member[@name="CSIDL.CSIDL_NETHOOD"]/*' />
    [NativeTypeName("#define CSIDL_NETHOOD 0x0013")]
    public const int CSIDL_NETHOOD = 0x0013;

    /// <include file='CSIDL.xml' path='doc/member[@name="CSIDL.CSIDL_FONTS"]/*' />
    [NativeTypeName("#define CSIDL_FONTS 0x0014")]
    public const int CSIDL_FONTS = 0x0014;

    /// <include file='CSIDL.xml' path='doc/member[@name="CSIDL.CSIDL_TEMPLATES"]/*' />
    [NativeTypeName("#define CSIDL_TEMPLATES 0x0015")]
    public const int CSIDL_TEMPLATES = 0x0015;

    /// <include file='CSIDL.xml' path='doc/member[@name="CSIDL.CSIDL_COMMON_STARTMENU"]/*' />
    [NativeTypeName("#define CSIDL_COMMON_STARTMENU 0x0016")]
    public const int CSIDL_COMMON_STARTMENU = 0x0016;

    /// <include file='CSIDL.xml' path='doc/member[@name="CSIDL.CSIDL_COMMON_PROGRAMS"]/*' />
    [NativeTypeName("#define CSIDL_COMMON_PROGRAMS 0X0017")]
    public const int CSIDL_COMMON_PROGRAMS = 0X0017;

    /// <include file='CSIDL.xml' path='doc/member[@name="CSIDL.CSIDL_COMMON_STARTUP"]/*' />
    [NativeTypeName("#define CSIDL_COMMON_STARTUP 0x0018")]
    public const int CSIDL_COMMON_STARTUP = 0x0018;

    /// <include file='CSIDL.xml' path='doc/member[@name="CSIDL.CSIDL_COMMON_DESKTOPDIRECTORY"]/*' />
    [NativeTypeName("#define CSIDL_COMMON_DESKTOPDIRECTORY 0x0019")]
    public const int CSIDL_COMMON_DESKTOPDIRECTORY = 0x0019;

    /// <include file='CSIDL.xml' path='doc/member[@name="CSIDL.CSIDL_APPDATA"]/*' />
    [NativeTypeName("#define CSIDL_APPDATA 0x001a")]
    public const int CSIDL_APPDATA = 0x001a;

    /// <include file='CSIDL.xml' path='doc/member[@name="CSIDL.CSIDL_PRINTHOOD"]/*' />
    [NativeTypeName("#define CSIDL_PRINTHOOD 0x001b")]
    public const int CSIDL_PRINTHOOD = 0x001b;

    /// <include file='CSIDL.xml' path='doc/member[@name="CSIDL.CSIDL_LOCAL_APPDATA"]/*' />
    [NativeTypeName("#define CSIDL_LOCAL_APPDATA 0x001c")]
    public const int CSIDL_LOCAL_APPDATA = 0x001c;

    /// <include file='CSIDL.xml' path='doc/member[@name="CSIDL.CSIDL_ALTSTARTUP"]/*' />
    [NativeTypeName("#define CSIDL_ALTSTARTUP 0x001d")]
    public const int CSIDL_ALTSTARTUP = 0x001d;

    /// <include file='CSIDL.xml' path='doc/member[@name="CSIDL.CSIDL_COMMON_ALTSTARTUP"]/*' />
    [NativeTypeName("#define CSIDL_COMMON_ALTSTARTUP 0x001e")]
    public const int CSIDL_COMMON_ALTSTARTUP = 0x001e;

    /// <include file='CSIDL.xml' path='doc/member[@name="CSIDL.CSIDL_COMMON_FAVORITES"]/*' />
    [NativeTypeName("#define CSIDL_COMMON_FAVORITES 0x001f")]
    public const int CSIDL_COMMON_FAVORITES = 0x001f;

    /// <include file='CSIDL.xml' path='doc/member[@name="CSIDL.CSIDL_INTERNET_CACHE"]/*' />
    [NativeTypeName("#define CSIDL_INTERNET_CACHE 0x0020")]
    public const int CSIDL_INTERNET_CACHE = 0x0020;

    /// <include file='CSIDL.xml' path='doc/member[@name="CSIDL.CSIDL_COOKIES"]/*' />
    [NativeTypeName("#define CSIDL_COOKIES 0x0021")]
    public const int CSIDL_COOKIES = 0x0021;

    /// <include file='CSIDL.xml' path='doc/member[@name="CSIDL.CSIDL_HISTORY"]/*' />
    [NativeTypeName("#define CSIDL_HISTORY 0x0022")]
    public const int CSIDL_HISTORY = 0x0022;

    /// <include file='CSIDL.xml' path='doc/member[@name="CSIDL.CSIDL_COMMON_APPDATA"]/*' />
    [NativeTypeName("#define CSIDL_COMMON_APPDATA 0x0023")]
    public const int CSIDL_COMMON_APPDATA = 0x0023;

    /// <include file='CSIDL.xml' path='doc/member[@name="CSIDL.CSIDL_WINDOWS"]/*' />
    [NativeTypeName("#define CSIDL_WINDOWS 0x0024")]
    public const int CSIDL_WINDOWS = 0x0024;

    /// <include file='CSIDL.xml' path='doc/member[@name="CSIDL.CSIDL_SYSTEM"]/*' />
    [NativeTypeName("#define CSIDL_SYSTEM 0x0025")]
    public const int CSIDL_SYSTEM = 0x0025;

    /// <include file='CSIDL.xml' path='doc/member[@name="CSIDL.CSIDL_PROGRAM_FILES"]/*' />
    [NativeTypeName("#define CSIDL_PROGRAM_FILES 0x0026")]
    public const int CSIDL_PROGRAM_FILES = 0x0026;

    /// <include file='CSIDL.xml' path='doc/member[@name="CSIDL.CSIDL_MYPICTURES"]/*' />
    [NativeTypeName("#define CSIDL_MYPICTURES 0x0027")]
    public const int CSIDL_MYPICTURES = 0x0027;

    /// <include file='CSIDL.xml' path='doc/member[@name="CSIDL.CSIDL_PROFILE"]/*' />
    [NativeTypeName("#define CSIDL_PROFILE 0x0028")]
    public const int CSIDL_PROFILE = 0x0028;

    /// <include file='CSIDL.xml' path='doc/member[@name="CSIDL.CSIDL_SYSTEMX86"]/*' />
    [NativeTypeName("#define CSIDL_SYSTEMX86 0x0029")]
    public const int CSIDL_SYSTEMX86 = 0x0029;

    /// <include file='CSIDL.xml' path='doc/member[@name="CSIDL.CSIDL_PROGRAM_FILESX86"]/*' />
    [NativeTypeName("#define CSIDL_PROGRAM_FILESX86 0x002a")]
    public const int CSIDL_PROGRAM_FILESX86 = 0x002a;

    /// <include file='CSIDL.xml' path='doc/member[@name="CSIDL.CSIDL_PROGRAM_FILES_COMMON"]/*' />
    [NativeTypeName("#define CSIDL_PROGRAM_FILES_COMMON 0x002b")]
    public const int CSIDL_PROGRAM_FILES_COMMON = 0x002b;

    /// <include file='CSIDL.xml' path='doc/member[@name="CSIDL.CSIDL_PROGRAM_FILES_COMMONX86"]/*' />
    [NativeTypeName("#define CSIDL_PROGRAM_FILES_COMMONX86 0x002c")]
    public const int CSIDL_PROGRAM_FILES_COMMONX86 = 0x002c;

    /// <include file='CSIDL.xml' path='doc/member[@name="CSIDL.CSIDL_COMMON_TEMPLATES"]/*' />
    [NativeTypeName("#define CSIDL_COMMON_TEMPLATES 0x002d")]
    public const int CSIDL_COMMON_TEMPLATES = 0x002d;

    /// <include file='CSIDL.xml' path='doc/member[@name="CSIDL.CSIDL_COMMON_DOCUMENTS"]/*' />
    [NativeTypeName("#define CSIDL_COMMON_DOCUMENTS 0x002e")]
    public const int CSIDL_COMMON_DOCUMENTS = 0x002e;

    /// <include file='CSIDL.xml' path='doc/member[@name="CSIDL.CSIDL_COMMON_ADMINTOOLS"]/*' />
    [NativeTypeName("#define CSIDL_COMMON_ADMINTOOLS 0x002f")]
    public const int CSIDL_COMMON_ADMINTOOLS = 0x002f;

    /// <include file='CSIDL.xml' path='doc/member[@name="CSIDL.CSIDL_ADMINTOOLS"]/*' />
    [NativeTypeName("#define CSIDL_ADMINTOOLS 0x0030")]
    public const int CSIDL_ADMINTOOLS = 0x0030;

    /// <include file='CSIDL.xml' path='doc/member[@name="CSIDL.CSIDL_CONNECTIONS"]/*' />
    [NativeTypeName("#define CSIDL_CONNECTIONS 0x0031")]
    public const int CSIDL_CONNECTIONS = 0x0031;

    /// <include file='CSIDL.xml' path='doc/member[@name="CSIDL.CSIDL_COMMON_MUSIC"]/*' />
    [NativeTypeName("#define CSIDL_COMMON_MUSIC 0x0035")]
    public const int CSIDL_COMMON_MUSIC = 0x0035;

    /// <include file='CSIDL.xml' path='doc/member[@name="CSIDL.CSIDL_COMMON_PICTURES"]/*' />
    [NativeTypeName("#define CSIDL_COMMON_PICTURES 0x0036")]
    public const int CSIDL_COMMON_PICTURES = 0x0036;

    /// <include file='CSIDL.xml' path='doc/member[@name="CSIDL.CSIDL_COMMON_VIDEO"]/*' />
    [NativeTypeName("#define CSIDL_COMMON_VIDEO 0x0037")]
    public const int CSIDL_COMMON_VIDEO = 0x0037;

    /// <include file='CSIDL.xml' path='doc/member[@name="CSIDL.CSIDL_RESOURCES"]/*' />
    [NativeTypeName("#define CSIDL_RESOURCES 0x0038")]
    public const int CSIDL_RESOURCES = 0x0038;

    /// <include file='CSIDL.xml' path='doc/member[@name="CSIDL.CSIDL_RESOURCES_LOCALIZED"]/*' />
    [NativeTypeName("#define CSIDL_RESOURCES_LOCALIZED 0x0039")]
    public const int CSIDL_RESOURCES_LOCALIZED = 0x0039;

    /// <include file='CSIDL.xml' path='doc/member[@name="CSIDL.CSIDL_COMMON_OEM_LINKS"]/*' />
    [NativeTypeName("#define CSIDL_COMMON_OEM_LINKS 0x003a")]
    public const int CSIDL_COMMON_OEM_LINKS = 0x003a;

    /// <include file='CSIDL.xml' path='doc/member[@name="CSIDL.CSIDL_CDBURN_AREA"]/*' />
    [NativeTypeName("#define CSIDL_CDBURN_AREA 0x003b")]
    public const int CSIDL_CDBURN_AREA = 0x003b;

    /// <include file='CSIDL.xml' path='doc/member[@name="CSIDL.CSIDL_COMPUTERSNEARME"]/*' />
    [NativeTypeName("#define CSIDL_COMPUTERSNEARME 0x003d")]
    public const int CSIDL_COMPUTERSNEARME = 0x003d;

    /// <include file='CSIDL.xml' path='doc/member[@name="CSIDL.CSIDL_FLAG_CREATE"]/*' />
    [NativeTypeName("#define CSIDL_FLAG_CREATE 0x8000")]
    public const int CSIDL_FLAG_CREATE = 0x8000;

    /// <include file='CSIDL.xml' path='doc/member[@name="CSIDL.CSIDL_FLAG_DONT_VERIFY"]/*' />
    [NativeTypeName("#define CSIDL_FLAG_DONT_VERIFY 0x4000")]
    public const int CSIDL_FLAG_DONT_VERIFY = 0x4000;

    /// <include file='CSIDL.xml' path='doc/member[@name="CSIDL.CSIDL_FLAG_DONT_UNEXPAND"]/*' />
    [NativeTypeName("#define CSIDL_FLAG_DONT_UNEXPAND 0x2000")]
    public const int CSIDL_FLAG_DONT_UNEXPAND = 0x2000;

    /// <include file='CSIDL.xml' path='doc/member[@name="CSIDL.CSIDL_FLAG_NO_ALIAS"]/*' />
    [NativeTypeName("#define CSIDL_FLAG_NO_ALIAS 0x1000")]
    public const int CSIDL_FLAG_NO_ALIAS = 0x1000;

    /// <include file='CSIDL.xml' path='doc/member[@name="CSIDL.CSIDL_FLAG_PER_USER_INIT"]/*' />
    [NativeTypeName("#define CSIDL_FLAG_PER_USER_INIT 0x0800")]
    public const int CSIDL_FLAG_PER_USER_INIT = 0x0800;

    /// <include file='CSIDL.xml' path='doc/member[@name="CSIDL.CSIDL_FLAG_MASK"]/*' />
    [NativeTypeName("#define CSIDL_FLAG_MASK 0xFF00")]
    public const int CSIDL_FLAG_MASK = 0xFF00;
}
