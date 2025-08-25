// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.networking.connectivity.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IWwanConnectionProfileDetails2.xml' path='doc/member[@name="IWwanConnectionProfileDetails2"]/*' />
[Guid("7A754EDE-A1ED-48B2-8E92-B460033D52E2")]
[NativeTypeName("struct IWwanConnectionProfileDetails2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IWwanConnectionProfileDetails2 : IWwanConnectionProfileDetails2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IWwanConnectionProfileDetails2);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IWwanConnectionProfileDetails2*, Guid*, void**, int>)(lpVtbl[0]))((IWwanConnectionProfileDetails2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IWwanConnectionProfileDetails2*, uint>)(lpVtbl[1]))((IWwanConnectionProfileDetails2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IWwanConnectionProfileDetails2*, uint>)(lpVtbl[2]))((IWwanConnectionProfileDetails2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IWwanConnectionProfileDetails2*, uint*, Guid**, int>)(lpVtbl[3]))((IWwanConnectionProfileDetails2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IWwanConnectionProfileDetails2*, HSTRING*, int>)(lpVtbl[4]))((IWwanConnectionProfileDetails2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IWwanConnectionProfileDetails2*, TrustLevel*, int>)(lpVtbl[5]))((IWwanConnectionProfileDetails2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IWwanConnectionProfileDetails2.xml' path='doc/member[@name="IWwanConnectionProfileDetails2.get_IPKind"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_IPKind([NativeTypeName("ABI::Windows::Networking::Connectivity::WwanNetworkIPKind *")] WwanNetworkIPKind* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IWwanConnectionProfileDetails2*, WwanNetworkIPKind*, int>)(lpVtbl[6]))((IWwanConnectionProfileDetails2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IWwanConnectionProfileDetails2.xml' path='doc/member[@name="IWwanConnectionProfileDetails2.get_PurposeGuids"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_PurposeGuids([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_GUID_t **")] IVectorView<Guid>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IWwanConnectionProfileDetails2*, IVectorView<Guid>**, int>)(lpVtbl[7]))((IWwanConnectionProfileDetails2*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_IPKind([NativeTypeName("ABI::Windows::Networking::Connectivity::WwanNetworkIPKind *")] WwanNetworkIPKind* value);

        [VtblIndex(7)]
        HRESULT get_PurposeGuids([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_GUID_t **")] IVectorView<Guid>** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Networking::Connectivity::WwanNetworkIPKind *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, WwanNetworkIPKind*, int> get_IPKind;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_GUID_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVectorView<Guid>**, int> get_PurposeGuids;
    }
}
