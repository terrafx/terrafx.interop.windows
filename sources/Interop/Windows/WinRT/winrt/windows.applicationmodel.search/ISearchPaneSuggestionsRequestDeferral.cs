// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.search.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ISearchPaneSuggestionsRequestDeferral.xml' path='doc/member[@name="ISearchPaneSuggestionsRequestDeferral"]/*' />
[Guid("A0D009F7-8748-4EE2-AD44-AFA6BE997C51")]
[NativeTypeName("struct ISearchPaneSuggestionsRequestDeferral : IInspectable")]
[NativeInheritance("IInspectable")]
[Obsolete("ISearchPaneSuggestionsRequestDeferral may be altered or unavailable for releases after Windows 10.")]
public unsafe partial struct ISearchPaneSuggestionsRequestDeferral : ISearchPaneSuggestionsRequestDeferral.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISearchPaneSuggestionsRequestDeferral));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ISearchPaneSuggestionsRequestDeferral*, Guid*, void**, int>)(lpVtbl[0]))((ISearchPaneSuggestionsRequestDeferral*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ISearchPaneSuggestionsRequestDeferral*, uint>)(lpVtbl[1]))((ISearchPaneSuggestionsRequestDeferral*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ISearchPaneSuggestionsRequestDeferral*, uint>)(lpVtbl[2]))((ISearchPaneSuggestionsRequestDeferral*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ISearchPaneSuggestionsRequestDeferral*, uint*, Guid**, int>)(lpVtbl[3]))((ISearchPaneSuggestionsRequestDeferral*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ISearchPaneSuggestionsRequestDeferral*, HSTRING*, int>)(lpVtbl[4]))((ISearchPaneSuggestionsRequestDeferral*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ISearchPaneSuggestionsRequestDeferral*, TrustLevel*, int>)(lpVtbl[5]))((ISearchPaneSuggestionsRequestDeferral*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ISearchPaneSuggestionsRequestDeferral.xml' path='doc/member[@name="ISearchPaneSuggestionsRequestDeferral.Complete"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    [Obsolete("ISearchPaneSuggestionsRequestDeferral may be altered or unavailable for releases after Windows 10.")]
    public HRESULT Complete()
    {
        return ((delegate* unmanaged[MemberFunction]<ISearchPaneSuggestionsRequestDeferral*, int>)(lpVtbl[6]))((ISearchPaneSuggestionsRequestDeferral*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        [Obsolete("ISearchPaneSuggestionsRequestDeferral may be altered or unavailable for releases after Windows 10.")]
        HRESULT Complete();
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

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        [Obsolete("ISearchPaneSuggestionsRequestDeferral may be altered or unavailable for releases after Windows 10.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> Complete;
    }
}
