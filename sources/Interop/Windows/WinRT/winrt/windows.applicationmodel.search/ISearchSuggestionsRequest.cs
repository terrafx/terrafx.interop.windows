// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.search.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ISearchSuggestionsRequest.xml' path='doc/member[@name="ISearchSuggestionsRequest"]/*' />
[Guid("4E4E26A7-44E5-4039-9099-6000EAD1F0C6")]
[NativeTypeName("struct ISearchSuggestionsRequest : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ISearchSuggestionsRequest : ISearchSuggestionsRequest.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISearchSuggestionsRequest));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ISearchSuggestionsRequest*, Guid*, void**, int>)(lpVtbl[0]))((ISearchSuggestionsRequest*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ISearchSuggestionsRequest*, uint>)(lpVtbl[1]))((ISearchSuggestionsRequest*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ISearchSuggestionsRequest*, uint>)(lpVtbl[2]))((ISearchSuggestionsRequest*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ISearchSuggestionsRequest*, uint*, Guid**, int>)(lpVtbl[3]))((ISearchSuggestionsRequest*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ISearchSuggestionsRequest*, HSTRING*, int>)(lpVtbl[4]))((ISearchSuggestionsRequest*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ISearchSuggestionsRequest*, TrustLevel*, int>)(lpVtbl[5]))((ISearchSuggestionsRequest*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ISearchSuggestionsRequest.xml' path='doc/member[@name="ISearchSuggestionsRequest.get_IsCanceled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_IsCanceled([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISearchSuggestionsRequest*, byte*, int>)(lpVtbl[6]))((ISearchSuggestionsRequest*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISearchSuggestionsRequest.xml' path='doc/member[@name="ISearchSuggestionsRequest.get_SearchSuggestionCollection"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_SearchSuggestionCollection([NativeTypeName("ABI::Windows::ApplicationModel::Search::ISearchSuggestionCollection **")] ISearchSuggestionCollection** collection)
    {
        return ((delegate* unmanaged[MemberFunction]<ISearchSuggestionsRequest*, ISearchSuggestionCollection**, int>)(lpVtbl[7]))((ISearchSuggestionsRequest*)Unsafe.AsPointer(ref this), collection);
    }

    /// <include file='ISearchSuggestionsRequest.xml' path='doc/member[@name="ISearchSuggestionsRequest.GetDeferral"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetDeferral([NativeTypeName("ABI::Windows::ApplicationModel::Search::ISearchSuggestionsRequestDeferral **")] ISearchSuggestionsRequestDeferral** deferral)
    {
        return ((delegate* unmanaged[MemberFunction]<ISearchSuggestionsRequest*, ISearchSuggestionsRequestDeferral**, int>)(lpVtbl[8]))((ISearchSuggestionsRequest*)Unsafe.AsPointer(ref this), deferral);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_IsCanceled([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(7)]
        HRESULT get_SearchSuggestionCollection([NativeTypeName("ABI::Windows::ApplicationModel::Search::ISearchSuggestionCollection **")] ISearchSuggestionCollection** collection);

        [VtblIndex(8)]
        HRESULT GetDeferral([NativeTypeName("ABI::Windows::ApplicationModel::Search::ISearchSuggestionsRequestDeferral **")] ISearchSuggestionsRequestDeferral** deferral);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsCanceled;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Search::ISearchSuggestionCollection **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ISearchSuggestionCollection**, int> get_SearchSuggestionCollection;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Search::ISearchSuggestionsRequestDeferral **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ISearchSuggestionsRequestDeferral**, int> GetDeferral;
    }
}
