// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.bluetooth.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IBluetoothLEConnectionParameters.xml' path='doc/member[@name="IBluetoothLEConnectionParameters"]/*' />
[Guid("33CB0771-8DA9-508F-A366-1CA388C929AB")]
[NativeTypeName("struct IBluetoothLEConnectionParameters : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IBluetoothLEConnectionParameters : IBluetoothLEConnectionParameters.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IBluetoothLEConnectionParameters));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEConnectionParameters*, Guid*, void**, int>)(lpVtbl[0]))((IBluetoothLEConnectionParameters*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEConnectionParameters*, uint>)(lpVtbl[1]))((IBluetoothLEConnectionParameters*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEConnectionParameters*, uint>)(lpVtbl[2]))((IBluetoothLEConnectionParameters*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEConnectionParameters*, uint*, Guid**, int>)(lpVtbl[3]))((IBluetoothLEConnectionParameters*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEConnectionParameters*, HSTRING*, int>)(lpVtbl[4]))((IBluetoothLEConnectionParameters*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEConnectionParameters*, TrustLevel*, int>)(lpVtbl[5]))((IBluetoothLEConnectionParameters*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IBluetoothLEConnectionParameters.xml' path='doc/member[@name="IBluetoothLEConnectionParameters.get_LinkTimeout"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_LinkTimeout([NativeTypeName("UINT16 *")] ushort* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEConnectionParameters*, ushort*, int>)(lpVtbl[6]))((IBluetoothLEConnectionParameters*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBluetoothLEConnectionParameters.xml' path='doc/member[@name="IBluetoothLEConnectionParameters.get_ConnectionLatency"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_ConnectionLatency([NativeTypeName("UINT16 *")] ushort* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEConnectionParameters*, ushort*, int>)(lpVtbl[7]))((IBluetoothLEConnectionParameters*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBluetoothLEConnectionParameters.xml' path='doc/member[@name="IBluetoothLEConnectionParameters.get_ConnectionInterval"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_ConnectionInterval([NativeTypeName("UINT16 *")] ushort* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEConnectionParameters*, ushort*, int>)(lpVtbl[8]))((IBluetoothLEConnectionParameters*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_LinkTimeout([NativeTypeName("UINT16 *")] ushort* value);

        [VtblIndex(7)]
        HRESULT get_ConnectionLatency([NativeTypeName("UINT16 *")] ushort* value);

        [VtblIndex(8)]
        HRESULT get_ConnectionInterval([NativeTypeName("UINT16 *")] ushort* value);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, ushort*, int> get_LinkTimeout;

        [NativeTypeName("HRESULT (UINT16 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ushort*, int> get_ConnectionLatency;

        [NativeTypeName("HRESULT (UINT16 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ushort*, int> get_ConnectionInterval;
    }
}
