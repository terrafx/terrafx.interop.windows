// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.datatransfer.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IDataPackageView.xml' path='doc/member[@name="IDataPackageView"]/*' />
[Guid("7B840471-5900-4D85-A90B-10CB85FE3552")]
[NativeTypeName("struct IDataPackageView : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IDataPackageView : IDataPackageView.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDataPackageView));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IDataPackageView*, Guid*, void**, int>)(lpVtbl[0]))((IDataPackageView*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IDataPackageView*, uint>)(lpVtbl[1]))((IDataPackageView*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IDataPackageView*, uint>)(lpVtbl[2]))((IDataPackageView*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IDataPackageView*, uint*, Guid**, int>)(lpVtbl[3]))((IDataPackageView*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IDataPackageView*, HSTRING*, int>)(lpVtbl[4]))((IDataPackageView*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IDataPackageView*, TrustLevel*, int>)(lpVtbl[5]))((IDataPackageView*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IDataPackageView.xml' path='doc/member[@name="IDataPackageView.get_Properties"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Properties([NativeTypeName("ABI::Windows::ApplicationModel::DataTransfer::IDataPackagePropertySetView **")] IDataPackagePropertySetView** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDataPackageView*, IDataPackagePropertySetView**, int>)(lpVtbl[6]))((IDataPackageView*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDataPackageView.xml' path='doc/member[@name="IDataPackageView.get_RequestedOperation"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_RequestedOperation([NativeTypeName("ABI::Windows::ApplicationModel::DataTransfer::DataPackageOperation *")] DataPackageOperation* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDataPackageView*, DataPackageOperation*, int>)(lpVtbl[7]))((IDataPackageView*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDataPackageView.xml' path='doc/member[@name="IDataPackageView.ReportOperationCompleted"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT ReportOperationCompleted([NativeTypeName("ABI::Windows::ApplicationModel::DataTransfer::DataPackageOperation")] DataPackageOperation value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDataPackageView*, DataPackageOperation, int>)(lpVtbl[8]))((IDataPackageView*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDataPackageView.xml' path='doc/member[@name="IDataPackageView.get_AvailableFormats"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_AvailableFormats([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_HSTRING_t **")] IVectorView<HSTRING>** formatIds)
    {
        return ((delegate* unmanaged[MemberFunction]<IDataPackageView*, IVectorView<HSTRING>**, int>)(lpVtbl[9]))((IDataPackageView*)Unsafe.AsPointer(ref this), formatIds);
    }

    /// <include file='IDataPackageView.xml' path='doc/member[@name="IDataPackageView.Contains"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT Contains(HSTRING formatId, [NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDataPackageView*, HSTRING, byte*, int>)(lpVtbl[10]))((IDataPackageView*)Unsafe.AsPointer(ref this), formatId, value);
    }

    /// <include file='IDataPackageView.xml' path='doc/member[@name="IDataPackageView.GetDataAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetDataAsync(HSTRING formatId, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_IInspectable_t **")] IAsyncOperation<Pointer<IInspectable>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IDataPackageView*, HSTRING, IAsyncOperation<Pointer<IInspectable>>**, int>)(lpVtbl[11]))((IDataPackageView*)Unsafe.AsPointer(ref this), formatId, operation);
    }

    /// <include file='IDataPackageView.xml' path='doc/member[@name="IDataPackageView.GetTextAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetTextAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_HSTRING_t **")] IAsyncOperation<HSTRING>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IDataPackageView*, IAsyncOperation<HSTRING>**, int>)(lpVtbl[12]))((IDataPackageView*)Unsafe.AsPointer(ref this), operation);
    }

    /// <include file='IDataPackageView.xml' path='doc/member[@name="IDataPackageView.GetCustomTextAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetCustomTextAsync(HSTRING formatId, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_HSTRING_t **")] IAsyncOperation<HSTRING>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IDataPackageView*, HSTRING, IAsyncOperation<HSTRING>**, int>)(lpVtbl[13]))((IDataPackageView*)Unsafe.AsPointer(ref this), formatId, operation);
    }

    /// <include file='IDataPackageView.xml' path='doc/member[@name="IDataPackageView.GetUriAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    [Obsolete("GetUriAsync may be altered or unavailable for releases after Windows 8.1. Instead, use GetWebLinkAsync or GetApplicationLinkAsync.")]
    public HRESULT GetUriAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CFoundation__CUri_t **")] IAsyncOperation<Pointer<IUri>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IDataPackageView*, IAsyncOperation<Pointer<IUri>>**, int>)(lpVtbl[14]))((IDataPackageView*)Unsafe.AsPointer(ref this), operation);
    }

    /// <include file='IDataPackageView.xml' path='doc/member[@name="IDataPackageView.GetHtmlFormatAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT GetHtmlFormatAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_HSTRING_t **")] IAsyncOperation<HSTRING>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IDataPackageView*, IAsyncOperation<HSTRING>**, int>)(lpVtbl[15]))((IDataPackageView*)Unsafe.AsPointer(ref this), operation);
    }

    /// <include file='IDataPackageView.xml' path='doc/member[@name="IDataPackageView.GetResourceMapAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT GetResourceMapAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIMapView_2_HSTRING_Windows__CStorage__CStreams__CRandomAccessStreamReference_t **")] IAsyncOperation<Pointer<IMapView<HSTRING, Pointer<IRandomAccessStreamReference>>>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IDataPackageView*, IAsyncOperation<Pointer<IMapView<HSTRING, Pointer<IRandomAccessStreamReference>>>>**, int>)(lpVtbl[16]))((IDataPackageView*)Unsafe.AsPointer(ref this), operation);
    }

    /// <include file='IDataPackageView.xml' path='doc/member[@name="IDataPackageView.GetRtfAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT GetRtfAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_HSTRING_t **")] IAsyncOperation<HSTRING>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IDataPackageView*, IAsyncOperation<HSTRING>**, int>)(lpVtbl[17]))((IDataPackageView*)Unsafe.AsPointer(ref this), operation);
    }

    /// <include file='IDataPackageView.xml' path='doc/member[@name="IDataPackageView.GetBitmapAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT GetBitmapAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStreams__CRandomAccessStreamReference_t **")] IAsyncOperation<Pointer<IRandomAccessStreamReference>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IDataPackageView*, IAsyncOperation<Pointer<IRandomAccessStreamReference>>**, int>)(lpVtbl[18]))((IDataPackageView*)Unsafe.AsPointer(ref this), operation);
    }

    /// <include file='IDataPackageView.xml' path='doc/member[@name="IDataPackageView.GetStorageItemsAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT GetStorageItemsAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CStorage__CIStorageItem_t **")] IAsyncOperation<Pointer<IVectorView<Pointer<IStorageItem>>>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IDataPackageView*, IAsyncOperation<Pointer<IVectorView<Pointer<IStorageItem>>>>**, int>)(lpVtbl[19]))((IDataPackageView*)Unsafe.AsPointer(ref this), operation);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Properties([NativeTypeName("ABI::Windows::ApplicationModel::DataTransfer::IDataPackagePropertySetView **")] IDataPackagePropertySetView** value);

        [VtblIndex(7)]
        HRESULT get_RequestedOperation([NativeTypeName("ABI::Windows::ApplicationModel::DataTransfer::DataPackageOperation *")] DataPackageOperation* value);

        [VtblIndex(8)]
        HRESULT ReportOperationCompleted([NativeTypeName("ABI::Windows::ApplicationModel::DataTransfer::DataPackageOperation")] DataPackageOperation value);

        [VtblIndex(9)]
        HRESULT get_AvailableFormats([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_HSTRING_t **")] IVectorView<HSTRING>** formatIds);

        [VtblIndex(10)]
        HRESULT Contains(HSTRING formatId, [NativeTypeName("boolean *")] byte* value);

        [VtblIndex(11)]
        HRESULT GetDataAsync(HSTRING formatId, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_IInspectable_t **")] IAsyncOperation<Pointer<IInspectable>>** operation);

        [VtblIndex(12)]
        HRESULT GetTextAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_HSTRING_t **")] IAsyncOperation<HSTRING>** operation);

        [VtblIndex(13)]
        HRESULT GetCustomTextAsync(HSTRING formatId, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_HSTRING_t **")] IAsyncOperation<HSTRING>** operation);

        [VtblIndex(14)]
        [Obsolete("GetUriAsync may be altered or unavailable for releases after Windows 8.1. Instead, use GetWebLinkAsync or GetApplicationLinkAsync.")]
        HRESULT GetUriAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CFoundation__CUri_t **")] IAsyncOperation<Pointer<IUri>>** operation);

        [VtblIndex(15)]
        HRESULT GetHtmlFormatAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_HSTRING_t **")] IAsyncOperation<HSTRING>** operation);

        [VtblIndex(16)]
        HRESULT GetResourceMapAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIMapView_2_HSTRING_Windows__CStorage__CStreams__CRandomAccessStreamReference_t **")] IAsyncOperation<Pointer<IMapView<HSTRING, Pointer<IRandomAccessStreamReference>>>>** operation);

        [VtblIndex(17)]
        HRESULT GetRtfAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_HSTRING_t **")] IAsyncOperation<HSTRING>** operation);

        [VtblIndex(18)]
        HRESULT GetBitmapAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStreams__CRandomAccessStreamReference_t **")] IAsyncOperation<Pointer<IRandomAccessStreamReference>>** operation);

        [VtblIndex(19)]
        HRESULT GetStorageItemsAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CStorage__CIStorageItem_t **")] IAsyncOperation<Pointer<IVectorView<Pointer<IStorageItem>>>>** operation);
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

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::DataTransfer::IDataPackagePropertySetView **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDataPackagePropertySetView**, int> get_Properties;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::DataTransfer::DataPackageOperation *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, DataPackageOperation*, int> get_RequestedOperation;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::DataTransfer::DataPackageOperation) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, DataPackageOperation, int> ReportOperationCompleted;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_HSTRING_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVectorView<HSTRING>**, int> get_AvailableFormats;

        [NativeTypeName("HRESULT (HSTRING, boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, byte*, int> Contains;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_IInspectable_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IAsyncOperation<Pointer<IInspectable>>**, int> GetDataAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_HSTRING_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncOperation<HSTRING>**, int> GetTextAsync;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_HSTRING_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IAsyncOperation<HSTRING>**, int> GetCustomTextAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CFoundation__CUri_t **) __attribute__((stdcall))")]
        [Obsolete("GetUriAsync may be altered or unavailable for releases after Windows 8.1. Instead, use GetWebLinkAsync or GetApplicationLinkAsync.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncOperation<Pointer<IUri>>**, int> GetUriAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_HSTRING_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncOperation<HSTRING>**, int> GetHtmlFormatAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1___FIMapView_2_HSTRING_Windows__CStorage__CStreams__CRandomAccessStreamReference_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncOperation<Pointer<IMapView<HSTRING, Pointer<IRandomAccessStreamReference>>>>**, int> GetResourceMapAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_HSTRING_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncOperation<HSTRING>**, int> GetRtfAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStreams__CRandomAccessStreamReference_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncOperation<Pointer<IRandomAccessStreamReference>>**, int> GetBitmapAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CStorage__CIStorageItem_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncOperation<Pointer<IVectorView<Pointer<IStorageItem>>>>**, int> GetStorageItemsAsync;
    }
}
