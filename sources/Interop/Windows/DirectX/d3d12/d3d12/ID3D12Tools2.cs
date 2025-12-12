// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.618.5
// Original source is Copyright © Microsoft. Licensed under the MIT license

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX;

/// <include file='ID3D12Tools2.xml' path='doc/member[@name="ID3D12Tools2"]/*' />
[Guid("01D393C5-C9B0-42A1-958C-C26B02D4D097")]
[NativeTypeName("struct ID3D12Tools2 : ID3D12Tools1")]
[NativeInheritance("ID3D12Tools1")]
public unsafe partial struct ID3D12Tools2 : ID3D12Tools2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_ID3D12Tools2);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12Tools2*, Guid*, void**, int>)(lpVtbl[0]))((ID3D12Tools2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12Tools2*, uint>)(lpVtbl[1]))((ID3D12Tools2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12Tools2*, uint>)(lpVtbl[2]))((ID3D12Tools2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="ID3D12Tools.EnableShaderInstrumentation" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public void EnableShaderInstrumentation(BOOL bEnable)
    {
        ((delegate* unmanaged[MemberFunction]<ID3D12Tools2*, BOOL, void>)(lpVtbl[3]))((ID3D12Tools2*)Unsafe.AsPointer(ref this), bEnable);
    }

    /// <inheritdoc cref="ID3D12Tools.ShaderInstrumentationEnabled" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public BOOL ShaderInstrumentationEnabled()
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12Tools2*, int>)(lpVtbl[4]))((ID3D12Tools2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="ID3D12Tools1.ReserveGPUVARangesAtCreate" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT ReserveGPUVARangesAtCreate(D3D12_GPU_VIRTUAL_ADDRESS_RANGE* pRanges, uint uiNumRanges)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12Tools2*, D3D12_GPU_VIRTUAL_ADDRESS_RANGE*, uint, int>)(lpVtbl[5]))((ID3D12Tools2*)Unsafe.AsPointer(ref this), pRanges, uiNumRanges);
    }

    /// <inheritdoc cref="ID3D12Tools1.ClearReservedGPUVARangesList" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public void ClearReservedGPUVARangesList()
    {
        ((delegate* unmanaged[MemberFunction]<ID3D12Tools2*, void>)(lpVtbl[6]))((ID3D12Tools2*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ID3D12Tools2.xml' path='doc/member[@name="ID3D12Tools2.SetApplicationSpecificDriverState"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetApplicationSpecificDriverState(IUnknown* pAdapter, ID3DBlob* pBlob)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12Tools2*, IUnknown*, ID3DBlob*, int>)(lpVtbl[7]))((ID3D12Tools2*)Unsafe.AsPointer(ref this), pAdapter, pBlob);
    }

    public interface Interface : ID3D12Tools1.Interface
    {
        [VtblIndex(7)]
        HRESULT SetApplicationSpecificDriverState(IUnknown* pAdapter, ID3DBlob* pBlob);
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

        [NativeTypeName("HRESULT (IUnknown *, ID3DBlob *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUnknown*, ID3DBlob*, int> SetApplicationSpecificDriverState;
    }
}
