// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.appservice.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IAppServiceConnection.xml' path='doc/member[@name="IAppServiceConnection"]/*' />
[Guid("9DD474A2-871F-4D52-89A9-9E090531BD27")]
[NativeTypeName("struct IAppServiceConnection : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAppServiceConnection : IAppServiceConnection.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IAppServiceConnection);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppServiceConnection*, Guid*, void**, int>)(lpVtbl[0]))((IAppServiceConnection*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppServiceConnection*, uint>)(lpVtbl[1]))((IAppServiceConnection*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppServiceConnection*, uint>)(lpVtbl[2]))((IAppServiceConnection*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppServiceConnection*, uint*, Guid**, int>)(lpVtbl[3]))((IAppServiceConnection*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppServiceConnection*, HSTRING*, int>)(lpVtbl[4]))((IAppServiceConnection*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppServiceConnection*, TrustLevel*, int>)(lpVtbl[5]))((IAppServiceConnection*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IAppServiceConnection.xml' path='doc/member[@name="IAppServiceConnection.get_AppServiceName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_AppServiceName(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppServiceConnection*, HSTRING*, int>)(lpVtbl[6]))((IAppServiceConnection*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppServiceConnection.xml' path='doc/member[@name="IAppServiceConnection.put_AppServiceName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_AppServiceName(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppServiceConnection*, HSTRING, int>)(lpVtbl[7]))((IAppServiceConnection*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppServiceConnection.xml' path='doc/member[@name="IAppServiceConnection.get_PackageFamilyName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_PackageFamilyName(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppServiceConnection*, HSTRING*, int>)(lpVtbl[8]))((IAppServiceConnection*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppServiceConnection.xml' path='doc/member[@name="IAppServiceConnection.put_PackageFamilyName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_PackageFamilyName(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppServiceConnection*, HSTRING, int>)(lpVtbl[9]))((IAppServiceConnection*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppServiceConnection.xml' path='doc/member[@name="IAppServiceConnection.OpenAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT OpenAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CAppService__CAppServiceConnectionStatus_t **")] IAsyncOperation<AppServiceConnectionStatus>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppServiceConnection*, IAsyncOperation<AppServiceConnectionStatus>**, int>)(lpVtbl[10]))((IAppServiceConnection*)Unsafe.AsPointer(ref this), operation);
    }

    /// <include file='IAppServiceConnection.xml' path='doc/member[@name="IAppServiceConnection.SendMessageAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT SendMessageAsync([NativeTypeName("ABI::Windows::Foundation::Collections::IPropertySet *")] IPropertySet* message, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CAppService__CAppServiceResponse_t **")] IAsyncOperation<Pointer<IAppServiceResponse>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppServiceConnection*, IPropertySet*, IAsyncOperation<Pointer<IAppServiceResponse>>**, int>)(lpVtbl[11]))((IAppServiceConnection*)Unsafe.AsPointer(ref this), message, operation);
    }

    /// <include file='IAppServiceConnection.xml' path='doc/member[@name="IAppServiceConnection.add_RequestReceived"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT add_RequestReceived([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CAppService__CAppServiceConnection_Windows__CApplicationModel__CAppService__CAppServiceRequestReceivedEventArgs_t *")] ITypedEventHandler<Pointer<IAppServiceConnection>, Pointer<IAppServiceRequestReceivedEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppServiceConnection*, ITypedEventHandler<Pointer<IAppServiceConnection>, Pointer<IAppServiceRequestReceivedEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[12]))((IAppServiceConnection*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IAppServiceConnection.xml' path='doc/member[@name="IAppServiceConnection.remove_RequestReceived"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT remove_RequestReceived(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppServiceConnection*, EventRegistrationToken, int>)(lpVtbl[13]))((IAppServiceConnection*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IAppServiceConnection.xml' path='doc/member[@name="IAppServiceConnection.add_ServiceClosed"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT add_ServiceClosed([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CAppService__CAppServiceConnection_Windows__CApplicationModel__CAppService__CAppServiceClosedEventArgs_t *")] ITypedEventHandler<Pointer<IAppServiceConnection>, Pointer<IAppServiceClosedEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppServiceConnection*, ITypedEventHandler<Pointer<IAppServiceConnection>, Pointer<IAppServiceClosedEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[14]))((IAppServiceConnection*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IAppServiceConnection.xml' path='doc/member[@name="IAppServiceConnection.remove_ServiceClosed"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT remove_ServiceClosed(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppServiceConnection*, EventRegistrationToken, int>)(lpVtbl[15]))((IAppServiceConnection*)Unsafe.AsPointer(ref this), token);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_AppServiceName(HSTRING* value);

        [VtblIndex(7)]
        HRESULT put_AppServiceName(HSTRING value);

        [VtblIndex(8)]
        HRESULT get_PackageFamilyName(HSTRING* value);

        [VtblIndex(9)]
        HRESULT put_PackageFamilyName(HSTRING value);

        [VtblIndex(10)]
        HRESULT OpenAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CAppService__CAppServiceConnectionStatus_t **")] IAsyncOperation<AppServiceConnectionStatus>** operation);

        [VtblIndex(11)]
        HRESULT SendMessageAsync([NativeTypeName("ABI::Windows::Foundation::Collections::IPropertySet *")] IPropertySet* message, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CAppService__CAppServiceResponse_t **")] IAsyncOperation<Pointer<IAppServiceResponse>>** operation);

        [VtblIndex(12)]
        HRESULT add_RequestReceived([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CAppService__CAppServiceConnection_Windows__CApplicationModel__CAppService__CAppServiceRequestReceivedEventArgs_t *")] ITypedEventHandler<Pointer<IAppServiceConnection>, Pointer<IAppServiceRequestReceivedEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(13)]
        HRESULT remove_RequestReceived(EventRegistrationToken token);

        [VtblIndex(14)]
        HRESULT add_ServiceClosed([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CAppService__CAppServiceConnection_Windows__CApplicationModel__CAppService__CAppServiceClosedEventArgs_t *")] ITypedEventHandler<Pointer<IAppServiceConnection>, Pointer<IAppServiceClosedEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(15)]
        HRESULT remove_ServiceClosed(EventRegistrationToken token);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_AppServiceName;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_AppServiceName;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_PackageFamilyName;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_PackageFamilyName;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CAppService__CAppServiceConnectionStatus_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncOperation<AppServiceConnectionStatus>**, int> OpenAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::IPropertySet *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CAppService__CAppServiceResponse_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IPropertySet*, IAsyncOperation<Pointer<IAppServiceResponse>>**, int> SendMessageAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CAppService__CAppServiceConnection_Windows__CApplicationModel__CAppService__CAppServiceRequestReceivedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IAppServiceConnection>, Pointer<IAppServiceRequestReceivedEventArgs>>*, EventRegistrationToken*, int> add_RequestReceived;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_RequestReceived;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CAppService__CAppServiceConnection_Windows__CApplicationModel__CAppService__CAppServiceClosedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IAppServiceConnection>, Pointer<IAppServiceClosedEventArgs>>*, EventRegistrationToken*, int> add_ServiceClosed;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_ServiceClosed;
    }
}
