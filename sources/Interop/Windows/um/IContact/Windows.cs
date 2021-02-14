// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/IContact.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public static partial class Windows
    {
        [NativeTypeName("#define CGD_DEFAULT 0x00000000")]
        public const int CGD_DEFAULT = 0x00000000;

        [NativeTypeName("#define CGD_UNKNOWN_PROPERTY 0x00000000")]
        public const int CGD_UNKNOWN_PROPERTY = 0x00000000;

        [NativeTypeName("#define CGD_STRING_PROPERTY 0x00000001")]
        public const int CGD_STRING_PROPERTY = 0x00000001;

        [NativeTypeName("#define CGD_DATE_PROPERTY 0x00000002")]
        public const int CGD_DATE_PROPERTY = 0x00000002;

        [NativeTypeName("#define CGD_BINARY_PROPERTY 0x00000004")]
        public const int CGD_BINARY_PROPERTY = 0x00000004;

        [NativeTypeName("#define CGD_ARRAY_NODE 0x00000008")]
        public const int CGD_ARRAY_NODE = 0x00000008;

        public static readonly Guid IID_IContactManager = new Guid(0xAD553D98, 0xDEB1, 0x474A, 0x8E, 0x17, 0xFC, 0x0C, 0x20, 0x75, 0xB7, 0x38);

        public static readonly Guid IID_IContactCollection = new Guid(0xB6AFA338, 0xD779, 0x11D9, 0x8B, 0xDE, 0xF6, 0x6B, 0xAD, 0x1E, 0x3F, 0x3A);

        public static readonly Guid IID_IContactProperties = new Guid(0x70DD27DD, 0x5CBD, 0x46E8, 0xBE, 0xF0, 0x23, 0xB6, 0xB3, 0x46, 0x28, 0x8F);

        public static readonly Guid IID_IContact = new Guid(0xF941B671, 0xBDA7, 0x4F77, 0x88, 0x4A, 0xF4, 0x64, 0x62, 0xF2, 0x26, 0xA7);

        public static readonly Guid IID_IContactPropertyCollection = new Guid(0xFFD3ADF8, 0xFA64, 0x4328, 0xB1, 0xB6, 0x2E, 0x0D, 0xB5, 0x09, 0xCB, 0x3C);

        public static readonly Guid CLSID_Contact = new Guid(0x61B68808, 0x8EEE, 0x4FD1, 0xAC, 0xB8, 0x3D, 0x80, 0x4C, 0x8D, 0xB0, 0x56);

        public static readonly Guid CLSID_ContactManager = new Guid(0x7165C8AB, 0xAF88, 0x42BD, 0x86, 0xFD, 0x53, 0x10, 0xB4, 0x28, 0x5A, 0x02);
    }
}
