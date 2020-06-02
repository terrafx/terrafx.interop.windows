// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/DocumentTarget.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("D2959BF7-B31B-4A3D-9600-712EB1335BA4")]
    public unsafe partial struct IPrintDocumentPackageTargetFactory
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IPrintDocumentPackageTargetFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IPrintDocumentPackageTargetFactory*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IPrintDocumentPackageTargetFactory*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateDocumentPackageTargetForPrintJob([NativeTypeName("LPCWSTR")] ushort* printerName, [NativeTypeName("LPCWSTR")] ushort* jobName, [NativeTypeName("IStream *")] IStream* jobOutputStream, [NativeTypeName("IStream *")] IStream* jobPrintTicketStream, [NativeTypeName("IPrintDocumentPackageTarget **")] IPrintDocumentPackageTarget** docPackageTarget)
        {
            return lpVtbl->CreateDocumentPackageTargetForPrintJob((IPrintDocumentPackageTargetFactory*)Unsafe.AsPointer(ref this), printerName, jobName, jobOutputStream, jobPrintTicketStream, docPackageTarget);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IPrintDocumentPackageTargetFactory*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IPrintDocumentPackageTargetFactory*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IPrintDocumentPackageTargetFactory*, uint> Release;

            [NativeTypeName("HRESULT (LPCWSTR, LPCWSTR, IStream *, IStream *, IPrintDocumentPackageTarget **) __attribute__((stdcall))")]
            public delegate* stdcall<IPrintDocumentPackageTargetFactory*, ushort*, ushort*, IStream*, IStream*, IPrintDocumentPackageTarget**, int> CreateDocumentPackageTargetForPrintJob;
        }
    }
}
