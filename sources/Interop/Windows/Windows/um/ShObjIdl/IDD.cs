// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class IDD
{
    /// <include file='IDD.xml' path='doc/member[@name="IDD.IDD_WIZEXTN_FIRST"]/*' />
    [NativeTypeName("#define IDD_WIZEXTN_FIRST 0x5000")]
    public const int IDD_WIZEXTN_FIRST = 0x5000;

    /// <include file='IDD.xml' path='doc/member[@name="IDD.IDD_WIZEXTN_LAST"]/*' />
    [NativeTypeName("#define IDD_WIZEXTN_LAST 0x5100")]
    public const int IDD_WIZEXTN_LAST = 0x5100;
}
