// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/windows.ui.xaml.media.dxinterop.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop
{
    [SupportedOSPlatform("windows8.1")]
    [Guid("43BEBD4E-ADD5-4035-8F85-5608D08E9DC9")]
    [NativeTypeName("struct ISwapChainBackgroundPanelNative : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ISwapChainBackgroundPanelNative : ISwapChainBackgroundPanelNative.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ISwapChainBackgroundPanelNative*, Guid*, void**, int>)(lpVtbl[0]))((ISwapChainBackgroundPanelNative*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISwapChainBackgroundPanelNative*, uint>)(lpVtbl[1]))((ISwapChainBackgroundPanelNative*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISwapChainBackgroundPanelNative*, uint>)(lpVtbl[2]))((ISwapChainBackgroundPanelNative*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT SetSwapChain(IDXGISwapChain* swapChain)
        {
            return ((delegate* unmanaged<ISwapChainBackgroundPanelNative*, IDXGISwapChain*, int>)(lpVtbl[3]))((ISwapChainBackgroundPanelNative*)Unsafe.AsPointer(ref this), swapChain);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT SetSwapChain(IDXGISwapChain* swapChain);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<ISwapChainBackgroundPanelNative*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ISwapChainBackgroundPanelNative*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ISwapChainBackgroundPanelNative*, uint> Release;

            [NativeTypeName("HRESULT (IDXGISwapChain *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISwapChainBackgroundPanelNative*, IDXGISwapChain*, int> SetSwapChain;
        }
    }
}
