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

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((ID3D12StateObjectProperties*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((ID3D12StateObjectProperties*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((ID3D12StateObjectProperties*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("void *")]
        public void* GetShaderIdentifier([NativeTypeName("LPCWSTR")] ushort* pExportName)
        {
            return lpVtbl->GetShaderIdentifier((ID3D12StateObjectProperties*)Unsafe.AsPointer(ref this), pExportName);
        }

        [return: NativeTypeName("UINT64")]
        public ulong GetShaderStackSize([NativeTypeName("LPCWSTR")] ushort* pExportName)
        {
            return lpVtbl->GetShaderStackSize((ID3D12StateObjectProperties*)Unsafe.AsPointer(ref this), pExportName);
        }

        [return: NativeTypeName("UINT64")]
        public ulong GetPipelineStackSize()
        {
            return lpVtbl->GetPipelineStackSize((ID3D12StateObjectProperties*)Unsafe.AsPointer(ref this));
        }

        public void SetPipelineStackSize([NativeTypeName("UINT64")] ulong PipelineStackSizeInBytes)
        {
            lpVtbl->SetPipelineStackSize((ID3D12StateObjectProperties*)Unsafe.AsPointer(ref this), PipelineStackSizeInBytes);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12StateObjectProperties*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12StateObjectProperties*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12StateObjectProperties*, uint> Release;

            [NativeTypeName("void *(LPCWSTR) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12StateObjectProperties*, ushort*, void*> GetShaderIdentifier;

            [NativeTypeName("UINT64 (LPCWSTR) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12StateObjectProperties*, ushort*, ulong> GetShaderStackSize;

            [NativeTypeName("UINT64 () __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12StateObjectProperties*, ulong> GetPipelineStackSize;

            [NativeTypeName("void (UINT64) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12StateObjectProperties*, ulong, void> SetPipelineStackSize;
        }
    }
}
