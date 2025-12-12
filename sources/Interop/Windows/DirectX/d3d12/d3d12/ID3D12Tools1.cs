// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.618.5
// Original source is Copyright © Microsoft. Licensed under the MIT license

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX;

/// <include file='ID3D12Tools1.xml' path='doc/member[@name="ID3D12Tools1"]/*' />
[Guid("E4FBC019-DD3C-43E1-8F32-7F649575F0A0")]
[NativeTypeName("struct ID3D12Tools1 : ID3D12Tools")]
[NativeInheritance("ID3D12Tools")]
public unsafe partial struct ID3D12Tools1 : ID3D12Tools1.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_ID3D12Tools1);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12Tools1*, Guid*, void**, int>)(lpVtbl[0]))((ID3D12Tools1*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12Tools1*, uint>)(lpVtbl[1]))((ID3D12Tools1*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12Tools1*, uint>)(lpVtbl[2]))((ID3D12Tools1*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="ID3D12Tools.EnableShaderInstrumentation" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public void EnableShaderInstrumentation(BOOL bEnable)
    {
        ((delegate* unmanaged[MemberFunction]<ID3D12Tools1*, BOOL, void>)(lpVtbl[3]))((ID3D12Tools1*)Unsafe.AsPointer(ref this), bEnable);
    }

    /// <inheritdoc cref="ID3D12Tools.ShaderInstrumentationEnabled" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public BOOL ShaderInstrumentationEnabled()
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12Tools1*, int>)(lpVtbl[4]))((ID3D12Tools1*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ID3D12Tools1.xml' path='doc/member[@name="ID3D12Tools1.ReserveGPUVARangesAtCreate"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT ReserveGPUVARangesAtCreate(D3D12_GPU_VIRTUAL_ADDRESS_RANGE* pRanges, uint uiNumRanges)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12Tools1*, D3D12_GPU_VIRTUAL_ADDRESS_RANGE*, uint, int>)(lpVtbl[5]))((ID3D12Tools1*)Unsafe.AsPointer(ref this), pRanges, uiNumRanges);
    }

    /// <include file='ID3D12Tools1.xml' path='doc/member[@name="ID3D12Tools1.ClearReservedGPUVARangesList"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public void ClearReservedGPUVARangesList()
    {
        ((delegate* unmanaged[MemberFunction]<ID3D12Tools1*, void>)(lpVtbl[6]))((ID3D12Tools1*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : ID3D12Tools.Interface
    {
        [VtblIndex(5)]
        HRESULT ReserveGPUVARangesAtCreate(D3D12_GPU_VIRTUAL_ADDRESS_RANGE* pRanges, uint uiNumRanges);

        [VtblIndex(6)]
        void ClearReservedGPUVARangesList();
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

        [NativeTypeName("void (BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BOOL, void> EnableShaderInstrumentation;

        [NativeTypeName("BOOL () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> ShaderInstrumentationEnabled;

        [NativeTypeName("HRESULT (D3D12_GPU_VIRTUAL_ADDRESS_RANGE *, UINT) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, D3D12_GPU_VIRTUAL_ADDRESS_RANGE*, uint, int> ReserveGPUVARangesAtCreate;

        [NativeTypeName("void () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, void> ClearReservedGPUVARangesList;
    }
}
