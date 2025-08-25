// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.datatransfer.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IDataPackage.xml' path='doc/member[@name="IDataPackage"]/*' />
[Guid("61EBF5C7-EFEA-4346-9554-981D7E198FFE")]
[NativeTypeName("struct IDataPackage : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IDataPackage : IDataPackage.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IDataPackage);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IDataPackage*, Guid*, void**, int>)(lpVtbl[0]))((IDataPackage*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IDataPackage*, uint>)(lpVtbl[1]))((IDataPackage*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IDataPackage*, uint>)(lpVtbl[2]))((IDataPackage*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IDataPackage*, uint*, Guid**, int>)(lpVtbl[3]))((IDataPackage*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IDataPackage*, HSTRING*, int>)(lpVtbl[4]))((IDataPackage*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IDataPackage*, TrustLevel*, int>)(lpVtbl[5]))((IDataPackage*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IDataPackage.xml' path='doc/member[@name="IDataPackage.GetView"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetView([NativeTypeName("ABI::Windows::ApplicationModel::DataTransfer::IDataPackageView **")] IDataPackageView** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IDataPackage*, IDataPackageView**, int>)(lpVtbl[6]))((IDataPackage*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='IDataPackage.xml' path='doc/member[@name="IDataPackage.get_Properties"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Properties([NativeTypeName("ABI::Windows::ApplicationModel::DataTransfer::IDataPackagePropertySet **")] IDataPackagePropertySet** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDataPackage*, IDataPackagePropertySet**, int>)(lpVtbl[7]))((IDataPackage*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDataPackage.xml' path='doc/member[@name="IDataPackage.get_RequestedOperation"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_RequestedOperation([NativeTypeName("ABI::Windows::ApplicationModel::DataTransfer::DataPackageOperation *")] DataPackageOperation* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDataPackage*, DataPackageOperation*, int>)(lpVtbl[8]))((IDataPackage*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDataPackage.xml' path='doc/member[@name="IDataPackage.put_RequestedOperation"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_RequestedOperation([NativeTypeName("ABI::Windows::ApplicationModel::DataTransfer::DataPackageOperation")] DataPackageOperation value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDataPackage*, DataPackageOperation, int>)(lpVtbl[9]))((IDataPackage*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDataPackage.xml' path='doc/member[@name="IDataPackage.add_OperationCompleted"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT add_OperationCompleted([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CDataTransfer__CDataPackage_Windows__CApplicationModel__CDataTransfer__COperationCompletedEventArgs_t *")] ITypedEventHandler<Pointer<IDataPackage>, Pointer<IOperationCompletedEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IDataPackage*, ITypedEventHandler<Pointer<IDataPackage>, Pointer<IOperationCompletedEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[10]))((IDataPackage*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IDataPackage.xml' path='doc/member[@name="IDataPackage.remove_OperationCompleted"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT remove_OperationCompleted(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IDataPackage*, EventRegistrationToken, int>)(lpVtbl[11]))((IDataPackage*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IDataPackage.xml' path='doc/member[@name="IDataPackage.add_Destroyed"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT add_Destroyed([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CDataTransfer__CDataPackage_IInspectable_t *")] ITypedEventHandler<Pointer<IDataPackage>, Pointer<IInspectable>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IDataPackage*, ITypedEventHandler<Pointer<IDataPackage>, Pointer<IInspectable>>*, EventRegistrationToken*, int>)(lpVtbl[12]))((IDataPackage*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IDataPackage.xml' path='doc/member[@name="IDataPackage.remove_Destroyed"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT remove_Destroyed(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IDataPackage*, EventRegistrationToken, int>)(lpVtbl[13]))((IDataPackage*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IDataPackage.xml' path='doc/member[@name="IDataPackage.SetData"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT SetData(HSTRING formatId, IInspectable* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDataPackage*, HSTRING, IInspectable*, int>)(lpVtbl[14]))((IDataPackage*)Unsafe.AsPointer(ref this), formatId, value);
    }

    /// <include file='IDataPackage.xml' path='doc/member[@name="IDataPackage.SetDataProvider"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT SetDataProvider(HSTRING formatId, [NativeTypeName("ABI::Windows::ApplicationModel::DataTransfer::IDataProviderHandler *")] IDataProviderHandler* delayRenderer)
    {
        return ((delegate* unmanaged[MemberFunction]<IDataPackage*, HSTRING, IDataProviderHandler*, int>)(lpVtbl[15]))((IDataPackage*)Unsafe.AsPointer(ref this), formatId, delayRenderer);
    }

    /// <include file='IDataPackage.xml' path='doc/member[@name="IDataPackage.SetText"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT SetText(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDataPackage*, HSTRING, int>)(lpVtbl[16]))((IDataPackage*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDataPackage.xml' path='doc/member[@name="IDataPackage.SetUri"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    [Obsolete("SetUri may be altered or unavailable for releases after Windows Phone 'OSVersion' (TBD).Instead, use SetWebLink or SetApplicationLink.")]
    public HRESULT SetUri([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDataPackage*, IUriRuntimeClass*, int>)(lpVtbl[17]))((IDataPackage*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDataPackage.xml' path='doc/member[@name="IDataPackage.SetHtmlFormat"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT SetHtmlFormat(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDataPackage*, HSTRING, int>)(lpVtbl[18]))((IDataPackage*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDataPackage.xml' path='doc/member[@name="IDataPackage.get_ResourceMap"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT get_ResourceMap([NativeTypeName("ABI::Windows::Foundation::Collections::__FIMap_2_HSTRING_Windows__CStorage__CStreams__CRandomAccessStreamReference_t **")] IMap<HSTRING, Pointer<IRandomAccessStreamReference>>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDataPackage*, IMap<HSTRING, Pointer<IRandomAccessStreamReference>>**, int>)(lpVtbl[19]))((IDataPackage*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDataPackage.xml' path='doc/member[@name="IDataPackage.SetRtf"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT SetRtf(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDataPackage*, HSTRING, int>)(lpVtbl[20]))((IDataPackage*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDataPackage.xml' path='doc/member[@name="IDataPackage.SetBitmap"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT SetBitmap([NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamReference *")] IRandomAccessStreamReference* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDataPackage*, IRandomAccessStreamReference*, int>)(lpVtbl[21]))((IDataPackage*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDataPackage.xml' path='doc/member[@name="IDataPackage.SetStorageItemsReadOnly"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT SetStorageItemsReadOnly([NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CStorage__CIStorageItem_t *")] IIterable<Pointer<IStorageItem>>* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDataPackage*, IIterable<Pointer<IStorageItem>>*, int>)(lpVtbl[22]))((IDataPackage*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDataPackage.xml' path='doc/member[@name="IDataPackage.SetStorageItems"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT SetStorageItems([NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CStorage__CIStorageItem_t *")] IIterable<Pointer<IStorageItem>>* value, [NativeTypeName("boolean")] byte readOnly)
    {
        return ((delegate* unmanaged[MemberFunction]<IDataPackage*, IIterable<Pointer<IStorageItem>>*, byte, int>)(lpVtbl[23]))((IDataPackage*)Unsafe.AsPointer(ref this), value, readOnly);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT GetView([NativeTypeName("ABI::Windows::ApplicationModel::DataTransfer::IDataPackageView **")] IDataPackageView** result);

        [VtblIndex(7)]
        HRESULT get_Properties([NativeTypeName("ABI::Windows::ApplicationModel::DataTransfer::IDataPackagePropertySet **")] IDataPackagePropertySet** value);

        [VtblIndex(8)]
        HRESULT get_RequestedOperation([NativeTypeName("ABI::Windows::ApplicationModel::DataTransfer::DataPackageOperation *")] DataPackageOperation* value);

        [VtblIndex(9)]
        HRESULT put_RequestedOperation([NativeTypeName("ABI::Windows::ApplicationModel::DataTransfer::DataPackageOperation")] DataPackageOperation value);

        [VtblIndex(10)]
        HRESULT add_OperationCompleted([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CDataTransfer__CDataPackage_Windows__CApplicationModel__CDataTransfer__COperationCompletedEventArgs_t *")] ITypedEventHandler<Pointer<IDataPackage>, Pointer<IOperationCompletedEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(11)]
        HRESULT remove_OperationCompleted(EventRegistrationToken token);

        [VtblIndex(12)]
        HRESULT add_Destroyed([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CDataTransfer__CDataPackage_IInspectable_t *")] ITypedEventHandler<Pointer<IDataPackage>, Pointer<IInspectable>>* handler, EventRegistrationToken* token);

        [VtblIndex(13)]
        HRESULT remove_Destroyed(EventRegistrationToken token);

        [VtblIndex(14)]
        HRESULT SetData(HSTRING formatId, IInspectable* value);

        [VtblIndex(15)]
        HRESULT SetDataProvider(HSTRING formatId, [NativeTypeName("ABI::Windows::ApplicationModel::DataTransfer::IDataProviderHandler *")] IDataProviderHandler* delayRenderer);

        [VtblIndex(16)]
        HRESULT SetText(HSTRING value);

        [VtblIndex(17)]
        [Obsolete("SetUri may be altered or unavailable for releases after Windows Phone 'OSVersion' (TBD).Instead, use SetWebLink or SetApplicationLink.")]
        HRESULT SetUri([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* value);

        [VtblIndex(18)]
        HRESULT SetHtmlFormat(HSTRING value);

        [VtblIndex(19)]
        HRESULT get_ResourceMap([NativeTypeName("ABI::Windows::Foundation::Collections::__FIMap_2_HSTRING_Windows__CStorage__CStreams__CRandomAccessStreamReference_t **")] IMap<HSTRING, Pointer<IRandomAccessStreamReference>>** value);

        [VtblIndex(20)]
        HRESULT SetRtf(HSTRING value);

        [VtblIndex(21)]
        HRESULT SetBitmap([NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamReference *")] IRandomAccessStreamReference* value);

        [VtblIndex(22)]
        HRESULT SetStorageItemsReadOnly([NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CStorage__CIStorageItem_t *")] IIterable<Pointer<IStorageItem>>* value);

        [VtblIndex(23)]
        HRESULT SetStorageItems([NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CStorage__CIStorageItem_t *")] IIterable<Pointer<IStorageItem>>* value, [NativeTypeName("boolean")] byte readOnly);
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

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::DataTransfer::IDataPackageView **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDataPackageView**, int> GetView;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::DataTransfer::IDataPackagePropertySet **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDataPackagePropertySet**, int> get_Properties;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::DataTransfer::DataPackageOperation *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, DataPackageOperation*, int> get_RequestedOperation;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::DataTransfer::DataPackageOperation) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, DataPackageOperation, int> put_RequestedOperation;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CDataTransfer__CDataPackage_Windows__CApplicationModel__CDataTransfer__COperationCompletedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IDataPackage>, Pointer<IOperationCompletedEventArgs>>*, EventRegistrationToken*, int> add_OperationCompleted;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_OperationCompleted;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CDataTransfer__CDataPackage_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IDataPackage>, Pointer<IInspectable>>*, EventRegistrationToken*, int> add_Destroyed;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_Destroyed;

        [NativeTypeName("HRESULT (HSTRING, IInspectable *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IInspectable*, int> SetData;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::ApplicationModel::DataTransfer::IDataProviderHandler *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IDataProviderHandler*, int> SetDataProvider;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> SetText;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IUriRuntimeClass *) __attribute__((stdcall))")]
        [Obsolete("SetUri may be altered or unavailable for releases after Windows Phone 'OSVersion' (TBD).Instead, use SetWebLink or SetApplicationLink.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUriRuntimeClass*, int> SetUri;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> SetHtmlFormat;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIMap_2_HSTRING_Windows__CStorage__CStreams__CRandomAccessStreamReference_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMap<HSTRING, Pointer<IRandomAccessStreamReference>>**, int> get_ResourceMap;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> SetRtf;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IRandomAccessStreamReference *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IRandomAccessStreamReference*, int> SetBitmap;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CStorage__CIStorageItem_t *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IIterable<Pointer<IStorageItem>>*, int> SetStorageItemsReadOnly;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CStorage__CIStorageItem_t *, boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IIterable<Pointer<IStorageItem>>*, byte, int> SetStorageItems;
    }
}
