// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/xaudio2.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("84AC29BB-D619-44D2-B197-E4ACF7DF3ED6")]
    public unsafe partial struct IXAudio2Extension
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IXAudio2Extension*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IXAudio2Extension*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IXAudio2Extension*)Unsafe.AsPointer(ref this));
        }

        public void GetProcessingQuantum([NativeTypeName("UINT32 *")] uint* quantumNumerator, [NativeTypeName("UINT32 *")] uint* quantumDenominator)
        {
            lpVtbl->GetProcessingQuantum((IXAudio2Extension*)Unsafe.AsPointer(ref this), quantumNumerator, quantumDenominator);
        }

        public void GetProcessor([NativeTypeName("XAUDIO2_PROCESSOR *")] uint* processor)
        {
            lpVtbl->GetProcessor((IXAudio2Extension*)Unsafe.AsPointer(ref this), processor);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IXAudio2Extension*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IXAudio2Extension*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IXAudio2Extension*, uint> Release;

            [NativeTypeName("void (UINT32 *, UINT32 *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IXAudio2Extension*, uint*, uint*, void> GetProcessingQuantum;

            [NativeTypeName("void (XAUDIO2_PROCESSOR *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IXAudio2Extension*, uint*, void> GetProcessor;
        }
    }
}
