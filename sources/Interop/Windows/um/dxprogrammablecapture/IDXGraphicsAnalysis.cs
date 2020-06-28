// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/DXProgrammableCapture.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("9F251514-9D4D-4902-9D60-18988AB7D4B5")]
    public unsafe partial struct IDXGraphicsAnalysis
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IDXGraphicsAnalysis*, Guid*, void**, int>)(lpVtbl[0]))((IDXGraphicsAnalysis*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IDXGraphicsAnalysis*, uint>)(lpVtbl[1]))((IDXGraphicsAnalysis*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IDXGraphicsAnalysis*, uint>)(lpVtbl[2]))((IDXGraphicsAnalysis*)Unsafe.AsPointer(ref this));
        }

        public void BeginCapture()
        {
            ((delegate* stdcall<IDXGraphicsAnalysis*, void>)(lpVtbl[3]))((IDXGraphicsAnalysis*)Unsafe.AsPointer(ref this));
        }

        public void EndCapture()
        {
            ((delegate* stdcall<IDXGraphicsAnalysis*, void>)(lpVtbl[4]))((IDXGraphicsAnalysis*)Unsafe.AsPointer(ref this));
        }
    }
}
