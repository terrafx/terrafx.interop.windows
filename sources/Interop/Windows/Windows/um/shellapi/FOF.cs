// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/shellapi.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class FOF
{
    /// <include file='FOF.xml' path='doc/member[@name="FOF.FOF_MULTIDESTFILES"]/*' />
    [NativeTypeName("#define FOF_MULTIDESTFILES 0x0001")]
    public const int FOF_MULTIDESTFILES = 0x0001;

    /// <include file='FOF.xml' path='doc/member[@name="FOF.FOF_CONFIRMMOUSE"]/*' />
    [NativeTypeName("#define FOF_CONFIRMMOUSE 0x0002")]
    public const int FOF_CONFIRMMOUSE = 0x0002;

    /// <include file='FOF.xml' path='doc/member[@name="FOF.FOF_SILENT"]/*' />
    [NativeTypeName("#define FOF_SILENT 0x0004")]
    public const int FOF_SILENT = 0x0004;

    /// <include file='FOF.xml' path='doc/member[@name="FOF.FOF_RENAMEONCOLLISION"]/*' />
    [NativeTypeName("#define FOF_RENAMEONCOLLISION 0x0008")]
    public const int FOF_RENAMEONCOLLISION = 0x0008;

    /// <include file='FOF.xml' path='doc/member[@name="FOF.FOF_NOCONFIRMATION"]/*' />
    [NativeTypeName("#define FOF_NOCONFIRMATION 0x0010")]
    public const int FOF_NOCONFIRMATION = 0x0010;

    /// <include file='FOF.xml' path='doc/member[@name="FOF.FOF_WANTMAPPINGHANDLE"]/*' />
    [NativeTypeName("#define FOF_WANTMAPPINGHANDLE 0x0020")]
    public const int FOF_WANTMAPPINGHANDLE = 0x0020;

    /// <include file='FOF.xml' path='doc/member[@name="FOF.FOF_ALLOWUNDO"]/*' />
    [NativeTypeName("#define FOF_ALLOWUNDO 0x0040")]
    public const int FOF_ALLOWUNDO = 0x0040;

    /// <include file='FOF.xml' path='doc/member[@name="FOF.FOF_FILESONLY"]/*' />
    [NativeTypeName("#define FOF_FILESONLY 0x0080")]
    public const int FOF_FILESONLY = 0x0080;

    /// <include file='FOF.xml' path='doc/member[@name="FOF.FOF_SIMPLEPROGRESS"]/*' />
    [NativeTypeName("#define FOF_SIMPLEPROGRESS 0x0100")]
    public const int FOF_SIMPLEPROGRESS = 0x0100;

    /// <include file='FOF.xml' path='doc/member[@name="FOF.FOF_NOCONFIRMMKDIR"]/*' />
    [NativeTypeName("#define FOF_NOCONFIRMMKDIR 0x0200")]
    public const int FOF_NOCONFIRMMKDIR = 0x0200;

    /// <include file='FOF.xml' path='doc/member[@name="FOF.FOF_NOERRORUI"]/*' />
    [NativeTypeName("#define FOF_NOERRORUI 0x0400")]
    public const int FOF_NOERRORUI = 0x0400;

    /// <include file='FOF.xml' path='doc/member[@name="FOF.FOF_NOCOPYSECURITYATTRIBS"]/*' />
    [NativeTypeName("#define FOF_NOCOPYSECURITYATTRIBS 0x0800")]
    public const int FOF_NOCOPYSECURITYATTRIBS = 0x0800;

    /// <include file='FOF.xml' path='doc/member[@name="FOF.FOF_NORECURSION"]/*' />
    [NativeTypeName("#define FOF_NORECURSION 0x1000")]
    public const int FOF_NORECURSION = 0x1000;

    /// <include file='FOF.xml' path='doc/member[@name="FOF.FOF_NO_CONNECTED_ELEMENTS"]/*' />
    [NativeTypeName("#define FOF_NO_CONNECTED_ELEMENTS 0x2000")]
    public const int FOF_NO_CONNECTED_ELEMENTS = 0x2000;

    /// <include file='FOF.xml' path='doc/member[@name="FOF.FOF_WANTNUKEWARNING"]/*' />
    [NativeTypeName("#define FOF_WANTNUKEWARNING 0x4000")]
    public const int FOF_WANTNUKEWARNING = 0x4000;

    /// <include file='FOF.xml' path='doc/member[@name="FOF.FOF_NORECURSEREPARSE"]/*' />
    [NativeTypeName("#define FOF_NORECURSEREPARSE 0x8000")]
    public const int FOF_NORECURSEREPARSE = 0x8000;

    /// <include file='FOF.xml' path='doc/member[@name="FOF.FOF_NO_UI"]/*' />
    [NativeTypeName("#define FOF_NO_UI (FOF_SILENT | FOF_NOCONFIRMATION | FOF_NOERRORUI | FOF_NOCONFIRMMKDIR)")]
    public const int FOF_NO_UI = (0x0004 | 0x0010 | 0x0400 | 0x0200);
}
