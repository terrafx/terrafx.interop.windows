// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.audio.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IAudioGraph.xml' path='doc/member[@name="IAudioGraph"]/*' />
[Guid("1AD46EED-E48C-4E14-9660-2C4F83E9CDD8")]
[NativeTypeName("struct IAudioGraph : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAudioGraph : IAudioGraph.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IAudioGraph);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioGraph*, Guid*, void**, int>)(lpVtbl[0]))((IAudioGraph*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioGraph*, uint>)(lpVtbl[1]))((IAudioGraph*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioGraph*, uint>)(lpVtbl[2]))((IAudioGraph*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioGraph*, uint*, Guid**, int>)(lpVtbl[3]))((IAudioGraph*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioGraph*, HSTRING*, int>)(lpVtbl[4]))((IAudioGraph*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioGraph*, TrustLevel*, int>)(lpVtbl[5]))((IAudioGraph*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IAudioGraph.xml' path='doc/member[@name="IAudioGraph.CreateFrameInputNode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateFrameInputNode([NativeTypeName("ABI::Windows::Media::Audio::IAudioFrameInputNode **")] IAudioFrameInputNode** frameInputNode)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioGraph*, IAudioFrameInputNode**, int>)(lpVtbl[6]))((IAudioGraph*)Unsafe.AsPointer(ref this), frameInputNode);
    }

    /// <include file='IAudioGraph.xml' path='doc/member[@name="IAudioGraph.CreateFrameInputNodeWithFormat"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateFrameInputNodeWithFormat([NativeTypeName("ABI::Windows::Media::MediaProperties::IAudioEncodingProperties *")] IAudioEncodingProperties* encodingProperties, [NativeTypeName("ABI::Windows::Media::Audio::IAudioFrameInputNode **")] IAudioFrameInputNode** frameInputNode)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioGraph*, IAudioEncodingProperties*, IAudioFrameInputNode**, int>)(lpVtbl[7]))((IAudioGraph*)Unsafe.AsPointer(ref this), encodingProperties, frameInputNode);
    }

    /// <include file='IAudioGraph.xml' path='doc/member[@name="IAudioGraph.CreateDeviceInputNodeAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT CreateDeviceInputNodeAsync([NativeTypeName("ABI::Windows::Media::Capture::MediaCategory")] MediaCategory category, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CAudio__CCreateAudioDeviceInputNodeResult_t **")] IAsyncOperation<Pointer<ICreateAudioDeviceInputNodeResult>>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioGraph*, MediaCategory, IAsyncOperation<Pointer<ICreateAudioDeviceInputNodeResult>>**, int>)(lpVtbl[8]))((IAudioGraph*)Unsafe.AsPointer(ref this), category, result);
    }

    /// <include file='IAudioGraph.xml' path='doc/member[@name="IAudioGraph.CreateDeviceInputNodeWithFormatAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT CreateDeviceInputNodeWithFormatAsync([NativeTypeName("ABI::Windows::Media::Capture::MediaCategory")] MediaCategory category, [NativeTypeName("ABI::Windows::Media::MediaProperties::IAudioEncodingProperties *")] IAudioEncodingProperties* encodingProperties, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CAudio__CCreateAudioDeviceInputNodeResult_t **")] IAsyncOperation<Pointer<ICreateAudioDeviceInputNodeResult>>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioGraph*, MediaCategory, IAudioEncodingProperties*, IAsyncOperation<Pointer<ICreateAudioDeviceInputNodeResult>>**, int>)(lpVtbl[9]))((IAudioGraph*)Unsafe.AsPointer(ref this), category, encodingProperties, result);
    }

    /// <include file='IAudioGraph.xml' path='doc/member[@name="IAudioGraph.CreateDeviceInputNodeWithFormatOnDeviceAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT CreateDeviceInputNodeWithFormatOnDeviceAsync([NativeTypeName("ABI::Windows::Media::Capture::MediaCategory")] MediaCategory category, [NativeTypeName("ABI::Windows::Media::MediaProperties::IAudioEncodingProperties *")] IAudioEncodingProperties* encodingProperties, [NativeTypeName("ABI::Windows::Devices::Enumeration::IDeviceInformation *")] IDeviceInformation* device, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CAudio__CCreateAudioDeviceInputNodeResult_t **")] IAsyncOperation<Pointer<ICreateAudioDeviceInputNodeResult>>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioGraph*, MediaCategory, IAudioEncodingProperties*, IDeviceInformation*, IAsyncOperation<Pointer<ICreateAudioDeviceInputNodeResult>>**, int>)(lpVtbl[10]))((IAudioGraph*)Unsafe.AsPointer(ref this), category, encodingProperties, device, result);
    }

    /// <include file='IAudioGraph.xml' path='doc/member[@name="IAudioGraph.CreateFrameOutputNode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT CreateFrameOutputNode([NativeTypeName("ABI::Windows::Media::Audio::IAudioFrameOutputNode **")] IAudioFrameOutputNode** frameOutputNode)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioGraph*, IAudioFrameOutputNode**, int>)(lpVtbl[11]))((IAudioGraph*)Unsafe.AsPointer(ref this), frameOutputNode);
    }

    /// <include file='IAudioGraph.xml' path='doc/member[@name="IAudioGraph.CreateFrameOutputNodeWithFormat"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT CreateFrameOutputNodeWithFormat([NativeTypeName("ABI::Windows::Media::MediaProperties::IAudioEncodingProperties *")] IAudioEncodingProperties* encodingProperties, [NativeTypeName("ABI::Windows::Media::Audio::IAudioFrameOutputNode **")] IAudioFrameOutputNode** frameOutputNode)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioGraph*, IAudioEncodingProperties*, IAudioFrameOutputNode**, int>)(lpVtbl[12]))((IAudioGraph*)Unsafe.AsPointer(ref this), encodingProperties, frameOutputNode);
    }

    /// <include file='IAudioGraph.xml' path='doc/member[@name="IAudioGraph.CreateDeviceOutputNodeAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT CreateDeviceOutputNodeAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CAudio__CCreateAudioDeviceOutputNodeResult_t **")] IAsyncOperation<Pointer<ICreateAudioDeviceOutputNodeResult>>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioGraph*, IAsyncOperation<Pointer<ICreateAudioDeviceOutputNodeResult>>**, int>)(lpVtbl[13]))((IAudioGraph*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='IAudioGraph.xml' path='doc/member[@name="IAudioGraph.CreateFileInputNodeAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT CreateFileInputNodeAsync([NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile* file, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CAudio__CCreateAudioFileInputNodeResult_t **")] IAsyncOperation<Pointer<ICreateAudioFileInputNodeResult>>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioGraph*, IStorageFile*, IAsyncOperation<Pointer<ICreateAudioFileInputNodeResult>>**, int>)(lpVtbl[14]))((IAudioGraph*)Unsafe.AsPointer(ref this), file, result);
    }

    /// <include file='IAudioGraph.xml' path='doc/member[@name="IAudioGraph.CreateFileOutputNodeAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT CreateFileOutputNodeAsync([NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile* file, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CAudio__CCreateAudioFileOutputNodeResult_t **")] IAsyncOperation<Pointer<ICreateAudioFileOutputNodeResult>>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioGraph*, IStorageFile*, IAsyncOperation<Pointer<ICreateAudioFileOutputNodeResult>>**, int>)(lpVtbl[15]))((IAudioGraph*)Unsafe.AsPointer(ref this), file, result);
    }

    /// <include file='IAudioGraph.xml' path='doc/member[@name="IAudioGraph.CreateFileOutputNodeWithFileProfileAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT CreateFileOutputNodeWithFileProfileAsync([NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile* file, [NativeTypeName("ABI::Windows::Media::MediaProperties::IMediaEncodingProfile *")] IMediaEncodingProfile* fileEncodingProfile, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CAudio__CCreateAudioFileOutputNodeResult_t **")] IAsyncOperation<Pointer<ICreateAudioFileOutputNodeResult>>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioGraph*, IStorageFile*, IMediaEncodingProfile*, IAsyncOperation<Pointer<ICreateAudioFileOutputNodeResult>>**, int>)(lpVtbl[16]))((IAudioGraph*)Unsafe.AsPointer(ref this), file, fileEncodingProfile, result);
    }

    /// <include file='IAudioGraph.xml' path='doc/member[@name="IAudioGraph.CreateSubmixNode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT CreateSubmixNode([NativeTypeName("ABI::Windows::Media::Audio::IAudioInputNode **")] IAudioInputNode** submixNode)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioGraph*, IAudioInputNode**, int>)(lpVtbl[17]))((IAudioGraph*)Unsafe.AsPointer(ref this), submixNode);
    }

    /// <include file='IAudioGraph.xml' path='doc/member[@name="IAudioGraph.CreateSubmixNodeWithFormat"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT CreateSubmixNodeWithFormat([NativeTypeName("ABI::Windows::Media::MediaProperties::IAudioEncodingProperties *")] IAudioEncodingProperties* encodingProperties, [NativeTypeName("ABI::Windows::Media::Audio::IAudioInputNode **")] IAudioInputNode** submixNode)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioGraph*, IAudioEncodingProperties*, IAudioInputNode**, int>)(lpVtbl[18]))((IAudioGraph*)Unsafe.AsPointer(ref this), encodingProperties, submixNode);
    }

    /// <include file='IAudioGraph.xml' path='doc/member[@name="IAudioGraph.Start"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT Start()
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioGraph*, int>)(lpVtbl[19]))((IAudioGraph*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IAudioGraph.xml' path='doc/member[@name="IAudioGraph.Stop"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT Stop()
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioGraph*, int>)(lpVtbl[20]))((IAudioGraph*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IAudioGraph.xml' path='doc/member[@name="IAudioGraph.ResetAllNodes"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT ResetAllNodes()
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioGraph*, int>)(lpVtbl[21]))((IAudioGraph*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IAudioGraph.xml' path='doc/member[@name="IAudioGraph.add_QuantumStarted"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT add_QuantumStarted([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CAudio__CAudioGraph_IInspectable_t *")] ITypedEventHandler<Pointer<IAudioGraph>, Pointer<IInspectable>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioGraph*, ITypedEventHandler<Pointer<IAudioGraph>, Pointer<IInspectable>>*, EventRegistrationToken*, int>)(lpVtbl[22]))((IAudioGraph*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IAudioGraph.xml' path='doc/member[@name="IAudioGraph.remove_QuantumStarted"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT remove_QuantumStarted(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioGraph*, EventRegistrationToken, int>)(lpVtbl[23]))((IAudioGraph*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IAudioGraph.xml' path='doc/member[@name="IAudioGraph.add_QuantumProcessed"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT add_QuantumProcessed([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CAudio__CAudioGraph_IInspectable_t *")] ITypedEventHandler<Pointer<IAudioGraph>, Pointer<IInspectable>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioGraph*, ITypedEventHandler<Pointer<IAudioGraph>, Pointer<IInspectable>>*, EventRegistrationToken*, int>)(lpVtbl[24]))((IAudioGraph*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IAudioGraph.xml' path='doc/member[@name="IAudioGraph.remove_QuantumProcessed"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT remove_QuantumProcessed(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioGraph*, EventRegistrationToken, int>)(lpVtbl[25]))((IAudioGraph*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IAudioGraph.xml' path='doc/member[@name="IAudioGraph.add_UnrecoverableErrorOccurred"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT add_UnrecoverableErrorOccurred([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CAudio__CAudioGraph_Windows__CMedia__CAudio__CAudioGraphUnrecoverableErrorOccurredEventArgs_t *")] ITypedEventHandler<Pointer<IAudioGraph>, Pointer<IAudioGraphUnrecoverableErrorOccurredEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioGraph*, ITypedEventHandler<Pointer<IAudioGraph>, Pointer<IAudioGraphUnrecoverableErrorOccurredEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[26]))((IAudioGraph*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IAudioGraph.xml' path='doc/member[@name="IAudioGraph.remove_UnrecoverableErrorOccurred"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT remove_UnrecoverableErrorOccurred(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioGraph*, EventRegistrationToken, int>)(lpVtbl[27]))((IAudioGraph*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IAudioGraph.xml' path='doc/member[@name="IAudioGraph.get_CompletedQuantumCount"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT get_CompletedQuantumCount([NativeTypeName("UINT64 *")] ulong* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioGraph*, ulong*, int>)(lpVtbl[28]))((IAudioGraph*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAudioGraph.xml' path='doc/member[@name="IAudioGraph.get_EncodingProperties"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT get_EncodingProperties([NativeTypeName("ABI::Windows::Media::MediaProperties::IAudioEncodingProperties **")] IAudioEncodingProperties** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioGraph*, IAudioEncodingProperties**, int>)(lpVtbl[29]))((IAudioGraph*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAudioGraph.xml' path='doc/member[@name="IAudioGraph.get_LatencyInSamples"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT get_LatencyInSamples([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioGraph*, int*, int>)(lpVtbl[30]))((IAudioGraph*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAudioGraph.xml' path='doc/member[@name="IAudioGraph.get_PrimaryRenderDevice"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT get_PrimaryRenderDevice([NativeTypeName("ABI::Windows::Devices::Enumeration::IDeviceInformation **")] IDeviceInformation** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioGraph*, IDeviceInformation**, int>)(lpVtbl[31]))((IAudioGraph*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAudioGraph.xml' path='doc/member[@name="IAudioGraph.get_RenderDeviceAudioProcessing"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public HRESULT get_RenderDeviceAudioProcessing([NativeTypeName("ABI::Windows::Media::AudioProcessing *")] AudioProcessing* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioGraph*, AudioProcessing*, int>)(lpVtbl[32]))((IAudioGraph*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAudioGraph.xml' path='doc/member[@name="IAudioGraph.get_SamplesPerQuantum"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    public HRESULT get_SamplesPerQuantum([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioGraph*, int*, int>)(lpVtbl[33]))((IAudioGraph*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateFrameInputNode([NativeTypeName("ABI::Windows::Media::Audio::IAudioFrameInputNode **")] IAudioFrameInputNode** frameInputNode);

        [VtblIndex(7)]
        HRESULT CreateFrameInputNodeWithFormat([NativeTypeName("ABI::Windows::Media::MediaProperties::IAudioEncodingProperties *")] IAudioEncodingProperties* encodingProperties, [NativeTypeName("ABI::Windows::Media::Audio::IAudioFrameInputNode **")] IAudioFrameInputNode** frameInputNode);

        [VtblIndex(8)]
        HRESULT CreateDeviceInputNodeAsync([NativeTypeName("ABI::Windows::Media::Capture::MediaCategory")] MediaCategory category, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CAudio__CCreateAudioDeviceInputNodeResult_t **")] IAsyncOperation<Pointer<ICreateAudioDeviceInputNodeResult>>** result);

        [VtblIndex(9)]
        HRESULT CreateDeviceInputNodeWithFormatAsync([NativeTypeName("ABI::Windows::Media::Capture::MediaCategory")] MediaCategory category, [NativeTypeName("ABI::Windows::Media::MediaProperties::IAudioEncodingProperties *")] IAudioEncodingProperties* encodingProperties, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CAudio__CCreateAudioDeviceInputNodeResult_t **")] IAsyncOperation<Pointer<ICreateAudioDeviceInputNodeResult>>** result);

        [VtblIndex(10)]
        HRESULT CreateDeviceInputNodeWithFormatOnDeviceAsync([NativeTypeName("ABI::Windows::Media::Capture::MediaCategory")] MediaCategory category, [NativeTypeName("ABI::Windows::Media::MediaProperties::IAudioEncodingProperties *")] IAudioEncodingProperties* encodingProperties, [NativeTypeName("ABI::Windows::Devices::Enumeration::IDeviceInformation *")] IDeviceInformation* device, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CAudio__CCreateAudioDeviceInputNodeResult_t **")] IAsyncOperation<Pointer<ICreateAudioDeviceInputNodeResult>>** result);

        [VtblIndex(11)]
        HRESULT CreateFrameOutputNode([NativeTypeName("ABI::Windows::Media::Audio::IAudioFrameOutputNode **")] IAudioFrameOutputNode** frameOutputNode);

        [VtblIndex(12)]
        HRESULT CreateFrameOutputNodeWithFormat([NativeTypeName("ABI::Windows::Media::MediaProperties::IAudioEncodingProperties *")] IAudioEncodingProperties* encodingProperties, [NativeTypeName("ABI::Windows::Media::Audio::IAudioFrameOutputNode **")] IAudioFrameOutputNode** frameOutputNode);

        [VtblIndex(13)]
        HRESULT CreateDeviceOutputNodeAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CAudio__CCreateAudioDeviceOutputNodeResult_t **")] IAsyncOperation<Pointer<ICreateAudioDeviceOutputNodeResult>>** result);

        [VtblIndex(14)]
        HRESULT CreateFileInputNodeAsync([NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile* file, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CAudio__CCreateAudioFileInputNodeResult_t **")] IAsyncOperation<Pointer<ICreateAudioFileInputNodeResult>>** result);

        [VtblIndex(15)]
        HRESULT CreateFileOutputNodeAsync([NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile* file, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CAudio__CCreateAudioFileOutputNodeResult_t **")] IAsyncOperation<Pointer<ICreateAudioFileOutputNodeResult>>** result);

        [VtblIndex(16)]
        HRESULT CreateFileOutputNodeWithFileProfileAsync([NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile* file, [NativeTypeName("ABI::Windows::Media::MediaProperties::IMediaEncodingProfile *")] IMediaEncodingProfile* fileEncodingProfile, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CAudio__CCreateAudioFileOutputNodeResult_t **")] IAsyncOperation<Pointer<ICreateAudioFileOutputNodeResult>>** result);

        [VtblIndex(17)]
        HRESULT CreateSubmixNode([NativeTypeName("ABI::Windows::Media::Audio::IAudioInputNode **")] IAudioInputNode** submixNode);

        [VtblIndex(18)]
        HRESULT CreateSubmixNodeWithFormat([NativeTypeName("ABI::Windows::Media::MediaProperties::IAudioEncodingProperties *")] IAudioEncodingProperties* encodingProperties, [NativeTypeName("ABI::Windows::Media::Audio::IAudioInputNode **")] IAudioInputNode** submixNode);

        [VtblIndex(19)]
        HRESULT Start();

        [VtblIndex(20)]
        HRESULT Stop();

        [VtblIndex(21)]
        HRESULT ResetAllNodes();

        [VtblIndex(22)]
        HRESULT add_QuantumStarted([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CAudio__CAudioGraph_IInspectable_t *")] ITypedEventHandler<Pointer<IAudioGraph>, Pointer<IInspectable>>* handler, EventRegistrationToken* token);

        [VtblIndex(23)]
        HRESULT remove_QuantumStarted(EventRegistrationToken token);

        [VtblIndex(24)]
        HRESULT add_QuantumProcessed([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CAudio__CAudioGraph_IInspectable_t *")] ITypedEventHandler<Pointer<IAudioGraph>, Pointer<IInspectable>>* handler, EventRegistrationToken* token);

        [VtblIndex(25)]
        HRESULT remove_QuantumProcessed(EventRegistrationToken token);

        [VtblIndex(26)]
        HRESULT add_UnrecoverableErrorOccurred([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CAudio__CAudioGraph_Windows__CMedia__CAudio__CAudioGraphUnrecoverableErrorOccurredEventArgs_t *")] ITypedEventHandler<Pointer<IAudioGraph>, Pointer<IAudioGraphUnrecoverableErrorOccurredEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(27)]
        HRESULT remove_UnrecoverableErrorOccurred(EventRegistrationToken token);

        [VtblIndex(28)]
        HRESULT get_CompletedQuantumCount([NativeTypeName("UINT64 *")] ulong* value);

        [VtblIndex(29)]
        HRESULT get_EncodingProperties([NativeTypeName("ABI::Windows::Media::MediaProperties::IAudioEncodingProperties **")] IAudioEncodingProperties** value);

        [VtblIndex(30)]
        HRESULT get_LatencyInSamples([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(31)]
        HRESULT get_PrimaryRenderDevice([NativeTypeName("ABI::Windows::Devices::Enumeration::IDeviceInformation **")] IDeviceInformation** value);

        [VtblIndex(32)]
        HRESULT get_RenderDeviceAudioProcessing([NativeTypeName("ABI::Windows::Media::AudioProcessing *")] AudioProcessing* value);

        [VtblIndex(33)]
        HRESULT get_SamplesPerQuantum([NativeTypeName("INT32 *")] int* value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Media::Audio::IAudioFrameInputNode **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAudioFrameInputNode**, int> CreateFrameInputNode;

        [NativeTypeName("HRESULT (ABI::Windows::Media::MediaProperties::IAudioEncodingProperties *, ABI::Windows::Media::Audio::IAudioFrameInputNode **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAudioEncodingProperties*, IAudioFrameInputNode**, int> CreateFrameInputNodeWithFormat;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Capture::MediaCategory, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CAudio__CCreateAudioDeviceInputNodeResult_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, MediaCategory, IAsyncOperation<Pointer<ICreateAudioDeviceInputNodeResult>>**, int> CreateDeviceInputNodeAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Capture::MediaCategory, ABI::Windows::Media::MediaProperties::IAudioEncodingProperties *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CAudio__CCreateAudioDeviceInputNodeResult_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, MediaCategory, IAudioEncodingProperties*, IAsyncOperation<Pointer<ICreateAudioDeviceInputNodeResult>>**, int> CreateDeviceInputNodeWithFormatAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Capture::MediaCategory, ABI::Windows::Media::MediaProperties::IAudioEncodingProperties *, ABI::Windows::Devices::Enumeration::IDeviceInformation *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CAudio__CCreateAudioDeviceInputNodeResult_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, MediaCategory, IAudioEncodingProperties*, IDeviceInformation*, IAsyncOperation<Pointer<ICreateAudioDeviceInputNodeResult>>**, int> CreateDeviceInputNodeWithFormatOnDeviceAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Audio::IAudioFrameOutputNode **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAudioFrameOutputNode**, int> CreateFrameOutputNode;

        [NativeTypeName("HRESULT (ABI::Windows::Media::MediaProperties::IAudioEncodingProperties *, ABI::Windows::Media::Audio::IAudioFrameOutputNode **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAudioEncodingProperties*, IAudioFrameOutputNode**, int> CreateFrameOutputNodeWithFormat;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CAudio__CCreateAudioDeviceOutputNodeResult_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncOperation<Pointer<ICreateAudioDeviceOutputNodeResult>>**, int> CreateDeviceOutputNodeAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::IStorageFile *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CAudio__CCreateAudioFileInputNodeResult_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IStorageFile*, IAsyncOperation<Pointer<ICreateAudioFileInputNodeResult>>**, int> CreateFileInputNodeAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::IStorageFile *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CAudio__CCreateAudioFileOutputNodeResult_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IStorageFile*, IAsyncOperation<Pointer<ICreateAudioFileOutputNodeResult>>**, int> CreateFileOutputNodeAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::IStorageFile *, ABI::Windows::Media::MediaProperties::IMediaEncodingProfile *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CAudio__CCreateAudioFileOutputNodeResult_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IStorageFile*, IMediaEncodingProfile*, IAsyncOperation<Pointer<ICreateAudioFileOutputNodeResult>>**, int> CreateFileOutputNodeWithFileProfileAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Audio::IAudioInputNode **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAudioInputNode**, int> CreateSubmixNode;

        [NativeTypeName("HRESULT (ABI::Windows::Media::MediaProperties::IAudioEncodingProperties *, ABI::Windows::Media::Audio::IAudioInputNode **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAudioEncodingProperties*, IAudioInputNode**, int> CreateSubmixNodeWithFormat;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> Start;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> Stop;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> ResetAllNodes;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CAudio__CAudioGraph_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IAudioGraph>, Pointer<IInspectable>>*, EventRegistrationToken*, int> add_QuantumStarted;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_QuantumStarted;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CAudio__CAudioGraph_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IAudioGraph>, Pointer<IInspectable>>*, EventRegistrationToken*, int> add_QuantumProcessed;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_QuantumProcessed;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CAudio__CAudioGraph_Windows__CMedia__CAudio__CAudioGraphUnrecoverableErrorOccurredEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IAudioGraph>, Pointer<IAudioGraphUnrecoverableErrorOccurredEventArgs>>*, EventRegistrationToken*, int> add_UnrecoverableErrorOccurred;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_UnrecoverableErrorOccurred;

        [NativeTypeName("HRESULT (UINT64 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ulong*, int> get_CompletedQuantumCount;

        [NativeTypeName("HRESULT (ABI::Windows::Media::MediaProperties::IAudioEncodingProperties **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAudioEncodingProperties**, int> get_EncodingProperties;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> get_LatencyInSamples;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Enumeration::IDeviceInformation **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDeviceInformation**, int> get_PrimaryRenderDevice;

        [NativeTypeName("HRESULT (ABI::Windows::Media::AudioProcessing *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, AudioProcessing*, int> get_RenderDeviceAudioProcessing;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> get_SamplesPerQuantum;
    }
}
