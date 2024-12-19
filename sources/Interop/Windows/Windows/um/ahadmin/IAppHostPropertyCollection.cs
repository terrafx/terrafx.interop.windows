// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ahadmin.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IAppHostPropertyCollection.xml' path='doc/member[@name="IAppHostPropertyCollection"]/*' />
[Guid("0191775E-BCFF-445A-B4F4-3BDDA54E2816")]
[NativeTypeName("struct IAppHostPropertyCollection : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IAppHostPropertyCollection : IAppHostPropertyCollection.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppHostPropertyCollection));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostPropertyCollection*, Guid*, void**, int>)(lpVtbl[0]))((IAppHostPropertyCollection*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostPropertyCollection*, uint>)(lpVtbl[1]))((IAppHostPropertyCollection*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostPropertyCollection*, uint>)(lpVtbl[2]))((IAppHostPropertyCollection*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IAppHostPropertyCollection.xml' path='doc/member[@name="IAppHostPropertyCollection.get_Count"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT get_Count([NativeTypeName("DWORD *")] uint* pcCount)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostPropertyCollection*, uint*, int>)(lpVtbl[3]))((IAppHostPropertyCollection*)Unsafe.AsPointer(ref this), pcCount);
    }

    /// <include file='IAppHostPropertyCollection.xml' path='doc/member[@name="IAppHostPropertyCollection.get_Item"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT get_Item(VARIANT cIndex, IAppHostProperty** ppProperty)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostPropertyCollection*, VARIANT, IAppHostProperty**, int>)(lpVtbl[4]))((IAppHostPropertyCollection*)Unsafe.AsPointer(ref this), cIndex, ppProperty);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT get_Count([NativeTypeName("DWORD *")] uint* pcCount);

        [VtblIndex(4)]
        HRESULT get_Item(VARIANT cIndex, IAppHostProperty** ppProperty);
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

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_Count;

        [NativeTypeName("HRESULT (VARIANT, IAppHostProperty **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, VARIANT, IAppHostProperty**, int> get_Item;
    }
}
