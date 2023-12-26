// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.editing.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IMediaClip.xml' path='doc/member[@name="IMediaClip"]/*' />
[Guid("53F25366-5FBA-3EA4-8693-24761811140A")]
[NativeTypeName("struct IMediaClip : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IMediaClip : IMediaClip.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMediaClip));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaClip*, Guid*, void**, int>)(lpVtbl[0]))((IMediaClip*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaClip*, uint>)(lpVtbl[1]))((IMediaClip*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaClip*, uint>)(lpVtbl[2]))((IMediaClip*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaClip*, uint*, Guid**, int>)(lpVtbl[3]))((IMediaClip*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaClip*, HSTRING*, int>)(lpVtbl[4]))((IMediaClip*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaClip*, TrustLevel*, int>)(lpVtbl[5]))((IMediaClip*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IMediaClip.xml' path='doc/member[@name="IMediaClip.get_TrimTimeFromStart"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_TrimTimeFromStart([NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaClip*, TimeSpan*, int>)(lpVtbl[6]))((IMediaClip*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaClip.xml' path='doc/member[@name="IMediaClip.put_TrimTimeFromStart"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_TrimTimeFromStart([NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaClip*, TimeSpan, int>)(lpVtbl[7]))((IMediaClip*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaClip.xml' path='doc/member[@name="IMediaClip.get_TrimTimeFromEnd"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_TrimTimeFromEnd([NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaClip*, TimeSpan*, int>)(lpVtbl[8]))((IMediaClip*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaClip.xml' path='doc/member[@name="IMediaClip.put_TrimTimeFromEnd"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_TrimTimeFromEnd([NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaClip*, TimeSpan, int>)(lpVtbl[9]))((IMediaClip*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaClip.xml' path='doc/member[@name="IMediaClip.get_OriginalDuration"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_OriginalDuration([NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaClip*, TimeSpan*, int>)(lpVtbl[10]))((IMediaClip*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaClip.xml' path='doc/member[@name="IMediaClip.get_TrimmedDuration"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_TrimmedDuration([NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaClip*, TimeSpan*, int>)(lpVtbl[11]))((IMediaClip*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaClip.xml' path='doc/member[@name="IMediaClip.get_UserData"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_UserData([NativeTypeName("ABI::Windows::Foundation::Collections::__FIMap_2_HSTRING_HSTRING_t **")] IMap<HSTRING, HSTRING>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaClip*, IMap<HSTRING, HSTRING>**, int>)(lpVtbl[12]))((IMediaClip*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaClip.xml' path='doc/member[@name="IMediaClip.Clone"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT Clone([NativeTypeName("ABI::Windows::Media::Editing::IMediaClip **")] IMediaClip** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaClip*, IMediaClip**, int>)(lpVtbl[13]))((IMediaClip*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='IMediaClip.xml' path='doc/member[@name="IMediaClip.get_StartTimeInComposition"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_StartTimeInComposition([NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaClip*, TimeSpan*, int>)(lpVtbl[14]))((IMediaClip*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaClip.xml' path='doc/member[@name="IMediaClip.get_EndTimeInComposition"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_EndTimeInComposition([NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaClip*, TimeSpan*, int>)(lpVtbl[15]))((IMediaClip*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaClip.xml' path='doc/member[@name="IMediaClip.get_EmbeddedAudioTracks"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_EmbeddedAudioTracks([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CMedia__CEditing__CEmbeddedAudioTrack_t **")] IVectorView<IntPtr>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaClip*, IVectorView<IntPtr>**, int>)(lpVtbl[16]))((IMediaClip*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaClip.xml' path='doc/member[@name="IMediaClip.get_SelectedEmbeddedAudioTrackIndex"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_SelectedEmbeddedAudioTrackIndex([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaClip*, uint*, int>)(lpVtbl[17]))((IMediaClip*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaClip.xml' path='doc/member[@name="IMediaClip.put_SelectedEmbeddedAudioTrackIndex"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT put_SelectedEmbeddedAudioTrackIndex([NativeTypeName("UINT32")] uint value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaClip*, uint, int>)(lpVtbl[18]))((IMediaClip*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaClip.xml' path='doc/member[@name="IMediaClip.put_Volume"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT put_Volume(double value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaClip*, double, int>)(lpVtbl[19]))((IMediaClip*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaClip.xml' path='doc/member[@name="IMediaClip.get_Volume"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT get_Volume(double* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaClip*, double*, int>)(lpVtbl[20]))((IMediaClip*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaClip.xml' path='doc/member[@name="IMediaClip.GetVideoEncodingProperties"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT GetVideoEncodingProperties([NativeTypeName("ABI::Windows::Media::MediaProperties::IVideoEncodingProperties **")] IVideoEncodingProperties** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaClip*, IVideoEncodingProperties**, int>)(lpVtbl[21]))((IMediaClip*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaClip.xml' path='doc/member[@name="IMediaClip.get_AudioEffectDefinitions"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT get_AudioEffectDefinitions([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CMedia__CEffects__CIAudioEffectDefinition_t **")] IVector<IntPtr>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaClip*, IVector<IntPtr>**, int>)(lpVtbl[22]))((IMediaClip*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaClip.xml' path='doc/member[@name="IMediaClip.get_VideoEffectDefinitions"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT get_VideoEffectDefinitions([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CMedia__CEffects__CIVideoEffectDefinition_t **")] IVector<IntPtr>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaClip*, IVector<IntPtr>**, int>)(lpVtbl[23]))((IMediaClip*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_TrimTimeFromStart([NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value);

        [VtblIndex(7)]
        HRESULT put_TrimTimeFromStart([NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan value);

        [VtblIndex(8)]
        HRESULT get_TrimTimeFromEnd([NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value);

        [VtblIndex(9)]
        HRESULT put_TrimTimeFromEnd([NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan value);

        [VtblIndex(10)]
        HRESULT get_OriginalDuration([NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value);

        [VtblIndex(11)]
        HRESULT get_TrimmedDuration([NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value);

        [VtblIndex(12)]
        HRESULT get_UserData([NativeTypeName("ABI::Windows::Foundation::Collections::__FIMap_2_HSTRING_HSTRING_t **")] IMap<HSTRING, HSTRING>** value);

        [VtblIndex(13)]
        HRESULT Clone([NativeTypeName("ABI::Windows::Media::Editing::IMediaClip **")] IMediaClip** result);

        [VtblIndex(14)]
        HRESULT get_StartTimeInComposition([NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value);

        [VtblIndex(15)]
        HRESULT get_EndTimeInComposition([NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value);

        [VtblIndex(16)]
        HRESULT get_EmbeddedAudioTracks([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CMedia__CEditing__CEmbeddedAudioTrack_t **")] IVectorView<IntPtr>** value);

        [VtblIndex(17)]
        HRESULT get_SelectedEmbeddedAudioTrackIndex([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(18)]
        HRESULT put_SelectedEmbeddedAudioTrackIndex([NativeTypeName("UINT32")] uint value);

        [VtblIndex(19)]
        HRESULT put_Volume(double value);

        [VtblIndex(20)]
        HRESULT get_Volume(double* value);

        [VtblIndex(21)]
        HRESULT GetVideoEncodingProperties([NativeTypeName("ABI::Windows::Media::MediaProperties::IVideoEncodingProperties **")] IVideoEncodingProperties** value);

        [VtblIndex(22)]
        HRESULT get_AudioEffectDefinitions([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CMedia__CEffects__CIAudioEffectDefinition_t **")] IVector<IntPtr>** value);

        [VtblIndex(23)]
        HRESULT get_VideoEffectDefinitions([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CMedia__CEffects__CIVideoEffectDefinition_t **")] IVector<IntPtr>** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::TimeSpan *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TimeSpan*, int> get_TrimTimeFromStart;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::TimeSpan) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TimeSpan, int> put_TrimTimeFromStart;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::TimeSpan *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TimeSpan*, int> get_TrimTimeFromEnd;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::TimeSpan) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TimeSpan, int> put_TrimTimeFromEnd;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::TimeSpan *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TimeSpan*, int> get_OriginalDuration;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::TimeSpan *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TimeSpan*, int> get_TrimmedDuration;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIMap_2_HSTRING_HSTRING_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMap<HSTRING, HSTRING>**, int> get_UserData;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Editing::IMediaClip **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMediaClip**, int> Clone;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::TimeSpan *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TimeSpan*, int> get_StartTimeInComposition;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::TimeSpan *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TimeSpan*, int> get_EndTimeInComposition;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CMedia__CEditing__CEmbeddedAudioTrack_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVectorView<IntPtr>**, int> get_EmbeddedAudioTracks;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_SelectedEmbeddedAudioTrackIndex;

        [NativeTypeName("HRESULT (UINT32) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, int> put_SelectedEmbeddedAudioTrackIndex;

        [NativeTypeName("HRESULT (DOUBLE) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, double, int> put_Volume;

        [NativeTypeName("HRESULT (DOUBLE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, double*, int> get_Volume;

        [NativeTypeName("HRESULT (ABI::Windows::Media::MediaProperties::IVideoEncodingProperties **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVideoEncodingProperties**, int> GetVideoEncodingProperties;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CMedia__CEffects__CIAudioEffectDefinition_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVector<IntPtr>**, int> get_AudioEffectDefinitions;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CMedia__CEffects__CIVideoEffectDefinition_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVector<IntPtr>**, int> get_VideoEffectDefinitions;
    }
}
