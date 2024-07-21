// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D3DFORMAT.xml' path='doc/member[@name="D3DFORMAT"]/*' />
public enum D3DFORMAT
{
    /// <include file='D3DFORMAT.xml' path='doc/member[@name="D3DFORMAT.D3DFMT_UNKNOWN"]/*' />
    D3DFMT_UNKNOWN = 0,

    /// <include file='D3DFORMAT.xml' path='doc/member[@name="D3DFORMAT.D3DFMT_R8G8B8"]/*' />
    D3DFMT_R8G8B8 = 20,

    /// <include file='D3DFORMAT.xml' path='doc/member[@name="D3DFORMAT.D3DFMT_A8R8G8B8"]/*' />
    D3DFMT_A8R8G8B8 = 21,

    /// <include file='D3DFORMAT.xml' path='doc/member[@name="D3DFORMAT.D3DFMT_X8R8G8B8"]/*' />
    D3DFMT_X8R8G8B8 = 22,

    /// <include file='D3DFORMAT.xml' path='doc/member[@name="D3DFORMAT.D3DFMT_R5G6B5"]/*' />
    D3DFMT_R5G6B5 = 23,

    /// <include file='D3DFORMAT.xml' path='doc/member[@name="D3DFORMAT.D3DFMT_X1R5G5B5"]/*' />
    D3DFMT_X1R5G5B5 = 24,

    /// <include file='D3DFORMAT.xml' path='doc/member[@name="D3DFORMAT.D3DFMT_A1R5G5B5"]/*' />
    D3DFMT_A1R5G5B5 = 25,

    /// <include file='D3DFORMAT.xml' path='doc/member[@name="D3DFORMAT.D3DFMT_A4R4G4B4"]/*' />
    D3DFMT_A4R4G4B4 = 26,

    /// <include file='D3DFORMAT.xml' path='doc/member[@name="D3DFORMAT.D3DFMT_R3G3B2"]/*' />
    D3DFMT_R3G3B2 = 27,

    /// <include file='D3DFORMAT.xml' path='doc/member[@name="D3DFORMAT.D3DFMT_A8"]/*' />
    D3DFMT_A8 = 28,

    /// <include file='D3DFORMAT.xml' path='doc/member[@name="D3DFORMAT.D3DFMT_A8R3G3B2"]/*' />
    D3DFMT_A8R3G3B2 = 29,

    /// <include file='D3DFORMAT.xml' path='doc/member[@name="D3DFORMAT.D3DFMT_X4R4G4B4"]/*' />
    D3DFMT_X4R4G4B4 = 30,

    /// <include file='D3DFORMAT.xml' path='doc/member[@name="D3DFORMAT.D3DFMT_A2B10G10R10"]/*' />
    D3DFMT_A2B10G10R10 = 31,

    /// <include file='D3DFORMAT.xml' path='doc/member[@name="D3DFORMAT.D3DFMT_A8B8G8R8"]/*' />
    D3DFMT_A8B8G8R8 = 32,

    /// <include file='D3DFORMAT.xml' path='doc/member[@name="D3DFORMAT.D3DFMT_X8B8G8R8"]/*' />
    D3DFMT_X8B8G8R8 = 33,

    /// <include file='D3DFORMAT.xml' path='doc/member[@name="D3DFORMAT.D3DFMT_G16R16"]/*' />
    D3DFMT_G16R16 = 34,

    /// <include file='D3DFORMAT.xml' path='doc/member[@name="D3DFORMAT.D3DFMT_A2R10G10B10"]/*' />
    D3DFMT_A2R10G10B10 = 35,

    /// <include file='D3DFORMAT.xml' path='doc/member[@name="D3DFORMAT.D3DFMT_A16B16G16R16"]/*' />
    D3DFMT_A16B16G16R16 = 36,

    /// <include file='D3DFORMAT.xml' path='doc/member[@name="D3DFORMAT.D3DFMT_A8P8"]/*' />
    D3DFMT_A8P8 = 40,

    /// <include file='D3DFORMAT.xml' path='doc/member[@name="D3DFORMAT.D3DFMT_P8"]/*' />
    D3DFMT_P8 = 41,

    /// <include file='D3DFORMAT.xml' path='doc/member[@name="D3DFORMAT.D3DFMT_L8"]/*' />
    D3DFMT_L8 = 50,

    /// <include file='D3DFORMAT.xml' path='doc/member[@name="D3DFORMAT.D3DFMT_A8L8"]/*' />
    D3DFMT_A8L8 = 51,

    /// <include file='D3DFORMAT.xml' path='doc/member[@name="D3DFORMAT.D3DFMT_A4L4"]/*' />
    D3DFMT_A4L4 = 52,

    /// <include file='D3DFORMAT.xml' path='doc/member[@name="D3DFORMAT.D3DFMT_V8U8"]/*' />
    D3DFMT_V8U8 = 60,

    /// <include file='D3DFORMAT.xml' path='doc/member[@name="D3DFORMAT.D3DFMT_L6V5U5"]/*' />
    D3DFMT_L6V5U5 = 61,

