// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/shellapi.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class SHGFI
{
    /// <include file='SHGFI.xml' path='doc/member[@name="SHGFI.SHGFI_ICON"]/*' />
    [NativeTypeName("#define SHGFI_ICON 0x000000100")]
    public const int SHGFI_ICON = 0x000000100;

    /// <include file='SHGFI.xml' path='doc/member[@name="SHGFI.SHGFI_DISPLAYNAME"]/*' />
    [NativeTypeName("#define SHGFI_DISPLAYNAME 0x000000200")]
    public const int SHGFI_DISPLAYNAME = 0x000000200;

    /// <include file='SHGFI.xml' path='doc/member[@name="SHGFI.SHGFI_TYPENAME"]/*' />
    [NativeTypeName("#define SHGFI_TYPENAME 0x000000400")]
    public const int SHGFI_TYPENAME = 0x000000400;

    /// <include file='SHGFI.xml' path='doc/member[@name="SHGFI.SHGFI_ATTRIBUTES"]/*' />
    [NativeTypeName("#define SHGFI_ATTRIBUTES 0x000000800")]
    public const int SHGFI_ATTRIBUTES = 0x000000800;

    /// <include file='SHGFI.xml' path='doc/member[@name="SHGFI.SHGFI_ICONLOCATION"]/*' />
    [NativeTypeName("#define SHGFI_ICONLOCATION 0x000001000")]
    public const int SHGFI_ICONLOCATION = 0x000001000;

    /// <include file='SHGFI.xml' path='doc/member[@name="SHGFI.SHGFI_EXETYPE"]/*' />
    [NativeTypeName("#define SHGFI_EXETYPE 0x000002000")]
    public const int SHGFI_EXETYPE = 0x000002000;

    /// <include file='SHGFI.xml' path='doc/member[@name="SHGFI.SHGFI_SYSICONINDEX"]/*' />
    [NativeTypeName("#define SHGFI_SYSICONINDEX 0x000004000")]
    public const int SHGFI_SYSICONINDEX = 0x000004000;

    /// <include file='SHGFI.xml' path='doc/member[@name="SHGFI.SHGFI_LINKOVERLAY"]/*' />
    [NativeTypeName("#define SHGFI_LINKOVERLAY 0x000008000")]
    public const int SHGFI_LINKOVERLAY = 0x000008000;

    /// <include file='SHGFI.xml' path='doc/member[@name="SHGFI.SHGFI_SELECTED"]/*' />
    [NativeTypeName("#define SHGFI_SELECTED 0x000010000")]
    public const int SHGFI_SELECTED = 0x000010000;

    /// <include file='SHGFI.xml' path='doc/member[@name="SHGFI.SHGFI_ATTR_SPECIFIED"]/*' />
    [NativeTypeName("#define SHGFI_ATTR_SPECIFIED 0x000020000")]
    public const int SHGFI_ATTR_SPECIFIED = 0x000020000;

    /// <include file='SHGFI.xml' path='doc/member[@name="SHGFI.SHGFI_LARGEICON"]/*' />
    [NativeTypeName("#define SHGFI_LARGEICON 0x000000000")]
    public const int SHGFI_LARGEICON = 0x000000000;

    /// <include file='SHGFI.xml' path='doc/member[@name="SHGFI.SHGFI_SMALLICON"]/*' />
    [NativeTypeName("#define SHGFI_SMALLICON 0x000000001")]
    public const int SHGFI_SMALLICON = 0x000000001;

    /// <include file='SHGFI.xml' path='doc/member[@name="SHGFI.SHGFI_OPENICON"]/*' />
    [NativeTypeName("#define SHGFI_OPENICON 0x000000002")]
    public const int SHGFI_OPENICON = 0x000000002;

    /// <include file='SHGFI.xml' path='doc/member[@name="SHGFI.SHGFI_SHELLICONSIZE"]/*' />
    [NativeTypeName("#define SHGFI_SHELLICONSIZE 0x000000004")]
    public const int SHGFI_SHELLICONSIZE = 0x000000004;

    /// <include file='SHGFI.xml' path='doc/member[@name="SHGFI.SHGFI_PIDL"]/*' />
    [NativeTypeName("#define SHGFI_PIDL 0x000000008")]
    public const int SHGFI_PIDL = 0x000000008;

    /// <include file='SHGFI.xml' path='doc/member[@name="SHGFI.SHGFI_USEFILEATTRIBUTES"]/*' />
    [NativeTypeName("#define SHGFI_USEFILEATTRIBUTES 0x000000010")]
    public const int SHGFI_USEFILEATTRIBUTES = 0x000000010;

    /// <include file='SHGFI.xml' path='doc/member[@name="SHGFI.SHGFI_ADDOVERLAYS"]/*' />
    [NativeTypeName("#define SHGFI_ADDOVERLAYS 0x000000020")]
    public const int SHGFI_ADDOVERLAYS = 0x000000020;

    /// <include file='SHGFI.xml' path='doc/member[@name="SHGFI.SHGFI_OVERLAYINDEX"]/*' />
    [NativeTypeName("#define SHGFI_OVERLAYINDEX 0x000000040")]
    public const int SHGFI_OVERLAYINDEX = 0x000000040;
}
