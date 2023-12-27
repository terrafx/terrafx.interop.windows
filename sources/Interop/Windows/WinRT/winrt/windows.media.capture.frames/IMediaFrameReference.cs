// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.capture.frames.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IMediaFrameReference.xml' path='doc/member[@name="IMediaFrameReference"]/*' />
[Guid("F6B88641-F0DC-4044-8DC9-961CEDD05BAD")]
[NativeTypeName("struct IMediaFrameReference : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IMediaFrameReference : IMediaFrameReference.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMediaFrameReference));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaFrameReference*, Guid*, void**, int>)(lpVtbl[0]))((IMediaFrameReference*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaFrameReference*, uint>)(lpVtbl[1]))((IMediaFrameReference*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaFrameReference*, uint>)(lpVtbl[2]))((IMediaFrameReference*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaFrameReference*, uint*, Guid**, int>)(lpVtbl[3]))((IMediaFrameReference*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaFrameReference*, HSTRING*, int>)(lpVtbl[4]))((IMediaFrameReference*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaFrameReference*, TrustLevel*, int>)(lpVtbl[5]))((IMediaFrameReference*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IMediaFrameReference.xml' path='doc/member[@name="IMediaFrameReference.get_SourceKind"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_SourceKind([NativeTypeName("ABI::Windows::Media::Capture::Frames::MediaFrameSourceKind *")] MediaFrameSourceKind* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaFrameReference*, MediaFrameSourceKind*, int>)(lpVtbl[6]))((IMediaFrameReference*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaFrameReference.xml' path='doc/member[@name="IMediaFrameReference.get_Format"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Format([NativeTypeName("ABI::Windows::Media::Capture::Frames::IMediaFrameFormat **")] IMediaFrameFormat** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaFrameReference*, IMediaFrameFormat**, int>)(lpVtbl[7]))((IMediaFrameReference*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaFrameReference.xml' path='doc/member[@name="IMediaFrameReference.get_SystemRelativeTime"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_SystemRelativeTime([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CTimeSpan_t **")] IReference<TimeSpan>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaFrameReference*, IReference<TimeSpan>**, int>)(lpVtbl[8]))((IMediaFrameReference*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaFrameReference.xml' path='doc/member[@name="IMediaFrameReference.get_Duration"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_Duration([NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaFrameReference*, TimeSpan*, int>)(lpVtbl[9]))((IMediaFrameReference*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaFrameReference.xml' path='doc/member[@name="IMediaFrameReference.get_Properties"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_Properties([NativeTypeName("ABI::Windows::Foundation::Collections::__FIMapView_2_GUID_IInspectable_t **")] IMapView<Guid, Pointer<IInspectable>>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaFrameReference*, IMapView<Guid, Pointer<IInspectable>>**, int>)(lpVtbl[10]))((IMediaFrameReference*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaFrameReference.xml' path='doc/member[@name="IMediaFrameReference.get_BufferMediaFrame"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_BufferMediaFrame([NativeTypeName("ABI::Windows::Media::Capture::Frames::IBufferMediaFrame **")] IBufferMediaFrame** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaFrameReference*, IBufferMediaFrame**, int>)(lpVtbl[11]))((IMediaFrameReference*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaFrameReference.xml' path='doc/member[@name="IMediaFrameReference.get_VideoMediaFrame"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_VideoMediaFrame([NativeTypeName("ABI::Windows::Media::Capture::Frames::IVideoMediaFrame **")] IVideoMediaFrame** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaFrameReference*, IVideoMediaFrame**, int>)(lpVtbl[12]))((IMediaFrameReference*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaFrameReference.xml' path='doc/member[@name="IMediaFrameReference.get_CoordinateSystem"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_CoordinateSystem([NativeTypeName("ABI::Windows::Perception::Spatial::ISpatialCoordinateSystem **")] ISpatialCoordinateSystem** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaFrameReference*, ISpatialCoordinateSystem**, int>)(lpVtbl[13]))((IMediaFrameReference*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_SourceKind([NativeTypeName("ABI::Windows::Media::Capture::Frames::MediaFrameSourceKind *")] MediaFrameSourceKind* value);

        [VtblIndex(7)]
        HRESULT get_Format([NativeTypeName("ABI::Windows::Media::Capture::Frames::IMediaFrameFormat **")] IMediaFrameFormat** value);

        [VtblIndex(8)]
        HRESULT get_SystemRelativeTime([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CTimeSpan_t **")] IReference<TimeSpan>** value);

        [VtblIndex(9)]
        HRESULT get_Duration([NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value);

        [VtblIndex(10)]
        HRESULT get_Properties([NativeTypeName("ABI::Windows::Foundation::Collections::__FIMapView_2_GUID_IInspectable_t **")] IMapView<Guid, Pointer<IInspectable>>** value);

        [VtblIndex(11)]
        HRESULT get_BufferMediaFrame([NativeTypeName("ABI::Windows::Media::Capture::Frames::IBufferMediaFrame **")] IBufferMediaFrame** value);

        [VtblIndex(12)]
        HRESULT get_VideoMediaFrame([NativeTypeName("ABI::Windows::Media::Capture::Frames::IVideoMediaFrame **")] IVideoMediaFrame** value);

        [VtblIndex(13)]
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

        [NativeTypeName("HRESULT (ABI::Windows::Media::Capture::Frames::MediaFrameSourceKind *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, MediaFrameSourceKind*, int> get_SourceKind;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Capture::Frames::IMediaFrameFormat **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMediaFrameFormat**, int> get_Format;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CTimeSpan_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<TimeSpan>**, int> get_SystemRelativeTime;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::TimeSpan *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TimeSpan*, int> get_Duration;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIMapView_2_GUID_IInspectable_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMapView<Guid, Pointer<IInspectable>>**, int> get_Properties;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Capture::Frames::IBufferMediaFrame **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IBufferMediaFrame**, int> get_BufferMediaFrame;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Capture::Frames::IVideoMediaFrame **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVideoMediaFrame**, int> get_VideoMediaFrame;

        [NativeTypeName("HRESULT (ABI::Windows::Perception::Spatial::ISpatialCoordinateSystem **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ISpatialCoordinateSystem**, int> get_CoordinateSystem;
    }
}
