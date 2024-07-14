// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ICoreWindowPopupShowingEventArgs.xml' path='doc/member[@name="ICoreWindowPopupShowingEventArgs"]/*' />
[Guid("26155FA2-5BA5-4EA4-A3B4-2DC7D63C8E26")]
[NativeTypeName("struct ICoreWindowPopupShowingEventArgs : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICoreWindowPopupShowingEventArgs : ICoreWindowPopupShowingEventArgs.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICoreWindowPopupShowingEventArgs));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreWindowPopupShowingEventArgs*, Guid*, void**, int>)(lpVtbl[0]))((ICoreWindowPopupShowingEventArgs*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreWindowPopupShowingEventArgs*, uint>)(lpVtbl[1]))((ICoreWindowPopupShowingEventArgs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreWindowPopupShowingEventArgs*, uint>)(lpVtbl[2]))((ICoreWindowPopupShowingEventArgs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreWindowPopupShowingEventArgs*, uint*, Guid**, int>)(lpVtbl[3]))((ICoreWindowPopupShowingEventArgs*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreWindowPopupShowingEventArgs*, HSTRING*, int>)(lpVtbl[4]))((ICoreWindowPopupShowingEventArgs*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreWindowPopupShowingEventArgs*, TrustLevel*, int>)(lpVtbl[5]))((ICoreWindowPopupShowingEventArgs*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ICoreWindowPopupShowingEventArgs.xml' path='doc/member[@name="ICoreWindowPopupShowingEventArgs.SetDesiredSize"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetDesiredSize([NativeTypeName("ABI::Windows::Foundation::Size")] Size value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreWindowPopupShowingEventArgs*, Size, int>)(lpVtbl[6]))((ICoreWindowPopupShowingEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT SetDesiredSize([NativeTypeName("ABI::Windows::Foundation::Size")] Size value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Size) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Size, int> SetDesiredSize;
    }
}
