// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.bluetooth.genericattributeprofile.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IGattPresentationFormatStatics2.xml' path='doc/member[@name="IGattPresentationFormatStatics2"]/*' />
[Guid("A9C21713-B82F-435E-B634-21FD85A43C07")]
[NativeTypeName("struct IGattPresentationFormatStatics2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IGattPresentationFormatStatics2 : IGattPresentationFormatStatics2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IGattPresentationFormatStatics2));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattPresentationFormatStatics2*, Guid*, void**, int>)(lpVtbl[0]))((IGattPresentationFormatStatics2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IGattPresentationFormatStatics2*, uint>)(lpVtbl[1]))((IGattPresentationFormatStatics2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IGattPresentationFormatStatics2*, uint>)(lpVtbl[2]))((IGattPresentationFormatStatics2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattPresentationFormatStatics2*, uint*, Guid**, int>)(lpVtbl[3]))((IGattPresentationFormatStatics2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattPresentationFormatStatics2*, HSTRING*, int>)(lpVtbl[4]))((IGattPresentationFormatStatics2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattPresentationFormatStatics2*, TrustLevel*, int>)(lpVtbl[5]))((IGattPresentationFormatStatics2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IGattPresentationFormatStatics2.xml' path='doc/member[@name="IGattPresentationFormatStatics2.FromParts"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT FromParts(byte formatType, [NativeTypeName("INT32")] int exponent, [NativeTypeName("UINT16")] ushort unit, byte namespaceId, [NativeTypeName("UINT16")] ushort description, [NativeTypeName("ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::IGattPresentationFormat **")] IGattPresentationFormat** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattPresentationFormatStatics2*, byte, int, ushort, byte, ushort, IGattPresentationFormat**, int>)(lpVtbl[6]))((IGattPresentationFormatStatics2*)Unsafe.AsPointer(ref this), formatType, exponent, unit, namespaceId, description, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT FromParts(byte formatType, [NativeTypeName("INT32")] int exponent, [NativeTypeName("UINT16")] ushort unit, byte namespaceId, [NativeTypeName("UINT16")] ushort description, [NativeTypeName("ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::IGattPresentationFormat **")] IGattPresentationFormat** result);
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

        [NativeTypeName("HRESULT (BYTE, INT32, UINT16, BYTE, UINT16, ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::IGattPresentationFormat **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int, ushort, byte, ushort, IGattPresentationFormat**, int> FromParts;
    }
}
