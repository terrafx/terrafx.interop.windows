// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.capture.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IMediaCaptureInitializationSettings5.xml' path='doc/member[@name="IMediaCaptureInitializationSettings5"]/*' />
[Guid("D5A2E3B8-2626-4E94-B7B3-5308A0F64B1A")]
[NativeTypeName("struct IMediaCaptureInitializationSettings5 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IMediaCaptureInitializationSettings5 : IMediaCaptureInitializationSettings5.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMediaCaptureInitializationSettings5));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCaptureInitializationSettings5*, Guid*, void**, int>)(lpVtbl[0]))((IMediaCaptureInitializationSettings5*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCaptureInitializationSettings5*, uint>)(lpVtbl[1]))((IMediaCaptureInitializationSettings5*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCaptureInitializationSettings5*, uint>)(lpVtbl[2]))((IMediaCaptureInitializationSettings5*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCaptureInitializationSettings5*, uint*, Guid**, int>)(lpVtbl[3]))((IMediaCaptureInitializationSettings5*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCaptureInitializationSettings5*, HSTRING*, int>)(lpVtbl[4]))((IMediaCaptureInitializationSettings5*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCaptureInitializationSettings5*, TrustLevel*, int>)(lpVtbl[5]))((IMediaCaptureInitializationSettings5*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IMediaCaptureInitializationSettings5.xml' path='doc/member[@name="IMediaCaptureInitializationSettings5.get_SourceGroup"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_SourceGroup([NativeTypeName("ABI::Windows::Media::Capture::Frames::IMediaFrameSourceGroup **")] IMediaFrameSourceGroup** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCaptureInitializationSettings5*, IMediaFrameSourceGroup**, int>)(lpVtbl[6]))((IMediaCaptureInitializationSettings5*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaCaptureInitializationSettings5.xml' path='doc/member[@name="IMediaCaptureInitializationSettings5.put_SourceGroup"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_SourceGroup([NativeTypeName("ABI::Windows::Media::Capture::Frames::IMediaFrameSourceGroup *")] IMediaFrameSourceGroup* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCaptureInitializationSettings5*, IMediaFrameSourceGroup*, int>)(lpVtbl[7]))((IMediaCaptureInitializationSettings5*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaCaptureInitializationSettings5.xml' path='doc/member[@name="IMediaCaptureInitializationSettings5.get_SharingMode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_SharingMode([NativeTypeName("ABI::Windows::Media::Capture::MediaCaptureSharingMode *")] MediaCaptureSharingMode* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCaptureInitializationSettings5*, MediaCaptureSharingMode*, int>)(lpVtbl[8]))((IMediaCaptureInitializationSettings5*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaCaptureInitializationSettings5.xml' path='doc/member[@name="IMediaCaptureInitializationSettings5.put_SharingMode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_SharingMode([NativeTypeName("ABI::Windows::Media::Capture::MediaCaptureSharingMode")] MediaCaptureSharingMode value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCaptureInitializationSettings5*, MediaCaptureSharingMode, int>)(lpVtbl[9]))((IMediaCaptureInitializationSettings5*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaCaptureInitializationSettings5.xml' path='doc/member[@name="IMediaCaptureInitializationSettings5.get_MemoryPreference"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_MemoryPreference([NativeTypeName("ABI::Windows::Media::Capture::MediaCaptureMemoryPreference *")] MediaCaptureMemoryPreference* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCaptureInitializationSettings5*, MediaCaptureMemoryPreference*, int>)(lpVtbl[10]))((IMediaCaptureInitializationSettings5*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaCaptureInitializationSettings5.xml' path='doc/member[@name="IMediaCaptureInitializationSettings5.put_MemoryPreference"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_MemoryPreference([NativeTypeName("ABI::Windows::Media::Capture::MediaCaptureMemoryPreference")] MediaCaptureMemoryPreference value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCaptureInitializationSettings5*, MediaCaptureMemoryPreference, int>)(lpVtbl[11]))((IMediaCaptureInitializationSettings5*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_SourceGroup([NativeTypeName("ABI::Windows::Media::Capture::Frames::IMediaFrameSourceGroup **")] IMediaFrameSourceGroup** value);

        [VtblIndex(7)]
        HRESULT put_SourceGroup([NativeTypeName("ABI::Windows::Media::Capture::Frames::IMediaFrameSourceGroup *")] IMediaFrameSourceGroup* value);

        [VtblIndex(8)]
        HRESULT get_SharingMode([NativeTypeName("ABI::Windows::Media::Capture::MediaCaptureSharingMode *")] MediaCaptureSharingMode* value);

        [VtblIndex(9)]
        HRESULT put_SharingMode([NativeTypeName("ABI::Windows::Media::Capture::MediaCaptureSharingMode")] MediaCaptureSharingMode value);

        [VtblIndex(10)]
        HRESULT get_MemoryPreference([NativeTypeName("ABI::Windows::Media::Capture::MediaCaptureMemoryPreference *")] MediaCaptureMemoryPreference* value);

        [VtblIndex(11)]
        HRESULT put_MemoryPreference([NativeTypeName("ABI::Windows::Media::Capture::MediaCaptureMemoryPreference")] MediaCaptureMemoryPreference value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Media::Capture::Frames::IMediaFrameSourceGroup **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMediaFrameSourceGroup**, int> get_SourceGroup;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Capture::Frames::IMediaFrameSourceGroup *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMediaFrameSourceGroup*, int> put_SourceGroup;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Capture::MediaCaptureSharingMode *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, MediaCaptureSharingMode*, int> get_SharingMode;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Capture::MediaCaptureSharingMode) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, MediaCaptureSharingMode, int> put_SharingMode;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Capture::MediaCaptureMemoryPreference *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, MediaCaptureMemoryPreference*, int> get_MemoryPreference;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Capture::MediaCaptureMemoryPreference) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, MediaCaptureMemoryPreference, int> put_MemoryPreference;
    }
}
