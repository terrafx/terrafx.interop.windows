// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.gpio.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IGpioChangeCounter.xml' path='doc/member[@name="IGpioChangeCounter"]/*' />
[Guid("CB5EC0DE-6801-43FF-803D-4576628A8B26")]
[NativeTypeName("struct IGpioChangeCounter : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IGpioChangeCounter : IGpioChangeCounter.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IGpioChangeCounter));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IGpioChangeCounter*, Guid*, void**, int>)(lpVtbl[0]))((IGpioChangeCounter*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IGpioChangeCounter*, uint>)(lpVtbl[1]))((IGpioChangeCounter*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IGpioChangeCounter*, uint>)(lpVtbl[2]))((IGpioChangeCounter*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IGpioChangeCounter*, uint*, Guid**, int>)(lpVtbl[3]))((IGpioChangeCounter*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IGpioChangeCounter*, HSTRING*, int>)(lpVtbl[4]))((IGpioChangeCounter*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IGpioChangeCounter*, TrustLevel*, int>)(lpVtbl[5]))((IGpioChangeCounter*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IGpioChangeCounter.xml' path='doc/member[@name="IGpioChangeCounter.put_Polarity"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT put_Polarity([NativeTypeName("ABI::Windows::Devices::Gpio::GpioChangePolarity")] GpioChangePolarity value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGpioChangeCounter*, GpioChangePolarity, int>)(lpVtbl[6]))((IGpioChangeCounter*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGpioChangeCounter.xml' path='doc/member[@name="IGpioChangeCounter.get_Polarity"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Polarity([NativeTypeName("ABI::Windows::Devices::Gpio::GpioChangePolarity *")] GpioChangePolarity* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGpioChangeCounter*, GpioChangePolarity*, int>)(lpVtbl[7]))((IGpioChangeCounter*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGpioChangeCounter.xml' path='doc/member[@name="IGpioChangeCounter.get_IsStarted"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_IsStarted([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGpioChangeCounter*, byte*, int>)(lpVtbl[8]))((IGpioChangeCounter*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGpioChangeCounter.xml' path='doc/member[@name="IGpioChangeCounter.Start"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT Start()
    {
        return ((delegate* unmanaged[MemberFunction]<IGpioChangeCounter*, int>)(lpVtbl[9]))((IGpioChangeCounter*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IGpioChangeCounter.xml' path='doc/member[@name="IGpioChangeCounter.Stop"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT Stop()
    {
        return ((delegate* unmanaged[MemberFunction]<IGpioChangeCounter*, int>)(lpVtbl[10]))((IGpioChangeCounter*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IGpioChangeCounter.xml' path='doc/member[@name="IGpioChangeCounter.Read"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT Read([NativeTypeName("ABI::Windows::Devices::Gpio::GpioChangeCount *")] GpioChangeCount* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGpioChangeCounter*, GpioChangeCount*, int>)(lpVtbl[11]))((IGpioChangeCounter*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGpioChangeCounter.xml' path='doc/member[@name="IGpioChangeCounter.Reset"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT Reset([NativeTypeName("ABI::Windows::Devices::Gpio::GpioChangeCount *")] GpioChangeCount* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGpioChangeCounter*, GpioChangeCount*, int>)(lpVtbl[12]))((IGpioChangeCounter*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT put_Polarity([NativeTypeName("ABI::Windows::Devices::Gpio::GpioChangePolarity")] GpioChangePolarity value);

        [VtblIndex(7)]
        HRESULT get_Polarity([NativeTypeName("ABI::Windows::Devices::Gpio::GpioChangePolarity *")] GpioChangePolarity* value);

        [VtblIndex(8)]
        HRESULT get_IsStarted([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(9)]
        HRESULT Start();

        [VtblIndex(10)]
        HRESULT Stop();

        [VtblIndex(11)]
        HRESULT Read([NativeTypeName("ABI::Windows::Devices::Gpio::GpioChangeCount *")] GpioChangeCount* value);

        [VtblIndex(12)]
        HRESULT Reset([NativeTypeName("ABI::Windows::Devices::Gpio::GpioChangeCount *")] GpioChangeCount* value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Gpio::GpioChangePolarity) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, GpioChangePolarity, int> put_Polarity;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Gpio::GpioChangePolarity *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, GpioChangePolarity*, int> get_Polarity;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsStarted;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> Start;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> Stop;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Gpio::GpioChangeCount *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, GpioChangeCount*, int> Read;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Gpio::GpioChangeCount *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, GpioChangeCount*, int> Reset;
    }
}
