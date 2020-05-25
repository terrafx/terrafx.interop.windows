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

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IPrintDocumentPackageTargetFactory* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IPrintDocumentPackageTargetFactory* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IPrintDocumentPackageTargetFactory* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateDocumentPackageTargetForPrintJob(IPrintDocumentPackageTargetFactory* pThis, [NativeTypeName("LPCWSTR")] ushort* printerName, [NativeTypeName("LPCWSTR")] ushort* jobName, [NativeTypeName("IStream *")] IStream* jobOutputStream, [NativeTypeName("IStream *")] IStream* jobPrintTicketStream, [NativeTypeName("IPrintDocumentPackageTarget **")] IPrintDocumentPackageTarget** docPackageTarget);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IPrintDocumentPackageTargetFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IPrintDocumentPackageTargetFactory*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IPrintDocumentPackageTargetFactory*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateDocumentPackageTargetForPrintJob([NativeTypeName("LPCWSTR")] ushort* printerName, [NativeTypeName("LPCWSTR")] ushort* jobName, [NativeTypeName("IStream *")] IStream* jobOutputStream, [NativeTypeName("IStream *")] IStream* jobPrintTicketStream, [NativeTypeName("IPrintDocumentPackageTarget **")] IPrintDocumentPackageTarget** docPackageTarget)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateDocumentPackageTargetForPrintJob>(lpVtbl->CreateDocumentPackageTargetForPrintJob)((IPrintDocumentPackageTargetFactory*)Unsafe.AsPointer(ref this), printerName, jobName, jobOutputStream, jobPrintTicketStream, docPackageTarget);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (LPCWSTR, LPCWSTR, IStream *, IStream *, IPrintDocumentPackageTarget **) __attribute__((stdcall))")]
            public IntPtr CreateDocumentPackageTargetForPrintJob;
        }
    }
}
