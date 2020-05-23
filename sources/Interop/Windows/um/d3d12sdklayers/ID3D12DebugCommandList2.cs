// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12sdklayers.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("AEB575CF-4E06-48BE-BA3B-C450FC96652E")]
    public unsafe partial struct ID3D12DebugCommandList2
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(ID3D12DebugCommandList2* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(ID3D12DebugCommandList2* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(ID3D12DebugCommandList2* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("BOOL")]
        public delegate int _AssertResourceState(ID3D12DebugCommandList2* pThis, [NativeTypeName("ID3D12Resource *")] ID3D12Resource* pResource, [NativeTypeName("UINT")] uint Subresource, [NativeTypeName("UINT")] uint State);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetFeatureMask(ID3D12DebugCommandList2* pThis, D3D12_DEBUG_FEATURE Mask);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate D3D12_DEBUG_FEATURE _GetFeatureMask(ID3D12DebugCommandList2* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetDebugParameter(ID3D12DebugCommandList2* pThis, D3D12_DEBUG_COMMAND_LIST_PARAMETER_TYPE Type, [NativeTypeName("const void *")] void* pData, [NativeTypeName("UINT")] uint DataSize);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetDebugParameter(ID3D12DebugCommandList2* pThis, D3D12_DEBUG_COMMAND_LIST_PARAMETER_TYPE Type, [NativeTypeName("void *")] void* pData, [NativeTypeName("UINT")] uint DataSize);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((ID3D12DebugCommandList2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((ID3D12DebugCommandList2*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((ID3D12DebugCommandList2*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("BOOL")]
        public int AssertResourceState([NativeTypeName("ID3D12Resource *")] ID3D12Resource* pResource, [NativeTypeName("UINT")] uint Subresource, [NativeTypeName("UINT")] uint State)
        {
            return Marshal.GetDelegateForFunctionPointer<_AssertResourceState>(lpVtbl->AssertResourceState)((ID3D12DebugCommandList2*)Unsafe.AsPointer(ref this), pResource, Subresource, State);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetFeatureMask(D3D12_DEBUG_FEATURE Mask)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetFeatureMask>(lpVtbl->SetFeatureMask)((ID3D12DebugCommandList2*)Unsafe.AsPointer(ref this), Mask);
        }

        public D3D12_DEBUG_FEATURE GetFeatureMask()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetFeatureMask>(lpVtbl->GetFeatureMask)((ID3D12DebugCommandList2*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetDebugParameter(D3D12_DEBUG_COMMAND_LIST_PARAMETER_TYPE Type, [NativeTypeName("const void *")] void* pData, [NativeTypeName("UINT")] uint DataSize)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetDebugParameter>(lpVtbl->SetDebugParameter)((ID3D12DebugCommandList2*)Unsafe.AsPointer(ref this), Type, pData, DataSize);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDebugParameter(D3D12_DEBUG_COMMAND_LIST_PARAMETER_TYPE Type, [NativeTypeName("void *")] void* pData, [NativeTypeName("UINT")] uint DataSize)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetDebugParameter>(lpVtbl->GetDebugParameter)((ID3D12DebugCommandList2*)Unsafe.AsPointer(ref this), Type, pData, DataSize);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("BOOL (ID3D12Resource *, UINT, UINT) __attribute__((stdcall))")]
            public IntPtr AssertResourceState;

            [NativeTypeName("HRESULT (D3D12_DEBUG_FEATURE) __attribute__((stdcall))")]
            public IntPtr SetFeatureMask;

            [NativeTypeName("D3D12_DEBUG_FEATURE () __attribute__((stdcall))")]
            public IntPtr GetFeatureMask;

            [NativeTypeName("HRESULT (D3D12_DEBUG_COMMAND_LIST_PARAMETER_TYPE, const void *, UINT) __attribute__((stdcall))")]
            public IntPtr SetDebugParameter;

            [NativeTypeName("HRESULT (D3D12_DEBUG_COMMAND_LIST_PARAMETER_TYPE, void *, UINT) __attribute__((stdcall))")]
            public IntPtr GetDebugParameter;
        }
    }
}
