// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.capture.frames.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IAudioMediaFrame.xml' path='doc/member[@name="IAudioMediaFrame"]/*' />
[Guid("A3A9FEFF-8021-441B-9A46-E7F0137B7981")]
[NativeTypeName("struct IAudioMediaFrame : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAudioMediaFrame : IAudioMediaFrame.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IAudioMediaFrame);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioMediaFrame*, Guid*, void**, int>)(lpVtbl[0]))((IAudioMediaFrame*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioMediaFrame*, uint>)(lpVtbl[1]))((IAudioMediaFrame*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioMediaFrame*, uint>)(lpVtbl[2]))((IAudioMediaFrame*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioMediaFrame*, uint*, Guid**, int>)(lpVtbl[3]))((IAudioMediaFrame*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioMediaFrame*, HSTRING*, int>)(lpVtbl[4]))((IAudioMediaFrame*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioMediaFrame*, TrustLevel*, int>)(lpVtbl[5]))((IAudioMediaFrame*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IAudioMediaFrame.xml' path='doc/member[@name="IAudioMediaFrame.get_FrameReference"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_FrameReference([NativeTypeName("ABI::Windows::Media::Capture::Frames::IMediaFrameReference **")] IMediaFrameReference** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioMediaFrame*, IMediaFrameReference**, int>)(lpVtbl[6]))((IAudioMediaFrame*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAudioMediaFrame.xml' path='doc/member[@name="IAudioMediaFrame.get_AudioEncodingProperties"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_AudioEncodingProperties([NativeTypeName("ABI::Windows::Media::MediaProperties::IAudioEncodingProperties **")] IAudioEncodingProperties** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioMediaFrame*, IAudioEncodingProperties**, int>)(lpVtbl[7]))((IAudioMediaFrame*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAudioMediaFrame.xml' path='doc/member[@name="IAudioMediaFrame.GetAudioFrame"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetAudioFrame([NativeTypeName("ABI::Windows::Media::IAudioFrame **")] IAudioFrame** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioMediaFrame*, IAudioFrame**, int>)(lpVtbl[8]))((IAudioMediaFrame*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_FrameReference([NativeTypeName("ABI::Windows::Media::Capture::Frames::IMediaFrameReference **")] IMediaFrameReference** value);

        [VtblIndex(7)]
        HRESULT get_AudioEncodingProperties([NativeTypeName("ABI::Windows::Media::MediaProperties::IAudioEncodingProperties **")] IAudioEncodingProperties** value);

        [VtblIndex(8)]
        HRESULT GetAudioFrame([NativeTypeName("ABI::Windows::Media::IAudioFrame **")] IAudioFrame** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Media::MediaProperties::IAudioEncodingProperties **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAudioEncodingProperties**, int> get_AudioEncodingProperties;

        [NativeTypeName("HRESULT (ABI::Windows::Media::IAudioFrame **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAudioFrame**, int> GetAudioFrame;
    }
}
