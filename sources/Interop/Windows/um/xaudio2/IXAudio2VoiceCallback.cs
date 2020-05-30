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

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _OnVoiceProcessingPassStart(IXAudio2VoiceCallback* pThis, [NativeTypeName("UINT32")] uint BytesRequired);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _OnVoiceProcessingPassEnd(IXAudio2VoiceCallback* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _OnStreamEnd(IXAudio2VoiceCallback* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _OnBufferStart(IXAudio2VoiceCallback* pThis, [NativeTypeName("void *")] void* pBufferContext);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _OnBufferEnd(IXAudio2VoiceCallback* pThis, [NativeTypeName("void *")] void* pBufferContext);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _OnLoopEnd(IXAudio2VoiceCallback* pThis, [NativeTypeName("void *")] void* pBufferContext);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _OnVoiceError(IXAudio2VoiceCallback* pThis, [NativeTypeName("void *")] void* pBufferContext, [NativeTypeName("HRESULT")] int Error);

        public void OnVoiceProcessingPassStart([NativeTypeName("UINT32")] uint BytesRequired)
        {
            Marshal.GetDelegateForFunctionPointer<_OnVoiceProcessingPassStart>(lpVtbl->OnVoiceProcessingPassStart)((IXAudio2VoiceCallback*)Unsafe.AsPointer(ref this), BytesRequired);
        }

        public void OnVoiceProcessingPassEnd()
        {
            Marshal.GetDelegateForFunctionPointer<_OnVoiceProcessingPassEnd>(lpVtbl->OnVoiceProcessingPassEnd)((IXAudio2VoiceCallback*)Unsafe.AsPointer(ref this));
        }

        public void OnStreamEnd()
        {
            Marshal.GetDelegateForFunctionPointer<_OnStreamEnd>(lpVtbl->OnStreamEnd)((IXAudio2VoiceCallback*)Unsafe.AsPointer(ref this));
        }

        public void OnBufferStart([NativeTypeName("void *")] void* pBufferContext)
        {
            Marshal.GetDelegateForFunctionPointer<_OnBufferStart>(lpVtbl->OnBufferStart)((IXAudio2VoiceCallback*)Unsafe.AsPointer(ref this), pBufferContext);
        }

        public void OnBufferEnd([NativeTypeName("void *")] void* pBufferContext)
        {
            Marshal.GetDelegateForFunctionPointer<_OnBufferEnd>(lpVtbl->OnBufferEnd)((IXAudio2VoiceCallback*)Unsafe.AsPointer(ref this), pBufferContext);
        }

        public void OnLoopEnd([NativeTypeName("void *")] void* pBufferContext)
        {
            Marshal.GetDelegateForFunctionPointer<_OnLoopEnd>(lpVtbl->OnLoopEnd)((IXAudio2VoiceCallback*)Unsafe.AsPointer(ref this), pBufferContext);
        }

        public void OnVoiceError([NativeTypeName("void *")] void* pBufferContext, [NativeTypeName("HRESULT")] int Error)
        {
            Marshal.GetDelegateForFunctionPointer<_OnVoiceError>(lpVtbl->OnVoiceError)((IXAudio2VoiceCallback*)Unsafe.AsPointer(ref this), pBufferContext, Error);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("void (UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr OnVoiceProcessingPassStart;

            [NativeTypeName("void () __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr OnVoiceProcessingPassEnd;

            [NativeTypeName("void () __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr OnStreamEnd;

            [NativeTypeName("void (void *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr OnBufferStart;

            [NativeTypeName("void (void *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr OnBufferEnd;

            [NativeTypeName("void (void *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr OnLoopEnd;

            [NativeTypeName("void (void *, HRESULT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr OnVoiceError;
        }
    }
}
