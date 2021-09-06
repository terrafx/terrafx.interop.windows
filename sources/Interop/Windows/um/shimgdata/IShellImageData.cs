// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/shimgdata.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("BFDEEC12-8040-4403-A5EA-9E07DAFCF530")]
    [NativeTypeName("struct IShellImageData : IUnknown")]
    public unsafe partial struct IShellImageData
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IShellImageData*, Guid*, void**, int>)(lpVtbl[0]))((IShellImageData*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IShellImageData*, uint>)(lpVtbl[1]))((IShellImageData*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IShellImageData*, uint>)(lpVtbl[2]))((IShellImageData*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Decode([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("ULONG")] uint cxDesired, [NativeTypeName("ULONG")] uint cyDesired)
        {
            return ((delegate* unmanaged<IShellImageData*, uint, uint, uint, int>)(lpVtbl[3]))((IShellImageData*)Unsafe.AsPointer(ref this), dwFlags, cxDesired, cyDesired);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Draw([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("LPRECT")] RECT* prcDest, [NativeTypeName("LPRECT")] RECT* prcSrc)
        {
            return ((delegate* unmanaged<IShellImageData*, IntPtr, RECT*, RECT*, int>)(lpVtbl[4]))((IShellImageData*)Unsafe.AsPointer(ref this), hdc, prcDest, prcSrc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int NextFrame()
        {
            return ((delegate* unmanaged<IShellImageData*, int>)(lpVtbl[5]))((IShellImageData*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int NextPage()
        {
            return ((delegate* unmanaged<IShellImageData*, int>)(lpVtbl[6]))((IShellImageData*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int PrevPage()
        {
            return ((delegate* unmanaged<IShellImageData*, int>)(lpVtbl[7]))((IShellImageData*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int IsTransparent()
        {
            return ((delegate* unmanaged<IShellImageData*, int>)(lpVtbl[8]))((IShellImageData*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int IsAnimated()
        {
            return ((delegate* unmanaged<IShellImageData*, int>)(lpVtbl[9]))((IShellImageData*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int IsVector()
        {
            return ((delegate* unmanaged<IShellImageData*, int>)(lpVtbl[10]))((IShellImageData*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int IsMultipage()
        {
            return ((delegate* unmanaged<IShellImageData*, int>)(lpVtbl[11]))((IShellImageData*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int IsEditable()
        {
            return ((delegate* unmanaged<IShellImageData*, int>)(lpVtbl[12]))((IShellImageData*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int IsPrintable()
        {
            return ((delegate* unmanaged<IShellImageData*, int>)(lpVtbl[13]))((IShellImageData*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int IsDecoded()
        {
            return ((delegate* unmanaged<IShellImageData*, int>)(lpVtbl[14]))((IShellImageData*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetCurrentPage([NativeTypeName("ULONG *")] uint* pnPage)
        {
            return ((delegate* unmanaged<IShellImageData*, uint*, int>)(lpVtbl[15]))((IShellImageData*)Unsafe.AsPointer(ref this), pnPage);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPageCount([NativeTypeName("ULONG *")] uint* pcPages)
        {
            return ((delegate* unmanaged<IShellImageData*, uint*, int>)(lpVtbl[16]))((IShellImageData*)Unsafe.AsPointer(ref this), pcPages);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SelectPage([NativeTypeName("ULONG")] uint iPage)
        {
            return ((delegate* unmanaged<IShellImageData*, uint, int>)(lpVtbl[17]))((IShellImageData*)Unsafe.AsPointer(ref this), iPage);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSize(SIZE* pSize)
        {
            return ((delegate* unmanaged<IShellImageData*, SIZE*, int>)(lpVtbl[18]))((IShellImageData*)Unsafe.AsPointer(ref this), pSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRawDataFormat([NativeTypeName("GUID *")] Guid* pDataFormat)
        {
            return ((delegate* unmanaged<IShellImageData*, Guid*, int>)(lpVtbl[19]))((IShellImageData*)Unsafe.AsPointer(ref this), pDataFormat);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPixelFormat([NativeTypeName("PixelFormat *")] uint* pFormat)
        {
            return ((delegate* unmanaged<IShellImageData*, uint*, int>)(lpVtbl[20]))((IShellImageData*)Unsafe.AsPointer(ref this), pFormat);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDelay([NativeTypeName("DWORD *")] uint* pdwDelay)
        {
            return ((delegate* unmanaged<IShellImageData*, uint*, int>)(lpVtbl[21]))((IShellImageData*)Unsafe.AsPointer(ref this), pdwDelay);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetProperties([NativeTypeName("DWORD")] uint dwMode, IPropertySetStorage** ppPropSet)
        {
            return ((delegate* unmanaged<IShellImageData*, uint, IPropertySetStorage**, int>)(lpVtbl[22]))((IShellImageData*)Unsafe.AsPointer(ref this), dwMode, ppPropSet);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Rotate([NativeTypeName("DWORD")] uint dwAngle)
        {
            return ((delegate* unmanaged<IShellImageData*, uint, int>)(lpVtbl[23]))((IShellImageData*)Unsafe.AsPointer(ref this), dwAngle);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Scale([NativeTypeName("ULONG")] uint cx, [NativeTypeName("ULONG")] uint cy, [NativeTypeName("InterpolationMode")] uint hints)
        {
            return ((delegate* unmanaged<IShellImageData*, uint, uint, uint, int>)(lpVtbl[24]))((IShellImageData*)Unsafe.AsPointer(ref this), cx, cy, hints);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int DiscardEdit()
        {
            return ((delegate* unmanaged<IShellImageData*, int>)(lpVtbl[25]))((IShellImageData*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetEncoderParams(IPropertyBag* pbagEnc)
        {
            return ((delegate* unmanaged<IShellImageData*, IPropertyBag*, int>)(lpVtbl[26]))((IShellImageData*)Unsafe.AsPointer(ref this), pbagEnc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int DisplayName([NativeTypeName("LPWSTR")] ushort* wszName, [NativeTypeName("UINT")] uint cch)
        {
            return ((delegate* unmanaged<IShellImageData*, ushort*, uint, int>)(lpVtbl[27]))((IShellImageData*)Unsafe.AsPointer(ref this), wszName, cch);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetResolution([NativeTypeName("ULONG *")] uint* puResolutionX, [NativeTypeName("ULONG *")] uint* puResolutionY)
        {
            return ((delegate* unmanaged<IShellImageData*, uint*, uint*, int>)(lpVtbl[28]))((IShellImageData*)Unsafe.AsPointer(ref this), puResolutionX, puResolutionY);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetEncoderParams([NativeTypeName("GUID *")] Guid* pguidFmt, [NativeTypeName("EncoderParameters **")] byte** ppEncParams)
        {
            return ((delegate* unmanaged<IShellImageData*, Guid*, byte**, int>)(lpVtbl[29]))((IShellImageData*)Unsafe.AsPointer(ref this), pguidFmt, ppEncParams);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RegisterAbort(IShellImageDataAbort* pAbort, IShellImageDataAbort** ppAbortPrev)
        {
            return ((delegate* unmanaged<IShellImageData*, IShellImageDataAbort*, IShellImageDataAbort**, int>)(lpVtbl[30]))((IShellImageData*)Unsafe.AsPointer(ref this), pAbort, ppAbortPrev);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CloneFrame([NativeTypeName("Image **")] byte** ppImg)
        {
            return ((delegate* unmanaged<IShellImageData*, byte**, int>)(lpVtbl[31]))((IShellImageData*)Unsafe.AsPointer(ref this), ppImg);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ReplaceFrame([NativeTypeName("Image *")] byte* pImg)
        {
            return ((delegate* unmanaged<IShellImageData*, byte*, int>)(lpVtbl[32]))((IShellImageData*)Unsafe.AsPointer(ref this), pImg);
        }
    }
}
