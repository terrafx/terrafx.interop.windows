// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct INPUT_MESSAGE_SOURCE
    {
        public INPUT_MESSAGE_DEVICE_TYPE deviceType;

        public INPUT_MESSAGE_ORIGIN_ID originId;
    }
}
