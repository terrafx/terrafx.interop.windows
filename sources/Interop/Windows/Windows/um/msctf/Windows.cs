// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msctf.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class Windows
{
    /// <include file='Windows.xml' path='doc/member[@name="Windows.TKB_ALTERNATES_STANDARD"]/*' />
    [NativeTypeName("#define TKB_ALTERNATES_STANDARD 0x00000001")]
    public const int TKB_ALTERNATES_STANDARD = 0x00000001;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.TKB_ALTERNATES_FOR_AUTOCORRECTION"]/*' />
    [NativeTypeName("#define TKB_ALTERNATES_FOR_AUTOCORRECTION 0x00000002")]
    public const int TKB_ALTERNATES_FOR_AUTOCORRECTION = 0x00000002;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.TKB_ALTERNATES_FOR_PREDICTION"]/*' />
    [NativeTypeName("#define TKB_ALTERNATES_FOR_PREDICTION 0x00000003")]
    public const int TKB_ALTERNATES_FOR_PREDICTION = 0x00000003;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.TKB_ALTERNATES_AUTOCORRECTION_APPLIED"]/*' />
    [NativeTypeName("#define TKB_ALTERNATES_AUTOCORRECTION_APPLIED 0x00000004")]
    public const int TKB_ALTERNATES_AUTOCORRECTION_APPLIED = 0x00000004;
}
