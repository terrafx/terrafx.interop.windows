// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d3d12.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("7F91CE67-090C-4BB7-B78E-ED8FF2E31DA0")]
    public unsafe partial struct ID3D12VersionedRootSignatureDeserializer
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(ID3D12VersionedRootSignatureDeserializer* This, [NativeTypeName("REFIID")] Guid* riid, void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(ID3D12VersionedRootSignatureDeserializer* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(ID3D12VersionedRootSignatureDeserializer* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetRootSignatureDescAtVersion(ID3D12VersionedRootSignatureDeserializer* This, D3D_ROOT_SIGNATURE_VERSION convertToVersion, D3D12_VERSIONED_ROOT_SIGNATURE_DESC** ppDesc);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate D3D12_VERSIONED_ROOT_SIGNATURE_DESC* _GetUnconvertedRootSignatureDesc(ID3D12VersionedRootSignatureDeserializer* This);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("REFIID")] Guid* riid, void** ppvObject)
        {
            fixed (ID3D12VersionedRootSignatureDeserializer* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)(This, riid, ppvObject);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (ID3D12VersionedRootSignatureDeserializer* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(This);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (ID3D12VersionedRootSignatureDeserializer* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(This);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetRootSignatureDescAtVersion(D3D_ROOT_SIGNATURE_VERSION convertToVersion, D3D12_VERSIONED_ROOT_SIGNATURE_DESC** ppDesc)
        {
            fixed (ID3D12VersionedRootSignatureDeserializer* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetRootSignatureDescAtVersion>(lpVtbl->GetRootSignatureDescAtVersion)(This, convertToVersion, ppDesc);
            }
        }

        public D3D12_VERSIONED_ROOT_SIGNATURE_DESC* GetUnconvertedRootSignatureDesc()
        {
            fixed (ID3D12VersionedRootSignatureDeserializer* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetUnconvertedRootSignatureDesc>(lpVtbl->GetUnconvertedRootSignatureDesc)(This);
            }
        }

        public partial struct Vtbl
        {
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;

            public IntPtr GetRootSignatureDescAtVersion;

            public IntPtr GetUnconvertedRootSignatureDesc;
        }
    }
}
