// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinBase.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class SCS
{
    /// <include file='SCS.xml' path='doc/member[@name="SCS.SCS_32BIT_BINARY"]/*' />
    [NativeTypeName("#define SCS_32BIT_BINARY 0")]
    public const int SCS_32BIT_BINARY = 0;

    /// <include file='SCS.xml' path='doc/member[@name="SCS.SCS_DOS_BINARY"]/*' />
    [NativeTypeName("#define SCS_DOS_BINARY 1")]
    public const int SCS_DOS_BINARY = 1;

    /// <include file='SCS.xml' path='doc/member[@name="SCS.SCS_WOW_BINARY"]/*' />
    [NativeTypeName("#define SCS_WOW_BINARY 2")]
    public const int SCS_WOW_BINARY = 2;

    /// <include file='SCS.xml' path='doc/member[@name="SCS.SCS_PIF_BINARY"]/*' />
    [NativeTypeName("#define SCS_PIF_BINARY 3")]
    public const int SCS_PIF_BINARY = 3;

    /// <include file='SCS.xml' path='doc/member[@name="SCS.SCS_POSIX_BINARY"]/*' />
    [NativeTypeName("#define SCS_POSIX_BINARY 4")]
    public const int SCS_POSIX_BINARY = 4;

    /// <include file='SCS.xml' path='doc/member[@name="SCS.SCS_OS216_BINARY"]/*' />
    [NativeTypeName("#define SCS_OS216_BINARY 5")]
    public const int SCS_OS216_BINARY = 5;

    /// <include file='SCS.xml' path='doc/member[@name="SCS.SCS_64BIT_BINARY"]/*' />
    [NativeTypeName("#define SCS_64BIT_BINARY 6")]
    public const int SCS_64BIT_BINARY = 6;
}
