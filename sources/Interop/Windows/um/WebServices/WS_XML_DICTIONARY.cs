// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct WS_XML_DICTIONARY
    {
        [NativeTypeName("GUID")]
        public Guid guid;

        [NativeTypeName("WS_XML_STRING *")]
        public WS_XML_STRING* strings;

        [NativeTypeName("ULONG")]
        public uint stringCount;

        [NativeTypeName("BOOL")]
        public int isConst;
    }
}
