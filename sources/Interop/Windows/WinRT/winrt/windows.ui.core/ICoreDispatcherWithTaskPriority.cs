// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ICoreDispatcherWithTaskPriority.xml' path='doc/member[@name="ICoreDispatcherWithTaskPriority"]/*' />
[Guid("BAFAECAD-484D-41BE-BA80-1D58C65263EA")]
[NativeTypeName("struct ICoreDispatcherWithTaskPriority : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICoreDispatcherWithTaskPriority : ICoreDispatcherWithTaskPriority.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICoreDispatcherWithTaskPriority));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreDispatcherWithTaskPriority*, Guid*, void**, int>)(lpVtbl[0]))((ICoreDispatcherWithTaskPriority*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreDispatcherWithTaskPriority*, uint>)(lpVtbl[1]))((ICoreDispatcherWithTaskPriority*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreDispatcherWithTaskPriority*, uint>)(lpVtbl[2]))((ICoreDispatcherWithTaskPriority*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreDispatcherWithTaskPriority*, uint*, Guid**, int>)(lpVtbl[3]))((ICoreDispatcherWithTaskPriority*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreDispatcherWithTaskPriority*, HSTRING*, int>)(lpVtbl[4]))((ICoreDispatcherWithTaskPriority*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreDispatcherWithTaskPriority*, TrustLevel*, int>)(lpVtbl[5]))((ICoreDispatcherWithTaskPriority*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ICoreDispatcherWithTaskPriority.xml' path='doc/member[@name="ICoreDispatcherWithTaskPriority.get_CurrentPriority"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_CurrentPriority([NativeTypeName("ABI::Windows::UI::Core::CoreDispatcherPriority *")] CoreDispatcherPriority* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreDispatcherWithTaskPriority*, CoreDispatcherPriority*, int>)(lpVtbl[6]))((ICoreDispatcherWithTaskPriority*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICoreDispatcherWithTaskPriority.xml' path='doc/member[@name="ICoreDispatcherWithTaskPriority.put_CurrentPriority"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_CurrentPriority([NativeTypeName("ABI::Windows::UI::Core::CoreDispatcherPriority")] CoreDispatcherPriority value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreDispatcherWithTaskPriority*, CoreDispatcherPriority, int>)(lpVtbl[7]))((ICoreDispatcherWithTaskPriority*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICoreDispatcherWithTaskPriority.xml' path='doc/member[@name="ICoreDispatcherWithTaskPriority.ShouldYield"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT ShouldYield([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreDispatcherWithTaskPriority*, byte*, int>)(lpVtbl[8]))((ICoreDispatcherWithTaskPriority*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICoreDispatcherWithTaskPriority.xml' path='doc/member[@name="ICoreDispatcherWithTaskPriority.ShouldYieldToPriority"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT ShouldYieldToPriority([NativeTypeName("ABI::Windows::UI::Core::CoreDispatcherPriority")] CoreDispatcherPriority priority, [NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreDispatcherWithTaskPriority*, CoreDispatcherPriority, byte*, int>)(lpVtbl[9]))((ICoreDispatcherWithTaskPriority*)Unsafe.AsPointer(ref this), priority, value);
    }

    /// <include file='ICoreDispatcherWithTaskPriority.xml' path='doc/member[@name="ICoreDispatcherWithTaskPriority.StopProcessEvents"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT StopProcessEvents()
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreDispatcherWithTaskPriority*, int>)(lpVtbl[10]))((ICoreDispatcherWithTaskPriority*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_CurrentPriority([NativeTypeName("ABI::Windows::UI::Core::CoreDispatcherPriority *")] CoreDispatcherPriority* value);

        [VtblIndex(7)]
        HRESULT put_CurrentPriority([NativeTypeName("ABI::Windows::UI::Core::CoreDispatcherPriority")] CoreDispatcherPriority value);

        [VtblIndex(8)]
        HRESULT ShouldYield([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(9)]
        HRESULT ShouldYieldToPriority([NativeTypeName("ABI::Windows::UI::Core::CoreDispatcherPriority")] CoreDispatcherPriority priority, [NativeTypeName("boolean *")] byte* value);

        [VtblIndex(10)]
        HRESULT StopProcessEvents();
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

        [NativeTypeName("HRESULT (ABI::Windows::UI::Core::CoreDispatcherPriority *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, CoreDispatcherPriority*, int> get_CurrentPriority;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Core::CoreDispatcherPriority) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, CoreDispatcherPriority, int> put_CurrentPriority;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> ShouldYield;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Core::CoreDispatcherPriority, boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, CoreDispatcherPriority, byte*, int> ShouldYieldToPriority;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> StopProcessEvents;
    }
}
