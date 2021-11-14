// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/tcpestats.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows
{
    public partial struct TCP_ESTATS_SEND_BUFF_ROD_v0
    {
        [NativeTypeName("SIZE_T")]
        public nuint CurRetxQueue;

        [NativeTypeName("SIZE_T")]
        public nuint MaxRetxQueue;

        [NativeTypeName("SIZE_T")]
        public nuint CurAppWQueue;

        [NativeTypeName("SIZE_T")]
        public nuint MaxAppWQueue;
    }
}
