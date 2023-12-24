// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.graphics.directx.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='DirectXPixelFormat.xml' path='doc/member[@name="DirectXPixelFormat"]/*' />
public enum DirectXPixelFormat
{
    /// <include file='DirectXPixelFormat.xml' path='doc/member[@name="DirectXPixelFormat.DirectXPixelFormat_Unknown"]/*' />
    DirectXPixelFormat_Unknown = 0,

    /// <include file='DirectXPixelFormat.xml' path='doc/member[@name="DirectXPixelFormat.DirectXPixelFormat_R32G32B32A32Typeless"]/*' />
    DirectXPixelFormat_R32G32B32A32Typeless = 1,

    /// <include file='DirectXPixelFormat.xml' path='doc/member[@name="DirectXPixelFormat.DirectXPixelFormat_R32G32B32A32Float"]/*' />
    DirectXPixelFormat_R32G32B32A32Float = 2,

    /// <include file='DirectXPixelFormat.xml' path='doc/member[@name="DirectXPixelFormat.DirectXPixelFormat_R32G32B32A32UInt"]/*' />
    DirectXPixelFormat_R32G32B32A32UInt = 3,

    /// <include file='DirectXPixelFormat.xml' path='doc/member[@name="DirectXPixelFormat.DirectXPixelFormat_R32G32B32A32Int"]/*' />
    DirectXPixelFormat_R32G32B32A32Int = 4,

    /// <include file='DirectXPixelFormat.xml' path='doc/member[@name="DirectXPixelFormat.DirectXPixelFormat_R32G32B32Typeless"]/*' />
    DirectXPixelFormat_R32G32B32Typeless = 5,

    /// <include file='DirectXPixelFormat.xml' path='doc/member[@name="DirectXPixelFormat.DirectXPixelFormat_R32G32B32Float"]/*' />
    DirectXPixelFormat_R32G32B32Float = 6,

    /// <include file='DirectXPixelFormat.xml' path='doc/member[@name="DirectXPixelFormat.DirectXPixelFormat_R32G32B32UInt"]/*' />
    DirectXPixelFormat_R32G32B32UInt = 7,

    /// <include file='DirectXPixelFormat.xml' path='doc/member[@name="DirectXPixelFormat.DirectXPixelFormat_R32G32B32Int"]/*' />
    DirectXPixelFormat_R32G32B32Int = 8,

    /// <include file='DirectXPixelFormat.xml' path='doc/member[@name="DirectXPixelFormat.DirectXPixelFormat_R16G16B16A16Typeless"]/*' />
    DirectXPixelFormat_R16G16B16A16Typeless = 9,

    /// <include file='DirectXPixelFormat.xml' path='doc/member[@name="DirectXPixelFormat.DirectXPixelFormat_R16G16B16A16Float"]/*' />
    DirectXPixelFormat_R16G16B16A16Float = 10,

    /// <include file='DirectXPixelFormat.xml' path='doc/member[@name="DirectXPixelFormat.DirectXPixelFormat_R16G16B16A16UIntNormalized"]/*' />
    DirectXPixelFormat_R16G16B16A16UIntNormalized = 11,

    /// <include file='DirectXPixelFormat.xml' path='doc/member[@name="DirectXPixelFormat.DirectXPixelFormat_R16G16B16A16UInt"]/*' />
    DirectXPixelFormat_R16G16B16A16UInt = 12,

    /// <include file='DirectXPixelFormat.xml' path='doc/member[@name="DirectXPixelFormat.DirectXPixelFormat_R16G16B16A16IntNormalized"]/*' />
    DirectXPixelFormat_R16G16B16A16IntNormalized = 13,

    /// <include file='DirectXPixelFormat.xml' path='doc/member[@name="DirectXPixelFormat.DirectXPixelFormat_R16G16B16A16Int"]/*' />
    DirectXPixelFormat_R16G16B16A16Int = 14,

    /// <include file='DirectXPixelFormat.xml' path='doc/member[@name="DirectXPixelFormat.DirectXPixelFormat_R32G32Typeless"]/*' />
    DirectXPixelFormat_R32G32Typeless = 15,

