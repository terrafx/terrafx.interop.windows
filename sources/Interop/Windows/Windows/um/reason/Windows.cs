// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/reason.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class Windows
{
    /// <include file='Windows.xml' path='doc/member[@name="Windows.PCLEANUI"]/*' />
    [NativeTypeName("#define PCLEANUI (SHTDN_REASON_FLAG_PLANNED | SHTDN_REASON_FLAG_CLEAN_UI)")]
    public const uint PCLEANUI = (0x80000000 | 0x04000000);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UCLEANUI"]/*' />
    [NativeTypeName("#define UCLEANUI (SHTDN_REASON_FLAG_CLEAN_UI)")]
    public const int UCLEANUI = (0x04000000);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PDIRTYUI"]/*' />
    [NativeTypeName("#define PDIRTYUI (SHTDN_REASON_FLAG_PLANNED | SHTDN_REASON_FLAG_DIRTY_UI)")]
    public const uint PDIRTYUI = (0x80000000 | 0x08000000);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UDIRTYUI"]/*' />
    [NativeTypeName("#define UDIRTYUI (SHTDN_REASON_FLAG_DIRTY_UI)")]
    public const int UDIRTYUI = (0x08000000);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SNAPSHOT_POLICY_NEVER"]/*' />
    [NativeTypeName("#define SNAPSHOT_POLICY_NEVER 0")]
    public const int SNAPSHOT_POLICY_NEVER = 0;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SNAPSHOT_POLICY_ALWAYS"]/*' />
    [NativeTypeName("#define SNAPSHOT_POLICY_ALWAYS 1")]
    public const int SNAPSHOT_POLICY_ALWAYS = 1;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SNAPSHOT_POLICY_UNPLANNED"]/*' />
    [NativeTypeName("#define SNAPSHOT_POLICY_UNPLANNED 2")]
    public const int SNAPSHOT_POLICY_UNPLANNED = 2;
}
