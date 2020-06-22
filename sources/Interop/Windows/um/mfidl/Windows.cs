// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [DllImport("mf", EntryPoint = "MFCreateMediaSession", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateMediaSession([NativeTypeName("IMFAttributes *")] IMFAttributes* pConfiguration, [NativeTypeName("IMFMediaSession **")] IMFMediaSession** ppMediaSession);

        [DllImport("mf", EntryPoint = "MFCreatePMPMediaSession", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreatePMPMediaSession([NativeTypeName("DWORD")] uint dwCreationFlags, [NativeTypeName("IMFAttributes *")] IMFAttributes* pConfiguration, [NativeTypeName("IMFMediaSession **")] IMFMediaSession** ppMediaSession, [NativeTypeName("IMFActivate **")] IMFActivate** ppEnablerActivate);

        [DllImport("mfplat", EntryPoint = "MFCreateSourceResolver", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateSourceResolver([NativeTypeName("IMFSourceResolver **")] IMFSourceResolver** ppISourceResolver);

        [DllImport("mfplat", EntryPoint = "CreatePropertyStore", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CreatePropertyStore([NativeTypeName("IPropertyStore **")] IPropertyStore** ppStore);

        [DllImport("mf", EntryPoint = "MFGetSupportedSchemes", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFGetSupportedSchemes([NativeTypeName("PROPVARIANT *")] PROPVARIANT* pPropVarSchemeArray);

        [DllImport("mf", EntryPoint = "MFGetSupportedMimeTypes", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFGetSupportedMimeTypes([NativeTypeName("PROPVARIANT *")] PROPVARIANT* pPropVarMimeTypeArray);

        [DllImport("mf", EntryPoint = "MFCreateTopology", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateTopology([NativeTypeName("IMFTopology **")] IMFTopology** ppTopo);

        [DllImport("mf", EntryPoint = "MFCreateTopologyNode", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateTopologyNode(MF_TOPOLOGY_TYPE NodeType, [NativeTypeName("IMFTopologyNode **")] IMFTopologyNode** ppNode);

        [DllImport("mf", EntryPoint = "MFGetTopoNodeCurrentType", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFGetTopoNodeCurrentType([NativeTypeName("IMFTopologyNode *")] IMFTopologyNode* pNode, [NativeTypeName("DWORD")] uint dwStreamIndex, [NativeTypeName("BOOL")] int fOutput, [NativeTypeName("IMFMediaType **")] IMFMediaType** ppType);

        [DllImport("mf", EntryPoint = "MFGetService", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFGetService([NativeTypeName("IUnknown *")] IUnknown* punkObject, [NativeTypeName("const GUID &")] Guid* guidService, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPVOID *")] void** ppvObject);

        [DllImport("mfplat", EntryPoint = "MFGetSystemTime", ExactSpelling = true)]
        [return: NativeTypeName("MFTIME")]
        public static extern long MFGetSystemTime();

        [DllImport("mf", EntryPoint = "MFCreatePresentationClock", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreatePresentationClock([NativeTypeName("IMFPresentationClock **")] IMFPresentationClock** ppPresentationClock);

        [DllImport("mfplat", EntryPoint = "MFCreateSystemTimeSource", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateSystemTimeSource([NativeTypeName("IMFPresentationTimeSource **")] IMFPresentationTimeSource** ppSystemTimeSource);

        [DllImport("mfplat", EntryPoint = "MFCreatePresentationDescriptor", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreatePresentationDescriptor([NativeTypeName("DWORD")] uint cStreamDescriptors, [NativeTypeName("IMFStreamDescriptor **")] IMFStreamDescriptor** apStreamDescriptors, [NativeTypeName("IMFPresentationDescriptor **")] IMFPresentationDescriptor** ppPresentationDescriptor);

        [DllImport("mf", EntryPoint = "MFRequireProtectedEnvironment", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFRequireProtectedEnvironment([NativeTypeName("IMFPresentationDescriptor *")] IMFPresentationDescriptor* pPresentationDescriptor);

        [DllImport("mfplat", EntryPoint = "MFSerializePresentationDescriptor", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFSerializePresentationDescriptor([NativeTypeName("IMFPresentationDescriptor *")] IMFPresentationDescriptor* pPD, [NativeTypeName("DWORD *")] uint* pcbData, [NativeTypeName("BYTE **")] byte** ppbData);

        [DllImport("mfplat", EntryPoint = "MFDeserializePresentationDescriptor", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFDeserializePresentationDescriptor([NativeTypeName("DWORD")] uint cbData, [NativeTypeName("BYTE *")] byte* pbData, [NativeTypeName("IMFPresentationDescriptor **")] IMFPresentationDescriptor** ppPD);

        [DllImport("mfplat", EntryPoint = "MFCreateStreamDescriptor", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateStreamDescriptor([NativeTypeName("DWORD")] uint dwStreamIdentifier, [NativeTypeName("DWORD")] uint cMediaTypes, [NativeTypeName("IMFMediaType **")] IMFMediaType** apMediaTypes, [NativeTypeName("IMFStreamDescriptor **")] IMFStreamDescriptor** ppDescriptor);

        [DllImport("mf", EntryPoint = "MFCreateSimpleTypeHandler", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateSimpleTypeHandler([NativeTypeName("IMFMediaTypeHandler **")] IMFMediaTypeHandler** ppHandler);

        [DllImport("mf", EntryPoint = "MFShutdownObject", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFShutdownObject([NativeTypeName("IUnknown *")] IUnknown* pUnk);

        [DllImport("mf", EntryPoint = "MFCreateAudioRenderer", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateAudioRenderer([NativeTypeName("IMFAttributes *")] IMFAttributes* pAudioAttributes, [NativeTypeName("IMFMediaSink **")] IMFMediaSink** ppSink);

        [DllImport("mf", EntryPoint = "MFCreateAudioRendererActivate", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateAudioRendererActivate([NativeTypeName("IMFActivate **")] IMFActivate** ppActivate);

        [DllImport("mf", EntryPoint = "MFCreateVideoRendererActivate", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateVideoRendererActivate([NativeTypeName("HWND")] IntPtr hwndVideo, [NativeTypeName("IMFActivate **")] IMFActivate** ppActivate);

        [DllImport("mf", EntryPoint = "MFCreateMPEG4MediaSink", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateMPEG4MediaSink([NativeTypeName("IMFByteStream *")] IMFByteStream* pIByteStream, [NativeTypeName("IMFMediaType *")] IMFMediaType* pVideoMediaType, [NativeTypeName("IMFMediaType *")] IMFMediaType* pAudioMediaType, [NativeTypeName("IMFMediaSink **")] IMFMediaSink** ppIMediaSink);

        [DllImport("mf", EntryPoint = "MFCreate3GPMediaSink", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreate3GPMediaSink([NativeTypeName("IMFByteStream *")] IMFByteStream* pIByteStream, [NativeTypeName("IMFMediaType *")] IMFMediaType* pVideoMediaType, [NativeTypeName("IMFMediaType *")] IMFMediaType* pAudioMediaType, [NativeTypeName("IMFMediaSink **")] IMFMediaSink** ppIMediaSink);

        [DllImport("mf", EntryPoint = "MFCreateMP3MediaSink", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateMP3MediaSink([NativeTypeName("IMFByteStream *")] IMFByteStream* pTargetByteStream, [NativeTypeName("IMFMediaSink **")] IMFMediaSink** ppMediaSink);

        [DllImport("mf", EntryPoint = "MFCreateAC3MediaSink", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateAC3MediaSink([NativeTypeName("IMFByteStream *")] IMFByteStream* pTargetByteStream, [NativeTypeName("IMFMediaType *")] IMFMediaType* pAudioMediaType, [NativeTypeName("IMFMediaSink **")] IMFMediaSink** ppMediaSink);

        [DllImport("mf", EntryPoint = "MFCreateADTSMediaSink", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateADTSMediaSink([NativeTypeName("IMFByteStream *")] IMFByteStream* pTargetByteStream, [NativeTypeName("IMFMediaType *")] IMFMediaType* pAudioMediaType, [NativeTypeName("IMFMediaSink **")] IMFMediaSink** ppMediaSink);

        [DllImport("mf", EntryPoint = "MFCreateMuxSink", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateMuxSink([NativeTypeName("GUID")] Guid guidOutputSubType, [NativeTypeName("IMFAttributes *")] IMFAttributes* pOutputAttributes, [NativeTypeName("IMFByteStream *")] IMFByteStream* pOutputByteStream, [NativeTypeName("IMFMediaSink **")] IMFMediaSink** ppMuxSink);

        [DllImport("mf", EntryPoint = "MFCreateFMPEG4MediaSink", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateFMPEG4MediaSink([NativeTypeName("IMFByteStream *")] IMFByteStream* pIByteStream, [NativeTypeName("IMFMediaType *")] IMFMediaType* pVideoMediaType, [NativeTypeName("IMFMediaType *")] IMFMediaType* pAudioMediaType, [NativeTypeName("IMFMediaSink **")] IMFMediaSink** ppIMediaSink);

        [DllImport("mf", EntryPoint = "MFCreateAVIMediaSink", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateAVIMediaSink([NativeTypeName("IMFByteStream *")] IMFByteStream* pIByteStream, [NativeTypeName("IMFMediaType *")] IMFMediaType* pVideoMediaType, [NativeTypeName("IMFMediaType *")] IMFMediaType* pAudioMediaType, [NativeTypeName("IMFMediaSink **")] IMFMediaSink** ppIMediaSink);

        [DllImport("mf", EntryPoint = "MFCreateWAVEMediaSink", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateWAVEMediaSink([NativeTypeName("IMFByteStream *")] IMFByteStream* pTargetByteStream, [NativeTypeName("IMFMediaType *")] IMFMediaType* pAudioMediaType, [NativeTypeName("IMFMediaSink **")] IMFMediaSink** ppMediaSink);

        [DllImport("mf", EntryPoint = "MFCreateTopoLoader", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateTopoLoader([NativeTypeName("IMFTopoLoader **")] IMFTopoLoader** ppObj);

        [DllImport("mf", EntryPoint = "MFCreateSampleGrabberSinkActivate", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateSampleGrabberSinkActivate([NativeTypeName("IMFMediaType *")] IMFMediaType* pIMFMediaType, [NativeTypeName("IMFSampleGrabberSinkCallback *")] IMFSampleGrabberSinkCallback* pIMFSampleGrabberSinkCallback, [NativeTypeName("IMFActivate **")] IMFActivate** ppIActivate);

        [DllImport("mf", EntryPoint = "MFCreateStandardQualityManager", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateStandardQualityManager([NativeTypeName("IMFQualityManager **")] IMFQualityManager** ppQualityManager);

        [DllImport("mf", EntryPoint = "MFCreateSequencerSource", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateSequencerSource([NativeTypeName("IUnknown *")] IUnknown* pReserved, [NativeTypeName("IMFSequencerSource **")] IMFSequencerSource** ppSequencerSource);

        [DllImport("mf", EntryPoint = "MFCreateSequencerSegmentOffset", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateSequencerSegmentOffset([NativeTypeName("MFSequencerElementId")] uint dwId, [NativeTypeName("MFTIME")] long hnsOffset, [NativeTypeName("PROPVARIANT *")] PROPVARIANT* pvarSegmentOffset);

        [DllImport("mf", EntryPoint = "MFCreateAggregateSource", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateAggregateSource([NativeTypeName("IMFCollection *")] IMFCollection* pSourceCollection, [NativeTypeName("IMFMediaSource **")] IMFMediaSource** ppAggSource);

        [DllImport("mf", EntryPoint = "MFCreateCredentialCache", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateCredentialCache([NativeTypeName("IMFNetCredentialCache **")] IMFNetCredentialCache** ppCache);

        [DllImport("mf", EntryPoint = "MFCreateProxyLocator", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateProxyLocator([NativeTypeName("LPCWSTR")] ushort* pszProtocol, [NativeTypeName("IPropertyStore *")] IPropertyStore* pProxyConfig, [NativeTypeName("IMFNetProxyLocator **")] IMFNetProxyLocator** ppProxyLocator);

        [DllImport("mf", EntryPoint = "MFCreateNetSchemePlugin", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateNetSchemePlugin([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPVOID *")] void** ppvHandler);

        [DllImport("mf", EntryPoint = "MFCreatePMPServer", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreatePMPServer([NativeTypeName("DWORD")] uint dwCreationFlags, [NativeTypeName("IMFPMPServer **")] IMFPMPServer** ppPMPServer);

        [DllImport("mf", EntryPoint = "MFCreateRemoteDesktopPlugin", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateRemoteDesktopPlugin([NativeTypeName("IMFRemoteDesktopPlugin **")] IMFRemoteDesktopPlugin** ppPlugin);

        [DllImport("mf", EntryPoint = "CreateNamedPropertyStore", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CreateNamedPropertyStore([NativeTypeName("INamedPropertyStore **")] INamedPropertyStore** ppStore);

        [DllImport("mf", EntryPoint = "MFCreateSampleCopierMFT", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateSampleCopierMFT([NativeTypeName("IMFTransform **")] IMFTransform** ppCopierMFT);

        [DllImport("mf", EntryPoint = "MFCreateTranscodeProfile", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateTranscodeProfile([NativeTypeName("IMFTranscodeProfile **")] IMFTranscodeProfile** ppTranscodeProfile);

        [DllImport("mf", EntryPoint = "MFCreateTranscodeTopology", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateTranscodeTopology([NativeTypeName("IMFMediaSource *")] IMFMediaSource* pSrc, [NativeTypeName("LPCWSTR")] ushort* pwszOutputFilePath, [NativeTypeName("IMFTranscodeProfile *")] IMFTranscodeProfile* pProfile, [NativeTypeName("IMFTopology **")] IMFTopology** ppTranscodeTopo);

        [DllImport("mf", EntryPoint = "MFCreateTranscodeTopologyFromByteStream", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateTranscodeTopologyFromByteStream([NativeTypeName("IMFMediaSource *")] IMFMediaSource* pSrc, [NativeTypeName("IMFByteStream *")] IMFByteStream* pOutputStream, [NativeTypeName("IMFTranscodeProfile *")] IMFTranscodeProfile* pProfile, [NativeTypeName("IMFTopology **")] IMFTopology** ppTranscodeTopo);

        [DllImport("mf", EntryPoint = "MFTranscodeGetAudioOutputAvailableTypes", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFTranscodeGetAudioOutputAvailableTypes([NativeTypeName("const GUID &")] Guid* guidSubType, [NativeTypeName("DWORD")] uint dwMFTFlags, [NativeTypeName("IMFAttributes *")] IMFAttributes* pCodecConfig, [NativeTypeName("IMFCollection **")] IMFCollection** ppAvailableTypes);

        [DllImport("mf", EntryPoint = "MFCreateTranscodeSinkActivate", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateTranscodeSinkActivate([NativeTypeName("IMFActivate **")] IMFActivate** ppActivate);

        [DllImport("mfplat", EntryPoint = "MFCreateTrackedSample", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateTrackedSample([NativeTypeName("IMFTrackedSample **")] IMFTrackedSample** ppMFSample);

        [DllImport("mfplat", EntryPoint = "MFCreateMFByteStreamOnStream", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateMFByteStreamOnStream([NativeTypeName("IStream *")] IStream* pStream, [NativeTypeName("IMFByteStream **")] IMFByteStream** ppByteStream);

        [DllImport("mfplat", EntryPoint = "MFCreateStreamOnMFByteStream", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateStreamOnMFByteStream([NativeTypeName("IMFByteStream *")] IMFByteStream* pByteStream, [NativeTypeName("IStream **")] IStream** ppStream);

        [DllImport("mfplat", EntryPoint = "MFCreateMFByteStreamOnStreamEx", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateMFByteStreamOnStreamEx([NativeTypeName("IUnknown *")] IUnknown* punkStream, [NativeTypeName("IMFByteStream **")] IMFByteStream** ppByteStream);

        [DllImport("mfplat", EntryPoint = "MFCreateStreamOnMFByteStreamEx", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateStreamOnMFByteStreamEx([NativeTypeName("IMFByteStream *")] IMFByteStream* pByteStream, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppv);

        [DllImport("mfplat", EntryPoint = "MFCreateMediaTypeFromProperties", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateMediaTypeFromProperties([NativeTypeName("IUnknown *")] IUnknown* punkStream, [NativeTypeName("IMFMediaType **")] IMFMediaType** ppMediaType);

        [DllImport("mfplat", EntryPoint = "MFCreatePropertiesFromMediaType", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreatePropertiesFromMediaType([NativeTypeName("IMFMediaType *")] IMFMediaType* pMediaType, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppv);

        [DllImport("mf", EntryPoint = "MFEnumDeviceSources", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFEnumDeviceSources([NativeTypeName("IMFAttributes *")] IMFAttributes* pAttributes, [NativeTypeName("IMFActivate ***")] IMFActivate*** pppSourceActivate, [NativeTypeName("UINT32 *")] uint* pcSourceActivate);

        [DllImport("mf", EntryPoint = "MFCreateDeviceSource", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateDeviceSource([NativeTypeName("IMFAttributes *")] IMFAttributes* pAttributes, [NativeTypeName("IMFMediaSource **")] IMFMediaSource** ppSource);

        [DllImport("mf", EntryPoint = "MFCreateDeviceSourceActivate", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateDeviceSourceActivate([NativeTypeName("IMFAttributes *")] IMFAttributes* pAttributes, [NativeTypeName("IMFActivate **")] IMFActivate** ppActivate);

        [DllImport("mf", EntryPoint = "MFCreateProtectedEnvironmentAccess", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateProtectedEnvironmentAccess([NativeTypeName("IMFProtectedEnvironmentAccess **")] IMFProtectedEnvironmentAccess** ppAccess);

        [DllImport("mf", EntryPoint = "MFLoadSignedLibrary", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFLoadSignedLibrary([NativeTypeName("LPCWSTR")] ushort* pszName, [NativeTypeName("IMFSignedLibrary **")] IMFSignedLibrary** ppLib);

        [DllImport("mf", EntryPoint = "MFGetSystemId", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFGetSystemId([NativeTypeName("IMFSystemId **")] IMFSystemId** ppId);

        [DllImport("mf", EntryPoint = "MFGetLocalId", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFGetLocalId([NativeTypeName("const BYTE *")] byte* verifier, [NativeTypeName("UINT32")] uint size, [NativeTypeName("LPWSTR *")] ushort** id);

        [DllImport("mfplat", EntryPoint = "MFCreateContentProtectionDevice", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateContentProtectionDevice([NativeTypeName("const GUID &")] Guid* ProtectionSystemId, [NativeTypeName("IMFContentProtectionDevice **")] IMFContentProtectionDevice** ContentProtectionDevice);

        [DllImport("mfplat", EntryPoint = "MFIsContentProtectionDeviceSupported", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFIsContentProtectionDeviceSupported([NativeTypeName("const GUID &")] Guid* ProtectionSystemId, [NativeTypeName("BOOL *")] int* isSupported);

        [DllImport("mfplat", EntryPoint = "MFCreateContentDecryptorContext", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateContentDecryptorContext([NativeTypeName("const GUID &")] Guid* guidMediaProtectionSystemId, [NativeTypeName("IMFDXGIDeviceManager *")] IMFDXGIDeviceManager* pD3DManager, [NativeTypeName("IMFContentProtectionDevice *")] IMFContentProtectionDevice* pContentProtectionDevice, [NativeTypeName("IMFContentDecryptorContext **")] IMFContentDecryptorContext** ppContentDecryptorContext);

        [DllImport("mf", EntryPoint = "MFCreateSensorGroup", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateSensorGroup([NativeTypeName("LPCWSTR")] ushort* SensorGroupSymbolicLink, [NativeTypeName("IMFSensorGroup **")] IMFSensorGroup** ppSensorGroup);

        [DllImport("mf", EntryPoint = "MFCreateSensorStream", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateSensorStream([NativeTypeName("DWORD")] uint StreamId, [NativeTypeName("IMFAttributes *")] IMFAttributes* pAttributes, [NativeTypeName("IMFCollection *")] IMFCollection* pMediaTypeCollection, [NativeTypeName("IMFSensorStream **")] IMFSensorStream** ppStream);

        [DllImport("mfsensorgroup", EntryPoint = "MFCreateSensorProfile", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateSensorProfile([NativeTypeName("const GUID &")] Guid* ProfileType, [NativeTypeName("UINT32")] uint ProfileIndex, [NativeTypeName("LPCWSTR")] ushort* Constraints, [NativeTypeName("IMFSensorProfile **")] IMFSensorProfile** ppProfile);

        [DllImport("mfsensorgroup", EntryPoint = "MFCreateSensorProfileCollection", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateSensorProfileCollection([NativeTypeName("IMFSensorProfileCollection **")] IMFSensorProfileCollection** ppSensorProfile);

        [DllImport("mfsensorgroup", EntryPoint = "MFCreateSensorActivityMonitor", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateSensorActivityMonitor([NativeTypeName("IMFSensorActivitiesReportCallback *")] IMFSensorActivitiesReportCallback* pCallback, [NativeTypeName("IMFSensorActivityMonitor **")] IMFSensorActivityMonitor** ppActivityMonitor);

        [DllImport("mf", EntryPoint = "MFCreateExtendedCameraIntrinsics", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateExtendedCameraIntrinsics([NativeTypeName("IMFExtendedCameraIntrinsics **")] IMFExtendedCameraIntrinsics** ppExtendedCameraIntrinsics);

        [DllImport("mf", EntryPoint = "MFCreateExtendedCameraIntrinsicModel", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateExtendedCameraIntrinsicModel([NativeTypeName("const MFCameraIntrinsic_DistortionModelType")] MFCameraIntrinsic_DistortionModelType distortionModelType, [NativeTypeName("IMFExtendedCameraIntrinsicModel **")] IMFExtendedCameraIntrinsicModel** ppExtendedCameraIntrinsicModel);

        [DllImport("mf", EntryPoint = "MFCreateRelativePanelWatcher", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateRelativePanelWatcher([NativeTypeName("PCWSTR")] ushort* videoDeviceId, [NativeTypeName("PCWSTR")] ushort* displayMonitorDeviceId, [NativeTypeName("IMFRelativePanelWatcher **")] IMFRelativePanelWatcher** ppRelativePanelWatcher);

        [DllImport("mf", EntryPoint = "BSTR_UserSize64", ExactSpelling = true)]
        [return: NativeTypeName("unsigned long")]
        public static extern uint BSTR_UserSize64([NativeTypeName("unsigned long *")] uint* param0, [NativeTypeName("unsigned long")] uint param1, [NativeTypeName("BSTR *")] ushort** param2);

        [DllImport("mf", EntryPoint = "BSTR_UserMarshal64", ExactSpelling = true)]
        [return: NativeTypeName("unsigned char *")]
        public static extern byte* BSTR_UserMarshal64([NativeTypeName("unsigned long *")] uint* param0, [NativeTypeName("unsigned char *")] byte* param1, [NativeTypeName("BSTR *")] ushort** param2);

        [DllImport("mf", EntryPoint = "BSTR_UserUnmarshal64", ExactSpelling = true)]
        [return: NativeTypeName("unsigned char *")]
        public static extern byte* BSTR_UserUnmarshal64([NativeTypeName("unsigned long *")] uint* param0, [NativeTypeName("unsigned char *")] byte* param1, [NativeTypeName("BSTR *")] ushort** param2);

        [DllImport("mf", EntryPoint = "BSTR_UserFree64", ExactSpelling = true)]
        public static extern void BSTR_UserFree64([NativeTypeName("unsigned long *")] uint* param0, [NativeTypeName("BSTR *")] ushort** param1);

        [DllImport("mf", EntryPoint = "LPSAFEARRAY_UserSize64", ExactSpelling = true)]
        [return: NativeTypeName("unsigned long")]
        public static extern uint LPSAFEARRAY_UserSize64([NativeTypeName("unsigned long *")] uint* param0, [NativeTypeName("unsigned long")] uint param1, [NativeTypeName("LPSAFEARRAY *")] SAFEARRAY** param2);

        [DllImport("mf", EntryPoint = "LPSAFEARRAY_UserMarshal64", ExactSpelling = true)]
        [return: NativeTypeName("unsigned char *")]
        public static extern byte* LPSAFEARRAY_UserMarshal64([NativeTypeName("unsigned long *")] uint* param0, [NativeTypeName("unsigned char *")] byte* param1, [NativeTypeName("LPSAFEARRAY *")] SAFEARRAY** param2);

        [DllImport("mf", EntryPoint = "LPSAFEARRAY_UserUnmarshal64", ExactSpelling = true)]
        [return: NativeTypeName("unsigned char *")]
        public static extern byte* LPSAFEARRAY_UserUnmarshal64([NativeTypeName("unsigned long *")] uint* param0, [NativeTypeName("unsigned char *")] byte* param1, [NativeTypeName("LPSAFEARRAY *")] SAFEARRAY** param2);

        [DllImport("mf", EntryPoint = "LPSAFEARRAY_UserFree64", ExactSpelling = true)]
        public static extern void LPSAFEARRAY_UserFree64([NativeTypeName("unsigned long *")] uint* param0, [NativeTypeName("LPSAFEARRAY *")] SAFEARRAY** param1);

        [DllImport("mf", EntryPoint = "IMFContentProtectionManager_EndEnableContent_Proxy", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int IMFContentProtectionManager_EndEnableContent_Proxy([NativeTypeName("IMFContentProtectionManager *")] IMFContentProtectionManager* This, [NativeTypeName("IMFAsyncResult *")] IMFAsyncResult* pResult);
    }
}
