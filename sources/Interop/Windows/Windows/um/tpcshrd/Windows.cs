// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/tpcshrd.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows
{
    public static partial class Windows
    {
        [NativeTypeName("#define WM_TABLET_DEFBASE 0x02C0")]
        public const int WM_TABLET_DEFBASE = 0x02C0;

        [NativeTypeName("#define WM_TABLET_MAXOFFSET 0x20")]
        public const int WM_TABLET_MAXOFFSET = 0x20;

        [NativeTypeName("#define WM_TABLET_ADDED (WM_TABLET_DEFBASE + 8)")]
        public const int WM_TABLET_ADDED = (0x02C0 + 8);

        [NativeTypeName("#define WM_TABLET_DELETED (WM_TABLET_DEFBASE + 9)")]
        public const int WM_TABLET_DELETED = (0x02C0 + 9);

        [NativeTypeName("#define WM_TABLET_FLICK (WM_TABLET_DEFBASE + 11)")]
        public const int WM_TABLET_FLICK = (0x02C0 + 11);

        [NativeTypeName("#define WM_TABLET_QUERYSYSTEMGESTURESTATUS (WM_TABLET_DEFBASE + 12)")]
        public const int WM_TABLET_QUERYSYSTEMGESTURESTATUS = (0x02C0 + 12);

        [NativeTypeName("#define TABLET_DISABLE_PRESSANDHOLD 0x00000001")]
        public const int TABLET_DISABLE_PRESSANDHOLD = 0x00000001;

        [NativeTypeName("#define TABLET_DISABLE_PENTAPFEEDBACK 0x00000008")]
        public const int TABLET_DISABLE_PENTAPFEEDBACK = 0x00000008;

        [NativeTypeName("#define TABLET_DISABLE_PENBARRELFEEDBACK 0x00000010")]
        public const int TABLET_DISABLE_PENBARRELFEEDBACK = 0x00000010;

        [NativeTypeName("#define TABLET_DISABLE_TOUCHUIFORCEON 0x00000100")]
        public const int TABLET_DISABLE_TOUCHUIFORCEON = 0x00000100;

        [NativeTypeName("#define TABLET_DISABLE_TOUCHUIFORCEOFF 0x00000200")]
        public const int TABLET_DISABLE_TOUCHUIFORCEOFF = 0x00000200;

        [NativeTypeName("#define TABLET_DISABLE_TOUCHSWITCH 0x00008000")]
        public const int TABLET_DISABLE_TOUCHSWITCH = 0x00008000;

        [NativeTypeName("#define TABLET_DISABLE_FLICKS 0x00010000")]
        public const int TABLET_DISABLE_FLICKS = 0x00010000;

        [NativeTypeName("#define TABLET_ENABLE_FLICKSONCONTEXT 0x00020000")]
        public const int TABLET_ENABLE_FLICKSONCONTEXT = 0x00020000;

        [NativeTypeName("#define TABLET_ENABLE_FLICKLEARNINGMODE 0x00040000")]
        public const int TABLET_ENABLE_FLICKLEARNINGMODE = 0x00040000;

        [NativeTypeName("#define TABLET_DISABLE_SMOOTHSCROLLING 0x00080000")]
        public const int TABLET_DISABLE_SMOOTHSCROLLING = 0x00080000;

        [NativeTypeName("#define TABLET_DISABLE_FLICKFALLBACKKEYS 0x00100000")]
        public const int TABLET_DISABLE_FLICKFALLBACKKEYS = 0x00100000;

        [NativeTypeName("#define TABLET_ENABLE_MULTITOUCHDATA 0x01000000")]
        public const int TABLET_ENABLE_MULTITOUCHDATA = 0x01000000;

        [NativeTypeName("#define MAX_PACKET_PROPERTY_COUNT 32")]
        public const int MAX_PACKET_PROPERTY_COUNT = 32;

        [NativeTypeName("#define MAX_PACKET_BUTTON_COUNT 32")]
        public const int MAX_PACKET_BUTTON_COUNT = 32;

        [NativeTypeName("#define IP_CURSOR_DOWN 0x00000001")]
        public const int IP_CURSOR_DOWN = 0x00000001;

        [NativeTypeName("#define IP_INVERTED 0x00000002")]
        public const int IP_INVERTED = 0x00000002;

        [NativeTypeName("#define IP_MARGIN 0x00000004")]
        public const int IP_MARGIN = 0x00000004;
    }
}
