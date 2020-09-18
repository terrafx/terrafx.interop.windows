// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct WS_XML_ELEMENT_NODE
    {
        public WS_XML_NODE node;

        [NativeTypeName("WS_XML_STRING *")]
        public WS_XML_STRING* prefix;

        [NativeTypeName("WS_XML_STRING *")]
        public WS_XML_STRING* localName;

        [NativeTypeName("WS_XML_STRING *")]
        public WS_XML_STRING* ns;

        [NativeTypeName("ULONG")]
        public uint attributeCount;

        [NativeTypeName("WS_XML_ATTRIBUTE **")]
        public WS_XML_ATTRIBUTE** attributes;

        [NativeTypeName("BOOL")]
        public int isEmpty;
    }
}