    /// <include file='DirectXPixelFormat.xml' path='doc/member[@name="DirectXPixelFormat.DirectXPixelFormat_R32G32Float"]/*' />
    DirectXPixelFormat_R32G32Float = 16,

    /// <include file='DirectXPixelFormat.xml' path='doc/member[@name="DirectXPixelFormat.DirectXPixelFormat_R32G32UInt"]/*' />
    DirectXPixelFormat_R32G32UInt = 17,

    /// <include file='DirectXPixelFormat.xml' path='doc/member[@name="DirectXPixelFormat.DirectXPixelFormat_R32G32Int"]/*' />
    DirectXPixelFormat_R32G32Int = 18,

    /// <include file='DirectXPixelFormat.xml' path='doc/member[@name="DirectXPixelFormat.DirectXPixelFormat_R32G8X24Typeless"]/*' />
    DirectXPixelFormat_R32G8X24Typeless = 19,

    /// <include file='DirectXPixelFormat.xml' path='doc/member[@name="DirectXPixelFormat.DirectXPixelFormat_D32FloatS8X24UInt"]/*' />
    DirectXPixelFormat_D32FloatS8X24UInt = 20,

    /// <include file='DirectXPixelFormat.xml' path='doc/member[@name="DirectXPixelFormat.DirectXPixelFormat_R32FloatX8X24Typeless"]/*' />
    DirectXPixelFormat_R32FloatX8X24Typeless = 21,

    /// <include file='DirectXPixelFormat.xml' path='doc/member[@name="DirectXPixelFormat.DirectXPixelFormat_X32TypelessG8X24UInt"]/*' />
    DirectXPixelFormat_X32TypelessG8X24UInt = 22,

    /// <include file='DirectXPixelFormat.xml' path='doc/member[@name="DirectXPixelFormat.DirectXPixelFormat_R10G10B10A2Typeless"]/*' />
    DirectXPixelFormat_R10G10B10A2Typeless = 23,

    /// <include file='DirectXPixelFormat.xml' path='doc/member[@name="DirectXPixelFormat.DirectXPixelFormat_R10G10B10A2UIntNormalized"]/*' />
    DirectXPixelFormat_R10G10B10A2UIntNormalized = 24,

    /// <include file='DirectXPixelFormat.xml' path='doc/member[@name="DirectXPixelFormat.DirectXPixelFormat_R10G10B10A2UInt"]/*' />
    DirectXPixelFormat_R10G10B10A2UInt = 25,

    /// <include file='DirectXPixelFormat.xml' path='doc/member[@name="DirectXPixelFormat.DirectXPixelFormat_R11G11B10Float"]/*' />
    DirectXPixelFormat_R11G11B10Float = 26,

    /// <include file='DirectXPixelFormat.xml' path='doc/member[@name="DirectXPixelFormat.DirectXPixelFormat_R8G8B8A8Typeless"]/*' />
    DirectXPixelFormat_R8G8B8A8Typeless = 27,

    /// <include file='DirectXPixelFormat.xml' path='doc/member[@name="DirectXPixelFormat.DirectXPixelFormat_R8G8B8A8UIntNormalized"]/*' />
    DirectXPixelFormat_R8G8B8A8UIntNormalized = 28,

    /// <include file='DirectXPixelFormat.xml' path='doc/member[@name="DirectXPixelFormat.DirectXPixelFormat_R8G8B8A8UIntNormalizedSrgb"]/*' />
    DirectXPixelFormat_R8G8B8A8UIntNormalizedSrgb = 29,

    /// <include file='DirectXPixelFormat.xml' path='doc/member[@name="DirectXPixelFormat.DirectXPixelFormat_R8G8B8A8UInt"]/*' />
    DirectXPixelFormat_R8G8B8A8UInt = 30,

    /// <include file='DirectXPixelFormat.xml' path='doc/member[@name="DirectXPixelFormat.DirectXPixelFormat_R8G8B8A8IntNormalized"]/*' />
    DirectXPixelFormat_R8G8B8A8IntNormalized = 31,

    /// <include file='DirectXPixelFormat.xml' path='doc/member[@name="DirectXPixelFormat.DirectXPixelFormat_R8G8B8A8Int"]/*' />
    DirectXPixelFormat_R8G8B8A8Int = 32,

