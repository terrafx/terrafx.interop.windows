// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.activation.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IAppointmentsProviderShowTimeFrameActivatedEventArgs.xml' path='doc/member[@name="IAppointmentsProviderShowTimeFrameActivatedEventArgs"]/*' />
[Guid("9BAEABA6-0E0B-49AA-BABC-12B1DC774986")]
[NativeTypeName("struct IAppointmentsProviderShowTimeFrameActivatedEventArgs : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAppointmentsProviderShowTimeFrameActivatedEventArgs : IAppointmentsProviderShowTimeFrameActivatedEventArgs.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppointmentsProviderShowTimeFrameActivatedEventArgs));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentsProviderShowTimeFrameActivatedEventArgs*, Guid*, void**, int>)(lpVtbl[0]))((IAppointmentsProviderShowTimeFrameActivatedEventArgs*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentsProviderShowTimeFrameActivatedEventArgs*, uint>)(lpVtbl[1]))((IAppointmentsProviderShowTimeFrameActivatedEventArgs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentsProviderShowTimeFrameActivatedEventArgs*, uint>)(lpVtbl[2]))((IAppointmentsProviderShowTimeFrameActivatedEventArgs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentsProviderShowTimeFrameActivatedEventArgs*, uint*, Guid**, int>)(lpVtbl[3]))((IAppointmentsProviderShowTimeFrameActivatedEventArgs*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentsProviderShowTimeFrameActivatedEventArgs*, HSTRING*, int>)(lpVtbl[4]))((IAppointmentsProviderShowTimeFrameActivatedEventArgs*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentsProviderShowTimeFrameActivatedEventArgs*, TrustLevel*, int>)(lpVtbl[5]))((IAppointmentsProviderShowTimeFrameActivatedEventArgs*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IAppointmentsProviderShowTimeFrameActivatedEventArgs.xml' path='doc/member[@name="IAppointmentsProviderShowTimeFrameActivatedEventArgs.get_TimeToShow"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_TimeToShow([NativeTypeName("ABI::Windows::Foundation::DateTime *")] DateTime* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentsProviderShowTimeFrameActivatedEventArgs*, DateTime*, int>)(lpVtbl[6]))((IAppointmentsProviderShowTimeFrameActivatedEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppointmentsProviderShowTimeFrameActivatedEventArgs.xml' path='doc/member[@name="IAppointmentsProviderShowTimeFrameActivatedEventArgs.get_Duration"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Duration([NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppointmentsProviderShowTimeFrameActivatedEventArgs*, TimeSpan*, int>)(lpVtbl[7]))((IAppointmentsProviderShowTimeFrameActivatedEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_TimeToShow([NativeTypeName("ABI::Windows::Foundation::DateTime *")] DateTime* value);

        [VtblIndex(7)]
        HRESULT get_Duration([NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::DateTime *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, DateTime*, int> get_TimeToShow;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::TimeSpan *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TimeSpan*, int> get_Duration;
    }
}
