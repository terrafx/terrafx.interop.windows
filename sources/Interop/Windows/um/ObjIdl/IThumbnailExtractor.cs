// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ObjIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("969DC708-5C76-11D1-8D86-0000F804B057")]
    public unsafe partial struct IThumbnailExtractor
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IThumbnailExtractor*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IThumbnailExtractor*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IThumbnailExtractor*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int ExtractThumbnail([NativeTypeName("IStorage *")] IStorage* pStg, [NativeTypeName("ULONG")] uint ulLength, [NativeTypeName("ULONG")] uint ulHeight, [NativeTypeName("ULONG *")] uint* pulOutputLength, [NativeTypeName("ULONG *")] uint* pulOutputHeight, [NativeTypeName("HBITMAP *")] IntPtr* phOutputBitmap)
        {
            return lpVtbl->ExtractThumbnail((IThumbnailExtractor*)Unsafe.AsPointer(ref this), pStg, ulLength, ulHeight, pulOutputLength, pulOutputHeight, phOutputBitmap);
        }

        [return: NativeTypeName("HRESULT")]
        public int OnFileUpdated([NativeTypeName("IStorage *")] IStorage* pStg)
        {
            return lpVtbl->OnFileUpdated((IThumbnailExtractor*)Unsafe.AsPointer(ref this), pStg);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IThumbnailExtractor*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IThumbnailExtractor*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IThumbnailExtractor*, uint> Release;

            [NativeTypeName("HRESULT (IStorage *, ULONG, ULONG, ULONG *, ULONG *, HBITMAP *) __attribute__((stdcall))")]
            public delegate* stdcall<IThumbnailExtractor*, IStorage*, uint, uint, uint*, uint*, IntPtr*, int> ExtractThumbnail;

            [NativeTypeName("HRESULT (IStorage *) __attribute__((stdcall))")]
            public delegate* stdcall<IThumbnailExtractor*, IStorage*, int> OnFileUpdated;
        }
    }
}
