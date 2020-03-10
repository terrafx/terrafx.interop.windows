// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("7F91CE67-090C-4BB7-B78E-ED8FF2E31DA0")]
    public unsafe partial struct ID3D12VersionedRootSignatureDeserializer
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(ID3D12VersionedRootSignatureDeserializer* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(ID3D12VersionedRootSignatureDeserializer* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(ID3D12VersionedRootSignatureDeserializer* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetRootSignatureDescAtVersion(ID3D12VersionedRootSignatureDeserializer* pThis, D3D_ROOT_SIGNATURE_VERSION convertToVersion, [NativeTypeName("const D3D12_VERSIONED_ROOT_SIGNATURE_DESC **")] D3D12_VERSIONED_ROOT_SIGNATURE_DESC** ppDesc);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("const D3D12_VERSIONED_ROOT_SIGNATURE_DESC *")]
        public delegate D3D12_VERSIONED_ROOT_SIGNATURE_DESC* _GetUnconvertedRootSignatureDesc(ID3D12VersionedRootSignatureDeserializer* pThis);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((ID3D12VersionedRootSignatureDeserializer*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((ID3D12VersionedRootSignatureDeserializer*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((ID3D12VersionedRootSignatureDeserializer*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetRootSignatureDescAtVersion(D3D_ROOT_SIGNATURE_VERSION convertToVersion, [NativeTypeName("const D3D12_VERSIONED_ROOT_SIGNATURE_DESC **")] D3D12_VERSIONED_ROOT_SIGNATURE_DESC** ppDesc)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetRootSignatureDescAtVersion>(lpVtbl->GetRootSignatureDescAtVersion)((ID3D12VersionedRootSignatureDeserializer*)Unsafe.AsPointer(ref this), convertToVersion, ppDesc);
        }

        [return: NativeTypeName("const D3D12_VERSIONED_ROOT_SIGNATURE_DESC *")]
        public D3D12_VERSIONED_ROOT_SIGNATURE_DESC* GetUnconvertedRootSignatureDesc()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetUnconvertedRootSignatureDesc>(lpVtbl->GetUnconvertedRootSignatureDesc)((ID3D12VersionedRootSignatureDeserializer*)Unsafe.AsPointer(ref this));
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (D3D_ROOT_SIGNATURE_VERSION, const D3D12_VERSIONED_ROOT_SIGNATURE_DESC **) __attribute__((stdcall))")]
            public IntPtr GetRootSignatureDescAtVersion;

            [NativeTypeName("const D3D12_VERSIONED_ROOT_SIGNATURE_DESC *() __attribute__((stdcall))")]
            public IntPtr GetUnconvertedRootSignatureDesc;
        }
    }
}
