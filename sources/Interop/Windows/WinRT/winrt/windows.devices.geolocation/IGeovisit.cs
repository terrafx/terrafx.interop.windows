// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.geolocation.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IGeovisit.xml' path='doc/member[@name="IGeovisit"]/*' />
[Guid("B1877A76-9EF6-41AB-A0DD-793ECE76E2DE")]
[NativeTypeName("struct IGeovisit : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IGeovisit : IGeovisit.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IGeovisit));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IGeovisit*, Guid*, void**, int>)(lpVtbl[0]))((IGeovisit*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IGeovisit*, uint>)(lpVtbl[1]))((IGeovisit*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IGeovisit*, uint>)(lpVtbl[2]))((IGeovisit*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IGeovisit*, uint*, Guid**, int>)(lpVtbl[3]))((IGeovisit*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IGeovisit*, HSTRING*, int>)(lpVtbl[4]))((IGeovisit*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IGeovisit*, TrustLevel*, int>)(lpVtbl[5]))((IGeovisit*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IGeovisit.xml' path='doc/member[@name="IGeovisit.get_Position"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Position([NativeTypeName("ABI::Windows::Devices::Geolocation::IGeoposition **")] IGeoposition** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGeovisit*, IGeoposition**, int>)(lpVtbl[6]))((IGeovisit*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGeovisit.xml' path='doc/member[@name="IGeovisit.get_StateChange"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_StateChange([NativeTypeName("ABI::Windows::Devices::Geolocation::VisitStateChange *")] VisitStateChange* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGeovisit*, VisitStateChange*, int>)(lpVtbl[7]))((IGeovisit*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGeovisit.xml' path='doc/member[@name="IGeovisit.get_Timestamp"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Timestamp([NativeTypeName("ABI::Windows::Foundation::DateTime *")] WinRTDateTime* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGeovisit*, WinRTDateTime*, int>)(lpVtbl[8]))((IGeovisit*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Position([NativeTypeName("ABI::Windows::Devices::Geolocation::IGeoposition **")] IGeoposition** value);

        [VtblIndex(7)]
        HRESULT get_StateChange([NativeTypeName("ABI::Windows::Devices::Geolocation::VisitStateChange *")] VisitStateChange* value);

        [VtblIndex(8)]
        HRESULT get_Timestamp([NativeTypeName("ABI::Windows::Foundation::DateTime *")] WinRTDateTime* value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Geolocation::IGeoposition **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IGeoposition**, int> get_Position;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Geolocation::VisitStateChange *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, VisitStateChange*, int> get_StateChange;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::DateTime *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, WinRTDateTime*, int> get_Timestamp;
    }
}
