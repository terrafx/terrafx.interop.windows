// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/verrsrc.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class FILE
{
    /// <include file='FILE.xml' path='doc/member[@name="FILE.FILE_VER_GET_LOCALISED"]/*' />
    [NativeTypeName("#define FILE_VER_GET_LOCALISED 0x01")]
    public const int FILE_VER_GET_LOCALISED = 0x01;

    /// <include file='FILE.xml' path='doc/member[@name="FILE.FILE_VER_GET_NEUTRAL"]/*' />
    [NativeTypeName("#define FILE_VER_GET_NEUTRAL 0x02")]
    public const int FILE_VER_GET_NEUTRAL = 0x02;

    /// <include file='FILE.xml' path='doc/member[@name="FILE.FILE_VER_GET_PREFETCHED"]/*' />
    [NativeTypeName("#define FILE_VER_GET_PREFETCHED 0x04")]
    public const int FILE_VER_GET_PREFETCHED = 0x04;
}
