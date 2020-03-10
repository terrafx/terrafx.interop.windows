// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Xinput.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class XInput
    {
        public const string XINPUT_DLL_W = "xinput1_4.dll";

        public const string XINPUT_DLL = XINPUT_DLL_W;

        public const byte XINPUT_DEVTYPE_GAMEPAD = 0x01;

        public const byte XINPUT_DEVSUBTYPE_GAMEPAD = 0x01;
        public const byte XINPUT_DEVSUBTYPE_UNKNOWN = 0x00;
        public const byte XINPUT_DEVSUBTYPE_WHEEL = 0x02;
        public const byte XINPUT_DEVSUBTYPE_ARCADE_STICK = 0x03;
        public const byte XINPUT_DEVSUBTYPE_FLIGHT_STICK = 0x04;
        public const byte XINPUT_DEVSUBTYPE_DANCE_PAD = 0x05;
        public const byte XINPUT_DEVSUBTYPE_GUITAR = 0x06;
        public const byte XINPUT_DEVSUBTYPE_GUITAR_ALTERNATE = 0x07;
        public const byte XINPUT_DEVSUBTYPE_DRUM_KIT = 0x08;
        public const byte XINPUT_DEVSUBTYPE_GUITAR_BASS = 0x0B;
        public const byte XINPUT_DEVSUBTYPE_ARCADE_PAD = 0x13;

        public const ushort XINPUT_CAPS_VOICE_SUPPORTED = 0x0004;
        public const ushort XINPUT_CAPS_FFB_SUPPORTED = 0x0001;
        public const ushort XINPUT_CAPS_WIRELESS = 0x0002;
        public const ushort XINPUT_CAPS_PMD_SUPPORTED = 0x0008;
        public const ushort XINPUT_CAPS_NO_NAVIGATION = 0x0010;

        public const ushort XINPUT_GAMEPAD_DPAD_UP = 0x0001;
        public const ushort XINPUT_GAMEPAD_DPAD_DOWN = 0x0002;
        public const ushort XINPUT_GAMEPAD_DPAD_LEFT = 0x0004;
        public const ushort XINPUT_GAMEPAD_DPAD_RIGHT = 0x0008;
        public const ushort XINPUT_GAMEPAD_START = 0x0010;
        public const ushort XINPUT_GAMEPAD_BACK = 0x0020;
        public const ushort XINPUT_GAMEPAD_LEFT_THUMB = 0x0040;
        public const ushort XINPUT_GAMEPAD_RIGHT_THUMB = 0x0080;
        public const ushort XINPUT_GAMEPAD_LEFT_SHOULDER = 0x0100;
        public const ushort XINPUT_GAMEPAD_RIGHT_SHOULDER = 0x0200;
        public const ushort XINPUT_GAMEPAD_A = 0x1000;
        public const ushort XINPUT_GAMEPAD_B = 0x2000;
        public const ushort XINPUT_GAMEPAD_X = 0x4000;
        public const ushort XINPUT_GAMEPAD_Y = 0x8000;

        public const short XINPUT_GAMEPAD_LEFT_THUMB_DEADZONE = 7849;
        public const short XINPUT_GAMEPAD_RIGHT_THUMB_DEADZONE = 8689;

        public const byte XINPUT_GAMEPAD_TRIGGER_THRESHOLD = 30;

        public const uint XINPUT_FLAG_GAMEPAD = 0x00000001;

        public const byte BATTERY_DEVTYPE_GAMEPAD = 0x00;
        public const byte BATTERY_DEVTYPE_HEADSET = 0x01;

        public const byte BATTERY_TYPE_DISCONNECTED = 0x00;
        public const byte BATTERY_TYPE_WIRED = 0x01;
        public const byte BATTERY_TYPE_ALKALINE = 0x02;
        public const byte BATTERY_TYPE_NIMH = 0x03;
        public const byte BATTERY_TYPE_UNKNOWN = 0xFF;

        public const byte BATTERY_LEVEL_EMPTY = 0x00;
        public const byte BATTERY_LEVEL_LOW = 0x01;
        public const byte BATTERY_LEVEL_MEDIUM = 0x02;
        public const byte BATTERY_LEVEL_FULL = 0x03;

        public const uint XUSER_MAX_COUNT = 4;
        public const uint XUSER_INDEX_ANY = 0x000000FF;

        public const ushort VK_PAD_A = 0x5800;
        public const ushort VK_PAD_B = 0x5801;
        public const ushort VK_PAD_X = 0x5802;
        public const ushort VK_PAD_Y = 0x5803;
        public const ushort VK_PAD_RSHOULDER = 0x5804;
        public const ushort VK_PAD_LSHOULDER = 0x5805;
        public const ushort VK_PAD_LTRIGGER = 0x5806;
        public const ushort VK_PAD_RTRIGGER = 0x5807;

        public const ushort VK_PAD_DPAD_UP = 0x5810;
        public const ushort VK_PAD_DPAD_DOWN = 0x5811;
        public const ushort VK_PAD_DPAD_LEFT = 0x5812;
        public const ushort VK_PAD_DPAD_RIGHT = 0x5813;
        public const ushort VK_PAD_START = 0x5814;
        public const ushort VK_PAD_BACK = 0x5815;
        public const ushort VK_PAD_LTHUMB_PRESS = 0x5816;
        public const ushort VK_PAD_RTHUMB_PRESS = 0x5817;

        public const ushort VK_PAD_LTHUMB_UP = 0x5820;
        public const ushort VK_PAD_LTHUMB_DOWN = 0x5821;
        public const ushort VK_PAD_LTHUMB_RIGHT = 0x5822;
        public const ushort VK_PAD_LTHUMB_LEFT = 0x5823;
        public const ushort VK_PAD_LTHUMB_UPLEFT = 0x5824;
        public const ushort VK_PAD_LTHUMB_UPRIGHT = 0x5825;
        public const ushort VK_PAD_LTHUMB_DOWNRIGHT = 0x5826;
        public const ushort VK_PAD_LTHUMB_DOWNLEFT = 0x5827;

        public const ushort VK_PAD_RTHUMB_UP = 0x5830;
        public const ushort VK_PAD_RTHUMB_DOWN = 0x5831;
        public const ushort VK_PAD_RTHUMB_RIGHT = 0x5832;
        public const ushort VK_PAD_RTHUMB_LEFT = 0x5833;
        public const ushort VK_PAD_RTHUMB_UPLEFT = 0x5834;
        public const ushort VK_PAD_RTHUMB_UPRIGHT = 0x5835;
        public const ushort VK_PAD_RTHUMB_DOWNRIGHT = 0x5836;
        public const ushort VK_PAD_RTHUMB_DOWNLEFT = 0x5837;

        public const ushort XINPUT_KEYSTROKE_KEYDOWN = 0x0001;
        public const ushort XINPUT_KEYSTROKE_KEYUP = 0x0002;
        public const ushort XINPUT_KEYSTROKE_REPEAT = 0x0004;
    }
}
