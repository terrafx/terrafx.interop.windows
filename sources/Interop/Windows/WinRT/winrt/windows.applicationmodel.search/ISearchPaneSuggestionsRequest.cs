// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.search.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ISearchPaneSuggestionsRequest.xml' path='doc/member[@name="ISearchPaneSuggestionsRequest"]/*' />
[Guid("81B10B1C-E561-4093-9B4D-2AD482794A53")]
[NativeTypeName("struct ISearchPaneSuggestionsRequest : IInspectable")]
[NativeInheritance("IInspectable")]
[Obsolete("ISearchPaneSuggestionsRequest may be altered or unavailable for releases after Windows 10.")]
public unsafe partial struct ISearchPaneSuggestionsRequest : ISearchPaneSuggestionsRequest.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISearchPaneSuggestionsRequest));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ISearchPaneSuggestionsRequest*, Guid*, void**, int>)(lpVtbl[0]))((ISearchPaneSuggestionsRequest*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ISearchPaneSuggestionsRequest*, uint>)(lpVtbl[1]))((ISearchPaneSuggestionsRequest*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ISearchPaneSuggestionsRequest*, uint>)(lpVtbl[2]))((ISearchPaneSuggestionsRequest*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ISearchPaneSuggestionsRequest*, uint*, Guid**, int>)(lpVtbl[3]))((ISearchPaneSuggestionsRequest*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ISearchPaneSuggestionsRequest*, HSTRING*, int>)(lpVtbl[4]))((ISearchPaneSuggestionsRequest*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ISearchPaneSuggestionsRequest*, TrustLevel*, int>)(lpVtbl[5]))((ISearchPaneSuggestionsRequest*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ISearchPaneSuggestionsRequest.xml' path='doc/member[@name="ISearchPaneSuggestionsRequest.get_IsCanceled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    [Obsolete("ISearchPaneSuggestionsRequest may be altered or unavailable for releases after Windows 10.")]
    public HRESULT get_IsCanceled([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISearchPaneSuggestionsRequest*, byte*, int>)(lpVtbl[6]))((ISearchPaneSuggestionsRequest*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISearchPaneSuggestionsRequest.xml' path='doc/member[@name="ISearchPaneSuggestionsRequest.get_SearchSuggestionCollection"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    [Obsolete("ISearchPaneSuggestionsRequest may be altered or unavailable for releases after Windows 10.")]
    public HRESULT get_SearchSuggestionCollection([NativeTypeName("ABI::Windows::ApplicationModel::Search::ISearchSuggestionCollection **")] ISearchSuggestionCollection** collection)
    {
        return ((delegate* unmanaged[MemberFunction]<ISearchPaneSuggestionsRequest*, ISearchSuggestionCollection**, int>)(lpVtbl[7]))((ISearchPaneSuggestionsRequest*)Unsafe.AsPointer(ref this), collection);
    }

    /// <include file='ISearchPaneSuggestionsRequest.xml' path='doc/member[@name="ISearchPaneSuggestionsRequest.GetDeferral"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    [Obsolete("ISearchPaneSuggestionsRequest may be altered or unavailable for releases after Windows 10.")]
    public HRESULT GetDeferral([NativeTypeName("ABI::Windows::ApplicationModel::Search::ISearchPaneSuggestionsRequestDeferral **")] ISearchPaneSuggestionsRequestDeferral** deferral)
    {
        return ((delegate* unmanaged[MemberFunction]<ISearchPaneSuggestionsRequest*, ISearchPaneSuggestionsRequestDeferral**, int>)(lpVtbl[8]))((ISearchPaneSuggestionsRequest*)Unsafe.AsPointer(ref this), deferral);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        [Obsolete("ISearchPaneSuggestionsRequest may be altered or unavailable for releases after Windows 10.")]
        HRESULT get_IsCanceled([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(7)]
        [Obsolete("ISearchPaneSuggestionsRequest may be altered or unavailable for releases after Windows 10.")]
        HRESULT get_SearchSuggestionCollection([NativeTypeName("ABI::Windows::ApplicationModel::Search::ISearchSuggestionCollection **")] ISearchSuggestionCollection** collection);

        [VtblIndex(8)]
        [Obsolete("ISearchPaneSuggestionsRequest may be altered or unavailable for releases after Windows 10.")]
        HRESULT GetDeferral([NativeTypeName("ABI::Windows::ApplicationModel::Search::ISearchPaneSuggestionsRequestDeferral **")] ISearchPaneSuggestionsRequestDeferral** deferral);
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
        [Obsolete("ISearchPaneSuggestionsRequest may be altered or unavailable for releases after Windows 10.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsCanceled;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Search::ISearchSuggestionCollection **) __attribute__((stdcall))")]
        [Obsolete("ISearchPaneSuggestionsRequest may be altered or unavailable for releases after Windows 10.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ISearchSuggestionCollection**, int> get_SearchSuggestionCollection;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Search::ISearchPaneSuggestionsRequestDeferral **) __attribute__((stdcall))")]
        [Obsolete("ISearchPaneSuggestionsRequest may be altered or unavailable for releases after Windows 10.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ISearchPaneSuggestionsRequestDeferral**, int> GetDeferral;
    }
}
