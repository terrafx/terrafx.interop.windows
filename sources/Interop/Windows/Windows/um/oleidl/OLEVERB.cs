// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/oleidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows
{
    public unsafe partial struct OLEVERB
    {
        [NativeTypeName("LONG")]
        public int lVerb;

        [NativeTypeName("LPOLESTR")]
        public ushort* lpszVerbName;

        [NativeTypeName("DWORD")]
        public uint fuFlags;

        [NativeTypeName("DWORD")]
        public uint grfAttribs;
    }
}
