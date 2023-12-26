// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.search.core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ISearchSuggestionsRequestedEventArgs.xml' path='doc/member[@name="ISearchSuggestionsRequestedEventArgs"]/*' />
[Guid("6FD519E5-9E7E-4AB4-8BE3-C76B1BD4344A")]
[NativeTypeName("struct ISearchSuggestionsRequestedEventArgs : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ISearchSuggestionsRequestedEventArgs : ISearchSuggestionsRequestedEventArgs.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISearchSuggestionsRequestedEventArgs));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ISearchSuggestionsRequestedEventArgs*, Guid*, void**, int>)(lpVtbl[0]))((ISearchSuggestionsRequestedEventArgs*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ISearchSuggestionsRequestedEventArgs*, uint>)(lpVtbl[1]))((ISearchSuggestionsRequestedEventArgs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ISearchSuggestionsRequestedEventArgs*, uint>)(lpVtbl[2]))((ISearchSuggestionsRequestedEventArgs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ISearchSuggestionsRequestedEventArgs*, uint*, Guid**, int>)(lpVtbl[3]))((ISearchSuggestionsRequestedEventArgs*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ISearchSuggestionsRequestedEventArgs*, HSTRING*, int>)(lpVtbl[4]))((ISearchSuggestionsRequestedEventArgs*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ISearchSuggestionsRequestedEventArgs*, TrustLevel*, int>)(lpVtbl[5]))((ISearchSuggestionsRequestedEventArgs*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ISearchSuggestionsRequestedEventArgs.xml' path='doc/member[@name="ISearchSuggestionsRequestedEventArgs.get_QueryText"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_QueryText(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISearchSuggestionsRequestedEventArgs*, HSTRING*, int>)(lpVtbl[6]))((ISearchSuggestionsRequestedEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISearchSuggestionsRequestedEventArgs.xml' path='doc/member[@name="ISearchSuggestionsRequestedEventArgs.get_Language"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Language(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISearchSuggestionsRequestedEventArgs*, HSTRING*, int>)(lpVtbl[7]))((ISearchSuggestionsRequestedEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISearchSuggestionsRequestedEventArgs.xml' path='doc/member[@name="ISearchSuggestionsRequestedEventArgs.get_LinguisticDetails"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_LinguisticDetails([NativeTypeName("ABI::Windows::ApplicationModel::Search::ISearchQueryLinguisticDetails **")] ISearchQueryLinguisticDetails** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISearchSuggestionsRequestedEventArgs*, ISearchQueryLinguisticDetails**, int>)(lpVtbl[8]))((ISearchSuggestionsRequestedEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISearchSuggestionsRequestedEventArgs.xml' path='doc/member[@name="ISearchSuggestionsRequestedEventArgs.get_Request"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_Request([NativeTypeName("ABI::Windows::ApplicationModel::Search::ISearchSuggestionsRequest **")] ISearchSuggestionsRequest** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISearchSuggestionsRequestedEventArgs*, ISearchSuggestionsRequest**, int>)(lpVtbl[9]))((ISearchSuggestionsRequestedEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_QueryText(HSTRING* value);

        [VtblIndex(7)]
        HRESULT get_Language(HSTRING* value);

        [VtblIndex(8)]
        HRESULT get_LinguisticDetails([NativeTypeName("ABI::Windows::ApplicationModel::Search::ISearchQueryLinguisticDetails **")] ISearchQueryLinguisticDetails** value);

        [VtblIndex(9)]
        HRESULT get_Request([NativeTypeName("ABI::Windows::ApplicationModel::Search::ISearchSuggestionsRequest **")] ISearchSuggestionsRequest** value);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_QueryText;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Language;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Search::ISearchQueryLinguisticDetails **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ISearchQueryLinguisticDetails**, int> get_LinguisticDetails;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Search::ISearchSuggestionsRequest **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ISearchSuggestionsRequest**, int> get_Request;
    }
}
