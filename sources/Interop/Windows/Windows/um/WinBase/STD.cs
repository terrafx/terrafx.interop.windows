// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinBase.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class STD
{
    /// <include file='STD.xml' path='doc/member[@name="STD.STD_INPUT_HANDLE"]/*' />
    [NativeTypeName("#define STD_INPUT_HANDLE ((DWORD)-10)")]
    public const uint STD_INPUT_HANDLE = unchecked((uint)(-10));

    /// <include file='STD.xml' path='doc/member[@name="STD.STD_OUTPUT_HANDLE"]/*' />
    [NativeTypeName("#define STD_OUTPUT_HANDLE ((DWORD)-11)")]
    public const uint STD_OUTPUT_HANDLE = unchecked((uint)(-11));

    /// <include file='STD.xml' path='doc/member[@name="STD.STD_ERROR_HANDLE"]/*' />
    [NativeTypeName("#define STD_ERROR_HANDLE ((DWORD)-12)")]
    public const uint STD_ERROR_HANDLE = unchecked((uint)(-12));
}
