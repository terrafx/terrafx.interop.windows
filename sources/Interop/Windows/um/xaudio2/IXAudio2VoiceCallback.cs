// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/xaudio2.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop
{
    public unsafe partial struct IXAudio2VoiceCallback
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void OnVoiceProcessingPassStart([NativeTypeName("UINT32")] uint BytesRequired)
        {
            ((delegate* unmanaged<IXAudio2VoiceCallback*, uint, void>)(lpVtbl[0]))((IXAudio2VoiceCallback*)Unsafe.AsPointer(ref this), BytesRequired);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void OnVoiceProcessingPassEnd()
        {
            ((delegate* unmanaged<IXAudio2VoiceCallback*, void>)(lpVtbl[1]))((IXAudio2VoiceCallback*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void OnStreamEnd()
        {
            ((delegate* unmanaged<IXAudio2VoiceCallback*, void>)(lpVtbl[2]))((IXAudio2VoiceCallback*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void OnBufferStart(void* pBufferContext)
        {
            ((delegate* unmanaged<IXAudio2VoiceCallback*, void*, void>)(lpVtbl[3]))((IXAudio2VoiceCallback*)Unsafe.AsPointer(ref this), pBufferContext);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void OnBufferEnd(void* pBufferContext)
        {
            ((delegate* unmanaged<IXAudio2VoiceCallback*, void*, void>)(lpVtbl[4]))((IXAudio2VoiceCallback*)Unsafe.AsPointer(ref this), pBufferContext);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void OnLoopEnd(void* pBufferContext)
        {
            ((delegate* unmanaged<IXAudio2VoiceCallback*, void*, void>)(lpVtbl[5]))((IXAudio2VoiceCallback*)Unsafe.AsPointer(ref this), pBufferContext);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void OnVoiceError(void* pBufferContext, [NativeTypeName("HRESULT")] int Error)
        {
            ((delegate* unmanaged<IXAudio2VoiceCallback*, void*, int, void>)(lpVtbl[6]))((IXAudio2VoiceCallback*)Unsafe.AsPointer(ref this), pBufferContext, Error);
        }
    }
}
