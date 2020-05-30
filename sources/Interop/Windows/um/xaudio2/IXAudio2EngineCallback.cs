// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/xaudio2.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public unsafe partial struct IXAudio2EngineCallback
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _OnProcessingPassStart(IXAudio2EngineCallback* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _OnProcessingPassEnd(IXAudio2EngineCallback* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _OnCriticalError(IXAudio2EngineCallback* pThis, [NativeTypeName("HRESULT")] int Error);

        public void OnProcessingPassStart()
        {
            Marshal.GetDelegateForFunctionPointer<_OnProcessingPassStart>(lpVtbl->OnProcessingPassStart)((IXAudio2EngineCallback*)Unsafe.AsPointer(ref this));
        }

        public void OnProcessingPassEnd()
        {
            Marshal.GetDelegateForFunctionPointer<_OnProcessingPassEnd>(lpVtbl->OnProcessingPassEnd)((IXAudio2EngineCallback*)Unsafe.AsPointer(ref this));
        }

        public void OnCriticalError([NativeTypeName("HRESULT")] int Error)
        {
            Marshal.GetDelegateForFunctionPointer<_OnCriticalError>(lpVtbl->OnCriticalError)((IXAudio2EngineCallback*)Unsafe.AsPointer(ref this), Error);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("void () __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr OnProcessingPassStart;

            [NativeTypeName("void () __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr OnProcessingPassEnd;

            [NativeTypeName("void (HRESULT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr OnCriticalError;
        }
    }
}
