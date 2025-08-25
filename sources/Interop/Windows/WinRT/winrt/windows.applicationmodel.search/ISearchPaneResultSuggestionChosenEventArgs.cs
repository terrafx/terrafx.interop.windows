// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.search.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ISearchPaneResultSuggestionChosenEventArgs.xml' path='doc/member[@name="ISearchPaneResultSuggestionChosenEventArgs"]/*' />
[Guid("C8316CC0-AED2-41E0-BCE0-C26CA74F85EC")]
[NativeTypeName("struct ISearchPaneResultSuggestionChosenEventArgs : IInspectable")]
[NativeInheritance("IInspectable")]
[Obsolete("ISearchPaneResultSuggestionChosenEventArgs may be altered or unavailable for releases after Windows 10.")]
public unsafe partial struct ISearchPaneResultSuggestionChosenEventArgs : ISearchPaneResultSuggestionChosenEventArgs.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_ISearchPaneResultSuggestionChosenEventArgs);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ISearchPaneResultSuggestionChosenEventArgs*, Guid*, void**, int>)(lpVtbl[0]))((ISearchPaneResultSuggestionChosenEventArgs*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ISearchPaneResultSuggestionChosenEventArgs*, uint>)(lpVtbl[1]))((ISearchPaneResultSuggestionChosenEventArgs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ISearchPaneResultSuggestionChosenEventArgs*, uint>)(lpVtbl[2]))((ISearchPaneResultSuggestionChosenEventArgs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ISearchPaneResultSuggestionChosenEventArgs*, uint*, Guid**, int>)(lpVtbl[3]))((ISearchPaneResultSuggestionChosenEventArgs*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ISearchPaneResultSuggestionChosenEventArgs*, HSTRING*, int>)(lpVtbl[4]))((ISearchPaneResultSuggestionChosenEventArgs*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ISearchPaneResultSuggestionChosenEventArgs*, TrustLevel*, int>)(lpVtbl[5]))((ISearchPaneResultSuggestionChosenEventArgs*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ISearchPaneResultSuggestionChosenEventArgs.xml' path='doc/member[@name="ISearchPaneResultSuggestionChosenEventArgs.get_Tag"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    [Obsolete("ISearchPaneResultSuggestionChosenEventArgs may be altered or unavailable for releases after Windows 10.")]
    public HRESULT get_Tag(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISearchPaneResultSuggestionChosenEventArgs*, HSTRING*, int>)(lpVtbl[6]))((ISearchPaneResultSuggestionChosenEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        [Obsolete("ISearchPaneResultSuggestionChosenEventArgs may be altered or unavailable for releases after Windows 10.")]
        HRESULT get_Tag(HSTRING* value);
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
        [Obsolete("ISearchPaneResultSuggestionChosenEventArgs may be altered or unavailable for releases after Windows 10.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Tag;
    }
}
