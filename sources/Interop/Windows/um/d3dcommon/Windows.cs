// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3dcommon.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public static partial class Windows
    {
        [NativeTypeName("const GUID")]
        public static readonly Guid IID_ID3D10Blob = new Guid(0x8ba5fb08, 0x5195, 0x40e2, 0xac, 0x58, 0xd, 0x98, 0x9c, 0x3a, 0x1, 0x2);

        [NativeTypeName("const GUID")]
        public static readonly Guid WKPDID_D3DDebugObjectName = new Guid(0x429b8c22, 0x9188, 0x4b0c, 0x87, 0x42, 0xac, 0xb0, 0xbf, 0x85, 0xc2, 0x00);

        [NativeTypeName("const GUID")]
        public static readonly Guid WKPDID_D3DDebugObjectNameW = new Guid(0x4cca5fd8, 0x921f, 0x42c8, 0x85, 0x66, 0x70, 0xca, 0xf2, 0xa9, 0xb7, 0x41);

        [NativeTypeName("const GUID")]
        public static readonly Guid WKPDID_CommentStringW = new Guid(0xd0149dc0, 0x90e8, 0x4ec8, 0x81, 0x44, 0xe9, 0x00, 0xad, 0x26, 0x6b, 0xb2);

        [NativeTypeName("const GUID")]
        public static readonly Guid D3D_TEXTURE_LAYOUT_ROW_MAJOR = new Guid(0xb5dc234f, 0x72bb, 0x4bec, 0x97, 0x05, 0x8c, 0xf2, 0x58, 0xdf, 0x6b, 0x6c);

        [NativeTypeName("const GUID")]
        public static readonly Guid D3D_TEXTURE_LAYOUT_64KB_STANDARD_SWIZZLE = new Guid(0x4c0f29e3, 0x3f5f, 0x4d35, 0x84, 0xc9, 0xbc, 0x09, 0x83, 0xb6, 0x2c, 0x28);

        [NativeTypeName("#define D3D_FL9_1_REQ_TEXTURE1D_U_DIMENSION 2048")]
        public const int D3D_FL9_1_REQ_TEXTURE1D_U_DIMENSION = 2048;

        [NativeTypeName("#define D3D_FL9_3_REQ_TEXTURE1D_U_DIMENSION 4096")]
        public const int D3D_FL9_3_REQ_TEXTURE1D_U_DIMENSION = 4096;

        [NativeTypeName("#define D3D_FL9_1_REQ_TEXTURE2D_U_OR_V_DIMENSION 2048")]
        public const int D3D_FL9_1_REQ_TEXTURE2D_U_OR_V_DIMENSION = 2048;

        [NativeTypeName("#define D3D_FL9_3_REQ_TEXTURE2D_U_OR_V_DIMENSION 4096")]
        public const int D3D_FL9_3_REQ_TEXTURE2D_U_OR_V_DIMENSION = 4096;

        [NativeTypeName("#define D3D_FL9_1_REQ_TEXTURECUBE_DIMENSION 512")]
        public const int D3D_FL9_1_REQ_TEXTURECUBE_DIMENSION = 512;

        [NativeTypeName("#define D3D_FL9_3_REQ_TEXTURECUBE_DIMENSION 4096")]
        public const int D3D_FL9_3_REQ_TEXTURECUBE_DIMENSION = 4096;

        [NativeTypeName("#define D3D_FL9_1_REQ_TEXTURE3D_U_V_OR_W_DIMENSION 256")]
        public const int D3D_FL9_1_REQ_TEXTURE3D_U_V_OR_W_DIMENSION = 256;

        [NativeTypeName("#define D3D_FL9_1_DEFAULT_MAX_ANISOTROPY 2")]
        public const int D3D_FL9_1_DEFAULT_MAX_ANISOTROPY = 2;

        [NativeTypeName("#define D3D_FL9_1_IA_PRIMITIVE_MAX_COUNT 65535")]
        public const int D3D_FL9_1_IA_PRIMITIVE_MAX_COUNT = 65535;

        [NativeTypeName("#define D3D_FL9_2_IA_PRIMITIVE_MAX_COUNT 1048575")]
        public const int D3D_FL9_2_IA_PRIMITIVE_MAX_COUNT = 1048575;

        [NativeTypeName("#define D3D_FL9_1_SIMULTANEOUS_RENDER_TARGET_COUNT 1")]
        public const int D3D_FL9_1_SIMULTANEOUS_RENDER_TARGET_COUNT = 1;

        [NativeTypeName("#define D3D_FL9_3_SIMULTANEOUS_RENDER_TARGET_COUNT 4")]
        public const int D3D_FL9_3_SIMULTANEOUS_RENDER_TARGET_COUNT = 4;

        [NativeTypeName("#define D3D_FL9_1_MAX_TEXTURE_REPEAT 128")]
        public const int D3D_FL9_1_MAX_TEXTURE_REPEAT = 128;

        [NativeTypeName("#define D3D_FL9_2_MAX_TEXTURE_REPEAT 2048")]
        public const int D3D_FL9_2_MAX_TEXTURE_REPEAT = 2048;

        [NativeTypeName("#define D3D_FL9_3_MAX_TEXTURE_REPEAT 8192")]
        public const int D3D_FL9_3_MAX_TEXTURE_REPEAT = 8192;

        [NativeTypeName("#define IID_ID3DBlob IID_ID3D10Blob")]
        public static readonly Guid IID_ID3DBlob = IID_ID3D10Blob;

        [NativeTypeName("#define D3D_COMPONENT_MASK_X 1")]
        public const int D3D_COMPONENT_MASK_X = 1;

        [NativeTypeName("#define D3D_COMPONENT_MASK_Y 2")]
        public const int D3D_COMPONENT_MASK_Y = 2;

        [NativeTypeName("#define D3D_COMPONENT_MASK_Z 4")]
        public const int D3D_COMPONENT_MASK_Z = 4;

        [NativeTypeName("#define D3D_COMPONENT_MASK_W 8")]
        public const int D3D_COMPONENT_MASK_W = 8;
    }
}
