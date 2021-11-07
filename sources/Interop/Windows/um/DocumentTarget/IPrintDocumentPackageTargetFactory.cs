// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/DocumentTarget.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop
{
    [SupportedOSPlatform("windows8.0")]
    [Guid("D2959BF7-B31B-4A3D-9600-712EB1335BA4")]
    [NativeTypeName("struct IPrintDocumentPackageTargetFactory : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IPrintDocumentPackageTargetFactory : IPrintDocumentPackageTargetFactory.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IPrintDocumentPackageTargetFactory*, Guid*, void**, int>)(lpVtbl[0]))((IPrintDocumentPackageTargetFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IPrintDocumentPackageTargetFactory*, uint>)(lpVtbl[1]))((IPrintDocumentPackageTargetFactory*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IPrintDocumentPackageTargetFactory*, uint>)(lpVtbl[2]))((IPrintDocumentPackageTargetFactory*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT CreateDocumentPackageTargetForPrintJob([NativeTypeName("LPCWSTR")] ushort* printerName, [NativeTypeName("LPCWSTR")] ushort* jobName, IStream* jobOutputStream, IStream* jobPrintTicketStream, IPrintDocumentPackageTarget** docPackageTarget)
        {
            return ((delegate* unmanaged<IPrintDocumentPackageTargetFactory*, ushort*, ushort*, IStream*, IStream*, IPrintDocumentPackageTarget**, int>)(lpVtbl[3]))((IPrintDocumentPackageTargetFactory*)Unsafe.AsPointer(ref this), printerName, jobName, jobOutputStream, jobPrintTicketStream, docPackageTarget);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT CreateDocumentPackageTargetForPrintJob([NativeTypeName("LPCWSTR")] ushort* printerName, [NativeTypeName("LPCWSTR")] ushort* jobName, IStream* jobOutputStream, IStream* jobPrintTicketStream, IPrintDocumentPackageTarget** docPackageTarget);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IPrintDocumentPackageTargetFactory*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IPrintDocumentPackageTargetFactory*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IPrintDocumentPackageTargetFactory*, uint> Release;

            [NativeTypeName("HRESULT (LPCWSTR, LPCWSTR, IStream *, IStream *, IPrintDocumentPackageTarget **) __attribute__((stdcall))")]
            public delegate* unmanaged<IPrintDocumentPackageTargetFactory*, ushort*, ushort*, IStream*, IStream*, IPrintDocumentPackageTarget**, int> CreateDocumentPackageTargetForPrintJob;
        }
    }
}
