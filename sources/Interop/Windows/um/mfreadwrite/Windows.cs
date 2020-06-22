// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfreadwrite.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [DllImport("mfreadwrite", EntryPoint = "MFCreateSourceReaderFromURL", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateSourceReaderFromURL([NativeTypeName("LPCWSTR")] ushort* pwszURL, [NativeTypeName("IMFAttributes *")] IMFAttributes* pAttributes, [NativeTypeName("IMFSourceReader **")] IMFSourceReader** ppSourceReader);

        [DllImport("mfreadwrite", EntryPoint = "MFCreateSourceReaderFromByteStream", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateSourceReaderFromByteStream([NativeTypeName("IMFByteStream *")] IMFByteStream* pByteStream, [NativeTypeName("IMFAttributes *")] IMFAttributes* pAttributes, [NativeTypeName("IMFSourceReader **")] IMFSourceReader** ppSourceReader);

        [DllImport("mfreadwrite", EntryPoint = "MFCreateSourceReaderFromMediaSource", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateSourceReaderFromMediaSource([NativeTypeName("IMFMediaSource *")] IMFMediaSource* pMediaSource, [NativeTypeName("IMFAttributes *")] IMFAttributes* pAttributes, [NativeTypeName("IMFSourceReader **")] IMFSourceReader** ppSourceReader);

        [DllImport("mfreadwrite", EntryPoint = "MFCreateSinkWriterFromURL", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateSinkWriterFromURL([NativeTypeName("LPCWSTR")] ushort* pwszOutputURL, [NativeTypeName("IMFByteStream *")] IMFByteStream* pByteStream, [NativeTypeName("IMFAttributes *")] IMFAttributes* pAttributes, [NativeTypeName("IMFSinkWriter **")] IMFSinkWriter** ppSinkWriter);

        [DllImport("mfreadwrite", EntryPoint = "MFCreateSinkWriterFromMediaSink", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFCreateSinkWriterFromMediaSink([NativeTypeName("IMFMediaSink *")] IMFMediaSink* pMediaSink, [NativeTypeName("IMFAttributes *")] IMFAttributes* pAttributes, [NativeTypeName("IMFSinkWriter **")] IMFSinkWriter** ppSinkWriter);
    }
}
