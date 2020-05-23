// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("DE5FA827-9BF9-4F26-89FF-D7F56FDE3860")]
    public unsafe partial struct ID3D12StateObjectProperties
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(ID3D12StateObjectProperties* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(ID3D12StateObjectProperties* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(ID3D12StateObjectProperties* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("void *")]
        public delegate void* _GetShaderIdentifier(ID3D12StateObjectProperties* pThis, [NativeTypeName("LPCWSTR")] ushort* pExportName);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("UINT64")]
        public delegate ulong _GetShaderStackSize(ID3D12StateObjectProperties* pThis, [NativeTypeName("LPCWSTR")] ushort* pExportName);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("UINT64")]
        public delegate ulong _GetPipelineStackSize(ID3D12StateObjectProperties* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _SetPipelineStackSize(ID3D12StateObjectProperties* pThis, [NativeTypeName("UINT64")] ulong PipelineStackSizeInBytes);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((ID3D12StateObjectProperties*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((ID3D12StateObjectProperties*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((ID3D12StateObjectProperties*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("void *")]
        public void* GetShaderIdentifier([NativeTypeName("LPCWSTR")] ushort* pExportName)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetShaderIdentifier>(lpVtbl->GetShaderIdentifier)((ID3D12StateObjectProperties*)Unsafe.AsPointer(ref this), pExportName);
        }

        [return: NativeTypeName("UINT64")]
        public ulong GetShaderStackSize([NativeTypeName("LPCWSTR")] ushort* pExportName)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetShaderStackSize>(lpVtbl->GetShaderStackSize)((ID3D12StateObjectProperties*)Unsafe.AsPointer(ref this), pExportName);
        }

        [return: NativeTypeName("UINT64")]
        public ulong GetPipelineStackSize()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetPipelineStackSize>(lpVtbl->GetPipelineStackSize)((ID3D12StateObjectProperties*)Unsafe.AsPointer(ref this));
        }

        public void SetPipelineStackSize([NativeTypeName("UINT64")] ulong PipelineStackSizeInBytes)
        {
            Marshal.GetDelegateForFunctionPointer<_SetPipelineStackSize>(lpVtbl->SetPipelineStackSize)((ID3D12StateObjectProperties*)Unsafe.AsPointer(ref this), PipelineStackSizeInBytes);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("void *(LPCWSTR) __attribute__((stdcall))")]
            public IntPtr GetShaderIdentifier;

            [NativeTypeName("UINT64 (LPCWSTR) __attribute__((stdcall))")]
            public IntPtr GetShaderStackSize;

            [NativeTypeName("UINT64 () __attribute__((stdcall))")]
            public IntPtr GetPipelineStackSize;

            [NativeTypeName("void (UINT64) __attribute__((stdcall))")]
            public IntPtr SetPipelineStackSize;
        }
    }
}
