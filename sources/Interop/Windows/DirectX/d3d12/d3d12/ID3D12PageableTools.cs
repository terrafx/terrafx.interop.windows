// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.618.5
// Original source is Copyright © Microsoft. Licensed under the MIT license

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX;

/// <include file='ID3D12PageableTools.xml' path='doc/member[@name="ID3D12PageableTools"]/*' />
[Guid("8F1359DB-D8D1-42F9-B5CF-79F4CBAD0D3D")]
[NativeTypeName("struct ID3D12PageableTools : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ID3D12PageableTools : ID3D12PageableTools.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_ID3D12PageableTools);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12PageableTools*, Guid*, void**, int>)(lpVtbl[0]))((ID3D12PageableTools*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12PageableTools*, uint>)(lpVtbl[1]))((ID3D12PageableTools*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12PageableTools*, uint>)(lpVtbl[2]))((ID3D12PageableTools*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ID3D12PageableTools.xml' path='doc/member[@name="ID3D12PageableTools.GetAllocation"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetAllocation(D3D12_GPU_VIRTUAL_ADDRESS_RANGE* pAllocation)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12PageableTools*, D3D12_GPU_VIRTUAL_ADDRESS_RANGE*, int>)(lpVtbl[3]))((ID3D12PageableTools*)Unsafe.AsPointer(ref this), pAllocation);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetAllocation(D3D12_GPU_VIRTUAL_ADDRESS_RANGE* pAllocation);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

        [NativeTypeName("HRESULT (D3D12_GPU_VIRTUAL_ADDRESS_RANGE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, D3D12_GPU_VIRTUAL_ADDRESS_RANGE*, int> GetAllocation;
    }
}
