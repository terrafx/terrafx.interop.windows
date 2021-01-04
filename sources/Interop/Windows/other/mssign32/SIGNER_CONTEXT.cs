// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from https://docs.microsoft.com/en-us/windows/win32/appxpkg/how-to-programmatically-sign-a-package
// Original source is Copyright © Microsoft. All rights reserved. License information available at https://github.com/MicrosoftDocs/win32/blob/docs/LICENSE-CODE

namespace TerraFX.Interop
{
    public unsafe partial struct SIGNER_CONTEXT
    {
        [NativeTypeName("DWORD")]
        public uint cbSize;

        [NativeTypeName("DWORD")]
        public uint cbBlob;

        [NativeTypeName("BYTE *")]
        public byte* pbBlob;
    }
}