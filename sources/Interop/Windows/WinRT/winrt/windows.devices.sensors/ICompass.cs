// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.sensors.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ICompass.xml' path='doc/member[@name="ICompass"]/*' />
[Guid("292FFA94-1B45-403C-BA06-B106DBA69A64")]
[NativeTypeName("struct ICompass : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICompass : ICompass.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICompass));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompass*, Guid*, void**, int>)(lpVtbl[0]))((ICompass*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ICompass*, uint>)(lpVtbl[1]))((ICompass*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ICompass*, uint>)(lpVtbl[2]))((ICompass*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompass*, uint*, Guid**, int>)(lpVtbl[3]))((ICompass*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompass*, HSTRING*, int>)(lpVtbl[4]))((ICompass*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompass*, TrustLevel*, int>)(lpVtbl[5]))((ICompass*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ICompass.xml' path='doc/member[@name="ICompass.GetCurrentReading"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetCurrentReading([NativeTypeName("ABI::Windows::Devices::Sensors::ICompassReading **")] ICompassReading** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompass*, ICompassReading**, int>)(lpVtbl[6]))((ICompass*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICompass.xml' path='doc/member[@name="ICompass.get_MinimumReportInterval"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_MinimumReportInterval([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompass*, uint*, int>)(lpVtbl[7]))((ICompass*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICompass.xml' path='doc/member[@name="ICompass.put_ReportInterval"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT put_ReportInterval([NativeTypeName("UINT32")] uint value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompass*, uint, int>)(lpVtbl[8]))((ICompass*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICompass.xml' path='doc/member[@name="ICompass.get_ReportInterval"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_ReportInterval([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompass*, uint*, int>)(lpVtbl[9]))((ICompass*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICompass.xml' path='doc/member[@name="ICompass.add_ReadingChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT add_ReadingChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CSensors__CCompass_Windows__CDevices__CSensors__CCompassReadingChangedEventArgs_t *")] ITypedEventHandler<Pointer<ICompass>, Pointer<ICompassReadingChangedEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompass*, ITypedEventHandler<Pointer<ICompass>, Pointer<ICompassReadingChangedEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[10]))((ICompass*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='ICompass.xml' path='doc/member[@name="ICompass.remove_ReadingChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT remove_ReadingChanged(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompass*, EventRegistrationToken, int>)(lpVtbl[11]))((ICompass*)Unsafe.AsPointer(ref this), token);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT GetCurrentReading([NativeTypeName("ABI::Windows::Devices::Sensors::ICompassReading **")] ICompassReading** value);

        [VtblIndex(7)]
        HRESULT get_MinimumReportInterval([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(8)]
        HRESULT put_ReportInterval([NativeTypeName("UINT32")] uint value);

        [VtblIndex(9)]
        HRESULT get_ReportInterval([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(10)]
        HRESULT add_ReadingChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CSensors__CCompass_Windows__CDevices__CSensors__CCompassReadingChangedEventArgs_t *")] ITypedEventHandler<Pointer<ICompass>, Pointer<ICompassReadingChangedEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(11)]
        HRESULT remove_ReadingChanged(EventRegistrationToken token);
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

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Sensors::ICompassReading **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ICompassReading**, int> GetCurrentReading;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_MinimumReportInterval;

        [NativeTypeName("HRESULT (UINT32) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, int> put_ReportInterval;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_ReportInterval;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CSensors__CCompass_Windows__CDevices__CSensors__CCompassReadingChangedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<ICompass>, Pointer<ICompassReadingChangedEventArgs>>*, EventRegistrationToken*, int> add_ReadingChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_ReadingChanged;
    }
}
