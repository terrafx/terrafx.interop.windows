// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/DocObj.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("B722BCC9-4E68-101B-A2BC-00AA00404770")]
    [NativeTypeName("struct IPrint : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IPrint
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IPrint*, Guid*, void**, int>)(lpVtbl[0]))((IPrint*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IPrint*, uint>)(lpVtbl[1]))((IPrint*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IPrint*, uint>)(lpVtbl[2]))((IPrint*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT SetInitialPageNum([NativeTypeName("LONG")] int nFirstPage)
        {
            return ((delegate* unmanaged<IPrint*, int, int>)(lpVtbl[3]))((IPrint*)Unsafe.AsPointer(ref this), nFirstPage);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetPageInfo([NativeTypeName("LONG *")] int* pnFirstPage, [NativeTypeName("LONG *")] int* pcPages)
        {
            return ((delegate* unmanaged<IPrint*, int*, int*, int>)(lpVtbl[4]))((IPrint*)Unsafe.AsPointer(ref this), pnFirstPage, pcPages);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT Print([NativeTypeName("DWORD")] uint grfFlags, DVTARGETDEVICE** pptd, PAGESET** ppPageSet, STGMEDIUM* pstgmOptions, IContinueCallback* pcallback, [NativeTypeName("LONG")] int nFirstPage, [NativeTypeName("LONG *")] int* pcPagesPrinted, [NativeTypeName("LONG *")] int* pnLastPage)
        {
            return ((delegate* unmanaged<IPrint*, uint, DVTARGETDEVICE**, PAGESET**, STGMEDIUM*, IContinueCallback*, int, int*, int*, int>)(lpVtbl[5]))((IPrint*)Unsafe.AsPointer(ref this), grfFlags, pptd, ppPageSet, pstgmOptions, pcallback, nFirstPage, pcPagesPrinted, pnLastPage);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IPrint*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IPrint*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IPrint*, uint> Release;

            [NativeTypeName("HRESULT (LONG) __attribute__((stdcall))")]
            public delegate* unmanaged<IPrint*, int, int> SetInitialPageNum;

            [NativeTypeName("HRESULT (LONG *, LONG *) __attribute__((stdcall))")]
            public delegate* unmanaged<IPrint*, int*, int*, int> GetPageInfo;

            [NativeTypeName("HRESULT (DWORD, DVTARGETDEVICE **, PAGESET **, STGMEDIUM *, IContinueCallback *, LONG, LONG *, LONG *) __attribute__((stdcall))")]
            public delegate* unmanaged<IPrint*, uint, DVTARGETDEVICE**, PAGESET**, STGMEDIUM*, IContinueCallback*, int, int*, int*, int> Print;
        }
    }
}
