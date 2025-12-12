// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.618.5
// Original source is Copyright © Microsoft. Licensed under the MIT license

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX;

/// <include file='ID3D12StateObjectDatabaseFactory.xml' path='doc/member[@name="ID3D12StateObjectDatabaseFactory"]/*' />
[Guid("F5B066F0-648A-4611-BD41-27FD0948B9EB")]
[NativeTypeName("struct ID3D12StateObjectDatabaseFactory : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ID3D12StateObjectDatabaseFactory : ID3D12StateObjectDatabaseFactory.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_ID3D12StateObjectDatabaseFactory);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12StateObjectDatabaseFactory*, Guid*, void**, int>)(lpVtbl[0]))((ID3D12StateObjectDatabaseFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12StateObjectDatabaseFactory*, uint>)(lpVtbl[1]))((ID3D12StateObjectDatabaseFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12StateObjectDatabaseFactory*, uint>)(lpVtbl[2]))((ID3D12StateObjectDatabaseFactory*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ID3D12StateObjectDatabaseFactory.xml' path='doc/member[@name="ID3D12StateObjectDatabaseFactory.CreateStateObjectDatabaseFromFile"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT CreateStateObjectDatabaseFromFile([NativeTypeName("LPCWSTR")] char* pDatabaseFile, D3D12_STATE_OBJECT_DATABASE_FLAGS flags, [NativeTypeName("const IID &")] Guid* riid, void** ppvStateObjectDatabase)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12StateObjectDatabaseFactory*, char*, D3D12_STATE_OBJECT_DATABASE_FLAGS, Guid*, void**, int>)(lpVtbl[3]))((ID3D12StateObjectDatabaseFactory*)Unsafe.AsPointer(ref this), pDatabaseFile, flags, riid, ppvStateObjectDatabase);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT CreateStateObjectDatabaseFromFile([NativeTypeName("LPCWSTR")] char* pDatabaseFile, D3D12_STATE_OBJECT_DATABASE_FLAGS flags, [NativeTypeName("const IID &")] Guid* riid, void** ppvStateObjectDatabase);
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

        [NativeTypeName("HRESULT (LPCWSTR, D3D12_STATE_OBJECT_DATABASE_FLAGS, const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, D3D12_STATE_OBJECT_DATABASE_FLAGS, Guid*, void**, int> CreateStateObjectDatabaseFromFile;
    }
}
