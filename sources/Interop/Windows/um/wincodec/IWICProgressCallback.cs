// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("4776F9CD-9517-45FA-BF24-E89C5EC5C60C")]
    [NativeTypeName("struct IWICProgressCallback : IUnknown")]
    public unsafe partial struct IWICProgressCallback
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IWICProgressCallback*, Guid*, void**, int>)(lpVtbl[0]))((IWICProgressCallback*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IWICProgressCallback*, uint>)(lpVtbl[1]))((IWICProgressCallback*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IWICProgressCallback*, uint>)(lpVtbl[2]))((IWICProgressCallback*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Notify([NativeTypeName("ULONG")] uint uFrameNum, WICProgressOperation operation, double dblProgress)
        {
            return ((delegate* stdcall<IWICProgressCallback*, uint, WICProgressOperation, double, int>)(lpVtbl[3]))((IWICProgressCallback*)Unsafe.AsPointer(ref this), uFrameNum, operation, dblProgress);
        }
    }
}
