// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/dxgi1_3.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("2633066B-4514-4C7A-8FD8-12EA98059D18")]
    public unsafe partial struct IDXGIDecodeSwapChain
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IDXGIDecodeSwapChain*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IDXGIDecodeSwapChain*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IDXGIDecodeSwapChain*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int PresentBuffer([NativeTypeName("UINT")] uint BufferToPresent, [NativeTypeName("UINT")] uint SyncInterval, [NativeTypeName("UINT")] uint Flags)
        {
            return lpVtbl->PresentBuffer((IDXGIDecodeSwapChain*)Unsafe.AsPointer(ref this), BufferToPresent, SyncInterval, Flags);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetSourceRect([NativeTypeName("const RECT *")] RECT* pRect)
        {
            return lpVtbl->SetSourceRect((IDXGIDecodeSwapChain*)Unsafe.AsPointer(ref this), pRect);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetTargetRect([NativeTypeName("const RECT *")] RECT* pRect)
        {
            return lpVtbl->SetTargetRect((IDXGIDecodeSwapChain*)Unsafe.AsPointer(ref this), pRect);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetDestSize([NativeTypeName("UINT")] uint Width, [NativeTypeName("UINT")] uint Height)
        {
            return lpVtbl->SetDestSize((IDXGIDecodeSwapChain*)Unsafe.AsPointer(ref this), Width, Height);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSourceRect([NativeTypeName("RECT *")] RECT* pRect)
        {
            return lpVtbl->GetSourceRect((IDXGIDecodeSwapChain*)Unsafe.AsPointer(ref this), pRect);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTargetRect([NativeTypeName("RECT *")] RECT* pRect)
        {
            return lpVtbl->GetTargetRect((IDXGIDecodeSwapChain*)Unsafe.AsPointer(ref this), pRect);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDestSize([NativeTypeName("UINT *")] uint* pWidth, [NativeTypeName("UINT *")] uint* pHeight)
        {
            return lpVtbl->GetDestSize((IDXGIDecodeSwapChain*)Unsafe.AsPointer(ref this), pWidth, pHeight);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetColorSpace(DXGI_MULTIPLANE_OVERLAY_YCbCr_FLAGS ColorSpace)
        {
            return lpVtbl->SetColorSpace((IDXGIDecodeSwapChain*)Unsafe.AsPointer(ref this), ColorSpace);
        }

        public DXGI_MULTIPLANE_OVERLAY_YCbCr_FLAGS GetColorSpace()
        {
            return lpVtbl->GetColorSpace((IDXGIDecodeSwapChain*)Unsafe.AsPointer(ref this));
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIDecodeSwapChain*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIDecodeSwapChain*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIDecodeSwapChain*, uint> Release;

            [NativeTypeName("HRESULT (UINT, UINT, UINT) __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIDecodeSwapChain*, uint, uint, uint, int> PresentBuffer;

            [NativeTypeName("HRESULT (const RECT *) __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIDecodeSwapChain*, RECT*, int> SetSourceRect;

            [NativeTypeName("HRESULT (const RECT *) __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIDecodeSwapChain*, RECT*, int> SetTargetRect;

            [NativeTypeName("HRESULT (UINT, UINT) __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIDecodeSwapChain*, uint, uint, int> SetDestSize;

            [NativeTypeName("HRESULT (RECT *) __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIDecodeSwapChain*, RECT*, int> GetSourceRect;

            [NativeTypeName("HRESULT (RECT *) __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIDecodeSwapChain*, RECT*, int> GetTargetRect;

            [NativeTypeName("HRESULT (UINT *, UINT *) __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIDecodeSwapChain*, uint*, uint*, int> GetDestSize;

            [NativeTypeName("HRESULT (DXGI_MULTIPLANE_OVERLAY_YCbCr_FLAGS) __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIDecodeSwapChain*, DXGI_MULTIPLANE_OVERLAY_YCbCr_FLAGS, int> SetColorSpace;

            [NativeTypeName("DXGI_MULTIPLANE_OVERLAY_YCbCr_FLAGS () __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIDecodeSwapChain*, DXGI_MULTIPLANE_OVERLAY_YCbCr_FLAGS> GetColorSpace;
        }
    }
}
