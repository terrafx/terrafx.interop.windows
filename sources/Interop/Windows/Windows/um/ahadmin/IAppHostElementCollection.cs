// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ahadmin.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IAppHostElementCollection.xml' path='doc/member[@name="IAppHostElementCollection"]/*' />
[Guid("C8550BFF-5281-4B1E-AC34-99B6FA38464D")]
[NativeTypeName("struct IAppHostElementCollection : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IAppHostElementCollection : IAppHostElementCollection.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IAppHostElementCollection);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostElementCollection*, Guid*, void**, int>)(lpVtbl[0]))((IAppHostElementCollection*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostElementCollection*, uint>)(lpVtbl[1]))((IAppHostElementCollection*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostElementCollection*, uint>)(lpVtbl[2]))((IAppHostElementCollection*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IAppHostElementCollection.xml' path='doc/member[@name="IAppHostElementCollection.get_Count"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT get_Count([NativeTypeName("DWORD *")] uint* pcElementCount)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostElementCollection*, uint*, int>)(lpVtbl[3]))((IAppHostElementCollection*)Unsafe.AsPointer(ref this), pcElementCount);
    }

    /// <include file='IAppHostElementCollection.xml' path='doc/member[@name="IAppHostElementCollection.get_Item"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT get_Item(VARIANT cIndex, IAppHostElement** ppElement)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostElementCollection*, VARIANT, IAppHostElement**, int>)(lpVtbl[4]))((IAppHostElementCollection*)Unsafe.AsPointer(ref this), cIndex, ppElement);
    }

    /// <include file='IAppHostElementCollection.xml' path='doc/member[@name="IAppHostElementCollection.AddElement"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT AddElement(IAppHostElement* pElement, int cPosition = -1)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostElementCollection*, IAppHostElement*, int, int>)(lpVtbl[5]))((IAppHostElementCollection*)Unsafe.AsPointer(ref this), pElement, cPosition);
    }

    /// <include file='IAppHostElementCollection.xml' path='doc/member[@name="IAppHostElementCollection.DeleteElement"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT DeleteElement(VARIANT cIndex)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostElementCollection*, VARIANT, int>)(lpVtbl[6]))((IAppHostElementCollection*)Unsafe.AsPointer(ref this), cIndex);
    }

    /// <include file='IAppHostElementCollection.xml' path='doc/member[@name="IAppHostElementCollection.Clear"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT Clear()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostElementCollection*, int>)(lpVtbl[7]))((IAppHostElementCollection*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IAppHostElementCollection.xml' path='doc/member[@name="IAppHostElementCollection.CreateNewElement"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT CreateNewElement([NativeTypeName("BSTR")] char* bstrElementName, IAppHostElement** ppElement)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostElementCollection*, char*, IAppHostElement**, int>)(lpVtbl[8]))((IAppHostElementCollection*)Unsafe.AsPointer(ref this), bstrElementName, ppElement);
    }

    /// <include file='IAppHostElementCollection.xml' path='doc/member[@name="IAppHostElementCollection.get_Schema"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_Schema(IAppHostCollectionSchema** ppSchema)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostElementCollection*, IAppHostCollectionSchema**, int>)(lpVtbl[9]))((IAppHostElementCollection*)Unsafe.AsPointer(ref this), ppSchema);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT get_Count([NativeTypeName("DWORD *")] uint* pcElementCount);

        [VtblIndex(4)]
        HRESULT get_Item(VARIANT cIndex, IAppHostElement** ppElement);

        [VtblIndex(5)]
        HRESULT AddElement(IAppHostElement* pElement, int cPosition = -1);

        [VtblIndex(6)]
        HRESULT DeleteElement(VARIANT cIndex);

        [VtblIndex(7)]
        HRESULT Clear();

        [VtblIndex(8)]
        HRESULT CreateNewElement([NativeTypeName("BSTR")] char* bstrElementName, IAppHostElement** ppElement);

        [VtblIndex(9)]
        HRESULT get_Schema(IAppHostCollectionSchema** ppSchema);
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

        [NativeTypeName("HRESULT (VARIANT, IAppHostElement **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, VARIANT, IAppHostElement**, int> get_Item;

        [NativeTypeName("HRESULT (IAppHostElement *, INT) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAppHostElement*, int, int> AddElement;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, VARIANT, int> DeleteElement;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> Clear;

        [NativeTypeName("HRESULT (BSTR, IAppHostElement **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, IAppHostElement**, int> CreateNewElement;

        [NativeTypeName("HRESULT (IAppHostCollectionSchema **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAppHostCollectionSchema**, int> get_Schema;
    }
}
