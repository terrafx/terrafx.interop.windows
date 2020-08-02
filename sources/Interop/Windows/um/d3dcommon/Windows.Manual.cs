// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3dcommon.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        public const int D3D_FL9_1_REQ_TEXTURE1D_U_DIMENSION = 2048;

        public const int D3D_FL9_3_REQ_TEXTURE1D_U_DIMENSION = 4096;

        public const int D3D_FL9_1_REQ_TEXTURE2D_U_OR_V_DIMENSION = 2048;

        public const int D3D_FL9_3_REQ_TEXTURE2D_U_OR_V_DIMENSION = 4096;

        public const int D3D_FL9_1_REQ_TEXTURECUBE_DIMENSION = 512;

        public const int D3D_FL9_3_REQ_TEXTURECUBE_DIMENSION = 4096;

        public const int D3D_FL9_1_REQ_TEXTURE3D_U_V_OR_W_DIMENSION = 256;

        public const int D3D_FL9_1_DEFAULT_MAX_ANISOTROPY = 2;

        public const int D3D_FL9_1_IA_PRIMITIVE_MAX_COUNT = 65535;

        public const int D3D_FL9_2_IA_PRIMITIVE_MAX_COUNT = 1048575;

        public const int D3D_FL9_1_SIMULTANEOUS_RENDER_TARGET_COUNT = 1;

        public const int D3D_FL9_3_SIMULTANEOUS_RENDER_TARGET_COUNT = 4;

        public const int D3D_FL9_1_MAX_TEXTURE_REPEAT = 128;

        public const int D3D_FL9_2_MAX_TEXTURE_REPEAT = 2048;

        public const int D3D_FL9_3_MAX_TEXTURE_REPEAT = 8192;

        public static readonly Guid IID_ID3DBlob = new Guid(0x8BA5FB08, 0x5195, 0x40E2, 0xAC, 0x58, 0x0D, 0x98, 0x9C, 0x3A, 0x01, 0x02);

        public static readonly Guid IID_ID3DDestructionNotifier = new Guid(0xA06EB39A, 0x50DA, 0x425B, 0x8C, 0x31, 0x4E, 0xEC, 0xD6, 0xC2, 0x70, 0xF3);

        public const int D3D_COMPONENT_MASK_X = 1;

        public const int D3D_COMPONENT_MASK_Y = 2;

        public const int D3D_COMPONENT_MASK_Z = 4;

        public const int D3D_COMPONENT_MASK_W = 8;
    }
}
