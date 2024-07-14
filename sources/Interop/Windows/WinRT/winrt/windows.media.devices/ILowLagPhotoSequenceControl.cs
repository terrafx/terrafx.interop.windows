// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.devices.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ILowLagPhotoSequenceControl.xml' path='doc/member[@name="ILowLagPhotoSequenceControl"]/*' />
[Guid("3DCF909D-6D16-409C-BAFE-B9A594C6FDE6")]
[NativeTypeName("struct ILowLagPhotoSequenceControl : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ILowLagPhotoSequenceControl : ILowLagPhotoSequenceControl.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ILowLagPhotoSequenceControl));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ILowLagPhotoSequenceControl*, Guid*, void**, int>)(lpVtbl[0]))((ILowLagPhotoSequenceControl*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ILowLagPhotoSequenceControl*, uint>)(lpVtbl[1]))((ILowLagPhotoSequenceControl*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ILowLagPhotoSequenceControl*, uint>)(lpVtbl[2]))((ILowLagPhotoSequenceControl*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ILowLagPhotoSequenceControl*, uint*, Guid**, int>)(lpVtbl[3]))((ILowLagPhotoSequenceControl*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ILowLagPhotoSequenceControl*, HSTRING*, int>)(lpVtbl[4]))((ILowLagPhotoSequenceControl*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ILowLagPhotoSequenceControl*, TrustLevel*, int>)(lpVtbl[5]))((ILowLagPhotoSequenceControl*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ILowLagPhotoSequenceControl.xml' path='doc/member[@name="ILowLagPhotoSequenceControl.get_Supported"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Supported([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ILowLagPhotoSequenceControl*, byte*, int>)(lpVtbl[6]))((ILowLagPhotoSequenceControl*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ILowLagPhotoSequenceControl.xml' path='doc/member[@name="ILowLagPhotoSequenceControl.get_MaxPastPhotos"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_MaxPastPhotos([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ILowLagPhotoSequenceControl*, uint*, int>)(lpVtbl[7]))((ILowLagPhotoSequenceControl*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ILowLagPhotoSequenceControl.xml' path='doc/member[@name="ILowLagPhotoSequenceControl.get_MaxPhotosPerSecond"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_MaxPhotosPerSecond(float* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ILowLagPhotoSequenceControl*, float*, int>)(lpVtbl[8]))((ILowLagPhotoSequenceControl*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ILowLagPhotoSequenceControl.xml' path='doc/member[@name="ILowLagPhotoSequenceControl.get_PastPhotoLimit"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_PastPhotoLimit([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ILowLagPhotoSequenceControl*, uint*, int>)(lpVtbl[9]))((ILowLagPhotoSequenceControl*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ILowLagPhotoSequenceControl.xml' path='doc/member[@name="ILowLagPhotoSequenceControl.put_PastPhotoLimit"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT put_PastPhotoLimit([NativeTypeName("UINT32")] uint value)
    {
        return ((delegate* unmanaged[MemberFunction]<ILowLagPhotoSequenceControl*, uint, int>)(lpVtbl[10]))((ILowLagPhotoSequenceControl*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ILowLagPhotoSequenceControl.xml' path='doc/member[@name="ILowLagPhotoSequenceControl.get_PhotosPerSecondLimit"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_PhotosPerSecondLimit(float* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ILowLagPhotoSequenceControl*, float*, int>)(lpVtbl[11]))((ILowLagPhotoSequenceControl*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ILowLagPhotoSequenceControl.xml' path='doc/member[@name="ILowLagPhotoSequenceControl.put_PhotosPerSecondLimit"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT put_PhotosPerSecondLimit(float value)
    {
        return ((delegate* unmanaged[MemberFunction]<ILowLagPhotoSequenceControl*, float, int>)(lpVtbl[12]))((ILowLagPhotoSequenceControl*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ILowLagPhotoSequenceControl.xml' path='doc/member[@name="ILowLagPhotoSequenceControl.GetHighestConcurrentFrameRate"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetHighestConcurrentFrameRate([NativeTypeName("ABI::Windows::Media::MediaProperties::IMediaEncodingProperties *")] IMediaEncodingProperties* captureProperties, [NativeTypeName("ABI::Windows::Media::MediaProperties::IMediaRatio **")] IMediaRatio** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ILowLagPhotoSequenceControl*, IMediaEncodingProperties*, IMediaRatio**, int>)(lpVtbl[13]))((ILowLagPhotoSequenceControl*)Unsafe.AsPointer(ref this), captureProperties, value);
    }

    /// <include file='ILowLagPhotoSequenceControl.xml' path='doc/member[@name="ILowLagPhotoSequenceControl.GetCurrentFrameRate"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT GetCurrentFrameRate([NativeTypeName("ABI::Windows::Media::MediaProperties::IMediaRatio **")] IMediaRatio** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ILowLagPhotoSequenceControl*, IMediaRatio**, int>)(lpVtbl[14]))((ILowLagPhotoSequenceControl*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ILowLagPhotoSequenceControl.xml' path='doc/member[@name="ILowLagPhotoSequenceControl.get_ThumbnailEnabled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_ThumbnailEnabled([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ILowLagPhotoSequenceControl*, byte*, int>)(lpVtbl[15]))((ILowLagPhotoSequenceControl*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ILowLagPhotoSequenceControl.xml' path='doc/member[@name="ILowLagPhotoSequenceControl.put_ThumbnailEnabled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT put_ThumbnailEnabled([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<ILowLagPhotoSequenceControl*, byte, int>)(lpVtbl[16]))((ILowLagPhotoSequenceControl*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ILowLagPhotoSequenceControl.xml' path='doc/member[@name="ILowLagPhotoSequenceControl.get_ThumbnailFormat"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_ThumbnailFormat([NativeTypeName("ABI::Windows::Media::MediaProperties::MediaThumbnailFormat *")] MediaThumbnailFormat* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ILowLagPhotoSequenceControl*, MediaThumbnailFormat*, int>)(lpVtbl[17]))((ILowLagPhotoSequenceControl*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ILowLagPhotoSequenceControl.xml' path='doc/member[@name="ILowLagPhotoSequenceControl.put_ThumbnailFormat"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT put_ThumbnailFormat([NativeTypeName("ABI::Windows::Media::MediaProperties::MediaThumbnailFormat")] MediaThumbnailFormat value)
    {
        return ((delegate* unmanaged[MemberFunction]<ILowLagPhotoSequenceControl*, MediaThumbnailFormat, int>)(lpVtbl[18]))((ILowLagPhotoSequenceControl*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ILowLagPhotoSequenceControl.xml' path='doc/member[@name="ILowLagPhotoSequenceControl.get_DesiredThumbnailSize"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT get_DesiredThumbnailSize([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ILowLagPhotoSequenceControl*, uint*, int>)(lpVtbl[19]))((ILowLagPhotoSequenceControl*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ILowLagPhotoSequenceControl.xml' path='doc/member[@name="ILowLagPhotoSequenceControl.put_DesiredThumbnailSize"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT put_DesiredThumbnailSize([NativeTypeName("UINT32")] uint value)
    {
        return ((delegate* unmanaged[MemberFunction]<ILowLagPhotoSequenceControl*, uint, int>)(lpVtbl[20]))((ILowLagPhotoSequenceControl*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ILowLagPhotoSequenceControl.xml' path='doc/member[@name="ILowLagPhotoSequenceControl.get_HardwareAcceleratedThumbnailSupported"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT get_HardwareAcceleratedThumbnailSupported([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ILowLagPhotoSequenceControl*, uint*, int>)(lpVtbl[21]))((ILowLagPhotoSequenceControl*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Supported([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(7)]
        HRESULT get_MaxPastPhotos([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(8)]
        HRESULT get_MaxPhotosPerSecond(float* value);

        [VtblIndex(9)]
        HRESULT get_PastPhotoLimit([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(10)]
        HRESULT put_PastPhotoLimit([NativeTypeName("UINT32")] uint value);

        [VtblIndex(11)]
        HRESULT get_PhotosPerSecondLimit(float* value);

        [VtblIndex(12)]
        HRESULT put_PhotosPerSecondLimit(float value);

        [VtblIndex(13)]
        HRESULT GetHighestConcurrentFrameRate([NativeTypeName("ABI::Windows::Media::MediaProperties::IMediaEncodingProperties *")] IMediaEncodingProperties* captureProperties, [NativeTypeName("ABI::Windows::Media::MediaProperties::IMediaRatio **")] IMediaRatio** value);

        [VtblIndex(14)]
        HRESULT GetCurrentFrameRate([NativeTypeName("ABI::Windows::Media::MediaProperties::IMediaRatio **")] IMediaRatio** value);

        [VtblIndex(15)]
        HRESULT get_ThumbnailEnabled([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(16)]
        HRESULT put_ThumbnailEnabled([NativeTypeName("boolean")] byte value);

        [VtblIndex(17)]
        HRESULT get_ThumbnailFormat([NativeTypeName("ABI::Windows::Media::MediaProperties::MediaThumbnailFormat *")] MediaThumbnailFormat* value);

        [VtblIndex(18)]
        HRESULT put_ThumbnailFormat([NativeTypeName("ABI::Windows::Media::MediaProperties::MediaThumbnailFormat")] MediaThumbnailFormat value);

        [VtblIndex(19)]
        HRESULT get_DesiredThumbnailSize([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(20)]
        HRESULT put_DesiredThumbnailSize([NativeTypeName("UINT32")] uint value);

        [VtblIndex(21)]
        HRESULT get_HardwareAcceleratedThumbnailSupported([NativeTypeName("UINT32 *")] uint* value);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_Supported;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_MaxPastPhotos;

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float*, int> get_MaxPhotosPerSecond;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_PastPhotoLimit;

        [NativeTypeName("HRESULT (UINT32) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, int> put_PastPhotoLimit;

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float*, int> get_PhotosPerSecondLimit;

        [NativeTypeName("HRESULT (FLOAT) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float, int> put_PhotosPerSecondLimit;

        [NativeTypeName("HRESULT (ABI::Windows::Media::MediaProperties::IMediaEncodingProperties *, ABI::Windows::Media::MediaProperties::IMediaRatio **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMediaEncodingProperties*, IMediaRatio**, int> GetHighestConcurrentFrameRate;

        [NativeTypeName("HRESULT (ABI::Windows::Media::MediaProperties::IMediaRatio **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMediaRatio**, int> GetCurrentFrameRate;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_ThumbnailEnabled;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_ThumbnailEnabled;

        [NativeTypeName("HRESULT (ABI::Windows::Media::MediaProperties::MediaThumbnailFormat *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, MediaThumbnailFormat*, int> get_ThumbnailFormat;

        [NativeTypeName("HRESULT (ABI::Windows::Media::MediaProperties::MediaThumbnailFormat) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, MediaThumbnailFormat, int> put_ThumbnailFormat;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_DesiredThumbnailSize;

        [NativeTypeName("HRESULT (UINT32) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, int> put_DesiredThumbnailSize;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_HardwareAcceleratedThumbnailSupported;
    }
}
