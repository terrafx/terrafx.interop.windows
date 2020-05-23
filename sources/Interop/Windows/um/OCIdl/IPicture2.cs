// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/OCIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("F5185DD8-2012-4B0B-AAD9-F052C6BD482B")]
    public unsafe partial struct IPicture2
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IPicture2* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IPicture2* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IPicture2* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _get_Handle(IPicture2* pThis, [NativeTypeName("HHANDLE *")] nuint* pHandle);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _get_hPal(IPicture2* pThis, [NativeTypeName("HHANDLE *")] nuint* phPal);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _get_Type(IPicture2* pThis, [NativeTypeName("SHORT *")] short* pType);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _get_Width(IPicture2* pThis, [NativeTypeName("OLE_XSIZE_HIMETRIC *")] int* pWidth);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _get_Height(IPicture2* pThis, [NativeTypeName("OLE_YSIZE_HIMETRIC *")] int* pHeight);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Render(IPicture2* pThis, [NativeTypeName("HDC")] IntPtr hDC, [NativeTypeName("LONG")] int x, [NativeTypeName("LONG")] int y, [NativeTypeName("LONG")] int cx, [NativeTypeName("LONG")] int cy, [NativeTypeName("OLE_XPOS_HIMETRIC")] int xSrc, [NativeTypeName("OLE_YPOS_HIMETRIC")] int ySrc, [NativeTypeName("OLE_XSIZE_HIMETRIC")] int cxSrc, [NativeTypeName("OLE_YSIZE_HIMETRIC")] int cySrc, [NativeTypeName("LPCRECT")] RECT* pRcWBounds);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _set_hPal(IPicture2* pThis, [NativeTypeName("HHANDLE")] nuint hPal);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _get_CurDC(IPicture2* pThis, [NativeTypeName("HDC *")] IntPtr* phDC);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SelectPicture(IPicture2* pThis, [NativeTypeName("HDC")] IntPtr hDCIn, [NativeTypeName("HDC *")] IntPtr* phDCOut, [NativeTypeName("HHANDLE *")] nuint* phBmpOut);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _get_KeepOriginalFormat(IPicture2* pThis, [NativeTypeName("BOOL *")] int* pKeep);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _put_KeepOriginalFormat(IPicture2* pThis, [NativeTypeName("BOOL")] int keep);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _PictureChanged(IPicture2* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SaveAsFile(IPicture2* pThis, [NativeTypeName("LPSTREAM")] IStream* pStream, [NativeTypeName("BOOL")] int fSaveMemCopy, [NativeTypeName("LONG *")] int* pCbSize);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _get_Attributes(IPicture2* pThis, [NativeTypeName("DWORD *")] uint* pDwAttr);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IPicture2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IPicture2*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IPicture2*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int get_Handle([NativeTypeName("HHANDLE *")] nuint* pHandle)
        {
            return Marshal.GetDelegateForFunctionPointer<_get_Handle>(lpVtbl->get_Handle)((IPicture2*)Unsafe.AsPointer(ref this), pHandle);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_hPal([NativeTypeName("HHANDLE *")] nuint* phPal)
        {
            return Marshal.GetDelegateForFunctionPointer<_get_hPal>(lpVtbl->get_hPal)((IPicture2*)Unsafe.AsPointer(ref this), phPal);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_Type([NativeTypeName("SHORT *")] short* pType)
        {
            return Marshal.GetDelegateForFunctionPointer<_get_Type>(lpVtbl->get_Type)((IPicture2*)Unsafe.AsPointer(ref this), pType);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_Width([NativeTypeName("OLE_XSIZE_HIMETRIC *")] int* pWidth)
        {
            return Marshal.GetDelegateForFunctionPointer<_get_Width>(lpVtbl->get_Width)((IPicture2*)Unsafe.AsPointer(ref this), pWidth);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_Height([NativeTypeName("OLE_YSIZE_HIMETRIC *")] int* pHeight)
        {
            return Marshal.GetDelegateForFunctionPointer<_get_Height>(lpVtbl->get_Height)((IPicture2*)Unsafe.AsPointer(ref this), pHeight);
        }

        [return: NativeTypeName("HRESULT")]
        public int Render([NativeTypeName("HDC")] IntPtr hDC, [NativeTypeName("LONG")] int x, [NativeTypeName("LONG")] int y, [NativeTypeName("LONG")] int cx, [NativeTypeName("LONG")] int cy, [NativeTypeName("OLE_XPOS_HIMETRIC")] int xSrc, [NativeTypeName("OLE_YPOS_HIMETRIC")] int ySrc, [NativeTypeName("OLE_XSIZE_HIMETRIC")] int cxSrc, [NativeTypeName("OLE_YSIZE_HIMETRIC")] int cySrc, [NativeTypeName("LPCRECT")] RECT* pRcWBounds)
        {
            return Marshal.GetDelegateForFunctionPointer<_Render>(lpVtbl->Render)((IPicture2*)Unsafe.AsPointer(ref this), hDC, x, y, cx, cy, xSrc, ySrc, cxSrc, cySrc, pRcWBounds);
        }

        [return: NativeTypeName("HRESULT")]
        public int set_hPal([NativeTypeName("HHANDLE")] nuint hPal)
        {
            return Marshal.GetDelegateForFunctionPointer<_set_hPal>(lpVtbl->set_hPal)((IPicture2*)Unsafe.AsPointer(ref this), hPal);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_CurDC([NativeTypeName("HDC *")] IntPtr* phDC)
        {
            return Marshal.GetDelegateForFunctionPointer<_get_CurDC>(lpVtbl->get_CurDC)((IPicture2*)Unsafe.AsPointer(ref this), phDC);
        }

        [return: NativeTypeName("HRESULT")]
        public int SelectPicture([NativeTypeName("HDC")] IntPtr hDCIn, [NativeTypeName("HDC *")] IntPtr* phDCOut, [NativeTypeName("HHANDLE *")] nuint* phBmpOut)
        {
            return Marshal.GetDelegateForFunctionPointer<_SelectPicture>(lpVtbl->SelectPicture)((IPicture2*)Unsafe.AsPointer(ref this), hDCIn, phDCOut, phBmpOut);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_KeepOriginalFormat([NativeTypeName("BOOL *")] int* pKeep)
        {
            return Marshal.GetDelegateForFunctionPointer<_get_KeepOriginalFormat>(lpVtbl->get_KeepOriginalFormat)((IPicture2*)Unsafe.AsPointer(ref this), pKeep);
        }

        [return: NativeTypeName("HRESULT")]
        public int put_KeepOriginalFormat([NativeTypeName("BOOL")] int keep)
        {
            return Marshal.GetDelegateForFunctionPointer<_put_KeepOriginalFormat>(lpVtbl->put_KeepOriginalFormat)((IPicture2*)Unsafe.AsPointer(ref this), keep);
        }

        [return: NativeTypeName("HRESULT")]
        public int PictureChanged()
        {
            return Marshal.GetDelegateForFunctionPointer<_PictureChanged>(lpVtbl->PictureChanged)((IPicture2*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SaveAsFile([NativeTypeName("LPSTREAM")] IStream* pStream, [NativeTypeName("BOOL")] int fSaveMemCopy, [NativeTypeName("LONG *")] int* pCbSize)
        {
            return Marshal.GetDelegateForFunctionPointer<_SaveAsFile>(lpVtbl->SaveAsFile)((IPicture2*)Unsafe.AsPointer(ref this), pStream, fSaveMemCopy, pCbSize);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_Attributes([NativeTypeName("DWORD *")] uint* pDwAttr)
        {
            return Marshal.GetDelegateForFunctionPointer<_get_Attributes>(lpVtbl->get_Attributes)((IPicture2*)Unsafe.AsPointer(ref this), pDwAttr);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (HHANDLE *) __attribute__((stdcall))")]
            public IntPtr get_Handle;

            [NativeTypeName("HRESULT (HHANDLE *) __attribute__((stdcall))")]
            public IntPtr get_hPal;

            [NativeTypeName("HRESULT (SHORT *) __attribute__((stdcall))")]
            public IntPtr get_Type;

            [NativeTypeName("HRESULT (OLE_XSIZE_HIMETRIC *) __attribute__((stdcall))")]
            public IntPtr get_Width;

            [NativeTypeName("HRESULT (OLE_YSIZE_HIMETRIC *) __attribute__((stdcall))")]
            public IntPtr get_Height;

            [NativeTypeName("HRESULT (HDC, LONG, LONG, LONG, LONG, OLE_XPOS_HIMETRIC, OLE_YPOS_HIMETRIC, OLE_XSIZE_HIMETRIC, OLE_YSIZE_HIMETRIC, LPCRECT) __attribute__((stdcall))")]
            public IntPtr Render;

            [NativeTypeName("HRESULT (HHANDLE) __attribute__((stdcall))")]
            public IntPtr set_hPal;

            [NativeTypeName("HRESULT (HDC *) __attribute__((stdcall))")]
            public IntPtr get_CurDC;

            [NativeTypeName("HRESULT (HDC, HDC *, HHANDLE *) __attribute__((stdcall))")]
            public IntPtr SelectPicture;

            [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
            public IntPtr get_KeepOriginalFormat;

            [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
            public IntPtr put_KeepOriginalFormat;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public IntPtr PictureChanged;

            [NativeTypeName("HRESULT (LPSTREAM, BOOL, LONG *) __attribute__((stdcall))")]
            public IntPtr SaveAsFile;

            [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
            public IntPtr get_Attributes;
        }
    }
}
