// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/InteractionContext.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct INTERACTION_CONTEXT_OUTPUT
    {
        public INTERACTION_ID interactionId;

        public INTERACTION_FLAGS interactionFlags;

        [NativeTypeName("POINTER_INPUT_TYPE")]
        public uint inputType;

        public float x;

        public float y;

        [NativeTypeName("union (anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/InteractionContext.h:234:5)")]
        public _arguments_e__Union arguments;

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _arguments_e__Union
        {
            [FieldOffset(0)]
            public INTERACTION_ARGUMENTS_MANIPULATION manipulation;

            [FieldOffset(0)]
            public INTERACTION_ARGUMENTS_TAP tap;

            [FieldOffset(0)]
            public INTERACTION_ARGUMENTS_CROSS_SLIDE crossSlide;
        }
    }
}
