// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.pwm.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IPwmController.xml' path='doc/member[@name="IPwmController"]/*' />
[Guid("C45F5C85-D2E8-42CF-9BD6-CF5ED029E6A7")]
[NativeTypeName("struct IPwmController : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IPwmController : IPwmController.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IPwmController);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IPwmController*, Guid*, void**, int>)(lpVtbl[0]))((IPwmController*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IPwmController*, uint>)(lpVtbl[1]))((IPwmController*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IPwmController*, uint>)(lpVtbl[2]))((IPwmController*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IPwmController*, uint*, Guid**, int>)(lpVtbl[3]))((IPwmController*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IPwmController*, HSTRING*, int>)(lpVtbl[4]))((IPwmController*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IPwmController*, TrustLevel*, int>)(lpVtbl[5]))((IPwmController*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IPwmController.xml' path='doc/member[@name="IPwmController.get_PinCount"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_PinCount([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPwmController*, int*, int>)(lpVtbl[6]))((IPwmController*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPwmController.xml' path='doc/member[@name="IPwmController.get_ActualFrequency"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_ActualFrequency(double* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPwmController*, double*, int>)(lpVtbl[7]))((IPwmController*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPwmController.xml' path='doc/member[@name="IPwmController.SetDesiredFrequency"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SetDesiredFrequency(double desiredFrequency, double* result)
    {
        return ((delegate* unmanaged[MemberFunction]<IPwmController*, double, double*, int>)(lpVtbl[8]))((IPwmController*)Unsafe.AsPointer(ref this), desiredFrequency, result);
    }

    /// <include file='IPwmController.xml' path='doc/member[@name="IPwmController.get_MinFrequency"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_MinFrequency(double* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPwmController*, double*, int>)(lpVtbl[9]))((IPwmController*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPwmController.xml' path='doc/member[@name="IPwmController.get_MaxFrequency"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_MaxFrequency(double* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPwmController*, double*, int>)(lpVtbl[10]))((IPwmController*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPwmController.xml' path='doc/member[@name="IPwmController.OpenPin"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT OpenPin([NativeTypeName("INT32")] int pinNumber, [NativeTypeName("ABI::Windows::Devices::Pwm::IPwmPin **")] IPwmPin** pin)
    {
        return ((delegate* unmanaged[MemberFunction]<IPwmController*, int, IPwmPin**, int>)(lpVtbl[11]))((IPwmController*)Unsafe.AsPointer(ref this), pinNumber, pin);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_PinCount([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(7)]
        HRESULT get_ActualFrequency(double* value);

        [VtblIndex(8)]
        HRESULT SetDesiredFrequency(double desiredFrequency, double* result);

        [VtblIndex(9)]
        HRESULT get_MinFrequency(double* value);

        [VtblIndex(10)]
        HRESULT get_MaxFrequency(double* value);

        [VtblIndex(11)]
        HRESULT OpenPin([NativeTypeName("INT32")] int pinNumber, [NativeTypeName("ABI::Windows::Devices::Pwm::IPwmPin **")] IPwmPin** pin);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, double*, int> get_MinFrequency;

        [NativeTypeName("HRESULT (DOUBLE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, double*, int> get_MaxFrequency;

        [NativeTypeName("HRESULT (INT32, ABI::Windows::Devices::Pwm::IPwmPin **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int, IPwmPin**, int> OpenPin;
    }
}