    /// <include file='DirectXPixelFormat.xml' path='doc/member[@name="DirectXPixelFormat.DirectXPixelFormat_R16G16Typeless"]/*' />
    DirectXPixelFormat_R16G16Typeless = 33,

    /// <include file='DirectXPixelFormat.xml' path='doc/member[@name="DirectXPixelFormat.DirectXPixelFormat_R16G16Float"]/*' />
    DirectXPixelFormat_R16G16Float = 34,

    /// <include file='DirectXPixelFormat.xml' path='doc/member[@name="DirectXPixelFormat.DirectXPixelFormat_R16G16UIntNormalized"]/*' />
    DirectXPixelFormat_R16G16UIntNormalized = 35,

    /// <include file='DirectXPixelFormat.xml' path='doc/member[@name="DirectXPixelFormat.DirectXPixelFormat_R16G16UInt"]/*' />
    DirectXPixelFormat_R16G16UInt = 36,

    /// <include file='DirectXPixelFormat.xml' path='doc/member[@name="DirectXPixelFormat.DirectXPixelFormat_R16G16IntNormalized"]/*' />
    DirectXPixelFormat_R16G16IntNormalized = 37,

    /// <include file='DirectXPixelFormat.xml' path='doc/member[@name="DirectXPixelFormat.DirectXPixelFormat_R16G16Int"]/*' />
    DirectXPixelFormat_R16G16Int = 38,

    /// <include file='DirectXPixelFormat.xml' path='doc/member[@name="DirectXPixelFormat.DirectXPixelFormat_R32Typeless"]/*' />
    DirectXPixelFormat_R32Typeless = 39,

    /// <include file='DirectXPixelFormat.xml' path='doc/member[@name="DirectXPixelFormat.DirectXPixelFormat_D32Float"]/*' />
    DirectXPixelFormat_D32Float = 40,

    /// <include file='DirectXPixelFormat.xml' path='doc/member[@name="DirectXPixelFormat.DirectXPixelFormat_R32Float"]/*' />
    DirectXPixelFormat_R32Float = 41,

    /// <include file='DirectXPixelFormat.xml' path='doc/member[@name="DirectXPixelFormat.DirectXPixelFormat_R32UInt"]/*' />
    DirectXPixelFormat_R32UInt = 42,

    /// <include file='DirectXPixelFormat.xml' path='doc/member[@name="DirectXPixelFormat.DirectXPixelFormat_R32Int"]/*' />
    DirectXPixelFormat_R32Int = 43,

    /// <include file='DirectXPixelFormat.xml' path='doc/member[@name="DirectXPixelFormat.DirectXPixelFormat_R24G8Typeless"]/*' />
    DirectXPixelFormat_R24G8Typeless = 44,

    /// <include file='DirectXPixelFormat.xml' path='doc/member[@name="DirectXPixelFormat.DirectXPixelFormat_D24UIntNormalizedS8UInt"]/*' />
    DirectXPixelFormat_D24UIntNormalizedS8UInt = 45,

    /// <include file='DirectXPixelFormat.xml' path='doc/member[@name="DirectXPixelFormat.DirectXPixelFormat_R24UIntNormalizedX8Typeless"]/*' />
    DirectXPixelFormat_R24UIntNormalizedX8Typeless = 46,

    /// <include file='DirectXPixelFormat.xml' path='doc/member[@name="DirectXPixelFormat.DirectXPixelFormat_X24TypelessG8UInt"]/*' />
    DirectXPixelFormat_X24TypelessG8UInt = 47,

    /// <include file='DirectXPixelFormat.xml' path='doc/member[@name="DirectXPixelFormat.DirectXPixelFormat_R8G8Typeless"]/*' />
    DirectXPixelFormat_R8G8Typeless = 48,

    /// <include file='DirectXPixelFormat.xml' path='doc/member[@name="DirectXPixelFormat.DirectXPixelFormat_R8G8UIntNormalized"]/*' />
    DirectXPixelFormat_R8G8UIntNormalized = 49,

    /// <include file='DirectXPixelFormat.xml' path='doc/member[@name="DirectXPixelFormat.DirectXPixelFormat_R8G8UInt"]/*' />
    DirectXPixelFormat_R8G8UInt = 50,

