// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.capture.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IMediaCaptureVideoProfile.xml' path='doc/member[@name="IMediaCaptureVideoProfile"]/*' />
[Guid("21A073BF-A3EE-4ECF-9EF6-50B0BC4E1305")]
[NativeTypeName("struct IMediaCaptureVideoProfile : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IMediaCaptureVideoProfile : IMediaCaptureVideoProfile.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMediaCaptureVideoProfile));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCaptureVideoProfile*, Guid*, void**, int>)(lpVtbl[0]))((IMediaCaptureVideoProfile*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCaptureVideoProfile*, uint>)(lpVtbl[1]))((IMediaCaptureVideoProfile*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCaptureVideoProfile*, uint>)(lpVtbl[2]))((IMediaCaptureVideoProfile*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCaptureVideoProfile*, uint*, Guid**, int>)(lpVtbl[3]))((IMediaCaptureVideoProfile*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCaptureVideoProfile*, HSTRING*, int>)(lpVtbl[4]))((IMediaCaptureVideoProfile*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCaptureVideoProfile*, TrustLevel*, int>)(lpVtbl[5]))((IMediaCaptureVideoProfile*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IMediaCaptureVideoProfile.xml' path='doc/member[@name="IMediaCaptureVideoProfile.get_Id"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Id(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCaptureVideoProfile*, HSTRING*, int>)(lpVtbl[6]))((IMediaCaptureVideoProfile*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaCaptureVideoProfile.xml' path='doc/member[@name="IMediaCaptureVideoProfile.get_VideoDeviceId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_VideoDeviceId(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCaptureVideoProfile*, HSTRING*, int>)(lpVtbl[7]))((IMediaCaptureVideoProfile*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaCaptureVideoProfile.xml' path='doc/member[@name="IMediaCaptureVideoProfile.get_SupportedPreviewMediaDescription"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_SupportedPreviewMediaDescription([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CMedia__CCapture__CMediaCaptureVideoProfileMediaDescription_t **")] IVectorView<IntPtr>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCaptureVideoProfile*, IVectorView<IntPtr>**, int>)(lpVtbl[8]))((IMediaCaptureVideoProfile*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaCaptureVideoProfile.xml' path='doc/member[@name="IMediaCaptureVideoProfile.get_SupportedRecordMediaDescription"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_SupportedRecordMediaDescription([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CMedia__CCapture__CMediaCaptureVideoProfileMediaDescription_t **")] IVectorView<IntPtr>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCaptureVideoProfile*, IVectorView<IntPtr>**, int>)(lpVtbl[9]))((IMediaCaptureVideoProfile*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaCaptureVideoProfile.xml' path='doc/member[@name="IMediaCaptureVideoProfile.get_SupportedPhotoMediaDescription"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_SupportedPhotoMediaDescription([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CMedia__CCapture__CMediaCaptureVideoProfileMediaDescription_t **")] IVectorView<IntPtr>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCaptureVideoProfile*, IVectorView<IntPtr>**, int>)(lpVtbl[10]))((IMediaCaptureVideoProfile*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaCaptureVideoProfile.xml' path='doc/member[@name="IMediaCaptureVideoProfile.GetConcurrency"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetConcurrency([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CMedia__CCapture__CMediaCaptureVideoProfile_t **")] IVectorView<IntPtr>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCaptureVideoProfile*, IVectorView<IntPtr>**, int>)(lpVtbl[11]))((IMediaCaptureVideoProfile*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Id(HSTRING* value);

        [VtblIndex(7)]
        HRESULT get_VideoDeviceId(HSTRING* value);

        [VtblIndex(8)]
        HRESULT get_SupportedPreviewMediaDescription([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CMedia__CCapture__CMediaCaptureVideoProfileMediaDescription_t **")] IVectorView<IntPtr>** value);

        [VtblIndex(9)]
        HRESULT get_SupportedRecordMediaDescription([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CMedia__CCapture__CMediaCaptureVideoProfileMediaDescription_t **")] IVectorView<IntPtr>** value);

        [VtblIndex(10)]
        HRESULT get_SupportedPhotoMediaDescription([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CMedia__CCapture__CMediaCaptureVideoProfileMediaDescription_t **")] IVectorView<IntPtr>** value);

        [VtblIndex(11)]
        HRESULT GetConcurrency([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CMedia__CCapture__CMediaCaptureVideoProfile_t **")] IVectorView<IntPtr>** value);
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

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Id;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_VideoDeviceId;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CMedia__CCapture__CMediaCaptureVideoProfileMediaDescription_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVectorView<IntPtr>**, int> get_SupportedPreviewMediaDescription;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CMedia__CCapture__CMediaCaptureVideoProfileMediaDescription_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVectorView<IntPtr>**, int> get_SupportedRecordMediaDescription;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CMedia__CCapture__CMediaCaptureVideoProfileMediaDescription_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVectorView<IntPtr>**, int> get_SupportedPhotoMediaDescription;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CMedia__CCapture__CMediaCaptureVideoProfile_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVectorView<IntPtr>**, int> GetConcurrency;
    }
}
