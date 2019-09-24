// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared\dxgi1_3.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using System.Security;

namespace TerraFX.Interop
{
    [Guid("41E7D1F2-A591-4F7B-A2E5-FA9C843E1C12")]
    public unsafe struct IDXGIFactoryMedia
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _QueryInterface(
            [In] IDXGIFactoryMedia* This,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _AddRef(
            [In] IDXGIFactoryMedia* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _Release(
            [In] IDXGIFactoryMedia* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _CreateSwapChainForCompositionSurfaceHandle(
            [In] IDXGIFactoryMedia* This,
            [In] IUnknown* pDevice,
            [In, Optional, NativeTypeName("HANDLE")] IntPtr hSurface,
            [In] DXGI_SWAP_CHAIN_DESC1* pDesc,
            [In, Optional] IDXGIOutput* pRestrictToOutput,
            [Out] IDXGISwapChain1** ppSwapChain
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _CreateDecodeSwapChainForCompositionSurfaceHandle(
            [In] IDXGIFactoryMedia* This,
            [In] IUnknown* pDevice,
            [In, Optional, NativeTypeName("HANDLE")] IntPtr hSurface,
            [In] DXGI_DECODE_SWAP_CHAIN_DESC* pDesc,
            [In] IDXGIResource* pYuvDecodeBuffers,
            [In, Optional] IDXGIOutput* pRestrictToOutput,
            [Out] IDXGIDecodeSwapChain** ppSwapChain
        );

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface(
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        )
        {
            fixed (IDXGIFactoryMedia* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)(
                    This,
                    riid,
                    ppvObject
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (IDXGIFactoryMedia* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(
                    This
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (IDXGIFactoryMedia* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(
                    This
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateSwapChainForCompositionSurfaceHandle(
            [In] IUnknown* pDevice,
            [In, Optional, NativeTypeName("HANDLE")] IntPtr hSurface,
            [In] DXGI_SWAP_CHAIN_DESC1* pDesc,
            [In, Optional] IDXGIOutput* pRestrictToOutput,
            [Out] IDXGISwapChain1** ppSwapChain
        )
        {
            fixed (IDXGIFactoryMedia* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateSwapChainForCompositionSurfaceHandle>(lpVtbl->CreateSwapChainForCompositionSurfaceHandle)(
                    This,
                    pDevice,
                    hSurface,
                    pDesc,
                    pRestrictToOutput,
                    ppSwapChain
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateDecodeSwapChainForCompositionSurfaceHandle(
            [In] IUnknown* pDevice,
            [In, Optional, NativeTypeName("HANDLE")] IntPtr hSurface,
            [In] DXGI_DECODE_SWAP_CHAIN_DESC* pDesc,
            [In] IDXGIResource* pYuvDecodeBuffers,
            [In, Optional] IDXGIOutput* pRestrictToOutput,
            [Out] IDXGIDecodeSwapChain** ppSwapChain
        )
        {
            fixed (IDXGIFactoryMedia* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateDecodeSwapChainForCompositionSurfaceHandle>(lpVtbl->CreateDecodeSwapChainForCompositionSurfaceHandle)(
                    This,
                    pDevice,
                    hSurface,
                    pDesc,
                    pYuvDecodeBuffers,
                    pRestrictToOutput,
                    ppSwapChain
                );
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
