// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/windows.ui.xaml.media.dxinterop.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("D5A2F60C-37B2-44A2-937B-8D8EB9726821")]
    [NativeTypeName("struct ISwapChainPanelNative2 : ISwapChainPanelNative")]
    public unsafe partial struct ISwapChainPanelNative2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<ISwapChainPanelNative2*, Guid*, void**, int>)(lpVtbl[0]))((ISwapChainPanelNative2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<ISwapChainPanelNative2*, uint>)(lpVtbl[1]))((ISwapChainPanelNative2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<ISwapChainPanelNative2*, uint>)(lpVtbl[2]))((ISwapChainPanelNative2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetSwapChain([NativeTypeName("IDXGISwapChain *")] IDXGISwapChain* swapChain)
        {
            return ((delegate* unmanaged[Stdcall]<ISwapChainPanelNative2*, IDXGISwapChain*, int>)(lpVtbl[3]))((ISwapChainPanelNative2*)Unsafe.AsPointer(ref this), swapChain);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetSwapChainHandle([NativeTypeName("HANDLE")] IntPtr swapChainHandle)
        {
            return ((delegate* unmanaged[Stdcall]<ISwapChainPanelNative2*, IntPtr, int>)(lpVtbl[4]))((ISwapChainPanelNative2*)Unsafe.AsPointer(ref this), swapChainHandle);
        }
    }
}
