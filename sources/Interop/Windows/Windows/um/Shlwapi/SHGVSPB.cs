// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Shlwapi.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class SHGVSPB
{
    /// <include file='SHGVSPB.xml' path='doc/member[@name="SHGVSPB.SHGVSPB_PERUSER"]/*' />
    [NativeTypeName("#define SHGVSPB_PERUSER 0x00000001")]
    public const int SHGVSPB_PERUSER = 0x00000001;

    /// <include file='SHGVSPB.xml' path='doc/member[@name="SHGVSPB.SHGVSPB_ALLUSERS"]/*' />
    [NativeTypeName("#define SHGVSPB_ALLUSERS 0x00000002")]
    public const int SHGVSPB_ALLUSERS = 0x00000002;

    /// <include file='SHGVSPB.xml' path='doc/member[@name="SHGVSPB.SHGVSPB_PERFOLDER"]/*' />
    [NativeTypeName("#define SHGVSPB_PERFOLDER 0x00000004")]
    public const int SHGVSPB_PERFOLDER = 0x00000004;

    /// <include file='SHGVSPB.xml' path='doc/member[@name="SHGVSPB.SHGVSPB_ALLFOLDERS"]/*' />
    [NativeTypeName("#define SHGVSPB_ALLFOLDERS 0x00000008")]
    public const int SHGVSPB_ALLFOLDERS = 0x00000008;

    /// <include file='SHGVSPB.xml' path='doc/member[@name="SHGVSPB.SHGVSPB_INHERIT"]/*' />
    [NativeTypeName("#define SHGVSPB_INHERIT 0x00000010")]
    public const int SHGVSPB_INHERIT = 0x00000010;

    /// <include file='SHGVSPB.xml' path='doc/member[@name="SHGVSPB.SHGVSPB_ROAM"]/*' />
    [NativeTypeName("#define SHGVSPB_ROAM 0x00000020")]
    public const int SHGVSPB_ROAM = 0x00000020;

    /// <include file='SHGVSPB.xml' path='doc/member[@name="SHGVSPB.SHGVSPB_NOAUTODEFAULTS"]/*' />
    [NativeTypeName("#define SHGVSPB_NOAUTODEFAULTS 0x80000000")]
    public const uint SHGVSPB_NOAUTODEFAULTS = 0x80000000;

    /// <include file='SHGVSPB.xml' path='doc/member[@name="SHGVSPB.SHGVSPB_FOLDER"]/*' />
    [NativeTypeName("#define SHGVSPB_FOLDER (SHGVSPB_PERUSER | SHGVSPB_PERFOLDER)")]
    public const int SHGVSPB_FOLDER = (0x00000001 | 0x00000004);

    /// <include file='SHGVSPB.xml' path='doc/member[@name="SHGVSPB.SHGVSPB_FOLDERNODEFAULTS"]/*' />
    [NativeTypeName("#define SHGVSPB_FOLDERNODEFAULTS (SHGVSPB_PERUSER | SHGVSPB_PERFOLDER | SHGVSPB_NOAUTODEFAULTS)")]
    public const uint SHGVSPB_FOLDERNODEFAULTS = (0x00000001 | 0x00000004 | 0x80000000);

    /// <include file='SHGVSPB.xml' path='doc/member[@name="SHGVSPB.SHGVSPB_USERDEFAULTS"]/*' />
    [NativeTypeName("#define SHGVSPB_USERDEFAULTS (SHGVSPB_PERUSER | SHGVSPB_ALLFOLDERS)")]
    public const int SHGVSPB_USERDEFAULTS = (0x00000001 | 0x00000008);

    /// <include file='SHGVSPB.xml' path='doc/member[@name="SHGVSPB.SHGVSPB_GLOBALDEFAULTS"]/*' />
    [NativeTypeName("#define SHGVSPB_GLOBALDEFAULTS (SHGVSPB_ALLUSERS | SHGVSPB_ALLFOLDERS)")]
    public const int SHGVSPB_GLOBALDEFAULTS = (0x00000002 | 0x00000008);
}
