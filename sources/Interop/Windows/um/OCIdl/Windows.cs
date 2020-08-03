// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/OCIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public static partial class Windows
    {
        [NativeTypeName("#define MULTICLASSINFO_GETTYPEINFO 0x00000001")]
        public const int MULTICLASSINFO_GETTYPEINFO = 0x00000001;

        [NativeTypeName("#define MULTICLASSINFO_GETNUMRESERVEDDISPIDS 0x00000002")]
        public const int MULTICLASSINFO_GETNUMRESERVEDDISPIDS = 0x00000002;

        [NativeTypeName("#define MULTICLASSINFO_GETIIDPRIMARY 0x00000004")]
        public const int MULTICLASSINFO_GETIIDPRIMARY = 0x00000004;

        [NativeTypeName("#define MULTICLASSINFO_GETIIDSOURCE 0x00000008")]
        public const int MULTICLASSINFO_GETIIDSOURCE = 0x00000008;

        [NativeTypeName("#define TIFLAGS_EXTENDDISPATCHONLY 0x00000001")]
        public const int TIFLAGS_EXTENDDISPATCHONLY = 0x00000001;

        [NativeTypeName("#define SID_SOleUndoManager IID_IOleUndoManager")]
        public static readonly Guid SID_SOleUndoManager = IID_IOleUndoManager;
    }
}
