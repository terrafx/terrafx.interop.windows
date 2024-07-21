// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.capture.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IAppCaptureSettings4.xml' path='doc/member[@name="IAppCaptureSettings4"]/*' />
[Guid("07C2774C-1A81-482F-A244-049D95F25B0B")]
[NativeTypeName("struct IAppCaptureSettings4 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAppCaptureSettings4 : IAppCaptureSettings4.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppCaptureSettings4));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppCaptureSettings4*, Guid*, void**, int>)(lpVtbl[0]))((IAppCaptureSettings4*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppCaptureSettings4*, uint>)(lpVtbl[1]))((IAppCaptureSettings4*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppCaptureSettings4*, uint>)(lpVtbl[2]))((IAppCaptureSettings4*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppCaptureSettings4*, uint*, Guid**, int>)(lpVtbl[3]))((IAppCaptureSettings4*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppCaptureSettings4*, HSTRING*, int>)(lpVtbl[4]))((IAppCaptureSettings4*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppCaptureSettings4*, TrustLevel*, int>)(lpVtbl[5]))((IAppCaptureSettings4*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IAppCaptureSettings4.xml' path='doc/member[@name="IAppCaptureSettings4.put_IsMicrophoneCaptureEnabledByDefault"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT put_IsMicrophoneCaptureEnabledByDefault([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppCaptureSettings4*, byte, int>)(lpVtbl[6]))((IAppCaptureSettings4*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppCaptureSettings4.xml' path='doc/member[@name="IAppCaptureSettings4.get_IsMicrophoneCaptureEnabledByDefault"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_IsMicrophoneCaptureEnabledByDefault([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppCaptureSettings4*, byte*, int>)(lpVtbl[7]))((IAppCaptureSettings4*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppCaptureSettings4.xml' path='doc/member[@name="IAppCaptureSettings4.put_SystemAudioGain"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT put_SystemAudioGain(double value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppCaptureSettings4*, double, int>)(lpVtbl[8]))((IAppCaptureSettings4*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppCaptureSettings4.xml' path='doc/member[@name="IAppCaptureSettings4.get_SystemAudioGain"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_SystemAudioGain(double* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppCaptureSettings4*, double*, int>)(lpVtbl[9]))((IAppCaptureSettings4*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppCaptureSettings4.xml' path='doc/member[@name="IAppCaptureSettings4.put_MicrophoneGain"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT put_MicrophoneGain(double value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppCaptureSettings4*, double, int>)(lpVtbl[10]))((IAppCaptureSettings4*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppCaptureSettings4.xml' path='doc/member[@name="IAppCaptureSettings4.get_MicrophoneGain"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_MicrophoneGain(double* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppCaptureSettings4*, double*, int>)(lpVtbl[11]))((IAppCaptureSettings4*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppCaptureSettings4.xml' path='doc/member[@name="IAppCaptureSettings4.put_VideoEncodingFrameRateMode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT put_VideoEncodingFrameRateMode([NativeTypeName("ABI::Windows::Media::Capture::AppCaptureVideoEncodingFrameRateMode")] AppCaptureVideoEncodingFrameRateMode value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppCaptureSettings4*, AppCaptureVideoEncodingFrameRateMode, int>)(lpVtbl[12]))((IAppCaptureSettings4*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppCaptureSettings4.xml' path='doc/member[@name="IAppCaptureSettings4.get_VideoEncodingFrameRateMode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_VideoEncodingFrameRateMode([NativeTypeName("ABI::Windows::Media::Capture::AppCaptureVideoEncodingFrameRateMode *")] AppCaptureVideoEncodingFrameRateMode* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppCaptureSettings4*, AppCaptureVideoEncodingFrameRateMode*, int>)(lpVtbl[13]))((IAppCaptureSettings4*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT put_IsMicrophoneCaptureEnabledByDefault([NativeTypeName("boolean")] byte value);

        [VtblIndex(7)]
        HRESULT get_IsMicrophoneCaptureEnabledByDefault([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(8)]
        HRESULT put_SystemAudioGain(double value);

        [VtblIndex(9)]
        HRESULT get_SystemAudioGain(double* value);

        [VtblIndex(10)]
        HRESULT put_MicrophoneGain(double value);

        [VtblIndex(11)]
        HRESULT get_MicrophoneGain(double* value);

        [VtblIndex(12)]
        HRESULT put_VideoEncodingFrameRateMode([NativeTypeName("ABI::Windows::Media::Capture::AppCaptureVideoEncodingFrameRateMode")] AppCaptureVideoEncodingFrameRateMode value);

        [VtblIndex(13)]
        HRESULT get_VideoEncodingFrameRateMode([NativeTypeName("ABI::Windows::Media::Capture::AppCaptureVideoEncodingFrameRateMode *")] AppCaptureVideoEncodingFrameRateMode* value);
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

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_IsMicrophoneCaptureEnabledByDefault;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsMicrophoneCaptureEnabledByDefault;

        [NativeTypeName("HRESULT (DOUBLE) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, double, int> put_SystemAudioGain;

        [NativeTypeName("HRESULT (DOUBLE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, double*, int> get_SystemAudioGain;

        [NativeTypeName("HRESULT (DOUBLE) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, double, int> put_MicrophoneGain;

        [NativeTypeName("HRESULT (DOUBLE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, double*, int> get_MicrophoneGain;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Capture::AppCaptureVideoEncodingFrameRateMode) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, AppCaptureVideoEncodingFrameRateMode, int> put_VideoEncodingFrameRateMode;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Capture::AppCaptureVideoEncodingFrameRateMode *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, AppCaptureVideoEncodingFrameRateMode*, int> get_VideoEncodingFrameRateMode;
    }
}
