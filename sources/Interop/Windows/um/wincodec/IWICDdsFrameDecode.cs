// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3D4C0C61-18A4-41E4-BD80-481A4FC9F464")]
    public unsafe partial struct IWICDdsFrameDecode
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IWICDdsFrameDecode*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IWICDdsFrameDecode*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IWICDdsFrameDecode*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSizeInBlocks([NativeTypeName("UINT *")] uint* pWidthInBlocks, [NativeTypeName("UINT *")] uint* pHeightInBlocks)
        {
            return lpVtbl->GetSizeInBlocks((IWICDdsFrameDecode*)Unsafe.AsPointer(ref this), pWidthInBlocks, pHeightInBlocks);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFormatInfo([NativeTypeName("WICDdsFormatInfo *")] WICDdsFormatInfo* pFormatInfo)
        {
            return lpVtbl->GetFormatInfo((IWICDdsFrameDecode*)Unsafe.AsPointer(ref this), pFormatInfo);
        }

        [return: NativeTypeName("HRESULT")]
        public int CopyBlocks([NativeTypeName("const WICRect *")] WICRect* prcBoundsInBlocks, [NativeTypeName("UINT")] uint cbStride, [NativeTypeName("UINT")] uint cbBufferSize, [NativeTypeName("BYTE *")] byte* pbBuffer)
        {
            return lpVtbl->CopyBlocks((IWICDdsFrameDecode*)Unsafe.AsPointer(ref this), prcBoundsInBlocks, cbStride, cbBufferSize, pbBuffer);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IWICDdsFrameDecode*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IWICDdsFrameDecode*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IWICDdsFrameDecode*, uint> Release;

            [NativeTypeName("HRESULT (UINT *, UINT *) __attribute__((stdcall))")]
            public delegate* stdcall<IWICDdsFrameDecode*, uint*, uint*, int> GetSizeInBlocks;

            [NativeTypeName("HRESULT (WICDdsFormatInfo *) __attribute__((stdcall))")]
            public delegate* stdcall<IWICDdsFrameDecode*, WICDdsFormatInfo*, int> GetFormatInfo;

            [NativeTypeName("HRESULT (const WICRect *, UINT, UINT, BYTE *) __attribute__((stdcall))")]
            public delegate* stdcall<IWICDdsFrameDecode*, WICRect*, uint, uint, byte*, int> CopyBlocks;
        }
    }
}
