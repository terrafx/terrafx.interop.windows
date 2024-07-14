// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.search.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ISearchSuggestionCollection.xml' path='doc/member[@name="ISearchSuggestionCollection"]/*' />
[Guid("323A8A4B-FBEA-4446-ABBC-3DA7915FDD3A")]
[NativeTypeName("struct ISearchSuggestionCollection : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ISearchSuggestionCollection : ISearchSuggestionCollection.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISearchSuggestionCollection));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ISearchSuggestionCollection*, Guid*, void**, int>)(lpVtbl[0]))((ISearchSuggestionCollection*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ISearchSuggestionCollection*, uint>)(lpVtbl[1]))((ISearchSuggestionCollection*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ISearchSuggestionCollection*, uint>)(lpVtbl[2]))((ISearchSuggestionCollection*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ISearchSuggestionCollection*, uint*, Guid**, int>)(lpVtbl[3]))((ISearchSuggestionCollection*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ISearchSuggestionCollection*, HSTRING*, int>)(lpVtbl[4]))((ISearchSuggestionCollection*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ISearchSuggestionCollection*, TrustLevel*, int>)(lpVtbl[5]))((ISearchSuggestionCollection*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ISearchSuggestionCollection.xml' path='doc/member[@name="ISearchSuggestionCollection.get_Size"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Size([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISearchSuggestionCollection*, uint*, int>)(lpVtbl[6]))((ISearchSuggestionCollection*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISearchSuggestionCollection.xml' path='doc/member[@name="ISearchSuggestionCollection.AppendQuerySuggestion"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT AppendQuerySuggestion(HSTRING text)
    {
        return ((delegate* unmanaged[MemberFunction]<ISearchSuggestionCollection*, HSTRING, int>)(lpVtbl[7]))((ISearchSuggestionCollection*)Unsafe.AsPointer(ref this), text);
    }

    /// <include file='ISearchSuggestionCollection.xml' path='doc/member[@name="ISearchSuggestionCollection.AppendQuerySuggestions"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT AppendQuerySuggestions([NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")] IIterable<HSTRING>* suggestions)
    {
        return ((delegate* unmanaged[MemberFunction]<ISearchSuggestionCollection*, IIterable<HSTRING>*, int>)(lpVtbl[8]))((ISearchSuggestionCollection*)Unsafe.AsPointer(ref this), suggestions);
    }

    /// <include file='ISearchSuggestionCollection.xml' path='doc/member[@name="ISearchSuggestionCollection.AppendResultSuggestion"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT AppendResultSuggestion(HSTRING text, HSTRING detailText, HSTRING tag, [NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamReference *")] IRandomAccessStreamReference* image, HSTRING imageAlternateText)
    {
        return ((delegate* unmanaged[MemberFunction]<ISearchSuggestionCollection*, HSTRING, HSTRING, HSTRING, IRandomAccessStreamReference*, HSTRING, int>)(lpVtbl[9]))((ISearchSuggestionCollection*)Unsafe.AsPointer(ref this), text, detailText, tag, image, imageAlternateText);
    }

    /// <include file='ISearchSuggestionCollection.xml' path='doc/member[@name="ISearchSuggestionCollection.AppendSearchSeparator"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT AppendSearchSeparator(HSTRING label)
    {
        return ((delegate* unmanaged[MemberFunction]<ISearchSuggestionCollection*, HSTRING, int>)(lpVtbl[10]))((ISearchSuggestionCollection*)Unsafe.AsPointer(ref this), label);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Size([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(7)]
        HRESULT AppendQuerySuggestion(HSTRING text);

        [VtblIndex(8)]
        HRESULT AppendQuerySuggestions([NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")] IIterable<HSTRING>* suggestions);

        [VtblIndex(9)]
        HRESULT AppendResultSuggestion(HSTRING text, HSTRING detailText, HSTRING tag, [NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamReference *")] IRandomAccessStreamReference* image, HSTRING imageAlternateText);

        [VtblIndex(10)]
        HRESULT AppendSearchSeparator(HSTRING label);
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

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_Size;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> AppendQuerySuggestion;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IIterable<HSTRING>*, int> AppendQuerySuggestions;

        [NativeTypeName("HRESULT (HSTRING, HSTRING, HSTRING, ABI::Windows::Storage::Streams::IRandomAccessStreamReference *, HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, HSTRING, HSTRING, IRandomAccessStreamReference*, HSTRING, int> AppendResultSuggestion;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> AppendSearchSeparator;
    }
}
