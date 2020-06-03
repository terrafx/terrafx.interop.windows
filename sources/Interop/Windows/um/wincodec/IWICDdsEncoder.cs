// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("5CACDB4C-407E-41B3-B936-D0F010CD6732")]
    public unsafe partial struct IWICDdsEncoder
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IWICDdsEncoder*, Guid*, void**, int>)(lpVtbl[0]))((IWICDdsEncoder*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IWICDdsEncoder*, uint>)(lpVtbl[1]))((IWICDdsEncoder*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IWICDdsEncoder*, uint>)(lpVtbl[2]))((IWICDdsEncoder*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetParameters([NativeTypeName("WICDdsParameters *")] WICDdsParameters* pParameters)
        {
            return ((delegate* stdcall<IWICDdsEncoder*, WICDdsParameters*, int>)(lpVtbl[3]))((IWICDdsEncoder*)Unsafe.AsPointer(ref this), pParameters);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetParameters([NativeTypeName("WICDdsParameters *")] WICDdsParameters* pParameters)
        {
            return ((delegate* stdcall<IWICDdsEncoder*, WICDdsParameters*, int>)(lpVtbl[4]))((IWICDdsEncoder*)Unsafe.AsPointer(ref this), pParameters);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateNewFrame([NativeTypeName("IWICBitmapFrameEncode **")] IWICBitmapFrameEncode** ppIFrameEncode, [NativeTypeName("UINT *")] uint* pArrayIndex, [NativeTypeName("UINT *")] uint* pMipLevel, [NativeTypeName("UINT *")] uint* pSliceIndex)
        {
            return ((delegate* stdcall<IWICDdsEncoder*, IWICBitmapFrameEncode**, uint*, uint*, uint*, int>)(lpVtbl[5]))((IWICDdsEncoder*)Unsafe.AsPointer(ref this), ppIFrameEncode, pArrayIndex, pMipLevel, pSliceIndex);
        }
    }
}
