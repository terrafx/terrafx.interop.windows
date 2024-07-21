// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.audio.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IAudioFileOutputNode.xml' path='doc/member[@name="IAudioFileOutputNode"]/*' />
[Guid("50E01980-5166-4093-80F8-ADA00089E9CF")]
[NativeTypeName("struct IAudioFileOutputNode : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAudioFileOutputNode : IAudioFileOutputNode.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAudioFileOutputNode));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioFileOutputNode*, Guid*, void**, int>)(lpVtbl[0]))((IAudioFileOutputNode*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioFileOutputNode*, uint>)(lpVtbl[1]))((IAudioFileOutputNode*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioFileOutputNode*, uint>)(lpVtbl[2]))((IAudioFileOutputNode*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioFileOutputNode*, uint*, Guid**, int>)(lpVtbl[3]))((IAudioFileOutputNode*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioFileOutputNode*, HSTRING*, int>)(lpVtbl[4]))((IAudioFileOutputNode*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioFileOutputNode*, TrustLevel*, int>)(lpVtbl[5]))((IAudioFileOutputNode*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IAudioFileOutputNode.xml' path='doc/member[@name="IAudioFileOutputNode.get_File"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_File([NativeTypeName("ABI::Windows::Storage::IStorageFile **")] IStorageFile** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioFileOutputNode*, IStorageFile**, int>)(lpVtbl[6]))((IAudioFileOutputNode*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAudioFileOutputNode.xml' path='doc/member[@name="IAudioFileOutputNode.get_FileEncodingProfile"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_FileEncodingProfile([NativeTypeName("ABI::Windows::Media::MediaProperties::IMediaEncodingProfile **")] IMediaEncodingProfile** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioFileOutputNode*, IMediaEncodingProfile**, int>)(lpVtbl[7]))((IAudioFileOutputNode*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAudioFileOutputNode.xml' path='doc/member[@name="IAudioFileOutputNode.FinalizeAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT FinalizeAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CTranscoding__CTranscodeFailureReason_t **")] IAsyncOperation<TranscodeFailureReason>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioFileOutputNode*, IAsyncOperation<TranscodeFailureReason>**, int>)(lpVtbl[8]))((IAudioFileOutputNode*)Unsafe.AsPointer(ref this), result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_File([NativeTypeName("ABI::Windows::Storage::IStorageFile **")] IStorageFile** value);

        [VtblIndex(7)]
        HRESULT get_FileEncodingProfile([NativeTypeName("ABI::Windows::Media::MediaProperties::IMediaEncodingProfile **")] IMediaEncodingProfile** value);

        [VtblIndex(8)]
        HRESULT FinalizeAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CTranscoding__CTranscodeFailureReason_t **")] IAsyncOperation<TranscodeFailureReason>** result);
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

        [NativeTypeName("HRESULT (ABI::Windows::Storage::IStorageFile **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IStorageFile**, int> get_File;

        [NativeTypeName("HRESULT (ABI::Windows::Media::MediaProperties::IMediaEncodingProfile **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMediaEncodingProfile**, int> get_FileEncodingProfile;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CTranscoding__CTranscodeFailureReason_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncOperation<TranscodeFailureReason>**, int> FinalizeAsync;
    }
}
