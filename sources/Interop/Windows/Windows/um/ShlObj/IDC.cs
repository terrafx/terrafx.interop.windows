// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShlObj.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class IDC
{
    /// <include file='IDC.xml' path='doc/member[@name="IDC.IDC_OFFLINE_HAND"]/*' />
    [NativeTypeName("#define IDC_OFFLINE_HAND 103")]
    public const int IDC_OFFLINE_HAND = 103;

    /// <include file='IDC.xml' path='doc/member[@name="IDC.IDC_PANTOOL_HAND_OPEN"]/*' />
    [NativeTypeName("#define IDC_PANTOOL_HAND_OPEN 104")]
    public const int IDC_PANTOOL_HAND_OPEN = 104;

    /// <include file='IDC.xml' path='doc/member[@name="IDC.IDC_PANTOOL_HAND_CLOSED"]/*' />
    [NativeTypeName("#define IDC_PANTOOL_HAND_CLOSED 105")]
    public const int IDC_PANTOOL_HAND_CLOSED = 105;
}
