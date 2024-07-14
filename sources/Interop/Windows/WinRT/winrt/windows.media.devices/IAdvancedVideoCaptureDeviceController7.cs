// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.devices.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IAdvancedVideoCaptureDeviceController7.xml' path='doc/member[@name="IAdvancedVideoCaptureDeviceController7"]/*' />
[Guid("8D2927F0-A054-50E7-B7DF-7C04234D10F0")]
[NativeTypeName("struct IAdvancedVideoCaptureDeviceController7 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAdvancedVideoCaptureDeviceController7 : IAdvancedVideoCaptureDeviceController7.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAdvancedVideoCaptureDeviceController7));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdvancedVideoCaptureDeviceController7*, Guid*, void**, int>)(lpVtbl[0]))((IAdvancedVideoCaptureDeviceController7*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAdvancedVideoCaptureDeviceController7*, uint>)(lpVtbl[1]))((IAdvancedVideoCaptureDeviceController7*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAdvancedVideoCaptureDeviceController7*, uint>)(lpVtbl[2]))((IAdvancedVideoCaptureDeviceController7*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdvancedVideoCaptureDeviceController7*, uint*, Guid**, int>)(lpVtbl[3]))((IAdvancedVideoCaptureDeviceController7*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdvancedVideoCaptureDeviceController7*, HSTRING*, int>)(lpVtbl[4]))((IAdvancedVideoCaptureDeviceController7*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdvancedVideoCaptureDeviceController7*, TrustLevel*, int>)(lpVtbl[5]))((IAdvancedVideoCaptureDeviceController7*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IAdvancedVideoCaptureDeviceController7.xml' path='doc/member[@name="IAdvancedVideoCaptureDeviceController7.get_InfraredTorchControl"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_InfraredTorchControl([NativeTypeName("ABI::Windows::Media::Devices::IInfraredTorchControl **")] IInfraredTorchControl** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdvancedVideoCaptureDeviceController7*, IInfraredTorchControl**, int>)(lpVtbl[6]))((IAdvancedVideoCaptureDeviceController7*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_InfraredTorchControl([NativeTypeName("ABI::Windows::Media::Devices::IInfraredTorchControl **")] IInfraredTorchControl** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Media::Devices::IInfraredTorchControl **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IInfraredTorchControl**, int> get_InfraredTorchControl;
    }
}
