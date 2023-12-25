// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.devices.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IVideoDeviceController.xml' path='doc/member[@name="IVideoDeviceController"]/*' />
[Guid("99555575-2E2E-40B8-B6C7-F82D10013210")]
[NativeTypeName("struct IVideoDeviceController : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IVideoDeviceController : IVideoDeviceController.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IVideoDeviceController));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IVideoDeviceController*, Guid*, void**, int>)(lpVtbl[0]))((IVideoDeviceController*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IVideoDeviceController*, uint>)(lpVtbl[1]))((IVideoDeviceController*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IVideoDeviceController*, uint>)(lpVtbl[2]))((IVideoDeviceController*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IVideoDeviceController*, uint*, Guid**, int>)(lpVtbl[3]))((IVideoDeviceController*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IVideoDeviceController*, HSTRING*, int>)(lpVtbl[4]))((IVideoDeviceController*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IVideoDeviceController*, TrustLevel*, int>)(lpVtbl[5]))((IVideoDeviceController*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IVideoDeviceController.xml' path='doc/member[@name="IVideoDeviceController.get_Brightness"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Brightness([NativeTypeName("ABI::Windows::Media::Devices::IMediaDeviceControl **")] IMediaDeviceControl** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IVideoDeviceController*, IMediaDeviceControl**, int>)(lpVtbl[6]))((IVideoDeviceController*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IVideoDeviceController.xml' path='doc/member[@name="IVideoDeviceController.get_Contrast"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Contrast([NativeTypeName("ABI::Windows::Media::Devices::IMediaDeviceControl **")] IMediaDeviceControl** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IVideoDeviceController*, IMediaDeviceControl**, int>)(lpVtbl[7]))((IVideoDeviceController*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IVideoDeviceController.xml' path='doc/member[@name="IVideoDeviceController.get_Hue"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Hue([NativeTypeName("ABI::Windows::Media::Devices::IMediaDeviceControl **")] IMediaDeviceControl** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IVideoDeviceController*, IMediaDeviceControl**, int>)(lpVtbl[8]))((IVideoDeviceController*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IVideoDeviceController.xml' path='doc/member[@name="IVideoDeviceController.get_WhiteBalance"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_WhiteBalance([NativeTypeName("ABI::Windows::Media::Devices::IMediaDeviceControl **")] IMediaDeviceControl** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IVideoDeviceController*, IMediaDeviceControl**, int>)(lpVtbl[9]))((IVideoDeviceController*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IVideoDeviceController.xml' path='doc/member[@name="IVideoDeviceController.get_BacklightCompensation"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_BacklightCompensation([NativeTypeName("ABI::Windows::Media::Devices::IMediaDeviceControl **")] IMediaDeviceControl** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IVideoDeviceController*, IMediaDeviceControl**, int>)(lpVtbl[10]))((IVideoDeviceController*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IVideoDeviceController.xml' path='doc/member[@name="IVideoDeviceController.get_Pan"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_Pan([NativeTypeName("ABI::Windows::Media::Devices::IMediaDeviceControl **")] IMediaDeviceControl** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IVideoDeviceController*, IMediaDeviceControl**, int>)(lpVtbl[11]))((IVideoDeviceController*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IVideoDeviceController.xml' path='doc/member[@name="IVideoDeviceController.get_Tilt"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_Tilt([NativeTypeName("ABI::Windows::Media::Devices::IMediaDeviceControl **")] IMediaDeviceControl** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IVideoDeviceController*, IMediaDeviceControl**, int>)(lpVtbl[12]))((IVideoDeviceController*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IVideoDeviceController.xml' path='doc/member[@name="IVideoDeviceController.get_Zoom"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_Zoom([NativeTypeName("ABI::Windows::Media::Devices::IMediaDeviceControl **")] IMediaDeviceControl** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IVideoDeviceController*, IMediaDeviceControl**, int>)(lpVtbl[13]))((IVideoDeviceController*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IVideoDeviceController.xml' path='doc/member[@name="IVideoDeviceController.get_Roll"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_Roll([NativeTypeName("ABI::Windows::Media::Devices::IMediaDeviceControl **")] IMediaDeviceControl** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IVideoDeviceController*, IMediaDeviceControl**, int>)(lpVtbl[14]))((IVideoDeviceController*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IVideoDeviceController.xml' path='doc/member[@name="IVideoDeviceController.get_Exposure"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_Exposure([NativeTypeName("ABI::Windows::Media::Devices::IMediaDeviceControl **")] IMediaDeviceControl** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IVideoDeviceController*, IMediaDeviceControl**, int>)(lpVtbl[15]))((IVideoDeviceController*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IVideoDeviceController.xml' path='doc/member[@name="IVideoDeviceController.get_Focus"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_Focus([NativeTypeName("ABI::Windows::Media::Devices::IMediaDeviceControl **")] IMediaDeviceControl** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IVideoDeviceController*, IMediaDeviceControl**, int>)(lpVtbl[16]))((IVideoDeviceController*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IVideoDeviceController.xml' path='doc/member[@name="IVideoDeviceController.TrySetPowerlineFrequency"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT TrySetPowerlineFrequency([NativeTypeName("ABI::Windows::Media::Capture::PowerlineFrequency")] PowerlineFrequency value, [NativeTypeName("boolean *")] byte* succeeded)
    {
        return ((delegate* unmanaged[MemberFunction]<IVideoDeviceController*, PowerlineFrequency, byte*, int>)(lpVtbl[17]))((IVideoDeviceController*)Unsafe.AsPointer(ref this), value, succeeded);
    }

    /// <include file='IVideoDeviceController.xml' path='doc/member[@name="IVideoDeviceController.TryGetPowerlineFrequency"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT TryGetPowerlineFrequency([NativeTypeName("ABI::Windows::Media::Capture::PowerlineFrequency *")] PowerlineFrequency* value, [NativeTypeName("boolean *")] byte* succeeded)
    {
        return ((delegate* unmanaged[MemberFunction]<IVideoDeviceController*, PowerlineFrequency*, byte*, int>)(lpVtbl[18]))((IVideoDeviceController*)Unsafe.AsPointer(ref this), value, succeeded);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Brightness([NativeTypeName("ABI::Windows::Media::Devices::IMediaDeviceControl **")] IMediaDeviceControl** value);

        [VtblIndex(7)]
        HRESULT get_Contrast([NativeTypeName("ABI::Windows::Media::Devices::IMediaDeviceControl **")] IMediaDeviceControl** value);

        [VtblIndex(8)]
        HRESULT get_Hue([NativeTypeName("ABI::Windows::Media::Devices::IMediaDeviceControl **")] IMediaDeviceControl** value);

        [VtblIndex(9)]
        HRESULT get_WhiteBalance([NativeTypeName("ABI::Windows::Media::Devices::IMediaDeviceControl **")] IMediaDeviceControl** value);

        [VtblIndex(10)]
        HRESULT get_BacklightCompensation([NativeTypeName("ABI::Windows::Media::Devices::IMediaDeviceControl **")] IMediaDeviceControl** value);

        [VtblIndex(11)]
        HRESULT get_Pan([NativeTypeName("ABI::Windows::Media::Devices::IMediaDeviceControl **")] IMediaDeviceControl** value);

        [VtblIndex(12)]
        HRESULT get_Tilt([NativeTypeName("ABI::Windows::Media::Devices::IMediaDeviceControl **")] IMediaDeviceControl** value);

        [VtblIndex(13)]
        HRESULT get_Zoom([NativeTypeName("ABI::Windows::Media::Devices::IMediaDeviceControl **")] IMediaDeviceControl** value);

        [VtblIndex(14)]
        HRESULT get_Roll([NativeTypeName("ABI::Windows::Media::Devices::IMediaDeviceControl **")] IMediaDeviceControl** value);

        [VtblIndex(15)]
        HRESULT get_Exposure([NativeTypeName("ABI::Windows::Media::Devices::IMediaDeviceControl **")] IMediaDeviceControl** value);

        [VtblIndex(16)]
        HRESULT get_Focus([NativeTypeName("ABI::Windows::Media::Devices::IMediaDeviceControl **")] IMediaDeviceControl** value);

        [VtblIndex(17)]
        HRESULT TrySetPowerlineFrequency([NativeTypeName("ABI::Windows::Media::Capture::PowerlineFrequency")] PowerlineFrequency value, [NativeTypeName("boolean *")] byte* succeeded);

        [VtblIndex(18)]
        HRESULT TryGetPowerlineFrequency([NativeTypeName("ABI::Windows::Media::Capture::PowerlineFrequency *")] PowerlineFrequency* value, [NativeTypeName("boolean *")] byte* succeeded);
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

        [NativeTypeName("HRESULT (ABI::Windows::Media::Devices::IMediaDeviceControl **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMediaDeviceControl**, int> get_Brightness;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Devices::IMediaDeviceControl **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMediaDeviceControl**, int> get_Contrast;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Devices::IMediaDeviceControl **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMediaDeviceControl**, int> get_Hue;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Devices::IMediaDeviceControl **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMediaDeviceControl**, int> get_WhiteBalance;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Devices::IMediaDeviceControl **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMediaDeviceControl**, int> get_BacklightCompensation;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Devices::IMediaDeviceControl **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMediaDeviceControl**, int> get_Pan;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Devices::IMediaDeviceControl **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMediaDeviceControl**, int> get_Tilt;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Devices::IMediaDeviceControl **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMediaDeviceControl**, int> get_Zoom;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Devices::IMediaDeviceControl **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMediaDeviceControl**, int> get_Roll;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Devices::IMediaDeviceControl **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMediaDeviceControl**, int> get_Exposure;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Devices::IMediaDeviceControl **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMediaDeviceControl**, int> get_Focus;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Capture::PowerlineFrequency, boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, PowerlineFrequency, byte*, int> TrySetPowerlineFrequency;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Capture::PowerlineFrequency *, boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, PowerlineFrequency*, byte*, int> TryGetPowerlineFrequency;
    }
}
