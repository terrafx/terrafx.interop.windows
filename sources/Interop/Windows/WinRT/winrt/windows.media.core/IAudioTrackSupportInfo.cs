// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IAudioTrackSupportInfo.xml' path='doc/member[@name="IAudioTrackSupportInfo"]/*' />
[Guid("178BEFF7-CC39-44A6-B951-4A5653F073FA")]
[NativeTypeName("struct IAudioTrackSupportInfo : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAudioTrackSupportInfo : IAudioTrackSupportInfo.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAudioTrackSupportInfo));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioTrackSupportInfo*, Guid*, void**, int>)(lpVtbl[0]))((IAudioTrackSupportInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioTrackSupportInfo*, uint>)(lpVtbl[1]))((IAudioTrackSupportInfo*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioTrackSupportInfo*, uint>)(lpVtbl[2]))((IAudioTrackSupportInfo*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioTrackSupportInfo*, uint*, Guid**, int>)(lpVtbl[3]))((IAudioTrackSupportInfo*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioTrackSupportInfo*, HSTRING*, int>)(lpVtbl[4]))((IAudioTrackSupportInfo*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioTrackSupportInfo*, TrustLevel*, int>)(lpVtbl[5]))((IAudioTrackSupportInfo*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IAudioTrackSupportInfo.xml' path='doc/member[@name="IAudioTrackSupportInfo.get_DecoderStatus"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_DecoderStatus([NativeTypeName("ABI::Windows::Media::Core::MediaDecoderStatus *")] MediaDecoderStatus* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioTrackSupportInfo*, MediaDecoderStatus*, int>)(lpVtbl[6]))((IAudioTrackSupportInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAudioTrackSupportInfo.xml' path='doc/member[@name="IAudioTrackSupportInfo.get_Degradation"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Degradation([NativeTypeName("ABI::Windows::Media::Core::AudioDecoderDegradation *")] AudioDecoderDegradation* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioTrackSupportInfo*, AudioDecoderDegradation*, int>)(lpVtbl[7]))((IAudioTrackSupportInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAudioTrackSupportInfo.xml' path='doc/member[@name="IAudioTrackSupportInfo.get_DegradationReason"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_DegradationReason([NativeTypeName("ABI::Windows::Media::Core::AudioDecoderDegradationReason *")] AudioDecoderDegradationReason* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioTrackSupportInfo*, AudioDecoderDegradationReason*, int>)(lpVtbl[8]))((IAudioTrackSupportInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAudioTrackSupportInfo.xml' path='doc/member[@name="IAudioTrackSupportInfo.get_MediaSourceStatus"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_MediaSourceStatus([NativeTypeName("ABI::Windows::Media::Core::MediaSourceStatus *")] MediaSourceStatus* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioTrackSupportInfo*, MediaSourceStatus*, int>)(lpVtbl[9]))((IAudioTrackSupportInfo*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_DecoderStatus([NativeTypeName("ABI::Windows::Media::Core::MediaDecoderStatus *")] MediaDecoderStatus* value);

        [VtblIndex(7)]
        HRESULT get_Degradation([NativeTypeName("ABI::Windows::Media::Core::AudioDecoderDegradation *")] AudioDecoderDegradation* value);

        [VtblIndex(8)]
        HRESULT get_DegradationReason([NativeTypeName("ABI::Windows::Media::Core::AudioDecoderDegradationReason *")] AudioDecoderDegradationReason* value);

        [VtblIndex(9)]
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

        [NativeTypeName("HRESULT (ABI::Windows::Media::Core::AudioDecoderDegradation *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, AudioDecoderDegradation*, int> get_Degradation;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Core::AudioDecoderDegradationReason *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, AudioDecoderDegradationReason*, int> get_DegradationReason;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Core::MediaSourceStatus *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, MediaSourceStatus*, int> get_MediaSourceStatus;
    }
}
