// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum MFNETSOURCE_PROTOCOL_TYPE
    {
        MFNETSOURCE_UNDEFINED = 0,
        MFNETSOURCE_HTTP = 0x1,
        MFNETSOURCE_RTSP = 0x2,
        MFNETSOURCE_FILE = 0x3,
        MFNETSOURCE_MULTICAST = 0x4,
    }
}
