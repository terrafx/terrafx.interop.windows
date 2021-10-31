// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/devicetopology.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("DD79923C-0599-45E0-B8B6-C8DF7DB6E796")]
    [NativeTypeName("struct IAudioPeakMeter : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IAudioPeakMeter
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IAudioPeakMeter*, Guid*, void**, int>)(lpVtbl[0]))((IAudioPeakMeter*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAudioPeakMeter*, uint>)(lpVtbl[1]))((IAudioPeakMeter*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAudioPeakMeter*, uint>)(lpVtbl[2]))((IAudioPeakMeter*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetChannelCount([NativeTypeName("UINT *")] uint* pcChannels)
        {
            return ((delegate* unmanaged<IAudioPeakMeter*, uint*, int>)(lpVtbl[3]))((IAudioPeakMeter*)Unsafe.AsPointer(ref this), pcChannels);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetLevel([NativeTypeName("UINT")] uint nChannel, float* pfLevel)
        {
            return ((delegate* unmanaged<IAudioPeakMeter*, uint, float*, int>)(lpVtbl[4]))((IAudioPeakMeter*)Unsafe.AsPointer(ref this), nChannel, pfLevel);
        }
    }
}
