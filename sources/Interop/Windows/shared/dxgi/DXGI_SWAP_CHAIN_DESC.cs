// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared\dxgi.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public unsafe struct DXGI_SWAP_CHAIN_DESC
    {
        #region Fields
        public DXGI_MODE_DESC BufferDesc;

        public DXGI_SAMPLE_DESC SampleDesc;

        [NativeTypeName("DXGI_USAGE")]
        public uint BufferUsage;

        [NativeTypeName("UINT")]
        public uint BufferCount;

        [NativeTypeName("HWND")]
        public IntPtr OutputWindow;

        [NativeTypeName("BOOL")]
        public int Windowed;

        public DXGI_SWAP_EFFECT SwapEffect;

        [NativeTypeName("UINT")]
        public uint Flags;
        #endregion
    }
}
