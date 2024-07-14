// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.contacts.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IContactLocationFieldFactory.xml' path='doc/member[@name="IContactLocationFieldFactory"]/*' />
[Guid("F79932D7-2FDF-43FE-8F18-41897390BCFE")]
[NativeTypeName("struct IContactLocationFieldFactory : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IContactLocationFieldFactory : IContactLocationFieldFactory.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IContactLocationFieldFactory));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactLocationFieldFactory*, Guid*, void**, int>)(lpVtbl[0]))((IContactLocationFieldFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IContactLocationFieldFactory*, uint>)(lpVtbl[1]))((IContactLocationFieldFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IContactLocationFieldFactory*, uint>)(lpVtbl[2]))((IContactLocationFieldFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactLocationFieldFactory*, uint*, Guid**, int>)(lpVtbl[3]))((IContactLocationFieldFactory*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactLocationFieldFactory*, HSTRING*, int>)(lpVtbl[4]))((IContactLocationFieldFactory*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactLocationFieldFactory*, TrustLevel*, int>)(lpVtbl[5]))((IContactLocationFieldFactory*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IContactLocationFieldFactory.xml' path='doc/member[@name="IContactLocationFieldFactory.CreateLocation_Default"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateLocation_Default(HSTRING unstructuredAddress, [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContactLocationField **")] IContactLocationField** field)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactLocationFieldFactory*, HSTRING, IContactLocationField**, int>)(lpVtbl[6]))((IContactLocationFieldFactory*)Unsafe.AsPointer(ref this), unstructuredAddress, field);
    }

    /// <include file='IContactLocationFieldFactory.xml' path='doc/member[@name="IContactLocationFieldFactory.CreateLocation_Category"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateLocation_Category(HSTRING unstructuredAddress, [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::ContactFieldCategory")] ContactFieldCategory category, [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContactLocationField **")] IContactLocationField** field)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactLocationFieldFactory*, HSTRING, ContactFieldCategory, IContactLocationField**, int>)(lpVtbl[7]))((IContactLocationFieldFactory*)Unsafe.AsPointer(ref this), unstructuredAddress, category, field);
    }

    /// <include file='IContactLocationFieldFactory.xml' path='doc/member[@name="IContactLocationFieldFactory.CreateLocation_All"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT CreateLocation_All(HSTRING unstructuredAddress, [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::ContactFieldCategory")] ContactFieldCategory category, HSTRING street, HSTRING city, HSTRING region, HSTRING country, HSTRING postalCode, [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContactLocationField **")] IContactLocationField** field)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactLocationFieldFactory*, HSTRING, ContactFieldCategory, HSTRING, HSTRING, HSTRING, HSTRING, HSTRING, IContactLocationField**, int>)(lpVtbl[8]))((IContactLocationFieldFactory*)Unsafe.AsPointer(ref this), unstructuredAddress, category, street, city, region, country, postalCode, field);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateLocation_Default(HSTRING unstructuredAddress, [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContactLocationField **")] IContactLocationField** field);

        [VtblIndex(7)]
        HRESULT CreateLocation_Category(HSTRING unstructuredAddress, [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::ContactFieldCategory")] ContactFieldCategory category, [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContactLocationField **")] IContactLocationField** field);

        [VtblIndex(8)]
        HRESULT CreateLocation_All(HSTRING unstructuredAddress, [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::ContactFieldCategory")] ContactFieldCategory category, HSTRING street, HSTRING city, HSTRING region, HSTRING country, HSTRING postalCode, [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContactLocationField **")] IContactLocationField** field);
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

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::ApplicationModel::Contacts::IContactLocationField **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IContactLocationField**, int> CreateLocation_Default;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::ApplicationModel::Contacts::ContactFieldCategory, ABI::Windows::ApplicationModel::Contacts::IContactLocationField **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, ContactFieldCategory, IContactLocationField**, int> CreateLocation_Category;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::ApplicationModel::Contacts::ContactFieldCategory, HSTRING, HSTRING, HSTRING, HSTRING, HSTRING, ABI::Windows::ApplicationModel::Contacts::IContactLocationField **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, ContactFieldCategory, HSTRING, HSTRING, HSTRING, HSTRING, HSTRING, IContactLocationField**, int> CreateLocation_All;
    }
}
