// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.capture.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IMediaCaptureVideoPreview.xml' path='doc/member[@name="IMediaCaptureVideoPreview"]/*' />
[Guid("27727073-549E-447F-A20A-4F03C479D8C0")]
[NativeTypeName("struct IMediaCaptureVideoPreview : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IMediaCaptureVideoPreview : IMediaCaptureVideoPreview.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMediaCaptureVideoPreview));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCaptureVideoPreview*, Guid*, void**, int>)(lpVtbl[0]))((IMediaCaptureVideoPreview*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCaptureVideoPreview*, uint>)(lpVtbl[1]))((IMediaCaptureVideoPreview*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCaptureVideoPreview*, uint>)(lpVtbl[2]))((IMediaCaptureVideoPreview*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCaptureVideoPreview*, uint*, Guid**, int>)(lpVtbl[3]))((IMediaCaptureVideoPreview*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCaptureVideoPreview*, HSTRING*, int>)(lpVtbl[4]))((IMediaCaptureVideoPreview*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCaptureVideoPreview*, TrustLevel*, int>)(lpVtbl[5]))((IMediaCaptureVideoPreview*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IMediaCaptureVideoPreview.xml' path='doc/member[@name="IMediaCaptureVideoPreview.StartPreviewAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT StartPreviewAsync([NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** asyncInfo)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCaptureVideoPreview*, IAsyncAction**, int>)(lpVtbl[6]))((IMediaCaptureVideoPreview*)Unsafe.AsPointer(ref this), asyncInfo);
    }

    /// <include file='IMediaCaptureVideoPreview.xml' path='doc/member[@name="IMediaCaptureVideoPreview.StartPreviewToCustomSinkAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT StartPreviewToCustomSinkAsync([NativeTypeName("ABI::Windows::Media::MediaProperties::IMediaEncodingProfile *")] IMediaEncodingProfile* encodingProfile, [NativeTypeName("ABI::Windows::Media::IMediaExtension *")] IMediaExtension* customMediaSink, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** asyncInfo)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCaptureVideoPreview*, IMediaEncodingProfile*, IMediaExtension*, IAsyncAction**, int>)(lpVtbl[7]))((IMediaCaptureVideoPreview*)Unsafe.AsPointer(ref this), encodingProfile, customMediaSink, asyncInfo);
    }

    /// <include file='IMediaCaptureVideoPreview.xml' path='doc/member[@name="IMediaCaptureVideoPreview.StartPreviewToCustomSinkIdAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT StartPreviewToCustomSinkIdAsync([NativeTypeName("ABI::Windows::Media::MediaProperties::IMediaEncodingProfile *")] IMediaEncodingProfile* encodingProfile, HSTRING customSinkActivationId, [NativeTypeName("ABI::Windows::Foundation::Collections::IPropertySet *")] IPropertySet* customSinkSettings, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** asyncInfo)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCaptureVideoPreview*, IMediaEncodingProfile*, HSTRING, IPropertySet*, IAsyncAction**, int>)(lpVtbl[8]))((IMediaCaptureVideoPreview*)Unsafe.AsPointer(ref this), encodingProfile, customSinkActivationId, customSinkSettings, asyncInfo);
    }

    /// <include file='IMediaCaptureVideoPreview.xml' path='doc/member[@name="IMediaCaptureVideoPreview.StopPreviewAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT StopPreviewAsync([NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** asyncInfo)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaCaptureVideoPreview*, IAsyncAction**, int>)(lpVtbl[9]))((IMediaCaptureVideoPreview*)Unsafe.AsPointer(ref this), asyncInfo);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT StartPreviewAsync([NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** asyncInfo);

        [VtblIndex(7)]
        HRESULT StartPreviewToCustomSinkAsync([NativeTypeName("ABI::Windows::Media::MediaProperties::IMediaEncodingProfile *")] IMediaEncodingProfile* encodingProfile, [NativeTypeName("ABI::Windows::Media::IMediaExtension *")] IMediaExtension* customMediaSink, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** asyncInfo);

        [VtblIndex(8)]
        HRESULT StartPreviewToCustomSinkIdAsync([NativeTypeName("ABI::Windows::Media::MediaProperties::IMediaEncodingProfile *")] IMediaEncodingProfile* encodingProfile, HSTRING customSinkActivationId, [NativeTypeName("ABI::Windows::Foundation::Collections::IPropertySet *")] IPropertySet* customSinkSettings, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** asyncInfo);

        [VtblIndex(9)]
        HRESULT StopPreviewAsync([NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** asyncInfo);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncAction**, int> StartPreviewAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Media::MediaProperties::IMediaEncodingProfile *, ABI::Windows::Media::IMediaExtension *, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMediaEncodingProfile*, IMediaExtension*, IAsyncAction**, int> StartPreviewToCustomSinkAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Media::MediaProperties::IMediaEncodingProfile *, HSTRING, ABI::Windows::Foundation::Collections::IPropertySet *, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMediaEncodingProfile*, HSTRING, IPropertySet*, IAsyncAction**, int> StartPreviewToCustomSinkIdAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncAction**, int> StopPreviewAsync;
    }
}
