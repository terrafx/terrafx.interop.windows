// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12sdklayers.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("09E0BF36-54AC-484F-8847-4BAEEAB6053F")]
    [NativeTypeName("struct ID3D12DebugCommandList : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ID3D12DebugCommandList
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ID3D12DebugCommandList*, Guid*, void**, int>)(lpVtbl[0]))((ID3D12DebugCommandList*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ID3D12DebugCommandList*, uint>)(lpVtbl[1]))((ID3D12DebugCommandList*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ID3D12DebugCommandList*, uint>)(lpVtbl[2]))((ID3D12DebugCommandList*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("BOOL")]
        public int AssertResourceState(ID3D12Resource* pResource, [NativeTypeName("UINT")] uint Subresource, [NativeTypeName("UINT")] uint State)
        {
            return ((delegate* unmanaged<ID3D12DebugCommandList*, ID3D12Resource*, uint, uint, int>)(lpVtbl[3]))((ID3D12DebugCommandList*)Unsafe.AsPointer(ref this), pResource, Subresource, State);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int SetFeatureMask(D3D12_DEBUG_FEATURE Mask)
        {
            return ((delegate* unmanaged<ID3D12DebugCommandList*, D3D12_DEBUG_FEATURE, int>)(lpVtbl[4]))((ID3D12DebugCommandList*)Unsafe.AsPointer(ref this), Mask);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public D3D12_DEBUG_FEATURE GetFeatureMask()
        {
            return ((delegate* unmanaged<ID3D12DebugCommandList*, D3D12_DEBUG_FEATURE>)(lpVtbl[5]))((ID3D12DebugCommandList*)Unsafe.AsPointer(ref this));
        }
    }
}
