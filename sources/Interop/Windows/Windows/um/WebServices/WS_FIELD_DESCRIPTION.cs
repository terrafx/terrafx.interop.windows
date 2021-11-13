// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows
{
    public unsafe partial struct WS_FIELD_DESCRIPTION
    {
        public WS_FIELD_MAPPING mapping;

        public WS_XML_STRING* localName;

        public WS_XML_STRING* ns;

        public WS_TYPE type;

        public void* typeDescription;

        [NativeTypeName("ULONG")]
        public uint offset;

        [NativeTypeName("ULONG")]
        public uint options;

        public WS_DEFAULT_VALUE* defaultValue;

        [NativeTypeName("ULONG")]
        public uint countOffset;

        public WS_XML_STRING* itemLocalName;

        public WS_XML_STRING* itemNs;

        public WS_ITEM_RANGE* itemRange;
    }
}
