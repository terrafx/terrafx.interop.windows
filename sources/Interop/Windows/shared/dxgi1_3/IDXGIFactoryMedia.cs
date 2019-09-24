// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared\dxgi1_3.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("41E7D1F2-A591-4F7B-A2E5-FA9C843E1C12")]
    public unsafe struct IDXGIFactoryMedia
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IDXGIFactoryMedia* This, [NativeTypeName("REFIID")] Guid* riid, void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IDXGIFactoryMedia* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IDXGIFactoryMedia* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateSwapChainForCompositionSurfaceHandle(IDXGIFactoryMedia* This, IUnknown* pDevice, [Optional, NativeTypeName("HANDLE")] IntPtr hSurface, DXGI_SWAP_CHAIN_DESC1* pDesc, [Optional] IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateDecodeSwapChainForCompositionSurfaceHandle(IDXGIFactoryMedia* This, IUnknown* pDevice, [Optional, NativeTypeName("HANDLE")] IntPtr hSurface, DXGI_DECODE_SWAP_CHAIN_DESC* pDesc, IDXGIResource* pYuvDecodeBuffers, [Optional] IDXGIOutput* pRestrictToOutput, IDXGIDecodeSwapChain** ppSwapChain);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("REFIID")] Guid* riid, void** ppvObject)
        {
            fixed (IDXGIFactoryMedia* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)(This, riid, ppvObject);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (IDXGIFactoryMedia* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(This);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (IDXGIFactoryMedia* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(This);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateSwapChainForCompositionSurfaceHandle(IUnknown* pDevice, [Optional, NativeTypeName("HANDLE")] IntPtr hSurface, DXGI_SWAP_CHAIN_DESC1* pDesc, [Optional] IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
        {
            fixed (IDXGIFactoryMedia* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateSwapChainForCompositionSurfaceHandle>(lpVtbl->CreateSwapChainForCompositionSurfaceHandle)(This, pDevice, hSurface, pDesc, pRestrictToOutput, ppSwapChain);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateDecodeSwapChainForCompositionSurfaceHandle(IUnknown* pDevice, [Optional, NativeTypeName("HANDLE")] IntPtr hSurface, DXGI_DECODE_SWAP_CHAIN_DESC* pDesc, IDXGIResource* pYuvDecodeBuffers, [Optional] IDXGIOutput* pRestrictToOutput, IDXGIDecodeSwapChain** ppSwapChain)
        {
            fixed (IDXGIFactoryMedia* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateDecodeSwapChainForCompositionSurfaceHandle>(lpVtbl->CreateDecodeSwapChainForCompositionSurfaceHandle)(This, pDevice, hSurface, pDesc, pYuvDecodeBuffers, pRestrictToOutput, ppSwapChain);
            }
        }

        public struct Vtbl
        {
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;

            public IntPtr CreateSwapChainForCompositionSurfaceHandle;

            public IntPtr CreateDecodeSwapChainForCompositionSurfaceHandle;
        }
    }
}
