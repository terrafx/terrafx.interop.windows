// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IVideoTrackSupportInfo.xml' path='doc/member[@name="IVideoTrackSupportInfo"]/*' />
[Guid("4BB534A0-FC5F-450D-8FF0-778D590486DE")]
[NativeTypeName("struct IVideoTrackSupportInfo : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IVideoTrackSupportInfo : IVideoTrackSupportInfo.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IVideoTrackSupportInfo));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IVideoTrackSupportInfo*, Guid*, void**, int>)(lpVtbl[0]))((IVideoTrackSupportInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IVideoTrackSupportInfo*, uint>)(lpVtbl[1]))((IVideoTrackSupportInfo*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IVideoTrackSupportInfo*, uint>)(lpVtbl[2]))((IVideoTrackSupportInfo*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IVideoTrackSupportInfo*, uint*, Guid**, int>)(lpVtbl[3]))((IVideoTrackSupportInfo*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IVideoTrackSupportInfo*, HSTRING*, int>)(lpVtbl[4]))((IVideoTrackSupportInfo*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IVideoTrackSupportInfo*, TrustLevel*, int>)(lpVtbl[5]))((IVideoTrackSupportInfo*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IVideoTrackSupportInfo.xml' path='doc/member[@name="IVideoTrackSupportInfo.get_DecoderStatus"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_DecoderStatus([NativeTypeName("ABI::Windows::Media::Core::MediaDecoderStatus *")] MediaDecoderStatus* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IVideoTrackSupportInfo*, MediaDecoderStatus*, int>)(lpVtbl[6]))((IVideoTrackSupportInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IVideoTrackSupportInfo.xml' path='doc/member[@name="IVideoTrackSupportInfo.get_MediaSourceStatus"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_MediaSourceStatus([NativeTypeName("ABI::Windows::Media::Core::MediaSourceStatus *")] MediaSourceStatus* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IVideoTrackSupportInfo*, MediaSourceStatus*, int>)(lpVtbl[7]))((IVideoTrackSupportInfo*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_DecoderStatus([NativeTypeName("ABI::Windows::Media::Core::MediaDecoderStatus *")] MediaDecoderStatus* value);

        [VtblIndex(7)]
        HRESULT get_MediaSourceStatus([NativeTypeName("ABI::Windows::Media::Core::MediaSourceStatus *")] MediaSourceStatus* value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Media::Core::MediaDecoderStatus *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, MediaDecoderStatus*, int> get_DecoderStatus;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Core::MediaSourceStatus *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, MediaSourceStatus*, int> get_MediaSourceStatus;
    }
}
