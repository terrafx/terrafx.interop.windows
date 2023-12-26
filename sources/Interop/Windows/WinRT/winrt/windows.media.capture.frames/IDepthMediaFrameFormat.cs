// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.capture.frames.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IDepthMediaFrameFormat.xml' path='doc/member[@name="IDepthMediaFrameFormat"]/*' />
[Guid("C312CF40-D729-453E-8780-2E04F140D28E")]
[NativeTypeName("struct IDepthMediaFrameFormat : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IDepthMediaFrameFormat : IDepthMediaFrameFormat.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDepthMediaFrameFormat));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IDepthMediaFrameFormat*, Guid*, void**, int>)(lpVtbl[0]))((IDepthMediaFrameFormat*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IDepthMediaFrameFormat*, uint>)(lpVtbl[1]))((IDepthMediaFrameFormat*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IDepthMediaFrameFormat*, uint>)(lpVtbl[2]))((IDepthMediaFrameFormat*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IDepthMediaFrameFormat*, uint*, Guid**, int>)(lpVtbl[3]))((IDepthMediaFrameFormat*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IDepthMediaFrameFormat*, HSTRING*, int>)(lpVtbl[4]))((IDepthMediaFrameFormat*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IDepthMediaFrameFormat*, TrustLevel*, int>)(lpVtbl[5]))((IDepthMediaFrameFormat*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IDepthMediaFrameFormat.xml' path='doc/member[@name="IDepthMediaFrameFormat.get_VideoFormat"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_VideoFormat([NativeTypeName("ABI::Windows::Media::Capture::Frames::IVideoMediaFrameFormat **")] IVideoMediaFrameFormat** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDepthMediaFrameFormat*, IVideoMediaFrameFormat**, int>)(lpVtbl[6]))((IDepthMediaFrameFormat*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDepthMediaFrameFormat.xml' path='doc/member[@name="IDepthMediaFrameFormat.get_DepthScaleInMeters"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_DepthScaleInMeters(double* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDepthMediaFrameFormat*, double*, int>)(lpVtbl[7]))((IDepthMediaFrameFormat*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_VideoFormat([NativeTypeName("ABI::Windows::Media::Capture::Frames::IVideoMediaFrameFormat **")] IVideoMediaFrameFormat** value);

        [VtblIndex(7)]
        HRESULT get_DepthScaleInMeters(double* value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Media::Capture::Frames::IVideoMediaFrameFormat **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVideoMediaFrameFormat**, int> get_VideoFormat;

        [NativeTypeName("HRESULT (DOUBLE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, double*, int> get_DepthScaleInMeters;
    }
}
