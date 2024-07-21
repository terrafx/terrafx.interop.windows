// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.search.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ISearchPaneQuerySubmittedEventArgs.xml' path='doc/member[@name="ISearchPaneQuerySubmittedEventArgs"]/*' />
[Guid("143BA4FC-E9C5-4736-91B2-E8EB9CB88356")]
[NativeTypeName("struct ISearchPaneQuerySubmittedEventArgs : IInspectable")]
[NativeInheritance("IInspectable")]
[Obsolete("ISearchPaneQuerySubmittedEventArgs may be altered or unavailable for releases after Windows 10.")]
public unsafe partial struct ISearchPaneQuerySubmittedEventArgs : ISearchPaneQuerySubmittedEventArgs.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISearchPaneQuerySubmittedEventArgs));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ISearchPaneQuerySubmittedEventArgs*, Guid*, void**, int>)(lpVtbl[0]))((ISearchPaneQuerySubmittedEventArgs*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ISearchPaneQuerySubmittedEventArgs*, uint>)(lpVtbl[1]))((ISearchPaneQuerySubmittedEventArgs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ISearchPaneQuerySubmittedEventArgs*, uint>)(lpVtbl[2]))((ISearchPaneQuerySubmittedEventArgs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ISearchPaneQuerySubmittedEventArgs*, uint*, Guid**, int>)(lpVtbl[3]))((ISearchPaneQuerySubmittedEventArgs*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ISearchPaneQuerySubmittedEventArgs*, HSTRING*, int>)(lpVtbl[4]))((ISearchPaneQuerySubmittedEventArgs*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ISearchPaneQuerySubmittedEventArgs*, TrustLevel*, int>)(lpVtbl[5]))((ISearchPaneQuerySubmittedEventArgs*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ISearchPaneQuerySubmittedEventArgs.xml' path='doc/member[@name="ISearchPaneQuerySubmittedEventArgs.get_QueryText"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    [Obsolete("ISearchPaneQuerySubmittedEventArgs may be altered or unavailable for releases after Windows 10.")]
    public HRESULT get_QueryText(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISearchPaneQuerySubmittedEventArgs*, HSTRING*, int>)(lpVtbl[6]))((ISearchPaneQuerySubmittedEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISearchPaneQuerySubmittedEventArgs.xml' path='doc/member[@name="ISearchPaneQuerySubmittedEventArgs.get_Language"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    [Obsolete("ISearchPaneQuerySubmittedEventArgs may be altered or unavailable for releases after Windows 10.")]
    public HRESULT get_Language(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISearchPaneQuerySubmittedEventArgs*, HSTRING*, int>)(lpVtbl[7]))((ISearchPaneQuerySubmittedEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        [Obsolete("ISearchPaneQuerySubmittedEventArgs may be altered or unavailable for releases after Windows 10.")]
        HRESULT get_QueryText(HSTRING* value);

        [VtblIndex(7)]
        [Obsolete("ISearchPaneQuerySubmittedEventArgs may be altered or unavailable for releases after Windows 10.")]
        HRESULT get_Language(HSTRING* value);
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
        [Obsolete("ISearchPaneQuerySubmittedEventArgs may be altered or unavailable for releases after Windows 10.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_QueryText;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        [Obsolete("ISearchPaneQuerySubmittedEventArgs may be altered or unavailable for releases after Windows 10.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Language;
    }
}
