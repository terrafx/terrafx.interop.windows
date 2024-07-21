// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.bluetooth.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IBluetoothUuidHelperStatics.xml' path='doc/member[@name="IBluetoothUuidHelperStatics"]/*' />
[Guid("17DF0CD8-CF74-4B21-AFE6-F57A11BCDEA0")]
[NativeTypeName("struct IBluetoothUuidHelperStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IBluetoothUuidHelperStatics : IBluetoothUuidHelperStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IBluetoothUuidHelperStatics));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothUuidHelperStatics*, Guid*, void**, int>)(lpVtbl[0]))((IBluetoothUuidHelperStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothUuidHelperStatics*, uint>)(lpVtbl[1]))((IBluetoothUuidHelperStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothUuidHelperStatics*, uint>)(lpVtbl[2]))((IBluetoothUuidHelperStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothUuidHelperStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IBluetoothUuidHelperStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothUuidHelperStatics*, HSTRING*, int>)(lpVtbl[4]))((IBluetoothUuidHelperStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothUuidHelperStatics*, TrustLevel*, int>)(lpVtbl[5]))((IBluetoothUuidHelperStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IBluetoothUuidHelperStatics.xml' path='doc/member[@name="IBluetoothUuidHelperStatics.FromShortId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT FromShortId([NativeTypeName("UINT32")] uint shortId, Guid* result)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothUuidHelperStatics*, uint, Guid*, int>)(lpVtbl[6]))((IBluetoothUuidHelperStatics*)Unsafe.AsPointer(ref this), shortId, result);
    }

    /// <include file='IBluetoothUuidHelperStatics.xml' path='doc/member[@name="IBluetoothUuidHelperStatics.TryGetShortId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT TryGetShortId(Guid uuid, [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT32_t **")] IReference<uint>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothUuidHelperStatics*, Guid, IReference<uint>**, int>)(lpVtbl[7]))((IBluetoothUuidHelperStatics*)Unsafe.AsPointer(ref this), uuid, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT FromShortId([NativeTypeName("UINT32")] uint shortId, Guid* result);

        [VtblIndex(7)]
        HRESULT TryGetShortId(Guid uuid, [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT32_t **")] IReference<uint>** result);
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

        [NativeTypeName("HRESULT (UINT32, GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, Guid*, int> FromShortId;

        [NativeTypeName("HRESULT (GUID, ABI::Windows::Foundation::__FIReference_1_UINT32_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid, IReference<uint>**, int> TryGetShortId;
    }
}
