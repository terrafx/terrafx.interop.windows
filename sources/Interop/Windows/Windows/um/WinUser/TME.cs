// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class TME
{
    /// <include file='TME.xml' path='doc/member[@name="TME.TME_HOVER"]/*' />
    [NativeTypeName("#define TME_HOVER 0x00000001")]
    public const int TME_HOVER = 0x00000001;

    /// <include file='TME.xml' path='doc/member[@name="TME.TME_LEAVE"]/*' />
    [NativeTypeName("#define TME_LEAVE 0x00000002")]
    public const int TME_LEAVE = 0x00000002;

    /// <include file='TME.xml' path='doc/member[@name="TME.TME_NONCLIENT"]/*' />
    [NativeTypeName("#define TME_NONCLIENT 0x00000010")]
    public const int TME_NONCLIENT = 0x00000010;

    /// <include file='TME.xml' path='doc/member[@name="TME.TME_QUERY"]/*' />
    [NativeTypeName("#define TME_QUERY 0x40000000")]
    public const int TME_QUERY = 0x40000000;

    /// <include file='TME.xml' path='doc/member[@name="TME.TME_CANCEL"]/*' />
    [NativeTypeName("#define TME_CANCEL 0x80000000")]
    public const uint TME_CANCEL = 0x80000000;
}
