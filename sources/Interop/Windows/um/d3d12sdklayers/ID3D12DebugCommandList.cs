// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12sdklayers.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("09E0BF36-54AC-484F-8847-4BAEEAB6053F")]
    public unsafe partial struct ID3D12DebugCommandList
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(ID3D12DebugCommandList* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(ID3D12DebugCommandList* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(ID3D12DebugCommandList* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("BOOL")]
        public delegate int _AssertResourceState(ID3D12DebugCommandList* pThis, [NativeTypeName("ID3D12Resource *")] ID3D12Resource* pResource, [NativeTypeName("UINT")] uint Subresource, [NativeTypeName("UINT")] uint State);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetFeatureMask(ID3D12DebugCommandList* pThis, D3D12_DEBUG_FEATURE Mask);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate D3D12_DEBUG_FEATURE _GetFeatureMask(ID3D12DebugCommandList* pThis);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((ID3D12DebugCommandList*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((ID3D12DebugCommandList*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((ID3D12DebugCommandList*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("BOOL")]
        public int AssertResourceState([NativeTypeName("ID3D12Resource *")] ID3D12Resource* pResource, [NativeTypeName("UINT")] uint Subresource, [NativeTypeName("UINT")] uint State)
        {
            return Marshal.GetDelegateForFunctionPointer<_AssertResourceState>(lpVtbl->AssertResourceState)((ID3D12DebugCommandList*)Unsafe.AsPointer(ref this), pResource, Subresource, State);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetFeatureMask(D3D12_DEBUG_FEATURE Mask)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetFeatureMask>(lpVtbl->SetFeatureMask)((ID3D12DebugCommandList*)Unsafe.AsPointer(ref this), Mask);
        }

        public D3D12_DEBUG_FEATURE GetFeatureMask()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetFeatureMask>(lpVtbl->GetFeatureMask)((ID3D12DebugCommandList*)Unsafe.AsPointer(ref this));
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
        }
    }
}