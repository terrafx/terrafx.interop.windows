// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/xaudio2.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop
{
    public unsafe partial struct IXAudio2EngineCallback
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void OnProcessingPassStart()
        {
            ((delegate* stdcall<IXAudio2EngineCallback*, void>)(lpVtbl[0]))((IXAudio2EngineCallback*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void OnProcessingPassEnd()
        {
            ((delegate* stdcall<IXAudio2EngineCallback*, void>)(lpVtbl[1]))((IXAudio2EngineCallback*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void OnCriticalError([NativeTypeName("HRESULT")] int Error)
        {
            ((delegate* stdcall<IXAudio2EngineCallback*, int, void>)(lpVtbl[2]))((IXAudio2EngineCallback*)Unsafe.AsPointer(ref this), Error);
        }
    }
}
