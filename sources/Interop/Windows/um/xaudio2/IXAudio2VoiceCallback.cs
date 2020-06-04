// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/xaudio2.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop
{
    public unsafe partial struct IXAudio2VoiceCallback
    {
        public void** lpVtbl;

        public void OnVoiceProcessingPassStart([NativeTypeName("UINT32")] uint BytesRequired)
        {
            ((delegate* stdcall<IXAudio2VoiceCallback*, uint, void>)(lpVtbl[0]))((IXAudio2VoiceCallback*)Unsafe.AsPointer(ref this), BytesRequired);
        }

        public void OnVoiceProcessingPassEnd()
        {
            ((delegate* stdcall<IXAudio2VoiceCallback*, void>)(lpVtbl[1]))((IXAudio2VoiceCallback*)Unsafe.AsPointer(ref this));
        }

        public void OnStreamEnd()
        {
            ((delegate* stdcall<IXAudio2VoiceCallback*, void>)(lpVtbl[2]))((IXAudio2VoiceCallback*)Unsafe.AsPointer(ref this));
        }

        public void OnBufferStart([NativeTypeName("void *")] void* pBufferContext)
        {
            ((delegate* stdcall<IXAudio2VoiceCallback*, void*, void>)(lpVtbl[3]))((IXAudio2VoiceCallback*)Unsafe.AsPointer(ref this), pBufferContext);
        }

        public void OnBufferEnd([NativeTypeName("void *")] void* pBufferContext)
        {
            ((delegate* stdcall<IXAudio2VoiceCallback*, void*, void>)(lpVtbl[4]))((IXAudio2VoiceCallback*)Unsafe.AsPointer(ref this), pBufferContext);
        }

        public void OnLoopEnd([NativeTypeName("void *")] void* pBufferContext)
        {
            ((delegate* stdcall<IXAudio2VoiceCallback*, void*, void>)(lpVtbl[5]))((IXAudio2VoiceCallback*)Unsafe.AsPointer(ref this), pBufferContext);
        }

        public void OnVoiceError([NativeTypeName("void *")] void* pBufferContext, [NativeTypeName("HRESULT")] int Error)
        {
            ((delegate* stdcall<IXAudio2VoiceCallback*, void*, int, void>)(lpVtbl[6]))((IXAudio2VoiceCallback*)Unsafe.AsPointer(ref this), pBufferContext, Error);
        }
    }
}
