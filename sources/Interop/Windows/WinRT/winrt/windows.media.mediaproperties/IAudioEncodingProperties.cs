// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.mediaproperties.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IAudioEncodingProperties.xml' path='doc/member[@name="IAudioEncodingProperties"]/*' />
[Guid("62BC7A16-005C-4B3B-8A0B-0A090E9687F3")]
[NativeTypeName("struct IAudioEncodingProperties : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAudioEncodingProperties : IAudioEncodingProperties.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAudioEncodingProperties));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioEncodingProperties*, Guid*, void**, int>)(lpVtbl[0]))((IAudioEncodingProperties*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioEncodingProperties*, uint>)(lpVtbl[1]))((IAudioEncodingProperties*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioEncodingProperties*, uint>)(lpVtbl[2]))((IAudioEncodingProperties*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioEncodingProperties*, uint*, Guid**, int>)(lpVtbl[3]))((IAudioEncodingProperties*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioEncodingProperties*, HSTRING*, int>)(lpVtbl[4]))((IAudioEncodingProperties*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioEncodingProperties*, TrustLevel*, int>)(lpVtbl[5]))((IAudioEncodingProperties*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IAudioEncodingProperties.xml' path='doc/member[@name="IAudioEncodingProperties.put_Bitrate"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT put_Bitrate([NativeTypeName("UINT32")] uint value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioEncodingProperties*, uint, int>)(lpVtbl[6]))((IAudioEncodingProperties*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAudioEncodingProperties.xml' path='doc/member[@name="IAudioEncodingProperties.get_Bitrate"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Bitrate([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioEncodingProperties*, uint*, int>)(lpVtbl[7]))((IAudioEncodingProperties*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAudioEncodingProperties.xml' path='doc/member[@name="IAudioEncodingProperties.put_ChannelCount"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT put_ChannelCount([NativeTypeName("UINT32")] uint value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioEncodingProperties*, uint, int>)(lpVtbl[8]))((IAudioEncodingProperties*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAudioEncodingProperties.xml' path='doc/member[@name="IAudioEncodingProperties.get_ChannelCount"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_ChannelCount([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioEncodingProperties*, uint*, int>)(lpVtbl[9]))((IAudioEncodingProperties*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAudioEncodingProperties.xml' path='doc/member[@name="IAudioEncodingProperties.put_SampleRate"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT put_SampleRate([NativeTypeName("UINT32")] uint value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioEncodingProperties*, uint, int>)(lpVtbl[10]))((IAudioEncodingProperties*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAudioEncodingProperties.xml' path='doc/member[@name="IAudioEncodingProperties.get_SampleRate"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_SampleRate([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioEncodingProperties*, uint*, int>)(lpVtbl[11]))((IAudioEncodingProperties*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAudioEncodingProperties.xml' path='doc/member[@name="IAudioEncodingProperties.put_BitsPerSample"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT put_BitsPerSample([NativeTypeName("UINT32")] uint value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioEncodingProperties*, uint, int>)(lpVtbl[12]))((IAudioEncodingProperties*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAudioEncodingProperties.xml' path='doc/member[@name="IAudioEncodingProperties.get_BitsPerSample"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_BitsPerSample([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioEncodingProperties*, uint*, int>)(lpVtbl[13]))((IAudioEncodingProperties*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT put_Bitrate([NativeTypeName("UINT32")] uint value);

        [VtblIndex(7)]
        HRESULT get_Bitrate([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(8)]
        HRESULT put_ChannelCount([NativeTypeName("UINT32")] uint value);

        [VtblIndex(9)]
        HRESULT get_ChannelCount([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(10)]
        HRESULT put_SampleRate([NativeTypeName("UINT32")] uint value);

        [VtblIndex(11)]
        HRESULT get_SampleRate([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(12)]
        HRESULT put_BitsPerSample([NativeTypeName("UINT32")] uint value);

        [VtblIndex(13)]
        HRESULT get_BitsPerSample([NativeTypeName("UINT32 *")] uint* value);
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

        [NativeTypeName("HRESULT (UINT32) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, int> put_Bitrate;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_Bitrate;

        [NativeTypeName("HRESULT (UINT32) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, int> put_ChannelCount;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_ChannelCount;

        [NativeTypeName("HRESULT (UINT32) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, int> put_SampleRate;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_SampleRate;

        [NativeTypeName("HRESULT (UINT32) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, int> put_BitsPerSample;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_BitsPerSample;
    }
}