    /// <include file='D3DFORMAT.xml' path='doc/member[@name="D3DFORMAT.D3DFMT_X8L8V8U8"]/*' />
    D3DFMT_X8L8V8U8 = 62,

    /// <include file='D3DFORMAT.xml' path='doc/member[@name="D3DFORMAT.D3DFMT_Q8W8V8U8"]/*' />
    D3DFMT_Q8W8V8U8 = 63,

    /// <include file='D3DFORMAT.xml' path='doc/member[@name="D3DFORMAT.D3DFMT_V16U16"]/*' />
    D3DFMT_V16U16 = 64,

    /// <include file='D3DFORMAT.xml' path='doc/member[@name="D3DFORMAT.D3DFMT_A2W10V10U10"]/*' />
    D3DFMT_A2W10V10U10 = 67,

    /// <include file='D3DFORMAT.xml' path='doc/member[@name="D3DFORMAT.D3DFMT_UYVY"]/*' />
    D3DFMT_UYVY = unchecked((int)((uint)((byte)('U')) | ((uint)((byte)('Y')) << 8) | ((uint)((byte)('V')) << 16) | ((uint)((byte)('Y')) << 24))),

    /// <include file='D3DFORMAT.xml' path='doc/member[@name="D3DFORMAT.D3DFMT_R8G8_B8G8"]/*' />
    D3DFMT_R8G8_B8G8 = unchecked((int)((uint)((byte)('R')) | ((uint)((byte)('G')) << 8) | ((uint)((byte)('B')) << 16) | ((uint)((byte)('G')) << 24))),

    /// <include file='D3DFORMAT.xml' path='doc/member[@name="D3DFORMAT.D3DFMT_YUY2"]/*' />
    D3DFMT_YUY2 = unchecked((int)((uint)((byte)('Y')) | ((uint)((byte)('U')) << 8) | ((uint)((byte)('Y')) << 16) | ((uint)((byte)('2')) << 24))),

    /// <include file='D3DFORMAT.xml' path='doc/member[@name="D3DFORMAT.D3DFMT_G8R8_G8B8"]/*' />
    D3DFMT_G8R8_G8B8 = unchecked((int)((uint)((byte)('G')) | ((uint)((byte)('R')) << 8) | ((uint)((byte)('G')) << 16) | ((uint)((byte)('B')) << 24))),

    /// <include file='D3DFORMAT.xml' path='doc/member[@name="D3DFORMAT.D3DFMT_DXT1"]/*' />
    D3DFMT_DXT1 = unchecked((int)((uint)((byte)('D')) | ((uint)((byte)('X')) << 8) | ((uint)((byte)('T')) << 16) | ((uint)((byte)('1')) << 24))),

    /// <include file='D3DFORMAT.xml' path='doc/member[@name="D3DFORMAT.D3DFMT_DXT2"]/*' />
    D3DFMT_DXT2 = unchecked((int)((uint)((byte)('D')) | ((uint)((byte)('X')) << 8) | ((uint)((byte)('T')) << 16) | ((uint)((byte)('2')) << 24))),

    /// <include file='D3DFORMAT.xml' path='doc/member[@name="D3DFORMAT.D3DFMT_DXT3"]/*' />
    D3DFMT_DXT3 = unchecked((int)((uint)((byte)('D')) | ((uint)((byte)('X')) << 8) | ((uint)((byte)('T')) << 16) | ((uint)((byte)('3')) << 24))),

    /// <include file='D3DFORMAT.xml' path='doc/member[@name="D3DFORMAT.D3DFMT_DXT4"]/*' />
    D3DFMT_DXT4 = unchecked((int)((uint)((byte)('D')) | ((uint)((byte)('X')) << 8) | ((uint)((byte)('T')) << 16) | ((uint)((byte)('4')) << 24))),

    /// <include file='D3DFORMAT.xml' path='doc/member[@name="D3DFORMAT.D3DFMT_DXT5"]/*' />
    D3DFMT_DXT5 = unchecked((int)((uint)((byte)('D')) | ((uint)((byte)('X')) << 8) | ((uint)((byte)('T')) << 16) | ((uint)((byte)('5')) << 24))),

    /// <include file='D3DFORMAT.xml' path='doc/member[@name="D3DFORMAT.D3DFMT_D16_LOCKABLE"]/*' />
    D3DFMT_D16_LOCKABLE = 70,

    /// <include file='D3DFORMAT.xml' path='doc/member[@name="D3DFORMAT.D3DFMT_D32"]/*' />
    D3DFMT_D32 = 71,

    /// <include file='D3DFORMAT.xml' path='doc/member[@name="D3DFORMAT.D3DFMT_D15S1"]/*' />
    D3DFMT_D15S1 = 73,

    /// <include file='D3DFORMAT.xml' path='doc/member[@name="D3DFORMAT.D3DFMT_D24S8"]/*' />
    D3DFMT_D24S8 = 75,

