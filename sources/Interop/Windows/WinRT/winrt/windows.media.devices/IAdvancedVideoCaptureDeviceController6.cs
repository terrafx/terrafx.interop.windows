// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.devices.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IAdvancedVideoCaptureDeviceController6.xml' path='doc/member[@name="IAdvancedVideoCaptureDeviceController6"]/*' />
[Guid("B6563A53-68A1-44B7-9F89-B5FA97AC0CBE")]
[NativeTypeName("struct IAdvancedVideoCaptureDeviceController6 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAdvancedVideoCaptureDeviceController6 : IAdvancedVideoCaptureDeviceController6.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAdvancedVideoCaptureDeviceController6));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdvancedVideoCaptureDeviceController6*, Guid*, void**, int>)(lpVtbl[0]))((IAdvancedVideoCaptureDeviceController6*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAdvancedVideoCaptureDeviceController6*, uint>)(lpVtbl[1]))((IAdvancedVideoCaptureDeviceController6*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAdvancedVideoCaptureDeviceController6*, uint>)(lpVtbl[2]))((IAdvancedVideoCaptureDeviceController6*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdvancedVideoCaptureDeviceController6*, uint*, Guid**, int>)(lpVtbl[3]))((IAdvancedVideoCaptureDeviceController6*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdvancedVideoCaptureDeviceController6*, HSTRING*, int>)(lpVtbl[4]))((IAdvancedVideoCaptureDeviceController6*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdvancedVideoCaptureDeviceController6*, TrustLevel*, int>)(lpVtbl[5]))((IAdvancedVideoCaptureDeviceController6*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IAdvancedVideoCaptureDeviceController6.xml' path='doc/member[@name="IAdvancedVideoCaptureDeviceController6.get_VideoTemporalDenoisingControl"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_VideoTemporalDenoisingControl([NativeTypeName("ABI::Windows::Media::Devices::IVideoTemporalDenoisingControl **")] IVideoTemporalDenoisingControl** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdvancedVideoCaptureDeviceController6*, IVideoTemporalDenoisingControl**, int>)(lpVtbl[6]))((IAdvancedVideoCaptureDeviceController6*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_VideoTemporalDenoisingControl([NativeTypeName("ABI::Windows::Media::Devices::IVideoTemporalDenoisingControl **")] IVideoTemporalDenoisingControl** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Media::Devices::IVideoTemporalDenoisingControl **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVideoTemporalDenoisingControl**, int> get_VideoTemporalDenoisingControl;
    }
}
