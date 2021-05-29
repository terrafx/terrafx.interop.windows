// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msctf.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public partial struct TF_PERSISTENT_PROPERTY_HEADER_ACP
    {
        [NativeTypeName("GUID")]
        public Guid guidType;

        [NativeTypeName("LONG")]
        public int ichStart;

        [NativeTypeName("LONG")]
        public int cch;

        [NativeTypeName("ULONG")]
        public uint cb;

        [NativeTypeName("DWORD")]
        public uint dwPrivate;

        [NativeTypeName("CLSID")]
        public Guid clsidTIP;
    }
}
