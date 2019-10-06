// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d3d12sdklayers.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("102CA951-311B-4B01-B11F-ECB83E061B37")]
    public unsafe partial struct ID3D12DebugCommandList1
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(ID3D12DebugCommandList1* This, [NativeTypeName("REFIID")] Guid* riid, void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(ID3D12DebugCommandList1* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(ID3D12DebugCommandList1* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("BOOL")]
        public delegate int _AssertResourceState(ID3D12DebugCommandList1* This, ID3D12Resource* pResource, [NativeTypeName("UINT")] uint Subresource, [NativeTypeName("UINT")] uint State);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetDebugParameter(ID3D12DebugCommandList1* This, D3D12_DEBUG_COMMAND_LIST_PARAMETER_TYPE Type, void* pData, [NativeTypeName("UINT")] uint DataSize);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetDebugParameter(ID3D12DebugCommandList1* This, D3D12_DEBUG_COMMAND_LIST_PARAMETER_TYPE Type, void* pData, [NativeTypeName("UINT")] uint DataSize);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("REFIID")] Guid* riid, void** ppvObject)
        {
            fixed (ID3D12DebugCommandList1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)(This, riid, ppvObject);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (ID3D12DebugCommandList1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(This);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (ID3D12DebugCommandList1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(This);
            }
        }

        [return: NativeTypeName("BOOL")]
        public int AssertResourceState(ID3D12Resource* pResource, [NativeTypeName("UINT")] uint Subresource, [NativeTypeName("UINT")] uint State)
        {
            fixed (ID3D12DebugCommandList1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AssertResourceState>(lpVtbl->AssertResourceState)(This, pResource, Subresource, State);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetDebugParameter(D3D12_DEBUG_COMMAND_LIST_PARAMETER_TYPE Type, void* pData, [NativeTypeName("UINT")] uint DataSize)
        {
            fixed (ID3D12DebugCommandList1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetDebugParameter>(lpVtbl->SetDebugParameter)(This, Type, pData, DataSize);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDebugParameter(D3D12_DEBUG_COMMAND_LIST_PARAMETER_TYPE Type, void* pData, [NativeTypeName("UINT")] uint DataSize)
        {
            fixed (ID3D12DebugCommandList1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetDebugParameter>(lpVtbl->GetDebugParameter)(This, Type, pData, DataSize);
            }
        }

        public partial struct Vtbl
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
