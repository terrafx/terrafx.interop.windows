// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.620.2
// Original source is Copyright © Microsoft. Licensed under the MIT license

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX;

/// <include file='ID3D12StateObjectDatabaseFactory1.xml' path='doc/member[@name="ID3D12StateObjectDatabaseFactory1"]/*' />
[Guid("68A6585D-0AC7-4FA4-BA33-E3BD442F2833")]
[NativeTypeName("struct ID3D12StateObjectDatabaseFactory1 : ID3D12StateObjectDatabaseFactory")]
[NativeInheritance("ID3D12StateObjectDatabaseFactory")]
public unsafe partial struct ID3D12StateObjectDatabaseFactory1 : ID3D12StateObjectDatabaseFactory1.Interface, INativeGuid
{
    /// <include file='ID3D12StateObjectDatabaseFactory1.xml' path='doc/member[@name="ID3D12StateObjectDatabaseFactory1.INativeGuid.NativeGuid"]/*' />
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_ID3D12StateObjectDatabaseFactory1);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12StateObjectDatabaseFactory1*, Guid*, void**, int>)(lpVtbl[0]))((ID3D12StateObjectDatabaseFactory1*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12StateObjectDatabaseFactory1*, uint>)(lpVtbl[1]))((ID3D12StateObjectDatabaseFactory1*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12StateObjectDatabaseFactory1*, uint>)(lpVtbl[2]))((ID3D12StateObjectDatabaseFactory1*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="ID3D12StateObjectDatabaseFactory.CreateStateObjectDatabaseFromFile" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT CreateStateObjectDatabaseFromFile([NativeTypeName("LPCWSTR")] char* pDatabaseFile, D3D12_STATE_OBJECT_DATABASE_FLAGS flags, [NativeTypeName("const IID &")] Guid* riid, void** ppvStateObjectDatabase)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12StateObjectDatabaseFactory1*, char*, D3D12_STATE_OBJECT_DATABASE_FLAGS, Guid*, void**, int>)(lpVtbl[3]))((ID3D12StateObjectDatabaseFactory1*)Unsafe.AsPointer(ref this), pDatabaseFile, flags, riid, ppvStateObjectDatabase);
    }

    /// <include file='ID3D12StateObjectDatabaseFactory1.xml' path='doc/member[@name="ID3D12StateObjectDatabaseFactory1.CreateStateObjectDatabaseFromFile1"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT CreateStateObjectDatabaseFromFile1([NativeTypeName("LPCWSTR")] char* pDatabaseFile, [NativeTypeName("const D3D12_STATE_OBJECT_DATABASE_DESC *")] D3D12_STATE_OBJECT_DATABASE_DESC* pDesc, ID3D12InfoQueue* pInfoQueue, [NativeTypeName("const IID &")] Guid* riid, void** ppvStateObjectDatabase)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12StateObjectDatabaseFactory1*, char*, D3D12_STATE_OBJECT_DATABASE_DESC*, ID3D12InfoQueue*, Guid*, void**, int>)(lpVtbl[4]))((ID3D12StateObjectDatabaseFactory1*)Unsafe.AsPointer(ref this), pDatabaseFile, pDesc, pInfoQueue, riid, ppvStateObjectDatabase);
    }

    public interface Interface : ID3D12StateObjectDatabaseFactory.Interface
    {
        [VtblIndex(4)]
        HRESULT CreateStateObjectDatabaseFromFile1([NativeTypeName("LPCWSTR")] char* pDatabaseFile, [NativeTypeName("const D3D12_STATE_OBJECT_DATABASE_DESC *")] D3D12_STATE_OBJECT_DATABASE_DESC* pDesc, ID3D12InfoQueue* pInfoQueue, [NativeTypeName("const IID &")] Guid* riid, void** ppvStateObjectDatabase);
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

        [NativeTypeName("HRESULT (LPCWSTR, const D3D12_STATE_OBJECT_DATABASE_DESC *, ID3D12InfoQueue *, const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, D3D12_STATE_OBJECT_DATABASE_DESC*, ID3D12InfoQueue*, Guid*, void**, int> CreateStateObjectDatabaseFromFile1;
    }
}
