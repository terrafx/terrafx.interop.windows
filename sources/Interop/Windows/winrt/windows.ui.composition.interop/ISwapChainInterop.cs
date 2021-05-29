// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.composition.interop.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("26F496A0-7F38-45FB-88F7-FAAABE67DD59")]
    [NativeTypeName("struct ISwapChainInterop : IUnknown")]
    public unsafe partial struct ISwapChainInterop
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ISwapChainInterop*, Guid*, void**, int>)(lpVtbl[0]))((ISwapChainInterop*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISwapChainInterop*, uint>)(lpVtbl[1]))((ISwapChainInterop*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISwapChainInterop*, uint>)(lpVtbl[2]))((ISwapChainInterop*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetSwapChain(IUnknown* swapChain)
        {
            return ((delegate* unmanaged<ISwapChainInterop*, IUnknown*, int>)(lpVtbl[3]))((ISwapChainInterop*)Unsafe.AsPointer(ref this), swapChain);
        }
    }
}
