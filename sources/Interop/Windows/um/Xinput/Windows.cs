// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Xinput.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [DllImport("xinput1_4", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint XInputGetState([NativeTypeName("DWORD")] uint dwUserIndex, XINPUT_STATE* pState);

        [DllImport("xinput1_4", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint XInputSetState([NativeTypeName("DWORD")] uint dwUserIndex, XINPUT_VIBRATION* pVibration);

        [DllImport("xinput1_4", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint XInputGetCapabilities([NativeTypeName("DWORD")] uint dwUserIndex, [NativeTypeName("DWORD")] uint dwFlags, XINPUT_CAPABILITIES* pCapabilities);

        [DllImport("xinput1_4", ExactSpelling = true)]
        public static extern void XInputEnable([NativeTypeName("BOOL")] int enable);

        [DllImport("xinput1_4", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint XInputGetAudioDeviceIds([NativeTypeName("DWORD")] uint dwUserIndex, [NativeTypeName("LPWSTR")] ushort* pRenderDeviceId, [NativeTypeName("UINT *")] uint* pRenderCount, [NativeTypeName("LPWSTR")] ushort* pCaptureDeviceId, [NativeTypeName("UINT *")] uint* pCaptureCount);

        [DllImport("xinput1_4", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint XInputGetBatteryInformation([NativeTypeName("DWORD")] uint dwUserIndex, [NativeTypeName("BYTE")] byte devType, XINPUT_BATTERY_INFORMATION* pBatteryInformation);

        [DllImport("xinput1_4", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint XInputGetKeystroke([NativeTypeName("DWORD")] uint dwUserIndex, [NativeTypeName("DWORD")] uint dwReserved, [NativeTypeName("PXINPUT_KEYSTROKE")] XINPUT_KEYSTROKE* pKeystroke);

        [NativeTypeName("#define XINPUT_DLL_A \"xinput1_4.dll\"")]
        public static ReadOnlySpan<byte> XINPUT_DLL_A => new byte[] { 0x78, 0x69, 0x6E, 0x70, 0x75, 0x74, 0x31, 0x5F, 0x34, 0x2E, 0x64, 0x6C, 0x6C, 0x00 };

        [NativeTypeName("#define XINPUT_DLL_W L\"xinput1_4.dll\"")]
        public const string XINPUT_DLL_W = "xinput1_4.dll";

        [NativeTypeName("#define XINPUT_DLL XINPUT_DLL_W")]
        public const string XINPUT_DLL = "xinput1_4.dll";

        [NativeTypeName("#define XINPUT_DEVTYPE_GAMEPAD 0x01")]
        public const int XINPUT_DEVTYPE_GAMEPAD = 0x01;

        [NativeTypeName("#define XINPUT_DEVSUBTYPE_GAMEPAD 0x01")]
        public const int XINPUT_DEVSUBTYPE_GAMEPAD = 0x01;

        [NativeTypeName("#define XINPUT_DEVSUBTYPE_UNKNOWN 0x00")]
        public const int XINPUT_DEVSUBTYPE_UNKNOWN = 0x00;

        [NativeTypeName("#define XINPUT_DEVSUBTYPE_WHEEL 0x02")]
        public const int XINPUT_DEVSUBTYPE_WHEEL = 0x02;

        [NativeTypeName("#define XINPUT_DEVSUBTYPE_ARCADE_STICK 0x03")]
        public const int XINPUT_DEVSUBTYPE_ARCADE_STICK = 0x03;

        [NativeTypeName("#define XINPUT_DEVSUBTYPE_FLIGHT_STICK 0x04")]
        public const int XINPUT_DEVSUBTYPE_FLIGHT_STICK = 0x04;

        [NativeTypeName("#define XINPUT_DEVSUBTYPE_DANCE_PAD 0x05")]
        public const int XINPUT_DEVSUBTYPE_DANCE_PAD = 0x05;

        [NativeTypeName("#define XINPUT_DEVSUBTYPE_GUITAR 0x06")]
        public const int XINPUT_DEVSUBTYPE_GUITAR = 0x06;

        [NativeTypeName("#define XINPUT_DEVSUBTYPE_GUITAR_ALTERNATE 0x07")]
        public const int XINPUT_DEVSUBTYPE_GUITAR_ALTERNATE = 0x07;

        [NativeTypeName("#define XINPUT_DEVSUBTYPE_DRUM_KIT 0x08")]
        public const int XINPUT_DEVSUBTYPE_DRUM_KIT = 0x08;

        [NativeTypeName("#define XINPUT_DEVSUBTYPE_GUITAR_BASS 0x0B")]
        public const int XINPUT_DEVSUBTYPE_GUITAR_BASS = 0x0B;

        [NativeTypeName("#define XINPUT_DEVSUBTYPE_ARCADE_PAD 0x13")]
        public const int XINPUT_DEVSUBTYPE_ARCADE_PAD = 0x13;

        [NativeTypeName("#define XINPUT_CAPS_VOICE_SUPPORTED 0x0004")]
        public const int XINPUT_CAPS_VOICE_SUPPORTED = 0x0004;

        [NativeTypeName("#define XINPUT_CAPS_FFB_SUPPORTED 0x0001")]
        public const int XINPUT_CAPS_FFB_SUPPORTED = 0x0001;

        [NativeTypeName("#define XINPUT_CAPS_WIRELESS 0x0002")]
        public const int XINPUT_CAPS_WIRELESS = 0x0002;

        [NativeTypeName("#define XINPUT_CAPS_PMD_SUPPORTED 0x0008")]
        public const int XINPUT_CAPS_PMD_SUPPORTED = 0x0008;

        [NativeTypeName("#define XINPUT_CAPS_NO_NAVIGATION 0x0010")]
        public const int XINPUT_CAPS_NO_NAVIGATION = 0x0010;

        [NativeTypeName("#define XINPUT_GAMEPAD_DPAD_UP 0x0001")]
        public const int XINPUT_GAMEPAD_DPAD_UP = 0x0001;

        [NativeTypeName("#define XINPUT_GAMEPAD_DPAD_DOWN 0x0002")]
        public const int XINPUT_GAMEPAD_DPAD_DOWN = 0x0002;

        [NativeTypeName("#define XINPUT_GAMEPAD_DPAD_LEFT 0x0004")]
        public const int XINPUT_GAMEPAD_DPAD_LEFT = 0x0004;

        [NativeTypeName("#define XINPUT_GAMEPAD_DPAD_RIGHT 0x0008")]
        public const int XINPUT_GAMEPAD_DPAD_RIGHT = 0x0008;

        [NativeTypeName("#define XINPUT_GAMEPAD_START 0x0010")]
        public const int XINPUT_GAMEPAD_START = 0x0010;

        [NativeTypeName("#define XINPUT_GAMEPAD_BACK 0x0020")]
        public const int XINPUT_GAMEPAD_BACK = 0x0020;

        [NativeTypeName("#define XINPUT_GAMEPAD_LEFT_THUMB 0x0040")]
        public const int XINPUT_GAMEPAD_LEFT_THUMB = 0x0040;

        [NativeTypeName("#define XINPUT_GAMEPAD_RIGHT_THUMB 0x0080")]
        public const int XINPUT_GAMEPAD_RIGHT_THUMB = 0x0080;

        [NativeTypeName("#define XINPUT_GAMEPAD_LEFT_SHOULDER 0x0100")]
        public const int XINPUT_GAMEPAD_LEFT_SHOULDER = 0x0100;

        [NativeTypeName("#define XINPUT_GAMEPAD_RIGHT_SHOULDER 0x0200")]
        public const int XINPUT_GAMEPAD_RIGHT_SHOULDER = 0x0200;

        [NativeTypeName("#define XINPUT_GAMEPAD_A 0x1000")]
        public const int XINPUT_GAMEPAD_A = 0x1000;

        [NativeTypeName("#define XINPUT_GAMEPAD_B 0x2000")]
        public const int XINPUT_GAMEPAD_B = 0x2000;

        [NativeTypeName("#define XINPUT_GAMEPAD_X 0x4000")]
        public const int XINPUT_GAMEPAD_X = 0x4000;

        [NativeTypeName("#define XINPUT_GAMEPAD_Y 0x8000")]
        public const int XINPUT_GAMEPAD_Y = 0x8000;

        [NativeTypeName("#define XINPUT_GAMEPAD_LEFT_THUMB_DEADZONE 7849")]
        public const int XINPUT_GAMEPAD_LEFT_THUMB_DEADZONE = 7849;

        [NativeTypeName("#define XINPUT_GAMEPAD_RIGHT_THUMB_DEADZONE 8689")]
        public const int XINPUT_GAMEPAD_RIGHT_THUMB_DEADZONE = 8689;

        [NativeTypeName("#define XINPUT_GAMEPAD_TRIGGER_THRESHOLD 30")]
        public const int XINPUT_GAMEPAD_TRIGGER_THRESHOLD = 30;

        [NativeTypeName("#define XINPUT_FLAG_GAMEPAD 0x00000001")]
        public const int XINPUT_FLAG_GAMEPAD = 0x00000001;

        [NativeTypeName("#define BATTERY_DEVTYPE_GAMEPAD 0x00")]
        public const int BATTERY_DEVTYPE_GAMEPAD = 0x00;

        [NativeTypeName("#define BATTERY_DEVTYPE_HEADSET 0x01")]
        public const int BATTERY_DEVTYPE_HEADSET = 0x01;

        [NativeTypeName("#define BATTERY_TYPE_DISCONNECTED 0x00")]
        public const int BATTERY_TYPE_DISCONNECTED = 0x00;

        [NativeTypeName("#define BATTERY_TYPE_WIRED 0x01")]
        public const int BATTERY_TYPE_WIRED = 0x01;

        [NativeTypeName("#define BATTERY_TYPE_ALKALINE 0x02")]
        public const int BATTERY_TYPE_ALKALINE = 0x02;

        [NativeTypeName("#define BATTERY_TYPE_NIMH 0x03")]
        public const int BATTERY_TYPE_NIMH = 0x03;

        [NativeTypeName("#define BATTERY_TYPE_UNKNOWN 0xFF")]
        public const int BATTERY_TYPE_UNKNOWN = 0xFF;

        [NativeTypeName("#define BATTERY_LEVEL_EMPTY 0x00")]
        public const int BATTERY_LEVEL_EMPTY = 0x00;

        [NativeTypeName("#define BATTERY_LEVEL_LOW 0x01")]
        public const int BATTERY_LEVEL_LOW = 0x01;

        [NativeTypeName("#define BATTERY_LEVEL_MEDIUM 0x02")]
        public const int BATTERY_LEVEL_MEDIUM = 0x02;

        [NativeTypeName("#define BATTERY_LEVEL_FULL 0x03")]
        public const int BATTERY_LEVEL_FULL = 0x03;

        [NativeTypeName("#define XUSER_MAX_COUNT 4")]
        public const int XUSER_MAX_COUNT = 4;

        [NativeTypeName("#define XUSER_INDEX_ANY 0x000000FF")]
        public const int XUSER_INDEX_ANY = 0x000000FF;

        [NativeTypeName("#define VK_PAD_A 0x5800")]
        public const int VK_PAD_A = 0x5800;

        [NativeTypeName("#define VK_PAD_B 0x5801")]
        public const int VK_PAD_B = 0x5801;

        [NativeTypeName("#define VK_PAD_X 0x5802")]
        public const int VK_PAD_X = 0x5802;

        [NativeTypeName("#define VK_PAD_Y 0x5803")]
        public const int VK_PAD_Y = 0x5803;

        [NativeTypeName("#define VK_PAD_RSHOULDER 0x5804")]
        public const int VK_PAD_RSHOULDER = 0x5804;

        [NativeTypeName("#define VK_PAD_LSHOULDER 0x5805")]
        public const int VK_PAD_LSHOULDER = 0x5805;

        [NativeTypeName("#define VK_PAD_LTRIGGER 0x5806")]
        public const int VK_PAD_LTRIGGER = 0x5806;

        [NativeTypeName("#define VK_PAD_RTRIGGER 0x5807")]
        public const int VK_PAD_RTRIGGER = 0x5807;

        [NativeTypeName("#define VK_PAD_DPAD_UP 0x5810")]
        public const int VK_PAD_DPAD_UP = 0x5810;

        [NativeTypeName("#define VK_PAD_DPAD_DOWN 0x5811")]
        public const int VK_PAD_DPAD_DOWN = 0x5811;

        [NativeTypeName("#define VK_PAD_DPAD_LEFT 0x5812")]
        public const int VK_PAD_DPAD_LEFT = 0x5812;

        [NativeTypeName("#define VK_PAD_DPAD_RIGHT 0x5813")]
        public const int VK_PAD_DPAD_RIGHT = 0x5813;

        [NativeTypeName("#define VK_PAD_START 0x5814")]
        public const int VK_PAD_START = 0x5814;

        [NativeTypeName("#define VK_PAD_BACK 0x5815")]
        public const int VK_PAD_BACK = 0x5815;

        [NativeTypeName("#define VK_PAD_LTHUMB_PRESS 0x5816")]
        public const int VK_PAD_LTHUMB_PRESS = 0x5816;

        [NativeTypeName("#define VK_PAD_RTHUMB_PRESS 0x5817")]
        public const int VK_PAD_RTHUMB_PRESS = 0x5817;

        [NativeTypeName("#define VK_PAD_LTHUMB_UP 0x5820")]
        public const int VK_PAD_LTHUMB_UP = 0x5820;

        [NativeTypeName("#define VK_PAD_LTHUMB_DOWN 0x5821")]
        public const int VK_PAD_LTHUMB_DOWN = 0x5821;

        [NativeTypeName("#define VK_PAD_LTHUMB_RIGHT 0x5822")]
        public const int VK_PAD_LTHUMB_RIGHT = 0x5822;

        [NativeTypeName("#define VK_PAD_LTHUMB_LEFT 0x5823")]
        public const int VK_PAD_LTHUMB_LEFT = 0x5823;

        [NativeTypeName("#define VK_PAD_LTHUMB_UPLEFT 0x5824")]
        public const int VK_PAD_LTHUMB_UPLEFT = 0x5824;

        [NativeTypeName("#define VK_PAD_LTHUMB_UPRIGHT 0x5825")]
        public const int VK_PAD_LTHUMB_UPRIGHT = 0x5825;

        [NativeTypeName("#define VK_PAD_LTHUMB_DOWNRIGHT 0x5826")]
        public const int VK_PAD_LTHUMB_DOWNRIGHT = 0x5826;

        [NativeTypeName("#define VK_PAD_LTHUMB_DOWNLEFT 0x5827")]
        public const int VK_PAD_LTHUMB_DOWNLEFT = 0x5827;

        [NativeTypeName("#define VK_PAD_RTHUMB_UP 0x5830")]
        public const int VK_PAD_RTHUMB_UP = 0x5830;

        [NativeTypeName("#define VK_PAD_RTHUMB_DOWN 0x5831")]
        public const int VK_PAD_RTHUMB_DOWN = 0x5831;

        [NativeTypeName("#define VK_PAD_RTHUMB_RIGHT 0x5832")]
        public const int VK_PAD_RTHUMB_RIGHT = 0x5832;

        [NativeTypeName("#define VK_PAD_RTHUMB_LEFT 0x5833")]
        public const int VK_PAD_RTHUMB_LEFT = 0x5833;

        [NativeTypeName("#define VK_PAD_RTHUMB_UPLEFT 0x5834")]
        public const int VK_PAD_RTHUMB_UPLEFT = 0x5834;

        [NativeTypeName("#define VK_PAD_RTHUMB_UPRIGHT 0x5835")]
        public const int VK_PAD_RTHUMB_UPRIGHT = 0x5835;

        [NativeTypeName("#define VK_PAD_RTHUMB_DOWNRIGHT 0x5836")]
        public const int VK_PAD_RTHUMB_DOWNRIGHT = 0x5836;

        [NativeTypeName("#define VK_PAD_RTHUMB_DOWNLEFT 0x5837")]
        public const int VK_PAD_RTHUMB_DOWNLEFT = 0x5837;

        [NativeTypeName("#define XINPUT_KEYSTROKE_KEYDOWN 0x0001")]
        public const int XINPUT_KEYSTROKE_KEYDOWN = 0x0001;

        [NativeTypeName("#define XINPUT_KEYSTROKE_KEYUP 0x0002")]
        public const int XINPUT_KEYSTROKE_KEYUP = 0x0002;

        [NativeTypeName("#define XINPUT_KEYSTROKE_REPEAT 0x0004")]
        public const int XINPUT_KEYSTROKE_REPEAT = 0x0004;
    }
}
