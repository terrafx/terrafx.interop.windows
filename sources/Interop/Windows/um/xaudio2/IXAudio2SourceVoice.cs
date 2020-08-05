// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/xaudio2.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop
{
    [NativeTypeName("struct IXAudio2SourceVoice : IXAudio2Voice")]
    public unsafe partial struct IXAudio2SourceVoice
    {
        public void** lpVtbl;

        public void GetVoiceDetails([NativeTypeName("XAUDIO2_VOICE_DETAILS *")] XAUDIO2_VOICE_DETAILS* pVoiceDetails)
        {
            ((delegate* stdcall<IXAudio2SourceVoice*, XAUDIO2_VOICE_DETAILS*, void>)(lpVtbl[0]))((IXAudio2SourceVoice*)Unsafe.AsPointer(ref this), pVoiceDetails);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetOutputVoices([NativeTypeName("const XAUDIO2_VOICE_SENDS *")] XAUDIO2_VOICE_SENDS* pSendList)
        {
            return ((delegate* stdcall<IXAudio2SourceVoice*, XAUDIO2_VOICE_SENDS*, int>)(lpVtbl[1]))((IXAudio2SourceVoice*)Unsafe.AsPointer(ref this), pSendList);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetEffectChain([NativeTypeName("const XAUDIO2_EFFECT_CHAIN *")] XAUDIO2_EFFECT_CHAIN* pEffectChain)
        {
            return ((delegate* stdcall<IXAudio2SourceVoice*, XAUDIO2_EFFECT_CHAIN*, int>)(lpVtbl[2]))((IXAudio2SourceVoice*)Unsafe.AsPointer(ref this), pEffectChain);
        }

        [return: NativeTypeName("HRESULT")]
        public int EnableEffect([NativeTypeName("UINT32")] uint EffectIndex, [NativeTypeName("UINT32")] uint OperationSet = 0)
        {
            return ((delegate* stdcall<IXAudio2SourceVoice*, uint, uint, int>)(lpVtbl[3]))((IXAudio2SourceVoice*)Unsafe.AsPointer(ref this), EffectIndex, OperationSet);
        }

        [return: NativeTypeName("HRESULT")]
        public int DisableEffect([NativeTypeName("UINT32")] uint EffectIndex, [NativeTypeName("UINT32")] uint OperationSet = 0)
        {
            return ((delegate* stdcall<IXAudio2SourceVoice*, uint, uint, int>)(lpVtbl[4]))((IXAudio2SourceVoice*)Unsafe.AsPointer(ref this), EffectIndex, OperationSet);
        }

        public void GetEffectState([NativeTypeName("UINT32")] uint EffectIndex, [NativeTypeName("BOOL *")] int* pEnabled)
        {
            ((delegate* stdcall<IXAudio2SourceVoice*, uint, int*, void>)(lpVtbl[5]))((IXAudio2SourceVoice*)Unsafe.AsPointer(ref this), EffectIndex, pEnabled);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetEffectParameters([NativeTypeName("UINT32")] uint EffectIndex, [NativeTypeName("const void *")] void* pParameters, [NativeTypeName("UINT32")] uint ParametersByteSize, [NativeTypeName("UINT32")] uint OperationSet = 0)
        {
            return ((delegate* stdcall<IXAudio2SourceVoice*, uint, void*, uint, uint, int>)(lpVtbl[6]))((IXAudio2SourceVoice*)Unsafe.AsPointer(ref this), EffectIndex, pParameters, ParametersByteSize, OperationSet);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetEffectParameters([NativeTypeName("UINT32")] uint EffectIndex, [NativeTypeName("void *")] void* pParameters, [NativeTypeName("UINT32")] uint ParametersByteSize)
        {
            return ((delegate* stdcall<IXAudio2SourceVoice*, uint, void*, uint, int>)(lpVtbl[7]))((IXAudio2SourceVoice*)Unsafe.AsPointer(ref this), EffectIndex, pParameters, ParametersByteSize);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetFilterParameters([NativeTypeName("const XAUDIO2_FILTER_PARAMETERS *")] XAUDIO2_FILTER_PARAMETERS* pParameters, [NativeTypeName("UINT32")] uint OperationSet = 0)
        {
            return ((delegate* stdcall<IXAudio2SourceVoice*, XAUDIO2_FILTER_PARAMETERS*, uint, int>)(lpVtbl[8]))((IXAudio2SourceVoice*)Unsafe.AsPointer(ref this), pParameters, OperationSet);
        }

        public void GetFilterParameters([NativeTypeName("XAUDIO2_FILTER_PARAMETERS *")] XAUDIO2_FILTER_PARAMETERS* pParameters)
        {
            ((delegate* stdcall<IXAudio2SourceVoice*, XAUDIO2_FILTER_PARAMETERS*, void>)(lpVtbl[9]))((IXAudio2SourceVoice*)Unsafe.AsPointer(ref this), pParameters);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetOutputFilterParameters([NativeTypeName("IXAudio2Voice *")] IXAudio2Voice* pDestinationVoice, [NativeTypeName("const XAUDIO2_FILTER_PARAMETERS *")] XAUDIO2_FILTER_PARAMETERS* pParameters, [NativeTypeName("UINT32")] uint OperationSet = 0)
        {
            return ((delegate* stdcall<IXAudio2SourceVoice*, IXAudio2Voice*, XAUDIO2_FILTER_PARAMETERS*, uint, int>)(lpVtbl[10]))((IXAudio2SourceVoice*)Unsafe.AsPointer(ref this), pDestinationVoice, pParameters, OperationSet);
        }

        public void GetOutputFilterParameters([NativeTypeName("IXAudio2Voice *")] IXAudio2Voice* pDestinationVoice, [NativeTypeName("XAUDIO2_FILTER_PARAMETERS *")] XAUDIO2_FILTER_PARAMETERS* pParameters)
        {
            ((delegate* stdcall<IXAudio2SourceVoice*, IXAudio2Voice*, XAUDIO2_FILTER_PARAMETERS*, void>)(lpVtbl[11]))((IXAudio2SourceVoice*)Unsafe.AsPointer(ref this), pDestinationVoice, pParameters);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetVolume(float Volume, [NativeTypeName("UINT32")] uint OperationSet = 0)
        {
            return ((delegate* stdcall<IXAudio2SourceVoice*, float, uint, int>)(lpVtbl[12]))((IXAudio2SourceVoice*)Unsafe.AsPointer(ref this), Volume, OperationSet);
        }

        public void GetVolume([NativeTypeName("float *")] float* pVolume)
        {
            ((delegate* stdcall<IXAudio2SourceVoice*, float*, void>)(lpVtbl[13]))((IXAudio2SourceVoice*)Unsafe.AsPointer(ref this), pVolume);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetChannelVolumes([NativeTypeName("UINT32")] uint Channels, [NativeTypeName("const float *")] float* pVolumes, [NativeTypeName("UINT32")] uint OperationSet = 0)
        {
            return ((delegate* stdcall<IXAudio2SourceVoice*, uint, float*, uint, int>)(lpVtbl[14]))((IXAudio2SourceVoice*)Unsafe.AsPointer(ref this), Channels, pVolumes, OperationSet);
        }

        public void GetChannelVolumes([NativeTypeName("UINT32")] uint Channels, [NativeTypeName("float *")] float* pVolumes)
        {
            ((delegate* stdcall<IXAudio2SourceVoice*, uint, float*, void>)(lpVtbl[15]))((IXAudio2SourceVoice*)Unsafe.AsPointer(ref this), Channels, pVolumes);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetOutputMatrix([NativeTypeName("IXAudio2Voice *")] IXAudio2Voice* pDestinationVoice, [NativeTypeName("UINT32")] uint SourceChannels, [NativeTypeName("UINT32")] uint DestinationChannels, [NativeTypeName("const float *")] float* pLevelMatrix, [NativeTypeName("UINT32")] uint OperationSet = 0)
        {
            return ((delegate* stdcall<IXAudio2SourceVoice*, IXAudio2Voice*, uint, uint, float*, uint, int>)(lpVtbl[16]))((IXAudio2SourceVoice*)Unsafe.AsPointer(ref this), pDestinationVoice, SourceChannels, DestinationChannels, pLevelMatrix, OperationSet);
        }

        public void GetOutputMatrix([NativeTypeName("IXAudio2Voice *")] IXAudio2Voice* pDestinationVoice, [NativeTypeName("UINT32")] uint SourceChannels, [NativeTypeName("UINT32")] uint DestinationChannels, [NativeTypeName("float *")] float* pLevelMatrix)
        {
            ((delegate* stdcall<IXAudio2SourceVoice*, IXAudio2Voice*, uint, uint, float*, void>)(lpVtbl[17]))((IXAudio2SourceVoice*)Unsafe.AsPointer(ref this), pDestinationVoice, SourceChannels, DestinationChannels, pLevelMatrix);
        }

        public void DestroyVoice()
        {
            ((delegate* stdcall<IXAudio2SourceVoice*, void>)(lpVtbl[18]))((IXAudio2SourceVoice*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Start([NativeTypeName("UINT32")] uint Flags = 0, [NativeTypeName("UINT32")] uint OperationSet = 0)
        {
            return ((delegate* stdcall<IXAudio2SourceVoice*, uint, uint, int>)(lpVtbl[19]))((IXAudio2SourceVoice*)Unsafe.AsPointer(ref this), Flags, OperationSet);
        }

        [return: NativeTypeName("HRESULT")]
        public int Stop([NativeTypeName("UINT32")] uint Flags = 0, [NativeTypeName("UINT32")] uint OperationSet = 0)
        {
            return ((delegate* stdcall<IXAudio2SourceVoice*, uint, uint, int>)(lpVtbl[20]))((IXAudio2SourceVoice*)Unsafe.AsPointer(ref this), Flags, OperationSet);
        }

        [return: NativeTypeName("HRESULT")]
        public int SubmitSourceBuffer([NativeTypeName("const XAUDIO2_BUFFER *")] XAUDIO2_BUFFER* pBuffer, [NativeTypeName("const XAUDIO2_BUFFER_WMA *")] XAUDIO2_BUFFER_WMA* pBufferWMA = null)
        {
            return ((delegate* stdcall<IXAudio2SourceVoice*, XAUDIO2_BUFFER*, XAUDIO2_BUFFER_WMA*, int>)(lpVtbl[21]))((IXAudio2SourceVoice*)Unsafe.AsPointer(ref this), pBuffer, pBufferWMA);
        }

        [return: NativeTypeName("HRESULT")]
        public int FlushSourceBuffers()
        {
            return ((delegate* stdcall<IXAudio2SourceVoice*, int>)(lpVtbl[22]))((IXAudio2SourceVoice*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Discontinuity()
        {
            return ((delegate* stdcall<IXAudio2SourceVoice*, int>)(lpVtbl[23]))((IXAudio2SourceVoice*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int ExitLoop([NativeTypeName("UINT32")] uint OperationSet = 0)
        {
            return ((delegate* stdcall<IXAudio2SourceVoice*, uint, int>)(lpVtbl[24]))((IXAudio2SourceVoice*)Unsafe.AsPointer(ref this), OperationSet);
        }

        public void GetState([NativeTypeName("XAUDIO2_VOICE_STATE *")] XAUDIO2_VOICE_STATE* pVoiceState, [NativeTypeName("UINT32")] uint Flags = 0)
        {
            ((delegate* stdcall<IXAudio2SourceVoice*, XAUDIO2_VOICE_STATE*, uint, void>)(lpVtbl[25]))((IXAudio2SourceVoice*)Unsafe.AsPointer(ref this), pVoiceState, Flags);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetFrequencyRatio(float Ratio, [NativeTypeName("UINT32")] uint OperationSet = 0)
        {
            return ((delegate* stdcall<IXAudio2SourceVoice*, float, uint, int>)(lpVtbl[26]))((IXAudio2SourceVoice*)Unsafe.AsPointer(ref this), Ratio, OperationSet);
        }

        public void GetFrequencyRatio([NativeTypeName("float *")] float* pRatio)
        {
            ((delegate* stdcall<IXAudio2SourceVoice*, float*, void>)(lpVtbl[27]))((IXAudio2SourceVoice*)Unsafe.AsPointer(ref this), pRatio);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetSourceSampleRate([NativeTypeName("UINT32")] uint NewSourceSampleRate)
        {
            return ((delegate* stdcall<IXAudio2SourceVoice*, uint, int>)(lpVtbl[28]))((IXAudio2SourceVoice*)Unsafe.AsPointer(ref this), NewSourceSampleRate);
        }
    }
}
