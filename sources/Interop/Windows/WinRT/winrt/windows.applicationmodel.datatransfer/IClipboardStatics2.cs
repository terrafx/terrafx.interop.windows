// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.datatransfer.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IClipboardStatics2.xml' path='doc/member[@name="IClipboardStatics2"]/*' />
[Guid("D2AC1B6A-D29F-554B-B303-F0452345FE02")]
[NativeTypeName("struct IClipboardStatics2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IClipboardStatics2 : IClipboardStatics2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IClipboardStatics2);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IClipboardStatics2*, Guid*, void**, int>)(lpVtbl[0]))((IClipboardStatics2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IClipboardStatics2*, uint>)(lpVtbl[1]))((IClipboardStatics2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IClipboardStatics2*, uint>)(lpVtbl[2]))((IClipboardStatics2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IClipboardStatics2*, uint*, Guid**, int>)(lpVtbl[3]))((IClipboardStatics2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IClipboardStatics2*, HSTRING*, int>)(lpVtbl[4]))((IClipboardStatics2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IClipboardStatics2*, TrustLevel*, int>)(lpVtbl[5]))((IClipboardStatics2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IClipboardStatics2.xml' path='doc/member[@name="IClipboardStatics2.GetHistoryItemsAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetHistoryItemsAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CDataTransfer__CClipboardHistoryItemsResult_t **")] IAsyncOperation<Pointer<IClipboardHistoryItemsResult>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IClipboardStatics2*, IAsyncOperation<Pointer<IClipboardHistoryItemsResult>>**, int>)(lpVtbl[6]))((IClipboardStatics2*)Unsafe.AsPointer(ref this), operation);
    }

    /// <include file='IClipboardStatics2.xml' path='doc/member[@name="IClipboardStatics2.ClearHistory"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT ClearHistory([NativeTypeName("boolean *")] byte* result)
    {
        return ((delegate* unmanaged[MemberFunction]<IClipboardStatics2*, byte*, int>)(lpVtbl[7]))((IClipboardStatics2*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='IClipboardStatics2.xml' path='doc/member[@name="IClipboardStatics2.DeleteItemFromHistory"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT DeleteItemFromHistory([NativeTypeName("ABI::Windows::ApplicationModel::DataTransfer::IClipboardHistoryItem *")] IClipboardHistoryItem* item, [NativeTypeName("boolean *")] byte* result)
    {
        return ((delegate* unmanaged[MemberFunction]<IClipboardStatics2*, IClipboardHistoryItem*, byte*, int>)(lpVtbl[8]))((IClipboardStatics2*)Unsafe.AsPointer(ref this), item, result);
    }

    /// <include file='IClipboardStatics2.xml' path='doc/member[@name="IClipboardStatics2.SetHistoryItemAsContent"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT SetHistoryItemAsContent([NativeTypeName("ABI::Windows::ApplicationModel::DataTransfer::IClipboardHistoryItem *")] IClipboardHistoryItem* item, [NativeTypeName("ABI::Windows::ApplicationModel::DataTransfer::SetHistoryItemAsContentStatus *")] SetHistoryItemAsContentStatus* result)
    {
        return ((delegate* unmanaged[MemberFunction]<IClipboardStatics2*, IClipboardHistoryItem*, SetHistoryItemAsContentStatus*, int>)(lpVtbl[9]))((IClipboardStatics2*)Unsafe.AsPointer(ref this), item, result);
    }

    /// <include file='IClipboardStatics2.xml' path='doc/member[@name="IClipboardStatics2.IsHistoryEnabled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT IsHistoryEnabled([NativeTypeName("boolean *")] byte* result)
    {
        return ((delegate* unmanaged[MemberFunction]<IClipboardStatics2*, byte*, int>)(lpVtbl[10]))((IClipboardStatics2*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='IClipboardStatics2.xml' path='doc/member[@name="IClipboardStatics2.IsRoamingEnabled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT IsRoamingEnabled([NativeTypeName("boolean *")] byte* result)
    {
        return ((delegate* unmanaged[MemberFunction]<IClipboardStatics2*, byte*, int>)(lpVtbl[11]))((IClipboardStatics2*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='IClipboardStatics2.xml' path='doc/member[@name="IClipboardStatics2.SetContentWithOptions"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT SetContentWithOptions([NativeTypeName("ABI::Windows::ApplicationModel::DataTransfer::IDataPackage *")] IDataPackage* content, [NativeTypeName("ABI::Windows::ApplicationModel::DataTransfer::IClipboardContentOptions *")] IClipboardContentOptions* options, [NativeTypeName("boolean *")] byte* result)
    {
        return ((delegate* unmanaged[MemberFunction]<IClipboardStatics2*, IDataPackage*, IClipboardContentOptions*, byte*, int>)(lpVtbl[12]))((IClipboardStatics2*)Unsafe.AsPointer(ref this), content, options, result);
    }

    /// <include file='IClipboardStatics2.xml' path='doc/member[@name="IClipboardStatics2.add_HistoryChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT add_HistoryChanged([NativeTypeName("ABI::Windows::Foundation::__FIEventHandler_1_Windows__CApplicationModel__CDataTransfer__CClipboardHistoryChangedEventArgs_t *")] IEventHandler<Pointer<IClipboardHistoryChangedEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IClipboardStatics2*, IEventHandler<Pointer<IClipboardHistoryChangedEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[13]))((IClipboardStatics2*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IClipboardStatics2.xml' path='doc/member[@name="IClipboardStatics2.remove_HistoryChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT remove_HistoryChanged(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IClipboardStatics2*, EventRegistrationToken, int>)(lpVtbl[14]))((IClipboardStatics2*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IClipboardStatics2.xml' path='doc/member[@name="IClipboardStatics2.add_RoamingEnabledChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT add_RoamingEnabledChanged([NativeTypeName("ABI::Windows::Foundation::__FIEventHandler_1_IInspectable_t *")] IEventHandler<Pointer<IInspectable>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IClipboardStatics2*, IEventHandler<Pointer<IInspectable>>*, EventRegistrationToken*, int>)(lpVtbl[15]))((IClipboardStatics2*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IClipboardStatics2.xml' path='doc/member[@name="IClipboardStatics2.remove_RoamingEnabledChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT remove_RoamingEnabledChanged(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IClipboardStatics2*, EventRegistrationToken, int>)(lpVtbl[16]))((IClipboardStatics2*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IClipboardStatics2.xml' path='doc/member[@name="IClipboardStatics2.add_HistoryEnabledChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT add_HistoryEnabledChanged([NativeTypeName("ABI::Windows::Foundation::__FIEventHandler_1_IInspectable_t *")] IEventHandler<Pointer<IInspectable>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IClipboardStatics2*, IEventHandler<Pointer<IInspectable>>*, EventRegistrationToken*, int>)(lpVtbl[17]))((IClipboardStatics2*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IClipboardStatics2.xml' path='doc/member[@name="IClipboardStatics2.remove_HistoryEnabledChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT remove_HistoryEnabledChanged(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IClipboardStatics2*, EventRegistrationToken, int>)(lpVtbl[18]))((IClipboardStatics2*)Unsafe.AsPointer(ref this), token);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT GetHistoryItemsAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CDataTransfer__CClipboardHistoryItemsResult_t **")] IAsyncOperation<Pointer<IClipboardHistoryItemsResult>>** operation);

        [VtblIndex(7)]
        HRESULT ClearHistory([NativeTypeName("boolean *")] byte* result);

        [VtblIndex(8)]
        HRESULT DeleteItemFromHistory([NativeTypeName("ABI::Windows::ApplicationModel::DataTransfer::IClipboardHistoryItem *")] IClipboardHistoryItem* item, [NativeTypeName("boolean *")] byte* result);

        [VtblIndex(9)]
        HRESULT SetHistoryItemAsContent([NativeTypeName("ABI::Windows::ApplicationModel::DataTransfer::IClipboardHistoryItem *")] IClipboardHistoryItem* item, [NativeTypeName("ABI::Windows::ApplicationModel::DataTransfer::SetHistoryItemAsContentStatus *")] SetHistoryItemAsContentStatus* result);

        [VtblIndex(10)]
        HRESULT IsHistoryEnabled([NativeTypeName("boolean *")] byte* result);

        [VtblIndex(11)]
        HRESULT IsRoamingEnabled([NativeTypeName("boolean *")] byte* result);

        [VtblIndex(12)]
        HRESULT SetContentWithOptions([NativeTypeName("ABI::Windows::ApplicationModel::DataTransfer::IDataPackage *")] IDataPackage* content, [NativeTypeName("ABI::Windows::ApplicationModel::DataTransfer::IClipboardContentOptions *")] IClipboardContentOptions* options, [NativeTypeName("boolean *")] byte* result);

        [VtblIndex(13)]
        HRESULT add_HistoryChanged([NativeTypeName("ABI::Windows::Foundation::__FIEventHandler_1_Windows__CApplicationModel__CDataTransfer__CClipboardHistoryChangedEventArgs_t *")] IEventHandler<Pointer<IClipboardHistoryChangedEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(14)]
        HRESULT remove_HistoryChanged(EventRegistrationToken token);

        [VtblIndex(15)]
        HRESULT add_RoamingEnabledChanged([NativeTypeName("ABI::Windows::Foundation::__FIEventHandler_1_IInspectable_t *")] IEventHandler<Pointer<IInspectable>>* handler, EventRegistrationToken* token);

        [VtblIndex(16)]
        HRESULT remove_RoamingEnabledChanged(EventRegistrationToken token);

        [VtblIndex(17)]
        HRESULT add_HistoryEnabledChanged([NativeTypeName("ABI::Windows::Foundation::__FIEventHandler_1_IInspectable_t *")] IEventHandler<Pointer<IInspectable>>* handler, EventRegistrationToken* token);

        [VtblIndex(18)]
        HRESULT remove_HistoryEnabledChanged(EventRegistrationToken token);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CDataTransfer__CClipboardHistoryItemsResult_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncOperation<Pointer<IClipboardHistoryItemsResult>>**, int> GetHistoryItemsAsync;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> ClearHistory;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::DataTransfer::IClipboardHistoryItem *, boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IClipboardHistoryItem*, byte*, int> DeleteItemFromHistory;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::DataTransfer::IClipboardHistoryItem *, ABI::Windows::ApplicationModel::DataTransfer::SetHistoryItemAsContentStatus *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IClipboardHistoryItem*, SetHistoryItemAsContentStatus*, int> SetHistoryItemAsContent;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> IsHistoryEnabled;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> IsRoamingEnabled;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::DataTransfer::IDataPackage *, ABI::Windows::ApplicationModel::DataTransfer::IClipboardContentOptions *, boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDataPackage*, IClipboardContentOptions*, byte*, int> SetContentWithOptions;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIEventHandler_1_Windows__CApplicationModel__CDataTransfer__CClipboardHistoryChangedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IEventHandler<Pointer<IClipboardHistoryChangedEventArgs>>*, EventRegistrationToken*, int> add_HistoryChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_HistoryChanged;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIEventHandler_1_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IEventHandler<Pointer<IInspectable>>*, EventRegistrationToken*, int> add_RoamingEnabledChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_RoamingEnabledChanged;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIEventHandler_1_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IEventHandler<Pointer<IInspectable>>*, EventRegistrationToken*, int> add_HistoryEnabledChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_HistoryEnabledChanged;
    }
}
