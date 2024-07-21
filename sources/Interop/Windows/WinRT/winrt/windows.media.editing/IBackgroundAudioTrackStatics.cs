// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.editing.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IBackgroundAudioTrackStatics.xml' path='doc/member[@name="IBackgroundAudioTrackStatics"]/*' />
[Guid("D9B1C0D7-D018-42A8-A559-CB4D9E97E664")]
[NativeTypeName("struct IBackgroundAudioTrackStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IBackgroundAudioTrackStatics : IBackgroundAudioTrackStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IBackgroundAudioTrackStatics));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundAudioTrackStatics*, Guid*, void**, int>)(lpVtbl[0]))((IBackgroundAudioTrackStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundAudioTrackStatics*, uint>)(lpVtbl[1]))((IBackgroundAudioTrackStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundAudioTrackStatics*, uint>)(lpVtbl[2]))((IBackgroundAudioTrackStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundAudioTrackStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IBackgroundAudioTrackStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundAudioTrackStatics*, HSTRING*, int>)(lpVtbl[4]))((IBackgroundAudioTrackStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundAudioTrackStatics*, TrustLevel*, int>)(lpVtbl[5]))((IBackgroundAudioTrackStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IBackgroundAudioTrackStatics.xml' path='doc/member[@name="IBackgroundAudioTrackStatics.CreateFromEmbeddedAudioTrack"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateFromEmbeddedAudioTrack([NativeTypeName("ABI::Windows::Media::Editing::IEmbeddedAudioTrack *")] IEmbeddedAudioTrack* embeddedAudioTrack, [NativeTypeName("ABI::Windows::Media::Editing::IBackgroundAudioTrack **")] IBackgroundAudioTrack** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundAudioTrackStatics*, IEmbeddedAudioTrack*, IBackgroundAudioTrack**, int>)(lpVtbl[6]))((IBackgroundAudioTrackStatics*)Unsafe.AsPointer(ref this), embeddedAudioTrack, value);
    }

    /// <include file='IBackgroundAudioTrackStatics.xml' path='doc/member[@name="IBackgroundAudioTrackStatics.CreateFromFileAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateFromFileAsync([NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile* file, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CEditing__CBackgroundAudioTrack_t **")] IAsyncOperation<Pointer<IBackgroundAudioTrack>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundAudioTrackStatics*, IStorageFile*, IAsyncOperation<Pointer<IBackgroundAudioTrack>>**, int>)(lpVtbl[7]))((IBackgroundAudioTrackStatics*)Unsafe.AsPointer(ref this), file, operation);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateFromEmbeddedAudioTrack([NativeTypeName("ABI::Windows::Media::Editing::IEmbeddedAudioTrack *")] IEmbeddedAudioTrack* embeddedAudioTrack, [NativeTypeName("ABI::Windows::Media::Editing::IBackgroundAudioTrack **")] IBackgroundAudioTrack** value);

        [VtblIndex(7)]
        HRESULT CreateFromFileAsync([NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile* file, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CEditing__CBackgroundAudioTrack_t **")] IAsyncOperation<Pointer<IBackgroundAudioTrack>>** operation);
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

        [NativeTypeName("HRESULT (ABI::Windows::Media::Editing::IEmbeddedAudioTrack *, ABI::Windows::Media::Editing::IBackgroundAudioTrack **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IEmbeddedAudioTrack*, IBackgroundAudioTrack**, int> CreateFromEmbeddedAudioTrack;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::IStorageFile *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CEditing__CBackgroundAudioTrack_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IStorageFile*, IAsyncOperation<Pointer<IBackgroundAudioTrack>>**, int> CreateFromFileAsync;
    }
}
