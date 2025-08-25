// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.calls.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IPhoneCallHistoryEntryAddressFactory.xml' path='doc/member[@name="IPhoneCallHistoryEntryAddressFactory"]/*' />
[Guid("FB0FADBA-C7F0-4BB6-9F6B-BA5D73209ACA")]
[NativeTypeName("struct IPhoneCallHistoryEntryAddressFactory : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IPhoneCallHistoryEntryAddressFactory : IPhoneCallHistoryEntryAddressFactory.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IPhoneCallHistoryEntryAddressFactory);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCallHistoryEntryAddressFactory*, Guid*, void**, int>)(lpVtbl[0]))((IPhoneCallHistoryEntryAddressFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCallHistoryEntryAddressFactory*, uint>)(lpVtbl[1]))((IPhoneCallHistoryEntryAddressFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCallHistoryEntryAddressFactory*, uint>)(lpVtbl[2]))((IPhoneCallHistoryEntryAddressFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCallHistoryEntryAddressFactory*, uint*, Guid**, int>)(lpVtbl[3]))((IPhoneCallHistoryEntryAddressFactory*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCallHistoryEntryAddressFactory*, HSTRING*, int>)(lpVtbl[4]))((IPhoneCallHistoryEntryAddressFactory*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCallHistoryEntryAddressFactory*, TrustLevel*, int>)(lpVtbl[5]))((IPhoneCallHistoryEntryAddressFactory*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IPhoneCallHistoryEntryAddressFactory.xml' path='doc/member[@name="IPhoneCallHistoryEntryAddressFactory.Create"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Create(HSTRING rawAddress, [NativeTypeName("ABI::Windows::ApplicationModel::Calls::PhoneCallHistoryEntryRawAddressKind")] PhoneCallHistoryEntryRawAddressKind rawAddressKind, [NativeTypeName("ABI::Windows::ApplicationModel::Calls::IPhoneCallHistoryEntryAddress **")] IPhoneCallHistoryEntryAddress** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCallHistoryEntryAddressFactory*, HSTRING, PhoneCallHistoryEntryRawAddressKind, IPhoneCallHistoryEntryAddress**, int>)(lpVtbl[6]))((IPhoneCallHistoryEntryAddressFactory*)Unsafe.AsPointer(ref this), rawAddress, rawAddressKind, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT Create(HSTRING rawAddress, [NativeTypeName("ABI::Windows::ApplicationModel::Calls::PhoneCallHistoryEntryRawAddressKind")] PhoneCallHistoryEntryRawAddressKind rawAddressKind, [NativeTypeName("ABI::Windows::ApplicationModel::Calls::IPhoneCallHistoryEntryAddress **")] IPhoneCallHistoryEntryAddress** result);
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

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::ApplicationModel::Calls::PhoneCallHistoryEntryRawAddressKind, ABI::Windows::ApplicationModel::Calls::IPhoneCallHistoryEntryAddress **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, PhoneCallHistoryEntryRawAddressKind, IPhoneCallHistoryEntryAddress**, int> Create;
    }
}
