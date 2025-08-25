// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.search.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ISearchSuggestionManager.xml' path='doc/member[@name="ISearchSuggestionManager"]/*' />
[Guid("3F0C50A1-CB9D-497B-B500-3C04AC959AD2")]
[NativeTypeName("struct ISearchSuggestionManager : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ISearchSuggestionManager : ISearchSuggestionManager.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_ISearchSuggestionManager);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ISearchSuggestionManager*, Guid*, void**, int>)(lpVtbl[0]))((ISearchSuggestionManager*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ISearchSuggestionManager*, uint>)(lpVtbl[1]))((ISearchSuggestionManager*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ISearchSuggestionManager*, uint>)(lpVtbl[2]))((ISearchSuggestionManager*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ISearchSuggestionManager*, uint*, Guid**, int>)(lpVtbl[3]))((ISearchSuggestionManager*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ISearchSuggestionManager*, HSTRING*, int>)(lpVtbl[4]))((ISearchSuggestionManager*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ISearchSuggestionManager*, TrustLevel*, int>)(lpVtbl[5]))((ISearchSuggestionManager*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ISearchSuggestionManager.xml' path='doc/member[@name="ISearchSuggestionManager.get_SearchHistoryEnabled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_SearchHistoryEnabled([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISearchSuggestionManager*, byte*, int>)(lpVtbl[6]))((ISearchSuggestionManager*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISearchSuggestionManager.xml' path='doc/member[@name="ISearchSuggestionManager.put_SearchHistoryEnabled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_SearchHistoryEnabled([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISearchSuggestionManager*, byte, int>)(lpVtbl[7]))((ISearchSuggestionManager*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISearchSuggestionManager.xml' path='doc/member[@name="ISearchSuggestionManager.get_SearchHistoryContext"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_SearchHistoryContext(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISearchSuggestionManager*, HSTRING*, int>)(lpVtbl[8]))((ISearchSuggestionManager*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISearchSuggestionManager.xml' path='doc/member[@name="ISearchSuggestionManager.put_SearchHistoryContext"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_SearchHistoryContext(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISearchSuggestionManager*, HSTRING, int>)(lpVtbl[9]))((ISearchSuggestionManager*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISearchSuggestionManager.xml' path='doc/member[@name="ISearchSuggestionManager.SetLocalContentSuggestionSettings"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT SetLocalContentSuggestionSettings([NativeTypeName("ABI::Windows::ApplicationModel::Search::ILocalContentSuggestionSettings *")] ILocalContentSuggestionSettings* settings)
    {
        return ((delegate* unmanaged[MemberFunction]<ISearchSuggestionManager*, ILocalContentSuggestionSettings*, int>)(lpVtbl[10]))((ISearchSuggestionManager*)Unsafe.AsPointer(ref this), settings);
    }

    /// <include file='ISearchSuggestionManager.xml' path='doc/member[@name="ISearchSuggestionManager.SetQuery"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT SetQuery(HSTRING queryText)
    {
        return ((delegate* unmanaged[MemberFunction]<ISearchSuggestionManager*, HSTRING, int>)(lpVtbl[11]))((ISearchSuggestionManager*)Unsafe.AsPointer(ref this), queryText);
    }

    /// <include file='ISearchSuggestionManager.xml' path='doc/member[@name="ISearchSuggestionManager.SetQueryWithLanguage"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT SetQueryWithLanguage(HSTRING queryText, HSTRING language)
    {
        return ((delegate* unmanaged[MemberFunction]<ISearchSuggestionManager*, HSTRING, HSTRING, int>)(lpVtbl[12]))((ISearchSuggestionManager*)Unsafe.AsPointer(ref this), queryText, language);
    }

    /// <include file='ISearchSuggestionManager.xml' path='doc/member[@name="ISearchSuggestionManager.SetQueryWithSearchQueryLinguisticDetails"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT SetQueryWithSearchQueryLinguisticDetails(HSTRING queryText, HSTRING language, [NativeTypeName("ABI::Windows::ApplicationModel::Search::ISearchQueryLinguisticDetails *")] ISearchQueryLinguisticDetails* linguisticDetails)
    {
        return ((delegate* unmanaged[MemberFunction]<ISearchSuggestionManager*, HSTRING, HSTRING, ISearchQueryLinguisticDetails*, int>)(lpVtbl[13]))((ISearchSuggestionManager*)Unsafe.AsPointer(ref this), queryText, language, linguisticDetails);
    }

    /// <include file='ISearchSuggestionManager.xml' path='doc/member[@name="ISearchSuggestionManager.get_Suggestions"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_Suggestions([NativeTypeName("ABI::Windows::Foundation::Collections::__FIObservableVector_1_Windows__CApplicationModel__CSearch__CCore__CSearchSuggestion_t **")] IObservableVector<Pointer<ISearchSuggestion>>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISearchSuggestionManager*, IObservableVector<Pointer<ISearchSuggestion>>**, int>)(lpVtbl[14]))((ISearchSuggestionManager*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISearchSuggestionManager.xml' path='doc/member[@name="ISearchSuggestionManager.AddToHistory"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT AddToHistory(HSTRING queryText)
    {
        return ((delegate* unmanaged[MemberFunction]<ISearchSuggestionManager*, HSTRING, int>)(lpVtbl[15]))((ISearchSuggestionManager*)Unsafe.AsPointer(ref this), queryText);
    }

    /// <include file='ISearchSuggestionManager.xml' path='doc/member[@name="ISearchSuggestionManager.AddToHistoryWithLanguage"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT AddToHistoryWithLanguage(HSTRING queryText, HSTRING language)
    {
        return ((delegate* unmanaged[MemberFunction]<ISearchSuggestionManager*, HSTRING, HSTRING, int>)(lpVtbl[16]))((ISearchSuggestionManager*)Unsafe.AsPointer(ref this), queryText, language);
    }

    /// <include file='ISearchSuggestionManager.xml' path='doc/member[@name="ISearchSuggestionManager.ClearHistory"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT ClearHistory()
    {
        return ((delegate* unmanaged[MemberFunction]<ISearchSuggestionManager*, int>)(lpVtbl[17]))((ISearchSuggestionManager*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ISearchSuggestionManager.xml' path='doc/member[@name="ISearchSuggestionManager.add_SuggestionsRequested"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT add_SuggestionsRequested([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CSearch__CCore__CSearchSuggestionManager_Windows__CApplicationModel__CSearch__CCore__CSearchSuggestionsRequestedEventArgs_t *")] ITypedEventHandler<Pointer<ISearchSuggestionManager>, Pointer<ISearchSuggestionsRequestedEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<ISearchSuggestionManager*, ITypedEventHandler<Pointer<ISearchSuggestionManager>, Pointer<ISearchSuggestionsRequestedEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[18]))((ISearchSuggestionManager*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='ISearchSuggestionManager.xml' path='doc/member[@name="ISearchSuggestionManager.remove_SuggestionsRequested"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT remove_SuggestionsRequested(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<ISearchSuggestionManager*, EventRegistrationToken, int>)(lpVtbl[19]))((ISearchSuggestionManager*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='ISearchSuggestionManager.xml' path='doc/member[@name="ISearchSuggestionManager.add_RequestingFocusOnKeyboardInput"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT add_RequestingFocusOnKeyboardInput([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CSearch__CCore__CSearchSuggestionManager_Windows__CApplicationModel__CSearch__CCore__CRequestingFocusOnKeyboardInputEventArgs_t *")] ITypedEventHandler<Pointer<ISearchSuggestionManager>, Pointer<IRequestingFocusOnKeyboardInputEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<ISearchSuggestionManager*, ITypedEventHandler<Pointer<ISearchSuggestionManager>, Pointer<IRequestingFocusOnKeyboardInputEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[20]))((ISearchSuggestionManager*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='ISearchSuggestionManager.xml' path='doc/member[@name="ISearchSuggestionManager.remove_RequestingFocusOnKeyboardInput"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT remove_RequestingFocusOnKeyboardInput(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<ISearchSuggestionManager*, EventRegistrationToken, int>)(lpVtbl[21]))((ISearchSuggestionManager*)Unsafe.AsPointer(ref this), token);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_SearchHistoryEnabled([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(7)]
        HRESULT put_SearchHistoryEnabled([NativeTypeName("boolean")] byte value);

        [VtblIndex(8)]
        HRESULT get_SearchHistoryContext(HSTRING* value);

        [VtblIndex(9)]
        HRESULT put_SearchHistoryContext(HSTRING value);

        [VtblIndex(10)]
        HRESULT SetLocalContentSuggestionSettings([NativeTypeName("ABI::Windows::ApplicationModel::Search::ILocalContentSuggestionSettings *")] ILocalContentSuggestionSettings* settings);

        [VtblIndex(11)]
        HRESULT SetQuery(HSTRING queryText);

        [VtblIndex(12)]
        HRESULT SetQueryWithLanguage(HSTRING queryText, HSTRING language);

        [VtblIndex(13)]
        HRESULT SetQueryWithSearchQueryLinguisticDetails(HSTRING queryText, HSTRING language, [NativeTypeName("ABI::Windows::ApplicationModel::Search::ISearchQueryLinguisticDetails *")] ISearchQueryLinguisticDetails* linguisticDetails);

        [VtblIndex(14)]
        HRESULT get_Suggestions([NativeTypeName("ABI::Windows::Foundation::Collections::__FIObservableVector_1_Windows__CApplicationModel__CSearch__CCore__CSearchSuggestion_t **")] IObservableVector<Pointer<ISearchSuggestion>>** value);

        [VtblIndex(15)]
        HRESULT AddToHistory(HSTRING queryText);

        [VtblIndex(16)]
        HRESULT AddToHistoryWithLanguage(HSTRING queryText, HSTRING language);

        [VtblIndex(17)]
        HRESULT ClearHistory();

        [VtblIndex(18)]
        HRESULT add_SuggestionsRequested([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CSearch__CCore__CSearchSuggestionManager_Windows__CApplicationModel__CSearch__CCore__CSearchSuggestionsRequestedEventArgs_t *")] ITypedEventHandler<Pointer<ISearchSuggestionManager>, Pointer<ISearchSuggestionsRequestedEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(19)]
        HRESULT remove_SuggestionsRequested(EventRegistrationToken token);

        [VtblIndex(20)]
        HRESULT add_RequestingFocusOnKeyboardInput([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CSearch__CCore__CSearchSuggestionManager_Windows__CApplicationModel__CSearch__CCore__CRequestingFocusOnKeyboardInputEventArgs_t *")] ITypedEventHandler<Pointer<ISearchSuggestionManager>, Pointer<IRequestingFocusOnKeyboardInputEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(21)]
        HRESULT remove_RequestingFocusOnKeyboardInput(EventRegistrationToken token);
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

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_SearchHistoryEnabled;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_SearchHistoryEnabled;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_SearchHistoryContext;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_SearchHistoryContext;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Search::ILocalContentSuggestionSettings *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ILocalContentSuggestionSettings*, int> SetLocalContentSuggestionSettings;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> SetQuery;

        [NativeTypeName("HRESULT (HSTRING, HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, HSTRING, int> SetQueryWithLanguage;

        [NativeTypeName("HRESULT (HSTRING, HSTRING, ABI::Windows::ApplicationModel::Search::ISearchQueryLinguisticDetails *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, HSTRING, ISearchQueryLinguisticDetails*, int> SetQueryWithSearchQueryLinguisticDetails;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIObservableVector_1_Windows__CApplicationModel__CSearch__CCore__CSearchSuggestion_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IObservableVector<Pointer<ISearchSuggestion>>**, int> get_Suggestions;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> AddToHistory;

        [NativeTypeName("HRESULT (HSTRING, HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, HSTRING, int> AddToHistoryWithLanguage;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> ClearHistory;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CSearch__CCore__CSearchSuggestionManager_Windows__CApplicationModel__CSearch__CCore__CSearchSuggestionsRequestedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<ISearchSuggestionManager>, Pointer<ISearchSuggestionsRequestedEventArgs>>*, EventRegistrationToken*, int> add_SuggestionsRequested;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_SuggestionsRequested;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CSearch__CCore__CSearchSuggestionManager_Windows__CApplicationModel__CSearch__CCore__CRequestingFocusOnKeyboardInputEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<ISearchSuggestionManager>, Pointer<IRequestingFocusOnKeyboardInputEventArgs>>*, EventRegistrationToken*, int> add_RequestingFocusOnKeyboardInput;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_RequestingFocusOnKeyboardInput;
    }
}
