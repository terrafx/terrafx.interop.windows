// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.devices.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IMediaDeviceController.xml' path='doc/member[@name="IMediaDeviceController"]/*' />
[Guid("F6F8F5CE-209A-48FB-86FC-D44578F317E6")]
[NativeTypeName("struct IMediaDeviceController : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IMediaDeviceController : IMediaDeviceController.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMediaDeviceController));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaDeviceController*, Guid*, void**, int>)(lpVtbl[0]))((IMediaDeviceController*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaDeviceController*, uint>)(lpVtbl[1]))((IMediaDeviceController*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaDeviceController*, uint>)(lpVtbl[2]))((IMediaDeviceController*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaDeviceController*, uint*, Guid**, int>)(lpVtbl[3]))((IMediaDeviceController*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaDeviceController*, HSTRING*, int>)(lpVtbl[4]))((IMediaDeviceController*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaDeviceController*, TrustLevel*, int>)(lpVtbl[5]))((IMediaDeviceController*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IMediaDeviceController.xml' path='doc/member[@name="IMediaDeviceController.GetAvailableMediaStreamProperties"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetAvailableMediaStreamProperties([NativeTypeName("ABI::Windows::Media::Capture::MediaStreamType")] MediaStreamType mediaStreamType, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CMedia__CMediaProperties__CIMediaEncodingProperties_t **")] IVectorView<Pointer<IMediaEncodingProperties>>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaDeviceController*, MediaStreamType, IVectorView<Pointer<IMediaEncodingProperties>>**, int>)(lpVtbl[6]))((IMediaDeviceController*)Unsafe.AsPointer(ref this), mediaStreamType, value);
    }

    /// <include file='IMediaDeviceController.xml' path='doc/member[@name="IMediaDeviceController.GetMediaStreamProperties"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetMediaStreamProperties([NativeTypeName("ABI::Windows::Media::Capture::MediaStreamType")] MediaStreamType mediaStreamType, [NativeTypeName("ABI::Windows::Media::MediaProperties::IMediaEncodingProperties **")] IMediaEncodingProperties** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaDeviceController*, MediaStreamType, IMediaEncodingProperties**, int>)(lpVtbl[7]))((IMediaDeviceController*)Unsafe.AsPointer(ref this), mediaStreamType, value);
    }

    /// <include file='IMediaDeviceController.xml' path='doc/member[@name="IMediaDeviceController.SetMediaStreamPropertiesAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SetMediaStreamPropertiesAsync([NativeTypeName("ABI::Windows::Media::Capture::MediaStreamType")] MediaStreamType mediaStreamType, [NativeTypeName("ABI::Windows::Media::MediaProperties::IMediaEncodingProperties *")] IMediaEncodingProperties* mediaEncodingProperties, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** asyncInfo)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaDeviceController*, MediaStreamType, IMediaEncodingProperties*, IAsyncAction**, int>)(lpVtbl[8]))((IMediaDeviceController*)Unsafe.AsPointer(ref this), mediaStreamType, mediaEncodingProperties, asyncInfo);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT GetAvailableMediaStreamProperties([NativeTypeName("ABI::Windows::Media::Capture::MediaStreamType")] MediaStreamType mediaStreamType, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CMedia__CMediaProperties__CIMediaEncodingProperties_t **")] IVectorView<Pointer<IMediaEncodingProperties>>** value);

        [VtblIndex(7)]
        HRESULT GetMediaStreamProperties([NativeTypeName("ABI::Windows::Media::Capture::MediaStreamType")] MediaStreamType mediaStreamType, [NativeTypeName("ABI::Windows::Media::MediaProperties::IMediaEncodingProperties **")] IMediaEncodingProperties** value);

        [VtblIndex(8)]
        HRESULT SetMediaStreamPropertiesAsync([NativeTypeName("ABI::Windows::Media::Capture::MediaStreamType")] MediaStreamType mediaStreamType, [NativeTypeName("ABI::Windows::Media::MediaProperties::IMediaEncodingProperties *")] IMediaEncodingProperties* mediaEncodingProperties, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** asyncInfo);
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

        [NativeTypeName("HRESULT (ABI::Windows::Media::Capture::MediaStreamType, ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CMedia__CMediaProperties__CIMediaEncodingProperties_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, MediaStreamType, IVectorView<Pointer<IMediaEncodingProperties>>**, int> GetAvailableMediaStreamProperties;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Capture::MediaStreamType, ABI::Windows::Media::MediaProperties::IMediaEncodingProperties **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, MediaStreamType, IMediaEncodingProperties**, int> GetMediaStreamProperties;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Capture::MediaStreamType, ABI::Windows::Media::MediaProperties::IMediaEncodingProperties *, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, MediaStreamType, IMediaEncodingProperties*, IAsyncAction**, int> SetMediaStreamPropertiesAsync;
    }
}
