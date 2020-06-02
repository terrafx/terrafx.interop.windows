// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11sdklayers.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("79CF2233-7536-4948-9D36-1E4692DC5760")]
    public unsafe partial struct ID3D11Debug
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((ID3D11Debug*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((ID3D11Debug*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((ID3D11Debug*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetFeatureMask([NativeTypeName("UINT")] uint Mask)
        {
            return lpVtbl->SetFeatureMask((ID3D11Debug*)Unsafe.AsPointer(ref this), Mask);
        }

        [return: NativeTypeName("UINT")]
        public uint GetFeatureMask()
        {
            return lpVtbl->GetFeatureMask((ID3D11Debug*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPresentPerRenderOpDelay([NativeTypeName("UINT")] uint Milliseconds)
        {
            return lpVtbl->SetPresentPerRenderOpDelay((ID3D11Debug*)Unsafe.AsPointer(ref this), Milliseconds);
        }

        [return: NativeTypeName("UINT")]
        public uint GetPresentPerRenderOpDelay()
        {
            return lpVtbl->GetPresentPerRenderOpDelay((ID3D11Debug*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetSwapChain([NativeTypeName("IDXGISwapChain *")] IDXGISwapChain* pSwapChain)
        {
            return lpVtbl->SetSwapChain((ID3D11Debug*)Unsafe.AsPointer(ref this), pSwapChain);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSwapChain([NativeTypeName("IDXGISwapChain **")] IDXGISwapChain** ppSwapChain)
        {
            return lpVtbl->GetSwapChain((ID3D11Debug*)Unsafe.AsPointer(ref this), ppSwapChain);
        }

        [return: NativeTypeName("HRESULT")]
        public int ValidateContext([NativeTypeName("ID3D11DeviceContext *")] ID3D11DeviceContext* pContext)
        {
            return lpVtbl->ValidateContext((ID3D11Debug*)Unsafe.AsPointer(ref this), pContext);
        }

        [return: NativeTypeName("HRESULT")]
        public int ReportLiveDeviceObjects(D3D11_RLDO_FLAGS Flags)
        {
            return lpVtbl->ReportLiveDeviceObjects((ID3D11Debug*)Unsafe.AsPointer(ref this), Flags);
        }

        [return: NativeTypeName("HRESULT")]
        public int ValidateContextForDispatch([NativeTypeName("ID3D11DeviceContext *")] ID3D11DeviceContext* pContext)
        {
            return lpVtbl->ValidateContextForDispatch((ID3D11Debug*)Unsafe.AsPointer(ref this), pContext);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11Debug*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11Debug*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11Debug*, uint> Release;

            [NativeTypeName("HRESULT (UINT) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11Debug*, uint, int> SetFeatureMask;

            [NativeTypeName("UINT () __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11Debug*, uint> GetFeatureMask;

            [NativeTypeName("HRESULT (UINT) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11Debug*, uint, int> SetPresentPerRenderOpDelay;

            [NativeTypeName("UINT () __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11Debug*, uint> GetPresentPerRenderOpDelay;

            [NativeTypeName("HRESULT (IDXGISwapChain *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11Debug*, IDXGISwapChain*, int> SetSwapChain;

            [NativeTypeName("HRESULT (IDXGISwapChain **) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11Debug*, IDXGISwapChain**, int> GetSwapChain;

            [NativeTypeName("HRESULT (ID3D11DeviceContext *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11Debug*, ID3D11DeviceContext*, int> ValidateContext;

            [NativeTypeName("HRESULT (D3D11_RLDO_FLAGS) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11Debug*, D3D11_RLDO_FLAGS, int> ReportLiveDeviceObjects;

            [NativeTypeName("HRESULT (ID3D11DeviceContext *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11Debug*, ID3D11DeviceContext*, int> ValidateContextForDispatch;
        }
    }
}
