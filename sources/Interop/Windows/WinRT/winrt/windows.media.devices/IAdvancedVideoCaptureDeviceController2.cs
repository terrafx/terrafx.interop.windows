// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.devices.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IAdvancedVideoCaptureDeviceController2.xml' path='doc/member[@name="IAdvancedVideoCaptureDeviceController2"]/*' />
[Guid("8BB94F8F-F11A-43DB-B402-11930B80AE56")]
[NativeTypeName("struct IAdvancedVideoCaptureDeviceController2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAdvancedVideoCaptureDeviceController2 : IAdvancedVideoCaptureDeviceController2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IAdvancedVideoCaptureDeviceController2);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdvancedVideoCaptureDeviceController2*, Guid*, void**, int>)(lpVtbl[0]))((IAdvancedVideoCaptureDeviceController2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAdvancedVideoCaptureDeviceController2*, uint>)(lpVtbl[1]))((IAdvancedVideoCaptureDeviceController2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAdvancedVideoCaptureDeviceController2*, uint>)(lpVtbl[2]))((IAdvancedVideoCaptureDeviceController2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdvancedVideoCaptureDeviceController2*, uint*, Guid**, int>)(lpVtbl[3]))((IAdvancedVideoCaptureDeviceController2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdvancedVideoCaptureDeviceController2*, HSTRING*, int>)(lpVtbl[4]))((IAdvancedVideoCaptureDeviceController2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdvancedVideoCaptureDeviceController2*, TrustLevel*, int>)(lpVtbl[5]))((IAdvancedVideoCaptureDeviceController2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IAdvancedVideoCaptureDeviceController2.xml' path='doc/member[@name="IAdvancedVideoCaptureDeviceController2.get_LowLagPhotoSequence"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_LowLagPhotoSequence([NativeTypeName("ABI::Windows::Media::Devices::ILowLagPhotoSequenceControl **")] ILowLagPhotoSequenceControl** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdvancedVideoCaptureDeviceController2*, ILowLagPhotoSequenceControl**, int>)(lpVtbl[6]))((IAdvancedVideoCaptureDeviceController2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAdvancedVideoCaptureDeviceController2.xml' path='doc/member[@name="IAdvancedVideoCaptureDeviceController2.get_LowLagPhoto"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_LowLagPhoto([NativeTypeName("ABI::Windows::Media::Devices::ILowLagPhotoControl **")] ILowLagPhotoControl** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdvancedVideoCaptureDeviceController2*, ILowLagPhotoControl**, int>)(lpVtbl[7]))((IAdvancedVideoCaptureDeviceController2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAdvancedVideoCaptureDeviceController2.xml' path='doc/member[@name="IAdvancedVideoCaptureDeviceController2.get_SceneModeControl"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_SceneModeControl([NativeTypeName("ABI::Windows::Media::Devices::ISceneModeControl **")] ISceneModeControl** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdvancedVideoCaptureDeviceController2*, ISceneModeControl**, int>)(lpVtbl[8]))((IAdvancedVideoCaptureDeviceController2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAdvancedVideoCaptureDeviceController2.xml' path='doc/member[@name="IAdvancedVideoCaptureDeviceController2.get_TorchControl"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_TorchControl([NativeTypeName("ABI::Windows::Media::Devices::ITorchControl **")] ITorchControl** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdvancedVideoCaptureDeviceController2*, ITorchControl**, int>)(lpVtbl[9]))((IAdvancedVideoCaptureDeviceController2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAdvancedVideoCaptureDeviceController2.xml' path='doc/member[@name="IAdvancedVideoCaptureDeviceController2.get_FlashControl"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_FlashControl([NativeTypeName("ABI::Windows::Media::Devices::IFlashControl **")] IFlashControl** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdvancedVideoCaptureDeviceController2*, IFlashControl**, int>)(lpVtbl[10]))((IAdvancedVideoCaptureDeviceController2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAdvancedVideoCaptureDeviceController2.xml' path='doc/member[@name="IAdvancedVideoCaptureDeviceController2.get_WhiteBalanceControl"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_WhiteBalanceControl([NativeTypeName("ABI::Windows::Media::Devices::IWhiteBalanceControl **")] IWhiteBalanceControl** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdvancedVideoCaptureDeviceController2*, IWhiteBalanceControl**, int>)(lpVtbl[11]))((IAdvancedVideoCaptureDeviceController2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAdvancedVideoCaptureDeviceController2.xml' path='doc/member[@name="IAdvancedVideoCaptureDeviceController2.get_ExposureControl"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_ExposureControl([NativeTypeName("ABI::Windows::Media::Devices::IExposureControl **")] IExposureControl** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdvancedVideoCaptureDeviceController2*, IExposureControl**, int>)(lpVtbl[12]))((IAdvancedVideoCaptureDeviceController2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAdvancedVideoCaptureDeviceController2.xml' path='doc/member[@name="IAdvancedVideoCaptureDeviceController2.get_FocusControl"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_FocusControl([NativeTypeName("ABI::Windows::Media::Devices::IFocusControl **")] IFocusControl** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdvancedVideoCaptureDeviceController2*, IFocusControl**, int>)(lpVtbl[13]))((IAdvancedVideoCaptureDeviceController2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAdvancedVideoCaptureDeviceController2.xml' path='doc/member[@name="IAdvancedVideoCaptureDeviceController2.get_ExposureCompensationControl"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_ExposureCompensationControl([NativeTypeName("ABI::Windows::Media::Devices::IExposureCompensationControl **")] IExposureCompensationControl** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdvancedVideoCaptureDeviceController2*, IExposureCompensationControl**, int>)(lpVtbl[14]))((IAdvancedVideoCaptureDeviceController2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAdvancedVideoCaptureDeviceController2.xml' path='doc/member[@name="IAdvancedVideoCaptureDeviceController2.get_IsoSpeedControl"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_IsoSpeedControl([NativeTypeName("ABI::Windows::Media::Devices::IIsoSpeedControl **")] IIsoSpeedControl** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdvancedVideoCaptureDeviceController2*, IIsoSpeedControl**, int>)(lpVtbl[15]))((IAdvancedVideoCaptureDeviceController2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAdvancedVideoCaptureDeviceController2.xml' path='doc/member[@name="IAdvancedVideoCaptureDeviceController2.get_RegionsOfInterestControl"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_RegionsOfInterestControl([NativeTypeName("ABI::Windows::Media::Devices::IRegionsOfInterestControl **")] IRegionsOfInterestControl** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdvancedVideoCaptureDeviceController2*, IRegionsOfInterestControl**, int>)(lpVtbl[16]))((IAdvancedVideoCaptureDeviceController2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAdvancedVideoCaptureDeviceController2.xml' path='doc/member[@name="IAdvancedVideoCaptureDeviceController2.get_PrimaryUse"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_PrimaryUse([NativeTypeName("ABI::Windows::Media::Devices::CaptureUse *")] CaptureUse* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdvancedVideoCaptureDeviceController2*, CaptureUse*, int>)(lpVtbl[17]))((IAdvancedVideoCaptureDeviceController2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAdvancedVideoCaptureDeviceController2.xml' path='doc/member[@name="IAdvancedVideoCaptureDeviceController2.put_PrimaryUse"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT put_PrimaryUse([NativeTypeName("ABI::Windows::Media::Devices::CaptureUse")] CaptureUse value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdvancedVideoCaptureDeviceController2*, CaptureUse, int>)(lpVtbl[18]))((IAdvancedVideoCaptureDeviceController2*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_LowLagPhotoSequence([NativeTypeName("ABI::Windows::Media::Devices::ILowLagPhotoSequenceControl **")] ILowLagPhotoSequenceControl** value);

        [VtblIndex(7)]
        HRESULT get_LowLagPhoto([NativeTypeName("ABI::Windows::Media::Devices::ILowLagPhotoControl **")] ILowLagPhotoControl** value);

        [VtblIndex(8)]
        HRESULT get_SceneModeControl([NativeTypeName("ABI::Windows::Media::Devices::ISceneModeControl **")] ISceneModeControl** value);

        [VtblIndex(9)]
        HRESULT get_TorchControl([NativeTypeName("ABI::Windows::Media::Devices::ITorchControl **")] ITorchControl** value);

        [VtblIndex(10)]
        HRESULT get_FlashControl([NativeTypeName("ABI::Windows::Media::Devices::IFlashControl **")] IFlashControl** value);

        [VtblIndex(11)]
        HRESULT get_WhiteBalanceControl([NativeTypeName("ABI::Windows::Media::Devices::IWhiteBalanceControl **")] IWhiteBalanceControl** value);

        [VtblIndex(12)]
        HRESULT get_ExposureControl([NativeTypeName("ABI::Windows::Media::Devices::IExposureControl **")] IExposureControl** value);

        [VtblIndex(13)]
        HRESULT get_FocusControl([NativeTypeName("ABI::Windows::Media::Devices::IFocusControl **")] IFocusControl** value);

        [VtblIndex(14)]
        HRESULT get_ExposureCompensationControl([NativeTypeName("ABI::Windows::Media::Devices::IExposureCompensationControl **")] IExposureCompensationControl** value);

        [VtblIndex(15)]
        HRESULT get_IsoSpeedControl([NativeTypeName("ABI::Windows::Media::Devices::IIsoSpeedControl **")] IIsoSpeedControl** value);

        [VtblIndex(16)]
        HRESULT get_RegionsOfInterestControl([NativeTypeName("ABI::Windows::Media::Devices::IRegionsOfInterestControl **")] IRegionsOfInterestControl** value);

        [VtblIndex(17)]
        HRESULT get_PrimaryUse([NativeTypeName("ABI::Windows::Media::Devices::CaptureUse *")] CaptureUse* value);

        [VtblIndex(18)]
        HRESULT put_PrimaryUse([NativeTypeName("ABI::Windows::Media::Devices::CaptureUse")] CaptureUse value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Media::Devices::ILowLagPhotoSequenceControl **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ILowLagPhotoSequenceControl**, int> get_LowLagPhotoSequence;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Devices::ILowLagPhotoControl **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ILowLagPhotoControl**, int> get_LowLagPhoto;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Devices::ISceneModeControl **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ISceneModeControl**, int> get_SceneModeControl;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Devices::ITorchControl **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITorchControl**, int> get_TorchControl;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Devices::IFlashControl **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IFlashControl**, int> get_FlashControl;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Devices::IWhiteBalanceControl **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IWhiteBalanceControl**, int> get_WhiteBalanceControl;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Devices::IExposureControl **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IExposureControl**, int> get_ExposureControl;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Devices::IFocusControl **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IFocusControl**, int> get_FocusControl;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Devices::IExposureCompensationControl **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IExposureCompensationControl**, int> get_ExposureCompensationControl;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Devices::IIsoSpeedControl **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IIsoSpeedControl**, int> get_IsoSpeedControl;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Devices::IRegionsOfInterestControl **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IRegionsOfInterestControl**, int> get_RegionsOfInterestControl;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Devices::CaptureUse *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, CaptureUse*, int> get_PrimaryUse;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Devices::CaptureUse) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, CaptureUse, int> put_PrimaryUse;
    }
}
