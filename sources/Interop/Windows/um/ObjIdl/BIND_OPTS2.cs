// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/objidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    [NativeTypeName("struct tagBIND_OPTS2 : tagBIND_OPTS")]
    public unsafe partial struct BIND_OPTS2
    {
        public BIND_OPTS __AnonymousBase_objidl_L8984_C36;

        [NativeTypeName("DWORD")]
        public uint dwTrackFlags;

        [NativeTypeName("DWORD")]
        public uint dwClassContext;

        [NativeTypeName("LCID")]
        public uint locale;

        public COSERVERINFO* pServerInfo;
    }
}
