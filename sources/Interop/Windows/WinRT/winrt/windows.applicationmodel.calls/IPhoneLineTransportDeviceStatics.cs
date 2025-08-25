// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.calls.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IPhoneLineTransportDeviceStatics.xml' path='doc/member[@name="IPhoneLineTransportDeviceStatics"]/*' />
[Guid("0F3121AC-D609-51A1-96F3-FB00D1819252")]
[NativeTypeName("struct IPhoneLineTransportDeviceStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IPhoneLineTransportDeviceStatics : IPhoneLineTransportDeviceStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IPhoneLineTransportDeviceStatics);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneLineTransportDeviceStatics*, Guid*, void**, int>)(lpVtbl[0]))((IPhoneLineTransportDeviceStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneLineTransportDeviceStatics*, uint>)(lpVtbl[1]))((IPhoneLineTransportDeviceStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneLineTransportDeviceStatics*, uint>)(lpVtbl[2]))((IPhoneLineTransportDeviceStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneLineTransportDeviceStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IPhoneLineTransportDeviceStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneLineTransportDeviceStatics*, HSTRING*, int>)(lpVtbl[4]))((IPhoneLineTransportDeviceStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneLineTransportDeviceStatics*, TrustLevel*, int>)(lpVtbl[5]))((IPhoneLineTransportDeviceStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IPhoneLineTransportDeviceStatics.xml' path='doc/member[@name="IPhoneLineTransportDeviceStatics.FromId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT FromId(HSTRING id, [NativeTypeName("ABI::Windows::ApplicationModel::Calls::IPhoneLineTransportDevice **")] IPhoneLineTransportDevice** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneLineTransportDeviceStatics*, HSTRING, IPhoneLineTransportDevice**, int>)(lpVtbl[6]))((IPhoneLineTransportDeviceStatics*)Unsafe.AsPointer(ref this), id, result);
    }

    /// <include file='IPhoneLineTransportDeviceStatics.xml' path='doc/member[@name="IPhoneLineTransportDeviceStatics.GetDeviceSelector"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetDeviceSelector(HSTRING* result)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneLineTransportDeviceStatics*, HSTRING*, int>)(lpVtbl[7]))((IPhoneLineTransportDeviceStatics*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='IPhoneLineTransportDeviceStatics.xml' path='doc/member[@name="IPhoneLineTransportDeviceStatics.GetDeviceSelectorForPhoneLineTransport"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetDeviceSelectorForPhoneLineTransport([NativeTypeName("ABI::Windows::ApplicationModel::Calls::PhoneLineTransport")] PhoneLineTransport transport, HSTRING* result)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneLineTransportDeviceStatics*, PhoneLineTransport, HSTRING*, int>)(lpVtbl[8]))((IPhoneLineTransportDeviceStatics*)Unsafe.AsPointer(ref this), transport, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT FromId(HSTRING id, [NativeTypeName("ABI::Windows::ApplicationModel::Calls::IPhoneLineTransportDevice **")] IPhoneLineTransportDevice** result);

        [VtblIndex(7)]
        HRESULT GetDeviceSelector(HSTRING* result);

        [VtblIndex(8)]
        HRESULT GetDeviceSelectorForPhoneLineTransport([NativeTypeName("ABI::Windows::ApplicationModel::Calls::PhoneLineTransport")] PhoneLineTransport transport, HSTRING* result);
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

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::ApplicationModel::Calls::IPhoneLineTransportDevice **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IPhoneLineTransportDevice**, int> FromId;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> GetDeviceSelector;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Calls::PhoneLineTransport, HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, PhoneLineTransport, HSTRING*, int> GetDeviceSelectorForPhoneLineTransport;
    }
}
