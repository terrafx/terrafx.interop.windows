// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.sms.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ISmsDevice2Statics.xml' path='doc/member[@name="ISmsDevice2Statics"]/*' />
[Guid("65C78325-1031-491E-8FB6-EF9991AFE363")]
[NativeTypeName("struct ISmsDevice2Statics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ISmsDevice2Statics : ISmsDevice2Statics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISmsDevice2Statics));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsDevice2Statics*, Guid*, void**, int>)(lpVtbl[0]))((ISmsDevice2Statics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsDevice2Statics*, uint>)(lpVtbl[1]))((ISmsDevice2Statics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsDevice2Statics*, uint>)(lpVtbl[2]))((ISmsDevice2Statics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsDevice2Statics*, uint*, Guid**, int>)(lpVtbl[3]))((ISmsDevice2Statics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsDevice2Statics*, HSTRING*, int>)(lpVtbl[4]))((ISmsDevice2Statics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsDevice2Statics*, TrustLevel*, int>)(lpVtbl[5]))((ISmsDevice2Statics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ISmsDevice2Statics.xml' path='doc/member[@name="ISmsDevice2Statics.GetDeviceSelector"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetDeviceSelector(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsDevice2Statics*, HSTRING*, int>)(lpVtbl[6]))((ISmsDevice2Statics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmsDevice2Statics.xml' path='doc/member[@name="ISmsDevice2Statics.FromId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT FromId(HSTRING deviceId, [NativeTypeName("ABI::Windows::Devices::Sms::ISmsDevice2 **")] ISmsDevice2** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsDevice2Statics*, HSTRING, ISmsDevice2**, int>)(lpVtbl[7]))((ISmsDevice2Statics*)Unsafe.AsPointer(ref this), deviceId, value);
    }

    /// <include file='ISmsDevice2Statics.xml' path='doc/member[@name="ISmsDevice2Statics.GetDefault"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetDefault([NativeTypeName("ABI::Windows::Devices::Sms::ISmsDevice2 **")] ISmsDevice2** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsDevice2Statics*, ISmsDevice2**, int>)(lpVtbl[8]))((ISmsDevice2Statics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmsDevice2Statics.xml' path='doc/member[@name="ISmsDevice2Statics.FromParentId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT FromParentId(HSTRING parentDeviceId, [NativeTypeName("ABI::Windows::Devices::Sms::ISmsDevice2 **")] ISmsDevice2** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsDevice2Statics*, HSTRING, ISmsDevice2**, int>)(lpVtbl[9]))((ISmsDevice2Statics*)Unsafe.AsPointer(ref this), parentDeviceId, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT GetDeviceSelector(HSTRING* value);

        [VtblIndex(7)]
        HRESULT FromId(HSTRING deviceId, [NativeTypeName("ABI::Windows::Devices::Sms::ISmsDevice2 **")] ISmsDevice2** value);

        [VtblIndex(8)]
        HRESULT GetDefault([NativeTypeName("ABI::Windows::Devices::Sms::ISmsDevice2 **")] ISmsDevice2** value);

        [VtblIndex(9)]
        HRESULT FromParentId(HSTRING parentDeviceId, [NativeTypeName("ABI::Windows::Devices::Sms::ISmsDevice2 **")] ISmsDevice2** value);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> GetDeviceSelector;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Devices::Sms::ISmsDevice2 **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, ISmsDevice2**, int> FromId;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Sms::ISmsDevice2 **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ISmsDevice2**, int> GetDefault;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Devices::Sms::ISmsDevice2 **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, ISmsDevice2**, int> FromParentId;
    }
}
