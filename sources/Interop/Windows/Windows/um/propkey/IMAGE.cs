// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/propkey.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class IMAGE
{
    /// <include file='IMAGE.xml' path='doc/member[@name="IMAGE.IMAGE_COLORSPACE_SRGB"]/*' />
    [NativeTypeName("#define IMAGE_COLORSPACE_SRGB 1u")]
    public const uint IMAGE_COLORSPACE_SRGB = 1U;

    /// <include file='IMAGE.xml' path='doc/member[@name="IMAGE.IMAGE_COLORSPACE_UNCALIBRATED"]/*' />
    [NativeTypeName("#define IMAGE_COLORSPACE_UNCALIBRATED 0xFFFFu")]
    public const uint IMAGE_COLORSPACE_UNCALIBRATED = 0xFFFFU;

    /// <include file='IMAGE.xml' path='doc/member[@name="IMAGE.IMAGE_COMPRESSION_UNCOMPRESSED"]/*' />
    [NativeTypeName("#define IMAGE_COMPRESSION_UNCOMPRESSED 1u")]
    public const uint IMAGE_COMPRESSION_UNCOMPRESSED = 1U;

    /// <include file='IMAGE.xml' path='doc/member[@name="IMAGE.IMAGE_COMPRESSION_CCITT_T3"]/*' />
    [NativeTypeName("#define IMAGE_COMPRESSION_CCITT_T3 2u")]
    public const uint IMAGE_COMPRESSION_CCITT_T3 = 2U;

    /// <include file='IMAGE.xml' path='doc/member[@name="IMAGE.IMAGE_COMPRESSION_CCITT_T4"]/*' />
    [NativeTypeName("#define IMAGE_COMPRESSION_CCITT_T4 3u")]
    public const uint IMAGE_COMPRESSION_CCITT_T4 = 3U;

    /// <include file='IMAGE.xml' path='doc/member[@name="IMAGE.IMAGE_COMPRESSION_CCITT_T6"]/*' />
    [NativeTypeName("#define IMAGE_COMPRESSION_CCITT_T6 4u")]
    public const uint IMAGE_COMPRESSION_CCITT_T6 = 4U;

    /// <include file='IMAGE.xml' path='doc/member[@name="IMAGE.IMAGE_COMPRESSION_LZW"]/*' />
    [NativeTypeName("#define IMAGE_COMPRESSION_LZW 5u")]
    public const uint IMAGE_COMPRESSION_LZW = 5U;

    /// <include file='IMAGE.xml' path='doc/member[@name="IMAGE.IMAGE_COMPRESSION_JPEG"]/*' />
    [NativeTypeName("#define IMAGE_COMPRESSION_JPEG 6u")]
    public const uint IMAGE_COMPRESSION_JPEG = 6U;

    /// <include file='IMAGE.xml' path='doc/member[@name="IMAGE.IMAGE_COMPRESSION_PACKBITS"]/*' />
    [NativeTypeName("#define IMAGE_COMPRESSION_PACKBITS 32773u")]
    public const uint IMAGE_COMPRESSION_PACKBITS = 32773U;
}