    /// <include file='DirectXPixelFormat.xml' path='doc/member[@name="DirectXPixelFormat.DirectXPixelFormat_R8G8IntNormalized"]/*' />
    DirectXPixelFormat_R8G8IntNormalized = 51,

    /// <include file='DirectXPixelFormat.xml' path='doc/member[@name="DirectXPixelFormat.DirectXPixelFormat_R8G8Int"]/*' />
    DirectXPixelFormat_R8G8Int = 52,

    /// <include file='DirectXPixelFormat.xml' path='doc/member[@name="DirectXPixelFormat.DirectXPixelFormat_R16Typeless"]/*' />
    DirectXPixelFormat_R16Typeless = 53,

    /// <include file='DirectXPixelFormat.xml' path='doc/member[@name="DirectXPixelFormat.DirectXPixelFormat_R16Float"]/*' />
    DirectXPixelFormat_R16Float = 54,

    /// <include file='DirectXPixelFormat.xml' path='doc/member[@name="DirectXPixelFormat.DirectXPixelFormat_D16UIntNormalized"]/*' />
    DirectXPixelFormat_D16UIntNormalized = 55,

    /// <include file='DirectXPixelFormat.xml' path='doc/member[@name="DirectXPixelFormat.DirectXPixelFormat_R16UIntNormalized"]/*' />
    DirectXPixelFormat_R16UIntNormalized = 56,

    /// <include file='DirectXPixelFormat.xml' path='doc/member[@name="DirectXPixelFormat.DirectXPixelFormat_R16UInt"]/*' />
    DirectXPixelFormat_R16UInt = 57,

    /// <include file='DirectXPixelFormat.xml' path='doc/member[@name="DirectXPixelFormat.DirectXPixelFormat_R16IntNormalized"]/*' />
    DirectXPixelFormat_R16IntNormalized = 58,

    /// <include file='DirectXPixelFormat.xml' path='doc/member[@name="DirectXPixelFormat.DirectXPixelFormat_R16Int"]/*' />
    DirectXPixelFormat_R16Int = 59,

    /// <include file='DirectXPixelFormat.xml' path='doc/member[@name="DirectXPixelFormat.DirectXPixelFormat_R8Typeless"]/*' />
    DirectXPixelFormat_R8Typeless = 60,

    /// <include file='DirectXPixelFormat.xml' path='doc/member[@name="DirectXPixelFormat.DirectXPixelFormat_R8UIntNormalized"]/*' />
    DirectXPixelFormat_R8UIntNormalized = 61,

    /// <include file='DirectXPixelFormat.xml' path='doc/member[@name="DirectXPixelFormat.DirectXPixelFormat_R8UInt"]/*' />
    DirectXPixelFormat_R8UInt = 62,

    /// <include file='DirectXPixelFormat.xml' path='doc/member[@name="DirectXPixelFormat.DirectXPixelFormat_R8IntNormalized"]/*' />
    DirectXPixelFormat_R8IntNormalized = 63,

    /// <include file='DirectXPixelFormat.xml' path='doc/member[@name="DirectXPixelFormat.DirectXPixelFormat_R8Int"]/*' />
    DirectXPixelFormat_R8Int = 64,

    /// <include file='DirectXPixelFormat.xml' path='doc/member[@name="DirectXPixelFormat.DirectXPixelFormat_A8UIntNormalized"]/*' />
    DirectXPixelFormat_A8UIntNormalized = 65,

    /// <include file='DirectXPixelFormat.xml' path='doc/member[@name="DirectXPixelFormat.DirectXPixelFormat_R1UIntNormalized"]/*' />
    DirectXPixelFormat_R1UIntNormalized = 66,

    /// <include file='DirectXPixelFormat.xml' path='doc/member[@name="DirectXPixelFormat.DirectXPixelFormat_R9G9B9E5SharedExponent"]/*' />
    DirectXPixelFormat_R9G9B9E5SharedExponent = 67,

    /// <include file='DirectXPixelFormat.xml' path='doc/member[@name="DirectXPixelFormat.DirectXPixelFormat_R8G8B8G8UIntNormalized"]/*' />
    DirectXPixelFormat_R8G8B8G8UIntNormalized = 68,

