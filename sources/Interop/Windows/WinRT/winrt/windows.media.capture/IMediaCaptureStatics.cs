// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.capture.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IMediaCaptureStatics.xml' path='doc/member[@name="IMediaCaptureStatics"]/*' />
[Guid("ACEF81FF-99ED-4645-965E-1925CFC63834")]
[NativeTypeName("struct IMediaCaptureStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IMediaCaptureStatics : IMediaCaptureStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IMediaCaptureStatics);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCaptureStatics*, Guid*, void**, int>)(lpVtbl[0]))((IMediaCaptureStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCaptureStatics*, uint>)(lpVtbl[1]))((IMediaCaptureStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCaptureStatics*, uint>)(lpVtbl[2]))((IMediaCaptureStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCaptureStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IMediaCaptureStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCaptureStatics*, HSTRING*, int>)(lpVtbl[4]))((IMediaCaptureStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCaptureStatics*, TrustLevel*, int>)(lpVtbl[5]))((IMediaCaptureStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IMediaCaptureStatics.xml' path='doc/member[@name="IMediaCaptureStatics.IsVideoProfileSupported"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT IsVideoProfileSupported(HSTRING videoDeviceId, [NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCaptureStatics*, HSTRING, byte*, int>)(lpVtbl[6]))((IMediaCaptureStatics*)Unsafe.AsPointer(ref this), videoDeviceId, value);
    }

    /// <include file='IMediaCaptureStatics.xml' path='doc/member[@name="IMediaCaptureStatics.FindAllVideoProfiles"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT FindAllVideoProfiles(HSTRING videoDeviceId, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CMedia__CCapture__CMediaCaptureVideoProfile_t **")] IVectorView<Pointer<IMediaCaptureVideoProfile>>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCaptureStatics*, HSTRING, IVectorView<Pointer<IMediaCaptureVideoProfile>>**, int>)(lpVtbl[7]))((IMediaCaptureStatics*)Unsafe.AsPointer(ref this), videoDeviceId, value);
    }

    /// <include file='IMediaCaptureStatics.xml' path='doc/member[@name="IMediaCaptureStatics.FindConcurrentProfiles"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT FindConcurrentProfiles(HSTRING videoDeviceId, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CMedia__CCapture__CMediaCaptureVideoProfile_t **")] IVectorView<Pointer<IMediaCaptureVideoProfile>>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCaptureStatics*, HSTRING, IVectorView<Pointer<IMediaCaptureVideoProfile>>**, int>)(lpVtbl[8]))((IMediaCaptureStatics*)Unsafe.AsPointer(ref this), videoDeviceId, value);
    }

    /// <include file='IMediaCaptureStatics.xml' path='doc/member[@name="IMediaCaptureStatics.FindKnownVideoProfiles"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT FindKnownVideoProfiles(HSTRING videoDeviceId, [NativeTypeName("ABI::Windows::Media::Capture::KnownVideoProfile")] KnownVideoProfile name, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CMedia__CCapture__CMediaCaptureVideoProfile_t **")] IVectorView<Pointer<IMediaCaptureVideoProfile>>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCaptureStatics*, HSTRING, KnownVideoProfile, IVectorView<Pointer<IMediaCaptureVideoProfile>>**, int>)(lpVtbl[9]))((IMediaCaptureStatics*)Unsafe.AsPointer(ref this), videoDeviceId, name, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT IsVideoProfileSupported(HSTRING videoDeviceId, [NativeTypeName("boolean *")] byte* value);

        [VtblIndex(7)]
        HRESULT FindAllVideoProfiles(HSTRING videoDeviceId, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CMedia__CCapture__CMediaCaptureVideoProfile_t **")] IVectorView<Pointer<IMediaCaptureVideoProfile>>** value);

        [VtblIndex(8)]
        HRESULT FindConcurrentProfiles(HSTRING videoDeviceId, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CMedia__CCapture__CMediaCaptureVideoProfile_t **")] IVectorView<Pointer<IMediaCaptureVideoProfile>>** value);

        [VtblIndex(9)]
        HRESULT FindKnownVideoProfiles(HSTRING videoDeviceId, [NativeTypeName("ABI::Windows::Media::Capture::KnownVideoProfile")] KnownVideoProfile name, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CMedia__CCapture__CMediaCaptureVideoProfile_t **")] IVectorView<Pointer<IMediaCaptureVideoProfile>>** value);
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

        [NativeTypeName("HRESULT (HSTRING, boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, byte*, int> IsVideoProfileSupported;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CMedia__CCapture__CMediaCaptureVideoProfile_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IVectorView<Pointer<IMediaCaptureVideoProfile>>**, int> FindAllVideoProfiles;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CMedia__CCapture__CMediaCaptureVideoProfile_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IVectorView<Pointer<IMediaCaptureVideoProfile>>**, int> FindConcurrentProfiles;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Media::Capture::KnownVideoProfile, ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CMedia__CCapture__CMediaCaptureVideoProfile_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, KnownVideoProfile, IVectorView<Pointer<IMediaCaptureVideoProfile>>**, int> FindKnownVideoProfiles;
    }
}
