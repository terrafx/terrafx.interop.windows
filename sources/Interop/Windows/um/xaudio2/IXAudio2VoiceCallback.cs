// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/xaudio2.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public unsafe partial struct IXAudio2VoiceCallback
    {
        public Vtbl* lpVtbl;

        public void OnVoiceProcessingPassStart([NativeTypeName("UINT32")] uint BytesRequired)
        {
            lpVtbl->OnVoiceProcessingPassStart((IXAudio2VoiceCallback*)Unsafe.AsPointer(ref this), BytesRequired);
        }

        public void OnVoiceProcessingPassEnd()
        {
            lpVtbl->OnVoiceProcessingPassEnd((IXAudio2VoiceCallback*)Unsafe.AsPointer(ref this));
        }

        public void OnStreamEnd()
        {
            lpVtbl->OnStreamEnd((IXAudio2VoiceCallback*)Unsafe.AsPointer(ref this));
        }

        public void OnBufferStart([NativeTypeName("void *")] void* pBufferContext)
        {
            lpVtbl->OnBufferStart((IXAudio2VoiceCallback*)Unsafe.AsPointer(ref this), pBufferContext);
        }

        public void OnBufferEnd([NativeTypeName("void *")] void* pBufferContext)
        {
            lpVtbl->OnBufferEnd((IXAudio2VoiceCallback*)Unsafe.AsPointer(ref this), pBufferContext);
        }

        public void OnLoopEnd([NativeTypeName("void *")] void* pBufferContext)
        {
            lpVtbl->OnLoopEnd((IXAudio2VoiceCallback*)Unsafe.AsPointer(ref this), pBufferContext);
        }

        public void OnVoiceError([NativeTypeName("void *")] void* pBufferContext, [NativeTypeName("HRESULT")] int Error)
        {
            lpVtbl->OnVoiceError((IXAudio2VoiceCallback*)Unsafe.AsPointer(ref this), pBufferContext, Error);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("void (UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IXAudio2VoiceCallback*, uint, void> OnVoiceProcessingPassStart;

            [NativeTypeName("void () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IXAudio2VoiceCallback*, void> OnVoiceProcessingPassEnd;

            [NativeTypeName("void () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IXAudio2VoiceCallback*, void> OnStreamEnd;

            [NativeTypeName("void (void *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IXAudio2VoiceCallback*, void*, void> OnBufferStart;

            [NativeTypeName("void (void *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IXAudio2VoiceCallback*, void*, void> OnBufferEnd;

            [NativeTypeName("void (void *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IXAudio2VoiceCallback*, void*, void> OnLoopEnd;

            [NativeTypeName("void (void *, HRESULT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IXAudio2VoiceCallback*, void*, int, void> OnVoiceError;
        }
    }
}
