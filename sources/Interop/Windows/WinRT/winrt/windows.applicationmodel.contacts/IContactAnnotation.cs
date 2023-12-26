// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.contacts.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IContactAnnotation.xml' path='doc/member[@name="IContactAnnotation"]/*' />
[Guid("821FC2EF-7D41-44A2-84C3-60A281DD7B86")]
[NativeTypeName("struct IContactAnnotation : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IContactAnnotation : IContactAnnotation.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IContactAnnotation));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactAnnotation*, Guid*, void**, int>)(lpVtbl[0]))((IContactAnnotation*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IContactAnnotation*, uint>)(lpVtbl[1]))((IContactAnnotation*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IContactAnnotation*, uint>)(lpVtbl[2]))((IContactAnnotation*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactAnnotation*, uint*, Guid**, int>)(lpVtbl[3]))((IContactAnnotation*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactAnnotation*, HSTRING*, int>)(lpVtbl[4]))((IContactAnnotation*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactAnnotation*, TrustLevel*, int>)(lpVtbl[5]))((IContactAnnotation*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IContactAnnotation.xml' path='doc/member[@name="IContactAnnotation.get_Id"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Id(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactAnnotation*, HSTRING*, int>)(lpVtbl[6]))((IContactAnnotation*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactAnnotation.xml' path='doc/member[@name="IContactAnnotation.get_AnnotationListId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_AnnotationListId(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactAnnotation*, HSTRING*, int>)(lpVtbl[7]))((IContactAnnotation*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactAnnotation.xml' path='doc/member[@name="IContactAnnotation.get_ContactId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_ContactId(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactAnnotation*, HSTRING*, int>)(lpVtbl[8]))((IContactAnnotation*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactAnnotation.xml' path='doc/member[@name="IContactAnnotation.put_ContactId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_ContactId(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactAnnotation*, HSTRING, int>)(lpVtbl[9]))((IContactAnnotation*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactAnnotation.xml' path='doc/member[@name="IContactAnnotation.get_RemoteId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_RemoteId(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactAnnotation*, HSTRING*, int>)(lpVtbl[10]))((IContactAnnotation*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactAnnotation.xml' path='doc/member[@name="IContactAnnotation.put_RemoteId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_RemoteId(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactAnnotation*, HSTRING, int>)(lpVtbl[11]))((IContactAnnotation*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactAnnotation.xml' path='doc/member[@name="IContactAnnotation.get_SupportedOperations"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_SupportedOperations([NativeTypeName("ABI::Windows::ApplicationModel::Contacts::ContactAnnotationOperations *")] ContactAnnotationOperations* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactAnnotation*, ContactAnnotationOperations*, int>)(lpVtbl[12]))((IContactAnnotation*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactAnnotation.xml' path='doc/member[@name="IContactAnnotation.put_SupportedOperations"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_SupportedOperations([NativeTypeName("ABI::Windows::ApplicationModel::Contacts::ContactAnnotationOperations")] ContactAnnotationOperations value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactAnnotation*, ContactAnnotationOperations, int>)(lpVtbl[13]))((IContactAnnotation*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactAnnotation.xml' path='doc/member[@name="IContactAnnotation.get_IsDisabled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_IsDisabled([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactAnnotation*, byte*, int>)(lpVtbl[14]))((IContactAnnotation*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactAnnotation.xml' path='doc/member[@name="IContactAnnotation.get_ProviderProperties"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_ProviderProperties([NativeTypeName("ABI::Windows::Foundation::Collections::IPropertySet **")] IPropertySet** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactAnnotation*, IPropertySet**, int>)(lpVtbl[15]))((IContactAnnotation*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Id(HSTRING* value);

        [VtblIndex(7)]
        HRESULT get_AnnotationListId(HSTRING* value);

        [VtblIndex(8)]
        HRESULT get_ContactId(HSTRING* value);

        [VtblIndex(9)]
        HRESULT put_ContactId(HSTRING value);

        [VtblIndex(10)]
        HRESULT get_RemoteId(HSTRING* value);

        [VtblIndex(11)]
        HRESULT put_RemoteId(HSTRING value);

        [VtblIndex(12)]
        HRESULT get_SupportedOperations([NativeTypeName("ABI::Windows::ApplicationModel::Contacts::ContactAnnotationOperations *")] ContactAnnotationOperations* value);

        [VtblIndex(13)]
        HRESULT put_SupportedOperations([NativeTypeName("ABI::Windows::ApplicationModel::Contacts::ContactAnnotationOperations")] ContactAnnotationOperations value);

        [VtblIndex(14)]
        HRESULT get_IsDisabled([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(15)]
        HRESULT get_ProviderProperties([NativeTypeName("ABI::Windows::Foundation::Collections::IPropertySet **")] IPropertySet** value);
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

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Id;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_AnnotationListId;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_ContactId;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_ContactId;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_RemoteId;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_RemoteId;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Contacts::ContactAnnotationOperations *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ContactAnnotationOperations*, int> get_SupportedOperations;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Contacts::ContactAnnotationOperations) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ContactAnnotationOperations, int> put_SupportedOperations;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsDisabled;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::IPropertySet **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IPropertySet**, int> get_ProviderProperties;
    }
}
