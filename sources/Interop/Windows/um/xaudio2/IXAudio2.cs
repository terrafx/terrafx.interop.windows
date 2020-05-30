// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/xaudio2.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.AUDIO_STREAM_CATEGORY;

namespace TerraFX.Interop
{
    [Guid("2B02E3CF-2E0B-4ec3-BE45-1B2A3FE7210D")]
    public unsafe partial struct IXAudio2
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IXAudio2* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IXAudio2* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IXAudio2* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _RegisterForCallbacks(IXAudio2* pThis, [NativeTypeName("IXAudio2EngineCallback *")] IXAudio2EngineCallback* pCallback);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _UnregisterForCallbacks(IXAudio2* pThis, [NativeTypeName("IXAudio2EngineCallback *")] IXAudio2EngineCallback* pCallback);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateSourceVoice(IXAudio2* pThis, [NativeTypeName("IXAudio2SourceVoice **")] IXAudio2SourceVoice** ppSourceVoice, [NativeTypeName("const WAVEFORMATEX *")] WAVEFORMATEX* pSourceFormat, [NativeTypeName("UINT32")] uint Flags = 0, float MaxFrequencyRatio = 2.0f, [NativeTypeName("IXAudio2VoiceCallback *")] IXAudio2VoiceCallback* pCallback = null, [NativeTypeName("const XAUDIO2_VOICE_SENDS *")] XAUDIO2_VOICE_SENDS* pSendList = null, [NativeTypeName("const XAUDIO2_EFFECT_CHAIN *")] XAUDIO2_EFFECT_CHAIN* pEffectChain = null);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateSubmixVoice(IXAudio2* pThis, [NativeTypeName("IXAudio2SubmixVoice **")] IXAudio2SubmixVoice** ppSubmixVoice, [NativeTypeName("UINT32")] uint InputChannels, [NativeTypeName("UINT32")] uint InputSampleRate, [NativeTypeName("UINT32")] uint Flags = 0, [NativeTypeName("UINT32")] uint ProcessingStage = 0, [NativeTypeName("const XAUDIO2_VOICE_SENDS *")] XAUDIO2_VOICE_SENDS* pSendList = null, [NativeTypeName("const XAUDIO2_EFFECT_CHAIN *")] XAUDIO2_EFFECT_CHAIN* pEffectChain = null);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateMasteringVoice(IXAudio2* pThis, [NativeTypeName("IXAudio2MasteringVoice **")] IXAudio2MasteringVoice** ppMasteringVoice, [NativeTypeName("UINT32")] uint InputChannels = 0, [NativeTypeName("UINT32")] uint InputSampleRate = 0, [NativeTypeName("UINT32")] uint Flags = 0, [NativeTypeName("LPCWSTR")] ushort* szDeviceId = null, [NativeTypeName("const XAUDIO2_EFFECT_CHAIN *")] XAUDIO2_EFFECT_CHAIN* pEffectChain = null, AUDIO_STREAM_CATEGORY StreamCategory = AudioCategory_GameEffects);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _StartEngine(IXAudio2* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _StopEngine(IXAudio2* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CommitChanges(IXAudio2* pThis, [NativeTypeName("UINT32")] uint OperationSet);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _GetPerformanceData(IXAudio2* pThis, [NativeTypeName("XAUDIO2_PERFORMANCE_DATA *")] XAUDIO2_PERFORMANCE_DATA* pPerfData);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _SetDebugConfiguration(IXAudio2* pThis, [NativeTypeName("const XAUDIO2_DEBUG_CONFIGURATION *")] XAUDIO2_DEBUG_CONFIGURATION* pDebugConfiguration, [NativeTypeName("void *")] void* pReserved = null);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IXAudio2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IXAudio2*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IXAudio2*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int RegisterForCallbacks([NativeTypeName("IXAudio2EngineCallback *")] IXAudio2EngineCallback* pCallback)
        {
            return Marshal.GetDelegateForFunctionPointer<_RegisterForCallbacks>(lpVtbl->RegisterForCallbacks)((IXAudio2*)Unsafe.AsPointer(ref this), pCallback);
        }

        public void UnregisterForCallbacks([NativeTypeName("IXAudio2EngineCallback *")] IXAudio2EngineCallback* pCallback)
        {
            Marshal.GetDelegateForFunctionPointer<_UnregisterForCallbacks>(lpVtbl->UnregisterForCallbacks)((IXAudio2*)Unsafe.AsPointer(ref this), pCallback);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateSourceVoice([NativeTypeName("IXAudio2SourceVoice **")] IXAudio2SourceVoice** ppSourceVoice, [NativeTypeName("const WAVEFORMATEX *")] WAVEFORMATEX* pSourceFormat, [NativeTypeName("UINT32")] uint Flags = 0, float MaxFrequencyRatio = 2.0f, [NativeTypeName("IXAudio2VoiceCallback *")] IXAudio2VoiceCallback* pCallback = null, [NativeTypeName("const XAUDIO2_VOICE_SENDS *")] XAUDIO2_VOICE_SENDS* pSendList = null, [NativeTypeName("const XAUDIO2_EFFECT_CHAIN *")] XAUDIO2_EFFECT_CHAIN* pEffectChain = null)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateSourceVoice>(lpVtbl->CreateSourceVoice)((IXAudio2*)Unsafe.AsPointer(ref this), ppSourceVoice, pSourceFormat, Flags, MaxFrequencyRatio, pCallback, pSendList, pEffectChain);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateSubmixVoice([NativeTypeName("IXAudio2SubmixVoice **")] IXAudio2SubmixVoice** ppSubmixVoice, [NativeTypeName("UINT32")] uint InputChannels, [NativeTypeName("UINT32")] uint InputSampleRate, [NativeTypeName("UINT32")] uint Flags = 0, [NativeTypeName("UINT32")] uint ProcessingStage = 0, [NativeTypeName("const XAUDIO2_VOICE_SENDS *")] XAUDIO2_VOICE_SENDS* pSendList = null, [NativeTypeName("const XAUDIO2_EFFECT_CHAIN *")] XAUDIO2_EFFECT_CHAIN* pEffectChain = null)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateSubmixVoice>(lpVtbl->CreateSubmixVoice)((IXAudio2*)Unsafe.AsPointer(ref this), ppSubmixVoice, InputChannels, InputSampleRate, Flags, ProcessingStage, pSendList, pEffectChain);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateMasteringVoice([NativeTypeName("IXAudio2MasteringVoice **")] IXAudio2MasteringVoice** ppMasteringVoice, [NativeTypeName("UINT32")] uint InputChannels = 0, [NativeTypeName("UINT32")] uint InputSampleRate = 0, [NativeTypeName("UINT32")] uint Flags = 0, [NativeTypeName("LPCWSTR")] ushort* szDeviceId = null, [NativeTypeName("const XAUDIO2_EFFECT_CHAIN *")] XAUDIO2_EFFECT_CHAIN* pEffectChain = null, AUDIO_STREAM_CATEGORY StreamCategory = AudioCategory_GameEffects)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateMasteringVoice>(lpVtbl->CreateMasteringVoice)((IXAudio2*)Unsafe.AsPointer(ref this), ppMasteringVoice, InputChannels, InputSampleRate, Flags, szDeviceId, pEffectChain, StreamCategory);
        }

        [return: NativeTypeName("HRESULT")]
        public int StartEngine()
        {
            return Marshal.GetDelegateForFunctionPointer<_StartEngine>(lpVtbl->StartEngine)((IXAudio2*)Unsafe.AsPointer(ref this));
        }

        public void StopEngine()
        {
            Marshal.GetDelegateForFunctionPointer<_StopEngine>(lpVtbl->StopEngine)((IXAudio2*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int CommitChanges([NativeTypeName("UINT32")] uint OperationSet)
        {
            return Marshal.GetDelegateForFunctionPointer<_CommitChanges>(lpVtbl->CommitChanges)((IXAudio2*)Unsafe.AsPointer(ref this), OperationSet);
        }

        public void GetPerformanceData([NativeTypeName("XAUDIO2_PERFORMANCE_DATA *")] XAUDIO2_PERFORMANCE_DATA* pPerfData)
        {
            Marshal.GetDelegateForFunctionPointer<_GetPerformanceData>(lpVtbl->GetPerformanceData)((IXAudio2*)Unsafe.AsPointer(ref this), pPerfData);
        }

        public void SetDebugConfiguration([NativeTypeName("const XAUDIO2_DEBUG_CONFIGURATION *")] XAUDIO2_DEBUG_CONFIGURATION* pDebugConfiguration, [NativeTypeName("void *")] void* pReserved = null)
        {
            Marshal.GetDelegateForFunctionPointer<_SetDebugConfiguration>(lpVtbl->SetDebugConfiguration)((IXAudio2*)Unsafe.AsPointer(ref this), pDebugConfiguration, pReserved);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (IXAudio2EngineCallback *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr RegisterForCallbacks;

            [NativeTypeName("void (IXAudio2EngineCallback *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr UnregisterForCallbacks;

            [NativeTypeName("HRESULT (IXAudio2SourceVoice **, const WAVEFORMATEX *, UINT32, float, IXAudio2VoiceCallback *, const XAUDIO2_VOICE_SENDS *, const XAUDIO2_EFFECT_CHAIN *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateSourceVoice;

            [NativeTypeName("HRESULT (IXAudio2SubmixVoice **, UINT32, UINT32, UINT32, UINT32, const XAUDIO2_VOICE_SENDS *, const XAUDIO2_EFFECT_CHAIN *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateSubmixVoice;

            [NativeTypeName("HRESULT (IXAudio2MasteringVoice **, UINT32, UINT32, UINT32, LPCWSTR, const XAUDIO2_EFFECT_CHAIN *, AUDIO_STREAM_CATEGORY) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateMasteringVoice;

            [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr StartEngine;

            [NativeTypeName("void () __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr StopEngine;

            [NativeTypeName("HRESULT (UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CommitChanges;

            [NativeTypeName("void (XAUDIO2_PERFORMANCE_DATA *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetPerformanceData;

            [NativeTypeName("void (const XAUDIO2_DEBUG_CONFIGURATION *, void *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetDebugConfiguration;
        }
    }
}
