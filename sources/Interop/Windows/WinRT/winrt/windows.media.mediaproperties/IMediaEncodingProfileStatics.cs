// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.mediaproperties.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IMediaEncodingProfileStatics.xml' path='doc/member[@name="IMediaEncodingProfileStatics"]/*' />
[Guid("197F352C-2EDE-4A45-A896-817A4854F8FE")]
[NativeTypeName("struct IMediaEncodingProfileStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IMediaEncodingProfileStatics : IMediaEncodingProfileStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMediaEncodingProfileStatics));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaEncodingProfileStatics*, Guid*, void**, int>)(lpVtbl[0]))((IMediaEncodingProfileStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaEncodingProfileStatics*, uint>)(lpVtbl[1]))((IMediaEncodingProfileStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaEncodingProfileStatics*, uint>)(lpVtbl[2]))((IMediaEncodingProfileStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaEncodingProfileStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IMediaEncodingProfileStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaEncodingProfileStatics*, HSTRING*, int>)(lpVtbl[4]))((IMediaEncodingProfileStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaEncodingProfileStatics*, TrustLevel*, int>)(lpVtbl[5]))((IMediaEncodingProfileStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IMediaEncodingProfileStatics.xml' path='doc/member[@name="IMediaEncodingProfileStatics.CreateM4a"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateM4a([NativeTypeName("ABI::Windows::Media::MediaProperties::AudioEncodingQuality")] AudioEncodingQuality quality, [NativeTypeName("ABI::Windows::Media::MediaProperties::IMediaEncodingProfile **")] IMediaEncodingProfile** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaEncodingProfileStatics*, AudioEncodingQuality, IMediaEncodingProfile**, int>)(lpVtbl[6]))((IMediaEncodingProfileStatics*)Unsafe.AsPointer(ref this), quality, value);
    }

    /// <include file='IMediaEncodingProfileStatics.xml' path='doc/member[@name="IMediaEncodingProfileStatics.CreateMp3"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateMp3([NativeTypeName("ABI::Windows::Media::MediaProperties::AudioEncodingQuality")] AudioEncodingQuality quality, [NativeTypeName("ABI::Windows::Media::MediaProperties::IMediaEncodingProfile **")] IMediaEncodingProfile** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaEncodingProfileStatics*, AudioEncodingQuality, IMediaEncodingProfile**, int>)(lpVtbl[7]))((IMediaEncodingProfileStatics*)Unsafe.AsPointer(ref this), quality, value);
    }

    /// <include file='IMediaEncodingProfileStatics.xml' path='doc/member[@name="IMediaEncodingProfileStatics.CreateWma"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT CreateWma([NativeTypeName("ABI::Windows::Media::MediaProperties::AudioEncodingQuality")] AudioEncodingQuality quality, [NativeTypeName("ABI::Windows::Media::MediaProperties::IMediaEncodingProfile **")] IMediaEncodingProfile** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaEncodingProfileStatics*, AudioEncodingQuality, IMediaEncodingProfile**, int>)(lpVtbl[8]))((IMediaEncodingProfileStatics*)Unsafe.AsPointer(ref this), quality, value);
    }

    /// <include file='IMediaEncodingProfileStatics.xml' path='doc/member[@name="IMediaEncodingProfileStatics.CreateMp4"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT CreateMp4([NativeTypeName("ABI::Windows::Media::MediaProperties::VideoEncodingQuality")] VideoEncodingQuality quality, [NativeTypeName("ABI::Windows::Media::MediaProperties::IMediaEncodingProfile **")] IMediaEncodingProfile** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaEncodingProfileStatics*, VideoEncodingQuality, IMediaEncodingProfile**, int>)(lpVtbl[9]))((IMediaEncodingProfileStatics*)Unsafe.AsPointer(ref this), quality, value);
    }

    /// <include file='IMediaEncodingProfileStatics.xml' path='doc/member[@name="IMediaEncodingProfileStatics.CreateWmv"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT CreateWmv([NativeTypeName("ABI::Windows::Media::MediaProperties::VideoEncodingQuality")] VideoEncodingQuality quality, [NativeTypeName("ABI::Windows::Media::MediaProperties::IMediaEncodingProfile **")] IMediaEncodingProfile** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaEncodingProfileStatics*, VideoEncodingQuality, IMediaEncodingProfile**, int>)(lpVtbl[10]))((IMediaEncodingProfileStatics*)Unsafe.AsPointer(ref this), quality, value);
    }

    /// <include file='IMediaEncodingProfileStatics.xml' path='doc/member[@name="IMediaEncodingProfileStatics.CreateFromFileAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT CreateFromFileAsync([NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile* file, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CMediaProperties__CMediaEncodingProfile_t **")] IAsyncOperation<Pointer<IMediaEncodingProfile>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaEncodingProfileStatics*, IStorageFile*, IAsyncOperation<Pointer<IMediaEncodingProfile>>**, int>)(lpVtbl[11]))((IMediaEncodingProfileStatics*)Unsafe.AsPointer(ref this), file, operation);
    }

    /// <include file='IMediaEncodingProfileStatics.xml' path='doc/member[@name="IMediaEncodingProfileStatics.CreateFromStreamAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT CreateFromStreamAsync([NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStream *")] IRandomAccessStream* stream, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CMediaProperties__CMediaEncodingProfile_t **")] IAsyncOperation<Pointer<IMediaEncodingProfile>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaEncodingProfileStatics*, IRandomAccessStream*, IAsyncOperation<Pointer<IMediaEncodingProfile>>**, int>)(lpVtbl[12]))((IMediaEncodingProfileStatics*)Unsafe.AsPointer(ref this), stream, operation);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateM4a([NativeTypeName("ABI::Windows::Media::MediaProperties::AudioEncodingQuality")] AudioEncodingQuality quality, [NativeTypeName("ABI::Windows::Media::MediaProperties::IMediaEncodingProfile **")] IMediaEncodingProfile** value);

        [VtblIndex(7)]
        HRESULT CreateMp3([NativeTypeName("ABI::Windows::Media::MediaProperties::AudioEncodingQuality")] AudioEncodingQuality quality, [NativeTypeName("ABI::Windows::Media::MediaProperties::IMediaEncodingProfile **")] IMediaEncodingProfile** value);

        [VtblIndex(8)]
        HRESULT CreateWma([NativeTypeName("ABI::Windows::Media::MediaProperties::AudioEncodingQuality")] AudioEncodingQuality quality, [NativeTypeName("ABI::Windows::Media::MediaProperties::IMediaEncodingProfile **")] IMediaEncodingProfile** value);

        [VtblIndex(9)]
        HRESULT CreateMp4([NativeTypeName("ABI::Windows::Media::MediaProperties::VideoEncodingQuality")] VideoEncodingQuality quality, [NativeTypeName("ABI::Windows::Media::MediaProperties::IMediaEncodingProfile **")] IMediaEncodingProfile** value);

        [VtblIndex(10)]
        HRESULT CreateWmv([NativeTypeName("ABI::Windows::Media::MediaProperties::VideoEncodingQuality")] VideoEncodingQuality quality, [NativeTypeName("ABI::Windows::Media::MediaProperties::IMediaEncodingProfile **")] IMediaEncodingProfile** value);

        [VtblIndex(11)]
        HRESULT CreateFromFileAsync([NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile* file, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CMediaProperties__CMediaEncodingProfile_t **")] IAsyncOperation<Pointer<IMediaEncodingProfile>>** operation);

        [VtblIndex(12)]
        HRESULT CreateFromStreamAsync([NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStream *")] IRandomAccessStream* stream, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CMediaProperties__CMediaEncodingProfile_t **")] IAsyncOperation<Pointer<IMediaEncodingProfile>>** operation);
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

        [NativeTypeName("HRESULT (ABI::Windows::Media::MediaProperties::AudioEncodingQuality, ABI::Windows::Media::MediaProperties::IMediaEncodingProfile **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, AudioEncodingQuality, IMediaEncodingProfile**, int> CreateM4a;

        [NativeTypeName("HRESULT (ABI::Windows::Media::MediaProperties::AudioEncodingQuality, ABI::Windows::Media::MediaProperties::IMediaEncodingProfile **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, AudioEncodingQuality, IMediaEncodingProfile**, int> CreateMp3;

        [NativeTypeName("HRESULT (ABI::Windows::Media::MediaProperties::AudioEncodingQuality, ABI::Windows::Media::MediaProperties::IMediaEncodingProfile **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, AudioEncodingQuality, IMediaEncodingProfile**, int> CreateWma;

        [NativeTypeName("HRESULT (ABI::Windows::Media::MediaProperties::VideoEncodingQuality, ABI::Windows::Media::MediaProperties::IMediaEncodingProfile **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, VideoEncodingQuality, IMediaEncodingProfile**, int> CreateMp4;

        [NativeTypeName("HRESULT (ABI::Windows::Media::MediaProperties::VideoEncodingQuality, ABI::Windows::Media::MediaProperties::IMediaEncodingProfile **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, VideoEncodingQuality, IMediaEncodingProfile**, int> CreateWmv;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::IStorageFile *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CMediaProperties__CMediaEncodingProfile_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IStorageFile*, IAsyncOperation<Pointer<IMediaEncodingProfile>>**, int> CreateFromFileAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IRandomAccessStream *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CMediaProperties__CMediaEncodingProfile_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IRandomAccessStream*, IAsyncOperation<Pointer<IMediaEncodingProfile>>**, int> CreateFromStreamAsync;
    }
}
