// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1effectauthor.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("0359DC30-95E6-4568-9055-27720D130E93")]
    [NativeTypeName("struct ID2D1AnalysisTransform : IUnknown")]
    public unsafe partial struct ID2D1AnalysisTransform
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<ID2D1AnalysisTransform*, Guid*, void**, int>)(lpVtbl[0]))((ID2D1AnalysisTransform*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<ID2D1AnalysisTransform*, uint>)(lpVtbl[1]))((ID2D1AnalysisTransform*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<ID2D1AnalysisTransform*, uint>)(lpVtbl[2]))((ID2D1AnalysisTransform*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int ProcessAnalysisResults([NativeTypeName("const BYTE *")] byte* analysisData, [NativeTypeName("UINT32")] uint analysisDataCount)
        {
            return ((delegate* stdcall<ID2D1AnalysisTransform*, byte*, uint, int>)(lpVtbl[3]))((ID2D1AnalysisTransform*)Unsafe.AsPointer(ref this), analysisData, analysisDataCount);
        }
    }
}
