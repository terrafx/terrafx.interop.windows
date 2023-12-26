// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.bluetooth.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IBluetoothLEAppearanceSubcategoriesStatics.xml' path='doc/member[@name="IBluetoothLEAppearanceSubcategoriesStatics"]/*' />
[Guid("E57BA606-2144-415A-8312-71CCF291F8D1")]
[NativeTypeName("struct IBluetoothLEAppearanceSubcategoriesStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IBluetoothLEAppearanceSubcategoriesStatics : IBluetoothLEAppearanceSubcategoriesStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IBluetoothLEAppearanceSubcategoriesStatics));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAppearanceSubcategoriesStatics*, Guid*, void**, int>)(lpVtbl[0]))((IBluetoothLEAppearanceSubcategoriesStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAppearanceSubcategoriesStatics*, uint>)(lpVtbl[1]))((IBluetoothLEAppearanceSubcategoriesStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAppearanceSubcategoriesStatics*, uint>)(lpVtbl[2]))((IBluetoothLEAppearanceSubcategoriesStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAppearanceSubcategoriesStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IBluetoothLEAppearanceSubcategoriesStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAppearanceSubcategoriesStatics*, HSTRING*, int>)(lpVtbl[4]))((IBluetoothLEAppearanceSubcategoriesStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAppearanceSubcategoriesStatics*, TrustLevel*, int>)(lpVtbl[5]))((IBluetoothLEAppearanceSubcategoriesStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IBluetoothLEAppearanceSubcategoriesStatics.xml' path='doc/member[@name="IBluetoothLEAppearanceSubcategoriesStatics.get_Generic"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Generic([NativeTypeName("UINT16 *")] ushort* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAppearanceSubcategoriesStatics*, ushort*, int>)(lpVtbl[6]))((IBluetoothLEAppearanceSubcategoriesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBluetoothLEAppearanceSubcategoriesStatics.xml' path='doc/member[@name="IBluetoothLEAppearanceSubcategoriesStatics.get_SportsWatch"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_SportsWatch([NativeTypeName("UINT16 *")] ushort* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAppearanceSubcategoriesStatics*, ushort*, int>)(lpVtbl[7]))((IBluetoothLEAppearanceSubcategoriesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBluetoothLEAppearanceSubcategoriesStatics.xml' path='doc/member[@name="IBluetoothLEAppearanceSubcategoriesStatics.get_ThermometerEar"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_ThermometerEar([NativeTypeName("UINT16 *")] ushort* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAppearanceSubcategoriesStatics*, ushort*, int>)(lpVtbl[8]))((IBluetoothLEAppearanceSubcategoriesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBluetoothLEAppearanceSubcategoriesStatics.xml' path='doc/member[@name="IBluetoothLEAppearanceSubcategoriesStatics.get_HeartRateBelt"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_HeartRateBelt([NativeTypeName("UINT16 *")] ushort* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAppearanceSubcategoriesStatics*, ushort*, int>)(lpVtbl[9]))((IBluetoothLEAppearanceSubcategoriesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBluetoothLEAppearanceSubcategoriesStatics.xml' path='doc/member[@name="IBluetoothLEAppearanceSubcategoriesStatics.get_BloodPressureArm"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_BloodPressureArm([NativeTypeName("UINT16 *")] ushort* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAppearanceSubcategoriesStatics*, ushort*, int>)(lpVtbl[10]))((IBluetoothLEAppearanceSubcategoriesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBluetoothLEAppearanceSubcategoriesStatics.xml' path='doc/member[@name="IBluetoothLEAppearanceSubcategoriesStatics.get_BloodPressureWrist"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_BloodPressureWrist([NativeTypeName("UINT16 *")] ushort* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAppearanceSubcategoriesStatics*, ushort*, int>)(lpVtbl[11]))((IBluetoothLEAppearanceSubcategoriesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBluetoothLEAppearanceSubcategoriesStatics.xml' path='doc/member[@name="IBluetoothLEAppearanceSubcategoriesStatics.get_Keyboard"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_Keyboard([NativeTypeName("UINT16 *")] ushort* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAppearanceSubcategoriesStatics*, ushort*, int>)(lpVtbl[12]))((IBluetoothLEAppearanceSubcategoriesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBluetoothLEAppearanceSubcategoriesStatics.xml' path='doc/member[@name="IBluetoothLEAppearanceSubcategoriesStatics.get_Mouse"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_Mouse([NativeTypeName("UINT16 *")] ushort* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAppearanceSubcategoriesStatics*, ushort*, int>)(lpVtbl[13]))((IBluetoothLEAppearanceSubcategoriesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBluetoothLEAppearanceSubcategoriesStatics.xml' path='doc/member[@name="IBluetoothLEAppearanceSubcategoriesStatics.get_Joystick"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_Joystick([NativeTypeName("UINT16 *")] ushort* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAppearanceSubcategoriesStatics*, ushort*, int>)(lpVtbl[14]))((IBluetoothLEAppearanceSubcategoriesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBluetoothLEAppearanceSubcategoriesStatics.xml' path='doc/member[@name="IBluetoothLEAppearanceSubcategoriesStatics.get_Gamepad"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_Gamepad([NativeTypeName("UINT16 *")] ushort* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAppearanceSubcategoriesStatics*, ushort*, int>)(lpVtbl[15]))((IBluetoothLEAppearanceSubcategoriesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBluetoothLEAppearanceSubcategoriesStatics.xml' path='doc/member[@name="IBluetoothLEAppearanceSubcategoriesStatics.get_DigitizerTablet"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_DigitizerTablet([NativeTypeName("UINT16 *")] ushort* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAppearanceSubcategoriesStatics*, ushort*, int>)(lpVtbl[16]))((IBluetoothLEAppearanceSubcategoriesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBluetoothLEAppearanceSubcategoriesStatics.xml' path='doc/member[@name="IBluetoothLEAppearanceSubcategoriesStatics.get_CardReader"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_CardReader([NativeTypeName("UINT16 *")] ushort* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAppearanceSubcategoriesStatics*, ushort*, int>)(lpVtbl[17]))((IBluetoothLEAppearanceSubcategoriesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBluetoothLEAppearanceSubcategoriesStatics.xml' path='doc/member[@name="IBluetoothLEAppearanceSubcategoriesStatics.get_DigitalPen"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_DigitalPen([NativeTypeName("UINT16 *")] ushort* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAppearanceSubcategoriesStatics*, ushort*, int>)(lpVtbl[18]))((IBluetoothLEAppearanceSubcategoriesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBluetoothLEAppearanceSubcategoriesStatics.xml' path='doc/member[@name="IBluetoothLEAppearanceSubcategoriesStatics.get_BarcodeScanner"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT get_BarcodeScanner([NativeTypeName("UINT16 *")] ushort* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAppearanceSubcategoriesStatics*, ushort*, int>)(lpVtbl[19]))((IBluetoothLEAppearanceSubcategoriesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBluetoothLEAppearanceSubcategoriesStatics.xml' path='doc/member[@name="IBluetoothLEAppearanceSubcategoriesStatics.get_RunningWalkingInShoe"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT get_RunningWalkingInShoe([NativeTypeName("UINT16 *")] ushort* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAppearanceSubcategoriesStatics*, ushort*, int>)(lpVtbl[20]))((IBluetoothLEAppearanceSubcategoriesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBluetoothLEAppearanceSubcategoriesStatics.xml' path='doc/member[@name="IBluetoothLEAppearanceSubcategoriesStatics.get_RunningWalkingOnShoe"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT get_RunningWalkingOnShoe([NativeTypeName("UINT16 *")] ushort* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAppearanceSubcategoriesStatics*, ushort*, int>)(lpVtbl[21]))((IBluetoothLEAppearanceSubcategoriesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBluetoothLEAppearanceSubcategoriesStatics.xml' path='doc/member[@name="IBluetoothLEAppearanceSubcategoriesStatics.get_RunningWalkingOnHip"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT get_RunningWalkingOnHip([NativeTypeName("UINT16 *")] ushort* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAppearanceSubcategoriesStatics*, ushort*, int>)(lpVtbl[22]))((IBluetoothLEAppearanceSubcategoriesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBluetoothLEAppearanceSubcategoriesStatics.xml' path='doc/member[@name="IBluetoothLEAppearanceSubcategoriesStatics.get_CyclingComputer"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT get_CyclingComputer([NativeTypeName("UINT16 *")] ushort* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAppearanceSubcategoriesStatics*, ushort*, int>)(lpVtbl[23]))((IBluetoothLEAppearanceSubcategoriesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBluetoothLEAppearanceSubcategoriesStatics.xml' path='doc/member[@name="IBluetoothLEAppearanceSubcategoriesStatics.get_CyclingSpeedSensor"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT get_CyclingSpeedSensor([NativeTypeName("UINT16 *")] ushort* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAppearanceSubcategoriesStatics*, ushort*, int>)(lpVtbl[24]))((IBluetoothLEAppearanceSubcategoriesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBluetoothLEAppearanceSubcategoriesStatics.xml' path='doc/member[@name="IBluetoothLEAppearanceSubcategoriesStatics.get_CyclingCadenceSensor"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT get_CyclingCadenceSensor([NativeTypeName("UINT16 *")] ushort* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAppearanceSubcategoriesStatics*, ushort*, int>)(lpVtbl[25]))((IBluetoothLEAppearanceSubcategoriesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBluetoothLEAppearanceSubcategoriesStatics.xml' path='doc/member[@name="IBluetoothLEAppearanceSubcategoriesStatics.get_CyclingPowerSensor"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT get_CyclingPowerSensor([NativeTypeName("UINT16 *")] ushort* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAppearanceSubcategoriesStatics*, ushort*, int>)(lpVtbl[26]))((IBluetoothLEAppearanceSubcategoriesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBluetoothLEAppearanceSubcategoriesStatics.xml' path='doc/member[@name="IBluetoothLEAppearanceSubcategoriesStatics.get_CyclingSpeedCadenceSensor"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT get_CyclingSpeedCadenceSensor([NativeTypeName("UINT16 *")] ushort* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAppearanceSubcategoriesStatics*, ushort*, int>)(lpVtbl[27]))((IBluetoothLEAppearanceSubcategoriesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBluetoothLEAppearanceSubcategoriesStatics.xml' path='doc/member[@name="IBluetoothLEAppearanceSubcategoriesStatics.get_OximeterFingertip"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT get_OximeterFingertip([NativeTypeName("UINT16 *")] ushort* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAppearanceSubcategoriesStatics*, ushort*, int>)(lpVtbl[28]))((IBluetoothLEAppearanceSubcategoriesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBluetoothLEAppearanceSubcategoriesStatics.xml' path='doc/member[@name="IBluetoothLEAppearanceSubcategoriesStatics.get_OximeterWristWorn"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT get_OximeterWristWorn([NativeTypeName("UINT16 *")] ushort* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAppearanceSubcategoriesStatics*, ushort*, int>)(lpVtbl[29]))((IBluetoothLEAppearanceSubcategoriesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBluetoothLEAppearanceSubcategoriesStatics.xml' path='doc/member[@name="IBluetoothLEAppearanceSubcategoriesStatics.get_LocationDisplay"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT get_LocationDisplay([NativeTypeName("UINT16 *")] ushort* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAppearanceSubcategoriesStatics*, ushort*, int>)(lpVtbl[30]))((IBluetoothLEAppearanceSubcategoriesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBluetoothLEAppearanceSubcategoriesStatics.xml' path='doc/member[@name="IBluetoothLEAppearanceSubcategoriesStatics.get_LocationNavigationDisplay"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT get_LocationNavigationDisplay([NativeTypeName("UINT16 *")] ushort* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAppearanceSubcategoriesStatics*, ushort*, int>)(lpVtbl[31]))((IBluetoothLEAppearanceSubcategoriesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBluetoothLEAppearanceSubcategoriesStatics.xml' path='doc/member[@name="IBluetoothLEAppearanceSubcategoriesStatics.get_LocationPod"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public HRESULT get_LocationPod([NativeTypeName("UINT16 *")] ushort* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAppearanceSubcategoriesStatics*, ushort*, int>)(lpVtbl[32]))((IBluetoothLEAppearanceSubcategoriesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBluetoothLEAppearanceSubcategoriesStatics.xml' path='doc/member[@name="IBluetoothLEAppearanceSubcategoriesStatics.get_LocationNavigationPod"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    public HRESULT get_LocationNavigationPod([NativeTypeName("UINT16 *")] ushort* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAppearanceSubcategoriesStatics*, ushort*, int>)(lpVtbl[33]))((IBluetoothLEAppearanceSubcategoriesStatics*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Generic([NativeTypeName("UINT16 *")] ushort* value);

        [VtblIndex(7)]
        HRESULT get_SportsWatch([NativeTypeName("UINT16 *")] ushort* value);

        [VtblIndex(8)]
        HRESULT get_ThermometerEar([NativeTypeName("UINT16 *")] ushort* value);

        [VtblIndex(9)]
        HRESULT get_HeartRateBelt([NativeTypeName("UINT16 *")] ushort* value);

        [VtblIndex(10)]
        HRESULT get_BloodPressureArm([NativeTypeName("UINT16 *")] ushort* value);

        [VtblIndex(11)]
        HRESULT get_BloodPressureWrist([NativeTypeName("UINT16 *")] ushort* value);

        [VtblIndex(12)]
        HRESULT get_Keyboard([NativeTypeName("UINT16 *")] ushort* value);

        [VtblIndex(13)]
        HRESULT get_Mouse([NativeTypeName("UINT16 *")] ushort* value);

        [VtblIndex(14)]
        HRESULT get_Joystick([NativeTypeName("UINT16 *")] ushort* value);

        [VtblIndex(15)]
        HRESULT get_Gamepad([NativeTypeName("UINT16 *")] ushort* value);

        [VtblIndex(16)]
        HRESULT get_DigitizerTablet([NativeTypeName("UINT16 *")] ushort* value);

        [VtblIndex(17)]
        HRESULT get_CardReader([NativeTypeName("UINT16 *")] ushort* value);

        [VtblIndex(18)]
        HRESULT get_DigitalPen([NativeTypeName("UINT16 *")] ushort* value);

        [VtblIndex(19)]
        HRESULT get_BarcodeScanner([NativeTypeName("UINT16 *")] ushort* value);

        [VtblIndex(20)]
        HRESULT get_RunningWalkingInShoe([NativeTypeName("UINT16 *")] ushort* value);

        [VtblIndex(21)]
        HRESULT get_RunningWalkingOnShoe([NativeTypeName("UINT16 *")] ushort* value);

        [VtblIndex(22)]
        HRESULT get_RunningWalkingOnHip([NativeTypeName("UINT16 *")] ushort* value);

        [VtblIndex(23)]
        HRESULT get_CyclingComputer([NativeTypeName("UINT16 *")] ushort* value);

        [VtblIndex(24)]
        HRESULT get_CyclingSpeedSensor([NativeTypeName("UINT16 *")] ushort* value);

        [VtblIndex(25)]
        HRESULT get_CyclingCadenceSensor([NativeTypeName("UINT16 *")] ushort* value);

        [VtblIndex(26)]
        HRESULT get_CyclingPowerSensor([NativeTypeName("UINT16 *")] ushort* value);

        [VtblIndex(27)]
        HRESULT get_CyclingSpeedCadenceSensor([NativeTypeName("UINT16 *")] ushort* value);

        [VtblIndex(28)]
        HRESULT get_OximeterFingertip([NativeTypeName("UINT16 *")] ushort* value);

        [VtblIndex(29)]
        HRESULT get_OximeterWristWorn([NativeTypeName("UINT16 *")] ushort* value);

        [VtblIndex(30)]
        HRESULT get_LocationDisplay([NativeTypeName("UINT16 *")] ushort* value);

        [VtblIndex(31)]
        HRESULT get_LocationNavigationDisplay([NativeTypeName("UINT16 *")] ushort* value);

        [VtblIndex(32)]
        HRESULT get_LocationPod([NativeTypeName("UINT16 *")] ushort* value);

        [VtblIndex(33)]
        HRESULT get_LocationNavigationPod([NativeTypeName("UINT16 *")] ushort* value);
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

        [NativeTypeName("HRESULT (UINT16 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ushort*, int> get_Generic;

        [NativeTypeName("HRESULT (UINT16 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ushort*, int> get_SportsWatch;

        [NativeTypeName("HRESULT (UINT16 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ushort*, int> get_ThermometerEar;

        [NativeTypeName("HRESULT (UINT16 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ushort*, int> get_HeartRateBelt;

        [NativeTypeName("HRESULT (UINT16 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ushort*, int> get_BloodPressureArm;

        [NativeTypeName("HRESULT (UINT16 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ushort*, int> get_BloodPressureWrist;

        [NativeTypeName("HRESULT (UINT16 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ushort*, int> get_Keyboard;

        [NativeTypeName("HRESULT (UINT16 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ushort*, int> get_Mouse;

        [NativeTypeName("HRESULT (UINT16 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ushort*, int> get_Joystick;

        [NativeTypeName("HRESULT (UINT16 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ushort*, int> get_Gamepad;

        [NativeTypeName("HRESULT (UINT16 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ushort*, int> get_DigitizerTablet;

        [NativeTypeName("HRESULT (UINT16 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ushort*, int> get_CardReader;

        [NativeTypeName("HRESULT (UINT16 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ushort*, int> get_DigitalPen;

        [NativeTypeName("HRESULT (UINT16 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ushort*, int> get_BarcodeScanner;

        [NativeTypeName("HRESULT (UINT16 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ushort*, int> get_RunningWalkingInShoe;

        [NativeTypeName("HRESULT (UINT16 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ushort*, int> get_RunningWalkingOnShoe;

        [NativeTypeName("HRESULT (UINT16 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ushort*, int> get_RunningWalkingOnHip;

        [NativeTypeName("HRESULT (UINT16 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ushort*, int> get_CyclingComputer;

        [NativeTypeName("HRESULT (UINT16 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ushort*, int> get_CyclingSpeedSensor;

        [NativeTypeName("HRESULT (UINT16 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ushort*, int> get_CyclingCadenceSensor;

        [NativeTypeName("HRESULT (UINT16 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ushort*, int> get_CyclingPowerSensor;

        [NativeTypeName("HRESULT (UINT16 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ushort*, int> get_CyclingSpeedCadenceSensor;

        [NativeTypeName("HRESULT (UINT16 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ushort*, int> get_OximeterFingertip;

        [NativeTypeName("HRESULT (UINT16 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ushort*, int> get_OximeterWristWorn;

        [NativeTypeName("HRESULT (UINT16 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ushort*, int> get_LocationDisplay;

        [NativeTypeName("HRESULT (UINT16 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ushort*, int> get_LocationNavigationDisplay;

        [NativeTypeName("HRESULT (UINT16 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ushort*, int> get_LocationPod;

        [NativeTypeName("HRESULT (UINT16 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ushort*, int> get_LocationNavigationPod;
    }
}
