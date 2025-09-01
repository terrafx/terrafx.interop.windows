// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.contacts.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IContactInstantMessageFieldFactory.xml' path='doc/member[@name="IContactInstantMessageFieldFactory"]/*' />
[Guid("BA0B6794-91A3-4BB2-B1B9-69A5DFF0BA09")]
[NativeTypeName("struct IContactInstantMessageFieldFactory : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IContactInstantMessageFieldFactory : IContactInstantMessageFieldFactory.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IContactInstantMessageFieldFactory);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactInstantMessageFieldFactory*, Guid*, void**, int>)(lpVtbl[0]))((IContactInstantMessageFieldFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IContactInstantMessageFieldFactory*, uint>)(lpVtbl[1]))((IContactInstantMessageFieldFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IContactInstantMessageFieldFactory*, uint>)(lpVtbl[2]))((IContactInstantMessageFieldFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactInstantMessageFieldFactory*, uint*, Guid**, int>)(lpVtbl[3]))((IContactInstantMessageFieldFactory*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactInstantMessageFieldFactory*, HSTRING*, int>)(lpVtbl[4]))((IContactInstantMessageFieldFactory*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactInstantMessageFieldFactory*, TrustLevel*, int>)(lpVtbl[5]))((IContactInstantMessageFieldFactory*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IContactInstantMessageFieldFactory.xml' path='doc/member[@name="IContactInstantMessageFieldFactory.CreateInstantMessage_Default"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateInstantMessage_Default(HSTRING userName, [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContactInstantMessageField **")] IContactInstantMessageField** field)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactInstantMessageFieldFactory*, HSTRING, IContactInstantMessageField**, int>)(lpVtbl[6]))((IContactInstantMessageFieldFactory*)Unsafe.AsPointer(ref this), userName, field);
    }

    /// <include file='IContactInstantMessageFieldFactory.xml' path='doc/member[@name="IContactInstantMessageFieldFactory.CreateInstantMessage_Category"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateInstantMessage_Category(HSTRING userName, [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::ContactFieldCategory")] ContactFieldCategory category, [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContactInstantMessageField **")] IContactInstantMessageField** field)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactInstantMessageFieldFactory*, HSTRING, ContactFieldCategory, IContactInstantMessageField**, int>)(lpVtbl[7]))((IContactInstantMessageFieldFactory*)Unsafe.AsPointer(ref this), userName, category, field);
    }

    /// <include file='IContactInstantMessageFieldFactory.xml' path='doc/member[@name="IContactInstantMessageFieldFactory.CreateInstantMessage_All"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT CreateInstantMessage_All(HSTRING userName, [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::ContactFieldCategory")] ContactFieldCategory category, HSTRING service, HSTRING displayText, [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* verb, [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContactInstantMessageField **")] IContactInstantMessageField** field)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactInstantMessageFieldFactory*, HSTRING, ContactFieldCategory, HSTRING, HSTRING, IUriRuntimeClass*, IContactInstantMessageField**, int>)(lpVtbl[8]))((IContactInstantMessageFieldFactory*)Unsafe.AsPointer(ref this), userName, category, service, displayText, verb, field);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateInstantMessage_Default(HSTRING userName, [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContactInstantMessageField **")] IContactInstantMessageField** field);

        [VtblIndex(7)]
        HRESULT CreateInstantMessage_Category(HSTRING userName, [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::ContactFieldCategory")] ContactFieldCategory category, [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContactInstantMessageField **")] IContactInstantMessageField** field);

        [VtblIndex(8)]
        HRESULT CreateInstantMessage_All(HSTRING userName, [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::ContactFieldCategory")] ContactFieldCategory category, HSTRING service, HSTRING displayText, [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* verb, [NativeTypeName("ABI::Windows::ApplicationModel::Contacts::IContactInstantMessageField **")] IContactInstantMessageField** field);
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

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::ApplicationModel::Contacts::IContactInstantMessageField **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IContactInstantMessageField**, int> CreateInstantMessage_Default;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::ApplicationModel::Contacts::ContactFieldCategory, ABI::Windows::ApplicationModel::Contacts::IContactInstantMessageField **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, ContactFieldCategory, IContactInstantMessageField**, int> CreateInstantMessage_Category;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::ApplicationModel::Contacts::ContactFieldCategory, HSTRING, HSTRING, ABI::Windows::Foundation::IUriRuntimeClass *, ABI::Windows::ApplicationModel::Contacts::IContactInstantMessageField **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, ContactFieldCategory, HSTRING, HSTRING, IUriRuntimeClass*, IContactInstantMessageField**, int> CreateInstantMessage_All;
    }
}
