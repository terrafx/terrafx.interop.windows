// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("DE5FA827-9BF9-4F26-89FF-D7F56FDE3860")]
    [NativeTypeName("struct ID3D12StateObjectProperties : IUnknown")]
    public unsafe partial struct ID3D12StateObjectProperties
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<ID3D12StateObjectProperties*, Guid*, void**, int>)(lpVtbl[0]))((ID3D12StateObjectProperties*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<ID3D12StateObjectProperties*, uint>)(lpVtbl[1]))((ID3D12StateObjectProperties*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<ID3D12StateObjectProperties*, uint>)(lpVtbl[2]))((ID3D12StateObjectProperties*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("void *")]
        public void* GetShaderIdentifier([NativeTypeName("LPCWSTR")] ushort* pExportName)
        {
            return ((delegate* stdcall<ID3D12StateObjectProperties*, ushort*, void*>)(lpVtbl[3]))((ID3D12StateObjectProperties*)Unsafe.AsPointer(ref this), pExportName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("UINT64")]
        public ulong GetShaderStackSize([NativeTypeName("LPCWSTR")] ushort* pExportName)
        {
            return ((delegate* stdcall<ID3D12StateObjectProperties*, ushort*, ulong>)(lpVtbl[4]))((ID3D12StateObjectProperties*)Unsafe.AsPointer(ref this), pExportName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("UINT64")]
        public ulong GetPipelineStackSize()
        {
            return ((delegate* stdcall<ID3D12StateObjectProperties*, ulong>)(lpVtbl[5]))((ID3D12StateObjectProperties*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void SetPipelineStackSize([NativeTypeName("UINT64")] ulong PipelineStackSizeInBytes)
        {
            ((delegate* stdcall<ID3D12StateObjectProperties*, ulong, void>)(lpVtbl[6]))((ID3D12StateObjectProperties*)Unsafe.AsPointer(ref this), PipelineStackSizeInBytes);
        }
    }
}
