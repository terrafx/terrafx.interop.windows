// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.contacts.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IContactInformation.xml' path='doc/member[@name="IContactInformation"]/*' />
[Guid("275EB6D4-6A2E-4278-A914-E460D5F088F6")]
[NativeTypeName("struct IContactInformation : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IContactInformation : IContactInformation.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IContactInformation));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactInformation*, Guid*, void**, int>)(lpVtbl[0]))((IContactInformation*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IContactInformation*, uint>)(lpVtbl[1]))((IContactInformation*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IContactInformation*, uint>)(lpVtbl[2]))((IContactInformation*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactInformation*, uint*, Guid**, int>)(lpVtbl[3]))((IContactInformation*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactInformation*, HSTRING*, int>)(lpVtbl[4]))((IContactInformation*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactInformation*, TrustLevel*, int>)(lpVtbl[5]))((IContactInformation*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IContactInformation.xml' path='doc/member[@name="IContactInformation.get_Name"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Name(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactInformation*, HSTRING*, int>)(lpVtbl[6]))((IContactInformation*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactInformation.xml' path='doc/member[@name="IContactInformation.GetThumbnailAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetThumbnailAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStreams__CIRandomAccessStreamWithContentType_t **")] IAsyncOperation<Pointer<IRandomAccessStreamWithContentType>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactInformation*, IAsyncOperation<Pointer<IRandomAccessStreamWithContentType>>**, int>)(lpVtbl[7]))((IContactInformation*)Unsafe.AsPointer(ref this), operation);
    }

    /// <include file='IContactInformation.xml' path='doc/member[@name="IContactInformation.get_Emails"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Emails([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CApplicationModel__CContacts__CContactField_t **")] IVectorView<Pointer<IContactField>>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactInformation*, IVectorView<Pointer<IContactField>>**, int>)(lpVtbl[8]))((IContactInformation*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactInformation.xml' path='doc/member[@name="IContactInformation.get_PhoneNumbers"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_PhoneNumbers([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CApplicationModel__CContacts__CContactField_t **")] IVectorView<Pointer<IContactField>>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactInformation*, IVectorView<Pointer<IContactField>>**, int>)(lpVtbl[9]))((IContactInformation*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactInformation.xml' path='doc/member[@name="IContactInformation.get_Locations"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_Locations([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CApplicationModel__CContacts__CContactLocationField_t **")] IVectorView<Pointer<IContactLocationField>>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactInformation*, IVectorView<Pointer<IContactLocationField>>**, int>)(lpVtbl[10]))((IContactInformation*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactInformation.xml' path='doc/member[@name="IContactInformation.get_InstantMessages"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_InstantMessages([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CApplicationModel__CContacts__CContactInstantMessageField_t **")] IVectorView<Pointer<IContactInstantMessageField>>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactInformation*, IVectorView<Pointer<IContactInstantMessageField>>**, int>)(lpVtbl[11]))((IContactInformation*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactInformation.xml' path='doc/member[@name="IContactInformation.get_CustomFields"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_CustomFields([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CApplicationModel__CContacts__CContactField_t **")] IVectorView<Pointer<IContactField>>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactInformation*, IVectorView<Pointer<IContactField>>**, int>)(lpVtbl[12]))((IContactInformation*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IContactInformation.xml' path='doc/member[@name="IContactInformation.QueryCustomFields"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT QueryCustomFields(HSTRING customName, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CApplicationModel__CContacts__CContactField_t **")] IVectorView<Pointer<IContactField>>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IContactInformation*, HSTRING, IVectorView<Pointer<IContactField>>**, int>)(lpVtbl[13]))((IContactInformation*)Unsafe.AsPointer(ref this), customName, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Name(HSTRING* value);

        [VtblIndex(7)]
        HRESULT GetThumbnailAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStreams__CIRandomAccessStreamWithContentType_t **")] IAsyncOperation<Pointer<IRandomAccessStreamWithContentType>>** operation);

        [VtblIndex(8)]
        HRESULT get_Emails([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CApplicationModel__CContacts__CContactField_t **")] IVectorView<Pointer<IContactField>>** value);

        [VtblIndex(9)]
        HRESULT get_PhoneNumbers([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CApplicationModel__CContacts__CContactField_t **")] IVectorView<Pointer<IContactField>>** value);

        [VtblIndex(10)]
        HRESULT get_Locations([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CApplicationModel__CContacts__CContactLocationField_t **")] IVectorView<Pointer<IContactLocationField>>** value);

        [VtblIndex(11)]
        HRESULT get_InstantMessages([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CApplicationModel__CContacts__CContactInstantMessageField_t **")] IVectorView<Pointer<IContactInstantMessageField>>** value);

        [VtblIndex(12)]
        HRESULT get_CustomFields([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CApplicationModel__CContacts__CContactField_t **")] IVectorView<Pointer<IContactField>>** value);

        [VtblIndex(13)]
        HRESULT QueryCustomFields(HSTRING customName, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CApplicationModel__CContacts__CContactField_t **")] IVectorView<Pointer<IContactField>>** value);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Name;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStreams__CIRandomAccessStreamWithContentType_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncOperation<Pointer<IRandomAccessStreamWithContentType>>**, int> GetThumbnailAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CApplicationModel__CContacts__CContactField_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVectorView<Pointer<IContactField>>**, int> get_Emails;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CApplicationModel__CContacts__CContactField_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVectorView<Pointer<IContactField>>**, int> get_PhoneNumbers;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CApplicationModel__CContacts__CContactLocationField_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVectorView<Pointer<IContactLocationField>>**, int> get_Locations;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CApplicationModel__CContacts__CContactInstantMessageField_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVectorView<Pointer<IContactInstantMessageField>>**, int> get_InstantMessages;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CApplicationModel__CContacts__CContactField_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVectorView<Pointer<IContactField>>**, int> get_CustomFields;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CApplicationModel__CContacts__CContactField_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IVectorView<Pointer<IContactField>>**, int> QueryCustomFields;
    }
}
