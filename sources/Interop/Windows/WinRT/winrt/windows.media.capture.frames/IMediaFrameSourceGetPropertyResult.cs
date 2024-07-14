// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.capture.frames.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IMediaFrameSourceGetPropertyResult.xml' path='doc/member[@name="IMediaFrameSourceGetPropertyResult"]/*' />
[Guid("088616C2-3A64-4BD5-BD2B-E7C898D2F37A")]
[NativeTypeName("struct IMediaFrameSourceGetPropertyResult : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IMediaFrameSourceGetPropertyResult : IMediaFrameSourceGetPropertyResult.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMediaFrameSourceGetPropertyResult));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaFrameSourceGetPropertyResult*, Guid*, void**, int>)(lpVtbl[0]))((IMediaFrameSourceGetPropertyResult*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaFrameSourceGetPropertyResult*, uint>)(lpVtbl[1]))((IMediaFrameSourceGetPropertyResult*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaFrameSourceGetPropertyResult*, uint>)(lpVtbl[2]))((IMediaFrameSourceGetPropertyResult*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaFrameSourceGetPropertyResult*, uint*, Guid**, int>)(lpVtbl[3]))((IMediaFrameSourceGetPropertyResult*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaFrameSourceGetPropertyResult*, HSTRING*, int>)(lpVtbl[4]))((IMediaFrameSourceGetPropertyResult*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaFrameSourceGetPropertyResult*, TrustLevel*, int>)(lpVtbl[5]))((IMediaFrameSourceGetPropertyResult*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IMediaFrameSourceGetPropertyResult.xml' path='doc/member[@name="IMediaFrameSourceGetPropertyResult.get_Status"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Status([NativeTypeName("ABI::Windows::Media::Capture::Frames::MediaFrameSourceGetPropertyStatus *")] MediaFrameSourceGetPropertyStatus* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaFrameSourceGetPropertyResult*, MediaFrameSourceGetPropertyStatus*, int>)(lpVtbl[6]))((IMediaFrameSourceGetPropertyResult*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaFrameSourceGetPropertyResult.xml' path='doc/member[@name="IMediaFrameSourceGetPropertyResult.get_Value"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Value(IInspectable** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaFrameSourceGetPropertyResult*, IInspectable**, int>)(lpVtbl[7]))((IMediaFrameSourceGetPropertyResult*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Status([NativeTypeName("ABI::Windows::Media::Capture::Frames::MediaFrameSourceGetPropertyStatus *")] MediaFrameSourceGetPropertyStatus* value);

        [VtblIndex(7)]
        HRESULT get_Value(IInspectable** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Media::Capture::Frames::MediaFrameSourceGetPropertyStatus *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, MediaFrameSourceGetPropertyStatus*, int> get_Status;

        [NativeTypeName("HRESULT (IInspectable **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IInspectable**, int> get_Value;
    }
}
