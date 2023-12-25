// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.capture.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IMediaCaptureSettings2.xml' path='doc/member[@name="IMediaCaptureSettings2"]/*' />
[Guid("6F9E7CFB-FA9F-4B13-9CBE-5AB94F1F3493")]
[NativeTypeName("struct IMediaCaptureSettings2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IMediaCaptureSettings2 : IMediaCaptureSettings2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMediaCaptureSettings2));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCaptureSettings2*, Guid*, void**, int>)(lpVtbl[0]))((IMediaCaptureSettings2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCaptureSettings2*, uint>)(lpVtbl[1]))((IMediaCaptureSettings2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCaptureSettings2*, uint>)(lpVtbl[2]))((IMediaCaptureSettings2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCaptureSettings2*, uint*, Guid**, int>)(lpVtbl[3]))((IMediaCaptureSettings2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCaptureSettings2*, HSTRING*, int>)(lpVtbl[4]))((IMediaCaptureSettings2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCaptureSettings2*, TrustLevel*, int>)(lpVtbl[5]))((IMediaCaptureSettings2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IMediaCaptureSettings2.xml' path='doc/member[@name="IMediaCaptureSettings2.get_ConcurrentRecordAndPhotoSupported"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_ConcurrentRecordAndPhotoSupported([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCaptureSettings2*, byte*, int>)(lpVtbl[6]))((IMediaCaptureSettings2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaCaptureSettings2.xml' path='doc/member[@name="IMediaCaptureSettings2.get_ConcurrentRecordAndPhotoSequenceSupported"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_ConcurrentRecordAndPhotoSequenceSupported([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCaptureSettings2*, byte*, int>)(lpVtbl[7]))((IMediaCaptureSettings2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaCaptureSettings2.xml' path='doc/member[@name="IMediaCaptureSettings2.get_CameraSoundRequiredForRegion"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_CameraSoundRequiredForRegion([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCaptureSettings2*, byte*, int>)(lpVtbl[8]))((IMediaCaptureSettings2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaCaptureSettings2.xml' path='doc/member[@name="IMediaCaptureSettings2.get_Horizontal35mmEquivalentFocalLength"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_Horizontal35mmEquivalentFocalLength([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT32_t **")] IReference<uint>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCaptureSettings2*, IReference<uint>**, int>)(lpVtbl[9]))((IMediaCaptureSettings2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaCaptureSettings2.xml' path='doc/member[@name="IMediaCaptureSettings2.get_PitchOffsetDegrees"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_PitchOffsetDegrees([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_int_t **")] IReference<int>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCaptureSettings2*, IReference<int>**, int>)(lpVtbl[10]))((IMediaCaptureSettings2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaCaptureSettings2.xml' path='doc/member[@name="IMediaCaptureSettings2.get_Vertical35mmEquivalentFocalLength"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_Vertical35mmEquivalentFocalLength([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT32_t **")] IReference<uint>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCaptureSettings2*, IReference<uint>**, int>)(lpVtbl[11]))((IMediaCaptureSettings2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaCaptureSettings2.xml' path='doc/member[@name="IMediaCaptureSettings2.get_MediaCategory"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_MediaCategory([NativeTypeName("ABI::Windows::Media::Capture::MediaCategory *")] MediaCategory* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCaptureSettings2*, MediaCategory*, int>)(lpVtbl[12]))((IMediaCaptureSettings2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaCaptureSettings2.xml' path='doc/member[@name="IMediaCaptureSettings2.get_AudioProcessing"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_AudioProcessing([NativeTypeName("ABI::Windows::Media::AudioProcessing *")] AudioProcessing* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCaptureSettings2*, AudioProcessing*, int>)(lpVtbl[13]))((IMediaCaptureSettings2*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_ConcurrentRecordAndPhotoSupported([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(7)]
        HRESULT get_ConcurrentRecordAndPhotoSequenceSupported([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(8)]
        HRESULT get_CameraSoundRequiredForRegion([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(9)]
        HRESULT get_Horizontal35mmEquivalentFocalLength([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT32_t **")] IReference<uint>** value);

        [VtblIndex(10)]
        HRESULT get_PitchOffsetDegrees([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_int_t **")] IReference<int>** value);

        [VtblIndex(11)]
        HRESULT get_Vertical35mmEquivalentFocalLength([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT32_t **")] IReference<uint>** value);

        [VtblIndex(12)]
        HRESULT get_MediaCategory([NativeTypeName("ABI::Windows::Media::Capture::MediaCategory *")] MediaCategory* value);

        [VtblIndex(13)]
        HRESULT get_AudioProcessing([NativeTypeName("ABI::Windows::Media::AudioProcessing *")] AudioProcessing* value);
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

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_ConcurrentRecordAndPhotoSupported;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_ConcurrentRecordAndPhotoSequenceSupported;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_CameraSoundRequiredForRegion;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_UINT32_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<uint>**, int> get_Horizontal35mmEquivalentFocalLength;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_int_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<int>**, int> get_PitchOffsetDegrees;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_UINT32_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<uint>**, int> get_Vertical35mmEquivalentFocalLength;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Capture::MediaCategory *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, MediaCategory*, int> get_MediaCategory;

        [NativeTypeName("HRESULT (ABI::Windows::Media::AudioProcessing *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, AudioProcessing*, int> get_AudioProcessing;
    }
}
