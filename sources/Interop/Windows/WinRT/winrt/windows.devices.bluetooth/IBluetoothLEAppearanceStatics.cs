// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.bluetooth.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IBluetoothLEAppearanceStatics.xml' path='doc/member[@name="IBluetoothLEAppearanceStatics"]/*' />
[Guid("A193C0C7-4504-4F4A-9BA5-CD1054E5E065")]
[NativeTypeName("struct IBluetoothLEAppearanceStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IBluetoothLEAppearanceStatics : IBluetoothLEAppearanceStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IBluetoothLEAppearanceStatics);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAppearanceStatics*, Guid*, void**, int>)(lpVtbl[0]))((IBluetoothLEAppearanceStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAppearanceStatics*, uint>)(lpVtbl[1]))((IBluetoothLEAppearanceStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAppearanceStatics*, uint>)(lpVtbl[2]))((IBluetoothLEAppearanceStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAppearanceStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IBluetoothLEAppearanceStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAppearanceStatics*, HSTRING*, int>)(lpVtbl[4]))((IBluetoothLEAppearanceStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAppearanceStatics*, TrustLevel*, int>)(lpVtbl[5]))((IBluetoothLEAppearanceStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IBluetoothLEAppearanceStatics.xml' path='doc/member[@name="IBluetoothLEAppearanceStatics.FromRawValue"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT FromRawValue([NativeTypeName("UINT16")] ushort rawValue, [NativeTypeName("ABI::Windows::Devices::Bluetooth::IBluetoothLEAppearance **")] IBluetoothLEAppearance** appearance)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAppearanceStatics*, ushort, IBluetoothLEAppearance**, int>)(lpVtbl[6]))((IBluetoothLEAppearanceStatics*)Unsafe.AsPointer(ref this), rawValue, appearance);
    }

    /// <include file='IBluetoothLEAppearanceStatics.xml' path='doc/member[@name="IBluetoothLEAppearanceStatics.FromParts"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT FromParts([NativeTypeName("UINT16")] ushort appearanceCategory, [NativeTypeName("UINT16")] ushort appearanceSubCategory, [NativeTypeName("ABI::Windows::Devices::Bluetooth::IBluetoothLEAppearance **")] IBluetoothLEAppearance** appearance)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAppearanceStatics*, ushort, ushort, IBluetoothLEAppearance**, int>)(lpVtbl[7]))((IBluetoothLEAppearanceStatics*)Unsafe.AsPointer(ref this), appearanceCategory, appearanceSubCategory, appearance);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT FromRawValue([NativeTypeName("UINT16")] ushort rawValue, [NativeTypeName("ABI::Windows::Devices::Bluetooth::IBluetoothLEAppearance **")] IBluetoothLEAppearance** appearance);

        [VtblIndex(7)]
        HRESULT FromParts([NativeTypeName("UINT16")] ushort appearanceCategory, [NativeTypeName("UINT16")] ushort appearanceSubCategory, [NativeTypeName("ABI::Windows::Devices::Bluetooth::IBluetoothLEAppearance **")] IBluetoothLEAppearance** appearance);
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

        [NativeTypeName("HRESULT (UINT16, ABI::Windows::Devices::Bluetooth::IBluetoothLEAppearance **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ushort, IBluetoothLEAppearance**, int> FromRawValue;

        [NativeTypeName("HRESULT (UINT16, UINT16, ABI::Windows::Devices::Bluetooth::IBluetoothLEAppearance **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ushort, ushort, IBluetoothLEAppearance**, int> FromParts;
    }
}
