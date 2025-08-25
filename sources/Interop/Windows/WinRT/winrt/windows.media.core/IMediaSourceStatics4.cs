// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IMediaSourceStatics4.xml' path='doc/member[@name="IMediaSourceStatics4"]/*' />
[Guid("281B3BFC-E50A-4428-A500-9C4ED918D3F0")]
[NativeTypeName("struct IMediaSourceStatics4 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IMediaSourceStatics4 : IMediaSourceStatics4.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IMediaSourceStatics4);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaSourceStatics4*, Guid*, void**, int>)(lpVtbl[0]))((IMediaSourceStatics4*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaSourceStatics4*, uint>)(lpVtbl[1]))((IMediaSourceStatics4*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaSourceStatics4*, uint>)(lpVtbl[2]))((IMediaSourceStatics4*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaSourceStatics4*, uint*, Guid**, int>)(lpVtbl[3]))((IMediaSourceStatics4*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaSourceStatics4*, HSTRING*, int>)(lpVtbl[4]))((IMediaSourceStatics4*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaSourceStatics4*, TrustLevel*, int>)(lpVtbl[5]))((IMediaSourceStatics4*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IMediaSourceStatics4.xml' path='doc/member[@name="IMediaSourceStatics4.CreateFromDownloadOperation"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateFromDownloadOperation([NativeTypeName("ABI::Windows::Networking::BackgroundTransfer::IDownloadOperation *")] IDownloadOperation* downloadOperation, [NativeTypeName("ABI::Windows::Media::Core::IMediaSource2 **")] IMediaSource2** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaSourceStatics4*, IDownloadOperation*, IMediaSource2**, int>)(lpVtbl[6]))((IMediaSourceStatics4*)Unsafe.AsPointer(ref this), downloadOperation, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateFromDownloadOperation([NativeTypeName("ABI::Windows::Networking::BackgroundTransfer::IDownloadOperation *")] IDownloadOperation* downloadOperation, [NativeTypeName("ABI::Windows::Media::Core::IMediaSource2 **")] IMediaSource2** result);
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

        [NativeTypeName("HRESULT (ABI::Windows::Networking::BackgroundTransfer::IDownloadOperation *, ABI::Windows::Media::Core::IMediaSource2 **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDownloadOperation*, IMediaSource2**, int> CreateFromDownloadOperation;
    }
}
