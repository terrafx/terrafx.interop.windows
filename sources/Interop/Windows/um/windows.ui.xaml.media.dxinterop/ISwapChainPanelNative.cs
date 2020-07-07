// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/windows.ui.xaml.media.dxinterop.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("F92F19D2-3ADE-45A6-A20C-F6F1EA90554B")]
    public unsafe partial struct ISwapChainPanelNative
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<ISwapChainPanelNative*, Guid*, void**, int>)(lpVtbl[0]))((ISwapChainPanelNative*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<ISwapChainPanelNative*, uint>)(lpVtbl[1]))((ISwapChainPanelNative*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<ISwapChainPanelNative*, uint>)(lpVtbl[2]))((ISwapChainPanelNative*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetSwapChain([NativeTypeName("IDXGISwapChain *")] IDXGISwapChain* swapChain)
        {
            return ((delegate* stdcall<ISwapChainPanelNative*, IDXGISwapChain*, int>)(lpVtbl[3]))((ISwapChainPanelNative*)Unsafe.AsPointer(ref this), swapChain);
        }
    }
}
