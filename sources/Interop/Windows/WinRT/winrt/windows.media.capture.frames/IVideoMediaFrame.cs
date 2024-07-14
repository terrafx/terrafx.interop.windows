// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.capture.frames.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IVideoMediaFrame.xml' path='doc/member[@name="IVideoMediaFrame"]/*' />
[Guid("00DD4CCB-32BD-4FE1-A013-7CC13CF5DBCF")]
[NativeTypeName("struct IVideoMediaFrame : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IVideoMediaFrame : IVideoMediaFrame.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IVideoMediaFrame));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IVideoMediaFrame*, Guid*, void**, int>)(lpVtbl[0]))((IVideoMediaFrame*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IVideoMediaFrame*, uint>)(lpVtbl[1]))((IVideoMediaFrame*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IVideoMediaFrame*, uint>)(lpVtbl[2]))((IVideoMediaFrame*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IVideoMediaFrame*, uint*, Guid**, int>)(lpVtbl[3]))((IVideoMediaFrame*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IVideoMediaFrame*, HSTRING*, int>)(lpVtbl[4]))((IVideoMediaFrame*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IVideoMediaFrame*, TrustLevel*, int>)(lpVtbl[5]))((IVideoMediaFrame*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IVideoMediaFrame.xml' path='doc/member[@name="IVideoMediaFrame.get_FrameReference"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_FrameReference([NativeTypeName("ABI::Windows::Media::Capture::Frames::IMediaFrameReference **")] IMediaFrameReference** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IVideoMediaFrame*, IMediaFrameReference**, int>)(lpVtbl[6]))((IVideoMediaFrame*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IVideoMediaFrame.xml' path='doc/member[@name="IVideoMediaFrame.get_VideoFormat"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_VideoFormat([NativeTypeName("ABI::Windows::Media::Capture::Frames::IVideoMediaFrameFormat **")] IVideoMediaFrameFormat** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IVideoMediaFrame*, IVideoMediaFrameFormat**, int>)(lpVtbl[7]))((IVideoMediaFrame*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IVideoMediaFrame.xml' path='doc/member[@name="IVideoMediaFrame.get_SoftwareBitmap"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_SoftwareBitmap([NativeTypeName("ABI::Windows::Graphics::Imaging::ISoftwareBitmap **")] ISoftwareBitmap** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IVideoMediaFrame*, ISoftwareBitmap**, int>)(lpVtbl[8]))((IVideoMediaFrame*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IVideoMediaFrame.xml' path='doc/member[@name="IVideoMediaFrame.get_Direct3DSurface"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_Direct3DSurface([NativeTypeName("ABI::Windows::Graphics::DirectX::Direct3D11::IDirect3DSurface **")] IDirect3DSurface** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IVideoMediaFrame*, IDirect3DSurface**, int>)(lpVtbl[9]))((IVideoMediaFrame*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IVideoMediaFrame.xml' path='doc/member[@name="IVideoMediaFrame.get_CameraIntrinsics"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_CameraIntrinsics([NativeTypeName("ABI::Windows::Media::Devices::Core::ICameraIntrinsics **")] ICameraIntrinsics** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IVideoMediaFrame*, ICameraIntrinsics**, int>)(lpVtbl[10]))((IVideoMediaFrame*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IVideoMediaFrame.xml' path='doc/member[@name="IVideoMediaFrame.get_InfraredMediaFrame"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_InfraredMediaFrame([NativeTypeName("ABI::Windows::Media::Capture::Frames::IInfraredMediaFrame **")] IInfraredMediaFrame** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IVideoMediaFrame*, IInfraredMediaFrame**, int>)(lpVtbl[11]))((IVideoMediaFrame*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IVideoMediaFrame.xml' path='doc/member[@name="IVideoMediaFrame.get_DepthMediaFrame"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_DepthMediaFrame([NativeTypeName("ABI::Windows::Media::Capture::Frames::IDepthMediaFrame **")] IDepthMediaFrame** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IVideoMediaFrame*, IDepthMediaFrame**, int>)(lpVtbl[12]))((IVideoMediaFrame*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IVideoMediaFrame.xml' path='doc/member[@name="IVideoMediaFrame.GetVideoFrame"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetVideoFrame([NativeTypeName("ABI::Windows::Media::IVideoFrame **")] IVideoFrame** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IVideoMediaFrame*, IVideoFrame**, int>)(lpVtbl[13]))((IVideoMediaFrame*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_FrameReference([NativeTypeName("ABI::Windows::Media::Capture::Frames::IMediaFrameReference **")] IMediaFrameReference** value);

        [VtblIndex(7)]
        HRESULT get_VideoFormat([NativeTypeName("ABI::Windows::Media::Capture::Frames::IVideoMediaFrameFormat **")] IVideoMediaFrameFormat** value);

        [VtblIndex(8)]
        HRESULT get_SoftwareBitmap([NativeTypeName("ABI::Windows::Graphics::Imaging::ISoftwareBitmap **")] ISoftwareBitmap** value);

        [VtblIndex(9)]
        HRESULT get_Direct3DSurface([NativeTypeName("ABI::Windows::Graphics::DirectX::Direct3D11::IDirect3DSurface **")] IDirect3DSurface** value);

        [VtblIndex(10)]
        HRESULT get_CameraIntrinsics([NativeTypeName("ABI::Windows::Media::Devices::Core::ICameraIntrinsics **")] ICameraIntrinsics** value);

        [VtblIndex(11)]
        HRESULT get_InfraredMediaFrame([NativeTypeName("ABI::Windows::Media::Capture::Frames::IInfraredMediaFrame **")] IInfraredMediaFrame** value);

        [VtblIndex(12)]
        HRESULT get_DepthMediaFrame([NativeTypeName("ABI::Windows::Media::Capture::Frames::IDepthMediaFrame **")] IDepthMediaFrame** value);

        [VtblIndex(13)]
        HRESULT GetVideoFrame([NativeTypeName("ABI::Windows::Media::IVideoFrame **")] IVideoFrame** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Media::Capture::Frames::IMediaFrameReference **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMediaFrameReference**, int> get_FrameReference;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Capture::Frames::IVideoMediaFrameFormat **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVideoMediaFrameFormat**, int> get_VideoFormat;

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::Imaging::ISoftwareBitmap **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ISoftwareBitmap**, int> get_SoftwareBitmap;

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::DirectX::Direct3D11::IDirect3DSurface **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDirect3DSurface**, int> get_Direct3DSurface;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Devices::Core::ICameraIntrinsics **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ICameraIntrinsics**, int> get_CameraIntrinsics;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Capture::Frames::IInfraredMediaFrame **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IInfraredMediaFrame**, int> get_InfraredMediaFrame;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Capture::Frames::IDepthMediaFrame **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDepthMediaFrame**, int> get_DepthMediaFrame;

        [NativeTypeName("HRESULT (ABI::Windows::Media::IVideoFrame **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVideoFrame**, int> GetVideoFrame;
    }
}
