// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Presentation.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IPresentationContent.xml' path='doc/member[@name="IPresentationContent"]/*' />
[Guid("5668BB79-3D8E-415C-B215-F38020F2D252")]
[NativeTypeName("struct IPresentationContent : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IPresentationContent : IPresentationContent.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPresentationContent));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IPresentationContent*, Guid*, void**, int>)(lpVtbl[0]))((IPresentationContent*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IPresentationContent*, uint>)(lpVtbl[1]))((IPresentationContent*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IPresentationContent*, uint>)(lpVtbl[2]))((IPresentationContent*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IPresentationContent.xml' path='doc/member[@name="IPresentationContent.SetTag"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public void SetTag([NativeTypeName("UINT_PTR")] nuint tag)
    {
        ((delegate* unmanaged[MemberFunction]<IPresentationContent*, nuint, void>)(lpVtbl[3]))((IPresentationContent*)Unsafe.AsPointer(ref this), tag);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        void SetTag([NativeTypeName("UINT_PTR")] nuint tag);
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

        [NativeTypeName("void (UINT_PTR) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, nuint, void> SetTag;
    }
}
