// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/windows.ui.xaml.media.dxinterop.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("F92F19D2-3ADE-45A6-A20C-F6F1EA90554B")]
    [NativeTypeName("struct ISwapChainPanelNative : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ISwapChainPanelNative
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ISwapChainPanelNative*, Guid*, void**, int>)(lpVtbl[0]))((ISwapChainPanelNative*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISwapChainPanelNative*, uint>)(lpVtbl[1]))((ISwapChainPanelNative*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISwapChainPanelNative*, uint>)(lpVtbl[2]))((ISwapChainPanelNative*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int SetSwapChain(IDXGISwapChain* swapChain)
        {
            return ((delegate* unmanaged<ISwapChainPanelNative*, IDXGISwapChain*, int>)(lpVtbl[3]))((ISwapChainPanelNative*)Unsafe.AsPointer(ref this), swapChain);
        }
    }
}
