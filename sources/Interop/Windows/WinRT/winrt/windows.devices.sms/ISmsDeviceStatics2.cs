// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.sms.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ISmsDeviceStatics2.xml' path='doc/member[@name="ISmsDeviceStatics2"]/*' />
[Guid("2CA11C87-0873-4CAF-8A7D-BD471E8586D1")]
[NativeTypeName("struct ISmsDeviceStatics2 : IInspectable")]
[NativeInheritance("IInspectable")]
[Obsolete("ISmsDeviceStatics2 may be altered or unavailable for releases after Windows 10.")]
public unsafe partial struct ISmsDeviceStatics2 : ISmsDeviceStatics2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISmsDeviceStatics2));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsDeviceStatics2*, Guid*, void**, int>)(lpVtbl[0]))((ISmsDeviceStatics2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsDeviceStatics2*, uint>)(lpVtbl[1]))((ISmsDeviceStatics2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsDeviceStatics2*, uint>)(lpVtbl[2]))((ISmsDeviceStatics2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsDeviceStatics2*, uint*, Guid**, int>)(lpVtbl[3]))((ISmsDeviceStatics2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsDeviceStatics2*, HSTRING*, int>)(lpVtbl[4]))((ISmsDeviceStatics2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsDeviceStatics2*, TrustLevel*, int>)(lpVtbl[5]))((ISmsDeviceStatics2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ISmsDeviceStatics2.xml' path='doc/member[@name="ISmsDeviceStatics2.FromNetworkAccountIdAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    [Obsolete("ISmsDeviceStatics2 may be altered or unavailable for releases after Windows 10.")]
    public HRESULT FromNetworkAccountIdAsync(HSTRING networkAccountId, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSms__CSmsDevice_t **")] IAsyncOperation<Pointer<ISmsDevice>>** asyncInfo)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsDeviceStatics2*, HSTRING, IAsyncOperation<Pointer<ISmsDevice>>**, int>)(lpVtbl[6]))((ISmsDeviceStatics2*)Unsafe.AsPointer(ref this), networkAccountId, asyncInfo);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        [Obsolete("ISmsDeviceStatics2 may be altered or unavailable for releases after Windows 10.")]
        HRESULT FromNetworkAccountIdAsync(HSTRING networkAccountId, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSms__CSmsDevice_t **")] IAsyncOperation<Pointer<ISmsDevice>>** asyncInfo);
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

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSms__CSmsDevice_t **) __attribute__((stdcall))")]
        [Obsolete("ISmsDeviceStatics2 may be altered or unavailable for releases after Windows 10.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IAsyncOperation<Pointer<ISmsDevice>>**, int> FromNetworkAccountIdAsync;
    }
}
