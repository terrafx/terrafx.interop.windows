// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct WS_SERVICE_METADATA
    {
        [NativeTypeName("ULONG")]
        public uint documentCount;

        [NativeTypeName("WS_SERVICE_METADATA_DOCUMENT **")]
        public WS_SERVICE_METADATA_DOCUMENT** documents;

        [NativeTypeName("WS_XML_STRING *")]
        public WS_XML_STRING* serviceName;

        [NativeTypeName("WS_XML_STRING *")]
        public WS_XML_STRING* serviceNs;
    }
}
