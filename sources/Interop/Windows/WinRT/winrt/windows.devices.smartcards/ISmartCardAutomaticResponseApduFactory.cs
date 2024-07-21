// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.smartcards.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ISmartCardAutomaticResponseApduFactory.xml' path='doc/member[@name="ISmartCardAutomaticResponseApduFactory"]/*' />
[Guid("E97EA2FA-D02C-4C55-B02A-8CFF7FA9F05B")]
[NativeTypeName("struct ISmartCardAutomaticResponseApduFactory : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ISmartCardAutomaticResponseApduFactory : ISmartCardAutomaticResponseApduFactory.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISmartCardAutomaticResponseApduFactory));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardAutomaticResponseApduFactory*, Guid*, void**, int>)(lpVtbl[0]))((ISmartCardAutomaticResponseApduFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardAutomaticResponseApduFactory*, uint>)(lpVtbl[1]))((ISmartCardAutomaticResponseApduFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardAutomaticResponseApduFactory*, uint>)(lpVtbl[2]))((ISmartCardAutomaticResponseApduFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardAutomaticResponseApduFactory*, uint*, Guid**, int>)(lpVtbl[3]))((ISmartCardAutomaticResponseApduFactory*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardAutomaticResponseApduFactory*, HSTRING*, int>)(lpVtbl[4]))((ISmartCardAutomaticResponseApduFactory*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardAutomaticResponseApduFactory*, TrustLevel*, int>)(lpVtbl[5]))((ISmartCardAutomaticResponseApduFactory*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ISmartCardAutomaticResponseApduFactory.xml' path='doc/member[@name="ISmartCardAutomaticResponseApduFactory.Create"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Create([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* commandApdu, [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* responseApdu, [NativeTypeName("ABI::Windows::Devices::SmartCards::ISmartCardAutomaticResponseApdu **")] ISmartCardAutomaticResponseApdu** result)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardAutomaticResponseApduFactory*, IBuffer*, IBuffer*, ISmartCardAutomaticResponseApdu**, int>)(lpVtbl[6]))((ISmartCardAutomaticResponseApduFactory*)Unsafe.AsPointer(ref this), commandApdu, responseApdu, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT Create([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* commandApdu, [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* responseApdu, [NativeTypeName("ABI::Windows::Devices::SmartCards::ISmartCardAutomaticResponseApdu **")] ISmartCardAutomaticResponseApdu** result);
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

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IBuffer *, ABI::Windows::Storage::Streams::IBuffer *, ABI::Windows::Devices::SmartCards::ISmartCardAutomaticResponseApdu **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IBuffer*, IBuffer*, ISmartCardAutomaticResponseApdu**, int> Create;
    }
}
