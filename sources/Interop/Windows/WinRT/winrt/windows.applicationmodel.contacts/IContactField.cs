// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.contacts.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IContactField.xml' path='doc/member[@name="IContactField"]/*' />
[Guid("B176486A-D293-492C-A058-DB575B3E3C0F")]
[NativeTypeName("struct IContactField : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IContactField : IContactField.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IContactField));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactField*, Guid*, void**, int>)(lpVtbl[0]))((IContactField*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IContactField*, uint>)(lpVtbl[1]))((IContactField*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IContactField*, uint>)(lpVtbl[2]))((IContactField*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactField*, uint*, Guid**, int>)(lpVtbl[3]))((IContactField*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactField*, HSTRING*, int>)(lpVtbl[4]))((IContactField*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactField*, TrustLevel*, int>)(lpVtbl[5]))((IContactField*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IContactField.xml' path='doc/member[@name="IContactField.get_Type"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Type([NativeTypeName("ABI::Windows::ApplicationModel::Contacts::ContactFieldType *")] ContactFieldType* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactField*, ContactFieldType*, int>)(lpVtbl[6]))((IContactField*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactField.xml' path='doc/member[@name="IContactField.get_Category"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Category([NativeTypeName("ABI::Windows::ApplicationModel::Contacts::ContactFieldCategory *")] ContactFieldCategory* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactField*, ContactFieldCategory*, int>)(lpVtbl[7]))((IContactField*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactField.xml' path='doc/member[@name="IContactField.get_Name"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Name(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactField*, HSTRING*, int>)(lpVtbl[8]))((IContactField*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactField.xml' path='doc/member[@name="IContactField.get_Value"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_Value(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactField*, HSTRING*, int>)(lpVtbl[9]))((IContactField*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Type([NativeTypeName("ABI::Windows::ApplicationModel::Contacts::ContactFieldType *")] ContactFieldType* value);

        [VtblIndex(7)]
        HRESULT get_Category([NativeTypeName("ABI::Windows::ApplicationModel::Contacts::ContactFieldCategory *")] ContactFieldCategory* value);

        [VtblIndex(8)]
        HRESULT get_Name(HSTRING* value);

        [VtblIndex(9)]
        HRESULT get_Value(HSTRING* value);
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

        [NativeTypeName("HRESULT (ULONG *, IID **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, Guid**, int> GetIids;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> GetRuntimeClassName;

        [NativeTypeName("HRESULT (TrustLevel *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TrustLevel*, int> GetTrustLevel;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Contacts::ContactFieldType *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ContactFieldType*, int> get_Type;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Contacts::ContactFieldCategory *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ContactFieldCategory*, int> get_Category;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Name;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Value;
    }
}