    /// <include file='D3DFORMAT.xml' path='doc/member[@name="D3DFORMAT.D3DFMT_D24X8"]/*' />
    D3DFMT_D24X8 = 77,

    /// <include file='D3DFORMAT.xml' path='doc/member[@name="D3DFORMAT.D3DFMT_D24X4S4"]/*' />
    D3DFMT_D24X4S4 = 79,

    /// <include file='D3DFORMAT.xml' path='doc/member[@name="D3DFORMAT.D3DFMT_D16"]/*' />
    D3DFMT_D16 = 80,

    /// <include file='D3DFORMAT.xml' path='doc/member[@name="D3DFORMAT.D3DFMT_D32F_LOCKABLE"]/*' />
    D3DFMT_D32F_LOCKABLE = 82,

    /// <include file='D3DFORMAT.xml' path='doc/member[@name="D3DFORMAT.D3DFMT_D24FS8"]/*' />
    D3DFMT_D24FS8 = 83,

    /// <include file='D3DFORMAT.xml' path='doc/member[@name="D3DFORMAT.D3DFMT_D32_LOCKABLE"]/*' />
    D3DFMT_D32_LOCKABLE = 84,

    /// <include file='D3DFORMAT.xml' path='doc/member[@name="D3DFORMAT.D3DFMT_S8_LOCKABLE"]/*' />
    D3DFMT_S8_LOCKABLE = 85,

    /// <include file='D3DFORMAT.xml' path='doc/member[@name="D3DFORMAT.D3DFMT_L16"]/*' />
    D3DFMT_L16 = 81,

    /// <include file='D3DFORMAT.xml' path='doc/member[@name="D3DFORMAT.D3DFMT_VERTEXDATA"]/*' />
    D3DFMT_VERTEXDATA = 100,

    /// <include file='D3DFORMAT.xml' path='doc/member[@name="D3DFORMAT.D3DFMT_INDEX16"]/*' />
    D3DFMT_INDEX16 = 101,

    /// <include file='D3DFORMAT.xml' path='doc/member[@name="D3DFORMAT.D3DFMT_INDEX32"]/*' />
    D3DFMT_INDEX32 = 102,

    /// <include file='D3DFORMAT.xml' path='doc/member[@name="D3DFORMAT.D3DFMT_Q16W16V16U16"]/*' />
    D3DFMT_Q16W16V16U16 = 110,

    /// <include file='D3DFORMAT.xml' path='doc/member[@name="D3DFORMAT.D3DFMT_MULTI2_ARGB8"]/*' />
    D3DFMT_MULTI2_ARGB8 = unchecked((int)((uint)((byte)('M')) | ((uint)((byte)('E')) << 8) | ((uint)((byte)('T')) << 16) | ((uint)((byte)('1')) << 24))),

    /// <include file='D3DFORMAT.xml' path='doc/member[@name="D3DFORMAT.D3DFMT_R16F"]/*' />
    D3DFMT_R16F = 111,

    /// <include file='D3DFORMAT.xml' path='doc/member[@name="D3DFORMAT.D3DFMT_G16R16F"]/*' />
    D3DFMT_G16R16F = 112,

    /// <include file='D3DFORMAT.xml' path='doc/member[@name="D3DFORMAT.D3DFMT_A16B16G16R16F"]/*' />
    D3DFMT_A16B16G16R16F = 113,

    /// <include file='D3DFORMAT.xml' path='doc/member[@name="D3DFORMAT.D3DFMT_R32F"]/*' />
    D3DFMT_R32F = 114,

    /// <include file='D3DFORMAT.xml' path='doc/member[@name="D3DFORMAT.D3DFMT_G32R32F"]/*' />
    D3DFMT_G32R32F = 115,

    /// <include file='D3DFORMAT.xml' path='doc/member[@name="D3DFORMAT.D3DFMT_A32B32G32R32F"]/*' />
    D3DFMT_A32B32G32R32F = 116,

    /// <include file='D3DFORMAT.xml' path='doc/member[@name="D3DFORMAT.D3DFMT_CxV8U8"]/*' />
    D3DFMT_CxV8U8 = 117,

    /// <include file='D3DFORMAT.xml' path='doc/member[@name="D3DFORMAT.D3DFMT_A1"]/*' />
    D3DFMT_A1 = 118,

    /// <include file='D3DFORMAT.xml' path='doc/member[@name="D3DFORMAT.D3DFMT_A2B10G10R10_XR_BIAS"]/*' />
    D3DFMT_A2B10G10R10_XR_BIAS = 119,

    /// <include file='D3DFORMAT.xml' path='doc/member[@name="D3DFORMAT.D3DFMT_BINARYBUFFER"]/*' />
    D3DFMT_BINARYBUFFER = 199,

    /// <include file='D3DFORMAT.xml' path='doc/member[@name="D3DFORMAT.D3DFMT_FORCE_DWORD"]/*' />
    D3DFMT_FORCE_DWORD = 0x7fffffff,
}
