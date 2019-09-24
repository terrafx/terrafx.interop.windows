// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d3d12sdklayers.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("09E0BF36-54AC-484F-8847-4BAEEAB6053A")]
    public unsafe struct ID3D12DebugCommandQueue
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(ID3D12DebugCommandQueue* This, [NativeTypeName("REFIID")] Guid* riid, void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(ID3D12DebugCommandQueue* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(ID3D12DebugCommandQueue* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("BOOL")]
        public delegate int _AssertResourceState(ID3D12DebugCommandQueue* This, ID3D12Resource* pResource, [NativeTypeName("UINT")] uint Subresource, [NativeTypeName("UINT")] uint State);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("REFIID")] Guid* riid, void** ppvObject)
        {
            fixed (ID3D12DebugCommandQueue* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)(This, riid, ppvObject);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (ID3D12DebugCommandQueue* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(This);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (ID3D12DebugCommandQueue* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(This);
            }
        }

        [return: NativeTypeName("BOOL")]
        public int AssertResourceState(ID3D12Resource* pResource, [NativeTypeName("UINT")] uint Subresource, [NativeTypeName("UINT")] uint State)
        {
            fixed (ID3D12DebugCommandQueue* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AssertResourceState>(lpVtbl->AssertResourceState)(This, pResource, Subresource, State);
            }
        }

        public struct Vtbl
        {
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;

            public IntPtr AssertResourceState;
        }
    }
}
