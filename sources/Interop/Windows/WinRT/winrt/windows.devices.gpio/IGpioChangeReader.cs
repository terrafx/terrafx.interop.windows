// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.gpio.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IGpioChangeReader.xml' path='doc/member[@name="IGpioChangeReader"]/*' />
[Guid("0ABC885F-E031-48E8-8590-70DE78363C6D")]
[NativeTypeName("struct IGpioChangeReader : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IGpioChangeReader : IGpioChangeReader.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IGpioChangeReader));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IGpioChangeReader*, Guid*, void**, int>)(lpVtbl[0]))((IGpioChangeReader*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IGpioChangeReader*, uint>)(lpVtbl[1]))((IGpioChangeReader*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IGpioChangeReader*, uint>)(lpVtbl[2]))((IGpioChangeReader*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IGpioChangeReader*, uint*, Guid**, int>)(lpVtbl[3]))((IGpioChangeReader*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IGpioChangeReader*, HSTRING*, int>)(lpVtbl[4]))((IGpioChangeReader*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IGpioChangeReader*, TrustLevel*, int>)(lpVtbl[5]))((IGpioChangeReader*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IGpioChangeReader.xml' path='doc/member[@name="IGpioChangeReader.get_Capacity"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Capacity([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGpioChangeReader*, int*, int>)(lpVtbl[6]))((IGpioChangeReader*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGpioChangeReader.xml' path='doc/member[@name="IGpioChangeReader.get_Length"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Length([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGpioChangeReader*, int*, int>)(lpVtbl[7]))((IGpioChangeReader*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGpioChangeReader.xml' path='doc/member[@name="IGpioChangeReader.get_IsEmpty"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_IsEmpty([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGpioChangeReader*, byte*, int>)(lpVtbl[8]))((IGpioChangeReader*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGpioChangeReader.xml' path='doc/member[@name="IGpioChangeReader.get_IsOverflowed"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_IsOverflowed([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGpioChangeReader*, byte*, int>)(lpVtbl[9]))((IGpioChangeReader*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGpioChangeReader.xml' path='doc/member[@name="IGpioChangeReader.put_Polarity"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT put_Polarity([NativeTypeName("ABI::Windows::Devices::Gpio::GpioChangePolarity")] GpioChangePolarity value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGpioChangeReader*, GpioChangePolarity, int>)(lpVtbl[10]))((IGpioChangeReader*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGpioChangeReader.xml' path='doc/member[@name="IGpioChangeReader.get_Polarity"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_Polarity([NativeTypeName("ABI::Windows::Devices::Gpio::GpioChangePolarity *")] GpioChangePolarity* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGpioChangeReader*, GpioChangePolarity*, int>)(lpVtbl[11]))((IGpioChangeReader*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGpioChangeReader.xml' path='doc/member[@name="IGpioChangeReader.get_IsStarted"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_IsStarted([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGpioChangeReader*, byte*, int>)(lpVtbl[12]))((IGpioChangeReader*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGpioChangeReader.xml' path='doc/member[@name="IGpioChangeReader.Start"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT Start()
    {
        return ((delegate* unmanaged[MemberFunction]<IGpioChangeReader*, int>)(lpVtbl[13]))((IGpioChangeReader*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IGpioChangeReader.xml' path='doc/member[@name="IGpioChangeReader.Stop"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT Stop()
    {
        return ((delegate* unmanaged[MemberFunction]<IGpioChangeReader*, int>)(lpVtbl[14]))((IGpioChangeReader*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IGpioChangeReader.xml' path='doc/member[@name="IGpioChangeReader.Clear"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT Clear()
    {
        return ((delegate* unmanaged[MemberFunction]<IGpioChangeReader*, int>)(lpVtbl[15]))((IGpioChangeReader*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IGpioChangeReader.xml' path='doc/member[@name="IGpioChangeReader.GetNextItem"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT GetNextItem([NativeTypeName("ABI::Windows::Devices::Gpio::GpioChangeRecord *")] GpioChangeRecord* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGpioChangeReader*, GpioChangeRecord*, int>)(lpVtbl[16]))((IGpioChangeReader*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGpioChangeReader.xml' path='doc/member[@name="IGpioChangeReader.PeekNextItem"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT PeekNextItem([NativeTypeName("ABI::Windows::Devices::Gpio::GpioChangeRecord *")] GpioChangeRecord* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGpioChangeReader*, GpioChangeRecord*, int>)(lpVtbl[17]))((IGpioChangeReader*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGpioChangeReader.xml' path='doc/member[@name="IGpioChangeReader.GetAllItems"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT GetAllItems([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CDevices__CGpio__CGpioChangeRecord_t **")] IVector<GpioChangeRecord>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGpioChangeReader*, IVector<GpioChangeRecord>**, int>)(lpVtbl[18]))((IGpioChangeReader*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGpioChangeReader.xml' path='doc/member[@name="IGpioChangeReader.WaitForItemsAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT WaitForItemsAsync([NativeTypeName("INT32")] int count, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IGpioChangeReader*, int, IAsyncAction**, int>)(lpVtbl[19]))((IGpioChangeReader*)Unsafe.AsPointer(ref this), count, operation);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Capacity([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(7)]
        HRESULT get_Length([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(8)]
        HRESULT get_IsEmpty([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(9)]
        HRESULT get_IsOverflowed([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(10)]
        HRESULT put_Polarity([NativeTypeName("ABI::Windows::Devices::Gpio::GpioChangePolarity")] GpioChangePolarity value);

        [VtblIndex(11)]
        HRESULT get_Polarity([NativeTypeName("ABI::Windows::Devices::Gpio::GpioChangePolarity *")] GpioChangePolarity* value);

        [VtblIndex(12)]
        HRESULT get_IsStarted([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(13)]
        HRESULT Start();

        [VtblIndex(14)]
        HRESULT Stop();

        [VtblIndex(15)]
        HRESULT Clear();

        [VtblIndex(16)]
        HRESULT GetNextItem([NativeTypeName("ABI::Windows::Devices::Gpio::GpioChangeRecord *")] GpioChangeRecord* value);

        [VtblIndex(17)]
        HRESULT PeekNextItem([NativeTypeName("ABI::Windows::Devices::Gpio::GpioChangeRecord *")] GpioChangeRecord* value);

        [VtblIndex(18)]
        HRESULT GetAllItems([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CDevices__CGpio__CGpioChangeRecord_t **")] IVector<GpioChangeRecord>** value);

        [VtblIndex(19)]
        HRESULT WaitForItemsAsync([NativeTypeName("INT32")] int count, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> get_Capacity;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> get_Length;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsEmpty;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsOverflowed;

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

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> Clear;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Gpio::GpioChangeRecord *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, GpioChangeRecord*, int> GetNextItem;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Gpio::GpioChangeRecord *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, GpioChangeRecord*, int> PeekNextItem;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CDevices__CGpio__CGpioChangeRecord_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVector<GpioChangeRecord>**, int> GetAllItems;

        [NativeTypeName("HRESULT (INT32, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int, IAsyncAction**, int> WaitForItemsAsync;
    }
}
