// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.capture.frames.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IDepthMediaFrame.xml' path='doc/member[@name="IDepthMediaFrame"]/*' />
[Guid("47135E4F-8549-45C0-925B-80D35EFDB10A")]
[NativeTypeName("struct IDepthMediaFrame : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IDepthMediaFrame : IDepthMediaFrame.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDepthMediaFrame));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IDepthMediaFrame*, Guid*, void**, int>)(lpVtbl[0]))((IDepthMediaFrame*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IDepthMediaFrame*, uint>)(lpVtbl[1]))((IDepthMediaFrame*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IDepthMediaFrame*, uint>)(lpVtbl[2]))((IDepthMediaFrame*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IDepthMediaFrame*, uint*, Guid**, int>)(lpVtbl[3]))((IDepthMediaFrame*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IDepthMediaFrame*, HSTRING*, int>)(lpVtbl[4]))((IDepthMediaFrame*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IDepthMediaFrame*, TrustLevel*, int>)(lpVtbl[5]))((IDepthMediaFrame*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IDepthMediaFrame.xml' path='doc/member[@name="IDepthMediaFrame.get_FrameReference"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_FrameReference([NativeTypeName("ABI::Windows::Media::Capture::Frames::IMediaFrameReference **")] IMediaFrameReference** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDepthMediaFrame*, IMediaFrameReference**, int>)(lpVtbl[6]))((IDepthMediaFrame*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDepthMediaFrame.xml' path='doc/member[@name="IDepthMediaFrame.get_VideoMediaFrame"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_VideoMediaFrame([NativeTypeName("ABI::Windows::Media::Capture::Frames::IVideoMediaFrame **")] IVideoMediaFrame** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDepthMediaFrame*, IVideoMediaFrame**, int>)(lpVtbl[7]))((IDepthMediaFrame*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDepthMediaFrame.xml' path='doc/member[@name="IDepthMediaFrame.get_DepthFormat"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_DepthFormat([NativeTypeName("ABI::Windows::Media::Capture::Frames::IDepthMediaFrameFormat **")] IDepthMediaFrameFormat** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDepthMediaFrame*, IDepthMediaFrameFormat**, int>)(lpVtbl[8]))((IDepthMediaFrame*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDepthMediaFrame.xml' path='doc/member[@name="IDepthMediaFrame.TryCreateCoordinateMapper"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT TryCreateCoordinateMapper([NativeTypeName("ABI::Windows::Media::Devices::Core::ICameraIntrinsics *")] ICameraIntrinsics* cameraIntrinsics, [NativeTypeName("ABI::Windows::Perception::Spatial::ISpatialCoordinateSystem *")] ISpatialCoordinateSystem* coordinateSystem, [NativeTypeName("ABI::Windows::Media::Devices::Core::IDepthCorrelatedCoordinateMapper **")] IDepthCorrelatedCoordinateMapper** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDepthMediaFrame*, ICameraIntrinsics*, ISpatialCoordinateSystem*, IDepthCorrelatedCoordinateMapper**, int>)(lpVtbl[9]))((IDepthMediaFrame*)Unsafe.AsPointer(ref this), cameraIntrinsics, coordinateSystem, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_FrameReference([NativeTypeName("ABI::Windows::Media::Capture::Frames::IMediaFrameReference **")] IMediaFrameReference** value);

        [VtblIndex(7)]
        HRESULT get_VideoMediaFrame([NativeTypeName("ABI::Windows::Media::Capture::Frames::IVideoMediaFrame **")] IVideoMediaFrame** value);

        [VtblIndex(8)]
        HRESULT get_DepthFormat([NativeTypeName("ABI::Windows::Media::Capture::Frames::IDepthMediaFrameFormat **")] IDepthMediaFrameFormat** value);

        [VtblIndex(9)]
        HRESULT TryCreateCoordinateMapper([NativeTypeName("ABI::Windows::Media::Devices::Core::ICameraIntrinsics *")] ICameraIntrinsics* cameraIntrinsics, [NativeTypeName("ABI::Windows::Perception::Spatial::ISpatialCoordinateSystem *")] ISpatialCoordinateSystem* coordinateSystem, [NativeTypeName("ABI::Windows::Media::Devices::Core::IDepthCorrelatedCoordinateMapper **")] IDepthCorrelatedCoordinateMapper** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Media::Capture::Frames::IVideoMediaFrame **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVideoMediaFrame**, int> get_VideoMediaFrame;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Capture::Frames::IDepthMediaFrameFormat **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDepthMediaFrameFormat**, int> get_DepthFormat;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Devices::Core::ICameraIntrinsics *, ABI::Windows::Perception::Spatial::ISpatialCoordinateSystem *, ABI::Windows::Media::Devices::Core::IDepthCorrelatedCoordinateMapper **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ICameraIntrinsics*, ISpatialCoordinateSystem*, IDepthCorrelatedCoordinateMapper**, int> TryCreateCoordinateMapper;
    }
}
