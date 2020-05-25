// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodecsdk.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [DllImport("WindowsCodecs", EntryPoint = "WICMatchMetadataContent", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WICMatchMetadataContent([NativeTypeName("const GUID &")] Guid* guidContainerFormat, [NativeTypeName("const GUID *")] Guid* pguidVendor, [NativeTypeName("IStream *")] IStream* pIStream, [NativeTypeName("GUID *")] Guid* pguidMetadataFormat);

        [DllImport("WindowsCodecs", EntryPoint = "WICSerializeMetadataContent", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WICSerializeMetadataContent([NativeTypeName("const GUID &")] Guid* guidContainerFormat, [NativeTypeName("IWICMetadataWriter *")] IWICMetadataWriter* pIWriter, [NativeTypeName("DWORD")] uint dwPersistOptions, [NativeTypeName("IStream *")] IStream* pIStream);

        [DllImport("WindowsCodecs", EntryPoint = "WICGetMetadataContentSize", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WICGetMetadataContentSize([NativeTypeName("const GUID &")] Guid* guidContainerFormat, [NativeTypeName("IWICMetadataWriter *")] IWICMetadataWriter* pIWriter, [NativeTypeName("ULARGE_INTEGER *")] ULARGE_INTEGER* pcbSize);
    }
}
