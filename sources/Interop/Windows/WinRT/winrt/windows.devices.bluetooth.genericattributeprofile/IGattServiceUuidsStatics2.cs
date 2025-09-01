// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.bluetooth.genericattributeprofile.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IGattServiceUuidsStatics2.xml' path='doc/member[@name="IGattServiceUuidsStatics2"]/*' />
[Guid("D2AE94F5-3D15-4F79-9C0C-EAAFA675155C")]
[NativeTypeName("struct IGattServiceUuidsStatics2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IGattServiceUuidsStatics2 : IGattServiceUuidsStatics2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IGattServiceUuidsStatics2);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattServiceUuidsStatics2*, Guid*, void**, int>)(lpVtbl[0]))((IGattServiceUuidsStatics2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IGattServiceUuidsStatics2*, uint>)(lpVtbl[1]))((IGattServiceUuidsStatics2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IGattServiceUuidsStatics2*, uint>)(lpVtbl[2]))((IGattServiceUuidsStatics2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattServiceUuidsStatics2*, uint*, Guid**, int>)(lpVtbl[3]))((IGattServiceUuidsStatics2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattServiceUuidsStatics2*, HSTRING*, int>)(lpVtbl[4]))((IGattServiceUuidsStatics2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattServiceUuidsStatics2*, TrustLevel*, int>)(lpVtbl[5]))((IGattServiceUuidsStatics2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IGattServiceUuidsStatics2.xml' path='doc/member[@name="IGattServiceUuidsStatics2.get_AlertNotification"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_AlertNotification(Guid* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattServiceUuidsStatics2*, Guid*, int>)(lpVtbl[6]))((IGattServiceUuidsStatics2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGattServiceUuidsStatics2.xml' path='doc/member[@name="IGattServiceUuidsStatics2.get_CurrentTime"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_CurrentTime(Guid* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattServiceUuidsStatics2*, Guid*, int>)(lpVtbl[7]))((IGattServiceUuidsStatics2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGattServiceUuidsStatics2.xml' path='doc/member[@name="IGattServiceUuidsStatics2.get_CyclingPower"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_CyclingPower(Guid* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattServiceUuidsStatics2*, Guid*, int>)(lpVtbl[8]))((IGattServiceUuidsStatics2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGattServiceUuidsStatics2.xml' path='doc/member[@name="IGattServiceUuidsStatics2.get_DeviceInformation"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_DeviceInformation(Guid* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattServiceUuidsStatics2*, Guid*, int>)(lpVtbl[9]))((IGattServiceUuidsStatics2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGattServiceUuidsStatics2.xml' path='doc/member[@name="IGattServiceUuidsStatics2.get_HumanInterfaceDevice"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_HumanInterfaceDevice(Guid* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattServiceUuidsStatics2*, Guid*, int>)(lpVtbl[10]))((IGattServiceUuidsStatics2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGattServiceUuidsStatics2.xml' path='doc/member[@name="IGattServiceUuidsStatics2.get_ImmediateAlert"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_ImmediateAlert(Guid* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattServiceUuidsStatics2*, Guid*, int>)(lpVtbl[11]))((IGattServiceUuidsStatics2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGattServiceUuidsStatics2.xml' path='doc/member[@name="IGattServiceUuidsStatics2.get_LinkLoss"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_LinkLoss(Guid* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattServiceUuidsStatics2*, Guid*, int>)(lpVtbl[12]))((IGattServiceUuidsStatics2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGattServiceUuidsStatics2.xml' path='doc/member[@name="IGattServiceUuidsStatics2.get_LocationAndNavigation"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_LocationAndNavigation(Guid* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattServiceUuidsStatics2*, Guid*, int>)(lpVtbl[13]))((IGattServiceUuidsStatics2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGattServiceUuidsStatics2.xml' path='doc/member[@name="IGattServiceUuidsStatics2.get_NextDstChange"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_NextDstChange(Guid* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattServiceUuidsStatics2*, Guid*, int>)(lpVtbl[14]))((IGattServiceUuidsStatics2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGattServiceUuidsStatics2.xml' path='doc/member[@name="IGattServiceUuidsStatics2.get_PhoneAlertStatus"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_PhoneAlertStatus(Guid* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattServiceUuidsStatics2*, Guid*, int>)(lpVtbl[15]))((IGattServiceUuidsStatics2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGattServiceUuidsStatics2.xml' path='doc/member[@name="IGattServiceUuidsStatics2.get_ReferenceTimeUpdate"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_ReferenceTimeUpdate(Guid* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattServiceUuidsStatics2*, Guid*, int>)(lpVtbl[16]))((IGattServiceUuidsStatics2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGattServiceUuidsStatics2.xml' path='doc/member[@name="IGattServiceUuidsStatics2.get_ScanParameters"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_ScanParameters(Guid* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattServiceUuidsStatics2*, Guid*, int>)(lpVtbl[17]))((IGattServiceUuidsStatics2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGattServiceUuidsStatics2.xml' path='doc/member[@name="IGattServiceUuidsStatics2.get_TxPower"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_TxPower(Guid* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattServiceUuidsStatics2*, Guid*, int>)(lpVtbl[18]))((IGattServiceUuidsStatics2*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_AlertNotification(Guid* value);

        [VtblIndex(7)]
        HRESULT get_CurrentTime(Guid* value);

        [VtblIndex(8)]
        HRESULT get_CyclingPower(Guid* value);

        [VtblIndex(9)]
        HRESULT get_DeviceInformation(Guid* value);

        [VtblIndex(10)]
        HRESULT get_HumanInterfaceDevice(Guid* value);

        [VtblIndex(11)]
        HRESULT get_ImmediateAlert(Guid* value);

        [VtblIndex(12)]
        HRESULT get_LinkLoss(Guid* value);

        [VtblIndex(13)]
        HRESULT get_LocationAndNavigation(Guid* value);

        [VtblIndex(14)]
        HRESULT get_NextDstChange(Guid* value);

        [VtblIndex(15)]
        HRESULT get_PhoneAlertStatus(Guid* value);

        [VtblIndex(16)]
        HRESULT get_ReferenceTimeUpdate(Guid* value);

        [VtblIndex(17)]
        HRESULT get_ScanParameters(Guid* value);

        [VtblIndex(18)]
        HRESULT get_TxPower(Guid* value);
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

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, int> get_AlertNotification;

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, int> get_CurrentTime;

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, int> get_CyclingPower;

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, int> get_DeviceInformation;

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, int> get_HumanInterfaceDevice;

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, int> get_ImmediateAlert;

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, int> get_LinkLoss;

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, int> get_LocationAndNavigation;

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, int> get_NextDstChange;

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, int> get_PhoneAlertStatus;

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, int> get_ReferenceTimeUpdate;

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, int> get_ScanParameters;

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, int> get_TxPower;
    }
}
