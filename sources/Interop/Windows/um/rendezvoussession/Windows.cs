// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/rendezvoussession.h and um/rendezvoussession_i.c in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public static partial class Windows
    {
        [NativeTypeName("const IID")]
        public static readonly Guid LIBID_RendezvousSessionLib = new Guid(0xEFD856A4, 0x5A85, 0x4A1B, 0xAD, 0xD5, 0x2E, 0xAD, 0xAC, 0xE6, 0xF6, 0xA2);

        [NativeTypeName("const IID")]
        public static readonly Guid IID_IRendezvousSession = new Guid(0x9BA4B1DD, 0x8B0C, 0x48B7, 0x9E, 0x7C, 0x2F, 0x25, 0x85, 0x7C, 0x8D, 0xF5);

        [NativeTypeName("const IID")]
        public static readonly Guid DIID_DRendezvousSessionEvents = new Guid(0x3FA19CF8, 0x64C4, 0x4F53, 0xAE, 0x60, 0x63, 0x5B, 0x38, 0x06, 0xEC, 0xA6);

        [NativeTypeName("const IID")]
        public static readonly Guid IID_IRendezvousApplication = new Guid(0x4F4D070B, 0xA275, 0x49FB, 0xB1, 0x0D, 0x8E, 0xC2, 0x63, 0x87, 0xB5, 0x0D);

        [NativeTypeName("const CLSID")]
        public static readonly Guid CLSID_RendezvousApplication = new Guid(0x0B7E019A, 0xB5DE, 0x47fa, 0x89, 0x66, 0x90, 0x82, 0xF8, 0x2F, 0xB1, 0x92);

        [NativeTypeName("#define DISPID_EVENT_ON_STATE_CHANGED ( 5 )")]
        public const int DISPID_EVENT_ON_STATE_CHANGED = (5);

        [NativeTypeName("#define DISPID_EVENT_ON_TERMINATION ( 6 )")]
        public const int DISPID_EVENT_ON_TERMINATION = (6);

        [NativeTypeName("#define DISPID_EVENT_ON_CONTEXT_DATA ( 7 )")]
        public const int DISPID_EVENT_ON_CONTEXT_DATA = (7);

        [NativeTypeName("#define DISPID_EVENT_ON_SEND_ERROR ( 8 )")]
        public const int DISPID_EVENT_ON_SEND_ERROR = (8);
    }
}
