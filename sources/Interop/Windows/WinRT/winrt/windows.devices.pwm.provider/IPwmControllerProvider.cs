// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.pwm.provider.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IPwmControllerProvider.xml' path='doc/member[@name="IPwmControllerProvider"]/*' />
[Guid("1300593B-E2E3-40A4-B7D9-48DFF0377A52")]
[NativeTypeName("struct IPwmControllerProvider : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IPwmControllerProvider : IPwmControllerProvider.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPwmControllerProvider));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IPwmControllerProvider*, Guid*, void**, int>)(lpVtbl[0]))((IPwmControllerProvider*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IPwmControllerProvider*, uint>)(lpVtbl[1]))((IPwmControllerProvider*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IPwmControllerProvider*, uint>)(lpVtbl[2]))((IPwmControllerProvider*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IPwmControllerProvider*, uint*, Guid**, int>)(lpVtbl[3]))((IPwmControllerProvider*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IPwmControllerProvider*, HSTRING*, int>)(lpVtbl[4]))((IPwmControllerProvider*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IPwmControllerProvider*, TrustLevel*, int>)(lpVtbl[5]))((IPwmControllerProvider*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IPwmControllerProvider.xml' path='doc/member[@name="IPwmControllerProvider.get_PinCount"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_PinCount([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPwmControllerProvider*, int*, int>)(lpVtbl[6]))((IPwmControllerProvider*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPwmControllerProvider.xml' path='doc/member[@name="IPwmControllerProvider.get_ActualFrequency"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_ActualFrequency(double* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPwmControllerProvider*, double*, int>)(lpVtbl[7]))((IPwmControllerProvider*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPwmControllerProvider.xml' path='doc/member[@name="IPwmControllerProvider.SetDesiredFrequency"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SetDesiredFrequency(double frequency, double* result)
    {
        return ((delegate* unmanaged[MemberFunction]<IPwmControllerProvider*, double, double*, int>)(lpVtbl[8]))((IPwmControllerProvider*)Unsafe.AsPointer(ref this), frequency, result);
    }

    /// <include file='IPwmControllerProvider.xml' path='doc/member[@name="IPwmControllerProvider.get_MaxFrequency"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_MaxFrequency(double* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPwmControllerProvider*, double*, int>)(lpVtbl[9]))((IPwmControllerProvider*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPwmControllerProvider.xml' path='doc/member[@name="IPwmControllerProvider.get_MinFrequency"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_MinFrequency(double* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPwmControllerProvider*, double*, int>)(lpVtbl[10]))((IPwmControllerProvider*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPwmControllerProvider.xml' path='doc/member[@name="IPwmControllerProvider.AcquirePin"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT AcquirePin([NativeTypeName("INT32")] int pin)
    {
        return ((delegate* unmanaged[MemberFunction]<IPwmControllerProvider*, int, int>)(lpVtbl[11]))((IPwmControllerProvider*)Unsafe.AsPointer(ref this), pin);
    }

    /// <include file='IPwmControllerProvider.xml' path='doc/member[@name="IPwmControllerProvider.ReleasePin"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT ReleasePin([NativeTypeName("INT32")] int pin)
    {
        return ((delegate* unmanaged[MemberFunction]<IPwmControllerProvider*, int, int>)(lpVtbl[12]))((IPwmControllerProvider*)Unsafe.AsPointer(ref this), pin);
    }

    /// <include file='IPwmControllerProvider.xml' path='doc/member[@name="IPwmControllerProvider.EnablePin"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT EnablePin([NativeTypeName("INT32")] int pin)
    {
        return ((delegate* unmanaged[MemberFunction]<IPwmControllerProvider*, int, int>)(lpVtbl[13]))((IPwmControllerProvider*)Unsafe.AsPointer(ref this), pin);
    }

    /// <include file='IPwmControllerProvider.xml' path='doc/member[@name="IPwmControllerProvider.DisablePin"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT DisablePin([NativeTypeName("INT32")] int pin)
    {
        return ((delegate* unmanaged[MemberFunction]<IPwmControllerProvider*, int, int>)(lpVtbl[14]))((IPwmControllerProvider*)Unsafe.AsPointer(ref this), pin);
    }

    /// <include file='IPwmControllerProvider.xml' path='doc/member[@name="IPwmControllerProvider.SetPulseParameters"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT SetPulseParameters([NativeTypeName("INT32")] int pin, double dutyCycle, [NativeTypeName("boolean")] byte invertPolarity)
    {
        return ((delegate* unmanaged[MemberFunction]<IPwmControllerProvider*, int, double, byte, int>)(lpVtbl[15]))((IPwmControllerProvider*)Unsafe.AsPointer(ref this), pin, dutyCycle, invertPolarity);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_PinCount([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(7)]
        HRESULT get_ActualFrequency(double* value);

        [VtblIndex(8)]
        HRESULT SetDesiredFrequency(double frequency, double* result);

        [VtblIndex(9)]
        HRESULT get_MaxFrequency(double* value);

        [VtblIndex(10)]
        HRESULT get_MinFrequency(double* value);

        [VtblIndex(11)]
        HRESULT AcquirePin([NativeTypeName("INT32")] int pin);

        [VtblIndex(12)]
        HRESULT ReleasePin([NativeTypeName("INT32")] int pin);

        [VtblIndex(13)]
        HRESULT EnablePin([NativeTypeName("INT32")] int pin);

        [VtblIndex(14)]
        HRESULT DisablePin([NativeTypeName("INT32")] int pin);

        [VtblIndex(15)]
        HRESULT SetPulseParameters([NativeTypeName("INT32")] int pin, double dutyCycle, [NativeTypeName("boolean")] byte invertPolarity);
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

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> get_PinCount;

        [NativeTypeName("HRESULT (DOUBLE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, double*, int> get_ActualFrequency;

        [NativeTypeName("HRESULT (DOUBLE, DOUBLE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, double, double*, int> SetDesiredFrequency;

        [NativeTypeName("HRESULT (DOUBLE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, double*, int> get_MaxFrequency;

        [NativeTypeName("HRESULT (DOUBLE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, double*, int> get_MinFrequency;

        [NativeTypeName("HRESULT (INT32) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int, int> AcquirePin;

        [NativeTypeName("HRESULT (INT32) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int, int> ReleasePin;

        [NativeTypeName("HRESULT (INT32) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int, int> EnablePin;

        [NativeTypeName("HRESULT (INT32) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int, int> DisablePin;

        [NativeTypeName("HRESULT (INT32, DOUBLE, boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int, double, byte, int> SetPulseParameters;
    }
}
