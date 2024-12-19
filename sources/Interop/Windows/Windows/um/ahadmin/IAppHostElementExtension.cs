// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ahadmin.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IAppHostElementExtension.xml' path='doc/member[@name="IAppHostElementExtension"]/*' />
[Guid("518EB37D-1FF4-42DD-86C3-3140BC35B823")]
[NativeTypeName("struct IAppHostElementExtension : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IAppHostElementExtension : IAppHostElementExtension.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppHostElementExtension));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostElementExtension*, Guid*, void**, int>)(lpVtbl[0]))((IAppHostElementExtension*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostElementExtension*, uint>)(lpVtbl[1]))((IAppHostElementExtension*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostElementExtension*, uint>)(lpVtbl[2]))((IAppHostElementExtension*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IAppHostElementExtension.xml' path='doc/member[@name="IAppHostElementExtension.ProvideElement"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT ProvideElement(IAppHostElement* pNewElement)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostElementExtension*, IAppHostElement*, int>)(lpVtbl[3]))((IAppHostElementExtension*)Unsafe.AsPointer(ref this), pNewElement);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT ProvideElement(IAppHostElement* pNewElement);
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

        [NativeTypeName("HRESULT (IAppHostElement *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAppHostElement*, int> ProvideElement;
    }
}
