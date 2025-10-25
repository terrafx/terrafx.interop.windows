// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.sensors.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IHumanPresenceSettings3.xml' path='doc/member[@name="IHumanPresenceSettings3"]/*' />
[Guid("89757226-ACC1-4F58-81DF-47F1D69537F2")]
[NativeTypeName("struct IHumanPresenceSettings3 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IHumanPresenceSettings3 : IHumanPresenceSettings3.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IHumanPresenceSettings3);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IHumanPresenceSettings3*, Guid*, void**, int>)(lpVtbl[0]))((IHumanPresenceSettings3*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IHumanPresenceSettings3*, uint>)(lpVtbl[1]))((IHumanPresenceSettings3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IHumanPresenceSettings3*, uint>)(lpVtbl[2]))((IHumanPresenceSettings3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IHumanPresenceSettings3*, uint*, Guid**, int>)(lpVtbl[3]))((IHumanPresenceSettings3*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IHumanPresenceSettings3*, HSTRING*, int>)(lpVtbl[4]))((IHumanPresenceSettings3*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IHumanPresenceSettings3*, TrustLevel*, int>)(lpVtbl[5]))((IHumanPresenceSettings3*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IHumanPresenceSettings3.xml' path='doc/member[@name="IHumanPresenceSettings3.get_IsOnlookerDetectionEnabled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_IsOnlookerDetectionEnabled([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHumanPresenceSettings3*, byte*, int>)(lpVtbl[6]))((IHumanPresenceSettings3*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHumanPresenceSettings3.xml' path='doc/member[@name="IHumanPresenceSettings3.put_IsOnlookerDetectionEnabled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_IsOnlookerDetectionEnabled([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHumanPresenceSettings3*, byte, int>)(lpVtbl[7]))((IHumanPresenceSettings3*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHumanPresenceSettings3.xml' path='doc/member[@name="IHumanPresenceSettings3.get_OnlookerDetectionOptions"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_OnlookerDetectionOptions([NativeTypeName("ABI::Windows::Devices::Sensors::IOnlookerDetectionOptions **")] IOnlookerDetectionOptions** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHumanPresenceSettings3*, IOnlookerDetectionOptions**, int>)(lpVtbl[8]))((IHumanPresenceSettings3*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_IsOnlookerDetectionEnabled([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(7)]
        HRESULT put_IsOnlookerDetectionEnabled([NativeTypeName("boolean")] byte value);

        [VtblIndex(8)]
        HRESULT get_OnlookerDetectionOptions([NativeTypeName("ABI::Windows::Devices::Sensors::IOnlookerDetectionOptions **")] IOnlookerDetectionOptions** value);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsOnlookerDetectionEnabled;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_IsOnlookerDetectionEnabled;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Sensors::IOnlookerDetectionOptions **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IOnlookerDetectionOptions**, int> get_OnlookerDetectionOptions;
    }
}
