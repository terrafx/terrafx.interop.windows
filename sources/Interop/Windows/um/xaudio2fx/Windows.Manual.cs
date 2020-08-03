// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/xaudio2fx.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [NativeTypeName("const GUID")]
        public static readonly Guid CLSID_AudioVolumeMeter = new Guid(0x4FC3B166, 0x972A, 0x40CF, 0xBC, 0x37, 0x7D, 0xB0, 0x3D, 0xB2, 0xFB, 0xA3);

        [NativeTypeName("const GUID")]
        public static readonly Guid CLSID_AudioReverb = new Guid(0xC2633B16, 0x471B, 0x4498, 0xB8, 0xC5, 0x4F, 0x09, 0x59, 0xE2, 0xEC, 0x09);

        public static readonly XAUDIO2FX_REVERB_I3DL2_PARAMETERS XAUDIO2FX_I3DL2_PRESET_DEFAULT = new XAUDIO2FX_REVERB_I3DL2_PARAMETERS { WetDryMix = 100, Room = -10000, RoomHF = 0, RoomRolloffFactor = 0.0f, DecayTime = 1.00f, DecayHFRatio = 0.50f, Reflections = -10000, ReflectionsDelay = 0.020f, Reverb = -10000, ReverbDelay = 0.040f, Diffusion = 100.0f, Density = 100.0f, HFReference = 5000.0f };

        public static readonly XAUDIO2FX_REVERB_I3DL2_PARAMETERS XAUDIO2FX_I3DL2_PRESET_GENERIC = new XAUDIO2FX_REVERB_I3DL2_PARAMETERS { WetDryMix = 100, Room = -1000, RoomHF = -100, RoomRolloffFactor = 0.0f, DecayTime = 1.49f, DecayHFRatio = 0.83f, Reflections = -2602, ReflectionsDelay = 0.007f, Reverb = 200, ReverbDelay = 0.011f, Diffusion = 100.0f, Density = 100.0f, HFReference = 5000.0f };

        public static readonly XAUDIO2FX_REVERB_I3DL2_PARAMETERS XAUDIO2FX_I3DL2_PRESET_PADDEDCELL = new XAUDIO2FX_REVERB_I3DL2_PARAMETERS { WetDryMix = 100, Room = -1000, RoomHF = -6000, RoomRolloffFactor = 0.0f, DecayTime = 0.17f, DecayHFRatio = 0.10f, Reflections = -1204, ReflectionsDelay = 0.001f, Reverb = 207, ReverbDelay = 0.002f, Diffusion = 100.0f, Density = 100.0f, HFReference = 5000.0f };

        public static readonly XAUDIO2FX_REVERB_I3DL2_PARAMETERS XAUDIO2FX_I3DL2_PRESET_ROOM = new XAUDIO2FX_REVERB_I3DL2_PARAMETERS { WetDryMix = 100, Room = -1000, RoomHF = -454, RoomRolloffFactor = 0.0f, DecayTime = 0.40f, DecayHFRatio = 0.83f, Reflections = -1646, ReflectionsDelay = 0.002f, Reverb = 53, ReverbDelay = 0.003f, Diffusion = 100.0f, Density = 100.0f, HFReference = 5000.0f };

        public static readonly XAUDIO2FX_REVERB_I3DL2_PARAMETERS XAUDIO2FX_I3DL2_PRESET_BATHROOM = new XAUDIO2FX_REVERB_I3DL2_PARAMETERS { WetDryMix = 100, Room = -1000, RoomHF = -1200, RoomRolloffFactor = 0.0f, DecayTime = 1.49f, DecayHFRatio = 0.54f, Reflections = -370, ReflectionsDelay = 0.007f, Reverb = 1030, ReverbDelay = 0.011f, Diffusion = 100.0f, Density = 60.0f, HFReference = 5000.0f };

        public static readonly XAUDIO2FX_REVERB_I3DL2_PARAMETERS XAUDIO2FX_I3DL2_PRESET_LIVINGROOM = new XAUDIO2FX_REVERB_I3DL2_PARAMETERS { WetDryMix = 100, Room = -1000, RoomHF = -6000, RoomRolloffFactor = 0.0f, DecayTime = 0.50f, DecayHFRatio = 0.10f, Reflections = -1376, ReflectionsDelay = 0.003f, Reverb = -1104, ReverbDelay = 0.004f, Diffusion = 100.0f, Density = 100.0f, HFReference = 5000.0f };

        public static readonly XAUDIO2FX_REVERB_I3DL2_PARAMETERS XAUDIO2FX_I3DL2_PRESET_STONEROOM = new XAUDIO2FX_REVERB_I3DL2_PARAMETERS { WetDryMix = 100, Room = -1000, RoomHF = -300, RoomRolloffFactor = 0.0f, DecayTime = 2.31f, DecayHFRatio = 0.64f, Reflections = -711, ReflectionsDelay = 0.012f, Reverb = 83, ReverbDelay = 0.017f, Diffusion = 100.0f, Density = 100.0f, HFReference = 5000.0f };

        public static readonly XAUDIO2FX_REVERB_I3DL2_PARAMETERS XAUDIO2FX_I3DL2_PRESET_AUDITORIUM = new XAUDIO2FX_REVERB_I3DL2_PARAMETERS { WetDryMix = 100, Room = -1000, RoomHF = -476, RoomRolloffFactor = 0.0f, DecayTime = 4.32f, DecayHFRatio = 0.59f, Reflections = -789, ReflectionsDelay = 0.020f, Reverb = -289, ReverbDelay = 0.030f, Diffusion = 100.0f, Density = 100.0f, HFReference = 5000.0f };

        public static readonly XAUDIO2FX_REVERB_I3DL2_PARAMETERS XAUDIO2FX_I3DL2_PRESET_CONCERTHALL = new XAUDIO2FX_REVERB_I3DL2_PARAMETERS { WetDryMix = 100, Room = -1000, RoomHF = -500, RoomRolloffFactor = 0.0f, DecayTime = 3.92f, DecayHFRatio = 0.70f, Reflections = -1230, ReflectionsDelay = 0.020f, Reverb = -2, ReverbDelay = 0.029f, Diffusion = 100.0f, Density = 100.0f, HFReference = 5000.0f };

        public static readonly XAUDIO2FX_REVERB_I3DL2_PARAMETERS XAUDIO2FX_I3DL2_PRESET_CAVE = new XAUDIO2FX_REVERB_I3DL2_PARAMETERS { WetDryMix = 100, Room = -1000, RoomHF = 0, RoomRolloffFactor = 0.0f, DecayTime = 2.91f, DecayHFRatio = 1.30f, Reflections = -602, ReflectionsDelay = 0.015f, Reverb = -302, ReverbDelay = 0.022f, Diffusion = 100.0f, Density = 100.0f, HFReference = 5000.0f };

        public static readonly XAUDIO2FX_REVERB_I3DL2_PARAMETERS XAUDIO2FX_I3DL2_PRESET_ARENA = new XAUDIO2FX_REVERB_I3DL2_PARAMETERS { WetDryMix = 100, Room = -1000, RoomHF = -698, RoomRolloffFactor = 0.0f, DecayTime = 7.24f, DecayHFRatio = 0.33f, Reflections = -1166, ReflectionsDelay = 0.020f, Reverb = 16, ReverbDelay = 0.030f, Diffusion = 100.0f, Density = 100.0f, HFReference = 5000.0f };

        public static readonly XAUDIO2FX_REVERB_I3DL2_PARAMETERS XAUDIO2FX_I3DL2_PRESET_HANGAR = new XAUDIO2FX_REVERB_I3DL2_PARAMETERS { WetDryMix = 100, Room = -1000, RoomHF = -1000, RoomRolloffFactor = 0.0f, DecayTime = 10.05f, DecayHFRatio = 0.23f, Reflections = -602, ReflectionsDelay = 0.020f, Reverb = 198, ReverbDelay = 0.030f, Diffusion = 100.0f, Density = 100.0f, HFReference = 5000.0f };

        public static readonly XAUDIO2FX_REVERB_I3DL2_PARAMETERS XAUDIO2FX_I3DL2_PRESET_CARPETEDHALLWAY = new XAUDIO2FX_REVERB_I3DL2_PARAMETERS { WetDryMix = 100, Room = -1000, RoomHF = -4000, RoomRolloffFactor = 0.0f, DecayTime = 0.30f, DecayHFRatio = 0.10f, Reflections = -1831, ReflectionsDelay = 0.002f, Reverb = -1630, ReverbDelay = 0.030f, Diffusion = 100.0f, Density = 100.0f, HFReference = 5000.0f };

        public static readonly XAUDIO2FX_REVERB_I3DL2_PARAMETERS XAUDIO2FX_I3DL2_PRESET_HALLWAY = new XAUDIO2FX_REVERB_I3DL2_PARAMETERS { WetDryMix = 100, Room = -1000, RoomHF = -300, RoomRolloffFactor = 0.0f, DecayTime = 1.49f, DecayHFRatio = 0.59f, Reflections = -1219, ReflectionsDelay = 0.007f, Reverb = 441, ReverbDelay = 0.011f, Diffusion = 100.0f, Density = 100.0f, HFReference = 5000.0f };

        public static readonly XAUDIO2FX_REVERB_I3DL2_PARAMETERS XAUDIO2FX_I3DL2_PRESET_STONECORRIDOR = new XAUDIO2FX_REVERB_I3DL2_PARAMETERS { WetDryMix = 100, Room = -1000, RoomHF = -237, RoomRolloffFactor = 0.0f, DecayTime = 2.70f, DecayHFRatio = 0.79f, Reflections = -1214, ReflectionsDelay = 0.013f, Reverb = 395, ReverbDelay = 0.020f, Diffusion = 100.0f, Density = 100.0f, HFReference = 5000.0f };

        public static readonly XAUDIO2FX_REVERB_I3DL2_PARAMETERS XAUDIO2FX_I3DL2_PRESET_ALLEY = new XAUDIO2FX_REVERB_I3DL2_PARAMETERS { WetDryMix = 100, Room = -1000, RoomHF = -270, RoomRolloffFactor = 0.0f, DecayTime = 1.49f, DecayHFRatio = 0.86f, Reflections = -1204, ReflectionsDelay = 0.007f, Reverb = -4, ReverbDelay = 0.011f, Diffusion = 100.0f, Density = 100.0f, HFReference = 5000.0f };

        public static readonly XAUDIO2FX_REVERB_I3DL2_PARAMETERS XAUDIO2FX_I3DL2_PRESET_FOREST = new XAUDIO2FX_REVERB_I3DL2_PARAMETERS { WetDryMix = 100, Room = -1000, RoomHF = -3300, RoomRolloffFactor = 0.0f, DecayTime = 1.49f, DecayHFRatio = 0.54f, Reflections = -2560, ReflectionsDelay = 0.162f, Reverb = -613, ReverbDelay = 0.088f, Diffusion = 79.0f, Density = 100.0f, HFReference = 5000.0f };

        public static readonly XAUDIO2FX_REVERB_I3DL2_PARAMETERS XAUDIO2FX_I3DL2_PRESET_CITY = new XAUDIO2FX_REVERB_I3DL2_PARAMETERS { WetDryMix = 100, Room = -1000, RoomHF = -800, RoomRolloffFactor = 0.0f, DecayTime = 1.49f, DecayHFRatio = 0.67f, Reflections = -2273, ReflectionsDelay = 0.007f, Reverb = -2217, ReverbDelay = 0.011f, Diffusion = 50.0f, Density = 100.0f, HFReference = 5000.0f };

        public static readonly XAUDIO2FX_REVERB_I3DL2_PARAMETERS XAUDIO2FX_I3DL2_PRESET_MOUNTAINS = new XAUDIO2FX_REVERB_I3DL2_PARAMETERS { WetDryMix = 100, Room = -1000, RoomHF = -2500, RoomRolloffFactor = 0.0f, DecayTime = 1.49f, DecayHFRatio = 0.21f, Reflections = -2780, ReflectionsDelay = 0.300f, Reverb = -2014, ReverbDelay = 0.100f, Diffusion = 27.0f, Density = 100.0f, HFReference = 5000.0f };

        public static readonly XAUDIO2FX_REVERB_I3DL2_PARAMETERS XAUDIO2FX_I3DL2_PRESET_QUARRY = new XAUDIO2FX_REVERB_I3DL2_PARAMETERS { WetDryMix = 100, Room = -1000, RoomHF = -1000, RoomRolloffFactor = 0.0f, DecayTime = 1.49f, DecayHFRatio = 0.83f, Reflections = -10000, ReflectionsDelay = 0.061f, Reverb = 500, ReverbDelay = 0.025f, Diffusion = 100.0f, Density = 100.0f, HFReference = 5000.0f };

        public static readonly XAUDIO2FX_REVERB_I3DL2_PARAMETERS XAUDIO2FX_I3DL2_PRESET_PLAIN = new XAUDIO2FX_REVERB_I3DL2_PARAMETERS { WetDryMix = 100, Room = -1000, RoomHF = -2000, RoomRolloffFactor = 0.0f, DecayTime = 1.49f, DecayHFRatio = 0.50f, Reflections = -2466, ReflectionsDelay = 0.179f, Reverb = -2514, ReverbDelay = 0.100f, Diffusion = 21.0f, Density = 100.0f, HFReference = 5000.0f };

        public static readonly XAUDIO2FX_REVERB_I3DL2_PARAMETERS XAUDIO2FX_I3DL2_PRESET_PARKINGLOT = new XAUDIO2FX_REVERB_I3DL2_PARAMETERS { WetDryMix = 100, Room = -1000, RoomHF = 0, RoomRolloffFactor = 0.0f, DecayTime = 1.65f, DecayHFRatio = 1.50f, Reflections = -1363, ReflectionsDelay = 0.008f, Reverb = -1153, ReverbDelay = 0.012f, Diffusion = 100.0f, Density = 100.0f, HFReference = 5000.0f };

        public static readonly XAUDIO2FX_REVERB_I3DL2_PARAMETERS XAUDIO2FX_I3DL2_PRESET_SEWERPIPE = new XAUDIO2FX_REVERB_I3DL2_PARAMETERS { WetDryMix = 100, Room = -1000, RoomHF = -1000, RoomRolloffFactor = 0.0f, DecayTime = 2.81f, DecayHFRatio = 0.14f, Reflections = 429, ReflectionsDelay = 0.014f, Reverb = 648, ReverbDelay = 0.021f, Diffusion = 80.0f, Density = 60.0f, HFReference = 5000.0f };

        public static readonly XAUDIO2FX_REVERB_I3DL2_PARAMETERS XAUDIO2FX_I3DL2_PRESET_UNDERWATER = new XAUDIO2FX_REVERB_I3DL2_PARAMETERS { WetDryMix = 100, Room = -1000, RoomHF = -4000, RoomRolloffFactor = 0.0f, DecayTime = 1.49f, DecayHFRatio = 0.10f, Reflections = -449, ReflectionsDelay = 0.007f, Reverb = 1700, ReverbDelay = 0.011f, Diffusion = 100.0f, Density = 100.0f, HFReference = 5000.0f };

        public static readonly XAUDIO2FX_REVERB_I3DL2_PARAMETERS XAUDIO2FX_I3DL2_PRESET_SMALLROOM = new XAUDIO2FX_REVERB_I3DL2_PARAMETERS { WetDryMix = 100, Room = -1000, RoomHF = -600, RoomRolloffFactor = 0.0f, DecayTime = 1.10f, DecayHFRatio = 0.83f, Reflections = -400, ReflectionsDelay = 0.005f, Reverb = 500, ReverbDelay = 0.010f, Diffusion = 100.0f, Density = 100.0f, HFReference = 5000.0f };

        public static readonly XAUDIO2FX_REVERB_I3DL2_PARAMETERS XAUDIO2FX_I3DL2_PRESET_MEDIUMROOM = new XAUDIO2FX_REVERB_I3DL2_PARAMETERS { WetDryMix = 100, Room = -1000, RoomHF = -600, RoomRolloffFactor = 0.0f, DecayTime = 1.30f, DecayHFRatio = 0.83f, Reflections = -1000, ReflectionsDelay = 0.010f, Reverb = -200, ReverbDelay = 0.020f, Diffusion = 100.0f, Density = 100.0f, HFReference = 5000.0f };

        public static readonly XAUDIO2FX_REVERB_I3DL2_PARAMETERS XAUDIO2FX_I3DL2_PRESET_LARGEROOM = new XAUDIO2FX_REVERB_I3DL2_PARAMETERS { WetDryMix = 100, Room = -1000, RoomHF = -600, RoomRolloffFactor = 0.0f, DecayTime = 1.50f, DecayHFRatio = 0.83f, Reflections = -1600, ReflectionsDelay = 0.020f, Reverb = -1000, ReverbDelay = 0.040f, Diffusion = 100.0f, Density = 100.0f, HFReference = 5000.0f };

        public static readonly XAUDIO2FX_REVERB_I3DL2_PARAMETERS XAUDIO2FX_I3DL2_PRESET_MEDIUMHALL = new XAUDIO2FX_REVERB_I3DL2_PARAMETERS { WetDryMix = 100, Room = -1000, RoomHF = -600, RoomRolloffFactor = 0.0f, DecayTime = 1.80f, DecayHFRatio = 0.70f, Reflections = -1300, ReflectionsDelay = 0.015f, Reverb = -800, ReverbDelay = 0.030f, Diffusion = 100.0f, Density = 100.0f, HFReference = 5000.0f };

        public static readonly XAUDIO2FX_REVERB_I3DL2_PARAMETERS XAUDIO2FX_I3DL2_PRESET_LARGEHALL = new XAUDIO2FX_REVERB_I3DL2_PARAMETERS { WetDryMix = 100, Room = -1000, RoomHF = -600, RoomRolloffFactor = 0.0f, DecayTime = 1.80f, DecayHFRatio = 0.70f, Reflections = -2000, ReflectionsDelay = 0.030f, Reverb = -1400, ReverbDelay = 0.060f, Diffusion = 100.0f, Density = 100.0f, HFReference = 5000.0f };

        public static readonly XAUDIO2FX_REVERB_I3DL2_PARAMETERS XAUDIO2FX_I3DL2_PRESET_PLATE = new XAUDIO2FX_REVERB_I3DL2_PARAMETERS { WetDryMix = 100, Room = -1000, RoomHF = -200, RoomRolloffFactor = 0.0f, DecayTime = 1.30f, DecayHFRatio = 0.90f, Reflections = 0, ReflectionsDelay = 0.002f, Reverb = 0, ReverbDelay = 0.010f, Diffusion = 100.0f, Density = 75.0f, HFReference = 5000.0f };

        [return: NativeTypeName("HRESULT")]
        public static int XAudio2CreateVolumeMeter([NativeTypeName("IUnknown **")] IUnknown** ppApo, [NativeTypeName("UINT32")] uint Flags = 0)
        {
            return CreateAudioVolumeMeter(ppApo);
        }

        [return: NativeTypeName("HRESULT")]
        public static int XAudio2CreateReverb([NativeTypeName("IUnknown **")] IUnknown** ppApo, [NativeTypeName("UINT32")] uint Flags = 0)
        {
            return CreateAudioReverb(ppApo);
        }

        public static void ReverbConvertI3DL2ToNative([NativeTypeName("const XAUDIO2FX_REVERB_I3DL2_PARAMETERS *")] XAUDIO2FX_REVERB_I3DL2_PARAMETERS* pI3DL2, [NativeTypeName("XAUDIO2FX_REVERB_PARAMETERS *")] XAUDIO2FX_REVERB_PARAMETERS* pNative, [NativeTypeName("BOOL")] int sevenDotOneReverb = 1)
        {
            float reflectionsDelay;
            float reverbDelay;

            if (sevenDotOneReverb != 0)
            {
                pNative->RearDelay = 20;
            }
            else
            {
                pNative->RearDelay = 5;
            }

            pNative->SideDelay = 5;
            pNative->PositionLeft = 6;
            pNative->PositionRight = 6;
            pNative->PositionMatrixLeft = 27;
            pNative->PositionMatrixRight = 27;
            pNative->RoomSize = 100.0f;
            pNative->LowEQCutoff = 4;
            pNative->HighEQCutoff = 6;
            pNative->RoomFilterMain = (float)pI3DL2->Room / 100.0f;
            pNative->RoomFilterHF = (float)pI3DL2->RoomHF / 100.0f;

            if (pI3DL2->DecayHFRatio >= 1.0f)
            {
                int index = (int)(-4.0 * Math.Log10(pI3DL2->DecayHFRatio));

                if (index < -8)
                    index = -8;

                pNative->LowEQGain = (byte)((index < 0) ? index + 8 : 8);
                pNative->HighEQGain = 8;
                pNative->DecayTime = pI3DL2->DecayTime * pI3DL2->DecayHFRatio;
            }
            else
            {
                int index = (int)(4.0 * Math.Log10(pI3DL2->DecayHFRatio));

                if (index < -8)
                    index = -8;

                pNative->LowEQGain = 8;
                pNative->HighEQGain = (byte)((index < 0) ? index + 8 : 8);
                pNative->DecayTime = pI3DL2->DecayTime;
            }

            reflectionsDelay = pI3DL2->ReflectionsDelay * 1000.0f;
            if (reflectionsDelay >= 300)
            {
                reflectionsDelay = (float)(300 - 1);
            }
            else if (reflectionsDelay <= 1)
            {
                reflectionsDelay = 1;
            }

            pNative->ReflectionsDelay = (uint)reflectionsDelay;
            reverbDelay = pI3DL2->ReverbDelay * 1000.0f;
            if (reverbDelay >= 85)
            {
                reverbDelay = (float)(85 - 1);
            }

            pNative->ReverbDelay = (byte)reverbDelay;
            pNative->ReflectionsGain = pI3DL2->Reflections / 100.0f;
            pNative->ReverbGain = pI3DL2->Reverb / 100.0f;
            pNative->EarlyDiffusion = (byte)(15.0f * pI3DL2->Diffusion / 100.0f);
            pNative->LateDiffusion = pNative->EarlyDiffusion;
            pNative->Density = pI3DL2->Density;
            pNative->RoomFilterFreq = pI3DL2->HFReference;
            pNative->WetDryMix = pI3DL2->WetDryMix;
            pNative->DisableLateField = 0;
        }
    }
}
