// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.bluetooth.genericattributeprofile.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IGattReadClientCharacteristicConfigurationDescriptorResult2.xml' path='doc/member[@name="IGattReadClientCharacteristicConfigurationDescriptorResult2"]/*' />
[Guid("1BF1A59D-BA4D-4622-8651-F4EE150D0A5D")]
[NativeTypeName("struct IGattReadClientCharacteristicConfigurationDescriptorResult2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IGattReadClientCharacteristicConfigurationDescriptorResult2 : IGattReadClientCharacteristicConfigurationDescriptorResult2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IGattReadClientCharacteristicConfigurationDescriptorResult2));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattReadClientCharacteristicConfigurationDescriptorResult2*, Guid*, void**, int>)(lpVtbl[0]))((IGattReadClientCharacteristicConfigurationDescriptorResult2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IGattReadClientCharacteristicConfigurationDescriptorResult2*, uint>)(lpVtbl[1]))((IGattReadClientCharacteristicConfigurationDescriptorResult2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IGattReadClientCharacteristicConfigurationDescriptorResult2*, uint>)(lpVtbl[2]))((IGattReadClientCharacteristicConfigurationDescriptorResult2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattReadClientCharacteristicConfigurationDescriptorResult2*, uint*, Guid**, int>)(lpVtbl[3]))((IGattReadClientCharacteristicConfigurationDescriptorResult2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattReadClientCharacteristicConfigurationDescriptorResult2*, HSTRING*, int>)(lpVtbl[4]))((IGattReadClientCharacteristicConfigurationDescriptorResult2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattReadClientCharacteristicConfigurationDescriptorResult2*, TrustLevel*, int>)(lpVtbl[5]))((IGattReadClientCharacteristicConfigurationDescriptorResult2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IGattReadClientCharacteristicConfigurationDescriptorResult2.xml' path='doc/member[@name="IGattReadClientCharacteristicConfigurationDescriptorResult2.get_ProtocolError"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_ProtocolError([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_byte_t **")] IReference<byte>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattReadClientCharacteristicConfigurationDescriptorResult2*, IReference<byte>**, int>)(lpVtbl[6]))((IGattReadClientCharacteristicConfigurationDescriptorResult2*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_ProtocolError([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_byte_t **")] IReference<byte>** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_byte_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<byte>**, int> get_ProtocolError;
    }
}
