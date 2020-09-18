// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct WS_XML_READER_MTOM_ENCODING
    {
        public WS_XML_READER_ENCODING encoding;

        [NativeTypeName("WS_XML_READER_ENCODING *")]
        public WS_XML_READER_ENCODING* textEncoding;

        [NativeTypeName("BOOL")]
        public int readMimeHeader;

        public WS_STRING startInfo;

        public WS_STRING boundary;

        public WS_STRING startUri;
    }
}
