// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.bluetooth.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IBluetoothSignalStrengthFilter.xml' path='doc/member[@name="IBluetoothSignalStrengthFilter"]/*' />
[Guid("DF7B7391-6BB5-4CFE-90B1-5D7324EDCF7F")]
[NativeTypeName("struct IBluetoothSignalStrengthFilter : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IBluetoothSignalStrengthFilter : IBluetoothSignalStrengthFilter.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IBluetoothSignalStrengthFilter));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothSignalStrengthFilter*, Guid*, void**, int>)(lpVtbl[0]))((IBluetoothSignalStrengthFilter*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothSignalStrengthFilter*, uint>)(lpVtbl[1]))((IBluetoothSignalStrengthFilter*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothSignalStrengthFilter*, uint>)(lpVtbl[2]))((IBluetoothSignalStrengthFilter*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothSignalStrengthFilter*, uint*, Guid**, int>)(lpVtbl[3]))((IBluetoothSignalStrengthFilter*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothSignalStrengthFilter*, HSTRING*, int>)(lpVtbl[4]))((IBluetoothSignalStrengthFilter*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothSignalStrengthFilter*, TrustLevel*, int>)(lpVtbl[5]))((IBluetoothSignalStrengthFilter*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IBluetoothSignalStrengthFilter.xml' path='doc/member[@name="IBluetoothSignalStrengthFilter.get_InRangeThresholdInDBm"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_InRangeThresholdInDBm([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_short_t **")] IReference<short>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothSignalStrengthFilter*, IReference<short>**, int>)(lpVtbl[6]))((IBluetoothSignalStrengthFilter*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBluetoothSignalStrengthFilter.xml' path='doc/member[@name="IBluetoothSignalStrengthFilter.put_InRangeThresholdInDBm"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_InRangeThresholdInDBm([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_short_t *")] IReference<short>* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothSignalStrengthFilter*, IReference<short>*, int>)(lpVtbl[7]))((IBluetoothSignalStrengthFilter*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBluetoothSignalStrengthFilter.xml' path='doc/member[@name="IBluetoothSignalStrengthFilter.get_OutOfRangeThresholdInDBm"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_OutOfRangeThresholdInDBm([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_short_t **")] IReference<short>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothSignalStrengthFilter*, IReference<short>**, int>)(lpVtbl[8]))((IBluetoothSignalStrengthFilter*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBluetoothSignalStrengthFilter.xml' path='doc/member[@name="IBluetoothSignalStrengthFilter.put_OutOfRangeThresholdInDBm"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_OutOfRangeThresholdInDBm([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_short_t *")] IReference<short>* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothSignalStrengthFilter*, IReference<short>*, int>)(lpVtbl[9]))((IBluetoothSignalStrengthFilter*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBluetoothSignalStrengthFilter.xml' path='doc/member[@name="IBluetoothSignalStrengthFilter.get_OutOfRangeTimeout"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_OutOfRangeTimeout([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CTimeSpan_t **")] IReference<TimeSpan>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothSignalStrengthFilter*, IReference<TimeSpan>**, int>)(lpVtbl[10]))((IBluetoothSignalStrengthFilter*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBluetoothSignalStrengthFilter.xml' path='doc/member[@name="IBluetoothSignalStrengthFilter.put_OutOfRangeTimeout"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_OutOfRangeTimeout([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CTimeSpan_t *")] IReference<TimeSpan>* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothSignalStrengthFilter*, IReference<TimeSpan>*, int>)(lpVtbl[11]))((IBluetoothSignalStrengthFilter*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBluetoothSignalStrengthFilter.xml' path='doc/member[@name="IBluetoothSignalStrengthFilter.get_SamplingInterval"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_SamplingInterval([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CTimeSpan_t **")] IReference<TimeSpan>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothSignalStrengthFilter*, IReference<TimeSpan>**, int>)(lpVtbl[12]))((IBluetoothSignalStrengthFilter*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBluetoothSignalStrengthFilter.xml' path='doc/member[@name="IBluetoothSignalStrengthFilter.put_SamplingInterval"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_SamplingInterval([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CTimeSpan_t *")] IReference<TimeSpan>* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothSignalStrengthFilter*, IReference<TimeSpan>*, int>)(lpVtbl[13]))((IBluetoothSignalStrengthFilter*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_InRangeThresholdInDBm([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_short_t **")] IReference<short>** value);

        [VtblIndex(7)]
        HRESULT put_InRangeThresholdInDBm([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_short_t *")] IReference<short>* value);

        [VtblIndex(8)]
        HRESULT get_OutOfRangeThresholdInDBm([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_short_t **")] IReference<short>** value);

        [VtblIndex(9)]
        HRESULT put_OutOfRangeThresholdInDBm([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_short_t *")] IReference<short>* value);

        [VtblIndex(10)]
        HRESULT get_OutOfRangeTimeout([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CTimeSpan_t **")] IReference<TimeSpan>** value);

        [VtblIndex(11)]
        HRESULT put_OutOfRangeTimeout([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CTimeSpan_t *")] IReference<TimeSpan>* value);

        [VtblIndex(12)]
        HRESULT get_SamplingInterval([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CTimeSpan_t **")] IReference<TimeSpan>** value);

        [VtblIndex(13)]
        HRESULT put_SamplingInterval([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CTimeSpan_t *")] IReference<TimeSpan>* value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_short_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<short>**, int> get_InRangeThresholdInDBm;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_short_t *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<short>*, int> put_InRangeThresholdInDBm;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_short_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<short>**, int> get_OutOfRangeThresholdInDBm;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_short_t *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<short>*, int> put_OutOfRangeThresholdInDBm;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CTimeSpan_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<TimeSpan>**, int> get_OutOfRangeTimeout;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CTimeSpan_t *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<TimeSpan>*, int> put_OutOfRangeTimeout;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CTimeSpan_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<TimeSpan>**, int> get_SamplingInterval;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CTimeSpan_t *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<TimeSpan>*, int> put_SamplingInterval;
    }
}
