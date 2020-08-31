// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/xaudio2.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop
{
    [NativeTypeName("struct IXAudio2SubmixVoice : IXAudio2Voice")]
    public unsafe partial struct IXAudio2SubmixVoice
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void GetVoiceDetails([NativeTypeName("XAUDIO2_VOICE_DETAILS *")] XAUDIO2_VOICE_DETAILS* pVoiceDetails)
        {
            ((delegate* stdcall<IXAudio2SubmixVoice*, XAUDIO2_VOICE_DETAILS*, void>)(lpVtbl[0]))((IXAudio2SubmixVoice*)Unsafe.AsPointer(ref this), pVoiceDetails);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetOutputVoices([NativeTypeName("const XAUDIO2_VOICE_SENDS *")] XAUDIO2_VOICE_SENDS* pSendList)
        {
            return ((delegate* stdcall<IXAudio2SubmixVoice*, XAUDIO2_VOICE_SENDS*, int>)(lpVtbl[1]))((IXAudio2SubmixVoice*)Unsafe.AsPointer(ref this), pSendList);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetEffectChain([NativeTypeName("const XAUDIO2_EFFECT_CHAIN *")] XAUDIO2_EFFECT_CHAIN* pEffectChain)
        {
            return ((delegate* stdcall<IXAudio2SubmixVoice*, XAUDIO2_EFFECT_CHAIN*, int>)(lpVtbl[2]))((IXAudio2SubmixVoice*)Unsafe.AsPointer(ref this), pEffectChain);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int EnableEffect([NativeTypeName("UINT32")] uint EffectIndex, [NativeTypeName("UINT32")] uint OperationSet = 0)
        {
            return ((delegate* stdcall<IXAudio2SubmixVoice*, uint, uint, int>)(lpVtbl[3]))((IXAudio2SubmixVoice*)Unsafe.AsPointer(ref this), EffectIndex, OperationSet);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int DisableEffect([NativeTypeName("UINT32")] uint EffectIndex, [NativeTypeName("UINT32")] uint OperationSet = 0)
        {
            return ((delegate* stdcall<IXAudio2SubmixVoice*, uint, uint, int>)(lpVtbl[4]))((IXAudio2SubmixVoice*)Unsafe.AsPointer(ref this), EffectIndex, OperationSet);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void GetEffectState([NativeTypeName("UINT32")] uint EffectIndex, [NativeTypeName("BOOL *")] int* pEnabled)
        {
            ((delegate* stdcall<IXAudio2SubmixVoice*, uint, int*, void>)(lpVtbl[5]))((IXAudio2SubmixVoice*)Unsafe.AsPointer(ref this), EffectIndex, pEnabled);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetEffectParameters([NativeTypeName("UINT32")] uint EffectIndex, [NativeTypeName("const void *")] void* pParameters, [NativeTypeName("UINT32")] uint ParametersByteSize, [NativeTypeName("UINT32")] uint OperationSet = 0)
        {
            return ((delegate* stdcall<IXAudio2SubmixVoice*, uint, void*, uint, uint, int>)(lpVtbl[6]))((IXAudio2SubmixVoice*)Unsafe.AsPointer(ref this), EffectIndex, pParameters, ParametersByteSize, OperationSet);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetEffectParameters([NativeTypeName("UINT32")] uint EffectIndex, [NativeTypeName("void *")] void* pParameters, [NativeTypeName("UINT32")] uint ParametersByteSize)
        {
            return ((delegate* stdcall<IXAudio2SubmixVoice*, uint, void*, uint, int>)(lpVtbl[7]))((IXAudio2SubmixVoice*)Unsafe.AsPointer(ref this), EffectIndex, pParameters, ParametersByteSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetFilterParameters([NativeTypeName("const XAUDIO2_FILTER_PARAMETERS *")] XAUDIO2_FILTER_PARAMETERS* pParameters, [NativeTypeName("UINT32")] uint OperationSet = 0)
        {
            return ((delegate* stdcall<IXAudio2SubmixVoice*, XAUDIO2_FILTER_PARAMETERS*, uint, int>)(lpVtbl[8]))((IXAudio2SubmixVoice*)Unsafe.AsPointer(ref this), pParameters, OperationSet);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void GetFilterParameters([NativeTypeName("XAUDIO2_FILTER_PARAMETERS *")] XAUDIO2_FILTER_PARAMETERS* pParameters)
        {
            ((delegate* stdcall<IXAudio2SubmixVoice*, XAUDIO2_FILTER_PARAMETERS*, void>)(lpVtbl[9]))((IXAudio2SubmixVoice*)Unsafe.AsPointer(ref this), pParameters);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetOutputFilterParameters([NativeTypeName("IXAudio2Voice *")] IXAudio2Voice* pDestinationVoice, [NativeTypeName("const XAUDIO2_FILTER_PARAMETERS *")] XAUDIO2_FILTER_PARAMETERS* pParameters, [NativeTypeName("UINT32")] uint OperationSet = 0)
        {
            return ((delegate* stdcall<IXAudio2SubmixVoice*, IXAudio2Voice*, XAUDIO2_FILTER_PARAMETERS*, uint, int>)(lpVtbl[10]))((IXAudio2SubmixVoice*)Unsafe.AsPointer(ref this), pDestinationVoice, pParameters, OperationSet);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void GetOutputFilterParameters([NativeTypeName("IXAudio2Voice *")] IXAudio2Voice* pDestinationVoice, [NativeTypeName("XAUDIO2_FILTER_PARAMETERS *")] XAUDIO2_FILTER_PARAMETERS* pParameters)
        {
            ((delegate* stdcall<IXAudio2SubmixVoice*, IXAudio2Voice*, XAUDIO2_FILTER_PARAMETERS*, void>)(lpVtbl[11]))((IXAudio2SubmixVoice*)Unsafe.AsPointer(ref this), pDestinationVoice, pParameters);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetVolume(float Volume, [NativeTypeName("UINT32")] uint OperationSet = 0)
        {
            return ((delegate* stdcall<IXAudio2SubmixVoice*, float, uint, int>)(lpVtbl[12]))((IXAudio2SubmixVoice*)Unsafe.AsPointer(ref this), Volume, OperationSet);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void GetVolume([NativeTypeName("float *")] float* pVolume)
        {
            ((delegate* stdcall<IXAudio2SubmixVoice*, float*, void>)(lpVtbl[13]))((IXAudio2SubmixVoice*)Unsafe.AsPointer(ref this), pVolume);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetChannelVolumes([NativeTypeName("UINT32")] uint Channels, [NativeTypeName("const float *")] float* pVolumes, [NativeTypeName("UINT32")] uint OperationSet = 0)
        {
            return ((delegate* stdcall<IXAudio2SubmixVoice*, uint, float*, uint, int>)(lpVtbl[14]))((IXAudio2SubmixVoice*)Unsafe.AsPointer(ref this), Channels, pVolumes, OperationSet);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void GetChannelVolumes([NativeTypeName("UINT32")] uint Channels, [NativeTypeName("float *")] float* pVolumes)
        {
            ((delegate* stdcall<IXAudio2SubmixVoice*, uint, float*, void>)(lpVtbl[15]))((IXAudio2SubmixVoice*)Unsafe.AsPointer(ref this), Channels, pVolumes);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetOutputMatrix([NativeTypeName("IXAudio2Voice *")] IXAudio2Voice* pDestinationVoice, [NativeTypeName("UINT32")] uint SourceChannels, [NativeTypeName("UINT32")] uint DestinationChannels, [NativeTypeName("const float *")] float* pLevelMatrix, [NativeTypeName("UINT32")] uint OperationSet = 0)
        {
            return ((delegate* stdcall<IXAudio2SubmixVoice*, IXAudio2Voice*, uint, uint, float*, uint, int>)(lpVtbl[16]))((IXAudio2SubmixVoice*)Unsafe.AsPointer(ref this), pDestinationVoice, SourceChannels, DestinationChannels, pLevelMatrix, OperationSet);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void GetOutputMatrix([NativeTypeName("IXAudio2Voice *")] IXAudio2Voice* pDestinationVoice, [NativeTypeName("UINT32")] uint SourceChannels, [NativeTypeName("UINT32")] uint DestinationChannels, [NativeTypeName("float *")] float* pLevelMatrix)
        {
            ((delegate* stdcall<IXAudio2SubmixVoice*, IXAudio2Voice*, uint, uint, float*, void>)(lpVtbl[17]))((IXAudio2SubmixVoice*)Unsafe.AsPointer(ref this), pDestinationVoice, SourceChannels, DestinationChannels, pLevelMatrix);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void DestroyVoice()
        {
            ((delegate* stdcall<IXAudio2SubmixVoice*, void>)(lpVtbl[18]))((IXAudio2SubmixVoice*)Unsafe.AsPointer(ref this));
        }
    }
}
