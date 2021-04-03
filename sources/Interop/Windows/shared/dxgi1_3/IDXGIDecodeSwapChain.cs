// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/dxgi1_3.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("2633066B-4514-4C7A-8FD8-12EA98059D18")]
    [NativeTypeName("struct IDXGIDecodeSwapChain : IUnknown")]
    public unsafe partial struct IDXGIDecodeSwapChain
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDXGIDecodeSwapChain*, Guid*, void**, int>)(lpVtbl[0]))((IDXGIDecodeSwapChain*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDXGIDecodeSwapChain*, uint>)(lpVtbl[1]))((IDXGIDecodeSwapChain*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDXGIDecodeSwapChain*, uint>)(lpVtbl[2]))((IDXGIDecodeSwapChain*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int PresentBuffer([NativeTypeName("UINT")] uint BufferToPresent, [NativeTypeName("UINT")] uint SyncInterval, [NativeTypeName("UINT")] uint Flags)
        {
            return ((delegate* unmanaged<IDXGIDecodeSwapChain*, uint, uint, uint, int>)(lpVtbl[3]))((IDXGIDecodeSwapChain*)Unsafe.AsPointer(ref this), BufferToPresent, SyncInterval, Flags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetSourceRect([NativeTypeName("const RECT *")] RECT* pRect)
        {
            return ((delegate* unmanaged<IDXGIDecodeSwapChain*, RECT*, int>)(lpVtbl[4]))((IDXGIDecodeSwapChain*)Unsafe.AsPointer(ref this), pRect);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetTargetRect([NativeTypeName("const RECT *")] RECT* pRect)
        {
            return ((delegate* unmanaged<IDXGIDecodeSwapChain*, RECT*, int>)(lpVtbl[5]))((IDXGIDecodeSwapChain*)Unsafe.AsPointer(ref this), pRect);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetDestSize([NativeTypeName("UINT")] uint Width, [NativeTypeName("UINT")] uint Height)
        {
            return ((delegate* unmanaged<IDXGIDecodeSwapChain*, uint, uint, int>)(lpVtbl[6]))((IDXGIDecodeSwapChain*)Unsafe.AsPointer(ref this), Width, Height);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSourceRect(RECT* pRect)
        {
            return ((delegate* unmanaged<IDXGIDecodeSwapChain*, RECT*, int>)(lpVtbl[7]))((IDXGIDecodeSwapChain*)Unsafe.AsPointer(ref this), pRect);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTargetRect(RECT* pRect)
        {
            return ((delegate* unmanaged<IDXGIDecodeSwapChain*, RECT*, int>)(lpVtbl[8]))((IDXGIDecodeSwapChain*)Unsafe.AsPointer(ref this), pRect);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDestSize([NativeTypeName("UINT *")] uint* pWidth, [NativeTypeName("UINT *")] uint* pHeight)
        {
            return ((delegate* unmanaged<IDXGIDecodeSwapChain*, uint*, uint*, int>)(lpVtbl[9]))((IDXGIDecodeSwapChain*)Unsafe.AsPointer(ref this), pWidth, pHeight);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetColorSpace(DXGI_MULTIPLANE_OVERLAY_YCbCr_FLAGS ColorSpace)
        {
            return ((delegate* unmanaged<IDXGIDecodeSwapChain*, DXGI_MULTIPLANE_OVERLAY_YCbCr_FLAGS, int>)(lpVtbl[10]))((IDXGIDecodeSwapChain*)Unsafe.AsPointer(ref this), ColorSpace);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public DXGI_MULTIPLANE_OVERLAY_YCbCr_FLAGS GetColorSpace()
        {
            return ((delegate* unmanaged<IDXGIDecodeSwapChain*, DXGI_MULTIPLANE_OVERLAY_YCbCr_FLAGS>)(lpVtbl[11]))((IDXGIDecodeSwapChain*)Unsafe.AsPointer(ref this));
        }
    }
}
