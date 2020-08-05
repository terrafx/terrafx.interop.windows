// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ObjIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("969DC708-5C76-11D1-8D86-0000F804B057")]
    [NativeTypeName("struct IThumbnailExtractor : IUnknown")]
    public unsafe partial struct IThumbnailExtractor
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IThumbnailExtractor*, Guid*, void**, int>)(lpVtbl[0]))((IThumbnailExtractor*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IThumbnailExtractor*, uint>)(lpVtbl[1]))((IThumbnailExtractor*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IThumbnailExtractor*, uint>)(lpVtbl[2]))((IThumbnailExtractor*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int ExtractThumbnail([NativeTypeName("IStorage *")] IStorage* pStg, [NativeTypeName("ULONG")] uint ulLength, [NativeTypeName("ULONG")] uint ulHeight, [NativeTypeName("ULONG *")] uint* pulOutputLength, [NativeTypeName("ULONG *")] uint* pulOutputHeight, [NativeTypeName("HBITMAP *")] IntPtr* phOutputBitmap)
        {
            return ((delegate* stdcall<IThumbnailExtractor*, IStorage*, uint, uint, uint*, uint*, IntPtr*, int>)(lpVtbl[3]))((IThumbnailExtractor*)Unsafe.AsPointer(ref this), pStg, ulLength, ulHeight, pulOutputLength, pulOutputHeight, phOutputBitmap);
        }

        [return: NativeTypeName("HRESULT")]
        public int OnFileUpdated([NativeTypeName("IStorage *")] IStorage* pStg)
        {
            return ((delegate* stdcall<IThumbnailExtractor*, IStorage*, int>)(lpVtbl[4]))((IThumbnailExtractor*)Unsafe.AsPointer(ref this), pStg);
        }
    }
}
