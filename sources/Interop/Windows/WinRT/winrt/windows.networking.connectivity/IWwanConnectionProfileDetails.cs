// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.networking.connectivity.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IWwanConnectionProfileDetails.xml' path='doc/member[@name="IWwanConnectionProfileDetails"]/*' />
[Guid("0E4DA8FE-835F-4DF3-82FD-DF556EBC09EF")]
[NativeTypeName("struct IWwanConnectionProfileDetails : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IWwanConnectionProfileDetails : IWwanConnectionProfileDetails.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWwanConnectionProfileDetails));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IWwanConnectionProfileDetails*, Guid*, void**, int>)(lpVtbl[0]))((IWwanConnectionProfileDetails*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IWwanConnectionProfileDetails*, uint>)(lpVtbl[1]))((IWwanConnectionProfileDetails*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IWwanConnectionProfileDetails*, uint>)(lpVtbl[2]))((IWwanConnectionProfileDetails*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IWwanConnectionProfileDetails*, uint*, Guid**, int>)(lpVtbl[3]))((IWwanConnectionProfileDetails*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IWwanConnectionProfileDetails*, HSTRING*, int>)(lpVtbl[4]))((IWwanConnectionProfileDetails*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IWwanConnectionProfileDetails*, TrustLevel*, int>)(lpVtbl[5]))((IWwanConnectionProfileDetails*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IWwanConnectionProfileDetails.xml' path='doc/member[@name="IWwanConnectionProfileDetails.get_HomeProviderId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_HomeProviderId(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IWwanConnectionProfileDetails*, HSTRING*, int>)(lpVtbl[6]))((IWwanConnectionProfileDetails*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IWwanConnectionProfileDetails.xml' path='doc/member[@name="IWwanConnectionProfileDetails.get_AccessPointName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_AccessPointName(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IWwanConnectionProfileDetails*, HSTRING*, int>)(lpVtbl[7]))((IWwanConnectionProfileDetails*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IWwanConnectionProfileDetails.xml' path='doc/member[@name="IWwanConnectionProfileDetails.GetNetworkRegistrationState"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetNetworkRegistrationState([NativeTypeName("ABI::Windows::Networking::Connectivity::WwanNetworkRegistrationState *")] WwanNetworkRegistrationState* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IWwanConnectionProfileDetails*, WwanNetworkRegistrationState*, int>)(lpVtbl[8]))((IWwanConnectionProfileDetails*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IWwanConnectionProfileDetails.xml' path='doc/member[@name="IWwanConnectionProfileDetails.GetCurrentDataClass"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetCurrentDataClass([NativeTypeName("ABI::Windows::Networking::Connectivity::WwanDataClass *")] WwanDataClass* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IWwanConnectionProfileDetails*, WwanDataClass*, int>)(lpVtbl[9]))((IWwanConnectionProfileDetails*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_HomeProviderId(HSTRING* value);

        [VtblIndex(7)]
        HRESULT get_AccessPointName(HSTRING* value);

        [VtblIndex(8)]
        HRESULT GetNetworkRegistrationState([NativeTypeName("ABI::Windows::Networking::Connectivity::WwanNetworkRegistrationState *")] WwanNetworkRegistrationState* value);

        [VtblIndex(9)]
        HRESULT GetCurrentDataClass([NativeTypeName("ABI::Windows::Networking::Connectivity::WwanDataClass *")] WwanDataClass* value);
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

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_HomeProviderId;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_AccessPointName;

        [NativeTypeName("HRESULT (ABI::Windows::Networking::Connectivity::WwanNetworkRegistrationState *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, WwanNetworkRegistrationState*, int> GetNetworkRegistrationState;

        [NativeTypeName("HRESULT (ABI::Windows::Networking::Connectivity::WwanDataClass *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, WwanDataClass*, int> GetCurrentDataClass;
    }
}
