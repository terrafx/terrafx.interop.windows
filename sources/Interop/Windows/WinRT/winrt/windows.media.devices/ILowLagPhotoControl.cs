// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.devices.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ILowLagPhotoControl.xml' path='doc/member[@name="ILowLagPhotoControl"]/*' />
[Guid("6D5C4DD0-FADF-415D-AEE6-3BAA529300C9")]
[NativeTypeName("struct ILowLagPhotoControl : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ILowLagPhotoControl : ILowLagPhotoControl.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_ILowLagPhotoControl);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ILowLagPhotoControl*, Guid*, void**, int>)(lpVtbl[0]))((ILowLagPhotoControl*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ILowLagPhotoControl*, uint>)(lpVtbl[1]))((ILowLagPhotoControl*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ILowLagPhotoControl*, uint>)(lpVtbl[2]))((ILowLagPhotoControl*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ILowLagPhotoControl*, uint*, Guid**, int>)(lpVtbl[3]))((ILowLagPhotoControl*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ILowLagPhotoControl*, HSTRING*, int>)(lpVtbl[4]))((ILowLagPhotoControl*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ILowLagPhotoControl*, TrustLevel*, int>)(lpVtbl[5]))((ILowLagPhotoControl*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ILowLagPhotoControl.xml' path='doc/member[@name="ILowLagPhotoControl.GetHighestConcurrentFrameRate"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetHighestConcurrentFrameRate([NativeTypeName("ABI::Windows::Media::MediaProperties::IMediaEncodingProperties *")] IMediaEncodingProperties* captureProperties, [NativeTypeName("ABI::Windows::Media::MediaProperties::IMediaRatio **")] IMediaRatio** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ILowLagPhotoControl*, IMediaEncodingProperties*, IMediaRatio**, int>)(lpVtbl[6]))((ILowLagPhotoControl*)Unsafe.AsPointer(ref this), captureProperties, value);
    }

    /// <include file='ILowLagPhotoControl.xml' path='doc/member[@name="ILowLagPhotoControl.GetCurrentFrameRate"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetCurrentFrameRate([NativeTypeName("ABI::Windows::Media::MediaProperties::IMediaRatio **")] IMediaRatio** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ILowLagPhotoControl*, IMediaRatio**, int>)(lpVtbl[7]))((ILowLagPhotoControl*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ILowLagPhotoControl.xml' path='doc/member[@name="ILowLagPhotoControl.get_ThumbnailEnabled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_ThumbnailEnabled([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ILowLagPhotoControl*, byte*, int>)(lpVtbl[8]))((ILowLagPhotoControl*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ILowLagPhotoControl.xml' path='doc/member[@name="ILowLagPhotoControl.put_ThumbnailEnabled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_ThumbnailEnabled([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<ILowLagPhotoControl*, byte, int>)(lpVtbl[9]))((ILowLagPhotoControl*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ILowLagPhotoControl.xml' path='doc/member[@name="ILowLagPhotoControl.get_ThumbnailFormat"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_ThumbnailFormat([NativeTypeName("ABI::Windows::Media::MediaProperties::MediaThumbnailFormat *")] MediaThumbnailFormat* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ILowLagPhotoControl*, MediaThumbnailFormat*, int>)(lpVtbl[10]))((ILowLagPhotoControl*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ILowLagPhotoControl.xml' path='doc/member[@name="ILowLagPhotoControl.put_ThumbnailFormat"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_ThumbnailFormat([NativeTypeName("ABI::Windows::Media::MediaProperties::MediaThumbnailFormat")] MediaThumbnailFormat value)
    {
        return ((delegate* unmanaged[MemberFunction]<ILowLagPhotoControl*, MediaThumbnailFormat, int>)(lpVtbl[11]))((ILowLagPhotoControl*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ILowLagPhotoControl.xml' path='doc/member[@name="ILowLagPhotoControl.get_DesiredThumbnailSize"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_DesiredThumbnailSize([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ILowLagPhotoControl*, uint*, int>)(lpVtbl[12]))((ILowLagPhotoControl*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ILowLagPhotoControl.xml' path='doc/member[@name="ILowLagPhotoControl.put_DesiredThumbnailSize"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_DesiredThumbnailSize([NativeTypeName("UINT32")] uint value)
    {
        return ((delegate* unmanaged[MemberFunction]<ILowLagPhotoControl*, uint, int>)(lpVtbl[13]))((ILowLagPhotoControl*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ILowLagPhotoControl.xml' path='doc/member[@name="ILowLagPhotoControl.get_HardwareAcceleratedThumbnailSupported"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_HardwareAcceleratedThumbnailSupported([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ILowLagPhotoControl*, uint*, int>)(lpVtbl[14]))((ILowLagPhotoControl*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT GetHighestConcurrentFrameRate([NativeTypeName("ABI::Windows::Media::MediaProperties::IMediaEncodingProperties *")] IMediaEncodingProperties* captureProperties, [NativeTypeName("ABI::Windows::Media::MediaProperties::IMediaRatio **")] IMediaRatio** value);

        [VtblIndex(7)]
        HRESULT GetCurrentFrameRate([NativeTypeName("ABI::Windows::Media::MediaProperties::IMediaRatio **")] IMediaRatio** value);

        [VtblIndex(8)]
        HRESULT get_ThumbnailEnabled([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(9)]
        HRESULT put_ThumbnailEnabled([NativeTypeName("boolean")] byte value);

        [VtblIndex(10)]
        HRESULT get_ThumbnailFormat([NativeTypeName("ABI::Windows::Media::MediaProperties::MediaThumbnailFormat *")] MediaThumbnailFormat* value);

        [VtblIndex(11)]
        HRESULT put_ThumbnailFormat([NativeTypeName("ABI::Windows::Media::MediaProperties::MediaThumbnailFormat")] MediaThumbnailFormat value);

        [VtblIndex(12)]
        HRESULT get_DesiredThumbnailSize([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(13)]
        HRESULT put_DesiredThumbnailSize([NativeTypeName("UINT32")] uint value);

        [VtblIndex(14)]
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
