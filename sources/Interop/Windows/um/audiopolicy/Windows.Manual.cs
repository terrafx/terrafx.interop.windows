// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mmdeviceapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        public static readonly Guid IID_IAudioSessionControl = new Guid(0xF4B1A599, 0x7266, 0x4319, 0xA8, 0xCA, 0xE7, 0x0A, 0xCB, 0x11, 0xE8, 0xCD);
    
        public static readonly Guid IID_IAudioSessionControl2 = new Guid(0xBFB7FF88, 0x7239, 0x4FC9, 0x8F, 0xA2, 0x07, 0xC9, 0x50, 0xBE, 0x9C, 0x6D);

        public static readonly Guid IID_IAudioSessionEnumerator = new Guid(0xE2F5BB11, 0x0570, 0x40CA, 0xAC, 0xDD, 0x3A, 0xA0, 0x12, 0x77, 0xDE, 0xE8);

        public static readonly Guid IID_IAudioSessionEvents = new Guid(0x24918ACC, 0x64B3, 0x37C1, 0x8C, 0xA9, 0x74, 0xA6, 0x6E, 0x99, 0x57, 0xA8);

        public static readonly Guid IID_IAudioSessionManager = new Guid(0xBFA971F1, 0x4D5E, 0x40BB, 0x93, 0x5E, 0x96, 0x70, 0x39, 0xBF, 0xBE, 0xE4);

        public static readonly Guid IID_IAudioSessionManager2 = new Guid(0x77AA99A0, 0x1BD6, 0x484F, 0x8B, 0xC7, 0x2C, 0x65, 0x4C, 0x9A, 0x9B, 0x6F);

        public static readonly Guid IID_IAudioSessionNotification = new Guid(0x641DD20B, 0x4D41, 0x49CC, 0xAB, 0xA3, 0x17, 0x4B, 0x94, 0x77, 0xBB, 0x08);

        public static readonly Guid IID_IAudioVolumeDuckNotification = new Guid(0xC3B284D4, 0x6D39, 0x4359, 0xB3, 0xCF, 0xB5, 0x6D, 0xDB, 0x3B, 0xB3, 0x9C); 
    }
}
