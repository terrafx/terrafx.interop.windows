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
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IWICDdsEncoder*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IWICDdsEncoder*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IWICDdsEncoder*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetParameters([NativeTypeName("WICDdsParameters *")] WICDdsParameters* pParameters)
        {
            return lpVtbl->SetParameters((IWICDdsEncoder*)Unsafe.AsPointer(ref this), pParameters);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetParameters([NativeTypeName("WICDdsParameters *")] WICDdsParameters* pParameters)
        {
            return lpVtbl->GetParameters((IWICDdsEncoder*)Unsafe.AsPointer(ref this), pParameters);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateNewFrame([NativeTypeName("IWICBitmapFrameEncode **")] IWICBitmapFrameEncode** ppIFrameEncode, [NativeTypeName("UINT *")] uint* pArrayIndex, [NativeTypeName("UINT *")] uint* pMipLevel, [NativeTypeName("UINT *")] uint* pSliceIndex)
        {
            return lpVtbl->CreateNewFrame((IWICDdsEncoder*)Unsafe.AsPointer(ref this), ppIFrameEncode, pArrayIndex, pMipLevel, pSliceIndex);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IWICDdsEncoder*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IWICDdsEncoder*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IWICDdsEncoder*, uint> Release;

            [NativeTypeName("HRESULT (WICDdsParameters *) __attribute__((stdcall))")]
            public delegate* stdcall<IWICDdsEncoder*, WICDdsParameters*, int> SetParameters;

            [NativeTypeName("HRESULT (WICDdsParameters *) __attribute__((stdcall))")]
            public delegate* stdcall<IWICDdsEncoder*, WICDdsParameters*, int> GetParameters;

            [NativeTypeName("HRESULT (IWICBitmapFrameEncode **, UINT *, UINT *, UINT *) __attribute__((stdcall))")]
            public delegate* stdcall<IWICDdsEncoder*, IWICBitmapFrameEncode**, uint*, uint*, uint*, int> CreateNewFrame;
        }
    }
}
