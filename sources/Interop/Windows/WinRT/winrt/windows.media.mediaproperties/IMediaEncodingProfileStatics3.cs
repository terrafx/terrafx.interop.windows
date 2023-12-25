// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.mediaproperties.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IMediaEncodingProfileStatics3.xml' path='doc/member[@name="IMediaEncodingProfileStatics3"]/*' />
[Guid("90DAC5AA-CF76-4294-A9ED-1A1420F51F6B")]
[NativeTypeName("struct IMediaEncodingProfileStatics3 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IMediaEncodingProfileStatics3 : IMediaEncodingProfileStatics3.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMediaEncodingProfileStatics3));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaEncodingProfileStatics3*, Guid*, void**, int>)(lpVtbl[0]))((IMediaEncodingProfileStatics3*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaEncodingProfileStatics3*, uint>)(lpVtbl[1]))((IMediaEncodingProfileStatics3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaEncodingProfileStatics3*, uint>)(lpVtbl[2]))((IMediaEncodingProfileStatics3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaEncodingProfileStatics3*, uint*, Guid**, int>)(lpVtbl[3]))((IMediaEncodingProfileStatics3*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaEncodingProfileStatics3*, HSTRING*, int>)(lpVtbl[4]))((IMediaEncodingProfileStatics3*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaEncodingProfileStatics3*, TrustLevel*, int>)(lpVtbl[5]))((IMediaEncodingProfileStatics3*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IMediaEncodingProfileStatics3.xml' path='doc/member[@name="IMediaEncodingProfileStatics3.CreateAlac"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateAlac([NativeTypeName("ABI::Windows::Media::MediaProperties::AudioEncodingQuality")] AudioEncodingQuality quality, [NativeTypeName("ABI::Windows::Media::MediaProperties::IMediaEncodingProfile **")] IMediaEncodingProfile** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaEncodingProfileStatics3*, AudioEncodingQuality, IMediaEncodingProfile**, int>)(lpVtbl[6]))((IMediaEncodingProfileStatics3*)Unsafe.AsPointer(ref this), quality, value);
    }

    /// <include file='IMediaEncodingProfileStatics3.xml' path='doc/member[@name="IMediaEncodingProfileStatics3.CreateFlac"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateFlac([NativeTypeName("ABI::Windows::Media::MediaProperties::AudioEncodingQuality")] AudioEncodingQuality quality, [NativeTypeName("ABI::Windows::Media::MediaProperties::IMediaEncodingProfile **")] IMediaEncodingProfile** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaEncodingProfileStatics3*, AudioEncodingQuality, IMediaEncodingProfile**, int>)(lpVtbl[7]))((IMediaEncodingProfileStatics3*)Unsafe.AsPointer(ref this), quality, value);
    }

    /// <include file='IMediaEncodingProfileStatics3.xml' path='doc/member[@name="IMediaEncodingProfileStatics3.CreateHevc"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT CreateHevc([NativeTypeName("ABI::Windows::Media::MediaProperties::VideoEncodingQuality")] VideoEncodingQuality quality, [NativeTypeName("ABI::Windows::Media::MediaProperties::IMediaEncodingProfile **")] IMediaEncodingProfile** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaEncodingProfileStatics3*, VideoEncodingQuality, IMediaEncodingProfile**, int>)(lpVtbl[8]))((IMediaEncodingProfileStatics3*)Unsafe.AsPointer(ref this), quality, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateAlac([NativeTypeName("ABI::Windows::Media::MediaProperties::AudioEncodingQuality")] AudioEncodingQuality quality, [NativeTypeName("ABI::Windows::Media::MediaProperties::IMediaEncodingProfile **")] IMediaEncodingProfile** value);

        [VtblIndex(7)]
        HRESULT CreateFlac([NativeTypeName("ABI::Windows::Media::MediaProperties::AudioEncodingQuality")] AudioEncodingQuality quality, [NativeTypeName("ABI::Windows::Media::MediaProperties::IMediaEncodingProfile **")] IMediaEncodingProfile** value);

        [VtblIndex(8)]
        HRESULT CreateHevc([NativeTypeName("ABI::Windows::Media::MediaProperties::VideoEncodingQuality")] VideoEncodingQuality quality, [NativeTypeName("ABI::Windows::Media::MediaProperties::IMediaEncodingProfile **")] IMediaEncodingProfile** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Media::MediaProperties::AudioEncodingQuality, ABI::Windows::Media::MediaProperties::IMediaEncodingProfile **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, AudioEncodingQuality, IMediaEncodingProfile**, int> CreateAlac;

        [NativeTypeName("HRESULT (ABI::Windows::Media::MediaProperties::AudioEncodingQuality, ABI::Windows::Media::MediaProperties::IMediaEncodingProfile **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, AudioEncodingQuality, IMediaEncodingProfile**, int> CreateFlac;

        [NativeTypeName("HRESULT (ABI::Windows::Media::MediaProperties::VideoEncodingQuality, ABI::Windows::Media::MediaProperties::IMediaEncodingProfile **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, VideoEncodingQuality, IMediaEncodingProfile**, int> CreateHevc;
    }
}
