// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from dia2.h in the Debug Interface Access SDK
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IDiaReadExeAtRVACallback.xml' path='doc/member[@name="IDiaReadExeAtRVACallback"]/*' />
[Guid("8E3F80CA-7517-432A-BA07-285134AAEA8E")]
[NativeTypeName("struct IDiaReadExeAtRVACallback : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDiaReadExeAtRVACallback : IDiaReadExeAtRVACallback.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDiaReadExeAtRVACallback));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaReadExeAtRVACallback*, Guid*, void**, int>)(lpVtbl[0]))((IDiaReadExeAtRVACallback*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaReadExeAtRVACallback*, uint>)(lpVtbl[1]))((IDiaReadExeAtRVACallback*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaReadExeAtRVACallback*, uint>)(lpVtbl[2]))((IDiaReadExeAtRVACallback*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDiaReadExeAtRVACallback.xml' path='doc/member[@name="IDiaReadExeAtRVACallback.ReadExecutableAtRVA"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT ReadExecutableAtRVA([NativeTypeName("DWORD")] uint relativeVirtualAddress, [NativeTypeName("DWORD")] uint cbData, [NativeTypeName("DWORD *")] uint* pcbData, byte* pbData)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaReadExeAtRVACallback*, uint, uint, uint*, byte*, int>)(lpVtbl[3]))((IDiaReadExeAtRVACallback*)Unsafe.AsPointer(ref this), relativeVirtualAddress, cbData, pcbData, pbData);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT ReadExecutableAtRVA([NativeTypeName("DWORD")] uint relativeVirtualAddress, [NativeTypeName("DWORD")] uint cbData, [NativeTypeName("DWORD *")] uint* pcbData, byte* pbData);
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

        [NativeTypeName("HRESULT (DWORD, DWORD, DWORD *, BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint, uint*, byte*, int> ReadExecutableAtRVA;
    }
}
