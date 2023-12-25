// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.mediaproperties.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IMediaEncodingProfile.xml' path='doc/member[@name="IMediaEncodingProfile"]/*' />
[Guid("E7DBF5A8-1DB9-4783-876B-3DFE12ACFDB3")]
[NativeTypeName("struct IMediaEncodingProfile : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IMediaEncodingProfile : IMediaEncodingProfile.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMediaEncodingProfile));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaEncodingProfile*, Guid*, void**, int>)(lpVtbl[0]))((IMediaEncodingProfile*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaEncodingProfile*, uint>)(lpVtbl[1]))((IMediaEncodingProfile*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaEncodingProfile*, uint>)(lpVtbl[2]))((IMediaEncodingProfile*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaEncodingProfile*, uint*, Guid**, int>)(lpVtbl[3]))((IMediaEncodingProfile*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaEncodingProfile*, HSTRING*, int>)(lpVtbl[4]))((IMediaEncodingProfile*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaEncodingProfile*, TrustLevel*, int>)(lpVtbl[5]))((IMediaEncodingProfile*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IMediaEncodingProfile.xml' path='doc/member[@name="IMediaEncodingProfile.put_Audio"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT put_Audio([NativeTypeName("ABI::Windows::Media::MediaProperties::IAudioEncodingProperties *")] IAudioEncodingProperties* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaEncodingProfile*, IAudioEncodingProperties*, int>)(lpVtbl[6]))((IMediaEncodingProfile*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaEncodingProfile.xml' path='doc/member[@name="IMediaEncodingProfile.get_Audio"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Audio([NativeTypeName("ABI::Windows::Media::MediaProperties::IAudioEncodingProperties **")] IAudioEncodingProperties** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaEncodingProfile*, IAudioEncodingProperties**, int>)(lpVtbl[7]))((IMediaEncodingProfile*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaEncodingProfile.xml' path='doc/member[@name="IMediaEncodingProfile.put_Video"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT put_Video([NativeTypeName("ABI::Windows::Media::MediaProperties::IVideoEncodingProperties *")] IVideoEncodingProperties* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaEncodingProfile*, IVideoEncodingProperties*, int>)(lpVtbl[8]))((IMediaEncodingProfile*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaEncodingProfile.xml' path='doc/member[@name="IMediaEncodingProfile.get_Video"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_Video([NativeTypeName("ABI::Windows::Media::MediaProperties::IVideoEncodingProperties **")] IVideoEncodingProperties** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaEncodingProfile*, IVideoEncodingProperties**, int>)(lpVtbl[9]))((IMediaEncodingProfile*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaEncodingProfile.xml' path='doc/member[@name="IMediaEncodingProfile.put_Container"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT put_Container([NativeTypeName("ABI::Windows::Media::MediaProperties::IContainerEncodingProperties *")] IContainerEncodingProperties* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaEncodingProfile*, IContainerEncodingProperties*, int>)(lpVtbl[10]))((IMediaEncodingProfile*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaEncodingProfile.xml' path='doc/member[@name="IMediaEncodingProfile.get_Container"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_Container([NativeTypeName("ABI::Windows::Media::MediaProperties::IContainerEncodingProperties **")] IContainerEncodingProperties** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaEncodingProfile*, IContainerEncodingProperties**, int>)(lpVtbl[11]))((IMediaEncodingProfile*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT put_Audio([NativeTypeName("ABI::Windows::Media::MediaProperties::IAudioEncodingProperties *")] IAudioEncodingProperties* value);

        [VtblIndex(7)]
        HRESULT get_Audio([NativeTypeName("ABI::Windows::Media::MediaProperties::IAudioEncodingProperties **")] IAudioEncodingProperties** value);

        [VtblIndex(8)]
        HRESULT put_Video([NativeTypeName("ABI::Windows::Media::MediaProperties::IVideoEncodingProperties *")] IVideoEncodingProperties* value);

        [VtblIndex(9)]
        HRESULT get_Video([NativeTypeName("ABI::Windows::Media::MediaProperties::IVideoEncodingProperties **")] IVideoEncodingProperties** value);

        [VtblIndex(10)]
        HRESULT put_Container([NativeTypeName("ABI::Windows::Media::MediaProperties::IContainerEncodingProperties *")] IContainerEncodingProperties* value);

        [VtblIndex(11)]
        HRESULT get_Container([NativeTypeName("ABI::Windows::Media::MediaProperties::IContainerEncodingProperties **")] IContainerEncodingProperties** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Media::MediaProperties::IAudioEncodingProperties *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAudioEncodingProperties*, int> put_Audio;

        [NativeTypeName("HRESULT (ABI::Windows::Media::MediaProperties::IAudioEncodingProperties **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAudioEncodingProperties**, int> get_Audio;

        [NativeTypeName("HRESULT (ABI::Windows::Media::MediaProperties::IVideoEncodingProperties *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVideoEncodingProperties*, int> put_Video;

        [NativeTypeName("HRESULT (ABI::Windows::Media::MediaProperties::IVideoEncodingProperties **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVideoEncodingProperties**, int> get_Video;

        [NativeTypeName("HRESULT (ABI::Windows::Media::MediaProperties::IContainerEncodingProperties *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IContainerEncodingProperties*, int> put_Container;

        [NativeTypeName("HRESULT (ABI::Windows::Media::MediaProperties::IContainerEncodingProperties **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IContainerEncodingProperties**, int> get_Container;
    }
}
