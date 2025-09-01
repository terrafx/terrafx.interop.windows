// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.transcoding.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IMediaTranscoder.xml' path='doc/member[@name="IMediaTranscoder"]/*' />
[Guid("190C99D2-A0AA-4D34-86BC-EED1B12C2F5B")]
[NativeTypeName("struct IMediaTranscoder : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IMediaTranscoder : IMediaTranscoder.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IMediaTranscoder);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaTranscoder*, Guid*, void**, int>)(lpVtbl[0]))((IMediaTranscoder*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaTranscoder*, uint>)(lpVtbl[1]))((IMediaTranscoder*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaTranscoder*, uint>)(lpVtbl[2]))((IMediaTranscoder*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaTranscoder*, uint*, Guid**, int>)(lpVtbl[3]))((IMediaTranscoder*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaTranscoder*, HSTRING*, int>)(lpVtbl[4]))((IMediaTranscoder*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaTranscoder*, TrustLevel*, int>)(lpVtbl[5]))((IMediaTranscoder*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IMediaTranscoder.xml' path='doc/member[@name="IMediaTranscoder.put_TrimStartTime"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT put_TrimStartTime([NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaTranscoder*, TimeSpan, int>)(lpVtbl[6]))((IMediaTranscoder*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaTranscoder.xml' path='doc/member[@name="IMediaTranscoder.get_TrimStartTime"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_TrimStartTime([NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaTranscoder*, TimeSpan*, int>)(lpVtbl[7]))((IMediaTranscoder*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaTranscoder.xml' path='doc/member[@name="IMediaTranscoder.put_TrimStopTime"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT put_TrimStopTime([NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaTranscoder*, TimeSpan, int>)(lpVtbl[8]))((IMediaTranscoder*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaTranscoder.xml' path='doc/member[@name="IMediaTranscoder.get_TrimStopTime"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_TrimStopTime([NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaTranscoder*, TimeSpan*, int>)(lpVtbl[9]))((IMediaTranscoder*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaTranscoder.xml' path='doc/member[@name="IMediaTranscoder.put_AlwaysReencode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT put_AlwaysReencode([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaTranscoder*, byte, int>)(lpVtbl[10]))((IMediaTranscoder*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaTranscoder.xml' path='doc/member[@name="IMediaTranscoder.get_AlwaysReencode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_AlwaysReencode([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaTranscoder*, byte*, int>)(lpVtbl[11]))((IMediaTranscoder*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaTranscoder.xml' path='doc/member[@name="IMediaTranscoder.put_HardwareAccelerationEnabled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT put_HardwareAccelerationEnabled([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaTranscoder*, byte, int>)(lpVtbl[12]))((IMediaTranscoder*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaTranscoder.xml' path='doc/member[@name="IMediaTranscoder.get_HardwareAccelerationEnabled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_HardwareAccelerationEnabled([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaTranscoder*, byte*, int>)(lpVtbl[13]))((IMediaTranscoder*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaTranscoder.xml' path='doc/member[@name="IMediaTranscoder.AddAudioEffect"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT AddAudioEffect(HSTRING activatableClassId)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaTranscoder*, HSTRING, int>)(lpVtbl[14]))((IMediaTranscoder*)Unsafe.AsPointer(ref this), activatableClassId);
    }

    /// <include file='IMediaTranscoder.xml' path='doc/member[@name="IMediaTranscoder.AddAudioEffectWithSettings"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT AddAudioEffectWithSettings(HSTRING activatableClassId, [NativeTypeName("boolean")] byte effectRequired, [NativeTypeName("ABI::Windows::Foundation::Collections::IPropertySet *")] IPropertySet* configuration)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaTranscoder*, HSTRING, byte, IPropertySet*, int>)(lpVtbl[15]))((IMediaTranscoder*)Unsafe.AsPointer(ref this), activatableClassId, effectRequired, configuration);
    }

    /// <include file='IMediaTranscoder.xml' path='doc/member[@name="IMediaTranscoder.AddVideoEffect"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT AddVideoEffect(HSTRING activatableClassId)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaTranscoder*, HSTRING, int>)(lpVtbl[16]))((IMediaTranscoder*)Unsafe.AsPointer(ref this), activatableClassId);
    }

    /// <include file='IMediaTranscoder.xml' path='doc/member[@name="IMediaTranscoder.AddVideoEffectWithSettings"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT AddVideoEffectWithSettings(HSTRING activatableClassId, [NativeTypeName("boolean")] byte effectRequired, [NativeTypeName("ABI::Windows::Foundation::Collections::IPropertySet *")] IPropertySet* configuration)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaTranscoder*, HSTRING, byte, IPropertySet*, int>)(lpVtbl[17]))((IMediaTranscoder*)Unsafe.AsPointer(ref this), activatableClassId, effectRequired, configuration);
    }

    /// <include file='IMediaTranscoder.xml' path='doc/member[@name="IMediaTranscoder.ClearEffects"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT ClearEffects()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaTranscoder*, int>)(lpVtbl[18]))((IMediaTranscoder*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMediaTranscoder.xml' path='doc/member[@name="IMediaTranscoder.PrepareFileTranscodeAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT PrepareFileTranscodeAsync([NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile* source, [NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile* destination, [NativeTypeName("ABI::Windows::Media::MediaProperties::IMediaEncodingProfile *")] IMediaEncodingProfile* profile, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CTranscoding__CPrepareTranscodeResult_t **")] IAsyncOperation<Pointer<IPrepareTranscodeResult>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaTranscoder*, IStorageFile*, IStorageFile*, IMediaEncodingProfile*, IAsyncOperation<Pointer<IPrepareTranscodeResult>>**, int>)(lpVtbl[19]))((IMediaTranscoder*)Unsafe.AsPointer(ref this), source, destination, profile, operation);
    }

    /// <include file='IMediaTranscoder.xml' path='doc/member[@name="IMediaTranscoder.PrepareStreamTranscodeAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT PrepareStreamTranscodeAsync([NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStream *")] IRandomAccessStream* source, [NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStream *")] IRandomAccessStream* destination, [NativeTypeName("ABI::Windows::Media::MediaProperties::IMediaEncodingProfile *")] IMediaEncodingProfile* profile, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CTranscoding__CPrepareTranscodeResult_t **")] IAsyncOperation<Pointer<IPrepareTranscodeResult>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaTranscoder*, IRandomAccessStream*, IRandomAccessStream*, IMediaEncodingProfile*, IAsyncOperation<Pointer<IPrepareTranscodeResult>>**, int>)(lpVtbl[20]))((IMediaTranscoder*)Unsafe.AsPointer(ref this), source, destination, profile, operation);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT put_TrimStartTime([NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan value);

        [VtblIndex(7)]
        HRESULT get_TrimStartTime([NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value);

        [VtblIndex(8)]
        HRESULT put_TrimStopTime([NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan value);

        [VtblIndex(9)]
        HRESULT get_TrimStopTime([NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value);

        [VtblIndex(10)]
        HRESULT put_AlwaysReencode([NativeTypeName("boolean")] byte value);

        [VtblIndex(11)]
        HRESULT get_AlwaysReencode([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(12)]
        HRESULT put_HardwareAccelerationEnabled([NativeTypeName("boolean")] byte value);

        [VtblIndex(13)]
        HRESULT get_HardwareAccelerationEnabled([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(14)]
        HRESULT AddAudioEffect(HSTRING activatableClassId);

        [VtblIndex(15)]
        HRESULT AddAudioEffectWithSettings(HSTRING activatableClassId, [NativeTypeName("boolean")] byte effectRequired, [NativeTypeName("ABI::Windows::Foundation::Collections::IPropertySet *")] IPropertySet* configuration);

        [VtblIndex(16)]
        HRESULT AddVideoEffect(HSTRING activatableClassId);

        [VtblIndex(17)]
        HRESULT AddVideoEffectWithSettings(HSTRING activatableClassId, [NativeTypeName("boolean")] byte effectRequired, [NativeTypeName("ABI::Windows::Foundation::Collections::IPropertySet *")] IPropertySet* configuration);

        [VtblIndex(18)]
        HRESULT ClearEffects();

        [VtblIndex(19)]
        HRESULT PrepareFileTranscodeAsync([NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile* source, [NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile* destination, [NativeTypeName("ABI::Windows::Media::MediaProperties::IMediaEncodingProfile *")] IMediaEncodingProfile* profile, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CTranscoding__CPrepareTranscodeResult_t **")] IAsyncOperation<Pointer<IPrepareTranscodeResult>>** operation);

        [VtblIndex(20)]
        HRESULT PrepareStreamTranscodeAsync([NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStream *")] IRandomAccessStream* source, [NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStream *")] IRandomAccessStream* destination, [NativeTypeName("ABI::Windows::Media::MediaProperties::IMediaEncodingProfile *")] IMediaEncodingProfile* profile, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CTranscoding__CPrepareTranscodeResult_t **")] IAsyncOperation<Pointer<IPrepareTranscodeResult>>** operation);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::TimeSpan) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TimeSpan, int> put_TrimStartTime;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::TimeSpan *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TimeSpan*, int> get_TrimStartTime;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::TimeSpan) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TimeSpan, int> put_TrimStopTime;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::TimeSpan *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TimeSpan*, int> get_TrimStopTime;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_AlwaysReencode;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_AlwaysReencode;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_HardwareAccelerationEnabled;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_HardwareAccelerationEnabled;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> AddAudioEffect;

        [NativeTypeName("HRESULT (HSTRING, boolean, ABI::Windows::Foundation::Collections::IPropertySet *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, byte, IPropertySet*, int> AddAudioEffectWithSettings;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> AddVideoEffect;

        [NativeTypeName("HRESULT (HSTRING, boolean, ABI::Windows::Foundation::Collections::IPropertySet *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, byte, IPropertySet*, int> AddVideoEffectWithSettings;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> ClearEffects;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::IStorageFile *, ABI::Windows::Storage::IStorageFile *, ABI::Windows::Media::MediaProperties::IMediaEncodingProfile *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CTranscoding__CPrepareTranscodeResult_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IStorageFile*, IStorageFile*, IMediaEncodingProfile*, IAsyncOperation<Pointer<IPrepareTranscodeResult>>**, int> PrepareFileTranscodeAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IRandomAccessStream *, ABI::Windows::Storage::Streams::IRandomAccessStream *, ABI::Windows::Media::MediaProperties::IMediaEncodingProfile *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CTranscoding__CPrepareTranscodeResult_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IRandomAccessStream*, IRandomAccessStream*, IMediaEncodingProfile*, IAsyncOperation<Pointer<IPrepareTranscodeResult>>**, int> PrepareStreamTranscodeAsync;
    }
}
