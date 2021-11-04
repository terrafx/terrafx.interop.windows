// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12sdklayers.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("102CA951-311B-4B01-B11F-ECB83E061B37")]
    [NativeTypeName("struct ID3D12DebugCommandList1 : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ID3D12DebugCommandList1
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ID3D12DebugCommandList1*, Guid*, void**, int>)(lpVtbl[0]))((ID3D12DebugCommandList1*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ID3D12DebugCommandList1*, uint>)(lpVtbl[1]))((ID3D12DebugCommandList1*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ID3D12DebugCommandList1*, uint>)(lpVtbl[2]))((ID3D12DebugCommandList1*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public BOOL AssertResourceState(ID3D12Resource* pResource, uint Subresource, uint State)
        {
            return ((delegate* unmanaged<ID3D12DebugCommandList1*, ID3D12Resource*, uint, uint, int>)(lpVtbl[3]))((ID3D12DebugCommandList1*)Unsafe.AsPointer(ref this), pResource, Subresource, State);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT SetDebugParameter(D3D12_DEBUG_COMMAND_LIST_PARAMETER_TYPE Type, [NativeTypeName("const void *")] void* pData, uint DataSize)
        {
            return ((delegate* unmanaged<ID3D12DebugCommandList1*, D3D12_DEBUG_COMMAND_LIST_PARAMETER_TYPE, void*, uint, int>)(lpVtbl[4]))((ID3D12DebugCommandList1*)Unsafe.AsPointer(ref this), Type, pData, DataSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetDebugParameter(D3D12_DEBUG_COMMAND_LIST_PARAMETER_TYPE Type, void* pData, uint DataSize)
        {
            return ((delegate* unmanaged<ID3D12DebugCommandList1*, D3D12_DEBUG_COMMAND_LIST_PARAMETER_TYPE, void*, uint, int>)(lpVtbl[5]))((ID3D12DebugCommandList1*)Unsafe.AsPointer(ref this), Type, pData, DataSize);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D12DebugCommandList1*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D12DebugCommandList1*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D12DebugCommandList1*, uint> Release;

            [NativeTypeName("BOOL (ID3D12Resource *, UINT, UINT) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D12DebugCommandList1*, ID3D12Resource*, uint, uint, int> AssertResourceState;

            [NativeTypeName("HRESULT (D3D12_DEBUG_COMMAND_LIST_PARAMETER_TYPE, const void *, UINT) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D12DebugCommandList1*, D3D12_DEBUG_COMMAND_LIST_PARAMETER_TYPE, void*, uint, int> SetDebugParameter;

            [NativeTypeName("HRESULT (D3D12_DEBUG_COMMAND_LIST_PARAMETER_TYPE, void *, UINT) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D12DebugCommandList1*, D3D12_DEBUG_COMMAND_LIST_PARAMETER_TYPE, void*, uint, int> GetDebugParameter;
        }
    }
}
