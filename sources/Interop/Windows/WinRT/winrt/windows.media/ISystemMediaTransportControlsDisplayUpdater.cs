// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ISystemMediaTransportControlsDisplayUpdater.xml' path='doc/member[@name="ISystemMediaTransportControlsDisplayUpdater"]/*' />
[Guid("8ABBC53E-FA55-4ECF-AD8E-C984E5DD1550")]
[NativeTypeName("struct ISystemMediaTransportControlsDisplayUpdater : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ISystemMediaTransportControlsDisplayUpdater : ISystemMediaTransportControlsDisplayUpdater.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISystemMediaTransportControlsDisplayUpdater));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemMediaTransportControlsDisplayUpdater*, Guid*, void**, int>)(lpVtbl[0]))((ISystemMediaTransportControlsDisplayUpdater*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemMediaTransportControlsDisplayUpdater*, uint>)(lpVtbl[1]))((ISystemMediaTransportControlsDisplayUpdater*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemMediaTransportControlsDisplayUpdater*, uint>)(lpVtbl[2]))((ISystemMediaTransportControlsDisplayUpdater*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemMediaTransportControlsDisplayUpdater*, uint*, Guid**, int>)(lpVtbl[3]))((ISystemMediaTransportControlsDisplayUpdater*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemMediaTransportControlsDisplayUpdater*, HSTRING*, int>)(lpVtbl[4]))((ISystemMediaTransportControlsDisplayUpdater*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemMediaTransportControlsDisplayUpdater*, TrustLevel*, int>)(lpVtbl[5]))((ISystemMediaTransportControlsDisplayUpdater*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ISystemMediaTransportControlsDisplayUpdater.xml' path='doc/member[@name="ISystemMediaTransportControlsDisplayUpdater.get_Type"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Type([NativeTypeName("ABI::Windows::Media::MediaPlaybackType *")] MediaPlaybackType* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemMediaTransportControlsDisplayUpdater*, MediaPlaybackType*, int>)(lpVtbl[6]))((ISystemMediaTransportControlsDisplayUpdater*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISystemMediaTransportControlsDisplayUpdater.xml' path='doc/member[@name="ISystemMediaTransportControlsDisplayUpdater.put_Type"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_Type([NativeTypeName("ABI::Windows::Media::MediaPlaybackType")] MediaPlaybackType value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemMediaTransportControlsDisplayUpdater*, MediaPlaybackType, int>)(lpVtbl[7]))((ISystemMediaTransportControlsDisplayUpdater*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISystemMediaTransportControlsDisplayUpdater.xml' path='doc/member[@name="ISystemMediaTransportControlsDisplayUpdater.get_AppMediaId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_AppMediaId(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemMediaTransportControlsDisplayUpdater*, HSTRING*, int>)(lpVtbl[8]))((ISystemMediaTransportControlsDisplayUpdater*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISystemMediaTransportControlsDisplayUpdater.xml' path='doc/member[@name="ISystemMediaTransportControlsDisplayUpdater.put_AppMediaId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_AppMediaId(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemMediaTransportControlsDisplayUpdater*, HSTRING, int>)(lpVtbl[9]))((ISystemMediaTransportControlsDisplayUpdater*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISystemMediaTransportControlsDisplayUpdater.xml' path='doc/member[@name="ISystemMediaTransportControlsDisplayUpdater.get_Thumbnail"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_Thumbnail([NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamReference **")] IRandomAccessStreamReference** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemMediaTransportControlsDisplayUpdater*, IRandomAccessStreamReference**, int>)(lpVtbl[10]))((ISystemMediaTransportControlsDisplayUpdater*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISystemMediaTransportControlsDisplayUpdater.xml' path='doc/member[@name="ISystemMediaTransportControlsDisplayUpdater.put_Thumbnail"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_Thumbnail([NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamReference *")] IRandomAccessStreamReference* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemMediaTransportControlsDisplayUpdater*, IRandomAccessStreamReference*, int>)(lpVtbl[11]))((ISystemMediaTransportControlsDisplayUpdater*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISystemMediaTransportControlsDisplayUpdater.xml' path='doc/member[@name="ISystemMediaTransportControlsDisplayUpdater.get_MusicProperties"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_MusicProperties([NativeTypeName("ABI::Windows::Media::IMusicDisplayProperties **")] IMusicDisplayProperties** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemMediaTransportControlsDisplayUpdater*, IMusicDisplayProperties**, int>)(lpVtbl[12]))((ISystemMediaTransportControlsDisplayUpdater*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISystemMediaTransportControlsDisplayUpdater.xml' path='doc/member[@name="ISystemMediaTransportControlsDisplayUpdater.get_VideoProperties"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_VideoProperties([NativeTypeName("ABI::Windows::Media::IVideoDisplayProperties **")] IVideoDisplayProperties** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemMediaTransportControlsDisplayUpdater*, IVideoDisplayProperties**, int>)(lpVtbl[13]))((ISystemMediaTransportControlsDisplayUpdater*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISystemMediaTransportControlsDisplayUpdater.xml' path='doc/member[@name="ISystemMediaTransportControlsDisplayUpdater.get_ImageProperties"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_ImageProperties([NativeTypeName("ABI::Windows::Media::IImageDisplayProperties **")] IImageDisplayProperties** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemMediaTransportControlsDisplayUpdater*, IImageDisplayProperties**, int>)(lpVtbl[14]))((ISystemMediaTransportControlsDisplayUpdater*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISystemMediaTransportControlsDisplayUpdater.xml' path='doc/member[@name="ISystemMediaTransportControlsDisplayUpdater.CopyFromFileAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT CopyFromFileAsync([NativeTypeName("ABI::Windows::Media::MediaPlaybackType")] MediaPlaybackType type, [NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile* source, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<bool>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemMediaTransportControlsDisplayUpdater*, MediaPlaybackType, IStorageFile*, IAsyncOperation<bool>**, int>)(lpVtbl[15]))((ISystemMediaTransportControlsDisplayUpdater*)Unsafe.AsPointer(ref this), type, source, operation);
    }

    /// <include file='ISystemMediaTransportControlsDisplayUpdater.xml' path='doc/member[@name="ISystemMediaTransportControlsDisplayUpdater.ClearAll"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT ClearAll()
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemMediaTransportControlsDisplayUpdater*, int>)(lpVtbl[16]))((ISystemMediaTransportControlsDisplayUpdater*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ISystemMediaTransportControlsDisplayUpdater.xml' path='doc/member[@name="ISystemMediaTransportControlsDisplayUpdater.Update"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT Update()
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemMediaTransportControlsDisplayUpdater*, int>)(lpVtbl[17]))((ISystemMediaTransportControlsDisplayUpdater*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Type([NativeTypeName("ABI::Windows::Media::MediaPlaybackType *")] MediaPlaybackType* value);

        [VtblIndex(7)]
        HRESULT put_Type([NativeTypeName("ABI::Windows::Media::MediaPlaybackType")] MediaPlaybackType value);

        [VtblIndex(8)]
        HRESULT get_AppMediaId(HSTRING* value);

        [VtblIndex(9)]
        HRESULT put_AppMediaId(HSTRING value);

        [VtblIndex(10)]
        HRESULT get_Thumbnail([NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamReference **")] IRandomAccessStreamReference** value);

        [VtblIndex(11)]
        HRESULT put_Thumbnail([NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamReference *")] IRandomAccessStreamReference* value);

        [VtblIndex(12)]
        HRESULT get_MusicProperties([NativeTypeName("ABI::Windows::Media::IMusicDisplayProperties **")] IMusicDisplayProperties** value);

        [VtblIndex(13)]
        HRESULT get_VideoProperties([NativeTypeName("ABI::Windows::Media::IVideoDisplayProperties **")] IVideoDisplayProperties** value);

        [VtblIndex(14)]
        HRESULT get_ImageProperties([NativeTypeName("ABI::Windows::Media::IImageDisplayProperties **")] IImageDisplayProperties** value);

        [VtblIndex(15)]
        HRESULT CopyFromFileAsync([NativeTypeName("ABI::Windows::Media::MediaPlaybackType")] MediaPlaybackType type, [NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile* source, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<bool>** operation);

        [VtblIndex(16)]
        HRESULT ClearAll();

        [VtblIndex(17)]
        HRESULT Update();
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

        [NativeTypeName("HRESULT (ABI::Windows::Media::MediaPlaybackType *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, MediaPlaybackType*, int> get_Type;

        [NativeTypeName("HRESULT (ABI::Windows::Media::MediaPlaybackType) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, MediaPlaybackType, int> put_Type;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_AppMediaId;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_AppMediaId;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IRandomAccessStreamReference **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IRandomAccessStreamReference**, int> get_Thumbnail;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IRandomAccessStreamReference *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IRandomAccessStreamReference*, int> put_Thumbnail;

        [NativeTypeName("HRESULT (ABI::Windows::Media::IMusicDisplayProperties **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMusicDisplayProperties**, int> get_MusicProperties;

        [NativeTypeName("HRESULT (ABI::Windows::Media::IVideoDisplayProperties **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVideoDisplayProperties**, int> get_VideoProperties;

        [NativeTypeName("HRESULT (ABI::Windows::Media::IImageDisplayProperties **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IImageDisplayProperties**, int> get_ImageProperties;

        [NativeTypeName("HRESULT (ABI::Windows::Media::MediaPlaybackType, ABI::Windows::Storage::IStorageFile *, ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, MediaPlaybackType, IStorageFile*, IAsyncOperation<bool>**, int> CopyFromFileAsync;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> ClearAll;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> Update;
    }
}
