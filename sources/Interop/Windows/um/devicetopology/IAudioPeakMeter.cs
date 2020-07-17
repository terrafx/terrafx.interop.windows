// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/devicetopology.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("DD79923C-0599-45E0-B8B6-C8DF7DB6E796")]
    public unsafe partial struct IAudioPeakMeter
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IAudioPeakMeter*, Guid*, void**, int>)(lpVtbl[0]))((IAudioPeakMeter*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IAudioPeakMeter*, uint>)(lpVtbl[1]))((IAudioPeakMeter*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IAudioPeakMeter*, uint>)(lpVtbl[2]))((IAudioPeakMeter*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetChannelCount([NativeTypeName("UINT *")] uint* pcChannels)
        {
            return ((delegate* stdcall<IAudioPeakMeter*, uint*, int>)(lpVtbl[3]))((IAudioPeakMeter*)Unsafe.AsPointer(ref this), pcChannels);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetLevel([NativeTypeName("UINT")] uint nChannel, [NativeTypeName("float *")] float* pfLevel)
        {
            return ((delegate* stdcall<IAudioPeakMeter*, uint, float*, int>)(lpVtbl[4]))((IAudioPeakMeter*)Unsafe.AsPointer(ref this), nChannel, pfLevel);
        }
    }
}
