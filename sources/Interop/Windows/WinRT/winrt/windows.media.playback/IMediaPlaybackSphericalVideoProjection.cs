// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.playback.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IMediaPlaybackSphericalVideoProjection.xml' path='doc/member[@name="IMediaPlaybackSphericalVideoProjection"]/*' />
[Guid("D405B37C-6F0E-4661-B8EE-D487BA9752D5")]
[NativeTypeName("struct IMediaPlaybackSphericalVideoProjection : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IMediaPlaybackSphericalVideoProjection : IMediaPlaybackSphericalVideoProjection.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMediaPlaybackSphericalVideoProjection));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackSphericalVideoProjection*, Guid*, void**, int>)(lpVtbl[0]))((IMediaPlaybackSphericalVideoProjection*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackSphericalVideoProjection*, uint>)(lpVtbl[1]))((IMediaPlaybackSphericalVideoProjection*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackSphericalVideoProjection*, uint>)(lpVtbl[2]))((IMediaPlaybackSphericalVideoProjection*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackSphericalVideoProjection*, uint*, Guid**, int>)(lpVtbl[3]))((IMediaPlaybackSphericalVideoProjection*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackSphericalVideoProjection*, HSTRING*, int>)(lpVtbl[4]))((IMediaPlaybackSphericalVideoProjection*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackSphericalVideoProjection*, TrustLevel*, int>)(lpVtbl[5]))((IMediaPlaybackSphericalVideoProjection*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IMediaPlaybackSphericalVideoProjection.xml' path='doc/member[@name="IMediaPlaybackSphericalVideoProjection.get_IsEnabled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_IsEnabled([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackSphericalVideoProjection*, byte*, int>)(lpVtbl[6]))((IMediaPlaybackSphericalVideoProjection*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaPlaybackSphericalVideoProjection.xml' path='doc/member[@name="IMediaPlaybackSphericalVideoProjection.put_IsEnabled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_IsEnabled([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackSphericalVideoProjection*, byte, int>)(lpVtbl[7]))((IMediaPlaybackSphericalVideoProjection*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaPlaybackSphericalVideoProjection.xml' path='doc/member[@name="IMediaPlaybackSphericalVideoProjection.get_FrameFormat"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_FrameFormat([NativeTypeName("ABI::Windows::Media::MediaProperties::SphericalVideoFrameFormat *")] SphericalVideoFrameFormat* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackSphericalVideoProjection*, SphericalVideoFrameFormat*, int>)(lpVtbl[8]))((IMediaPlaybackSphericalVideoProjection*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaPlaybackSphericalVideoProjection.xml' path='doc/member[@name="IMediaPlaybackSphericalVideoProjection.put_FrameFormat"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_FrameFormat([NativeTypeName("ABI::Windows::Media::MediaProperties::SphericalVideoFrameFormat")] SphericalVideoFrameFormat value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackSphericalVideoProjection*, SphericalVideoFrameFormat, int>)(lpVtbl[9]))((IMediaPlaybackSphericalVideoProjection*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaPlaybackSphericalVideoProjection.xml' path='doc/member[@name="IMediaPlaybackSphericalVideoProjection.get_HorizontalFieldOfViewInDegrees"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_HorizontalFieldOfViewInDegrees(double* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackSphericalVideoProjection*, double*, int>)(lpVtbl[10]))((IMediaPlaybackSphericalVideoProjection*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaPlaybackSphericalVideoProjection.xml' path='doc/member[@name="IMediaPlaybackSphericalVideoProjection.put_HorizontalFieldOfViewInDegrees"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_HorizontalFieldOfViewInDegrees(double value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackSphericalVideoProjection*, double, int>)(lpVtbl[11]))((IMediaPlaybackSphericalVideoProjection*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaPlaybackSphericalVideoProjection.xml' path='doc/member[@name="IMediaPlaybackSphericalVideoProjection.get_ViewOrientation"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_ViewOrientation([NativeTypeName("ABI::Windows::Foundation::Numerics::Quaternion *")] Quaternion* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackSphericalVideoProjection*, Quaternion*, int>)(lpVtbl[12]))((IMediaPlaybackSphericalVideoProjection*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaPlaybackSphericalVideoProjection.xml' path='doc/member[@name="IMediaPlaybackSphericalVideoProjection.put_ViewOrientation"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_ViewOrientation([NativeTypeName("ABI::Windows::Foundation::Numerics::Quaternion")] Quaternion value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackSphericalVideoProjection*, Quaternion, int>)(lpVtbl[13]))((IMediaPlaybackSphericalVideoProjection*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaPlaybackSphericalVideoProjection.xml' path='doc/member[@name="IMediaPlaybackSphericalVideoProjection.get_ProjectionMode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_ProjectionMode([NativeTypeName("ABI::Windows::Media::Playback::SphericalVideoProjectionMode *")] SphericalVideoProjectionMode* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackSphericalVideoProjection*, SphericalVideoProjectionMode*, int>)(lpVtbl[14]))((IMediaPlaybackSphericalVideoProjection*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaPlaybackSphericalVideoProjection.xml' path='doc/member[@name="IMediaPlaybackSphericalVideoProjection.put_ProjectionMode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT put_ProjectionMode([NativeTypeName("ABI::Windows::Media::Playback::SphericalVideoProjectionMode")] SphericalVideoProjectionMode value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlaybackSphericalVideoProjection*, SphericalVideoProjectionMode, int>)(lpVtbl[15]))((IMediaPlaybackSphericalVideoProjection*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_IsEnabled([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(7)]
        HRESULT put_IsEnabled([NativeTypeName("boolean")] byte value);

        [VtblIndex(8)]
        HRESULT get_FrameFormat([NativeTypeName("ABI::Windows::Media::MediaProperties::SphericalVideoFrameFormat *")] SphericalVideoFrameFormat* value);

        [VtblIndex(9)]
        HRESULT put_FrameFormat([NativeTypeName("ABI::Windows::Media::MediaProperties::SphericalVideoFrameFormat")] SphericalVideoFrameFormat value);

        [VtblIndex(10)]
        HRESULT get_HorizontalFieldOfViewInDegrees(double* value);

        [VtblIndex(11)]
        HRESULT put_HorizontalFieldOfViewInDegrees(double value);

        [VtblIndex(12)]
        HRESULT get_ViewOrientation([NativeTypeName("ABI::Windows::Foundation::Numerics::Quaternion *")] Quaternion* value);

        [VtblIndex(13)]
        HRESULT put_ViewOrientation([NativeTypeName("ABI::Windows::Foundation::Numerics::Quaternion")] Quaternion value);

        [VtblIndex(14)]
        HRESULT get_ProjectionMode([NativeTypeName("ABI::Windows::Media::Playback::SphericalVideoProjectionMode *")] SphericalVideoProjectionMode* value);

        [VtblIndex(15)]
        HRESULT put_ProjectionMode([NativeTypeName("ABI::Windows::Media::Playback::SphericalVideoProjectionMode")] SphericalVideoProjectionMode value);
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

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsEnabled;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_IsEnabled;

        [NativeTypeName("HRESULT (ABI::Windows::Media::MediaProperties::SphericalVideoFrameFormat *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, SphericalVideoFrameFormat*, int> get_FrameFormat;

        [NativeTypeName("HRESULT (ABI::Windows::Media::MediaProperties::SphericalVideoFrameFormat) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, SphericalVideoFrameFormat, int> put_FrameFormat;

        [NativeTypeName("HRESULT (DOUBLE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, double*, int> get_HorizontalFieldOfViewInDegrees;

        [NativeTypeName("HRESULT (DOUBLE) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, double, int> put_HorizontalFieldOfViewInDegrees;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Numerics::Quaternion *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Quaternion*, int> get_ViewOrientation;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Numerics::Quaternion) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Quaternion, int> put_ViewOrientation;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Playback::SphericalVideoProjectionMode *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, SphericalVideoProjectionMode*, int> get_ProjectionMode;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Playback::SphericalVideoProjectionMode) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, SphericalVideoProjectionMode, int> put_ProjectionMode;
    }
}
