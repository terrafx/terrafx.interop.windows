// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/verrsrc.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static unsafe partial class Windows
{
    /// <include file='Windows.xml' path='doc/member[@name="Windows.VS_FILE_INFO"]/*' />
    [NativeTypeName("#define VS_FILE_INFO RT_VERSION")]
    public static char* VS_FILE_INFO => ((char*)((nuint)((ushort)(16))));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.VS_VERSION_INFO"]/*' />
    [NativeTypeName("#define VS_VERSION_INFO 1")]
    public const int VS_VERSION_INFO = 1;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.VS_USER_DEFINED"]/*' />
    [NativeTypeName("#define VS_USER_DEFINED 100")]
    public const int VS_USER_DEFINED = 100;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.VS_FFI_SIGNATURE"]/*' />
    [NativeTypeName("#define VS_FFI_SIGNATURE 0xFEEF04BDL")]
    public const uint VS_FFI_SIGNATURE = 0xFEEF04BD;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.VS_FFI_STRUCVERSION"]/*' />
    [NativeTypeName("#define VS_FFI_STRUCVERSION 0x00010000L")]
    public const int VS_FFI_STRUCVERSION = 0x00010000;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.VS_FFI_FILEFLAGSMASK"]/*' />
    [NativeTypeName("#define VS_FFI_FILEFLAGSMASK 0x0000003FL")]
    public const int VS_FFI_FILEFLAGSMASK = 0x0000003F;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.VS_FF_DEBUG"]/*' />
    [NativeTypeName("#define VS_FF_DEBUG 0x00000001L")]
    public const int VS_FF_DEBUG = 0x00000001;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.VS_FF_PRERELEASE"]/*' />
    [NativeTypeName("#define VS_FF_PRERELEASE 0x00000002L")]
    public const int VS_FF_PRERELEASE = 0x00000002;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.VS_FF_PATCHED"]/*' />
    [NativeTypeName("#define VS_FF_PATCHED 0x00000004L")]
    public const int VS_FF_PATCHED = 0x00000004;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.VS_FF_PRIVATEBUILD"]/*' />
    [NativeTypeName("#define VS_FF_PRIVATEBUILD 0x00000008L")]
    public const int VS_FF_PRIVATEBUILD = 0x00000008;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.VS_FF_INFOINFERRED"]/*' />
    [NativeTypeName("#define VS_FF_INFOINFERRED 0x00000010L")]
    public const int VS_FF_INFOINFERRED = 0x00000010;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.VS_FF_SPECIALBUILD"]/*' />
    [NativeTypeName("#define VS_FF_SPECIALBUILD 0x00000020L")]
    public const int VS_FF_SPECIALBUILD = 0x00000020;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.VOS_UNKNOWN"]/*' />
    [NativeTypeName("#define VOS_UNKNOWN 0x00000000L")]
    public const int VOS_UNKNOWN = 0x00000000;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.VOS_DOS"]/*' />
    [NativeTypeName("#define VOS_DOS 0x00010000L")]
    public const int VOS_DOS = 0x00010000;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.VOS_OS216"]/*' />
    [NativeTypeName("#define VOS_OS216 0x00020000L")]
    public const int VOS_OS216 = 0x00020000;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.VOS_OS232"]/*' />
    [NativeTypeName("#define VOS_OS232 0x00030000L")]
    public const int VOS_OS232 = 0x00030000;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.VOS_NT"]/*' />
    [NativeTypeName("#define VOS_NT 0x00040000L")]
    public const int VOS_NT = 0x00040000;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.VOS_WINCE"]/*' />
    [NativeTypeName("#define VOS_WINCE 0x00050000L")]
    public const int VOS_WINCE = 0x00050000;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.VOS__BASE"]/*' />
    [NativeTypeName("#define VOS__BASE 0x00000000L")]
    public const int VOS__BASE = 0x00000000;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.VOS__WINDOWS16"]/*' />
    [NativeTypeName("#define VOS__WINDOWS16 0x00000001L")]
    public const int VOS__WINDOWS16 = 0x00000001;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.VOS__PM16"]/*' />
    [NativeTypeName("#define VOS__PM16 0x00000002L")]
    public const int VOS__PM16 = 0x00000002;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.VOS__PM32"]/*' />
    [NativeTypeName("#define VOS__PM32 0x00000003L")]
    public const int VOS__PM32 = 0x00000003;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.VOS__WINDOWS32"]/*' />
    [NativeTypeName("#define VOS__WINDOWS32 0x00000004L")]
    public const int VOS__WINDOWS32 = 0x00000004;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.VOS_DOS_WINDOWS16"]/*' />
    [NativeTypeName("#define VOS_DOS_WINDOWS16 0x00010001L")]
    public const int VOS_DOS_WINDOWS16 = 0x00010001;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.VOS_DOS_WINDOWS32"]/*' />
    [NativeTypeName("#define VOS_DOS_WINDOWS32 0x00010004L")]
    public const int VOS_DOS_WINDOWS32 = 0x00010004;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.VOS_OS216_PM16"]/*' />
    [NativeTypeName("#define VOS_OS216_PM16 0x00020002L")]
    public const int VOS_OS216_PM16 = 0x00020002;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.VOS_OS232_PM32"]/*' />
    [NativeTypeName("#define VOS_OS232_PM32 0x00030003L")]
    public const int VOS_OS232_PM32 = 0x00030003;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.VOS_NT_WINDOWS32"]/*' />
    [NativeTypeName("#define VOS_NT_WINDOWS32 0x00040004L")]
    public const int VOS_NT_WINDOWS32 = 0x00040004;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.VFT_UNKNOWN"]/*' />
    [NativeTypeName("#define VFT_UNKNOWN 0x00000000L")]
    public const int VFT_UNKNOWN = 0x00000000;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.VFT_APP"]/*' />
    [NativeTypeName("#define VFT_APP 0x00000001L")]
    public const int VFT_APP = 0x00000001;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.VFT_DLL"]/*' />
    [NativeTypeName("#define VFT_DLL 0x00000002L")]
    public const int VFT_DLL = 0x00000002;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.VFT_DRV"]/*' />
    [NativeTypeName("#define VFT_DRV 0x00000003L")]
    public const int VFT_DRV = 0x00000003;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.VFT_FONT"]/*' />
    [NativeTypeName("#define VFT_FONT 0x00000004L")]
    public const int VFT_FONT = 0x00000004;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.VFT_VXD"]/*' />
    [NativeTypeName("#define VFT_VXD 0x00000005L")]
    public const int VFT_VXD = 0x00000005;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.VFT_STATIC_LIB"]/*' />
    [NativeTypeName("#define VFT_STATIC_LIB 0x00000007L")]
    public const int VFT_STATIC_LIB = 0x00000007;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.VFT2_UNKNOWN"]/*' />
    [NativeTypeName("#define VFT2_UNKNOWN 0x00000000L")]
    public const int VFT2_UNKNOWN = 0x00000000;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.VFT2_DRV_PRINTER"]/*' />
    [NativeTypeName("#define VFT2_DRV_PRINTER 0x00000001L")]
    public const int VFT2_DRV_PRINTER = 0x00000001;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.VFT2_DRV_KEYBOARD"]/*' />
    [NativeTypeName("#define VFT2_DRV_KEYBOARD 0x00000002L")]
    public const int VFT2_DRV_KEYBOARD = 0x00000002;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.VFT2_DRV_LANGUAGE"]/*' />
    [NativeTypeName("#define VFT2_DRV_LANGUAGE 0x00000003L")]
    public const int VFT2_DRV_LANGUAGE = 0x00000003;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.VFT2_DRV_DISPLAY"]/*' />
    [NativeTypeName("#define VFT2_DRV_DISPLAY 0x00000004L")]
    public const int VFT2_DRV_DISPLAY = 0x00000004;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.VFT2_DRV_MOUSE"]/*' />
    [NativeTypeName("#define VFT2_DRV_MOUSE 0x00000005L")]
    public const int VFT2_DRV_MOUSE = 0x00000005;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.VFT2_DRV_NETWORK"]/*' />
    [NativeTypeName("#define VFT2_DRV_NETWORK 0x00000006L")]
    public const int VFT2_DRV_NETWORK = 0x00000006;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.VFT2_DRV_SYSTEM"]/*' />
    [NativeTypeName("#define VFT2_DRV_SYSTEM 0x00000007L")]
    public const int VFT2_DRV_SYSTEM = 0x00000007;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.VFT2_DRV_INSTALLABLE"]/*' />
    [NativeTypeName("#define VFT2_DRV_INSTALLABLE 0x00000008L")]
    public const int VFT2_DRV_INSTALLABLE = 0x00000008;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.VFT2_DRV_SOUND"]/*' />
    [NativeTypeName("#define VFT2_DRV_SOUND 0x00000009L")]
    public const int VFT2_DRV_SOUND = 0x00000009;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.VFT2_DRV_COMM"]/*' />
    [NativeTypeName("#define VFT2_DRV_COMM 0x0000000AL")]
    public const int VFT2_DRV_COMM = 0x0000000A;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.VFT2_DRV_INPUTMETHOD"]/*' />
    [NativeTypeName("#define VFT2_DRV_INPUTMETHOD 0x0000000BL")]
    public const int VFT2_DRV_INPUTMETHOD = 0x0000000B;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.VFT2_DRV_VERSIONED_PRINTER"]/*' />
    [NativeTypeName("#define VFT2_DRV_VERSIONED_PRINTER 0x0000000CL")]
    public const int VFT2_DRV_VERSIONED_PRINTER = 0x0000000C;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.VFT2_FONT_RASTER"]/*' />
    [NativeTypeName("#define VFT2_FONT_RASTER 0x00000001L")]
    public const int VFT2_FONT_RASTER = 0x00000001;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.VFT2_FONT_VECTOR"]/*' />
    [NativeTypeName("#define VFT2_FONT_VECTOR 0x00000002L")]
    public const int VFT2_FONT_VECTOR = 0x00000002;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.VFT2_FONT_TRUETYPE"]/*' />
    [NativeTypeName("#define VFT2_FONT_TRUETYPE 0x00000003L")]
    public const int VFT2_FONT_TRUETYPE = 0x00000003;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.VFFF_ISSHAREDFILE"]/*' />
    [NativeTypeName("#define VFFF_ISSHAREDFILE 0x0001")]
    public const int VFFF_ISSHAREDFILE = 0x0001;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.VFF_CURNEDEST"]/*' />
    [NativeTypeName("#define VFF_CURNEDEST 0x0001")]
    public const int VFF_CURNEDEST = 0x0001;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.VFF_FILEINUSE"]/*' />
    [NativeTypeName("#define VFF_FILEINUSE 0x0002")]
    public const int VFF_FILEINUSE = 0x0002;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.VFF_BUFFTOOSMALL"]/*' />
    [NativeTypeName("#define VFF_BUFFTOOSMALL 0x0004")]
    public const int VFF_BUFFTOOSMALL = 0x0004;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.VIFF_FORCEINSTALL"]/*' />
    [NativeTypeName("#define VIFF_FORCEINSTALL 0x0001")]
    public const int VIFF_FORCEINSTALL = 0x0001;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.VIFF_DONTDELETEOLD"]/*' />
    [NativeTypeName("#define VIFF_DONTDELETEOLD 0x0002")]
    public const int VIFF_DONTDELETEOLD = 0x0002;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.VIF_TEMPFILE"]/*' />
    [NativeTypeName("#define VIF_TEMPFILE 0x00000001L")]
    public const int VIF_TEMPFILE = 0x00000001;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.VIF_MISMATCH"]/*' />
    [NativeTypeName("#define VIF_MISMATCH 0x00000002L")]
    public const int VIF_MISMATCH = 0x00000002;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.VIF_SRCOLD"]/*' />
    [NativeTypeName("#define VIF_SRCOLD 0x00000004L")]
    public const int VIF_SRCOLD = 0x00000004;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.VIF_DIFFLANG"]/*' />
    [NativeTypeName("#define VIF_DIFFLANG 0x00000008L")]
    public const int VIF_DIFFLANG = 0x00000008;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.VIF_DIFFCODEPG"]/*' />
    [NativeTypeName("#define VIF_DIFFCODEPG 0x00000010L")]
    public const int VIF_DIFFCODEPG = 0x00000010;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.VIF_DIFFTYPE"]/*' />
    [NativeTypeName("#define VIF_DIFFTYPE 0x00000020L")]
    public const int VIF_DIFFTYPE = 0x00000020;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.VIF_WRITEPROT"]/*' />
    [NativeTypeName("#define VIF_WRITEPROT 0x00000040L")]
    public const int VIF_WRITEPROT = 0x00000040;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.VIF_FILEINUSE"]/*' />
    [NativeTypeName("#define VIF_FILEINUSE 0x00000080L")]
    public const int VIF_FILEINUSE = 0x00000080;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.VIF_OUTOFSPACE"]/*' />
    [NativeTypeName("#define VIF_OUTOFSPACE 0x00000100L")]
    public const int VIF_OUTOFSPACE = 0x00000100;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.VIF_ACCESSVIOLATION"]/*' />
    [NativeTypeName("#define VIF_ACCESSVIOLATION 0x00000200L")]
    public const int VIF_ACCESSVIOLATION = 0x00000200;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.VIF_SHARINGVIOLATION"]/*' />
    [NativeTypeName("#define VIF_SHARINGVIOLATION 0x00000400L")]
    public const int VIF_SHARINGVIOLATION = 0x00000400;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.VIF_CANNOTCREATE"]/*' />
    [NativeTypeName("#define VIF_CANNOTCREATE 0x00000800L")]
    public const int VIF_CANNOTCREATE = 0x00000800;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.VIF_CANNOTDELETE"]/*' />
    [NativeTypeName("#define VIF_CANNOTDELETE 0x00001000L")]
    public const int VIF_CANNOTDELETE = 0x00001000;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.VIF_CANNOTRENAME"]/*' />
    [NativeTypeName("#define VIF_CANNOTRENAME 0x00002000L")]
    public const int VIF_CANNOTRENAME = 0x00002000;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.VIF_CANNOTDELETECUR"]/*' />
    [NativeTypeName("#define VIF_CANNOTDELETECUR 0x00004000L")]
    public const int VIF_CANNOTDELETECUR = 0x00004000;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.VIF_OUTOFMEMORY"]/*' />
    [NativeTypeName("#define VIF_OUTOFMEMORY 0x00008000L")]
    public const int VIF_OUTOFMEMORY = 0x00008000;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.VIF_CANNOTREADSRC"]/*' />
    [NativeTypeName("#define VIF_CANNOTREADSRC 0x00010000L")]
    public const int VIF_CANNOTREADSRC = 0x00010000;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.VIF_CANNOTREADDST"]/*' />
    [NativeTypeName("#define VIF_CANNOTREADDST 0x00020000L")]
    public const int VIF_CANNOTREADDST = 0x00020000;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.VIF_BUFFTOOSMALL"]/*' />
    [NativeTypeName("#define VIF_BUFFTOOSMALL 0x00040000L")]
    public const int VIF_BUFFTOOSMALL = 0x00040000;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.VIF_CANNOTLOADLZ32"]/*' />
    [NativeTypeName("#define VIF_CANNOTLOADLZ32 0x00080000L")]
    public const int VIF_CANNOTLOADLZ32 = 0x00080000;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.VIF_CANNOTLOADCABINET"]/*' />
    [NativeTypeName("#define VIF_CANNOTLOADCABINET 0x00100000L")]
    public const int VIF_CANNOTLOADCABINET = 0x00100000;
}
