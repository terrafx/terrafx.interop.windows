// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d3d12sdklayers.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using System.Security;

namespace TerraFX.Interop
{
    [Guid("102CA951-311B-4B01-B11F-ECB83E061B37")]
    public unsafe struct ID3D12DebugCommandList1
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _QueryInterface(
            [In] ID3D12DebugCommandList1* This,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _AddRef(
            [In] ID3D12DebugCommandList1* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _Release(
            [In] ID3D12DebugCommandList1* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("BOOL")]
        public /* static */ delegate int _AssertResourceState(
            [In] ID3D12DebugCommandList1* This,
            [In] ID3D12Resource* pResource,
            [In, NativeTypeName("UINT")] uint Subresource,
            [In, NativeTypeName("UINT")] uint State
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _SetDebugParameter(
            [In] ID3D12DebugCommandList1* This,
            [In] D3D12_DEBUG_COMMAND_LIST_PARAMETER_TYPE Type,
            [In] void* pData,
            [In, NativeTypeName("UINT")] uint DataSize
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetDebugParameter(
            [In] ID3D12DebugCommandList1* This,
            [In] D3D12_DEBUG_COMMAND_LIST_PARAMETER_TYPE Type,
            [Out] void* pData,
            [In, NativeTypeName("UINT")] uint DataSize
        );

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface(
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        )
        {
            fixed (ID3D12DebugCommandList1* This = &this)
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
            fixed (ID3D12DebugCommandList1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(
                    This
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (ID3D12DebugCommandList1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(
                    This
                );
            }
        }

        [return: NativeTypeName("BOOL")]
        public int AssertResourceState(
            [In] ID3D12Resource* pResource,
            [In, NativeTypeName("UINT")] uint Subresource,
            [In, NativeTypeName("UINT")] uint State
        )
        {
            fixed (ID3D12DebugCommandList1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AssertResourceState>(lpVtbl->AssertResourceState)(
                    This,
                    pResource,
                    Subresource,
                    State
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetDebugParameter(
            [In] D3D12_DEBUG_COMMAND_LIST_PARAMETER_TYPE Type,
            [In] void* pData,
            [In, NativeTypeName("UINT")] uint DataSize
        )
        {
            fixed (ID3D12DebugCommandList1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetDebugParameter>(lpVtbl->SetDebugParameter)(
                    This,
                    Type,
                    pData,
                    DataSize
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDebugParameter(
            [In] D3D12_DEBUG_COMMAND_LIST_PARAMETER_TYPE Type,
            [Out] void* pData,
            [In, NativeTypeName("UINT")] uint DataSize
        )
        {
            fixed (ID3D12DebugCommandList1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetDebugParameter>(lpVtbl->GetDebugParameter)(
                    This,
                    Type,
                    pData,
                    DataSize
                );
            }
        }

        public struct Vtbl
        {
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;

            public IntPtr AssertResourceState;

            public IntPtr SetDebugParameter;

            public IntPtr GetDebugParameter;
        }
    }
}
