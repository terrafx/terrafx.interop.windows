// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.devices.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IAdvancedVideoCaptureDeviceController4.xml' path='doc/member[@name="IAdvancedVideoCaptureDeviceController4"]/*' />
[Guid("EA9FBFAF-D371-41C3-9A17-824A87EBDFD2")]
[NativeTypeName("struct IAdvancedVideoCaptureDeviceController4 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAdvancedVideoCaptureDeviceController4 : IAdvancedVideoCaptureDeviceController4.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IAdvancedVideoCaptureDeviceController4);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdvancedVideoCaptureDeviceController4*, Guid*, void**, int>)(lpVtbl[0]))((IAdvancedVideoCaptureDeviceController4*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAdvancedVideoCaptureDeviceController4*, uint>)(lpVtbl[1]))((IAdvancedVideoCaptureDeviceController4*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAdvancedVideoCaptureDeviceController4*, uint>)(lpVtbl[2]))((IAdvancedVideoCaptureDeviceController4*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdvancedVideoCaptureDeviceController4*, uint*, Guid**, int>)(lpVtbl[3]))((IAdvancedVideoCaptureDeviceController4*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdvancedVideoCaptureDeviceController4*, HSTRING*, int>)(lpVtbl[4]))((IAdvancedVideoCaptureDeviceController4*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdvancedVideoCaptureDeviceController4*, TrustLevel*, int>)(lpVtbl[5]))((IAdvancedVideoCaptureDeviceController4*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IAdvancedVideoCaptureDeviceController4.xml' path='doc/member[@name="IAdvancedVideoCaptureDeviceController4.get_ExposurePriorityVideoControl"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_ExposurePriorityVideoControl([NativeTypeName("ABI::Windows::Media::Devices::IExposurePriorityVideoControl **")] IExposurePriorityVideoControl** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdvancedVideoCaptureDeviceController4*, IExposurePriorityVideoControl**, int>)(lpVtbl[6]))((IAdvancedVideoCaptureDeviceController4*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAdvancedVideoCaptureDeviceController4.xml' path='doc/member[@name="IAdvancedVideoCaptureDeviceController4.get_DesiredOptimization"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_DesiredOptimization([NativeTypeName("ABI::Windows::Media::Devices::MediaCaptureOptimization *")] MediaCaptureOptimization* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdvancedVideoCaptureDeviceController4*, MediaCaptureOptimization*, int>)(lpVtbl[7]))((IAdvancedVideoCaptureDeviceController4*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAdvancedVideoCaptureDeviceController4.xml' path='doc/member[@name="IAdvancedVideoCaptureDeviceController4.put_DesiredOptimization"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT put_DesiredOptimization([NativeTypeName("ABI::Windows::Media::Devices::MediaCaptureOptimization")] MediaCaptureOptimization value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdvancedVideoCaptureDeviceController4*, MediaCaptureOptimization, int>)(lpVtbl[8]))((IAdvancedVideoCaptureDeviceController4*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAdvancedVideoCaptureDeviceController4.xml' path='doc/member[@name="IAdvancedVideoCaptureDeviceController4.get_HdrVideoControl"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_HdrVideoControl([NativeTypeName("ABI::Windows::Media::Devices::IHdrVideoControl **")] IHdrVideoControl** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdvancedVideoCaptureDeviceController4*, IHdrVideoControl**, int>)(lpVtbl[9]))((IAdvancedVideoCaptureDeviceController4*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAdvancedVideoCaptureDeviceController4.xml' path='doc/member[@name="IAdvancedVideoCaptureDeviceController4.get_OpticalImageStabilizationControl"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_OpticalImageStabilizationControl([NativeTypeName("ABI::Windows::Media::Devices::IOpticalImageStabilizationControl **")] IOpticalImageStabilizationControl** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdvancedVideoCaptureDeviceController4*, IOpticalImageStabilizationControl**, int>)(lpVtbl[10]))((IAdvancedVideoCaptureDeviceController4*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAdvancedVideoCaptureDeviceController4.xml' path='doc/member[@name="IAdvancedVideoCaptureDeviceController4.get_AdvancedPhotoControl"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_AdvancedPhotoControl([NativeTypeName("ABI::Windows::Media::Devices::IAdvancedPhotoControl **")] IAdvancedPhotoControl** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdvancedVideoCaptureDeviceController4*, IAdvancedPhotoControl**, int>)(lpVtbl[11]))((IAdvancedVideoCaptureDeviceController4*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_ExposurePriorityVideoControl([NativeTypeName("ABI::Windows::Media::Devices::IExposurePriorityVideoControl **")] IExposurePriorityVideoControl** value);

        [VtblIndex(7)]
        HRESULT get_DesiredOptimization([NativeTypeName("ABI::Windows::Media::Devices::MediaCaptureOptimization *")] MediaCaptureOptimization* value);

        [VtblIndex(8)]
        HRESULT put_DesiredOptimization([NativeTypeName("ABI::Windows::Media::Devices::MediaCaptureOptimization")] MediaCaptureOptimization value);

        [VtblIndex(9)]
        HRESULT get_HdrVideoControl([NativeTypeName("ABI::Windows::Media::Devices::IHdrVideoControl **")] IHdrVideoControl** value);

        [VtblIndex(10)]
        HRESULT get_OpticalImageStabilizationControl([NativeTypeName("ABI::Windows::Media::Devices::IOpticalImageStabilizationControl **")] IOpticalImageStabilizationControl** value);

        [VtblIndex(11)]
        HRESULT get_AdvancedPhotoControl([NativeTypeName("ABI::Windows::Media::Devices::IAdvancedPhotoControl **")] IAdvancedPhotoControl** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Media::Devices::IExposurePriorityVideoControl **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IExposurePriorityVideoControl**, int> get_ExposurePriorityVideoControl;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Devices::MediaCaptureOptimization *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, MediaCaptureOptimization*, int> get_DesiredOptimization;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Devices::MediaCaptureOptimization) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, MediaCaptureOptimization, int> put_DesiredOptimization;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Devices::IHdrVideoControl **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IHdrVideoControl**, int> get_HdrVideoControl;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Devices::IOpticalImageStabilizationControl **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IOpticalImageStabilizationControl**, int> get_OpticalImageStabilizationControl;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Devices::IAdvancedPhotoControl **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAdvancedPhotoControl**, int> get_AdvancedPhotoControl;
    }
}
