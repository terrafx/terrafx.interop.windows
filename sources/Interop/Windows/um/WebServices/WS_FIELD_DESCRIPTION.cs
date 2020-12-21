// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct WS_FIELD_DESCRIPTION
    {
        public WS_FIELD_MAPPING mapping;

        [NativeTypeName("WS_XML_STRING *")]
        public WS_XML_STRING* localName;

        [NativeTypeName("WS_XML_STRING *")]
        public WS_XML_STRING* ns;

        public WS_TYPE type;

        [NativeTypeName("void *")]
        public void* typeDescription;

        [NativeTypeName("ULONG")]
        public uint offset;

        [NativeTypeName("ULONG")]
        public uint options;

        [NativeTypeName("WS_DEFAULT_VALUE *")]
        public WS_DEFAULT_VALUE* defaultValue;

        [NativeTypeName("ULONG")]
        public uint countOffset;

        [NativeTypeName("WS_XML_STRING *")]
        public WS_XML_STRING* itemLocalName;

        [NativeTypeName("WS_XML_STRING *")]
        public WS_XML_STRING* itemNs;

        [NativeTypeName("WS_ITEM_RANGE *")]
        public WS_ITEM_RANGE* itemRange;
    }
}
