// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mmdeviceapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static TerraFX.Interop.EndpointFormFactor;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [NativeTypeName("const PROPERTYKEY")]
        public static ref readonly PROPERTYKEY PKEY_AudioEndpoint_FormFactor
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x03, 0xD8, 0xA5, 0x1D,
                    0x92, 0xD4,
                    0xDD, 0x4E,
                    0x8C,
                    0x23,
                    0xE0,
                    0xC0,
                    0xFF,
                    0xEE,
                    0x7F,
                    0x0E,
                    0x00, 0x00, 0x00, 0x00
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
                return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const PROPERTYKEY")]
        public static ref readonly PROPERTYKEY PKEY_AudioEndpoint_ControlPanelPageProvider
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x03, 0xD8, 0xA5, 0x1D,
                    0x92, 0xD4,
                    0xDD, 0x4E,
                    0x8C,
                    0x23,
                    0xE0,
                    0xC0,
                    0xFF,
                    0xEE,
                    0x7F,
                    0x0E,
                    0x01, 0x00, 0x00, 0x00
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
                return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const PROPERTYKEY")]
        public static ref readonly PROPERTYKEY PKEY_AudioEndpoint_Association
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x03, 0xD8, 0xA5, 0x1D,
                    0x92, 0xD4,
                    0xDD, 0x4E,
                    0x8C,
                    0x23,
                    0xE0,
                    0xC0,
                    0xFF,
                    0xEE,
                    0x7F,
                    0x0E,
                    0x02, 0x00, 0x00, 0x00
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
                return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const PROPERTYKEY")]
        public static ref readonly PROPERTYKEY PKEY_AudioEndpoint_PhysicalSpeakers
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x03, 0xD8, 0xA5, 0x1D,
                    0x92, 0xD4,
                    0xDD, 0x4E,
                    0x8C,
                    0x23,
                    0xE0,
                    0xC0,
                    0xFF,
                    0xEE,
                    0x7F,
                    0x0E,
                    0x03, 0x00, 0x00, 0x00
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
                return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const PROPERTYKEY")]
        public static ref readonly PROPERTYKEY PKEY_AudioEndpoint_GUID
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x03, 0xD8, 0xA5, 0x1D,
                    0x92, 0xD4,
                    0xDD, 0x4E,
                    0x8C,
                    0x23,
                    0xE0,
                    0xC0,
                    0xFF,
                    0xEE,
                    0x7F,
                    0x0E,
                    0x04, 0x00, 0x00, 0x00
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
                return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const PROPERTYKEY")]
        public static ref readonly PROPERTYKEY PKEY_AudioEndpoint_Disable_SysFx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x03, 0xD8, 0xA5, 0x1D,
                    0x92, 0xD4,
                    0xDD, 0x4E,
                    0x8C,
                    0x23,
                    0xE0,
                    0xC0,
                    0xFF,
                    0xEE,
                    0x7F,
                    0x0E,
                    0x05, 0x00, 0x00, 0x00
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
                return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const PROPERTYKEY")]
        public static ref readonly PROPERTYKEY PKEY_AudioEndpoint_FullRangeSpeakers
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x03, 0xD8, 0xA5, 0x1D,
                    0x92, 0xD4,
                    0xDD, 0x4E,
                    0x8C,
                    0x23,
                    0xE0,
                    0xC0,
                    0xFF,
                    0xEE,
                    0x7F,
                    0x0E,
                    0x06, 0x00, 0x00, 0x00
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
                return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const PROPERTYKEY")]
        public static ref readonly PROPERTYKEY PKEY_AudioEndpoint_Supports_EventDriven_Mode
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x03, 0xD8, 0xA5, 0x1D,
                    0x92, 0xD4,
                    0xDD, 0x4E,
                    0x8C,
                    0x23,
                    0xE0,
                    0xC0,
                    0xFF,
                    0xEE,
                    0x7F,
                    0x0E,
                    0x07, 0x00, 0x00, 0x00
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
                return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const PROPERTYKEY")]
        public static ref readonly PROPERTYKEY PKEY_AudioEndpoint_JackSubType
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x03, 0xD8, 0xA5, 0x1D,
                    0x92, 0xD4,
                    0xDD, 0x4E,
                    0x8C,
                    0x23,
                    0xE0,
                    0xC0,
                    0xFF,
                    0xEE,
                    0x7F,
                    0x0E,
                    0x08, 0x00, 0x00, 0x00
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
                return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const PROPERTYKEY")]
        public static ref readonly PROPERTYKEY PKEY_AudioEndpoint_Default_VolumeInDb
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x03, 0xD8, 0xA5, 0x1D,
                    0x92, 0xD4,
                    0xDD, 0x4E,
                    0x8C,
                    0x23,
                    0xE0,
                    0xC0,
                    0xFF,
                    0xEE,
                    0x7F,
                    0x0E,
                    0x09, 0x00, 0x00, 0x00
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
                return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const PROPERTYKEY")]
        public static ref readonly PROPERTYKEY PKEY_AudioEngine_DeviceFormat
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x4D, 0x06, 0x9F, 0xF1,
                    0x2C, 0x08,
                    0x27, 0x4E,
                    0xBC,
                    0x73,
                    0x68,
                    0x82,
                    0xA1,
                    0xBB,
                    0x8E,
                    0x4C,
                    0x00, 0x00, 0x00, 0x00
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
                return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const PROPERTYKEY")]
        public static ref readonly PROPERTYKEY PKEY_AudioEngine_OEMFormat
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x26, 0x0E, 0x87, 0xE4,
                    0xC5, 0x3C,
                    0xD2, 0x4C,
                    0xBA,
                    0x46,
                    0xCA,
                    0x0A,
                    0x9A,
                    0x70,
                    0xED,
                    0x04,
                    0x03, 0x00, 0x00, 0x00
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
                return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const PROPERTYKEY")]
        public static ref readonly PROPERTYKEY PKEY_AudioEndpointLogo_IconEffects
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x0D, 0x78, 0xAB, 0xF1,
                    0x10, 0x20,
                    0xD3, 0x4E,
                    0xA3,
                    0xA6,
                    0x8B,
                    0x87,
                    0xF0,
                    0xF0,
                    0xC4,
                    0x76,
                    0x00, 0x00, 0x00, 0x00
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
                return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const PROPERTYKEY")]
        public static ref readonly PROPERTYKEY PKEY_AudioEndpointLogo_IconPath
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x0D, 0x78, 0xAB, 0xF1,
                    0x10, 0x20,
                    0xD3, 0x4E,
                    0xA3,
                    0xA6,
                    0x8B,
                    0x87,
                    0xF0,
                    0xF0,
                    0xC4,
                    0x76,
                    0x01, 0x00, 0x00, 0x00
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
                return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const PROPERTYKEY")]
        public static ref readonly PROPERTYKEY PKEY_AudioEndpointSettings_MenuText
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x02, 0x20, 0x24, 0x14,
                    0x20, 0x03,
                    0xE4, 0x4D,
                    0x95,
                    0x55,
                    0xA7,
                    0xD8,
                    0x2B,
                    0x73,
                    0xC2,
                    0x86,
                    0x00, 0x00, 0x00, 0x00
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
                return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const PROPERTYKEY")]
        public static ref readonly PROPERTYKEY PKEY_AudioEndpointSettings_LaunchContract
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x02, 0x20, 0x24, 0x14,
                    0x20, 0x03,
                    0xE4, 0x4D,
                    0x95,
                    0x55,
                    0xA7,
                    0xD8,
                    0x2B,
                    0x73,
                    0xC2,
                    0x86,
                    0x01, 0x00, 0x00, 0x00
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
                return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid DEVINTERFACE_AUDIO_RENDER
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xAD, 0x7C, 0x32, 0xE6,
                    0xEC, 0xDC,
                    0x49, 0x49,
                    0xAE,
                    0x8A,
                    0x99,
                    0x1E,
                    0x97,
                    0x6A,
                    0x79,
                    0xD2
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid DEVINTERFACE_AUDIO_CAPTURE
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xBE, 0x81, 0xEF, 0x2E,
                    0xFA, 0x33,
                    0x00, 0x48,
                    0x96,
                    0x70,
                    0x1C,
                    0xD4,
                    0x74,
                    0x97,
                    0x2C,
                    0x3F
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid DEVINTERFACE_MIDI_OUTPUT
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x20, 0x33, 0xC2, 0x6D,
                    0x33, 0xAB,
                    0xE4, 0x4C,
                    0x80,
                    0xD4,
                    0xBB,
                    0xB3,
                    0xEB,
                    0xBF,
                    0x28,
                    0x14
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid DEVINTERFACE_MIDI_INPUT
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x2C, 0xE3, 0x4B, 0x50,
                    0xF6, 0xCC,
                    0x2C, 0x4D,
                    0xB7,
                    0x3F,
                    0x6F,
                    0x8B,
                    0x37,
                    0x47,
                    0xE2,
                    0x2B
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [SupportedOSPlatform("windows8.0")]
        [DllImport("mmdevapi", ExactSpelling = true)]
        public static extern HRESULT ActivateAudioInterfaceAsync([NativeTypeName("LPCWSTR")] ushort* deviceInterfacePath, [NativeTypeName("const IID &")] Guid* riid, PROPVARIANT* activationParams, IActivateAudioInterfaceCompletionHandler* completionHandler, IActivateAudioInterfaceAsyncOperation** activationOperation);

        [NativeTypeName("#define E_NOTFOUND HRESULT_FROM_WIN32(ERROR_NOT_FOUND)")]
        public static HRESULT E_NOTFOUND => HRESULT_FROM_WIN32(1168);

        [NativeTypeName("#define E_UNSUPPORTED_TYPE HRESULT_FROM_WIN32(ERROR_UNSUPPORTED_TYPE)")]
        public static HRESULT E_UNSUPPORTED_TYPE => HRESULT_FROM_WIN32(1630);

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

        public static ref readonly Guid IID_IMMNotificationClient
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xC9, 0xEE, 0x91, 0x79,
                    0x89, 0x7E,
                    0x85, 0x4D,
                    0x83,
                    0x90,
                    0x6C,
                    0x70,
                    0x3C,
                    0xEC,
                    0x60,
                    0xC0
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMMDevice
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x3F, 0x06, 0x66, 0xD6,
                    0x87, 0x15,
                    0x43, 0x4E,
                    0x81,
                    0xF1,
                    0xB9,
                    0x48,
                    0xE8,
                    0x07,
                    0x36,
                    0x3F
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMMDeviceCollection
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xBE, 0xA1, 0xD7, 0x0B,
                    0x1A, 0x7A,
                    0xDB, 0x44,
                    0x83,
                    0x97,
                    0xCC,
                    0x53,
                    0x92,
                    0x38,
                    0x7B,
                    0x5E
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMMEndpoint
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x88, 0x97, 0xE0, 0x1B,
                    0x94, 0x68,
                    0x89, 0x40,
                    0x85,
                    0x86,
                    0x9A,
                    0x2A,
                    0x6C,
                    0x26,
                    0x5A,
                    0xC5
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMMDeviceEnumerator
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xD2, 0x64, 0x56, 0xA9,
                    0x14, 0x96,
                    0x35, 0x4F,
                    0xA7,
                    0x46,
                    0xDE,
                    0x8D,
                    0xB6,
                    0x36,
                    0x17,
                    0xE6
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMMDeviceActivator
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xA4, 0x0E, 0x0D, 0x3B,
                    0xA9, 0xD0,
                    0x0E, 0x4B,
                    0x93,
                    0x5B,
                    0x09,
                    0x51,
                    0x67,
                    0x46,
                    0xFA,
                    0xC0
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IActivateAudioInterfaceCompletionHandler
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xAB, 0x49, 0xD9, 0x41,
                    0x62, 0x98,
                    0x4A, 0x44,
                    0x80,
                    0xF6,
                    0xC2,
                    0x61,
                    0x33,
                    0x4D,
                    0xA5,
                    0xEB
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IActivateAudioInterfaceAsyncOperation
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x78, 0x2D, 0xA2, 0x72,
                    0xE4, 0xCD,
                    0x1D, 0x43,
                    0xB8,
                    0xCC,
                    0x84,
                    0x3A,
                    0x71,
                    0x19,
                    0x9B,
                    0x6D
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }
    }
}
