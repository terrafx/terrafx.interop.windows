// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/dxgi1_3.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("41E7D1F2-A591-4F7B-A2E5-FA9C843E1C12")]
    public unsafe partial struct IDXGIFactoryMedia
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IDXGIFactoryMedia*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IDXGIFactoryMedia*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IDXGIFactoryMedia*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateSwapChainForCompositionSurfaceHandle([NativeTypeName("IUnknown *")] IUnknown* pDevice, [NativeTypeName("HANDLE")] IntPtr hSurface, [NativeTypeName("const DXGI_SWAP_CHAIN_DESC1 *")] DXGI_SWAP_CHAIN_DESC1* pDesc, [NativeTypeName("IDXGIOutput *")] IDXGIOutput* pRestrictToOutput, [NativeTypeName("IDXGISwapChain1 **")] IDXGISwapChain1** ppSwapChain)
        {
            return lpVtbl->CreateSwapChainForCompositionSurfaceHandle((IDXGIFactoryMedia*)Unsafe.AsPointer(ref this), pDevice, hSurface, pDesc, pRestrictToOutput, ppSwapChain);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateDecodeSwapChainForCompositionSurfaceHandle([NativeTypeName("IUnknown *")] IUnknown* pDevice, [NativeTypeName("HANDLE")] IntPtr hSurface, [NativeTypeName("DXGI_DECODE_SWAP_CHAIN_DESC *")] DXGI_DECODE_SWAP_CHAIN_DESC* pDesc, [NativeTypeName("IDXGIResource *")] IDXGIResource* pYuvDecodeBuffers, [NativeTypeName("IDXGIOutput *")] IDXGIOutput* pRestrictToOutput, [NativeTypeName("IDXGIDecodeSwapChain **")] IDXGIDecodeSwapChain** ppSwapChain)
        {
            return lpVtbl->CreateDecodeSwapChainForCompositionSurfaceHandle((IDXGIFactoryMedia*)Unsafe.AsPointer(ref this), pDevice, hSurface, pDesc, pYuvDecodeBuffers, pRestrictToOutput, ppSwapChain);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIFactoryMedia*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIFactoryMedia*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIFactoryMedia*, uint> Release;

            [NativeTypeName("HRESULT (IUnknown *, HANDLE, const DXGI_SWAP_CHAIN_DESC1 *, IDXGIOutput *, IDXGISwapChain1 **) __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIFactoryMedia*, IUnknown*, IntPtr, DXGI_SWAP_CHAIN_DESC1*, IDXGIOutput*, IDXGISwapChain1**, int> CreateSwapChainForCompositionSurfaceHandle;

            [NativeTypeName("HRESULT (IUnknown *, HANDLE, DXGI_DECODE_SWAP_CHAIN_DESC *, IDXGIResource *, IDXGIOutput *, IDXGIDecodeSwapChain **) __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIFactoryMedia*, IUnknown*, IntPtr, DXGI_DECODE_SWAP_CHAIN_DESC*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int> CreateDecodeSwapChainForCompositionSurfaceHandle;
        }
    }
}
