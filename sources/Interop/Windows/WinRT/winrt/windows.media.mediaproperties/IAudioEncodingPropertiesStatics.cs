// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.mediaproperties.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IAudioEncodingPropertiesStatics.xml' path='doc/member[@name="IAudioEncodingPropertiesStatics"]/*' />
[Guid("0CAD332C-EBE9-4527-B36D-E42A13CF38DB")]
[NativeTypeName("struct IAudioEncodingPropertiesStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAudioEncodingPropertiesStatics : IAudioEncodingPropertiesStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAudioEncodingPropertiesStatics));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioEncodingPropertiesStatics*, Guid*, void**, int>)(lpVtbl[0]))((IAudioEncodingPropertiesStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioEncodingPropertiesStatics*, uint>)(lpVtbl[1]))((IAudioEncodingPropertiesStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioEncodingPropertiesStatics*, uint>)(lpVtbl[2]))((IAudioEncodingPropertiesStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioEncodingPropertiesStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IAudioEncodingPropertiesStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioEncodingPropertiesStatics*, HSTRING*, int>)(lpVtbl[4]))((IAudioEncodingPropertiesStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioEncodingPropertiesStatics*, TrustLevel*, int>)(lpVtbl[5]))((IAudioEncodingPropertiesStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IAudioEncodingPropertiesStatics.xml' path='doc/member[@name="IAudioEncodingPropertiesStatics.CreateAac"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateAac([NativeTypeName("UINT32")] uint sampleRate, [NativeTypeName("UINT32")] uint channelCount, [NativeTypeName("UINT32")] uint bitrate, [NativeTypeName("ABI::Windows::Media::MediaProperties::IAudioEncodingProperties **")] IAudioEncodingProperties** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioEncodingPropertiesStatics*, uint, uint, uint, IAudioEncodingProperties**, int>)(lpVtbl[6]))((IAudioEncodingPropertiesStatics*)Unsafe.AsPointer(ref this), sampleRate, channelCount, bitrate, value);
    }

    /// <include file='IAudioEncodingPropertiesStatics.xml' path='doc/member[@name="IAudioEncodingPropertiesStatics.CreateAacAdts"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateAacAdts([NativeTypeName("UINT32")] uint sampleRate, [NativeTypeName("UINT32")] uint channelCount, [NativeTypeName("UINT32")] uint bitrate, [NativeTypeName("ABI::Windows::Media::MediaProperties::IAudioEncodingProperties **")] IAudioEncodingProperties** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioEncodingPropertiesStatics*, uint, uint, uint, IAudioEncodingProperties**, int>)(lpVtbl[7]))((IAudioEncodingPropertiesStatics*)Unsafe.AsPointer(ref this), sampleRate, channelCount, bitrate, value);
    }

    /// <include file='IAudioEncodingPropertiesStatics.xml' path='doc/member[@name="IAudioEncodingPropertiesStatics.CreateMp3"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT CreateMp3([NativeTypeName("UINT32")] uint sampleRate, [NativeTypeName("UINT32")] uint channelCount, [NativeTypeName("UINT32")] uint bitrate, [NativeTypeName("ABI::Windows::Media::MediaProperties::IAudioEncodingProperties **")] IAudioEncodingProperties** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioEncodingPropertiesStatics*, uint, uint, uint, IAudioEncodingProperties**, int>)(lpVtbl[8]))((IAudioEncodingPropertiesStatics*)Unsafe.AsPointer(ref this), sampleRate, channelCount, bitrate, value);
    }

    /// <include file='IAudioEncodingPropertiesStatics.xml' path='doc/member[@name="IAudioEncodingPropertiesStatics.CreatePcm"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT CreatePcm([NativeTypeName("UINT32")] uint sampleRate, [NativeTypeName("UINT32")] uint channelCount, [NativeTypeName("UINT32")] uint bitsPerSample, [NativeTypeName("ABI::Windows::Media::MediaProperties::IAudioEncodingProperties **")] IAudioEncodingProperties** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioEncodingPropertiesStatics*, uint, uint, uint, IAudioEncodingProperties**, int>)(lpVtbl[9]))((IAudioEncodingPropertiesStatics*)Unsafe.AsPointer(ref this), sampleRate, channelCount, bitsPerSample, value);
    }

    /// <include file='IAudioEncodingPropertiesStatics.xml' path='doc/member[@name="IAudioEncodingPropertiesStatics.CreateWma"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT CreateWma([NativeTypeName("UINT32")] uint sampleRate, [NativeTypeName("UINT32")] uint channelCount, [NativeTypeName("UINT32")] uint bitrate, [NativeTypeName("ABI::Windows::Media::MediaProperties::IAudioEncodingProperties **")] IAudioEncodingProperties** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioEncodingPropertiesStatics*, uint, uint, uint, IAudioEncodingProperties**, int>)(lpVtbl[10]))((IAudioEncodingPropertiesStatics*)Unsafe.AsPointer(ref this), sampleRate, channelCount, bitrate, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateAac([NativeTypeName("UINT32")] uint sampleRate, [NativeTypeName("UINT32")] uint channelCount, [NativeTypeName("UINT32")] uint bitrate, [NativeTypeName("ABI::Windows::Media::MediaProperties::IAudioEncodingProperties **")] IAudioEncodingProperties** value);

        [VtblIndex(7)]
        HRESULT CreateAacAdts([NativeTypeName("UINT32")] uint sampleRate, [NativeTypeName("UINT32")] uint channelCount, [NativeTypeName("UINT32")] uint bitrate, [NativeTypeName("ABI::Windows::Media::MediaProperties::IAudioEncodingProperties **")] IAudioEncodingProperties** value);

        [VtblIndex(8)]
        HRESULT CreateMp3([NativeTypeName("UINT32")] uint sampleRate, [NativeTypeName("UINT32")] uint channelCount, [NativeTypeName("UINT32")] uint bitrate, [NativeTypeName("ABI::Windows::Media::MediaProperties::IAudioEncodingProperties **")] IAudioEncodingProperties** value);

        [VtblIndex(9)]
        HRESULT CreatePcm([NativeTypeName("UINT32")] uint sampleRate, [NativeTypeName("UINT32")] uint channelCount, [NativeTypeName("UINT32")] uint bitsPerSample, [NativeTypeName("ABI::Windows::Media::MediaProperties::IAudioEncodingProperties **")] IAudioEncodingProperties** value);

        [VtblIndex(10)]
        HRESULT CreateWma([NativeTypeName("UINT32")] uint sampleRate, [NativeTypeName("UINT32")] uint channelCount, [NativeTypeName("UINT32")] uint bitrate, [NativeTypeName("ABI::Windows::Media::MediaProperties::IAudioEncodingProperties **")] IAudioEncodingProperties** value);
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

        [NativeTypeName("HRESULT (UINT32, UINT32, UINT32, ABI::Windows::Media::MediaProperties::IAudioEncodingProperties **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint, uint, IAudioEncodingProperties**, int> CreateAac;

        [NativeTypeName("HRESULT (UINT32, UINT32, UINT32, ABI::Windows::Media::MediaProperties::IAudioEncodingProperties **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint, uint, IAudioEncodingProperties**, int> CreateAacAdts;

        [NativeTypeName("HRESULT (UINT32, UINT32, UINT32, ABI::Windows::Media::MediaProperties::IAudioEncodingProperties **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint, uint, IAudioEncodingProperties**, int> CreateMp3;

        [NativeTypeName("HRESULT (UINT32, UINT32, UINT32, ABI::Windows::Media::MediaProperties::IAudioEncodingProperties **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint, uint, IAudioEncodingProperties**, int> CreatePcm;

        [NativeTypeName("HRESULT (UINT32, UINT32, UINT32, ABI::Windows::Media::MediaProperties::IAudioEncodingProperties **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint, uint, IAudioEncodingProperties**, int> CreateWma;
    }
}
