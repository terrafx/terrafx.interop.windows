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
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IShellImageData
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IShellImageData*, Guid*, void**, int>)(lpVtbl[0]))((IShellImageData*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IShellImageData*, uint>)(lpVtbl[1]))((IShellImageData*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IShellImageData*, uint>)(lpVtbl[2]))((IShellImageData*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT Decode([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("ULONG")] uint cxDesired, [NativeTypeName("ULONG")] uint cyDesired)
        {
            return ((delegate* unmanaged<IShellImageData*, uint, uint, uint, int>)(lpVtbl[3]))((IShellImageData*)Unsafe.AsPointer(ref this), dwFlags, cxDesired, cyDesired);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT Draw(HDC hdc, [NativeTypeName("LPRECT")] RECT* prcDest, [NativeTypeName("LPRECT")] RECT* prcSrc)
        {
            return ((delegate* unmanaged<IShellImageData*, HDC, RECT*, RECT*, int>)(lpVtbl[4]))((IShellImageData*)Unsafe.AsPointer(ref this), hdc, prcDest, prcSrc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT NextFrame()
        {
            return ((delegate* unmanaged<IShellImageData*, int>)(lpVtbl[5]))((IShellImageData*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT NextPage()
        {
            return ((delegate* unmanaged<IShellImageData*, int>)(lpVtbl[6]))((IShellImageData*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT PrevPage()
        {
            return ((delegate* unmanaged<IShellImageData*, int>)(lpVtbl[7]))((IShellImageData*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT IsTransparent()
        {
            return ((delegate* unmanaged<IShellImageData*, int>)(lpVtbl[8]))((IShellImageData*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT IsAnimated()
        {
            return ((delegate* unmanaged<IShellImageData*, int>)(lpVtbl[9]))((IShellImageData*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT IsVector()
        {
            return ((delegate* unmanaged<IShellImageData*, int>)(lpVtbl[10]))((IShellImageData*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT IsMultipage()
        {
            return ((delegate* unmanaged<IShellImageData*, int>)(lpVtbl[11]))((IShellImageData*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT IsEditable()
        {
            return ((delegate* unmanaged<IShellImageData*, int>)(lpVtbl[12]))((IShellImageData*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT IsPrintable()
        {
            return ((delegate* unmanaged<IShellImageData*, int>)(lpVtbl[13]))((IShellImageData*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT IsDecoded()
        {
            return ((delegate* unmanaged<IShellImageData*, int>)(lpVtbl[14]))((IShellImageData*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT GetCurrentPage([NativeTypeName("ULONG *")] uint* pnPage)
        {
            return ((delegate* unmanaged<IShellImageData*, uint*, int>)(lpVtbl[15]))((IShellImageData*)Unsafe.AsPointer(ref this), pnPage);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT GetPageCount([NativeTypeName("ULONG *")] uint* pcPages)
        {
            return ((delegate* unmanaged<IShellImageData*, uint*, int>)(lpVtbl[16]))((IShellImageData*)Unsafe.AsPointer(ref this), pcPages);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT SelectPage([NativeTypeName("ULONG")] uint iPage)
        {
            return ((delegate* unmanaged<IShellImageData*, uint, int>)(lpVtbl[17]))((IShellImageData*)Unsafe.AsPointer(ref this), iPage);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public HRESULT GetSize(SIZE* pSize)
        {
            return ((delegate* unmanaged<IShellImageData*, SIZE*, int>)(lpVtbl[18]))((IShellImageData*)Unsafe.AsPointer(ref this), pSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public HRESULT GetRawDataFormat(Guid* pDataFormat)
        {
            return ((delegate* unmanaged<IShellImageData*, Guid*, int>)(lpVtbl[19]))((IShellImageData*)Unsafe.AsPointer(ref this), pDataFormat);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        public HRESULT GetPixelFormat([NativeTypeName("PixelFormat *")] uint* pFormat)
        {
            return ((delegate* unmanaged<IShellImageData*, uint*, int>)(lpVtbl[20]))((IShellImageData*)Unsafe.AsPointer(ref this), pFormat);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        public HRESULT GetDelay([NativeTypeName("DWORD *")] uint* pdwDelay)
        {
            return ((delegate* unmanaged<IShellImageData*, uint*, int>)(lpVtbl[21]))((IShellImageData*)Unsafe.AsPointer(ref this), pdwDelay);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        public HRESULT GetProperties([NativeTypeName("DWORD")] uint dwMode, IPropertySetStorage** ppPropSet)
        {
            return ((delegate* unmanaged<IShellImageData*, uint, IPropertySetStorage**, int>)(lpVtbl[22]))((IShellImageData*)Unsafe.AsPointer(ref this), dwMode, ppPropSet);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        public HRESULT Rotate([NativeTypeName("DWORD")] uint dwAngle)
        {
            return ((delegate* unmanaged<IShellImageData*, uint, int>)(lpVtbl[23]))((IShellImageData*)Unsafe.AsPointer(ref this), dwAngle);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        public HRESULT Scale([NativeTypeName("ULONG")] uint cx, [NativeTypeName("ULONG")] uint cy, [NativeTypeName("InterpolationMode")] uint hints)
        {
            return ((delegate* unmanaged<IShellImageData*, uint, uint, uint, int>)(lpVtbl[24]))((IShellImageData*)Unsafe.AsPointer(ref this), cx, cy, hints);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        public HRESULT DiscardEdit()
        {
            return ((delegate* unmanaged<IShellImageData*, int>)(lpVtbl[25]))((IShellImageData*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        public HRESULT SetEncoderParams(IPropertyBag* pbagEnc)
        {
            return ((delegate* unmanaged<IShellImageData*, IPropertyBag*, int>)(lpVtbl[26]))((IShellImageData*)Unsafe.AsPointer(ref this), pbagEnc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        public HRESULT DisplayName([NativeTypeName("LPWSTR")] ushort* wszName, uint cch)
        {
            return ((delegate* unmanaged<IShellImageData*, ushort*, uint, int>)(lpVtbl[27]))((IShellImageData*)Unsafe.AsPointer(ref this), wszName, cch);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(28)]
        public HRESULT GetResolution([NativeTypeName("ULONG *")] uint* puResolutionX, [NativeTypeName("ULONG *")] uint* puResolutionY)
        {
            return ((delegate* unmanaged<IShellImageData*, uint*, uint*, int>)(lpVtbl[28]))((IShellImageData*)Unsafe.AsPointer(ref this), puResolutionX, puResolutionY);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(29)]
        public HRESULT GetEncoderParams(Guid* pguidFmt, [NativeTypeName("EncoderParameters **")] byte** ppEncParams)
        {
            return ((delegate* unmanaged<IShellImageData*, Guid*, byte**, int>)(lpVtbl[29]))((IShellImageData*)Unsafe.AsPointer(ref this), pguidFmt, ppEncParams);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(30)]
        public HRESULT RegisterAbort(IShellImageDataAbort* pAbort, IShellImageDataAbort** ppAbortPrev)
        {
            return ((delegate* unmanaged<IShellImageData*, IShellImageDataAbort*, IShellImageDataAbort**, int>)(lpVtbl[30]))((IShellImageData*)Unsafe.AsPointer(ref this), pAbort, ppAbortPrev);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(31)]
        public HRESULT CloneFrame([NativeTypeName("Image **")] byte** ppImg)
        {
            return ((delegate* unmanaged<IShellImageData*, byte**, int>)(lpVtbl[31]))((IShellImageData*)Unsafe.AsPointer(ref this), ppImg);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(32)]
        public HRESULT ReplaceFrame([NativeTypeName("Image *")] byte* pImg)
        {
            return ((delegate* unmanaged<IShellImageData*, byte*, int>)(lpVtbl[32]))((IShellImageData*)Unsafe.AsPointer(ref this), pImg);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IShellImageData*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IShellImageData*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IShellImageData*, uint> Release;

            [NativeTypeName("HRESULT (DWORD, ULONG, ULONG) __attribute__((stdcall))")]
            public delegate* unmanaged<IShellImageData*, uint, uint, uint, int> Decode;

            [NativeTypeName("HRESULT (HDC, LPRECT, LPRECT) __attribute__((stdcall))")]
            public delegate* unmanaged<IShellImageData*, HDC, RECT*, RECT*, int> Draw;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IShellImageData*, int> NextFrame;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IShellImageData*, int> NextPage;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IShellImageData*, int> PrevPage;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IShellImageData*, int> IsTransparent;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IShellImageData*, int> IsAnimated;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IShellImageData*, int> IsVector;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IShellImageData*, int> IsMultipage;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IShellImageData*, int> IsEditable;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IShellImageData*, int> IsPrintable;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IShellImageData*, int> IsDecoded;

            [NativeTypeName("HRESULT (ULONG *) __attribute__((stdcall))")]
            public delegate* unmanaged<IShellImageData*, uint*, int> GetCurrentPage;

            [NativeTypeName("HRESULT (ULONG *) __attribute__((stdcall))")]
            public delegate* unmanaged<IShellImageData*, uint*, int> GetPageCount;

            [NativeTypeName("HRESULT (ULONG) __attribute__((stdcall))")]
            public delegate* unmanaged<IShellImageData*, uint, int> SelectPage;

            [NativeTypeName("HRESULT (SIZE *) __attribute__((stdcall))")]
            public delegate* unmanaged<IShellImageData*, SIZE*, int> GetSize;

            [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
            public delegate* unmanaged<IShellImageData*, Guid*, int> GetRawDataFormat;

            [NativeTypeName("HRESULT (PixelFormat *) __attribute__((stdcall))")]
            public delegate* unmanaged<IShellImageData*, uint*, int> GetPixelFormat;

            [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
            public delegate* unmanaged<IShellImageData*, uint*, int> GetDelay;

            [NativeTypeName("HRESULT (DWORD, IPropertySetStorage **) __attribute__((stdcall))")]
            public delegate* unmanaged<IShellImageData*, uint, IPropertySetStorage**, int> GetProperties;

            [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged<IShellImageData*, uint, int> Rotate;

            [NativeTypeName("HRESULT (ULONG, ULONG, InterpolationMode) __attribute__((stdcall))")]
            public delegate* unmanaged<IShellImageData*, uint, uint, uint, int> Scale;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IShellImageData*, int> DiscardEdit;

            [NativeTypeName("HRESULT (IPropertyBag *) __attribute__((stdcall))")]
            public delegate* unmanaged<IShellImageData*, IPropertyBag*, int> SetEncoderParams;

            [NativeTypeName("HRESULT (LPWSTR, UINT) __attribute__((stdcall))")]
            public delegate* unmanaged<IShellImageData*, ushort*, uint, int> DisplayName;

            [NativeTypeName("HRESULT (ULONG *, ULONG *) __attribute__((stdcall))")]
            public delegate* unmanaged<IShellImageData*, uint*, uint*, int> GetResolution;

            [NativeTypeName("HRESULT (GUID *, EncoderParameters **) __attribute__((stdcall))")]
            public delegate* unmanaged<IShellImageData*, Guid*, byte**, int> GetEncoderParams;

            [NativeTypeName("HRESULT (IShellImageDataAbort *, IShellImageDataAbort **) __attribute__((stdcall))")]
            public delegate* unmanaged<IShellImageData*, IShellImageDataAbort*, IShellImageDataAbort**, int> RegisterAbort;

            [NativeTypeName("HRESULT (Image **) __attribute__((stdcall))")]
            public delegate* unmanaged<IShellImageData*, byte**, int> CloneFrame;

            [NativeTypeName("HRESULT (Image *) __attribute__((stdcall))")]
            public delegate* unmanaged<IShellImageData*, byte*, int> ReplaceFrame;
        }
    }
}
