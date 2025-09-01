// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.search.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ISearchSuggestion.xml' path='doc/member[@name="ISearchSuggestion"]/*' />
[Guid("5B5554B0-1527-437B-95C5-8D18D2B8AF55")]
[NativeTypeName("struct ISearchSuggestion : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ISearchSuggestion : ISearchSuggestion.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_ISearchSuggestion);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ISearchSuggestion*, Guid*, void**, int>)(lpVtbl[0]))((ISearchSuggestion*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ISearchSuggestion*, uint>)(lpVtbl[1]))((ISearchSuggestion*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ISearchSuggestion*, uint>)(lpVtbl[2]))((ISearchSuggestion*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ISearchSuggestion*, uint*, Guid**, int>)(lpVtbl[3]))((ISearchSuggestion*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ISearchSuggestion*, HSTRING*, int>)(lpVtbl[4]))((ISearchSuggestion*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ISearchSuggestion*, TrustLevel*, int>)(lpVtbl[5]))((ISearchSuggestion*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ISearchSuggestion.xml' path='doc/member[@name="ISearchSuggestion.get_Kind"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Kind([NativeTypeName("ABI::Windows::ApplicationModel::Search::Core::SearchSuggestionKind *")] SearchSuggestionKind* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISearchSuggestion*, SearchSuggestionKind*, int>)(lpVtbl[6]))((ISearchSuggestion*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISearchSuggestion.xml' path='doc/member[@name="ISearchSuggestion.get_Text"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Text(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISearchSuggestion*, HSTRING*, int>)(lpVtbl[7]))((ISearchSuggestion*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISearchSuggestion.xml' path='doc/member[@name="ISearchSuggestion.get_Tag"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Tag(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISearchSuggestion*, HSTRING*, int>)(lpVtbl[8]))((ISearchSuggestion*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISearchSuggestion.xml' path='doc/member[@name="ISearchSuggestion.get_DetailText"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_DetailText(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISearchSuggestion*, HSTRING*, int>)(lpVtbl[9]))((ISearchSuggestion*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISearchSuggestion.xml' path='doc/member[@name="ISearchSuggestion.get_Image"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_Image([NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamReference **")] IRandomAccessStreamReference** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISearchSuggestion*, IRandomAccessStreamReference**, int>)(lpVtbl[10]))((ISearchSuggestion*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISearchSuggestion.xml' path='doc/member[@name="ISearchSuggestion.get_ImageAlternateText"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_ImageAlternateText(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISearchSuggestion*, HSTRING*, int>)(lpVtbl[11]))((ISearchSuggestion*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Kind([NativeTypeName("ABI::Windows::ApplicationModel::Search::Core::SearchSuggestionKind *")] SearchSuggestionKind* value);

        [VtblIndex(7)]
        HRESULT get_Text(HSTRING* value);

        [VtblIndex(8)]
        HRESULT get_Tag(HSTRING* value);

        [VtblIndex(9)]
        HRESULT get_DetailText(HSTRING* value);

        [VtblIndex(10)]
        HRESULT get_Image([NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamReference **")] IRandomAccessStreamReference** value);

        [VtblIndex(11)]
        HRESULT get_ImageAlternateText(HSTRING* value);
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

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Search::Core::SearchSuggestionKind *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, SearchSuggestionKind*, int> get_Kind;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Text;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Tag;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_DetailText;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IRandomAccessStreamReference **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IRandomAccessStreamReference**, int> get_Image;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_ImageAlternateText;
    }
}
