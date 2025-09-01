// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.streaming.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IMediaRendererFactory.xml' path='doc/member[@name="IMediaRendererFactory"]/*' />
[Guid("657AB43D-B909-42B2-94D0-E3A0B134E8C9")]
[NativeTypeName("struct IMediaRendererFactory : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IMediaRendererFactory : IMediaRendererFactory.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IMediaRendererFactory);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaRendererFactory*, Guid*, void**, int>)(lpVtbl[0]))((IMediaRendererFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaRendererFactory*, uint>)(lpVtbl[1]))((IMediaRendererFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaRendererFactory*, uint>)(lpVtbl[2]))((IMediaRendererFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaRendererFactory*, uint*, Guid**, int>)(lpVtbl[3]))((IMediaRendererFactory*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaRendererFactory*, HSTRING*, int>)(lpVtbl[4]))((IMediaRendererFactory*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaRendererFactory*, TrustLevel*, int>)(lpVtbl[5]))((IMediaRendererFactory*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IMediaRendererFactory.xml' path='doc/member[@name="IMediaRendererFactory.CreateMediaRendererAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateMediaRendererAsync(HSTRING deviceIdentifier, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CStreaming__CMediaRenderer_t **")] IAsyncOperation<Pointer<IMediaRenderer>>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaRendererFactory*, HSTRING, IAsyncOperation<Pointer<IMediaRenderer>>**, int>)(lpVtbl[6]))((IMediaRendererFactory*)Unsafe.AsPointer(ref this), deviceIdentifier, value);
    }

    /// <include file='IMediaRendererFactory.xml' path='doc/member[@name="IMediaRendererFactory.CreateMediaRendererFromBasicDeviceAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateMediaRendererFromBasicDeviceAsync([NativeTypeName("ABI::Windows::Media::Streaming::IBasicDevice *")] IBasicDevice* basicDevice, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CStreaming__CMediaRenderer_t **")] IAsyncOperation<Pointer<IMediaRenderer>>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaRendererFactory*, IBasicDevice*, IAsyncOperation<Pointer<IMediaRenderer>>**, int>)(lpVtbl[7]))((IMediaRendererFactory*)Unsafe.AsPointer(ref this), basicDevice, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateMediaRendererAsync(HSTRING deviceIdentifier, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CStreaming__CMediaRenderer_t **")] IAsyncOperation<Pointer<IMediaRenderer>>** value);

        [VtblIndex(7)]
        HRESULT CreateMediaRendererFromBasicDeviceAsync([NativeTypeName("ABI::Windows::Media::Streaming::IBasicDevice *")] IBasicDevice* basicDevice, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CStreaming__CMediaRenderer_t **")] IAsyncOperation<Pointer<IMediaRenderer>>** value);
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

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CStreaming__CMediaRenderer_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IAsyncOperation<Pointer<IMediaRenderer>>**, int> CreateMediaRendererAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Streaming::IBasicDevice *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CStreaming__CMediaRenderer_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IBasicDevice*, IAsyncOperation<Pointer<IMediaRenderer>>**, int> CreateMediaRendererFromBasicDeviceAsync;
    }
}
