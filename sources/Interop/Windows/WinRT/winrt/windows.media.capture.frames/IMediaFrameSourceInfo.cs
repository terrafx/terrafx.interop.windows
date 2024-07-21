// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.capture.frames.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IMediaFrameSourceInfo.xml' path='doc/member[@name="IMediaFrameSourceInfo"]/*' />
[Guid("87BDC9CD-4601-408F-91CF-038318CD0AF3")]
[NativeTypeName("struct IMediaFrameSourceInfo : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IMediaFrameSourceInfo : IMediaFrameSourceInfo.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMediaFrameSourceInfo));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaFrameSourceInfo*, Guid*, void**, int>)(lpVtbl[0]))((IMediaFrameSourceInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaFrameSourceInfo*, uint>)(lpVtbl[1]))((IMediaFrameSourceInfo*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaFrameSourceInfo*, uint>)(lpVtbl[2]))((IMediaFrameSourceInfo*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaFrameSourceInfo*, uint*, Guid**, int>)(lpVtbl[3]))((IMediaFrameSourceInfo*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaFrameSourceInfo*, HSTRING*, int>)(lpVtbl[4]))((IMediaFrameSourceInfo*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaFrameSourceInfo*, TrustLevel*, int>)(lpVtbl[5]))((IMediaFrameSourceInfo*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IMediaFrameSourceInfo.xml' path='doc/member[@name="IMediaFrameSourceInfo.get_Id"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Id(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaFrameSourceInfo*, HSTRING*, int>)(lpVtbl[6]))((IMediaFrameSourceInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaFrameSourceInfo.xml' path='doc/member[@name="IMediaFrameSourceInfo.get_MediaStreamType"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_MediaStreamType([NativeTypeName("ABI::Windows::Media::Capture::MediaStreamType *")] MediaStreamType* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaFrameSourceInfo*, MediaStreamType*, int>)(lpVtbl[7]))((IMediaFrameSourceInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaFrameSourceInfo.xml' path='doc/member[@name="IMediaFrameSourceInfo.get_SourceKind"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_SourceKind([NativeTypeName("ABI::Windows::Media::Capture::Frames::MediaFrameSourceKind *")] MediaFrameSourceKind* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaFrameSourceInfo*, MediaFrameSourceKind*, int>)(lpVtbl[8]))((IMediaFrameSourceInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaFrameSourceInfo.xml' path='doc/member[@name="IMediaFrameSourceInfo.get_SourceGroup"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_SourceGroup([NativeTypeName("ABI::Windows::Media::Capture::Frames::IMediaFrameSourceGroup **")] IMediaFrameSourceGroup** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaFrameSourceInfo*, IMediaFrameSourceGroup**, int>)(lpVtbl[9]))((IMediaFrameSourceInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaFrameSourceInfo.xml' path='doc/member[@name="IMediaFrameSourceInfo.get_DeviceInformation"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_DeviceInformation([NativeTypeName("ABI::Windows::Devices::Enumeration::IDeviceInformation **")] IDeviceInformation** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaFrameSourceInfo*, IDeviceInformation**, int>)(lpVtbl[10]))((IMediaFrameSourceInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaFrameSourceInfo.xml' path='doc/member[@name="IMediaFrameSourceInfo.get_Properties"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_Properties([NativeTypeName("ABI::Windows::Foundation::Collections::__FIMapView_2_GUID_IInspectable_t **")] IMapView<Guid, Pointer<IInspectable>>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaFrameSourceInfo*, IMapView<Guid, Pointer<IInspectable>>**, int>)(lpVtbl[11]))((IMediaFrameSourceInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaFrameSourceInfo.xml' path='doc/member[@name="IMediaFrameSourceInfo.get_CoordinateSystem"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_CoordinateSystem([NativeTypeName("ABI::Windows::Perception::Spatial::ISpatialCoordinateSystem **")] ISpatialCoordinateSystem** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaFrameSourceInfo*, ISpatialCoordinateSystem**, int>)(lpVtbl[12]))((IMediaFrameSourceInfo*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Id(HSTRING* value);

        [VtblIndex(7)]
        HRESULT get_MediaStreamType([NativeTypeName("ABI::Windows::Media::Capture::MediaStreamType *")] MediaStreamType* value);

        [VtblIndex(8)]
        HRESULT get_SourceKind([NativeTypeName("ABI::Windows::Media::Capture::Frames::MediaFrameSourceKind *")] MediaFrameSourceKind* value);

        [VtblIndex(9)]
        HRESULT get_SourceGroup([NativeTypeName("ABI::Windows::Media::Capture::Frames::IMediaFrameSourceGroup **")] IMediaFrameSourceGroup** value);

        [VtblIndex(10)]
        HRESULT get_DeviceInformation([NativeTypeName("ABI::Windows::Devices::Enumeration::IDeviceInformation **")] IDeviceInformation** value);

        [VtblIndex(11)]
        HRESULT get_Properties([NativeTypeName("ABI::Windows::Foundation::Collections::__FIMapView_2_GUID_IInspectable_t **")] IMapView<Guid, Pointer<IInspectable>>** value);

        [VtblIndex(12)]
        HRESULT get_CoordinateSystem([NativeTypeName("ABI::Windows::Perception::Spatial::ISpatialCoordinateSystem **")] ISpatialCoordinateSystem** value);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Id;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Capture::MediaStreamType *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, MediaStreamType*, int> get_MediaStreamType;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Capture::Frames::MediaFrameSourceKind *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, MediaFrameSourceKind*, int> get_SourceKind;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Capture::Frames::IMediaFrameSourceGroup **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMediaFrameSourceGroup**, int> get_SourceGroup;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Enumeration::IDeviceInformation **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDeviceInformation**, int> get_DeviceInformation;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIMapView_2_GUID_IInspectable_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMapView<Guid, Pointer<IInspectable>>**, int> get_Properties;

        [NativeTypeName("HRESULT (ABI::Windows::Perception::Spatial::ISpatialCoordinateSystem **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ISpatialCoordinateSystem**, int> get_CoordinateSystem;
    }
}
