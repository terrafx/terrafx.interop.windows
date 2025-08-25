// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.bluetooth.genericattributeprofile.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IGattCharacteristicStatics.xml' path='doc/member[@name="IGattCharacteristicStatics"]/*' />
[Guid("59CB50C3-5934-4F68-A198-EB864FA44E6B")]
[NativeTypeName("struct IGattCharacteristicStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IGattCharacteristicStatics : IGattCharacteristicStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IGattCharacteristicStatics);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattCharacteristicStatics*, Guid*, void**, int>)(lpVtbl[0]))((IGattCharacteristicStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IGattCharacteristicStatics*, uint>)(lpVtbl[1]))((IGattCharacteristicStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IGattCharacteristicStatics*, uint>)(lpVtbl[2]))((IGattCharacteristicStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattCharacteristicStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IGattCharacteristicStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattCharacteristicStatics*, HSTRING*, int>)(lpVtbl[4]))((IGattCharacteristicStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattCharacteristicStatics*, TrustLevel*, int>)(lpVtbl[5]))((IGattCharacteristicStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IGattCharacteristicStatics.xml' path='doc/member[@name="IGattCharacteristicStatics.ConvertShortIdToUuid"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    [Obsolete("Use BluetoothUuidHelper instead of ConvertShortIdToUuid.  For more information, see MSDN.")]
    public HRESULT ConvertShortIdToUuid([NativeTypeName("UINT16")] ushort shortId, Guid* characteristicUuid)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattCharacteristicStatics*, ushort, Guid*, int>)(lpVtbl[6]))((IGattCharacteristicStatics*)Unsafe.AsPointer(ref this), shortId, characteristicUuid);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        [Obsolete("Use BluetoothUuidHelper instead of ConvertShortIdToUuid.  For more information, see MSDN.")]
        HRESULT ConvertShortIdToUuid([NativeTypeName("UINT16")] ushort shortId, Guid* characteristicUuid);
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

        [NativeTypeName("HRESULT (UINT16, GUID *) __attribute__((stdcall))")]
        [Obsolete("Use BluetoothUuidHelper instead of ConvertShortIdToUuid.  For more information, see MSDN.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ushort, Guid*, int> ConvertShortIdToUuid;
    }
}
