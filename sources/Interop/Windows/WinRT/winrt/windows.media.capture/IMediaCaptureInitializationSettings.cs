// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.capture.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IMediaCaptureInitializationSettings.xml' path='doc/member[@name="IMediaCaptureInitializationSettings"]/*' />
[Guid("9782BA70-EA65-4900-9356-8CA887726884")]
[NativeTypeName("struct IMediaCaptureInitializationSettings : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IMediaCaptureInitializationSettings : IMediaCaptureInitializationSettings.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMediaCaptureInitializationSettings));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCaptureInitializationSettings*, Guid*, void**, int>)(lpVtbl[0]))((IMediaCaptureInitializationSettings*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCaptureInitializationSettings*, uint>)(lpVtbl[1]))((IMediaCaptureInitializationSettings*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCaptureInitializationSettings*, uint>)(lpVtbl[2]))((IMediaCaptureInitializationSettings*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCaptureInitializationSettings*, uint*, Guid**, int>)(lpVtbl[3]))((IMediaCaptureInitializationSettings*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCaptureInitializationSettings*, HSTRING*, int>)(lpVtbl[4]))((IMediaCaptureInitializationSettings*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCaptureInitializationSettings*, TrustLevel*, int>)(lpVtbl[5]))((IMediaCaptureInitializationSettings*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IMediaCaptureInitializationSettings.xml' path='doc/member[@name="IMediaCaptureInitializationSettings.put_AudioDeviceId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT put_AudioDeviceId(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCaptureInitializationSettings*, HSTRING, int>)(lpVtbl[6]))((IMediaCaptureInitializationSettings*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaCaptureInitializationSettings.xml' path='doc/member[@name="IMediaCaptureInitializationSettings.get_AudioDeviceId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_AudioDeviceId(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCaptureInitializationSettings*, HSTRING*, int>)(lpVtbl[7]))((IMediaCaptureInitializationSettings*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaCaptureInitializationSettings.xml' path='doc/member[@name="IMediaCaptureInitializationSettings.put_VideoDeviceId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT put_VideoDeviceId(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCaptureInitializationSettings*, HSTRING, int>)(lpVtbl[8]))((IMediaCaptureInitializationSettings*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaCaptureInitializationSettings.xml' path='doc/member[@name="IMediaCaptureInitializationSettings.get_VideoDeviceId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_VideoDeviceId(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCaptureInitializationSettings*, HSTRING*, int>)(lpVtbl[9]))((IMediaCaptureInitializationSettings*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaCaptureInitializationSettings.xml' path='doc/member[@name="IMediaCaptureInitializationSettings.put_StreamingCaptureMode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT put_StreamingCaptureMode([NativeTypeName("ABI::Windows::Media::Capture::StreamingCaptureMode")] StreamingCaptureMode value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCaptureInitializationSettings*, StreamingCaptureMode, int>)(lpVtbl[10]))((IMediaCaptureInitializationSettings*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaCaptureInitializationSettings.xml' path='doc/member[@name="IMediaCaptureInitializationSettings.get_StreamingCaptureMode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_StreamingCaptureMode([NativeTypeName("ABI::Windows::Media::Capture::StreamingCaptureMode *")] StreamingCaptureMode* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCaptureInitializationSettings*, StreamingCaptureMode*, int>)(lpVtbl[11]))((IMediaCaptureInitializationSettings*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaCaptureInitializationSettings.xml' path='doc/member[@name="IMediaCaptureInitializationSettings.put_PhotoCaptureSource"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT put_PhotoCaptureSource([NativeTypeName("ABI::Windows::Media::Capture::PhotoCaptureSource")] PhotoCaptureSource value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCaptureInitializationSettings*, PhotoCaptureSource, int>)(lpVtbl[12]))((IMediaCaptureInitializationSettings*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaCaptureInitializationSettings.xml' path='doc/member[@name="IMediaCaptureInitializationSettings.get_PhotoCaptureSource"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_PhotoCaptureSource([NativeTypeName("ABI::Windows::Media::Capture::PhotoCaptureSource *")] PhotoCaptureSource* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCaptureInitializationSettings*, PhotoCaptureSource*, int>)(lpVtbl[13]))((IMediaCaptureInitializationSettings*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT put_AudioDeviceId(HSTRING value);

        [VtblIndex(7)]
        HRESULT get_AudioDeviceId(HSTRING* value);

        [VtblIndex(8)]
        HRESULT put_VideoDeviceId(HSTRING value);

        [VtblIndex(9)]
        HRESULT get_VideoDeviceId(HSTRING* value);

        [VtblIndex(10)]
        HRESULT put_StreamingCaptureMode([NativeTypeName("ABI::Windows::Media::Capture::StreamingCaptureMode")] StreamingCaptureMode value);

        [VtblIndex(11)]
        HRESULT get_StreamingCaptureMode([NativeTypeName("ABI::Windows::Media::Capture::StreamingCaptureMode *")] StreamingCaptureMode* value);

        [VtblIndex(12)]
        HRESULT put_PhotoCaptureSource([NativeTypeName("ABI::Windows::Media::Capture::PhotoCaptureSource")] PhotoCaptureSource value);

        [VtblIndex(13)]
        HRESULT get_PhotoCaptureSource([NativeTypeName("ABI::Windows::Media::Capture::PhotoCaptureSource *")] PhotoCaptureSource* value);
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

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_AudioDeviceId;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_AudioDeviceId;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_VideoDeviceId;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_VideoDeviceId;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Capture::StreamingCaptureMode) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, StreamingCaptureMode, int> put_StreamingCaptureMode;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Capture::StreamingCaptureMode *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, StreamingCaptureMode*, int> get_StreamingCaptureMode;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Capture::PhotoCaptureSource) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, PhotoCaptureSource, int> put_PhotoCaptureSource;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Capture::PhotoCaptureSource *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, PhotoCaptureSource*, int> get_PhotoCaptureSource;
    }
}
