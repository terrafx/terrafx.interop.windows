// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.sms.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ISmsDeviceStatics.xml' path='doc/member[@name="ISmsDeviceStatics"]/*' />
[Guid("F88D07EA-D815-4DD1-A234-4520CE4604A4")]
[NativeTypeName("struct ISmsDeviceStatics : IInspectable")]
[NativeInheritance("IInspectable")]
[Obsolete("ISmsDeviceStatics may be altered or unavailable for releases after Windows 10.")]
public unsafe partial struct ISmsDeviceStatics : ISmsDeviceStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_ISmsDeviceStatics);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsDeviceStatics*, Guid*, void**, int>)(lpVtbl[0]))((ISmsDeviceStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsDeviceStatics*, uint>)(lpVtbl[1]))((ISmsDeviceStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsDeviceStatics*, uint>)(lpVtbl[2]))((ISmsDeviceStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsDeviceStatics*, uint*, Guid**, int>)(lpVtbl[3]))((ISmsDeviceStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsDeviceStatics*, HSTRING*, int>)(lpVtbl[4]))((ISmsDeviceStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsDeviceStatics*, TrustLevel*, int>)(lpVtbl[5]))((ISmsDeviceStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ISmsDeviceStatics.xml' path='doc/member[@name="ISmsDeviceStatics.GetDeviceSelector"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    [Obsolete("ISmsDeviceStatics may be altered or unavailable for releases after Windows 10.")]
    public HRESULT GetDeviceSelector(HSTRING* phstrDeviceClassSelector)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsDeviceStatics*, HSTRING*, int>)(lpVtbl[6]))((ISmsDeviceStatics*)Unsafe.AsPointer(ref this), phstrDeviceClassSelector);
    }

    /// <include file='ISmsDeviceStatics.xml' path='doc/member[@name="ISmsDeviceStatics.FromIdAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    [Obsolete("ISmsDeviceStatics may be altered or unavailable for releases after Windows 10.")]
    public HRESULT FromIdAsync(HSTRING deviceId, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSms__CSmsDevice_t **")] IAsyncOperation<Pointer<ISmsDevice>>** asyncInfo)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsDeviceStatics*, HSTRING, IAsyncOperation<Pointer<ISmsDevice>>**, int>)(lpVtbl[7]))((ISmsDeviceStatics*)Unsafe.AsPointer(ref this), deviceId, asyncInfo);
    }

    /// <include file='ISmsDeviceStatics.xml' path='doc/member[@name="ISmsDeviceStatics.GetDefaultAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    [Obsolete("ISmsDeviceStatics may be altered or unavailable for releases after Windows 10.")]
    public HRESULT GetDefaultAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSms__CSmsDevice_t **")] IAsyncOperation<Pointer<ISmsDevice>>** asyncInfo)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsDeviceStatics*, IAsyncOperation<Pointer<ISmsDevice>>**, int>)(lpVtbl[8]))((ISmsDeviceStatics*)Unsafe.AsPointer(ref this), asyncInfo);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        [Obsolete("ISmsDeviceStatics may be altered or unavailable for releases after Windows 10.")]
        HRESULT GetDeviceSelector(HSTRING* phstrDeviceClassSelector);

        [VtblIndex(7)]
        [Obsolete("ISmsDeviceStatics may be altered or unavailable for releases after Windows 10.")]
        HRESULT FromIdAsync(HSTRING deviceId, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSms__CSmsDevice_t **")] IAsyncOperation<Pointer<ISmsDevice>>** asyncInfo);

        [VtblIndex(8)]
        [Obsolete("ISmsDeviceStatics may be altered or unavailable for releases after Windows 10.")]
        HRESULT GetDefaultAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSms__CSmsDevice_t **")] IAsyncOperation<Pointer<ISmsDevice>>** asyncInfo);
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
        [Obsolete("ISmsDeviceStatics may be altered or unavailable for releases after Windows 10.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> GetDeviceSelector;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSms__CSmsDevice_t **) __attribute__((stdcall))")]
        [Obsolete("ISmsDeviceStatics may be altered or unavailable for releases after Windows 10.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IAsyncOperation<Pointer<ISmsDevice>>**, int> FromIdAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSms__CSmsDevice_t **) __attribute__((stdcall))")]
        [Obsolete("ISmsDeviceStatics may be altered or unavailable for releases after Windows 10.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncOperation<Pointer<ISmsDevice>>**, int> GetDefaultAsync;
    }
}
