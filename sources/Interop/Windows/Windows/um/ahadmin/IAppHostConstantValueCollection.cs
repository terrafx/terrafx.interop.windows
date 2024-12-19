// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ahadmin.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IAppHostConstantValueCollection.xml' path='doc/member[@name="IAppHostConstantValueCollection"]/*' />
[Guid("5B5A68E6-8B9F-45E1-8199-A95FFCCDFFFF")]
[NativeTypeName("struct IAppHostConstantValueCollection : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IAppHostConstantValueCollection : IAppHostConstantValueCollection.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppHostConstantValueCollection));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostConstantValueCollection*, Guid*, void**, int>)(lpVtbl[0]))((IAppHostConstantValueCollection*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostConstantValueCollection*, uint>)(lpVtbl[1]))((IAppHostConstantValueCollection*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostConstantValueCollection*, uint>)(lpVtbl[2]))((IAppHostConstantValueCollection*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IAppHostConstantValueCollection.xml' path='doc/member[@name="IAppHostConstantValueCollection.get_Count"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT get_Count([NativeTypeName("DWORD *")] uint* pcCount)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostConstantValueCollection*, uint*, int>)(lpVtbl[3]))((IAppHostConstantValueCollection*)Unsafe.AsPointer(ref this), pcCount);
    }

    /// <include file='IAppHostConstantValueCollection.xml' path='doc/member[@name="IAppHostConstantValueCollection.get_Item"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT get_Item(VARIANT cIndex, IAppHostConstantValue** ppConstantValue)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostConstantValueCollection*, VARIANT, IAppHostConstantValue**, int>)(lpVtbl[4]))((IAppHostConstantValueCollection*)Unsafe.AsPointer(ref this), cIndex, ppConstantValue);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT get_Count([NativeTypeName("DWORD *")] uint* pcCount);

        [VtblIndex(4)]
        HRESULT get_Item(VARIANT cIndex, IAppHostConstantValue** ppConstantValue);
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

        [NativeTypeName("HRESULT (VARIANT, IAppHostConstantValue **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, VARIANT, IAppHostConstantValue**, int> get_Item;
    }
}
