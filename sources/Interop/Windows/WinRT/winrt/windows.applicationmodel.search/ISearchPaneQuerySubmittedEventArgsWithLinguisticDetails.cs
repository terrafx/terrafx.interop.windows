// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.search.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ISearchPaneQuerySubmittedEventArgsWithLinguisticDetails.xml' path='doc/member[@name="ISearchPaneQuerySubmittedEventArgsWithLinguisticDetails"]/*' />
[Guid("460C92E5-4C32-4538-A4D4-B6B4400D140F")]
[NativeTypeName("struct ISearchPaneQuerySubmittedEventArgsWithLinguisticDetails : IInspectable")]
[NativeInheritance("IInspectable")]
[Obsolete("ISearchPaneQuerySubmittedEventArgsWithLinguisticDetails may be altered or unavailable for releases after Windows 10.")]
public unsafe partial struct ISearchPaneQuerySubmittedEventArgsWithLinguisticDetails : ISearchPaneQuerySubmittedEventArgsWithLinguisticDetails.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISearchPaneQuerySubmittedEventArgsWithLinguisticDetails));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ISearchPaneQuerySubmittedEventArgsWithLinguisticDetails*, Guid*, void**, int>)(lpVtbl[0]))((ISearchPaneQuerySubmittedEventArgsWithLinguisticDetails*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ISearchPaneQuerySubmittedEventArgsWithLinguisticDetails*, uint>)(lpVtbl[1]))((ISearchPaneQuerySubmittedEventArgsWithLinguisticDetails*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ISearchPaneQuerySubmittedEventArgsWithLinguisticDetails*, uint>)(lpVtbl[2]))((ISearchPaneQuerySubmittedEventArgsWithLinguisticDetails*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ISearchPaneQuerySubmittedEventArgsWithLinguisticDetails*, uint*, Guid**, int>)(lpVtbl[3]))((ISearchPaneQuerySubmittedEventArgsWithLinguisticDetails*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ISearchPaneQuerySubmittedEventArgsWithLinguisticDetails*, HSTRING*, int>)(lpVtbl[4]))((ISearchPaneQuerySubmittedEventArgsWithLinguisticDetails*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ISearchPaneQuerySubmittedEventArgsWithLinguisticDetails*, TrustLevel*, int>)(lpVtbl[5]))((ISearchPaneQuerySubmittedEventArgsWithLinguisticDetails*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ISearchPaneQuerySubmittedEventArgsWithLinguisticDetails.xml' path='doc/member[@name="ISearchPaneQuerySubmittedEventArgsWithLinguisticDetails.get_LinguisticDetails"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    [Obsolete("ISearchPaneQuerySubmittedEventArgsWithLinguisticDetails may be altered or unavailable for releases after Windows 10.")]
    public HRESULT get_LinguisticDetails([NativeTypeName("ABI::Windows::ApplicationModel::Search::ISearchPaneQueryLinguisticDetails **")] ISearchPaneQueryLinguisticDetails** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISearchPaneQuerySubmittedEventArgsWithLinguisticDetails*, ISearchPaneQueryLinguisticDetails**, int>)(lpVtbl[6]))((ISearchPaneQuerySubmittedEventArgsWithLinguisticDetails*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        [Obsolete("ISearchPaneQuerySubmittedEventArgsWithLinguisticDetails may be altered or unavailable for releases after Windows 10.")]
        HRESULT get_LinguisticDetails([NativeTypeName("ABI::Windows::ApplicationModel::Search::ISearchPaneQueryLinguisticDetails **")] ISearchPaneQueryLinguisticDetails** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Search::ISearchPaneQueryLinguisticDetails **) __attribute__((stdcall))")]
        [Obsolete("ISearchPaneQuerySubmittedEventArgsWithLinguisticDetails may be altered or unavailable for releases after Windows 10.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ISearchPaneQueryLinguisticDetails**, int> get_LinguisticDetails;
    }
}
