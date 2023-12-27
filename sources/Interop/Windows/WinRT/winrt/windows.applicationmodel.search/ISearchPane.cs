// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.search.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ISearchPane.xml' path='doc/member[@name="ISearchPane"]/*' />
[Guid("FDACEC38-3700-4D73-91A1-2F998674238A")]
[NativeTypeName("struct ISearchPane : IInspectable")]
[NativeInheritance("IInspectable")]
[Obsolete("ISearchPane may be altered or unavailable for releases after Windows 10.")]
public unsafe partial struct ISearchPane : ISearchPane.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISearchPane));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ISearchPane*, Guid*, void**, int>)(lpVtbl[0]))((ISearchPane*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ISearchPane*, uint>)(lpVtbl[1]))((ISearchPane*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ISearchPane*, uint>)(lpVtbl[2]))((ISearchPane*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ISearchPane*, uint*, Guid**, int>)(lpVtbl[3]))((ISearchPane*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ISearchPane*, HSTRING*, int>)(lpVtbl[4]))((ISearchPane*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ISearchPane*, TrustLevel*, int>)(lpVtbl[5]))((ISearchPane*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ISearchPane.xml' path='doc/member[@name="ISearchPane.put_SearchHistoryEnabled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    [Obsolete("ISearchPane may be altered or unavailable for releases after Windows 10.")]
    public HRESULT put_SearchHistoryEnabled([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISearchPane*, byte, int>)(lpVtbl[6]))((ISearchPane*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISearchPane.xml' path='doc/member[@name="ISearchPane.get_SearchHistoryEnabled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    [Obsolete("ISearchPane may be altered or unavailable for releases after Windows 10.")]
    public HRESULT get_SearchHistoryEnabled([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISearchPane*, byte*, int>)(lpVtbl[7]))((ISearchPane*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISearchPane.xml' path='doc/member[@name="ISearchPane.put_SearchHistoryContext"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    [Obsolete("ISearchPane may be altered or unavailable for releases after Windows 10.")]
    public HRESULT put_SearchHistoryContext(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISearchPane*, HSTRING, int>)(lpVtbl[8]))((ISearchPane*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISearchPane.xml' path='doc/member[@name="ISearchPane.get_SearchHistoryContext"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    [Obsolete("ISearchPane may be altered or unavailable for releases after Windows 10.")]
    public HRESULT get_SearchHistoryContext(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISearchPane*, HSTRING*, int>)(lpVtbl[9]))((ISearchPane*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISearchPane.xml' path='doc/member[@name="ISearchPane.put_PlaceholderText"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    [Obsolete("ISearchPane may be altered or unavailable for releases after Windows 10.")]
    public HRESULT put_PlaceholderText(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISearchPane*, HSTRING, int>)(lpVtbl[10]))((ISearchPane*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISearchPane.xml' path='doc/member[@name="ISearchPane.get_PlaceholderText"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    [Obsolete("ISearchPane may be altered or unavailable for releases after Windows 10.")]
    public HRESULT get_PlaceholderText(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISearchPane*, HSTRING*, int>)(lpVtbl[11]))((ISearchPane*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISearchPane.xml' path='doc/member[@name="ISearchPane.get_QueryText"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    [Obsolete("ISearchPane may be altered or unavailable for releases after Windows 10.")]
    public HRESULT get_QueryText(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISearchPane*, HSTRING*, int>)(lpVtbl[12]))((ISearchPane*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISearchPane.xml' path='doc/member[@name="ISearchPane.get_Language"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    [Obsolete("ISearchPane may be altered or unavailable for releases after Windows 10.")]
    public HRESULT get_Language(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISearchPane*, HSTRING*, int>)(lpVtbl[13]))((ISearchPane*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISearchPane.xml' path='doc/member[@name="ISearchPane.get_Visible"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    [Obsolete("ISearchPane may be altered or unavailable for releases after Windows 10.")]
    public HRESULT get_Visible([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISearchPane*, byte*, int>)(lpVtbl[14]))((ISearchPane*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISearchPane.xml' path='doc/member[@name="ISearchPane.add_VisibilityChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    [Obsolete("ISearchPane may be altered or unavailable for releases after Windows 10.")]
    public HRESULT add_VisibilityChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CSearch__CSearchPane_Windows__CApplicationModel__CSearch__CSearchPaneVisibilityChangedEventArgs_t *")] ITypedEventHandler<Pointer<ISearchPane>, Pointer<ISearchPaneVisibilityChangedEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<ISearchPane*, ITypedEventHandler<Pointer<ISearchPane>, Pointer<ISearchPaneVisibilityChangedEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[15]))((ISearchPane*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='ISearchPane.xml' path='doc/member[@name="ISearchPane.remove_VisibilityChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    [Obsolete("ISearchPane may be altered or unavailable for releases after Windows 10.")]
    public HRESULT remove_VisibilityChanged(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<ISearchPane*, EventRegistrationToken, int>)(lpVtbl[16]))((ISearchPane*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='ISearchPane.xml' path='doc/member[@name="ISearchPane.add_QueryChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    [Obsolete("ISearchPane may be altered or unavailable for releases after Windows 10.")]
    public HRESULT add_QueryChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CSearch__CSearchPane_Windows__CApplicationModel__CSearch__CSearchPaneQueryChangedEventArgs_t *")] ITypedEventHandler<Pointer<ISearchPane>, Pointer<ISearchPaneQueryChangedEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<ISearchPane*, ITypedEventHandler<Pointer<ISearchPane>, Pointer<ISearchPaneQueryChangedEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[17]))((ISearchPane*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='ISearchPane.xml' path='doc/member[@name="ISearchPane.remove_QueryChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    [Obsolete("ISearchPane may be altered or unavailable for releases after Windows 10.")]
    public HRESULT remove_QueryChanged(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<ISearchPane*, EventRegistrationToken, int>)(lpVtbl[18]))((ISearchPane*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='ISearchPane.xml' path='doc/member[@name="ISearchPane.add_SuggestionsRequested"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    [Obsolete("ISearchPane may be altered or unavailable for releases after Windows 10.")]
    public HRESULT add_SuggestionsRequested([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CSearch__CSearchPane_Windows__CApplicationModel__CSearch__CSearchPaneSuggestionsRequestedEventArgs_t *")] ITypedEventHandler<Pointer<ISearchPane>, Pointer<ISearchPaneSuggestionsRequestedEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<ISearchPane*, ITypedEventHandler<Pointer<ISearchPane>, Pointer<ISearchPaneSuggestionsRequestedEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[19]))((ISearchPane*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='ISearchPane.xml' path='doc/member[@name="ISearchPane.remove_SuggestionsRequested"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    [Obsolete("ISearchPane may be altered or unavailable for releases after Windows 10.")]
    public HRESULT remove_SuggestionsRequested(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<ISearchPane*, EventRegistrationToken, int>)(lpVtbl[20]))((ISearchPane*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='ISearchPane.xml' path='doc/member[@name="ISearchPane.add_QuerySubmitted"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    [Obsolete("ISearchPane may be altered or unavailable for releases after Windows 10.")]
    public HRESULT add_QuerySubmitted([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CSearch__CSearchPane_Windows__CApplicationModel__CSearch__CSearchPaneQuerySubmittedEventArgs_t *")] ITypedEventHandler<Pointer<ISearchPane>, Pointer<ISearchPaneQuerySubmittedEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<ISearchPane*, ITypedEventHandler<Pointer<ISearchPane>, Pointer<ISearchPaneQuerySubmittedEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[21]))((ISearchPane*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='ISearchPane.xml' path='doc/member[@name="ISearchPane.remove_QuerySubmitted"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    [Obsolete("ISearchPane may be altered or unavailable for releases after Windows 10.")]
    public HRESULT remove_QuerySubmitted(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<ISearchPane*, EventRegistrationToken, int>)(lpVtbl[22]))((ISearchPane*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='ISearchPane.xml' path='doc/member[@name="ISearchPane.add_ResultSuggestionChosen"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    [Obsolete("ISearchPane may be altered or unavailable for releases after Windows 10.")]
    public HRESULT add_ResultSuggestionChosen([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CSearch__CSearchPane_Windows__CApplicationModel__CSearch__CSearchPaneResultSuggestionChosenEventArgs_t *")] ITypedEventHandler<Pointer<ISearchPane>, Pointer<ISearchPaneResultSuggestionChosenEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<ISearchPane*, ITypedEventHandler<Pointer<ISearchPane>, Pointer<ISearchPaneResultSuggestionChosenEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[23]))((ISearchPane*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='ISearchPane.xml' path='doc/member[@name="ISearchPane.remove_ResultSuggestionChosen"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    [Obsolete("ISearchPane may be altered or unavailable for releases after Windows 10.")]
    public HRESULT remove_ResultSuggestionChosen(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<ISearchPane*, EventRegistrationToken, int>)(lpVtbl[24]))((ISearchPane*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='ISearchPane.xml' path='doc/member[@name="ISearchPane.SetLocalContentSuggestionSettings"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    [Obsolete("ISearchPane may be altered or unavailable for releases after Windows 10.")]
    public HRESULT SetLocalContentSuggestionSettings([NativeTypeName("ABI::Windows::ApplicationModel::Search::ILocalContentSuggestionSettings *")] ILocalContentSuggestionSettings* settings)
    {
        return ((delegate* unmanaged[MemberFunction]<ISearchPane*, ILocalContentSuggestionSettings*, int>)(lpVtbl[25]))((ISearchPane*)Unsafe.AsPointer(ref this), settings);
    }

    /// <include file='ISearchPane.xml' path='doc/member[@name="ISearchPane.ShowOverloadDefault"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    [Obsolete("ISearchPane may be altered or unavailable for releases after Windows 10.")]
    public HRESULT ShowOverloadDefault()
    {
        return ((delegate* unmanaged[MemberFunction]<ISearchPane*, int>)(lpVtbl[26]))((ISearchPane*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ISearchPane.xml' path='doc/member[@name="ISearchPane.ShowOverloadWithQuery"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    [Obsolete("ISearchPane may be altered or unavailable for releases after Windows 10.")]
    public HRESULT ShowOverloadWithQuery(HSTRING query)
    {
        return ((delegate* unmanaged[MemberFunction]<ISearchPane*, HSTRING, int>)(lpVtbl[27]))((ISearchPane*)Unsafe.AsPointer(ref this), query);
    }

    /// <include file='ISearchPane.xml' path='doc/member[@name="ISearchPane.put_ShowOnKeyboardInput"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    [Obsolete("ISearchPane may be altered or unavailable for releases after Windows 10.")]
    public HRESULT put_ShowOnKeyboardInput([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISearchPane*, byte, int>)(lpVtbl[28]))((ISearchPane*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISearchPane.xml' path='doc/member[@name="ISearchPane.get_ShowOnKeyboardInput"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    [Obsolete("ISearchPane may be altered or unavailable for releases after Windows 10.")]
    public HRESULT get_ShowOnKeyboardInput([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISearchPane*, byte*, int>)(lpVtbl[29]))((ISearchPane*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISearchPane.xml' path='doc/member[@name="ISearchPane.TrySetQueryText"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    [Obsolete("ISearchPane may be altered or unavailable for releases after Windows 10.")]
    public HRESULT TrySetQueryText(HSTRING query, [NativeTypeName("boolean *")] byte* succeeded)
    {
        return ((delegate* unmanaged[MemberFunction]<ISearchPane*, HSTRING, byte*, int>)(lpVtbl[30]))((ISearchPane*)Unsafe.AsPointer(ref this), query, succeeded);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        [Obsolete("ISearchPane may be altered or unavailable for releases after Windows 10.")]
        HRESULT put_SearchHistoryEnabled([NativeTypeName("boolean")] byte value);

        [VtblIndex(7)]
        [Obsolete("ISearchPane may be altered or unavailable for releases after Windows 10.")]
        HRESULT get_SearchHistoryEnabled([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(8)]
        [Obsolete("ISearchPane may be altered or unavailable for releases after Windows 10.")]
        HRESULT put_SearchHistoryContext(HSTRING value);

        [VtblIndex(9)]
        [Obsolete("ISearchPane may be altered or unavailable for releases after Windows 10.")]
        HRESULT get_SearchHistoryContext(HSTRING* value);

        [VtblIndex(10)]
        [Obsolete("ISearchPane may be altered or unavailable for releases after Windows 10.")]
        HRESULT put_PlaceholderText(HSTRING value);

        [VtblIndex(11)]
        [Obsolete("ISearchPane may be altered or unavailable for releases after Windows 10.")]
        HRESULT get_PlaceholderText(HSTRING* value);

        [VtblIndex(12)]
        [Obsolete("ISearchPane may be altered or unavailable for releases after Windows 10.")]
        HRESULT get_QueryText(HSTRING* value);

        [VtblIndex(13)]
        [Obsolete("ISearchPane may be altered or unavailable for releases after Windows 10.")]
        HRESULT get_Language(HSTRING* value);

        [VtblIndex(14)]
        [Obsolete("ISearchPane may be altered or unavailable for releases after Windows 10.")]
        HRESULT get_Visible([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(15)]
        [Obsolete("ISearchPane may be altered or unavailable for releases after Windows 10.")]
        HRESULT add_VisibilityChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CSearch__CSearchPane_Windows__CApplicationModel__CSearch__CSearchPaneVisibilityChangedEventArgs_t *")] ITypedEventHandler<Pointer<ISearchPane>, Pointer<ISearchPaneVisibilityChangedEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(16)]
        [Obsolete("ISearchPane may be altered or unavailable for releases after Windows 10.")]
        HRESULT remove_VisibilityChanged(EventRegistrationToken token);

        [VtblIndex(17)]
        [Obsolete("ISearchPane may be altered or unavailable for releases after Windows 10.")]
        HRESULT add_QueryChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CSearch__CSearchPane_Windows__CApplicationModel__CSearch__CSearchPaneQueryChangedEventArgs_t *")] ITypedEventHandler<Pointer<ISearchPane>, Pointer<ISearchPaneQueryChangedEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(18)]
        [Obsolete("ISearchPane may be altered or unavailable for releases after Windows 10.")]
        HRESULT remove_QueryChanged(EventRegistrationToken token);

        [VtblIndex(19)]
        [Obsolete("ISearchPane may be altered or unavailable for releases after Windows 10.")]
        HRESULT add_SuggestionsRequested([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CSearch__CSearchPane_Windows__CApplicationModel__CSearch__CSearchPaneSuggestionsRequestedEventArgs_t *")] ITypedEventHandler<Pointer<ISearchPane>, Pointer<ISearchPaneSuggestionsRequestedEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(20)]
        [Obsolete("ISearchPane may be altered or unavailable for releases after Windows 10.")]
        HRESULT remove_SuggestionsRequested(EventRegistrationToken token);

        [VtblIndex(21)]
        [Obsolete("ISearchPane may be altered or unavailable for releases after Windows 10.")]
        HRESULT add_QuerySubmitted([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CSearch__CSearchPane_Windows__CApplicationModel__CSearch__CSearchPaneQuerySubmittedEventArgs_t *")] ITypedEventHandler<Pointer<ISearchPane>, Pointer<ISearchPaneQuerySubmittedEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(22)]
        [Obsolete("ISearchPane may be altered or unavailable for releases after Windows 10.")]
        HRESULT remove_QuerySubmitted(EventRegistrationToken token);

        [VtblIndex(23)]
        [Obsolete("ISearchPane may be altered or unavailable for releases after Windows 10.")]
        HRESULT add_ResultSuggestionChosen([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CSearch__CSearchPane_Windows__CApplicationModel__CSearch__CSearchPaneResultSuggestionChosenEventArgs_t *")] ITypedEventHandler<Pointer<ISearchPane>, Pointer<ISearchPaneResultSuggestionChosenEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(24)]
        [Obsolete("ISearchPane may be altered or unavailable for releases after Windows 10.")]
        HRESULT remove_ResultSuggestionChosen(EventRegistrationToken token);

        [VtblIndex(25)]
        [Obsolete("ISearchPane may be altered or unavailable for releases after Windows 10.")]
        HRESULT SetLocalContentSuggestionSettings([NativeTypeName("ABI::Windows::ApplicationModel::Search::ILocalContentSuggestionSettings *")] ILocalContentSuggestionSettings* settings);

        [VtblIndex(26)]
        [Obsolete("ISearchPane may be altered or unavailable for releases after Windows 10.")]
        HRESULT ShowOverloadDefault();

        [VtblIndex(27)]
        [Obsolete("ISearchPane may be altered or unavailable for releases after Windows 10.")]
        HRESULT ShowOverloadWithQuery(HSTRING query);

        [VtblIndex(28)]
        [Obsolete("ISearchPane may be altered or unavailable for releases after Windows 10.")]
        HRESULT put_ShowOnKeyboardInput([NativeTypeName("boolean")] byte value);

        [VtblIndex(29)]
        [Obsolete("ISearchPane may be altered or unavailable for releases after Windows 10.")]
        HRESULT get_ShowOnKeyboardInput([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(30)]
        [Obsolete("ISearchPane may be altered or unavailable for releases after Windows 10.")]
        HRESULT TrySetQueryText(HSTRING query, [NativeTypeName("boolean *")] byte* succeeded);
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

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        [Obsolete("ISearchPane may be altered or unavailable for releases after Windows 10.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_SearchHistoryEnabled;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        [Obsolete("ISearchPane may be altered or unavailable for releases after Windows 10.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_SearchHistoryEnabled;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        [Obsolete("ISearchPane may be altered or unavailable for releases after Windows 10.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_SearchHistoryContext;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        [Obsolete("ISearchPane may be altered or unavailable for releases after Windows 10.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_SearchHistoryContext;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        [Obsolete("ISearchPane may be altered or unavailable for releases after Windows 10.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_PlaceholderText;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        [Obsolete("ISearchPane may be altered or unavailable for releases after Windows 10.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_PlaceholderText;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        [Obsolete("ISearchPane may be altered or unavailable for releases after Windows 10.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_QueryText;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        [Obsolete("ISearchPane may be altered or unavailable for releases after Windows 10.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Language;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        [Obsolete("ISearchPane may be altered or unavailable for releases after Windows 10.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_Visible;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CSearch__CSearchPane_Windows__CApplicationModel__CSearch__CSearchPaneVisibilityChangedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        [Obsolete("ISearchPane may be altered or unavailable for releases after Windows 10.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<ISearchPane>, Pointer<ISearchPaneVisibilityChangedEventArgs>>*, EventRegistrationToken*, int> add_VisibilityChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        [Obsolete("ISearchPane may be altered or unavailable for releases after Windows 10.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_VisibilityChanged;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CSearch__CSearchPane_Windows__CApplicationModel__CSearch__CSearchPaneQueryChangedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        [Obsolete("ISearchPane may be altered or unavailable for releases after Windows 10.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<ISearchPane>, Pointer<ISearchPaneQueryChangedEventArgs>>*, EventRegistrationToken*, int> add_QueryChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        [Obsolete("ISearchPane may be altered or unavailable for releases after Windows 10.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_QueryChanged;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CSearch__CSearchPane_Windows__CApplicationModel__CSearch__CSearchPaneSuggestionsRequestedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        [Obsolete("ISearchPane may be altered or unavailable for releases after Windows 10.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<ISearchPane>, Pointer<ISearchPaneSuggestionsRequestedEventArgs>>*, EventRegistrationToken*, int> add_SuggestionsRequested;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        [Obsolete("ISearchPane may be altered or unavailable for releases after Windows 10.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_SuggestionsRequested;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CSearch__CSearchPane_Windows__CApplicationModel__CSearch__CSearchPaneQuerySubmittedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        [Obsolete("ISearchPane may be altered or unavailable for releases after Windows 10.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<ISearchPane>, Pointer<ISearchPaneQuerySubmittedEventArgs>>*, EventRegistrationToken*, int> add_QuerySubmitted;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        [Obsolete("ISearchPane may be altered or unavailable for releases after Windows 10.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_QuerySubmitted;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CSearch__CSearchPane_Windows__CApplicationModel__CSearch__CSearchPaneResultSuggestionChosenEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        [Obsolete("ISearchPane may be altered or unavailable for releases after Windows 10.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<ISearchPane>, Pointer<ISearchPaneResultSuggestionChosenEventArgs>>*, EventRegistrationToken*, int> add_ResultSuggestionChosen;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        [Obsolete("ISearchPane may be altered or unavailable for releases after Windows 10.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_ResultSuggestionChosen;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Search::ILocalContentSuggestionSettings *) __attribute__((stdcall))")]
        [Obsolete("ISearchPane may be altered or unavailable for releases after Windows 10.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ILocalContentSuggestionSettings*, int> SetLocalContentSuggestionSettings;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        [Obsolete("ISearchPane may be altered or unavailable for releases after Windows 10.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> ShowOverloadDefault;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        [Obsolete("ISearchPane may be altered or unavailable for releases after Windows 10.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> ShowOverloadWithQuery;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        [Obsolete("ISearchPane may be altered or unavailable for releases after Windows 10.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_ShowOnKeyboardInput;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        [Obsolete("ISearchPane may be altered or unavailable for releases after Windows 10.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_ShowOnKeyboardInput;

        [NativeTypeName("HRESULT (HSTRING, boolean *) __attribute__((stdcall))")]
        [Obsolete("ISearchPane may be altered or unavailable for releases after Windows 10.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, byte*, int> TrySetQueryText;
    }
}
