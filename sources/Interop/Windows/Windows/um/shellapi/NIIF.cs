// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/shellapi.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class NIIF
{
    /// <include file='NIIF.xml' path='doc/member[@name="NIIF.NIIF_NONE"]/*' />
    [NativeTypeName("#define NIIF_NONE 0x00000000")]
    public const int NIIF_NONE = 0x00000000;

    /// <include file='NIIF.xml' path='doc/member[@name="NIIF.NIIF_INFO"]/*' />
    [NativeTypeName("#define NIIF_INFO 0x00000001")]
    public const int NIIF_INFO = 0x00000001;

    /// <include file='NIIF.xml' path='doc/member[@name="NIIF.NIIF_WARNING"]/*' />
    [NativeTypeName("#define NIIF_WARNING 0x00000002")]
    public const int NIIF_WARNING = 0x00000002;

    /// <include file='NIIF.xml' path='doc/member[@name="NIIF.NIIF_ERROR"]/*' />
    [NativeTypeName("#define NIIF_ERROR 0x00000003")]
    public const int NIIF_ERROR = 0x00000003;

    /// <include file='NIIF.xml' path='doc/member[@name="NIIF.NIIF_USER"]/*' />
    [NativeTypeName("#define NIIF_USER 0x00000004")]
    public const int NIIF_USER = 0x00000004;

    /// <include file='NIIF.xml' path='doc/member[@name="NIIF.NIIF_ICON_MASK"]/*' />
    [NativeTypeName("#define NIIF_ICON_MASK 0x0000000F")]
    public const int NIIF_ICON_MASK = 0x0000000F;

    /// <include file='NIIF.xml' path='doc/member[@name="NIIF.NIIF_NOSOUND"]/*' />
    [NativeTypeName("#define NIIF_NOSOUND 0x00000010")]
    public const int NIIF_NOSOUND = 0x00000010;

    /// <include file='NIIF.xml' path='doc/member[@name="NIIF.NIIF_LARGE_ICON"]/*' />
    [NativeTypeName("#define NIIF_LARGE_ICON 0x00000020")]
    public const int NIIF_LARGE_ICON = 0x00000020;

    /// <include file='NIIF.xml' path='doc/member[@name="NIIF.NIIF_RESPECT_QUIET_TIME"]/*' />
    [NativeTypeName("#define NIIF_RESPECT_QUIET_TIME 0x00000080")]
    public const int NIIF_RESPECT_QUIET_TIME = 0x00000080;
}
