// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.capture.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IMediaCaptureSettings.xml' path='doc/member[@name="IMediaCaptureSettings"]/*' />
[Guid("1D83AAFE-6D45-4477-8DC4-AC5BC01C4091")]
[NativeTypeName("struct IMediaCaptureSettings : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IMediaCaptureSettings : IMediaCaptureSettings.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMediaCaptureSettings));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCaptureSettings*, Guid*, void**, int>)(lpVtbl[0]))((IMediaCaptureSettings*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCaptureSettings*, uint>)(lpVtbl[1]))((IMediaCaptureSettings*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCaptureSettings*, uint>)(lpVtbl[2]))((IMediaCaptureSettings*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCaptureSettings*, uint*, Guid**, int>)(lpVtbl[3]))((IMediaCaptureSettings*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCaptureSettings*, HSTRING*, int>)(lpVtbl[4]))((IMediaCaptureSettings*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCaptureSettings*, TrustLevel*, int>)(lpVtbl[5]))((IMediaCaptureSettings*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IMediaCaptureSettings.xml' path='doc/member[@name="IMediaCaptureSettings.get_AudioDeviceId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_AudioDeviceId(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCaptureSettings*, HSTRING*, int>)(lpVtbl[6]))((IMediaCaptureSettings*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaCaptureSettings.xml' path='doc/member[@name="IMediaCaptureSettings.get_VideoDeviceId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_VideoDeviceId(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCaptureSettings*, HSTRING*, int>)(lpVtbl[7]))((IMediaCaptureSettings*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaCaptureSettings.xml' path='doc/member[@name="IMediaCaptureSettings.get_StreamingCaptureMode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_StreamingCaptureMode([NativeTypeName("ABI::Windows::Media::Capture::StreamingCaptureMode *")] StreamingCaptureMode* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCaptureSettings*, StreamingCaptureMode*, int>)(lpVtbl[8]))((IMediaCaptureSettings*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaCaptureSettings.xml' path='doc/member[@name="IMediaCaptureSettings.get_PhotoCaptureSource"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_PhotoCaptureSource([NativeTypeName("ABI::Windows::Media::Capture::PhotoCaptureSource *")] PhotoCaptureSource* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCaptureSettings*, PhotoCaptureSource*, int>)(lpVtbl[9]))((IMediaCaptureSettings*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaCaptureSettings.xml' path='doc/member[@name="IMediaCaptureSettings.get_VideoDeviceCharacteristic"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_VideoDeviceCharacteristic([NativeTypeName("ABI::Windows::Media::Capture::VideoDeviceCharacteristic *")] VideoDeviceCharacteristic* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCaptureSettings*, VideoDeviceCharacteristic*, int>)(lpVtbl[10]))((IMediaCaptureSettings*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_AudioDeviceId(HSTRING* value);

        [VtblIndex(7)]
        HRESULT get_VideoDeviceId(HSTRING* value);

        [VtblIndex(8)]
        HRESULT get_StreamingCaptureMode([NativeTypeName("ABI::Windows::Media::Capture::StreamingCaptureMode *")] StreamingCaptureMode* value);

        [VtblIndex(9)]
        HRESULT get_PhotoCaptureSource([NativeTypeName("ABI::Windows::Media::Capture::PhotoCaptureSource *")] PhotoCaptureSource* value);

        [VtblIndex(10)]
        HRESULT get_VideoDeviceCharacteristic([NativeTypeName("ABI::Windows::Media::Capture::VideoDeviceCharacteristic *")] VideoDeviceCharacteristic* value);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_AudioDeviceId;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_VideoDeviceId;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Capture::StreamingCaptureMode *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, StreamingCaptureMode*, int> get_StreamingCaptureMode;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Capture::PhotoCaptureSource *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, PhotoCaptureSource*, int> get_PhotoCaptureSource;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Capture::VideoDeviceCharacteristic *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, VideoDeviceCharacteristic*, int> get_VideoDeviceCharacteristic;
    }
}
