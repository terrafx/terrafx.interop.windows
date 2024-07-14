// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.search.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ISearchPaneVisibilityChangedEventArgs.xml' path='doc/member[@name="ISearchPaneVisibilityChangedEventArgs"]/*' />
[Guid("3C4D3046-AC4B-49F2-97D6-020E6182CB9C")]
[NativeTypeName("struct ISearchPaneVisibilityChangedEventArgs : IInspectable")]
[NativeInheritance("IInspectable")]
[Obsolete("ISearchPaneVisibilityChangedEventArgs may be altered or unavailable for releases after Windows 10.")]
public unsafe partial struct ISearchPaneVisibilityChangedEventArgs : ISearchPaneVisibilityChangedEventArgs.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISearchPaneVisibilityChangedEventArgs));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ISearchPaneVisibilityChangedEventArgs*, Guid*, void**, int>)(lpVtbl[0]))((ISearchPaneVisibilityChangedEventArgs*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ISearchPaneVisibilityChangedEventArgs*, uint>)(lpVtbl[1]))((ISearchPaneVisibilityChangedEventArgs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ISearchPaneVisibilityChangedEventArgs*, uint>)(lpVtbl[2]))((ISearchPaneVisibilityChangedEventArgs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ISearchPaneVisibilityChangedEventArgs*, uint*, Guid**, int>)(lpVtbl[3]))((ISearchPaneVisibilityChangedEventArgs*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ISearchPaneVisibilityChangedEventArgs*, HSTRING*, int>)(lpVtbl[4]))((ISearchPaneVisibilityChangedEventArgs*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ISearchPaneVisibilityChangedEventArgs*, TrustLevel*, int>)(lpVtbl[5]))((ISearchPaneVisibilityChangedEventArgs*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ISearchPaneVisibilityChangedEventArgs.xml' path='doc/member[@name="ISearchPaneVisibilityChangedEventArgs.get_Visible"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    [Obsolete("ISearchPaneVisibilityChangedEventArgs may be altered or unavailable for releases after Windows 10.")]
    public HRESULT get_Visible([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISearchPaneVisibilityChangedEventArgs*, byte*, int>)(lpVtbl[6]))((ISearchPaneVisibilityChangedEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        [Obsolete("ISearchPaneVisibilityChangedEventArgs may be altered or unavailable for releases after Windows 10.")]
        HRESULT get_Visible([NativeTypeName("boolean *")] byte* value);
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
        [Obsolete("ISearchPaneVisibilityChangedEventArgs may be altered or unavailable for releases after Windows 10.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_Visible;
    }
}
