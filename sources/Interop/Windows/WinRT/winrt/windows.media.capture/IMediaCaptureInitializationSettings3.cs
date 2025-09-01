// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.capture.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IMediaCaptureInitializationSettings3.xml' path='doc/member[@name="IMediaCaptureInitializationSettings3"]/*' />
[Guid("4160519D-BE48-4730-8104-0CF6E9E97948")]
[NativeTypeName("struct IMediaCaptureInitializationSettings3 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IMediaCaptureInitializationSettings3 : IMediaCaptureInitializationSettings3.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IMediaCaptureInitializationSettings3);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCaptureInitializationSettings3*, Guid*, void**, int>)(lpVtbl[0]))((IMediaCaptureInitializationSettings3*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCaptureInitializationSettings3*, uint>)(lpVtbl[1]))((IMediaCaptureInitializationSettings3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCaptureInitializationSettings3*, uint>)(lpVtbl[2]))((IMediaCaptureInitializationSettings3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCaptureInitializationSettings3*, uint*, Guid**, int>)(lpVtbl[3]))((IMediaCaptureInitializationSettings3*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCaptureInitializationSettings3*, HSTRING*, int>)(lpVtbl[4]))((IMediaCaptureInitializationSettings3*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCaptureInitializationSettings3*, TrustLevel*, int>)(lpVtbl[5]))((IMediaCaptureInitializationSettings3*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IMediaCaptureInitializationSettings3.xml' path='doc/member[@name="IMediaCaptureInitializationSettings3.put_AudioSource"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT put_AudioSource([NativeTypeName("ABI::Windows::Media::Core::IMediaSource *")] IMediaSource* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCaptureInitializationSettings3*, IMediaSource*, int>)(lpVtbl[6]))((IMediaCaptureInitializationSettings3*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaCaptureInitializationSettings3.xml' path='doc/member[@name="IMediaCaptureInitializationSettings3.get_AudioSource"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_AudioSource([NativeTypeName("ABI::Windows::Media::Core::IMediaSource **")] IMediaSource** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCaptureInitializationSettings3*, IMediaSource**, int>)(lpVtbl[7]))((IMediaCaptureInitializationSettings3*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaCaptureInitializationSettings3.xml' path='doc/member[@name="IMediaCaptureInitializationSettings3.put_VideoSource"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT put_VideoSource([NativeTypeName("ABI::Windows::Media::Core::IMediaSource *")] IMediaSource* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCaptureInitializationSettings3*, IMediaSource*, int>)(lpVtbl[8]))((IMediaCaptureInitializationSettings3*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaCaptureInitializationSettings3.xml' path='doc/member[@name="IMediaCaptureInitializationSettings3.get_VideoSource"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_VideoSource([NativeTypeName("ABI::Windows::Media::Core::IMediaSource **")] IMediaSource** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCaptureInitializationSettings3*, IMediaSource**, int>)(lpVtbl[9]))((IMediaCaptureInitializationSettings3*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT put_AudioSource([NativeTypeName("ABI::Windows::Media::Core::IMediaSource *")] IMediaSource* value);

        [VtblIndex(7)]
        HRESULT get_AudioSource([NativeTypeName("ABI::Windows::Media::Core::IMediaSource **")] IMediaSource** value);

        [VtblIndex(8)]
        HRESULT put_VideoSource([NativeTypeName("ABI::Windows::Media::Core::IMediaSource *")] IMediaSource* value);

        [VtblIndex(9)]
        HRESULT get_VideoSource([NativeTypeName("ABI::Windows::Media::Core::IMediaSource **")] IMediaSource** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Media::Core::IMediaSource *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMediaSource*, int> put_AudioSource;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Core::IMediaSource **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMediaSource**, int> get_AudioSource;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Core::IMediaSource *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMediaSource*, int> put_VideoSource;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Core::IMediaSource **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMediaSource**, int> get_VideoSource;
    }
}
