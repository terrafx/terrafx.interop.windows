// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfreadwrite.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [NativeTypeName("const IID")]
        public static readonly Guid CLSID_MFReadWriteClassFactory = new Guid(0x48e2ed0f, 0x98c2, 0x4a37, 0xbe, 0xd5, 0x16, 0x63, 0x12, 0xdd, 0xd8, 0x3f);

        [NativeTypeName("const IID")]
        public static readonly Guid CLSID_MFSourceReader = new Guid(0x1777133c, 0x0881, 0x411b, 0xa5, 0x77, 0xad, 0x54, 0x5f, 0x07, 0x14, 0xc4);

        [DllImport("mfreadwrite", EntryPoint = "MFCreateSourceReaderFromURL", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateSourceReaderFromURL([NativeTypeName("LPCWSTR")] ushort* pwszURL, [NativeTypeName("IMFAttributes *")] IMFAttributes* pAttributes, [NativeTypeName("IMFSourceReader **")] IMFSourceReader** ppSourceReader);

        [DllImport("mfreadwrite", EntryPoint = "MFCreateSourceReaderFromByteStream", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateSourceReaderFromByteStream([NativeTypeName("IMFByteStream *")] IMFByteStream* pByteStream, [NativeTypeName("IMFAttributes *")] IMFAttributes* pAttributes, [NativeTypeName("IMFSourceReader **")] IMFSourceReader** ppSourceReader);

        [DllImport("mfreadwrite", EntryPoint = "MFCreateSourceReaderFromMediaSource", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateSourceReaderFromMediaSource([NativeTypeName("IMFMediaSource *")] IMFMediaSource* pMediaSource, [NativeTypeName("IMFAttributes *")] IMFAttributes* pAttributes, [NativeTypeName("IMFSourceReader **")] IMFSourceReader** ppSourceReader);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_SOURCE_READER_ASYNC_CALLBACK = new Guid(0x1e3dbeac, 0xbb43, 0x4c35, 0xb5, 0x07, 0xcd, 0x64, 0x44, 0x64, 0xc9, 0x65);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_SOURCE_READER_D3D_MANAGER = new Guid(0xec822da2, 0xe1e9, 0x4b29, 0xa0, 0xd8, 0x56, 0x3c, 0x71, 0x9f, 0x52, 0x69);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_SOURCE_READER_DISABLE_DXVA = new Guid(0xaa456cfd, 0x3943, 0x4a1e, 0xa7, 0x7d, 0x18, 0x38, 0xc0, 0xea, 0x2e, 0x35);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_SOURCE_READER_MEDIASOURCE_CONFIG = new Guid(0x9085abeb, 0x0354, 0x48f9, 0xab, 0xb5, 0x20, 0x0d, 0xf8, 0x38, 0xc6, 0x8e);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_SOURCE_READER_MEDIASOURCE_CHARACTERISTICS = new Guid(0x6d23f5c8, 0xc5d7, 0x4a9b, 0x99, 0x71, 0x5d, 0x11, 0xf8, 0xbc, 0xa8, 0x80);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_SOURCE_READER_ENABLE_VIDEO_PROCESSING = new Guid(0xfb394f3d, 0xccf1, 0x42ee, 0xbb, 0xb3, 0xf9, 0xb8, 0x45, 0xd5, 0x68, 0x1d);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_SOURCE_READER_ENABLE_ADVANCED_VIDEO_PROCESSING = new Guid(0xf81da2c, 0xb537, 0x4672, 0xa8, 0xb2, 0xa6, 0x81, 0xb1, 0x73, 0x7, 0xa3);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_SOURCE_READER_DISABLE_CAMERA_PLUGINS = new Guid(0x9d3365dd, 0x58f, 0x4cfb, 0x9f, 0x97, 0xb3, 0x14, 0xcc, 0x99, 0xc8, 0xad);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_SOURCE_READER_DISCONNECT_MEDIASOURCE_ON_SHUTDOWN = new Guid(0x56b67165, 0x219e, 0x456d, 0xa2, 0x2e, 0x2d, 0x30, 0x04, 0xc7, 0xfe, 0x56);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_SOURCE_READER_ENABLE_TRANSCODE_ONLY_TRANSFORMS = new Guid(0xdfd4f008, 0xb5fd, 0x4e78, 0xae, 0x44, 0x62, 0xa1, 0xe6, 0x7b, 0xbe, 0x27);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_SOURCE_READER_D3D11_BIND_FLAGS = new Guid(0x33f3197b, 0xf73a, 0x4e14, 0x8d, 0x85, 0xe, 0x4c, 0x43, 0x68, 0x78, 0x8d);

        [NativeTypeName("const IID")]
        public static readonly Guid CLSID_MFSinkWriter = new Guid(0xa3bbfb17, 0x8273, 0x4e52, 0x9e, 0x0e, 0x97, 0x39, 0xdc, 0x88, 0x79, 0x90);

        [DllImport("mfreadwrite", EntryPoint = "MFCreateSinkWriterFromURL", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateSinkWriterFromURL([NativeTypeName("LPCWSTR")] ushort* pwszOutputURL, [NativeTypeName("IMFByteStream *")] IMFByteStream* pByteStream, [NativeTypeName("IMFAttributes *")] IMFAttributes* pAttributes, [NativeTypeName("IMFSinkWriter **")] IMFSinkWriter** ppSinkWriter);

        [DllImport("mfreadwrite", EntryPoint = "MFCreateSinkWriterFromMediaSink", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateSinkWriterFromMediaSink([NativeTypeName("IMFMediaSink *")] IMFMediaSink* pMediaSink, [NativeTypeName("IMFAttributes *")] IMFAttributes* pAttributes, [NativeTypeName("IMFSinkWriter **")] IMFSinkWriter** ppSinkWriter);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_SINK_WRITER_ASYNC_CALLBACK = new Guid(0x48cb183e, 0x7b0b, 0x46f4, 0x82, 0x2e, 0x5e, 0x1d, 0x2d, 0xda, 0x43, 0x54);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_SINK_WRITER_DISABLE_THROTTLING = new Guid(0x08b845d8, 0x2b74, 0x4afe, 0x9d, 0x53, 0xbe, 0x16, 0xd2, 0xd5, 0xae, 0x4f);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_SINK_WRITER_D3D_MANAGER = new Guid(0xec822da2, 0xe1e9, 0x4b29, 0xa0, 0xd8, 0x56, 0x3c, 0x71, 0x9f, 0x52, 0x69);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_SINK_WRITER_ENCODER_CONFIG = new Guid(0xad91cd04, 0xa7cc, 0x4ac7, 0x99, 0xb6, 0xa5, 0x7b, 0x9a, 0x4a, 0x7c, 0x70);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_READWRITE_DISABLE_CONVERTERS = new Guid(0x98d5b065, 0x1374, 0x4847, 0x8d, 0x5d, 0x31, 0x52, 0x0f, 0xee, 0x71, 0x56);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_READWRITE_ENABLE_HARDWARE_TRANSFORMS = new Guid(0xa634a91c, 0x822b, 0x41b9, 0xa4, 0x94, 0x4d, 0xe4, 0x64, 0x36, 0x12, 0xb0);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_READWRITE_MMCSS_CLASS = new Guid(0x39384300, 0xd0eb, 0x40b1, 0x87, 0xa0, 0x33, 0x18, 0x87, 0x1b, 0x5a, 0x53);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_READWRITE_MMCSS_PRIORITY = new Guid(0x43ad19ce, 0xf33f, 0x4ba9, 0xa5, 0x80, 0xe4, 0xcd, 0x12, 0xf2, 0xd1, 0x44);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_READWRITE_MMCSS_CLASS_AUDIO = new Guid(0x430847da, 0x0890, 0x4b0e, 0x93, 0x8c, 0x05, 0x43, 0x32, 0xc5, 0x47, 0xe1);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_READWRITE_MMCSS_PRIORITY_AUDIO = new Guid(0x273db885, 0x2de2, 0x4db2, 0xa6, 0xa7, 0xfd, 0xb6, 0x6f, 0xb4, 0x0b, 0x61);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_READWRITE_D3D_OPTIONAL = new Guid(0x216479d9, 0x3071, 0x42ca, 0xbb, 0x6c, 0x4c, 0x22, 0x10, 0x2e, 0x1d, 0x18);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_MEDIASINK_AUTOFINALIZE_SUPPORTED = new Guid(0x48c131be, 0x135a, 0x41cb, 0x82, 0x90, 0x3, 0x65, 0x25, 0x9, 0xc9, 0x99);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_MEDIASINK_ENABLE_AUTOFINALIZE = new Guid(0x34014265, 0xcb7e, 0x4cde, 0xac, 0x7c, 0xef, 0xfd, 0x3b, 0x3c, 0x25, 0x30);

        [NativeTypeName("const IID")]
        public static readonly Guid MF_READWRITE_ENABLE_AUTOFINALIZE = new Guid(0xdd7ca129, 0x8cd1, 0x4dc5, 0x9d, 0xde, 0xce, 0x16, 0x86, 0x75, 0xde, 0x61);
    }
}
