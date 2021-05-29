// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/xaudio2.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("84AC29BB-D619-44D2-B197-E4ACF7DF3ED6")]
    [NativeTypeName("struct IXAudio2Extension : IUnknown")]
    public unsafe partial struct IXAudio2Extension
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IXAudio2Extension*, Guid*, void**, int>)(lpVtbl[0]))((IXAudio2Extension*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IXAudio2Extension*, uint>)(lpVtbl[1]))((IXAudio2Extension*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IXAudio2Extension*, uint>)(lpVtbl[2]))((IXAudio2Extension*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void GetProcessingQuantum([NativeTypeName("UINT32 *")] uint* quantumNumerator, [NativeTypeName("UINT32 *")] uint* quantumDenominator)
        {
            ((delegate* unmanaged<IXAudio2Extension*, uint*, uint*, void>)(lpVtbl[3]))((IXAudio2Extension*)Unsafe.AsPointer(ref this), quantumNumerator, quantumDenominator);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void GetProcessor([NativeTypeName("XAUDIO2_PROCESSOR *")] uint* processor)
        {
            ((delegate* unmanaged<IXAudio2Extension*, uint*, void>)(lpVtbl[4]))((IXAudio2Extension*)Unsafe.AsPointer(ref this), processor);
        }
    }
}
