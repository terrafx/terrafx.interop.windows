// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/dxgi1_3.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("41E7D1F2-A591-4F7B-A2E5-FA9C843E1C12")]
    [NativeTypeName("struct IDXGIFactoryMedia : IUnknown")]
    public unsafe partial struct IDXGIFactoryMedia
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDXGIFactoryMedia*, Guid*, void**, int>)(lpVtbl[0]))((IDXGIFactoryMedia*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDXGIFactoryMedia*, uint>)(lpVtbl[1]))((IDXGIFactoryMedia*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDXGIFactoryMedia*, uint>)(lpVtbl[2]))((IDXGIFactoryMedia*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateSwapChainForCompositionSurfaceHandle(IUnknown* pDevice, [NativeTypeName("HANDLE")] IntPtr hSurface, [NativeTypeName("const DXGI_SWAP_CHAIN_DESC1 *")] DXGI_SWAP_CHAIN_DESC1* pDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
        {
            return ((delegate* unmanaged<IDXGIFactoryMedia*, IUnknown*, IntPtr, DXGI_SWAP_CHAIN_DESC1*, IDXGIOutput*, IDXGISwapChain1**, int>)(lpVtbl[3]))((IDXGIFactoryMedia*)Unsafe.AsPointer(ref this), pDevice, hSurface, pDesc, pRestrictToOutput, ppSwapChain);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateDecodeSwapChainForCompositionSurfaceHandle(IUnknown* pDevice, [NativeTypeName("HANDLE")] IntPtr hSurface, DXGI_DECODE_SWAP_CHAIN_DESC* pDesc, IDXGIResource* pYuvDecodeBuffers, IDXGIOutput* pRestrictToOutput, IDXGIDecodeSwapChain** ppSwapChain)
        {
            return ((delegate* unmanaged<IDXGIFactoryMedia*, IUnknown*, IntPtr, DXGI_DECODE_SWAP_CHAIN_DESC*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)(lpVtbl[4]))((IDXGIFactoryMedia*)Unsafe.AsPointer(ref this), pDevice, hSurface, pDesc, pYuvDecodeBuffers, pRestrictToOutput, ppSwapChain);
        }
    }
}
