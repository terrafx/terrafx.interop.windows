// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IMediaStreamSampleStatics.xml' path='doc/member[@name="IMediaStreamSampleStatics"]/*' />
[Guid("DFDF218F-A6CF-4579-BE41-73DD941AD972")]
[NativeTypeName("struct IMediaStreamSampleStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IMediaStreamSampleStatics : IMediaStreamSampleStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMediaStreamSampleStatics));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaStreamSampleStatics*, Guid*, void**, int>)(lpVtbl[0]))((IMediaStreamSampleStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaStreamSampleStatics*, uint>)(lpVtbl[1]))((IMediaStreamSampleStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaStreamSampleStatics*, uint>)(lpVtbl[2]))((IMediaStreamSampleStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaStreamSampleStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IMediaStreamSampleStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaStreamSampleStatics*, HSTRING*, int>)(lpVtbl[4]))((IMediaStreamSampleStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaStreamSampleStatics*, TrustLevel*, int>)(lpVtbl[5]))((IMediaStreamSampleStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IMediaStreamSampleStatics.xml' path='doc/member[@name="IMediaStreamSampleStatics.CreateFromBuffer"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateFromBuffer([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* buffer, [NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan timestamp, [NativeTypeName("ABI::Windows::Media::Core::IMediaStreamSample **")] IMediaStreamSample** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaStreamSampleStatics*, IBuffer*, TimeSpan, IMediaStreamSample**, int>)(lpVtbl[6]))((IMediaStreamSampleStatics*)Unsafe.AsPointer(ref this), buffer, timestamp, value);
    }

    /// <include file='IMediaStreamSampleStatics.xml' path='doc/member[@name="IMediaStreamSampleStatics.CreateFromStreamAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateFromStreamAsync([NativeTypeName("ABI::Windows::Storage::Streams::IInputStream *")] IInputStream* stream, [NativeTypeName("UINT32")] uint count, [NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan timestamp, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CCore__CMediaStreamSample_t **")] IAsyncOperation<IntPtr>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaStreamSampleStatics*, IInputStream*, uint, TimeSpan, IAsyncOperation<IntPtr>**, int>)(lpVtbl[7]))((IMediaStreamSampleStatics*)Unsafe.AsPointer(ref this), stream, count, timestamp, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateFromBuffer([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* buffer, [NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan timestamp, [NativeTypeName("ABI::Windows::Media::Core::IMediaStreamSample **")] IMediaStreamSample** value);

        [VtblIndex(7)]
        HRESULT CreateFromStreamAsync([NativeTypeName("ABI::Windows::Storage::Streams::IInputStream *")] IInputStream* stream, [NativeTypeName("UINT32")] uint count, [NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan timestamp, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CCore__CMediaStreamSample_t **")] IAsyncOperation<IntPtr>** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IBuffer *, ABI::Windows::Foundation::TimeSpan, ABI::Windows::Media::Core::IMediaStreamSample **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IBuffer*, TimeSpan, IMediaStreamSample**, int> CreateFromBuffer;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IInputStream *, UINT32, ABI::Windows::Foundation::TimeSpan, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CCore__CMediaStreamSample_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IInputStream*, uint, TimeSpan, IAsyncOperation<IntPtr>**, int> CreateFromStreamAsync;
    }
}
