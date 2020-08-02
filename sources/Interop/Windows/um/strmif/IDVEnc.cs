// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("D18E17A0-AACB-11D0-AFB0-00AA00B67A42")]
    public unsafe partial struct IDVEnc
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IDVEnc*, Guid*, void**, int>)(lpVtbl[0]))((IDVEnc*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IDVEnc*, uint>)(lpVtbl[1]))((IDVEnc*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IDVEnc*, uint>)(lpVtbl[2]))((IDVEnc*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int get_IFormatResolution([NativeTypeName("int *")] int* VideoFormat, [NativeTypeName("int *")] int* DVFormat, [NativeTypeName("int *")] int* Resolution, [NativeTypeName("BYTE")] byte fDVInfo, [NativeTypeName("DVINFO *")] DVINFO* sDVInfo)
        {
            return ((delegate* stdcall<IDVEnc*, int*, int*, int*, byte, DVINFO*, int>)(lpVtbl[3]))((IDVEnc*)Unsafe.AsPointer(ref this), VideoFormat, DVFormat, Resolution, fDVInfo, sDVInfo);
        }

        [return: NativeTypeName("HRESULT")]
        public int put_IFormatResolution(int VideoFormat, int DVFormat, int Resolution, [NativeTypeName("BYTE")] byte fDVInfo, [NativeTypeName("DVINFO *")] DVINFO* sDVInfo)
        {
            return ((delegate* stdcall<IDVEnc*, int, int, int, byte, DVINFO*, int>)(lpVtbl[4]))((IDVEnc*)Unsafe.AsPointer(ref this), VideoFormat, DVFormat, Resolution, fDVInfo, sDVInfo);
        }
    }
}
