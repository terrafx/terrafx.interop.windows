// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.audio.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IAudioGraph2.xml' path='doc/member[@name="IAudioGraph2"]/*' />
[Guid("4E4C3BD5-4FC1-45F6-A947-3CD38F4FD839")]
[NativeTypeName("struct IAudioGraph2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAudioGraph2 : IAudioGraph2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAudioGraph2));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioGraph2*, Guid*, void**, int>)(lpVtbl[0]))((IAudioGraph2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioGraph2*, uint>)(lpVtbl[1]))((IAudioGraph2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioGraph2*, uint>)(lpVtbl[2]))((IAudioGraph2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioGraph2*, uint*, Guid**, int>)(lpVtbl[3]))((IAudioGraph2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioGraph2*, HSTRING*, int>)(lpVtbl[4]))((IAudioGraph2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioGraph2*, TrustLevel*, int>)(lpVtbl[5]))((IAudioGraph2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IAudioGraph2.xml' path='doc/member[@name="IAudioGraph2.CreateFrameInputNodeWithFormatAndEmitter"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateFrameInputNodeWithFormatAndEmitter([NativeTypeName("ABI::Windows::Media::MediaProperties::IAudioEncodingProperties *")] IAudioEncodingProperties* encodingProperties, [NativeTypeName("ABI::Windows::Media::Audio::IAudioNodeEmitter *")] IAudioNodeEmitter* emitter, [NativeTypeName("ABI::Windows::Media::Audio::IAudioFrameInputNode **")] IAudioFrameInputNode** frameInputNode)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioGraph2*, IAudioEncodingProperties*, IAudioNodeEmitter*, IAudioFrameInputNode**, int>)(lpVtbl[6]))((IAudioGraph2*)Unsafe.AsPointer(ref this), encodingProperties, emitter, frameInputNode);
    }

    /// <include file='IAudioGraph2.xml' path='doc/member[@name="IAudioGraph2.CreateDeviceInputNodeWithFormatAndEmitterOnDeviceAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateDeviceInputNodeWithFormatAndEmitterOnDeviceAsync([NativeTypeName("ABI::Windows::Media::Capture::MediaCategory")] MediaCategory category, [NativeTypeName("ABI::Windows::Media::MediaProperties::IAudioEncodingProperties *")] IAudioEncodingProperties* encodingProperties, [NativeTypeName("ABI::Windows::Devices::Enumeration::IDeviceInformation *")] IDeviceInformation* device, [NativeTypeName("ABI::Windows::Media::Audio::IAudioNodeEmitter *")] IAudioNodeEmitter* emitter, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CAudio__CCreateAudioDeviceInputNodeResult_t **")] IAsyncOperation<IntPtr>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioGraph2*, MediaCategory, IAudioEncodingProperties*, IDeviceInformation*, IAudioNodeEmitter*, IAsyncOperation<IntPtr>**, int>)(lpVtbl[7]))((IAudioGraph2*)Unsafe.AsPointer(ref this), category, encodingProperties, device, emitter, result);
    }

    /// <include file='IAudioGraph2.xml' path='doc/member[@name="IAudioGraph2.CreateFileInputNodeWithEmitterAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT CreateFileInputNodeWithEmitterAsync([NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile* file, [NativeTypeName("ABI::Windows::Media::Audio::IAudioNodeEmitter *")] IAudioNodeEmitter* emitter, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CAudio__CCreateAudioFileInputNodeResult_t **")] IAsyncOperation<IntPtr>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioGraph2*, IStorageFile*, IAudioNodeEmitter*, IAsyncOperation<IntPtr>**, int>)(lpVtbl[8]))((IAudioGraph2*)Unsafe.AsPointer(ref this), file, emitter, result);
    }

    /// <include file='IAudioGraph2.xml' path='doc/member[@name="IAudioGraph2.CreateSubmixNodeWithFormatAndEmitter"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT CreateSubmixNodeWithFormatAndEmitter([NativeTypeName("ABI::Windows::Media::MediaProperties::IAudioEncodingProperties *")] IAudioEncodingProperties* encodingProperties, [NativeTypeName("ABI::Windows::Media::Audio::IAudioNodeEmitter *")] IAudioNodeEmitter* emitter, [NativeTypeName("ABI::Windows::Media::Audio::IAudioInputNode **")] IAudioInputNode** submixNode)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioGraph2*, IAudioEncodingProperties*, IAudioNodeEmitter*, IAudioInputNode**, int>)(lpVtbl[9]))((IAudioGraph2*)Unsafe.AsPointer(ref this), encodingProperties, emitter, submixNode);
    }

    /// <include file='IAudioGraph2.xml' path='doc/member[@name="IAudioGraph2.CreateBatchUpdater"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT CreateBatchUpdater([NativeTypeName("ABI::Windows::Foundation::IClosable **")] IClosable** updater)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioGraph2*, IClosable**, int>)(lpVtbl[10]))((IAudioGraph2*)Unsafe.AsPointer(ref this), updater);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateFrameInputNodeWithFormatAndEmitter([NativeTypeName("ABI::Windows::Media::MediaProperties::IAudioEncodingProperties *")] IAudioEncodingProperties* encodingProperties, [NativeTypeName("ABI::Windows::Media::Audio::IAudioNodeEmitter *")] IAudioNodeEmitter* emitter, [NativeTypeName("ABI::Windows::Media::Audio::IAudioFrameInputNode **")] IAudioFrameInputNode** frameInputNode);

        [VtblIndex(7)]
        HRESULT CreateDeviceInputNodeWithFormatAndEmitterOnDeviceAsync([NativeTypeName("ABI::Windows::Media::Capture::MediaCategory")] MediaCategory category, [NativeTypeName("ABI::Windows::Media::MediaProperties::IAudioEncodingProperties *")] IAudioEncodingProperties* encodingProperties, [NativeTypeName("ABI::Windows::Devices::Enumeration::IDeviceInformation *")] IDeviceInformation* device, [NativeTypeName("ABI::Windows::Media::Audio::IAudioNodeEmitter *")] IAudioNodeEmitter* emitter, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CAudio__CCreateAudioDeviceInputNodeResult_t **")] IAsyncOperation<IntPtr>** result);

        [VtblIndex(8)]
        HRESULT CreateFileInputNodeWithEmitterAsync([NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile* file, [NativeTypeName("ABI::Windows::Media::Audio::IAudioNodeEmitter *")] IAudioNodeEmitter* emitter, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CAudio__CCreateAudioFileInputNodeResult_t **")] IAsyncOperation<IntPtr>** result);

        [VtblIndex(9)]
        HRESULT CreateSubmixNodeWithFormatAndEmitter([NativeTypeName("ABI::Windows::Media::MediaProperties::IAudioEncodingProperties *")] IAudioEncodingProperties* encodingProperties, [NativeTypeName("ABI::Windows::Media::Audio::IAudioNodeEmitter *")] IAudioNodeEmitter* emitter, [NativeTypeName("ABI::Windows::Media::Audio::IAudioInputNode **")] IAudioInputNode** submixNode);

        [VtblIndex(10)]
        HRESULT CreateBatchUpdater([NativeTypeName("ABI::Windows::Foundation::IClosable **")] IClosable** updater);
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

        [NativeTypeName("HRESULT (ABI::Windows::Media::MediaProperties::IAudioEncodingProperties *, ABI::Windows::Media::Audio::IAudioNodeEmitter *, ABI::Windows::Media::Audio::IAudioFrameInputNode **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAudioEncodingProperties*, IAudioNodeEmitter*, IAudioFrameInputNode**, int> CreateFrameInputNodeWithFormatAndEmitter;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Capture::MediaCategory, ABI::Windows::Media::MediaProperties::IAudioEncodingProperties *, ABI::Windows::Devices::Enumeration::IDeviceInformation *, ABI::Windows::Media::Audio::IAudioNodeEmitter *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CAudio__CCreateAudioDeviceInputNodeResult_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, MediaCategory, IAudioEncodingProperties*, IDeviceInformation*, IAudioNodeEmitter*, IAsyncOperation<IntPtr>**, int> CreateDeviceInputNodeWithFormatAndEmitterOnDeviceAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::IStorageFile *, ABI::Windows::Media::Audio::IAudioNodeEmitter *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CAudio__CCreateAudioFileInputNodeResult_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IStorageFile*, IAudioNodeEmitter*, IAsyncOperation<IntPtr>**, int> CreateFileInputNodeWithEmitterAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Media::MediaProperties::IAudioEncodingProperties *, ABI::Windows::Media::Audio::IAudioNodeEmitter *, ABI::Windows::Media::Audio::IAudioInputNode **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAudioEncodingProperties*, IAudioNodeEmitter*, IAudioInputNode**, int> CreateSubmixNodeWithFormatAndEmitter;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IClosable **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IClosable**, int> CreateBatchUpdater;
    }
}
