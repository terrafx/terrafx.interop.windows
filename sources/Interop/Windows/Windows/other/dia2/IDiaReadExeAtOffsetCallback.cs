// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from dia2.h in the Debug Interface Access SDK
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IDiaReadExeAtOffsetCallback.xml' path='doc/member[@name="IDiaReadExeAtOffsetCallback"]/*' />
[Guid("587A461C-B80B-4F54-9194-5032589A6319")]
[NativeTypeName("struct IDiaReadExeAtOffsetCallback : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDiaReadExeAtOffsetCallback : IDiaReadExeAtOffsetCallback.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDiaReadExeAtOffsetCallback));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaReadExeAtOffsetCallback*, Guid*, void**, int>)(lpVtbl[0]))((IDiaReadExeAtOffsetCallback*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaReadExeAtOffsetCallback*, uint>)(lpVtbl[1]))((IDiaReadExeAtOffsetCallback*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaReadExeAtOffsetCallback*, uint>)(lpVtbl[2]))((IDiaReadExeAtOffsetCallback*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDiaReadExeAtOffsetCallback.xml' path='doc/member[@name="IDiaReadExeAtOffsetCallback.ReadExecutableAt"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT ReadExecutableAt([NativeTypeName("DWORDLONG")] ulong fileOffset, [NativeTypeName("DWORD")] uint cbData, [NativeTypeName("DWORD *")] uint* pcbData, byte* pbData)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaReadExeAtOffsetCallback*, ulong, uint, uint*, byte*, int>)(lpVtbl[3]))((IDiaReadExeAtOffsetCallback*)Unsafe.AsPointer(ref this), fileOffset, cbData, pcbData, pbData);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT ReadExecutableAt([NativeTypeName("DWORDLONG")] ulong fileOffset, [NativeTypeName("DWORD")] uint cbData, [NativeTypeName("DWORD *")] uint* pcbData, byte* pbData);
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

        [NativeTypeName("HRESULT (DWORDLONG, DWORD, DWORD *, BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ulong, uint, uint*, byte*, int> ReadExecutableAt;
    }
}
