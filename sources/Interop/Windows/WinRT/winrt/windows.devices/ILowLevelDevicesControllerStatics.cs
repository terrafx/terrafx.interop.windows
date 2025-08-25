// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ILowLevelDevicesControllerStatics.xml' path='doc/member[@name="ILowLevelDevicesControllerStatics"]/*' />
[Guid("093E926A-FCCB-4394-A697-19DE637C2DB3")]
[NativeTypeName("struct ILowLevelDevicesControllerStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ILowLevelDevicesControllerStatics : ILowLevelDevicesControllerStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_ILowLevelDevicesControllerStatics);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ILowLevelDevicesControllerStatics*, Guid*, void**, int>)(lpVtbl[0]))((ILowLevelDevicesControllerStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ILowLevelDevicesControllerStatics*, uint>)(lpVtbl[1]))((ILowLevelDevicesControllerStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ILowLevelDevicesControllerStatics*, uint>)(lpVtbl[2]))((ILowLevelDevicesControllerStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ILowLevelDevicesControllerStatics*, uint*, Guid**, int>)(lpVtbl[3]))((ILowLevelDevicesControllerStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ILowLevelDevicesControllerStatics*, HSTRING*, int>)(lpVtbl[4]))((ILowLevelDevicesControllerStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ILowLevelDevicesControllerStatics*, TrustLevel*, int>)(lpVtbl[5]))((ILowLevelDevicesControllerStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ILowLevelDevicesControllerStatics.xml' path='doc/member[@name="ILowLevelDevicesControllerStatics.get_DefaultProvider"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_DefaultProvider([NativeTypeName("ABI::Windows::Devices::ILowLevelDevicesAggregateProvider **")] ILowLevelDevicesAggregateProvider** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ILowLevelDevicesControllerStatics*, ILowLevelDevicesAggregateProvider**, int>)(lpVtbl[6]))((ILowLevelDevicesControllerStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ILowLevelDevicesControllerStatics.xml' path='doc/member[@name="ILowLevelDevicesControllerStatics.put_DefaultProvider"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_DefaultProvider([NativeTypeName("ABI::Windows::Devices::ILowLevelDevicesAggregateProvider *")] ILowLevelDevicesAggregateProvider* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ILowLevelDevicesControllerStatics*, ILowLevelDevicesAggregateProvider*, int>)(lpVtbl[7]))((ILowLevelDevicesControllerStatics*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_DefaultProvider([NativeTypeName("ABI::Windows::Devices::ILowLevelDevicesAggregateProvider **")] ILowLevelDevicesAggregateProvider** value);

        [VtblIndex(7)]
        HRESULT put_DefaultProvider([NativeTypeName("ABI::Windows::Devices::ILowLevelDevicesAggregateProvider *")] ILowLevelDevicesAggregateProvider* value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Devices::ILowLevelDevicesAggregateProvider **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ILowLevelDevicesAggregateProvider**, int> get_DefaultProvider;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::ILowLevelDevicesAggregateProvider *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ILowLevelDevicesAggregateProvider*, int> put_DefaultProvider;
    }
}
