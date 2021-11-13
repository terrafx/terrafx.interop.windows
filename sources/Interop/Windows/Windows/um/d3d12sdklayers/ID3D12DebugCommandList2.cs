// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12sdklayers.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    [Guid("AEB575CF-4E06-48BE-BA3B-C450FC96652E")]
    [NativeTypeName("struct ID3D12DebugCommandList2 : ID3D12DebugCommandList")]
    [NativeInheritance("ID3D12DebugCommandList")]
    public unsafe partial struct ID3D12DebugCommandList2 : ID3D12DebugCommandList2.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ID3D12DebugCommandList2*, Guid*, void**, int>)(lpVtbl[0]))((ID3D12DebugCommandList2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ID3D12DebugCommandList2*, uint>)(lpVtbl[1]))((ID3D12DebugCommandList2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ID3D12DebugCommandList2*, uint>)(lpVtbl[2]))((ID3D12DebugCommandList2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public BOOL AssertResourceState(ID3D12Resource* pResource, uint Subresource, uint State)
        {
            return ((delegate* unmanaged<ID3D12DebugCommandList2*, ID3D12Resource*, uint, uint, int>)(lpVtbl[3]))((ID3D12DebugCommandList2*)Unsafe.AsPointer(ref this), pResource, Subresource, State);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT SetFeatureMask(D3D12_DEBUG_FEATURE Mask)
        {
            return ((delegate* unmanaged<ID3D12DebugCommandList2*, D3D12_DEBUG_FEATURE, int>)(lpVtbl[4]))((ID3D12DebugCommandList2*)Unsafe.AsPointer(ref this), Mask);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public D3D12_DEBUG_FEATURE GetFeatureMask()
        {
            return ((delegate* unmanaged<ID3D12DebugCommandList2*, D3D12_DEBUG_FEATURE>)(lpVtbl[5]))((ID3D12DebugCommandList2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT SetDebugParameter(D3D12_DEBUG_COMMAND_LIST_PARAMETER_TYPE Type, [NativeTypeName("const void *")] void* pData, uint DataSize)
        {
            return ((delegate* unmanaged<ID3D12DebugCommandList2*, D3D12_DEBUG_COMMAND_LIST_PARAMETER_TYPE, void*, uint, int>)(lpVtbl[6]))((ID3D12DebugCommandList2*)Unsafe.AsPointer(ref this), Type, pData, DataSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT GetDebugParameter(D3D12_DEBUG_COMMAND_LIST_PARAMETER_TYPE Type, void* pData, uint DataSize)
        {
            return ((delegate* unmanaged<ID3D12DebugCommandList2*, D3D12_DEBUG_COMMAND_LIST_PARAMETER_TYPE, void*, uint, int>)(lpVtbl[7]))((ID3D12DebugCommandList2*)Unsafe.AsPointer(ref this), Type, pData, DataSize);
        }

        public interface Interface : ID3D12DebugCommandList.Interface
        {
            [VtblIndex(6)]
            HRESULT SetDebugParameter(D3D12_DEBUG_COMMAND_LIST_PARAMETER_TYPE Type, [NativeTypeName("const void *")] void* pData, uint DataSize);

            [VtblIndex(7)]
            HRESULT GetDebugParameter(D3D12_DEBUG_COMMAND_LIST_PARAMETER_TYPE Type, void* pData, uint DataSize);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D12DebugCommandList2*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D12DebugCommandList2*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D12DebugCommandList2*, uint> Release;

            [NativeTypeName("BOOL (ID3D12Resource *, UINT, UINT) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D12DebugCommandList2*, ID3D12Resource*, uint, uint, int> AssertResourceState;

            [NativeTypeName("HRESULT (D3D12_DEBUG_FEATURE) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D12DebugCommandList2*, D3D12_DEBUG_FEATURE, int> SetFeatureMask;

            [NativeTypeName("D3D12_DEBUG_FEATURE () __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D12DebugCommandList2*, D3D12_DEBUG_FEATURE> GetFeatureMask;

            [NativeTypeName("HRESULT (D3D12_DEBUG_COMMAND_LIST_PARAMETER_TYPE, const void *, UINT) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D12DebugCommandList2*, D3D12_DEBUG_COMMAND_LIST_PARAMETER_TYPE, void*, uint, int> SetDebugParameter;

            [NativeTypeName("HRESULT (D3D12_DEBUG_COMMAND_LIST_PARAMETER_TYPE, void *, UINT) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D12DebugCommandList2*, D3D12_DEBUG_COMMAND_LIST_PARAMETER_TYPE, void*, uint, int> GetDebugParameter;
        }
    }
}
