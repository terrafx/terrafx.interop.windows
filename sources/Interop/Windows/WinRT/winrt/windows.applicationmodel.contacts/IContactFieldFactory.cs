// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.contacts.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IContactFieldFactory.xml' path='doc/member[@name="IContactFieldFactory"]/*' />
[Guid("85E2913F-0E4A-4A3E-8994-406AE7ED646E")]
[NativeTypeName("struct IContactFieldFactory : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IContactFieldFactory : IContactFieldFactory.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IContactFieldFactory);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactFieldFactory*, Guid*, void**, int>)(lpVtbl[0]))((IContactFieldFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IContactFieldFactory*, uint>)(lpVtbl[1]))((IContactFieldFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IContactFieldFactory*, uint>)(lpVtbl[2]))((IContactFieldFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactFieldFactory*, uint*, Guid**, int>)(lpVtbl[3]))((IContactFieldFactory*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactFieldFactory*, HSTRING*, int>)(lpVtbl[4]))((IContactFieldFactory*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactFieldFactory*, TrustLevel*, int>)(lpVtbl[5]))((IContactFieldFactory*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IContactFieldFactory.xml' path='doc/member[@name="IContactFieldFactory.CreateField_Default"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateField_Default(HSTRING value, [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::ContactFieldType")] ContactFieldType type, [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContactField **")] IContactField** field)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactFieldFactory*, HSTRING, ContactFieldType, IContactField**, int>)(lpVtbl[6]))((IContactFieldFactory*)Unsafe.AsPointer(ref this), value, type, field);
    }

    /// <include file='IContactFieldFactory.xml' path='doc/member[@name="IContactFieldFactory.CreateField_Category"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateField_Category(HSTRING value, [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::ContactFieldType")] ContactFieldType type, [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::ContactFieldCategory")] ContactFieldCategory category, [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContactField **")] IContactField** field)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactFieldFactory*, HSTRING, ContactFieldType, ContactFieldCategory, IContactField**, int>)(lpVtbl[7]))((IContactFieldFactory*)Unsafe.AsPointer(ref this), value, type, category, field);
    }

    /// <include file='IContactFieldFactory.xml' path='doc/member[@name="IContactFieldFactory.CreateField_Custom"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT CreateField_Custom(HSTRING name, HSTRING value, [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::ContactFieldType")] ContactFieldType type, [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::ContactFieldCategory")] ContactFieldCategory category, [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContactField **")] IContactField** field)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactFieldFactory*, HSTRING, HSTRING, ContactFieldType, ContactFieldCategory, IContactField**, int>)(lpVtbl[8]))((IContactFieldFactory*)Unsafe.AsPointer(ref this), name, value, type, category, field);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateField_Default(HSTRING value, [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::ContactFieldType")] ContactFieldType type, [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContactField **")] IContactField** field);

        [VtblIndex(7)]
        HRESULT CreateField_Category(HSTRING value, [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::ContactFieldType")] ContactFieldType type, [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::ContactFieldCategory")] ContactFieldCategory category, [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContactField **")] IContactField** field);

        [VtblIndex(8)]
        HRESULT CreateField_Custom(HSTRING name, HSTRING value, [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::ContactFieldType")] ContactFieldType type, [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::ContactFieldCategory")] ContactFieldCategory category, [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContactField **")] IContactField** field);
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

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::ApplicationModel::Contacts::ContactFieldType, ABI::Windows::ApplicationModel::Contacts::IContactField **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, ContactFieldType, IContactField**, int> CreateField_Default;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::ApplicationModel::Contacts::ContactFieldType, ABI::Windows::ApplicationModel::Contacts::ContactFieldCategory, ABI::Windows::ApplicationModel::Contacts::IContactField **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, ContactFieldType, ContactFieldCategory, IContactField**, int> CreateField_Category;

        [NativeTypeName("HRESULT (HSTRING, HSTRING, ABI::Windows::ApplicationModel::Contacts::ContactFieldType, ABI::Windows::ApplicationModel::Contacts::ContactFieldCategory, ABI::Windows::ApplicationModel::Contacts::IContactField **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, HSTRING, ContactFieldType, ContactFieldCategory, IContactField**, int> CreateField_Custom;
    }
}
