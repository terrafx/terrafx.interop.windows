// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/IPExport.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows
{
    public unsafe partial struct IP_OPTION_INFORMATION
    {
        [NativeTypeName("UCHAR")]
        public byte Ttl;

        [NativeTypeName("UCHAR")]
        public byte Tos;

        [NativeTypeName("UCHAR")]
        public byte Flags;

        [NativeTypeName("UCHAR")]
        public byte OptionsSize;

        [NativeTypeName("PUCHAR")]
        public byte* OptionsData;
    }
}
