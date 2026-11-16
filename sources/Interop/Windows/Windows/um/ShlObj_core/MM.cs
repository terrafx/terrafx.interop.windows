// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShlObj_core.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class MM
{
    /// <include file='MM.xml' path='doc/member[@name="MM.MM_ADDSEPARATOR"]/*' />
    [NativeTypeName("#define MM_ADDSEPARATOR 0x00000001L")]
    public const int MM_ADDSEPARATOR = 0x00000001;

    /// <include file='MM.xml' path='doc/member[@name="MM.MM_SUBMENUSHAVEIDS"]/*' />
    [NativeTypeName("#define MM_SUBMENUSHAVEIDS 0x00000002L")]
    public const int MM_SUBMENUSHAVEIDS = 0x00000002;

    /// <include file='MM.xml' path='doc/member[@name="MM.MM_DONTREMOVESEPS"]/*' />
    [NativeTypeName("#define MM_DONTREMOVESEPS 0x00000004L")]
    public const int MM_DONTREMOVESEPS = 0x00000004;
}
