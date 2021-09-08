// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/windows.ui.xaml.media.dxinterop.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("D5A2F60C-37B2-44A2-937B-8D8EB9726821")]
    [NativeTypeName("struct ISwapChainPanelNative2 : ISwapChainPanelNative")]
    [NativeInheritance("ISwapChainPanelNative")]
    public unsafe partial struct ISwapChainPanelNative2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ISwapChainPanelNative2*, Guid*, void**, int>)(lpVtbl[0]))((ISwapChainPanelNative2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISwapChainPanelNative2*, uint>)(lpVtbl[1]))((ISwapChainPanelNative2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISwapChainPanelNative2*, uint>)(lpVtbl[2]))((ISwapChainPanelNative2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int SetSwapChain(IDXGISwapChain* swapChain)
        {
            return ((delegate* unmanaged<ISwapChainPanelNative2*, IDXGISwapChain*, int>)(lpVtbl[3]))((ISwapChainPanelNative2*)Unsafe.AsPointer(ref this), swapChain);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int SetSwapChainHandle([NativeTypeName("HANDLE")] IntPtr swapChainHandle)
        {
            return ((delegate* unmanaged<ISwapChainPanelNative2*, IntPtr, int>)(lpVtbl[4]))((ISwapChainPanelNative2*)Unsafe.AsPointer(ref this), swapChainHandle);
        }
    }
}
