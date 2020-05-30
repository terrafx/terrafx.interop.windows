// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/xaudio2.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public unsafe partial struct IXAudio2SourceVoice
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _GetVoiceDetails(IXAudio2SourceVoice* pThis, [NativeTypeName("XAUDIO2_VOICE_DETAILS *")] XAUDIO2_VOICE_DETAILS* pVoiceDetails);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetOutputVoices(IXAudio2SourceVoice* pThis, [NativeTypeName("const XAUDIO2_VOICE_SENDS *")] XAUDIO2_VOICE_SENDS* pSendList);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetEffectChain(IXAudio2SourceVoice* pThis, [NativeTypeName("const XAUDIO2_EFFECT_CHAIN *")] XAUDIO2_EFFECT_CHAIN* pEffectChain);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _EnableEffect(IXAudio2SourceVoice* pThis, [NativeTypeName("UINT32")] uint EffectIndex, [NativeTypeName("UINT32")] uint OperationSet = 0);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _DisableEffect(IXAudio2SourceVoice* pThis, [NativeTypeName("UINT32")] uint EffectIndex, [NativeTypeName("UINT32")] uint OperationSet = 0);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _GetEffectState(IXAudio2SourceVoice* pThis, [NativeTypeName("UINT32")] uint EffectIndex, [NativeTypeName("BOOL *")] int* pEnabled);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetEffectParameters(IXAudio2SourceVoice* pThis, [NativeTypeName("UINT32")] uint EffectIndex, [NativeTypeName("const void *")] void* pParameters, [NativeTypeName("UINT32")] uint ParametersByteSize, [NativeTypeName("UINT32")] uint OperationSet = 0);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetEffectParameters(IXAudio2SourceVoice* pThis, [NativeTypeName("UINT32")] uint EffectIndex, [NativeTypeName("void *")] void* pParameters, [NativeTypeName("UINT32")] uint ParametersByteSize);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetFilterParameters(IXAudio2SourceVoice* pThis, [NativeTypeName("const XAUDIO2_FILTER_PARAMETERS *")] XAUDIO2_FILTER_PARAMETERS* pParameters, [NativeTypeName("UINT32")] uint OperationSet = 0);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _GetFilterParameters(IXAudio2SourceVoice* pThis, [NativeTypeName("XAUDIO2_FILTER_PARAMETERS *")] XAUDIO2_FILTER_PARAMETERS* pParameters);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetOutputFilterParameters(IXAudio2SourceVoice* pThis, [NativeTypeName("IXAudio2Voice *")] IXAudio2Voice* pDestinationVoice, [NativeTypeName("const XAUDIO2_FILTER_PARAMETERS *")] XAUDIO2_FILTER_PARAMETERS* pParameters, [NativeTypeName("UINT32")] uint OperationSet = 0);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _GetOutputFilterParameters(IXAudio2SourceVoice* pThis, [NativeTypeName("IXAudio2Voice *")] IXAudio2Voice* pDestinationVoice, [NativeTypeName("XAUDIO2_FILTER_PARAMETERS *")] XAUDIO2_FILTER_PARAMETERS* pParameters);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetVolume(IXAudio2SourceVoice* pThis, float Volume, [NativeTypeName("UINT32")] uint OperationSet = 0);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _GetVolume(IXAudio2SourceVoice* pThis, [NativeTypeName("float *")] float* pVolume);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetChannelVolumes(IXAudio2SourceVoice* pThis, [NativeTypeName("UINT32")] uint Channels, [NativeTypeName("const float *")] float* pVolumes, [NativeTypeName("UINT32")] uint OperationSet = 0);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _GetChannelVolumes(IXAudio2SourceVoice* pThis, [NativeTypeName("UINT32")] uint Channels, [NativeTypeName("float *")] float* pVolumes);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetOutputMatrix(IXAudio2SourceVoice* pThis, [NativeTypeName("IXAudio2Voice *")] IXAudio2Voice* pDestinationVoice, [NativeTypeName("UINT32")] uint SourceChannels, [NativeTypeName("UINT32")] uint DestinationChannels, [NativeTypeName("const float *")] float* pLevelMatrix, [NativeTypeName("UINT32")] uint OperationSet = 0);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _GetOutputMatrix(IXAudio2SourceVoice* pThis, [NativeTypeName("IXAudio2Voice *")] IXAudio2Voice* pDestinationVoice, [NativeTypeName("UINT32")] uint SourceChannels, [NativeTypeName("UINT32")] uint DestinationChannels, [NativeTypeName("float *")] float* pLevelMatrix);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _DestroyVoice(IXAudio2SourceVoice* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Start(IXAudio2SourceVoice* pThis, [NativeTypeName("UINT32")] uint Flags = 0, [NativeTypeName("UINT32")] uint OperationSet = 0);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Stop(IXAudio2SourceVoice* pThis, [NativeTypeName("UINT32")] uint Flags = 0, [NativeTypeName("UINT32")] uint OperationSet = 0);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SubmitSourceBuffer(IXAudio2SourceVoice* pThis, [NativeTypeName("const XAUDIO2_BUFFER *")] XAUDIO2_BUFFER* pBuffer, [NativeTypeName("const XAUDIO2_BUFFER_WMA *")] XAUDIO2_BUFFER_WMA* pBufferWMA = null);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _FlushSourceBuffers(IXAudio2SourceVoice* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Discontinuity(IXAudio2SourceVoice* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _ExitLoop(IXAudio2SourceVoice* pThis, [NativeTypeName("UINT32")] uint OperationSet = 0);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _GetState(IXAudio2SourceVoice* pThis, [NativeTypeName("XAUDIO2_VOICE_STATE *")] XAUDIO2_VOICE_STATE* pVoiceState, [NativeTypeName("UINT32")] uint Flags = 0);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetFrequencyRatio(IXAudio2SourceVoice* pThis, float Ratio, [NativeTypeName("UINT32")] uint OperationSet = 0);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _GetFrequencyRatio(IXAudio2SourceVoice* pThis, [NativeTypeName("float *")] float* pRatio);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetSourceSampleRate(IXAudio2SourceVoice* pThis, [NativeTypeName("UINT32")] uint NewSourceSampleRate);

        public void GetVoiceDetails([NativeTypeName("XAUDIO2_VOICE_DETAILS *")] XAUDIO2_VOICE_DETAILS* pVoiceDetails)
        {
            Marshal.GetDelegateForFunctionPointer<_GetVoiceDetails>(lpVtbl->GetVoiceDetails)((IXAudio2SourceVoice*)Unsafe.AsPointer(ref this), pVoiceDetails);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetOutputVoices([NativeTypeName("const XAUDIO2_VOICE_SENDS *")] XAUDIO2_VOICE_SENDS* pSendList)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetOutputVoices>(lpVtbl->SetOutputVoices)((IXAudio2SourceVoice*)Unsafe.AsPointer(ref this), pSendList);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetEffectChain([NativeTypeName("const XAUDIO2_EFFECT_CHAIN *")] XAUDIO2_EFFECT_CHAIN* pEffectChain)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetEffectChain>(lpVtbl->SetEffectChain)((IXAudio2SourceVoice*)Unsafe.AsPointer(ref this), pEffectChain);
        }

        [return: NativeTypeName("HRESULT")]
        public int EnableEffect([NativeTypeName("UINT32")] uint EffectIndex, [NativeTypeName("UINT32")] uint OperationSet = 0)
        {
            return Marshal.GetDelegateForFunctionPointer<_EnableEffect>(lpVtbl->EnableEffect)((IXAudio2SourceVoice*)Unsafe.AsPointer(ref this), EffectIndex, OperationSet);
        }

        [return: NativeTypeName("HRESULT")]
        public int DisableEffect([NativeTypeName("UINT32")] uint EffectIndex, [NativeTypeName("UINT32")] uint OperationSet = 0)
        {
            return Marshal.GetDelegateForFunctionPointer<_DisableEffect>(lpVtbl->DisableEffect)((IXAudio2SourceVoice*)Unsafe.AsPointer(ref this), EffectIndex, OperationSet);
        }

        public void GetEffectState([NativeTypeName("UINT32")] uint EffectIndex, [NativeTypeName("BOOL *")] int* pEnabled)
        {
            Marshal.GetDelegateForFunctionPointer<_GetEffectState>(lpVtbl->GetEffectState)((IXAudio2SourceVoice*)Unsafe.AsPointer(ref this), EffectIndex, pEnabled);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetEffectParameters([NativeTypeName("UINT32")] uint EffectIndex, [NativeTypeName("const void *")] void* pParameters, [NativeTypeName("UINT32")] uint ParametersByteSize, [NativeTypeName("UINT32")] uint OperationSet = 0)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetEffectParameters>(lpVtbl->SetEffectParameters)((IXAudio2SourceVoice*)Unsafe.AsPointer(ref this), EffectIndex, pParameters, ParametersByteSize, OperationSet);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetEffectParameters([NativeTypeName("UINT32")] uint EffectIndex, [NativeTypeName("void *")] void* pParameters, [NativeTypeName("UINT32")] uint ParametersByteSize)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetEffectParameters>(lpVtbl->GetEffectParameters)((IXAudio2SourceVoice*)Unsafe.AsPointer(ref this), EffectIndex, pParameters, ParametersByteSize);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetFilterParameters([NativeTypeName("const XAUDIO2_FILTER_PARAMETERS *")] XAUDIO2_FILTER_PARAMETERS* pParameters, [NativeTypeName("UINT32")] uint OperationSet = 0)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetFilterParameters>(lpVtbl->SetFilterParameters)((IXAudio2SourceVoice*)Unsafe.AsPointer(ref this), pParameters, OperationSet);
        }

        public void GetFilterParameters([NativeTypeName("XAUDIO2_FILTER_PARAMETERS *")] XAUDIO2_FILTER_PARAMETERS* pParameters)
        {
            Marshal.GetDelegateForFunctionPointer<_GetFilterParameters>(lpVtbl->GetFilterParameters)((IXAudio2SourceVoice*)Unsafe.AsPointer(ref this), pParameters);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetOutputFilterParameters([NativeTypeName("IXAudio2Voice *")] IXAudio2Voice* pDestinationVoice, [NativeTypeName("const XAUDIO2_FILTER_PARAMETERS *")] XAUDIO2_FILTER_PARAMETERS* pParameters, [NativeTypeName("UINT32")] uint OperationSet = 0)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetOutputFilterParameters>(lpVtbl->SetOutputFilterParameters)((IXAudio2SourceVoice*)Unsafe.AsPointer(ref this), pDestinationVoice, pParameters, OperationSet);
        }

        public void GetOutputFilterParameters([NativeTypeName("IXAudio2Voice *")] IXAudio2Voice* pDestinationVoice, [NativeTypeName("XAUDIO2_FILTER_PARAMETERS *")] XAUDIO2_FILTER_PARAMETERS* pParameters)
        {
            Marshal.GetDelegateForFunctionPointer<_GetOutputFilterParameters>(lpVtbl->GetOutputFilterParameters)((IXAudio2SourceVoice*)Unsafe.AsPointer(ref this), pDestinationVoice, pParameters);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetVolume(float Volume, [NativeTypeName("UINT32")] uint OperationSet = 0)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetVolume>(lpVtbl->SetVolume)((IXAudio2SourceVoice*)Unsafe.AsPointer(ref this), Volume, OperationSet);
        }

        public void GetVolume([NativeTypeName("float *")] float* pVolume)
        {
            Marshal.GetDelegateForFunctionPointer<_GetVolume>(lpVtbl->GetVolume)((IXAudio2SourceVoice*)Unsafe.AsPointer(ref this), pVolume);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetChannelVolumes([NativeTypeName("UINT32")] uint Channels, [NativeTypeName("const float *")] float* pVolumes, [NativeTypeName("UINT32")] uint OperationSet = 0)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetChannelVolumes>(lpVtbl->SetChannelVolumes)((IXAudio2SourceVoice*)Unsafe.AsPointer(ref this), Channels, pVolumes, OperationSet);
        }

        public void GetChannelVolumes([NativeTypeName("UINT32")] uint Channels, [NativeTypeName("float *")] float* pVolumes)
        {
            Marshal.GetDelegateForFunctionPointer<_GetChannelVolumes>(lpVtbl->GetChannelVolumes)((IXAudio2SourceVoice*)Unsafe.AsPointer(ref this), Channels, pVolumes);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetOutputMatrix([NativeTypeName("IXAudio2Voice *")] IXAudio2Voice* pDestinationVoice, [NativeTypeName("UINT32")] uint SourceChannels, [NativeTypeName("UINT32")] uint DestinationChannels, [NativeTypeName("const float *")] float* pLevelMatrix, [NativeTypeName("UINT32")] uint OperationSet = 0)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetOutputMatrix>(lpVtbl->SetOutputMatrix)((IXAudio2SourceVoice*)Unsafe.AsPointer(ref this), pDestinationVoice, SourceChannels, DestinationChannels, pLevelMatrix, OperationSet);
        }

        public void GetOutputMatrix([NativeTypeName("IXAudio2Voice *")] IXAudio2Voice* pDestinationVoice, [NativeTypeName("UINT32")] uint SourceChannels, [NativeTypeName("UINT32")] uint DestinationChannels, [NativeTypeName("float *")] float* pLevelMatrix)
        {
            Marshal.GetDelegateForFunctionPointer<_GetOutputMatrix>(lpVtbl->GetOutputMatrix)((IXAudio2SourceVoice*)Unsafe.AsPointer(ref this), pDestinationVoice, SourceChannels, DestinationChannels, pLevelMatrix);
        }

        public void DestroyVoice()
        {
            Marshal.GetDelegateForFunctionPointer<_DestroyVoice>(lpVtbl->DestroyVoice)((IXAudio2SourceVoice*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Start([NativeTypeName("UINT32")] uint Flags = 0, [NativeTypeName("UINT32")] uint OperationSet = 0)
        {
            return Marshal.GetDelegateForFunctionPointer<_Start>(lpVtbl->Start)((IXAudio2SourceVoice*)Unsafe.AsPointer(ref this), Flags, OperationSet);
        }

        [return: NativeTypeName("HRESULT")]
        public int Stop([NativeTypeName("UINT32")] uint Flags = 0, [NativeTypeName("UINT32")] uint OperationSet = 0)
        {
            return Marshal.GetDelegateForFunctionPointer<_Stop>(lpVtbl->Stop)((IXAudio2SourceVoice*)Unsafe.AsPointer(ref this), Flags, OperationSet);
        }

        [return: NativeTypeName("HRESULT")]
        public int SubmitSourceBuffer([NativeTypeName("const XAUDIO2_BUFFER *")] XAUDIO2_BUFFER* pBuffer, [NativeTypeName("const XAUDIO2_BUFFER_WMA *")] XAUDIO2_BUFFER_WMA* pBufferWMA = null)
        {
            return Marshal.GetDelegateForFunctionPointer<_SubmitSourceBuffer>(lpVtbl->SubmitSourceBuffer)((IXAudio2SourceVoice*)Unsafe.AsPointer(ref this), pBuffer, pBufferWMA);
        }

        [return: NativeTypeName("HRESULT")]
        public int FlushSourceBuffers()
        {
            return Marshal.GetDelegateForFunctionPointer<_FlushSourceBuffers>(lpVtbl->FlushSourceBuffers)((IXAudio2SourceVoice*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Discontinuity()
        {
            return Marshal.GetDelegateForFunctionPointer<_Discontinuity>(lpVtbl->Discontinuity)((IXAudio2SourceVoice*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int ExitLoop([NativeTypeName("UINT32")] uint OperationSet = 0)
        {
            return Marshal.GetDelegateForFunctionPointer<_ExitLoop>(lpVtbl->ExitLoop)((IXAudio2SourceVoice*)Unsafe.AsPointer(ref this), OperationSet);
        }

        public void GetState([NativeTypeName("XAUDIO2_VOICE_STATE *")] XAUDIO2_VOICE_STATE* pVoiceState, [NativeTypeName("UINT32")] uint Flags = 0)
        {
            Marshal.GetDelegateForFunctionPointer<_GetState>(lpVtbl->GetState)((IXAudio2SourceVoice*)Unsafe.AsPointer(ref this), pVoiceState, Flags);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetFrequencyRatio(float Ratio, [NativeTypeName("UINT32")] uint OperationSet = 0)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetFrequencyRatio>(lpVtbl->SetFrequencyRatio)((IXAudio2SourceVoice*)Unsafe.AsPointer(ref this), Ratio, OperationSet);
        }

        public void GetFrequencyRatio([NativeTypeName("float *")] float* pRatio)
        {
            Marshal.GetDelegateForFunctionPointer<_GetFrequencyRatio>(lpVtbl->GetFrequencyRatio)((IXAudio2SourceVoice*)Unsafe.AsPointer(ref this), pRatio);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetSourceSampleRate([NativeTypeName("UINT32")] uint NewSourceSampleRate)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetSourceSampleRate>(lpVtbl->SetSourceSampleRate)((IXAudio2SourceVoice*)Unsafe.AsPointer(ref this), NewSourceSampleRate);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("void (XAUDIO2_VOICE_DETAILS *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetVoiceDetails;

            [NativeTypeName("HRESULT (const XAUDIO2_VOICE_SENDS *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetOutputVoices;

            [NativeTypeName("HRESULT (const XAUDIO2_EFFECT_CHAIN *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetEffectChain;

            [NativeTypeName("HRESULT (UINT32, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr EnableEffect;

            [NativeTypeName("HRESULT (UINT32, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr DisableEffect;

            [NativeTypeName("void (UINT32, BOOL *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetEffectState;

            [NativeTypeName("HRESULT (UINT32, const void *, UINT32, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetEffectParameters;

            [NativeTypeName("HRESULT (UINT32, void *, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetEffectParameters;

            [NativeTypeName("HRESULT (const XAUDIO2_FILTER_PARAMETERS *, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetFilterParameters;

            [NativeTypeName("void (XAUDIO2_FILTER_PARAMETERS *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetFilterParameters;

            [NativeTypeName("HRESULT (IXAudio2Voice *, const XAUDIO2_FILTER_PARAMETERS *, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetOutputFilterParameters;

            [NativeTypeName("void (IXAudio2Voice *, XAUDIO2_FILTER_PARAMETERS *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetOutputFilterParameters;

            [NativeTypeName("HRESULT (float, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetVolume;

            [NativeTypeName("void (float *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetVolume;

            [NativeTypeName("HRESULT (UINT32, const float *, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetChannelVolumes;

            [NativeTypeName("void (UINT32, float *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetChannelVolumes;

            [NativeTypeName("HRESULT (IXAudio2Voice *, UINT32, UINT32, const float *, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetOutputMatrix;

            [NativeTypeName("void (IXAudio2Voice *, UINT32, UINT32, float *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetOutputMatrix;

            [NativeTypeName("void () __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr DestroyVoice;

            [NativeTypeName("HRESULT (UINT32, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr Start;

            [NativeTypeName("HRESULT (UINT32, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr Stop;

            [NativeTypeName("HRESULT (const XAUDIO2_BUFFER *, const XAUDIO2_BUFFER_WMA *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SubmitSourceBuffer;

            [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr FlushSourceBuffers;

            [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr Discontinuity;

            [NativeTypeName("HRESULT (UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr ExitLoop;

            [NativeTypeName("void (XAUDIO2_VOICE_STATE *, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetState;

            [NativeTypeName("HRESULT (float, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetFrequencyRatio;

            [NativeTypeName("void (float *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetFrequencyRatio;

            [NativeTypeName("HRESULT (UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetSourceSampleRate;
        }
    }
}
