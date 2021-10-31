// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3050F669-98B5-11CF-BB82-00AA00BDCE0B")]
    [NativeTypeName("struct IHTMLElementRender : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IHTMLElementRender
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IHTMLElementRender*, Guid*, void**, int>)(lpVtbl[0]))((IHTMLElementRender*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IHTMLElementRender*, uint>)(lpVtbl[1]))((IHTMLElementRender*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IHTMLElementRender*, uint>)(lpVtbl[2]))((IHTMLElementRender*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT DrawToDC([NativeTypeName("HDC")] IntPtr hDC)
        {
            return ((delegate* unmanaged<IHTMLElementRender*, IntPtr, int>)(lpVtbl[3]))((IHTMLElementRender*)Unsafe.AsPointer(ref this), hDC);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT SetDocumentPrinter([NativeTypeName("BSTR")] ushort* bstrPrinterName, [NativeTypeName("HDC")] IntPtr hDC)
        {
            return ((delegate* unmanaged<IHTMLElementRender*, ushort*, IntPtr, int>)(lpVtbl[4]))((IHTMLElementRender*)Unsafe.AsPointer(ref this), bstrPrinterName, hDC);
        }
    }
}
