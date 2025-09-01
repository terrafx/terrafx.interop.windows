// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.enumeration.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IDevicePairingResult.xml' path='doc/member[@name="IDevicePairingResult"]/*' />
[Guid("072B02BF-DD95-4025-9B37-DE51ADBA37B7")]
[NativeTypeName("struct IDevicePairingResult : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IDevicePairingResult : IDevicePairingResult.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IDevicePairingResult);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IDevicePairingResult*, Guid*, void**, int>)(lpVtbl[0]))((IDevicePairingResult*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IDevicePairingResult*, uint>)(lpVtbl[1]))((IDevicePairingResult*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IDevicePairingResult*, uint>)(lpVtbl[2]))((IDevicePairingResult*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IDevicePairingResult*, uint*, Guid**, int>)(lpVtbl[3]))((IDevicePairingResult*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IDevicePairingResult*, HSTRING*, int>)(lpVtbl[4]))((IDevicePairingResult*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IDevicePairingResult*, TrustLevel*, int>)(lpVtbl[5]))((IDevicePairingResult*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IDevicePairingResult.xml' path='doc/member[@name="IDevicePairingResult.get_Status"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Status([NativeTypeName("ABI::Windows::Devices::Enumeration::DevicePairingResultStatus *")] DevicePairingResultStatus* status)
    {
        return ((delegate* unmanaged[MemberFunction]<IDevicePairingResult*, DevicePairingResultStatus*, int>)(lpVtbl[6]))((IDevicePairingResult*)Unsafe.AsPointer(ref this), status);
    }

    /// <include file='IDevicePairingResult.xml' path='doc/member[@name="IDevicePairingResult.get_ProtectionLevelUsed"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_ProtectionLevelUsed([NativeTypeName("ABI::Windows::Devices::Enumeration::DevicePairingProtectionLevel *")] DevicePairingProtectionLevel* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDevicePairingResult*, DevicePairingProtectionLevel*, int>)(lpVtbl[7]))((IDevicePairingResult*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Status([NativeTypeName("ABI::Windows::Devices::Enumeration::DevicePairingResultStatus *")] DevicePairingResultStatus* status);

        [VtblIndex(7)]
        HRESULT get_ProtectionLevelUsed([NativeTypeName("ABI::Windows::Devices::Enumeration::DevicePairingProtectionLevel *")] DevicePairingProtectionLevel* value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Enumeration::DevicePairingResultStatus *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, DevicePairingResultStatus*, int> get_Status;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Enumeration::DevicePairingProtectionLevel *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, DevicePairingProtectionLevel*, int> get_ProtectionLevelUsed;
    }
}
