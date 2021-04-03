// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mmdeviceapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.EndpointFormFactor;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [NativeTypeName("const PROPERTYKEY")]
        public static readonly PROPERTYKEY PKEY_AudioEndpoint_FormFactor = new PROPERTYKEY
        {
            fmtid = new Guid(0x1da5d803, 0xd492, 0x4edd, 0x8c, 0x23, 0xe0, 0xc0, 0xff, 0xee, 0x7f, 0x0e),
            pid = 0,
        };

        [NativeTypeName("const PROPERTYKEY")]
        public static readonly PROPERTYKEY PKEY_AudioEndpoint_ControlPanelPageProvider = new PROPERTYKEY
        {
            fmtid = new Guid(0x1da5d803, 0xd492, 0x4edd, 0x8c, 0x23, 0xe0, 0xc0, 0xff, 0xee, 0x7f, 0x0e),
            pid = 1,
        };

        [NativeTypeName("const PROPERTYKEY")]
        public static readonly PROPERTYKEY PKEY_AudioEndpoint_Association = new PROPERTYKEY
        {
            fmtid = new Guid(0x1da5d803, 0xd492, 0x4edd, 0x8c, 0x23, 0xe0, 0xc0, 0xff, 0xee, 0x7f, 0x0e),
            pid = 2,
        };

        [NativeTypeName("const PROPERTYKEY")]
        public static readonly PROPERTYKEY PKEY_AudioEndpoint_PhysicalSpeakers = new PROPERTYKEY
        {
            fmtid = new Guid(0x1da5d803, 0xd492, 0x4edd, 0x8c, 0x23, 0xe0, 0xc0, 0xff, 0xee, 0x7f, 0x0e),
            pid = 3,
        };

        [NativeTypeName("const PROPERTYKEY")]
        public static readonly PROPERTYKEY PKEY_AudioEndpoint_GUID = new PROPERTYKEY
        {
            fmtid = new Guid(0x1da5d803, 0xd492, 0x4edd, 0x8c, 0x23, 0xe0, 0xc0, 0xff, 0xee, 0x7f, 0x0e),
            pid = 4,
        };

        [NativeTypeName("const PROPERTYKEY")]
        public static readonly PROPERTYKEY PKEY_AudioEndpoint_Disable_SysFx = new PROPERTYKEY
        {
            fmtid = new Guid(0x1da5d803, 0xd492, 0x4edd, 0x8c, 0x23, 0xe0, 0xc0, 0xff, 0xee, 0x7f, 0x0e),
            pid = 5,
        };

        [NativeTypeName("const PROPERTYKEY")]
        public static readonly PROPERTYKEY PKEY_AudioEndpoint_FullRangeSpeakers = new PROPERTYKEY
        {
            fmtid = new Guid(0x1da5d803, 0xd492, 0x4edd, 0x8c, 0x23, 0xe0, 0xc0, 0xff, 0xee, 0x7f, 0x0e),
            pid = 6,
        };

        [NativeTypeName("const PROPERTYKEY")]
        public static readonly PROPERTYKEY PKEY_AudioEndpoint_Supports_EventDriven_Mode = new PROPERTYKEY
        {
            fmtid = new Guid(0x1da5d803, 0xd492, 0x4edd, 0x8c, 0x23, 0xe0, 0xc0, 0xff, 0xee, 0x7f, 0x0e),
            pid = 7,
        };

        [NativeTypeName("const PROPERTYKEY")]
        public static readonly PROPERTYKEY PKEY_AudioEndpoint_JackSubType = new PROPERTYKEY
        {
            fmtid = new Guid(0x1da5d803, 0xd492, 0x4edd, 0x8c, 0x23, 0xe0, 0xc0, 0xff, 0xee, 0x7f, 0x0e),
            pid = 8,
        };

        [NativeTypeName("const PROPERTYKEY")]
        public static readonly PROPERTYKEY PKEY_AudioEndpoint_Default_VolumeInDb = new PROPERTYKEY
        {
            fmtid = new Guid(0x1da5d803, 0xd492, 0x4edd, 0x8c, 0x23, 0xe0, 0xc0, 0xff, 0xee, 0x7f, 0x0e),
            pid = 9,
        };

        [NativeTypeName("const PROPERTYKEY")]
        public static readonly PROPERTYKEY PKEY_AudioEngine_DeviceFormat = new PROPERTYKEY
        {
            fmtid = new Guid(0xf19f064d, 0x82c, 0x4e27, 0xbc, 0x73, 0x68, 0x82, 0xa1, 0xbb, 0x8e, 0x4c),
            pid = 0,
        };

        [NativeTypeName("const PROPERTYKEY")]
        public static readonly PROPERTYKEY PKEY_AudioEngine_OEMFormat = new PROPERTYKEY
        {
            fmtid = new Guid(0xe4870e26, 0x3cc5, 0x4cd2, 0xba, 0x46, 0xca, 0xa, 0x9a, 0x70, 0xed, 0x4),
            pid = 3,
        };

        [NativeTypeName("const PROPERTYKEY")]
        public static readonly PROPERTYKEY PKEY_AudioEndpointLogo_IconEffects = new PROPERTYKEY
        {
            fmtid = new Guid(0xf1ab780d, 0x2010, 0x4ed3, 0xa3, 0xa6, 0x8b, 0x87, 0xf0, 0xf0, 0xc4, 0x76),
            pid = 0,
        };

        [NativeTypeName("const PROPERTYKEY")]
        public static readonly PROPERTYKEY PKEY_AudioEndpointLogo_IconPath = new PROPERTYKEY
        {
            fmtid = new Guid(0xf1ab780d, 0x2010, 0x4ed3, 0xa3, 0xa6, 0x8b, 0x87, 0xf0, 0xf0, 0xc4, 0x76),
            pid = 1,
        };

        [NativeTypeName("const PROPERTYKEY")]
        public static readonly PROPERTYKEY PKEY_AudioEndpointSettings_MenuText = new PROPERTYKEY
        {
            fmtid = new Guid(0x14242002, 0x0320, 0x4de4, 0x95, 0x55, 0xa7, 0xd8, 0x2b, 0x73, 0xc2, 0x86),
            pid = 0,
        };

        [NativeTypeName("const PROPERTYKEY")]
        public static readonly PROPERTYKEY PKEY_AudioEndpointSettings_LaunchContract = new PROPERTYKEY
        {
            fmtid = new Guid(0x14242002, 0x0320, 0x4de4, 0x95, 0x55, 0xa7, 0xd8, 0x2b, 0x73, 0xc2, 0x86),
            pid = 1,
        };

        [NativeTypeName("const GUID")]
        public static readonly Guid DEVINTERFACE_AUDIO_RENDER = new Guid(0xe6327cad, 0xdcec, 0x4949, 0xae, 0x8a, 0x99, 0x1e, 0x97, 0x6a, 0x79, 0xd2);

        [NativeTypeName("const GUID")]
        public static readonly Guid DEVINTERFACE_AUDIO_CAPTURE = new Guid(0x2eef81be, 0x33fa, 0x4800, 0x96, 0x70, 0x1c, 0xd4, 0x74, 0x97, 0x2c, 0x3f);

        [NativeTypeName("const GUID")]
        public static readonly Guid DEVINTERFACE_MIDI_OUTPUT = new Guid(0x6dc23320, 0xab33, 0x4ce4, 0x80, 0xd4, 0xbb, 0xb3, 0xeb, 0xbf, 0x28, 0x14);

        [NativeTypeName("const GUID")]
        public static readonly Guid DEVINTERFACE_MIDI_INPUT = new Guid(0x504be32c, 0xccf6, 0x4d2c, 0xb7, 0x3f, 0x6f, 0x8b, 0x37, 0x47, 0xe2, 0x2b);

        [DllImport("mmdevapi", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int ActivateAudioInterfaceAsync([NativeTypeName("LPCWSTR")] ushort* deviceInterfacePath, [NativeTypeName("const IID &")] Guid* riid, PROPVARIANT* activationParams, IActivateAudioInterfaceCompletionHandler* completionHandler, IActivateAudioInterfaceAsyncOperation** activationOperation);

        [NativeTypeName("#define E_NOTFOUND HRESULT_FROM_WIN32(ERROR_NOT_FOUND)")]
        public static readonly int E_NOTFOUND = HRESULT_FROM_WIN32(1168);

        [NativeTypeName("#define E_UNSUPPORTED_TYPE HRESULT_FROM_WIN32(ERROR_UNSUPPORTED_TYPE)")]
        public static readonly int E_UNSUPPORTED_TYPE = HRESULT_FROM_WIN32(1630);

        [NativeTypeName("#define DEVICE_STATE_ACTIVE 0x00000001")]
        public const int DEVICE_STATE_ACTIVE = 0x00000001;

        [NativeTypeName("#define DEVICE_STATE_DISABLED 0x00000002")]
        public const int DEVICE_STATE_DISABLED = 0x00000002;

        [NativeTypeName("#define DEVICE_STATE_NOTPRESENT 0x00000004")]
        public const int DEVICE_STATE_NOTPRESENT = 0x00000004;

        [NativeTypeName("#define DEVICE_STATE_UNPLUGGED 0x00000008")]
        public const int DEVICE_STATE_UNPLUGGED = 0x00000008;

        [NativeTypeName("#define DEVICE_STATEMASK_ALL 0x0000000f")]
        public const int DEVICE_STATEMASK_ALL = 0x0000000f;

        [NativeTypeName("#define ENDPOINT_SYSFX_ENABLED 0x00000000")]
        public const int ENDPOINT_SYSFX_ENABLED = 0x00000000;

        [NativeTypeName("#define ENDPOINT_SYSFX_DISABLED 0x00000001")]
        public const int ENDPOINT_SYSFX_DISABLED = 0x00000001;

        [NativeTypeName("#define HDMI DigitalAudioDisplayDevice")]
        public const EndpointFormFactor HDMI = DigitalAudioDisplayDevice;

        public static readonly Guid IID_IMMNotificationClient = new Guid(0x7991EEC9, 0x7E89, 0x4D85, 0x83, 0x90, 0x6C, 0x70, 0x3C, 0xEC, 0x60, 0xC0);

        public static readonly Guid IID_IMMDevice = new Guid(0xD666063F, 0x1587, 0x4E43, 0x81, 0xF1, 0xB9, 0x48, 0xE8, 0x07, 0x36, 0x3F);

        public static readonly Guid IID_IMMDeviceCollection = new Guid(0x0BD7A1BE, 0x7A1A, 0x44DB, 0x83, 0x97, 0xCC, 0x53, 0x92, 0x38, 0x7B, 0x5E);

        public static readonly Guid IID_IMMEndpoint = new Guid(0x1BE09788, 0x6894, 0x4089, 0x85, 0x86, 0x9A, 0x2A, 0x6C, 0x26, 0x5A, 0xC5);

        public static readonly Guid IID_IMMDeviceEnumerator = new Guid(0xA95664D2, 0x9614, 0x4F35, 0xA7, 0x46, 0xDE, 0x8D, 0xB6, 0x36, 0x17, 0xE6);

        public static readonly Guid IID_IMMDeviceActivator = new Guid(0x3B0D0EA4, 0xD0A9, 0x4B0E, 0x93, 0x5B, 0x09, 0x51, 0x67, 0x46, 0xFA, 0xC0);

        public static readonly Guid IID_IActivateAudioInterfaceCompletionHandler = new Guid(0x41D949AB, 0x9862, 0x444A, 0x80, 0xF6, 0xC2, 0x61, 0x33, 0x4D, 0xA5, 0xEB);

        public static readonly Guid IID_IActivateAudioInterfaceAsyncOperation = new Guid(0x72A22D78, 0xCDE4, 0x431D, 0xB8, 0xCC, 0x84, 0x3A, 0x71, 0x19, 0x9B, 0x6D);
    }
}
