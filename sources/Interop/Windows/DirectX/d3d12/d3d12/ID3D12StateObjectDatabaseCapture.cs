// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.620.2
// Original source is Copyright © Microsoft. Licensed under the MIT license

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX;

/// <include file='ID3D12StateObjectDatabaseCapture.xml' path='doc/member[@name="ID3D12StateObjectDatabaseCapture"]/*' />
[Guid("D67447BC-4D6C-4CA5-A2A8-DEEEA4C145C4")]
[NativeTypeName("struct ID3D12StateObjectDatabaseCapture : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ID3D12StateObjectDatabaseCapture : ID3D12StateObjectDatabaseCapture.Interface, INativeGuid
{
    /// <include file='ID3D12StateObjectDatabaseCapture.xml' path='doc/member[@name="ID3D12StateObjectDatabaseCapture.INativeGuid.NativeGuid"]/*' />
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_ID3D12StateObjectDatabaseCapture);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12StateObjectDatabaseCapture*, Guid*, void**, int>)(lpVtbl[0]))((ID3D12StateObjectDatabaseCapture*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12StateObjectDatabaseCapture*, uint>)(lpVtbl[1]))((ID3D12StateObjectDatabaseCapture*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12StateObjectDatabaseCapture*, uint>)(lpVtbl[2]))((ID3D12StateObjectDatabaseCapture*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ID3D12StateObjectDatabaseCapture.xml' path='doc/member[@name="ID3D12StateObjectDatabaseCapture.EnableCapture"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public void EnableCapture(BOOL Enable, [NativeTypeName("LPCWSTR")] char* pDatabaseFile)
    {
        ((delegate* unmanaged[MemberFunction]<ID3D12StateObjectDatabaseCapture*, BOOL, char*, void>)(lpVtbl[3]))((ID3D12StateObjectDatabaseCapture*)Unsafe.AsPointer(ref this), Enable, pDatabaseFile);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        void EnableCapture(BOOL Enable, [NativeTypeName("LPCWSTR")] char* pDatabaseFile);
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

        [NativeTypeName("void (BOOL, LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BOOL, char*, void> EnableCapture;
    }
}