    /// <include file='DirectXPixelFormat.xml' path='doc/member[@name="DirectXPixelFormat.DirectXPixelFormat_G8R8G8B8UIntNormalized"]/*' />
    DirectXPixelFormat_G8R8G8B8UIntNormalized = 69,

    /// <include file='DirectXPixelFormat.xml' path='doc/member[@name="DirectXPixelFormat.DirectXPixelFormat_BC1Typeless"]/*' />
    DirectXPixelFormat_BC1Typeless = 70,

    /// <include file='DirectXPixelFormat.xml' path='doc/member[@name="DirectXPixelFormat.DirectXPixelFormat_BC1UIntNormalized"]/*' />
    DirectXPixelFormat_BC1UIntNormalized = 71,

    /// <include file='DirectXPixelFormat.xml' path='doc/member[@name="DirectXPixelFormat.DirectXPixelFormat_BC1UIntNormalizedSrgb"]/*' />
    DirectXPixelFormat_BC1UIntNormalizedSrgb = 72,

    /// <include file='DirectXPixelFormat.xml' path='doc/member[@name="DirectXPixelFormat.DirectXPixelFormat_BC2Typeless"]/*' />
    DirectXPixelFormat_BC2Typeless = 73,

    /// <include file='DirectXPixelFormat.xml' path='doc/member[@name="DirectXPixelFormat.DirectXPixelFormat_BC2UIntNormalized"]/*' />
    DirectXPixelFormat_BC2UIntNormalized = 74,

    /// <include file='DirectXPixelFormat.xml' path='doc/member[@name="DirectXPixelFormat.DirectXPixelFormat_BC2UIntNormalizedSrgb"]/*' />
    DirectXPixelFormat_BC2UIntNormalizedSrgb = 75,

    /// <include file='DirectXPixelFormat.xml' path='doc/member[@name="DirectXPixelFormat.DirectXPixelFormat_BC3Typeless"]/*' />
    DirectXPixelFormat_BC3Typeless = 76,

    /// <include file='DirectXPixelFormat.xml' path='doc/member[@name="DirectXPixelFormat.DirectXPixelFormat_BC3UIntNormalized"]/*' />
    DirectXPixelFormat_BC3UIntNormalized = 77,

    /// <include file='DirectXPixelFormat.xml' path='doc/member[@name="DirectXPixelFormat.DirectXPixelFormat_BC3UIntNormalizedSrgb"]/*' />
    DirectXPixelFormat_BC3UIntNormalizedSrgb = 78,

    /// <include file='DirectXPixelFormat.xml' path='doc/member[@name="DirectXPixelFormat.DirectXPixelFormat_BC4Typeless"]/*' />
    DirectXPixelFormat_BC4Typeless = 79,

    /// <include file='DirectXPixelFormat.xml' path='doc/member[@name="DirectXPixelFormat.DirectXPixelFormat_BC4UIntNormalized"]/*' />
    DirectXPixelFormat_BC4UIntNormalized = 80,

    /// <include file='DirectXPixelFormat.xml' path='doc/member[@name="DirectXPixelFormat.DirectXPixelFormat_BC4IntNormalized"]/*' />
    DirectXPixelFormat_BC4IntNormalized = 81,

    /// <include file='DirectXPixelFormat.xml' path='doc/member[@name="DirectXPixelFormat.DirectXPixelFormat_BC5Typeless"]/*' />
    DirectXPixelFormat_BC5Typeless = 82,

    /// <include file='DirectXPixelFormat.xml' path='doc/member[@name="DirectXPixelFormat.DirectXPixelFormat_BC5UIntNormalized"]/*' />
    DirectXPixelFormat_BC5UIntNormalized = 83,

    /// <include file='DirectXPixelFormat.xml' path='doc/member[@name="DirectXPixelFormat.DirectXPixelFormat_BC5IntNormalized"]/*' />
    DirectXPixelFormat_BC5IntNormalized = 84,

    /// <include file='DirectXPixelFormat.xml' path='doc/member[@name="DirectXPixelFormat.DirectXPixelFormat_B5G6R5UIntNormalized"]/*' />
    DirectXPixelFormat_B5G6R5UIntNormalized = 85,

