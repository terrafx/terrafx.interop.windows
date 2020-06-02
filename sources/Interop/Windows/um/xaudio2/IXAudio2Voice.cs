// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/xaudio2.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public unsafe partial struct IXAudio2Voice
    {
        public Vtbl* lpVtbl;

        public void GetVoiceDetails([NativeTypeName("XAUDIO2_VOICE_DETAILS *")] XAUDIO2_VOICE_DETAILS* pVoiceDetails)
        {
            lpVtbl->GetVoiceDetails((IXAudio2Voice*)Unsafe.AsPointer(ref this), pVoiceDetails);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetOutputVoices([NativeTypeName("const XAUDIO2_VOICE_SENDS *")] XAUDIO2_VOICE_SENDS* pSendList)
        {
            return lpVtbl->SetOutputVoices((IXAudio2Voice*)Unsafe.AsPointer(ref this), pSendList);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetEffectChain([NativeTypeName("const XAUDIO2_EFFECT_CHAIN *")] XAUDIO2_EFFECT_CHAIN* pEffectChain)
        {
            return lpVtbl->SetEffectChain((IXAudio2Voice*)Unsafe.AsPointer(ref this), pEffectChain);
        }

        [return: NativeTypeName("HRESULT")]
        public int EnableEffect([NativeTypeName("UINT32")] uint EffectIndex, [NativeTypeName("UINT32")] uint OperationSet = 0)
        {
            return lpVtbl->EnableEffect((IXAudio2Voice*)Unsafe.AsPointer(ref this), EffectIndex, OperationSet);
        }

        [return: NativeTypeName("HRESULT")]
        public int DisableEffect([NativeTypeName("UINT32")] uint EffectIndex, [NativeTypeName("UINT32")] uint OperationSet = 0)
        {
            return lpVtbl->DisableEffect((IXAudio2Voice*)Unsafe.AsPointer(ref this), EffectIndex, OperationSet);
        }

        public void GetEffectState([NativeTypeName("UINT32")] uint EffectIndex, [NativeTypeName("BOOL *")] int* pEnabled)
        {
            lpVtbl->GetEffectState((IXAudio2Voice*)Unsafe.AsPointer(ref this), EffectIndex, pEnabled);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetEffectParameters([NativeTypeName("UINT32")] uint EffectIndex, [NativeTypeName("const void *")] void* pParameters, [NativeTypeName("UINT32")] uint ParametersByteSize, [NativeTypeName("UINT32")] uint OperationSet = 0)
        {
            return lpVtbl->SetEffectParameters((IXAudio2Voice*)Unsafe.AsPointer(ref this), EffectIndex, pParameters, ParametersByteSize, OperationSet);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetEffectParameters([NativeTypeName("UINT32")] uint EffectIndex, [NativeTypeName("void *")] void* pParameters, [NativeTypeName("UINT32")] uint ParametersByteSize)
        {
            return lpVtbl->GetEffectParameters((IXAudio2Voice*)Unsafe.AsPointer(ref this), EffectIndex, pParameters, ParametersByteSize);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetFilterParameters([NativeTypeName("const XAUDIO2_FILTER_PARAMETERS *")] XAUDIO2_FILTER_PARAMETERS* pParameters, [NativeTypeName("UINT32")] uint OperationSet = 0)
        {
            return lpVtbl->SetFilterParameters((IXAudio2Voice*)Unsafe.AsPointer(ref this), pParameters, OperationSet);
        }

        public void GetFilterParameters([NativeTypeName("XAUDIO2_FILTER_PARAMETERS *")] XAUDIO2_FILTER_PARAMETERS* pParameters)
        {
            lpVtbl->GetFilterParameters((IXAudio2Voice*)Unsafe.AsPointer(ref this), pParameters);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetOutputFilterParameters([NativeTypeName("IXAudio2Voice *")] IXAudio2Voice* pDestinationVoice, [NativeTypeName("const XAUDIO2_FILTER_PARAMETERS *")] XAUDIO2_FILTER_PARAMETERS* pParameters, [NativeTypeName("UINT32")] uint OperationSet = 0)
        {
            return lpVtbl->SetOutputFilterParameters((IXAudio2Voice*)Unsafe.AsPointer(ref this), pDestinationVoice, pParameters, OperationSet);
        }

        public void GetOutputFilterParameters([NativeTypeName("IXAudio2Voice *")] IXAudio2Voice* pDestinationVoice, [NativeTypeName("XAUDIO2_FILTER_PARAMETERS *")] XAUDIO2_FILTER_PARAMETERS* pParameters)
        {
            lpVtbl->GetOutputFilterParameters((IXAudio2Voice*)Unsafe.AsPointer(ref this), pDestinationVoice, pParameters);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetVolume(float Volume, [NativeTypeName("UINT32")] uint OperationSet = 0)
        {
            return lpVtbl->SetVolume((IXAudio2Voice*)Unsafe.AsPointer(ref this), Volume, OperationSet);
        }

        public void GetVolume([NativeTypeName("float *")] float* pVolume)
        {
            lpVtbl->GetVolume((IXAudio2Voice*)Unsafe.AsPointer(ref this), pVolume);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetChannelVolumes([NativeTypeName("UINT32")] uint Channels, [NativeTypeName("const float *")] float* pVolumes, [NativeTypeName("UINT32")] uint OperationSet = 0)
        {
            return lpVtbl->SetChannelVolumes((IXAudio2Voice*)Unsafe.AsPointer(ref this), Channels, pVolumes, OperationSet);
        }

        public void GetChannelVolumes([NativeTypeName("UINT32")] uint Channels, [NativeTypeName("float *")] float* pVolumes)
        {
            lpVtbl->GetChannelVolumes((IXAudio2Voice*)Unsafe.AsPointer(ref this), Channels, pVolumes);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetOutputMatrix([NativeTypeName("IXAudio2Voice *")] IXAudio2Voice* pDestinationVoice, [NativeTypeName("UINT32")] uint SourceChannels, [NativeTypeName("UINT32")] uint DestinationChannels, [NativeTypeName("const float *")] float* pLevelMatrix, [NativeTypeName("UINT32")] uint OperationSet = 0)
        {
            return lpVtbl->SetOutputMatrix((IXAudio2Voice*)Unsafe.AsPointer(ref this), pDestinationVoice, SourceChannels, DestinationChannels, pLevelMatrix, OperationSet);
        }

        public void GetOutputMatrix([NativeTypeName("IXAudio2Voice *")] IXAudio2Voice* pDestinationVoice, [NativeTypeName("UINT32")] uint SourceChannels, [NativeTypeName("UINT32")] uint DestinationChannels, [NativeTypeName("float *")] float* pLevelMatrix)
        {
            lpVtbl->GetOutputMatrix((IXAudio2Voice*)Unsafe.AsPointer(ref this), pDestinationVoice, SourceChannels, DestinationChannels, pLevelMatrix);
        }

        public void DestroyVoice()
        {
            lpVtbl->DestroyVoice((IXAudio2Voice*)Unsafe.AsPointer(ref this));
        }

        public partial struct Vtbl
        {
            [NativeTypeName("void (XAUDIO2_VOICE_DETAILS *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IXAudio2Voice*, XAUDIO2_VOICE_DETAILS*, void> GetVoiceDetails;

            [NativeTypeName("HRESULT (const XAUDIO2_VOICE_SENDS *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IXAudio2Voice*, XAUDIO2_VOICE_SENDS*, int> SetOutputVoices;

            [NativeTypeName("HRESULT (const XAUDIO2_EFFECT_CHAIN *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IXAudio2Voice*, XAUDIO2_EFFECT_CHAIN*, int> SetEffectChain;

            [NativeTypeName("HRESULT (UINT32, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IXAudio2Voice*, uint, uint, int> EnableEffect;

            [NativeTypeName("HRESULT (UINT32, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IXAudio2Voice*, uint, uint, int> DisableEffect;

            [NativeTypeName("void (UINT32, BOOL *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IXAudio2Voice*, uint, int*, void> GetEffectState;

            [NativeTypeName("HRESULT (UINT32, const void *, UINT32, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IXAudio2Voice*, uint, void*, uint, uint, int> SetEffectParameters;

            [NativeTypeName("HRESULT (UINT32, void *, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IXAudio2Voice*, uint, void*, uint, int> GetEffectParameters;

            [NativeTypeName("HRESULT (const XAUDIO2_FILTER_PARAMETERS *, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IXAudio2Voice*, XAUDIO2_FILTER_PARAMETERS*, uint, int> SetFilterParameters;

            [NativeTypeName("void (XAUDIO2_FILTER_PARAMETERS *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IXAudio2Voice*, XAUDIO2_FILTER_PARAMETERS*, void> GetFilterParameters;

            [NativeTypeName("HRESULT (IXAudio2Voice *, const XAUDIO2_FILTER_PARAMETERS *, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IXAudio2Voice*, IXAudio2Voice*, XAUDIO2_FILTER_PARAMETERS*, uint, int> SetOutputFilterParameters;

            [NativeTypeName("void (IXAudio2Voice *, XAUDIO2_FILTER_PARAMETERS *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IXAudio2Voice*, IXAudio2Voice*, XAUDIO2_FILTER_PARAMETERS*, void> GetOutputFilterParameters;

            [NativeTypeName("HRESULT (float, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IXAudio2Voice*, float, uint, int> SetVolume;

            [NativeTypeName("void (float *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IXAudio2Voice*, float*, void> GetVolume;

            [NativeTypeName("HRESULT (UINT32, const float *, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IXAudio2Voice*, uint, float*, uint, int> SetChannelVolumes;

            [NativeTypeName("void (UINT32, float *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IXAudio2Voice*, uint, float*, void> GetChannelVolumes;

            [NativeTypeName("HRESULT (IXAudio2Voice *, UINT32, UINT32, const float *, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IXAudio2Voice*, IXAudio2Voice*, uint, uint, float*, uint, int> SetOutputMatrix;

            [NativeTypeName("void (IXAudio2Voice *, UINT32, UINT32, float *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IXAudio2Voice*, IXAudio2Voice*, uint, uint, float*, void> GetOutputMatrix;

            [NativeTypeName("void () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IXAudio2Voice*, void> DestroyVoice;
        }
    }
}
