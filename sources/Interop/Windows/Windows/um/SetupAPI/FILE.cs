// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class FILE
{
    /// <include file='FILE.xml' path='doc/member[@name="FILE.FILE_COMPRESSION_NONE"]/*' />
    [NativeTypeName("#define FILE_COMPRESSION_NONE 0")]
    public const int FILE_COMPRESSION_NONE = 0;

    /// <include file='FILE.xml' path='doc/member[@name="FILE.FILE_COMPRESSION_WINLZA"]/*' />
    [NativeTypeName("#define FILE_COMPRESSION_WINLZA 1")]
    public const int FILE_COMPRESSION_WINLZA = 1;

    /// <include file='FILE.xml' path='doc/member[@name="FILE.FILE_COMPRESSION_MSZIP"]/*' />
    [NativeTypeName("#define FILE_COMPRESSION_MSZIP 2")]
    public const int FILE_COMPRESSION_MSZIP = 2;

    /// <include file='FILE.xml' path='doc/member[@name="FILE.FILE_COMPRESSION_NTCAB"]/*' />
    [NativeTypeName("#define FILE_COMPRESSION_NTCAB 3")]
    public const int FILE_COMPRESSION_NTCAB = 3;
}
