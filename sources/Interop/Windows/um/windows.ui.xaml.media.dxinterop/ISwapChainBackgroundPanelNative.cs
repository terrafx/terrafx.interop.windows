// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/windows.ui.xaml.media.dxinterop.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("43BEBD4E-ADD5-4035-8F85-5608D08E9DC9")]
    [NativeTypeName("struct ISwapChainBackgroundPanelNative : IUnknown")]
    public unsafe partial struct ISwapChainBackgroundPanelNative
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<ISwapChainBackgroundPanelNative*, Guid*, void**, int>)(lpVtbl[0]))((ISwapChainBackgroundPanelNative*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<ISwapChainBackgroundPanelNative*, uint>)(lpVtbl[1]))((ISwapChainBackgroundPanelNative*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<ISwapChainBackgroundPanelNative*, uint>)(lpVtbl[2]))((ISwapChainBackgroundPanelNative*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetSwapChain([NativeTypeName("IDXGISwapChain *")] IDXGISwapChain* swapChain)
        {
            return ((delegate* stdcall<ISwapChainBackgroundPanelNative*, IDXGISwapChain*, int>)(lpVtbl[3]))((ISwapChainBackgroundPanelNative*)Unsafe.AsPointer(ref this), swapChain);
        }
    }
}
