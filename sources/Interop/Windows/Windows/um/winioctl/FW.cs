// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class FW
{
    /// <include file='FW.xml' path='doc/member[@name="FW.FW_ISSUEID_NO_ISSUE"]/*' />
    [NativeTypeName("#define FW_ISSUEID_NO_ISSUE 0x00000000")]
    public const int FW_ISSUEID_NO_ISSUE = 0x00000000;

    /// <include file='FW.xml' path='doc/member[@name="FW.FW_ISSUEID_UNKNOWN"]/*' />
    [NativeTypeName("#define FW_ISSUEID_UNKNOWN 0xFFFFFFFF")]
    public const uint FW_ISSUEID_UNKNOWN = 0xFFFFFFFF;
}
