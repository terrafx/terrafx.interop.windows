// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.calls.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IPhoneCallHistoryStore.xml' path='doc/member[@name="IPhoneCallHistoryStore"]/*' />
[Guid("2F907DB8-B40E-422B-8545-CB1910A61C52")]
[NativeTypeName("struct IPhoneCallHistoryStore : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IPhoneCallHistoryStore : IPhoneCallHistoryStore.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IPhoneCallHistoryStore);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCallHistoryStore*, Guid*, void**, int>)(lpVtbl[0]))((IPhoneCallHistoryStore*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCallHistoryStore*, uint>)(lpVtbl[1]))((IPhoneCallHistoryStore*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCallHistoryStore*, uint>)(lpVtbl[2]))((IPhoneCallHistoryStore*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCallHistoryStore*, uint*, Guid**, int>)(lpVtbl[3]))((IPhoneCallHistoryStore*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCallHistoryStore*, HSTRING*, int>)(lpVtbl[4]))((IPhoneCallHistoryStore*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCallHistoryStore*, TrustLevel*, int>)(lpVtbl[5]))((IPhoneCallHistoryStore*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IPhoneCallHistoryStore.xml' path='doc/member[@name="IPhoneCallHistoryStore.GetEntryAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetEntryAsync(HSTRING callHistoryEntryId, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CCalls__CPhoneCallHistoryEntry_t **")] IAsyncOperation<Pointer<IPhoneCallHistoryEntry>>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCallHistoryStore*, HSTRING, IAsyncOperation<Pointer<IPhoneCallHistoryEntry>>**, int>)(lpVtbl[6]))((IPhoneCallHistoryStore*)Unsafe.AsPointer(ref this), callHistoryEntryId, result);
    }

    /// <include file='IPhoneCallHistoryStore.xml' path='doc/member[@name="IPhoneCallHistoryStore.GetEntryReader"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetEntryReader([NativeTypeName("ABI::Windows::ApplicationModel::Calls::IPhoneCallHistoryEntryReader **")] IPhoneCallHistoryEntryReader** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCallHistoryStore*, IPhoneCallHistoryEntryReader**, int>)(lpVtbl[7]))((IPhoneCallHistoryStore*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='IPhoneCallHistoryStore.xml' path='doc/member[@name="IPhoneCallHistoryStore.GetEntryReaderWithOptions"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetEntryReaderWithOptions([NativeTypeName("ABI::Windows::ApplicationModel::Calls::IPhoneCallHistoryEntryQueryOptions *")] IPhoneCallHistoryEntryQueryOptions* queryOptions, [NativeTypeName("ABI::Windows::ApplicationModel::Calls::IPhoneCallHistoryEntryReader **")] IPhoneCallHistoryEntryReader** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCallHistoryStore*, IPhoneCallHistoryEntryQueryOptions*, IPhoneCallHistoryEntryReader**, int>)(lpVtbl[8]))((IPhoneCallHistoryStore*)Unsafe.AsPointer(ref this), queryOptions, result);
    }

    /// <include file='IPhoneCallHistoryStore.xml' path='doc/member[@name="IPhoneCallHistoryStore.SaveEntryAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT SaveEntryAsync([NativeTypeName("ABI::Windows::ApplicationModel::Calls::IPhoneCallHistoryEntry *")] IPhoneCallHistoryEntry* callHistoryEntry, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCallHistoryStore*, IPhoneCallHistoryEntry*, IAsyncAction**, int>)(lpVtbl[9]))((IPhoneCallHistoryStore*)Unsafe.AsPointer(ref this), callHistoryEntry, result);
    }

    /// <include file='IPhoneCallHistoryStore.xml' path='doc/member[@name="IPhoneCallHistoryStore.DeleteEntryAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT DeleteEntryAsync([NativeTypeName("ABI::Windows::ApplicationModel::Calls::IPhoneCallHistoryEntry *")] IPhoneCallHistoryEntry* callHistoryEntry, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCallHistoryStore*, IPhoneCallHistoryEntry*, IAsyncAction**, int>)(lpVtbl[10]))((IPhoneCallHistoryStore*)Unsafe.AsPointer(ref this), callHistoryEntry, result);
    }

    /// <include file='IPhoneCallHistoryStore.xml' path='doc/member[@name="IPhoneCallHistoryStore.DeleteEntriesAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT DeleteEntriesAsync([NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CApplicationModel__CCalls__CPhoneCallHistoryEntry_t *")] IIterable<Pointer<IPhoneCallHistoryEntry>>* callHistoryEntries, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCallHistoryStore*, IIterable<Pointer<IPhoneCallHistoryEntry>>*, IAsyncAction**, int>)(lpVtbl[11]))((IPhoneCallHistoryStore*)Unsafe.AsPointer(ref this), callHistoryEntries, result);
    }

    /// <include file='IPhoneCallHistoryStore.xml' path='doc/member[@name="IPhoneCallHistoryStore.MarkEntryAsSeenAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT MarkEntryAsSeenAsync([NativeTypeName("ABI::Windows::ApplicationModel::Calls::IPhoneCallHistoryEntry *")] IPhoneCallHistoryEntry* callHistoryEntry, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCallHistoryStore*, IPhoneCallHistoryEntry*, IAsyncAction**, int>)(lpVtbl[12]))((IPhoneCallHistoryStore*)Unsafe.AsPointer(ref this), callHistoryEntry, result);
    }

    /// <include file='IPhoneCallHistoryStore.xml' path='doc/member[@name="IPhoneCallHistoryStore.MarkEntriesAsSeenAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT MarkEntriesAsSeenAsync([NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CApplicationModel__CCalls__CPhoneCallHistoryEntry_t *")] IIterable<Pointer<IPhoneCallHistoryEntry>>* callHistoryEntries, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCallHistoryStore*, IIterable<Pointer<IPhoneCallHistoryEntry>>*, IAsyncAction**, int>)(lpVtbl[13]))((IPhoneCallHistoryStore*)Unsafe.AsPointer(ref this), callHistoryEntries, result);
    }

    /// <include file='IPhoneCallHistoryStore.xml' path='doc/member[@name="IPhoneCallHistoryStore.GetUnseenCountAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT GetUnseenCountAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_UINT32_t **")] IAsyncOperation<uint>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCallHistoryStore*, IAsyncOperation<uint>**, int>)(lpVtbl[14]))((IPhoneCallHistoryStore*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='IPhoneCallHistoryStore.xml' path='doc/member[@name="IPhoneCallHistoryStore.MarkAllAsSeenAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT MarkAllAsSeenAsync([NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCallHistoryStore*, IAsyncAction**, int>)(lpVtbl[15]))((IPhoneCallHistoryStore*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='IPhoneCallHistoryStore.xml' path='doc/member[@name="IPhoneCallHistoryStore.GetSourcesUnseenCountAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT GetSourcesUnseenCountAsync([NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")] IIterable<HSTRING>* sourceIds, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_UINT32_t **")] IAsyncOperation<uint>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCallHistoryStore*, IIterable<HSTRING>*, IAsyncOperation<uint>**, int>)(lpVtbl[16]))((IPhoneCallHistoryStore*)Unsafe.AsPointer(ref this), sourceIds, result);
    }

    /// <include file='IPhoneCallHistoryStore.xml' path='doc/member[@name="IPhoneCallHistoryStore.MarkSourcesAsSeenAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT MarkSourcesAsSeenAsync([NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")] IIterable<HSTRING>* sourceIds, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCallHistoryStore*, IIterable<HSTRING>*, IAsyncAction**, int>)(lpVtbl[17]))((IPhoneCallHistoryStore*)Unsafe.AsPointer(ref this), sourceIds, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT GetEntryAsync(HSTRING callHistoryEntryId, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CCalls__CPhoneCallHistoryEntry_t **")] IAsyncOperation<Pointer<IPhoneCallHistoryEntry>>** result);

        [VtblIndex(7)]
        HRESULT GetEntryReader([NativeTypeName("ABI::Windows::ApplicationModel::Calls::IPhoneCallHistoryEntryReader **")] IPhoneCallHistoryEntryReader** result);

        [VtblIndex(8)]
        HRESULT GetEntryReaderWithOptions([NativeTypeName("ABI::Windows::ApplicationModel::Calls::IPhoneCallHistoryEntryQueryOptions *")] IPhoneCallHistoryEntryQueryOptions* queryOptions, [NativeTypeName("ABI::Windows::ApplicationModel::Calls::IPhoneCallHistoryEntryReader **")] IPhoneCallHistoryEntryReader** result);

        [VtblIndex(9)]
        HRESULT SaveEntryAsync([NativeTypeName("ABI::Windows::ApplicationModel::Calls::IPhoneCallHistoryEntry *")] IPhoneCallHistoryEntry* callHistoryEntry, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** result);

        [VtblIndex(10)]
        HRESULT DeleteEntryAsync([NativeTypeName("ABI::Windows::ApplicationModel::Calls::IPhoneCallHistoryEntry *")] IPhoneCallHistoryEntry* callHistoryEntry, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** result);

        [VtblIndex(11)]
        HRESULT DeleteEntriesAsync([NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CApplicationModel__CCalls__CPhoneCallHistoryEntry_t *")] IIterable<Pointer<IPhoneCallHistoryEntry>>* callHistoryEntries, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** result);

        [VtblIndex(12)]
        HRESULT MarkEntryAsSeenAsync([NativeTypeName("ABI::Windows::ApplicationModel::Calls::IPhoneCallHistoryEntry *")] IPhoneCallHistoryEntry* callHistoryEntry, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** result);

        [VtblIndex(13)]
        HRESULT MarkEntriesAsSeenAsync([NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CApplicationModel__CCalls__CPhoneCallHistoryEntry_t *")] IIterable<Pointer<IPhoneCallHistoryEntry>>* callHistoryEntries, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** result);

        [VtblIndex(14)]
        HRESULT GetUnseenCountAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_UINT32_t **")] IAsyncOperation<uint>** result);

        [VtblIndex(15)]
        HRESULT MarkAllAsSeenAsync([NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** result);

        [VtblIndex(16)]
        HRESULT GetSourcesUnseenCountAsync([NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")] IIterable<HSTRING>* sourceIds, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_UINT32_t **")] IAsyncOperation<uint>** result);

        [VtblIndex(17)]
        HRESULT MarkSourcesAsSeenAsync([NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")] IIterable<HSTRING>* sourceIds, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** result);
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

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CCalls__CPhoneCallHistoryEntry_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IAsyncOperation<Pointer<IPhoneCallHistoryEntry>>**, int> GetEntryAsync;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Calls::IPhoneCallHistoryEntryReader **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IPhoneCallHistoryEntryReader**, int> GetEntryReader;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Calls::IPhoneCallHistoryEntryQueryOptions *, ABI::Windows::ApplicationModel::Calls::IPhoneCallHistoryEntryReader **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IPhoneCallHistoryEntryQueryOptions*, IPhoneCallHistoryEntryReader**, int> GetEntryReaderWithOptions;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Calls::IPhoneCallHistoryEntry *, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IPhoneCallHistoryEntry*, IAsyncAction**, int> SaveEntryAsync;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Calls::IPhoneCallHistoryEntry *, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IPhoneCallHistoryEntry*, IAsyncAction**, int> DeleteEntryAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CApplicationModel__CCalls__CPhoneCallHistoryEntry_t *, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IIterable<Pointer<IPhoneCallHistoryEntry>>*, IAsyncAction**, int> DeleteEntriesAsync;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Calls::IPhoneCallHistoryEntry *, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IPhoneCallHistoryEntry*, IAsyncAction**, int> MarkEntryAsSeenAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CApplicationModel__CCalls__CPhoneCallHistoryEntry_t *, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IIterable<Pointer<IPhoneCallHistoryEntry>>*, IAsyncAction**, int> MarkEntriesAsSeenAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_UINT32_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncOperation<uint>**, int> GetUnseenCountAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncAction**, int> MarkAllAsSeenAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *, ABI::Windows::Foundation::__FIAsyncOperation_1_UINT32_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IIterable<HSTRING>*, IAsyncOperation<uint>**, int> GetSourcesUnseenCountAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IIterable<HSTRING>*, IAsyncAction**, int> MarkSourcesAsSeenAsync;
    }
}
