// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class WIC
{
    /// <include file='WIC.xml' path='doc/member[@name="WIC.WIC_JPEG_MAX_COMPONENT_COUNT"]/*' />
    [NativeTypeName("#define WIC_JPEG_MAX_COMPONENT_COUNT ( 4 )")]
    public const int WIC_JPEG_MAX_COMPONENT_COUNT = (4);

    /// <include file='WIC.xml' path='doc/member[@name="WIC.WIC_JPEG_MAX_TABLE_INDEX"]/*' />
    [NativeTypeName("#define WIC_JPEG_MAX_TABLE_INDEX ( 3 )")]
    public const int WIC_JPEG_MAX_TABLE_INDEX = (3);

    /// <include file='WIC.xml' path='doc/member[@name="WIC.WIC_JPEG_SAMPLE_FACTORS_ONE"]/*' />
    [NativeTypeName("#define WIC_JPEG_SAMPLE_FACTORS_ONE ( 0x11 )")]
    public const int WIC_JPEG_SAMPLE_FACTORS_ONE = (0x11);

    /// <include file='WIC.xml' path='doc/member[@name="WIC.WIC_JPEG_SAMPLE_FACTORS_THREE_420"]/*' />
    [NativeTypeName("#define WIC_JPEG_SAMPLE_FACTORS_THREE_420 ( 0x111122 )")]
    public const int WIC_JPEG_SAMPLE_FACTORS_THREE_420 = (0x111122);

    /// <include file='WIC.xml' path='doc/member[@name="WIC.WIC_JPEG_SAMPLE_FACTORS_THREE_422"]/*' />
    [NativeTypeName("#define WIC_JPEG_SAMPLE_FACTORS_THREE_422 ( 0x111121 )")]
    public const int WIC_JPEG_SAMPLE_FACTORS_THREE_422 = (0x111121);

    /// <include file='WIC.xml' path='doc/member[@name="WIC.WIC_JPEG_SAMPLE_FACTORS_THREE_440"]/*' />
    [NativeTypeName("#define WIC_JPEG_SAMPLE_FACTORS_THREE_440 ( 0x111112 )")]
    public const int WIC_JPEG_SAMPLE_FACTORS_THREE_440 = (0x111112);

    /// <include file='WIC.xml' path='doc/member[@name="WIC.WIC_JPEG_SAMPLE_FACTORS_THREE_444"]/*' />
    [NativeTypeName("#define WIC_JPEG_SAMPLE_FACTORS_THREE_444 ( 0x111111 )")]
    public const int WIC_JPEG_SAMPLE_FACTORS_THREE_444 = (0x111111);

    /// <include file='WIC.xml' path='doc/member[@name="WIC.WIC_JPEG_QUANTIZATION_BASELINE_ONE"]/*' />
    [NativeTypeName("#define WIC_JPEG_QUANTIZATION_BASELINE_ONE ( 0 )")]
    public const int WIC_JPEG_QUANTIZATION_BASELINE_ONE = (0);

    /// <include file='WIC.xml' path='doc/member[@name="WIC.WIC_JPEG_QUANTIZATION_BASELINE_THREE"]/*' />
    [NativeTypeName("#define WIC_JPEG_QUANTIZATION_BASELINE_THREE ( 0x10100 )")]
    public const int WIC_JPEG_QUANTIZATION_BASELINE_THREE = (0x10100);

    /// <include file='WIC.xml' path='doc/member[@name="WIC.WIC_JPEG_HUFFMAN_BASELINE_ONE"]/*' />
    [NativeTypeName("#define WIC_JPEG_HUFFMAN_BASELINE_ONE ( 0 )")]
    public const int WIC_JPEG_HUFFMAN_BASELINE_ONE = (0);

    /// <include file='WIC.xml' path='doc/member[@name="WIC.WIC_JPEG_HUFFMAN_BASELINE_THREE"]/*' />
    [NativeTypeName("#define WIC_JPEG_HUFFMAN_BASELINE_THREE ( 0x111100 )")]
    public const int WIC_JPEG_HUFFMAN_BASELINE_THREE = (0x111100);
}
