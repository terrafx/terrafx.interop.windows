// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.casting.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ICastingDeviceStatics.xml' path='doc/member[@name="ICastingDeviceStatics"]/*' />
[Guid("E7D958D7-4D13-4237-A365-4C4F6A4CFD2F")]
[NativeTypeName("struct ICastingDeviceStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICastingDeviceStatics : ICastingDeviceStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICastingDeviceStatics));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ICastingDeviceStatics*, Guid*, void**, int>)(lpVtbl[0]))((ICastingDeviceStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ICastingDeviceStatics*, uint>)(lpVtbl[1]))((ICastingDeviceStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ICastingDeviceStatics*, uint>)(lpVtbl[2]))((ICastingDeviceStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ICastingDeviceStatics*, uint*, Guid**, int>)(lpVtbl[3]))((ICastingDeviceStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ICastingDeviceStatics*, HSTRING*, int>)(lpVtbl[4]))((ICastingDeviceStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ICastingDeviceStatics*, TrustLevel*, int>)(lpVtbl[5]))((ICastingDeviceStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ICastingDeviceStatics.xml' path='doc/member[@name="ICastingDeviceStatics.GetDeviceSelector"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetDeviceSelector([NativeTypeName("ABI::Windows::Media::Casting::CastingPlaybackTypes")] CastingPlaybackTypes type, HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICastingDeviceStatics*, CastingPlaybackTypes, HSTRING*, int>)(lpVtbl[6]))((ICastingDeviceStatics*)Unsafe.AsPointer(ref this), type, value);
    }

    /// <include file='ICastingDeviceStatics.xml' path='doc/member[@name="ICastingDeviceStatics.GetDeviceSelectorFromCastingSourceAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetDeviceSelectorFromCastingSourceAsync([NativeTypeName("ABI::Windows::Media::Casting::ICastingSource *")] ICastingSource* castingSource, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_HSTRING_t **")] IAsyncOperation<HSTRING>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<ICastingDeviceStatics*, ICastingSource*, IAsyncOperation<HSTRING>**, int>)(lpVtbl[7]))((ICastingDeviceStatics*)Unsafe.AsPointer(ref this), castingSource, operation);
    }

    /// <include file='ICastingDeviceStatics.xml' path='doc/member[@name="ICastingDeviceStatics.FromIdAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT FromIdAsync(HSTRING value, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CCasting__CCastingDevice_t **")] IAsyncOperation<Pointer<ICastingDevice>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<ICastingDeviceStatics*, HSTRING, IAsyncOperation<Pointer<ICastingDevice>>**, int>)(lpVtbl[8]))((ICastingDeviceStatics*)Unsafe.AsPointer(ref this), value, operation);
    }

    /// <include file='ICastingDeviceStatics.xml' path='doc/member[@name="ICastingDeviceStatics.DeviceInfoSupportsCastingAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT DeviceInfoSupportsCastingAsync([NativeTypeName("ABI::Windows::Devices::Enumeration::IDeviceInformation *")] IDeviceInformation* device, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<bool>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<ICastingDeviceStatics*, IDeviceInformation*, IAsyncOperation<bool>**, int>)(lpVtbl[9]))((ICastingDeviceStatics*)Unsafe.AsPointer(ref this), device, operation);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT GetDeviceSelector([NativeTypeName("ABI::Windows::Media::Casting::CastingPlaybackTypes")] CastingPlaybackTypes type, HSTRING* value);

        [VtblIndex(7)]
        HRESULT GetDeviceSelectorFromCastingSourceAsync([NativeTypeName("ABI::Windows::Media::Casting::ICastingSource *")] ICastingSource* castingSource, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_HSTRING_t **")] IAsyncOperation<HSTRING>** operation);

        [VtblIndex(8)]
        HRESULT FromIdAsync(HSTRING value, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CCasting__CCastingDevice_t **")] IAsyncOperation<Pointer<ICastingDevice>>** operation);

        [VtblIndex(9)]
        HRESULT DeviceInfoSupportsCastingAsync([NativeTypeName("ABI::Windows::Devices::Enumeration::IDeviceInformation *")] IDeviceInformation* device, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<bool>** operation);
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

        [NativeTypeName("HRESULT (ABI::Windows::Media::Casting::CastingPlaybackTypes, HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, CastingPlaybackTypes, HSTRING*, int> GetDeviceSelector;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Casting::ICastingSource *, ABI::Windows::Foundation::__FIAsyncOperation_1_HSTRING_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ICastingSource*, IAsyncOperation<HSTRING>**, int> GetDeviceSelectorFromCastingSourceAsync;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CCasting__CCastingDevice_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IAsyncOperation<Pointer<ICastingDevice>>**, int> FromIdAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Enumeration::IDeviceInformation *, ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDeviceInformation*, IAsyncOperation<bool>**, int> DeviceInfoSupportsCastingAsync;
    }
}
