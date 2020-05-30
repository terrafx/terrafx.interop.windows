// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dxcore_interface.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public static partial class Windows
    {
        public const int _FACDXCORE = 0x880;

        public static int MAKE_DXCORE_HRESULT(int code)
        {
            return MAKE_HRESULT(1, _FACDXCORE, code);
        }

        public static readonly Guid IID_IDXCoreAdapterFactory = new Guid(0x78EE5945, 0xC36E, 0x4B13, 0xA6, 0x69, 0x00, 0x5D, 0xD1, 0x1C, 0x0F, 0x06);

        public static readonly Guid IID_IDXCoreAdapterList = new Guid(0x526C7776, 0x40E9, 0x459B, 0xB7, 0x11, 0xF3, 0x2A, 0xD7, 0x6D, 0xFC, 0x28);

        public static readonly Guid IID_IDXCoreAdapter = new Guid(0xF0DB4C7F, 0xFE5A, 0x42A2, 0xBD, 0x62, 0xF2, 0xA6, 0xCF, 0x6F, 0xC8, 0x3E);

        public static readonly Guid DXCORE_ADAPTER_ATTRIBUTE_D3D11_GRAPHICS = new Guid(0x8C47866B, 0x7583, 0x450D, 0xF0, 0xF0, 0x6B, 0xAD, 0xA8, 0x95, 0xAF, 0x4B);

        public static readonly Guid DXCORE_ADAPTER_ATTRIBUTE_D3D12_GRAPHICS = new Guid(0x0C9ECE4D, 0x2F6E, 0x4F01, 0x8C, 0x96, 0xE8, 0x9E, 0x33, 0x1B, 0x47, 0xB1);

        public static readonly Guid DXCORE_ADAPTER_ATTRIBUTE_D3D12_CORE_COMPUTE = new Guid(0x248E2800, 0xA793, 0x4724, 0xAB, 0xAA, 0x23, 0xA6, 0xDE, 0x1B, 0xE0, 0x90);
    }
}
