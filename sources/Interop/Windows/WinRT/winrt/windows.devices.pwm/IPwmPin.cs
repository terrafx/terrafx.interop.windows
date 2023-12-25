// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.pwm.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IPwmPin.xml' path='doc/member[@name="IPwmPin"]/*' />
[Guid("22972DC8-C6CF-4821-B7F9-C6454FB6AF79")]
[NativeTypeName("struct IPwmPin : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IPwmPin : IPwmPin.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPwmPin));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IPwmPin*, Guid*, void**, int>)(lpVtbl[0]))((IPwmPin*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IPwmPin*, uint>)(lpVtbl[1]))((IPwmPin*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IPwmPin*, uint>)(lpVtbl[2]))((IPwmPin*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IPwmPin*, uint*, Guid**, int>)(lpVtbl[3]))((IPwmPin*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IPwmPin*, HSTRING*, int>)(lpVtbl[4]))((IPwmPin*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IPwmPin*, TrustLevel*, int>)(lpVtbl[5]))((IPwmPin*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IPwmPin.xml' path='doc/member[@name="IPwmPin.get_Controller"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Controller([NativeTypeName("ABI::Windows::Devices::Pwm::IPwmController **")] IPwmController** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPwmPin*, IPwmController**, int>)(lpVtbl[6]))((IPwmPin*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPwmPin.xml' path='doc/member[@name="IPwmPin.GetActiveDutyCyclePercentage"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetActiveDutyCyclePercentage(double* result)
    {
        return ((delegate* unmanaged[MemberFunction]<IPwmPin*, double*, int>)(lpVtbl[7]))((IPwmPin*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='IPwmPin.xml' path='doc/member[@name="IPwmPin.SetActiveDutyCyclePercentage"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SetActiveDutyCyclePercentage(double dutyCyclePercentage)
    {
        return ((delegate* unmanaged[MemberFunction]<IPwmPin*, double, int>)(lpVtbl[8]))((IPwmPin*)Unsafe.AsPointer(ref this), dutyCyclePercentage);
    }

    /// <include file='IPwmPin.xml' path='doc/member[@name="IPwmPin.get_Polarity"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_Polarity([NativeTypeName("ABI::Windows::Devices::Pwm::PwmPulsePolarity *")] PwmPulsePolarity* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPwmPin*, PwmPulsePolarity*, int>)(lpVtbl[9]))((IPwmPin*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPwmPin.xml' path='doc/member[@name="IPwmPin.put_Polarity"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT put_Polarity([NativeTypeName("ABI::Windows::Devices::Pwm::PwmPulsePolarity")] PwmPulsePolarity value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPwmPin*, PwmPulsePolarity, int>)(lpVtbl[10]))((IPwmPin*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPwmPin.xml' path='doc/member[@name="IPwmPin.Start"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT Start()
    {
        return ((delegate* unmanaged[MemberFunction]<IPwmPin*, int>)(lpVtbl[11]))((IPwmPin*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IPwmPin.xml' path='doc/member[@name="IPwmPin.Stop"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT Stop()
    {
        return ((delegate* unmanaged[MemberFunction]<IPwmPin*, int>)(lpVtbl[12]))((IPwmPin*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IPwmPin.xml' path='doc/member[@name="IPwmPin.get_IsStarted"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_IsStarted([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPwmPin*, byte*, int>)(lpVtbl[13]))((IPwmPin*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Controller([NativeTypeName("ABI::Windows::Devices::Pwm::IPwmController **")] IPwmController** value);

        [VtblIndex(7)]
        HRESULT GetActiveDutyCyclePercentage(double* result);

        [VtblIndex(8)]
        HRESULT SetActiveDutyCyclePercentage(double dutyCyclePercentage);

        [VtblIndex(9)]
        HRESULT get_Polarity([NativeTypeName("ABI::Windows::Devices::Pwm::PwmPulsePolarity *")] PwmPulsePolarity* value);

        [VtblIndex(10)]
        HRESULT put_Polarity([NativeTypeName("ABI::Windows::Devices::Pwm::PwmPulsePolarity")] PwmPulsePolarity value);

        [VtblIndex(11)]
        HRESULT Start();

        [VtblIndex(12)]
        HRESULT Stop();

        [VtblIndex(13)]
        HRESULT get_IsStarted([NativeTypeName("boolean *")] byte* value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Pwm::IPwmController **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IPwmController**, int> get_Controller;

        [NativeTypeName("HRESULT (DOUBLE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, double*, int> GetActiveDutyCyclePercentage;

        [NativeTypeName("HRESULT (DOUBLE) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, double, int> SetActiveDutyCyclePercentage;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Pwm::PwmPulsePolarity *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, PwmPulsePolarity*, int> get_Polarity;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Pwm::PwmPulsePolarity) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, PwmPulsePolarity, int> put_Polarity;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> Start;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> Stop;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsStarted;
    }
}