    /// <include file='DirectXPixelFormat.xml' path='doc/member[@name="DirectXPixelFormat.DirectXPixelFormat_B5G5R5A1UIntNormalized"]/*' />
    DirectXPixelFormat_B5G5R5A1UIntNormalized = 86,

    /// <include file='DirectXPixelFormat.xml' path='doc/member[@name="DirectXPixelFormat.DirectXPixelFormat_B8G8R8A8UIntNormalized"]/*' />
    DirectXPixelFormat_B8G8R8A8UIntNormalized = 87,

    /// <include file='DirectXPixelFormat.xml' path='doc/member[@name="DirectXPixelFormat.DirectXPixelFormat_B8G8R8X8UIntNormalized"]/*' />
    DirectXPixelFormat_B8G8R8X8UIntNormalized = 88,

    /// <include file='DirectXPixelFormat.xml' path='doc/member[@name="DirectXPixelFormat.DirectXPixelFormat_R10G10B10XRBiasA2UIntNormalized"]/*' />
    DirectXPixelFormat_R10G10B10XRBiasA2UIntNormalized = 89,

    /// <include file='DirectXPixelFormat.xml' path='doc/member[@name="DirectXPixelFormat.DirectXPixelFormat_B8G8R8A8Typeless"]/*' />
    DirectXPixelFormat_B8G8R8A8Typeless = 90,

    /// <include file='DirectXPixelFormat.xml' path='doc/member[@name="DirectXPixelFormat.DirectXPixelFormat_B8G8R8A8UIntNormalizedSrgb"]/*' />
    DirectXPixelFormat_B8G8R8A8UIntNormalizedSrgb = 91,

    /// <include file='DirectXPixelFormat.xml' path='doc/member[@name="DirectXPixelFormat.DirectXPixelFormat_B8G8R8X8Typeless"]/*' />
    DirectXPixelFormat_B8G8R8X8Typeless = 92,

    /// <include file='DirectXPixelFormat.xml' path='doc/member[@name="DirectXPixelFormat.DirectXPixelFormat_B8G8R8X8UIntNormalizedSrgb"]/*' />
    DirectXPixelFormat_B8G8R8X8UIntNormalizedSrgb = 93,

    /// <include file='DirectXPixelFormat.xml' path='doc/member[@name="DirectXPixelFormat.DirectXPixelFormat_BC6HTypeless"]/*' />
    DirectXPixelFormat_BC6HTypeless = 94,

    /// <include file='DirectXPixelFormat.xml' path='doc/member[@name="DirectXPixelFormat.DirectXPixelFormat_BC6H16UnsignedFloat"]/*' />
    DirectXPixelFormat_BC6H16UnsignedFloat = 95,

    /// <include file='DirectXPixelFormat.xml' path='doc/member[@name="DirectXPixelFormat.DirectXPixelFormat_BC6H16Float"]/*' />
    DirectXPixelFormat_BC6H16Float = 96,

    /// <include file='DirectXPixelFormat.xml' path='doc/member[@name="DirectXPixelFormat.DirectXPixelFormat_BC7Typeless"]/*' />
    DirectXPixelFormat_BC7Typeless = 97,

    /// <include file='DirectXPixelFormat.xml' path='doc/member[@name="DirectXPixelFormat.DirectXPixelFormat_BC7UIntNormalized"]/*' />
    DirectXPixelFormat_BC7UIntNormalized = 98,

    /// <include file='DirectXPixelFormat.xml' path='doc/member[@name="DirectXPixelFormat.DirectXPixelFormat_BC7UIntNormalizedSrgb"]/*' />
    DirectXPixelFormat_BC7UIntNormalizedSrgb = 99,

    /// <include file='DirectXPixelFormat.xml' path='doc/member[@name="DirectXPixelFormat.DirectXPixelFormat_Ayuv"]/*' />
    DirectXPixelFormat_Ayuv = 100,

    /// <include file='DirectXPixelFormat.xml' path='doc/member[@name="DirectXPixelFormat.DirectXPixelFormat_Y410"]/*' />
    DirectXPixelFormat_Y410 = 101,

