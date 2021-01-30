// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/gdiplusenums.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum EncoderValue
    {
        EncoderValueColorTypeCMYK,
        EncoderValueColorTypeYCCK,
        EncoderValueCompressionLZW,
        EncoderValueCompressionCCITT3,
        EncoderValueCompressionCCITT4,
        EncoderValueCompressionRle,
        EncoderValueCompressionNone,
        EncoderValueScanMethodInterlaced,
        EncoderValueScanMethodNonInterlaced,
        EncoderValueVersionGif87,
        EncoderValueVersionGif89,
        EncoderValueRenderProgressive,
        EncoderValueRenderNonProgressive,
        EncoderValueTransformRotate90,
        EncoderValueTransformRotate180,
        EncoderValueTransformRotate270,
        EncoderValueTransformFlipHorizontal,
        EncoderValueTransformFlipVertical,
        EncoderValueMultiFrame,
        EncoderValueLastFrame,
        EncoderValueFlush,
        EncoderValueFrameDimensionTime,
        EncoderValueFrameDimensionResolution,
        EncoderValueFrameDimensionPage,
    }
}
