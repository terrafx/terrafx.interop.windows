// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.bluetooth.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IBluetoothLEConnectionPhyInfo.xml' path='doc/member[@name="IBluetoothLEConnectionPhyInfo"]/*' />
[Guid("9A100BDD-602E-5C27-A1AE-B230015A6394")]
[NativeTypeName("struct IBluetoothLEConnectionPhyInfo : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IBluetoothLEConnectionPhyInfo : IBluetoothLEConnectionPhyInfo.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IBluetoothLEConnectionPhyInfo));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEConnectionPhyInfo*, Guid*, void**, int>)(lpVtbl[0]))((IBluetoothLEConnectionPhyInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEConnectionPhyInfo*, uint>)(lpVtbl[1]))((IBluetoothLEConnectionPhyInfo*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEConnectionPhyInfo*, uint>)(lpVtbl[2]))((IBluetoothLEConnectionPhyInfo*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEConnectionPhyInfo*, uint*, Guid**, int>)(lpVtbl[3]))((IBluetoothLEConnectionPhyInfo*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEConnectionPhyInfo*, HSTRING*, int>)(lpVtbl[4]))((IBluetoothLEConnectionPhyInfo*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEConnectionPhyInfo*, TrustLevel*, int>)(lpVtbl[5]))((IBluetoothLEConnectionPhyInfo*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IBluetoothLEConnectionPhyInfo.xml' path='doc/member[@name="IBluetoothLEConnectionPhyInfo.get_IsUncoded1MPhy"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_IsUncoded1MPhy([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEConnectionPhyInfo*, byte*, int>)(lpVtbl[6]))((IBluetoothLEConnectionPhyInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBluetoothLEConnectionPhyInfo.xml' path='doc/member[@name="IBluetoothLEConnectionPhyInfo.get_IsUncoded2MPhy"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_IsUncoded2MPhy([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEConnectionPhyInfo*, byte*, int>)(lpVtbl[7]))((IBluetoothLEConnectionPhyInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBluetoothLEConnectionPhyInfo.xml' path='doc/member[@name="IBluetoothLEConnectionPhyInfo.get_IsCodedPhy"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_IsCodedPhy([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEConnectionPhyInfo*, byte*, int>)(lpVtbl[8]))((IBluetoothLEConnectionPhyInfo*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_IsUncoded1MPhy([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(7)]
        HRESULT get_IsUncoded2MPhy([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(8)]
        HRESULT get_IsCodedPhy([NativeTypeName("boolean *")] byte* value);
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

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsUncoded1MPhy;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsUncoded2MPhy;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsCodedPhy;
    }
}