    /// <include file='DirectXPixelFormat.xml' path='doc/member[@name="DirectXPixelFormat.DirectXPixelFormat_Y416"]/*' />
    DirectXPixelFormat_Y416 = 102,

    /// <include file='DirectXPixelFormat.xml' path='doc/member[@name="DirectXPixelFormat.DirectXPixelFormat_NV12"]/*' />
    DirectXPixelFormat_NV12 = 103,

    /// <include file='DirectXPixelFormat.xml' path='doc/member[@name="DirectXPixelFormat.DirectXPixelFormat_P010"]/*' />
    DirectXPixelFormat_P010 = 104,

    /// <include file='DirectXPixelFormat.xml' path='doc/member[@name="DirectXPixelFormat.DirectXPixelFormat_P016"]/*' />
    DirectXPixelFormat_P016 = 105,

    /// <include file='DirectXPixelFormat.xml' path='doc/member[@name="DirectXPixelFormat.DirectXPixelFormat_Opaque420"]/*' />
    DirectXPixelFormat_Opaque420 = 106,

    /// <include file='DirectXPixelFormat.xml' path='doc/member[@name="DirectXPixelFormat.DirectXPixelFormat_Yuy2"]/*' />
    DirectXPixelFormat_Yuy2 = 107,

    /// <include file='DirectXPixelFormat.xml' path='doc/member[@name="DirectXPixelFormat.DirectXPixelFormat_Y210"]/*' />
    DirectXPixelFormat_Y210 = 108,

    /// <include file='DirectXPixelFormat.xml' path='doc/member[@name="DirectXPixelFormat.DirectXPixelFormat_Y216"]/*' />
    DirectXPixelFormat_Y216 = 109,

    /// <include file='DirectXPixelFormat.xml' path='doc/member[@name="DirectXPixelFormat.DirectXPixelFormat_NV11"]/*' />
    DirectXPixelFormat_NV11 = 110,

    /// <include file='DirectXPixelFormat.xml' path='doc/member[@name="DirectXPixelFormat.DirectXPixelFormat_AI44"]/*' />
    DirectXPixelFormat_AI44 = 111,

    /// <include file='DirectXPixelFormat.xml' path='doc/member[@name="DirectXPixelFormat.DirectXPixelFormat_IA44"]/*' />
    DirectXPixelFormat_IA44 = 112,

    /// <include file='DirectXPixelFormat.xml' path='doc/member[@name="DirectXPixelFormat.DirectXPixelFormat_P8"]/*' />
    DirectXPixelFormat_P8 = 113,

    /// <include file='DirectXPixelFormat.xml' path='doc/member[@name="DirectXPixelFormat.DirectXPixelFormat_A8P8"]/*' />
    DirectXPixelFormat_A8P8 = 114,

    /// <include file='DirectXPixelFormat.xml' path='doc/member[@name="DirectXPixelFormat.DirectXPixelFormat_B4G4R4A4UIntNormalized"]/*' />
    DirectXPixelFormat_B4G4R4A4UIntNormalized = 115,

    /// <include file='DirectXPixelFormat.xml' path='doc/member[@name="DirectXPixelFormat.DirectXPixelFormat_P208"]/*' />
    DirectXPixelFormat_P208 = 130,

    /// <include file='DirectXPixelFormat.xml' path='doc/member[@name="DirectXPixelFormat.DirectXPixelFormat_V208"]/*' />
    DirectXPixelFormat_V208 = 131,

    /// <include file='DirectXPixelFormat.xml' path='doc/member[@name="DirectXPixelFormat.DirectXPixelFormat_V408"]/*' />
    DirectXPixelFormat_V408 = 132,

    /// <include file='DirectXPixelFormat.xml' path='doc/member[@name="DirectXPixelFormat.DirectXPixelFormat_SamplerFeedbackMinMipOpaque"]/*' />
    DirectXPixelFormat_SamplerFeedbackMinMipOpaque = 189,

    /// <include file='DirectXPixelFormat.xml' path='doc/member[@name="DirectXPixelFormat.DirectXPixelFormat_SamplerFeedbackMipRegionUsedOpaque"]/*' />
    DirectXPixelFormat_SamplerFeedbackMipRegionUsedOpaque = 190,
}
