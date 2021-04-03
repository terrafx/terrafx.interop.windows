// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/control.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("56A868B5-0AD4-11CE-B03A-0020AF0BA770")]
    [NativeTypeName("struct IBasicVideo : IDispatch")]
    public unsafe partial struct IBasicVideo
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IBasicVideo*, Guid*, void**, int>)(lpVtbl[0]))((IBasicVideo*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IBasicVideo*, uint>)(lpVtbl[1]))((IBasicVideo*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IBasicVideo*, uint>)(lpVtbl[2]))((IBasicVideo*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* unmanaged<IBasicVideo*, uint*, int>)(lpVtbl[3]))((IBasicVideo*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<IBasicVideo*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IBasicVideo*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<IBasicVideo*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IBasicVideo*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* unmanaged<IBasicVideo*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IBasicVideo*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_AvgTimePerFrame([NativeTypeName("REFTIME *")] double* pAvgTimePerFrame)
        {
            return ((delegate* unmanaged<IBasicVideo*, double*, int>)(lpVtbl[7]))((IBasicVideo*)Unsafe.AsPointer(ref this), pAvgTimePerFrame);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_BitRate([NativeTypeName("long *")] int* pBitRate)
        {
            return ((delegate* unmanaged<IBasicVideo*, int*, int>)(lpVtbl[8]))((IBasicVideo*)Unsafe.AsPointer(ref this), pBitRate);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_BitErrorRate([NativeTypeName("long *")] int* pBitErrorRate)
        {
            return ((delegate* unmanaged<IBasicVideo*, int*, int>)(lpVtbl[9]))((IBasicVideo*)Unsafe.AsPointer(ref this), pBitErrorRate);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_VideoWidth([NativeTypeName("long *")] int* pVideoWidth)
        {
            return ((delegate* unmanaged<IBasicVideo*, int*, int>)(lpVtbl[10]))((IBasicVideo*)Unsafe.AsPointer(ref this), pVideoWidth);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_VideoHeight([NativeTypeName("long *")] int* pVideoHeight)
        {
            return ((delegate* unmanaged<IBasicVideo*, int*, int>)(lpVtbl[11]))((IBasicVideo*)Unsafe.AsPointer(ref this), pVideoHeight);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_SourceLeft([NativeTypeName("long")] int SourceLeft)
        {
            return ((delegate* unmanaged<IBasicVideo*, int, int>)(lpVtbl[12]))((IBasicVideo*)Unsafe.AsPointer(ref this), SourceLeft);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_SourceLeft([NativeTypeName("long *")] int* pSourceLeft)
        {
            return ((delegate* unmanaged<IBasicVideo*, int*, int>)(lpVtbl[13]))((IBasicVideo*)Unsafe.AsPointer(ref this), pSourceLeft);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_SourceWidth([NativeTypeName("long")] int SourceWidth)
        {
            return ((delegate* unmanaged<IBasicVideo*, int, int>)(lpVtbl[14]))((IBasicVideo*)Unsafe.AsPointer(ref this), SourceWidth);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_SourceWidth([NativeTypeName("long *")] int* pSourceWidth)
        {
            return ((delegate* unmanaged<IBasicVideo*, int*, int>)(lpVtbl[15]))((IBasicVideo*)Unsafe.AsPointer(ref this), pSourceWidth);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_SourceTop([NativeTypeName("long")] int SourceTop)
        {
            return ((delegate* unmanaged<IBasicVideo*, int, int>)(lpVtbl[16]))((IBasicVideo*)Unsafe.AsPointer(ref this), SourceTop);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_SourceTop([NativeTypeName("long *")] int* pSourceTop)
        {
            return ((delegate* unmanaged<IBasicVideo*, int*, int>)(lpVtbl[17]))((IBasicVideo*)Unsafe.AsPointer(ref this), pSourceTop);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_SourceHeight([NativeTypeName("long")] int SourceHeight)
        {
            return ((delegate* unmanaged<IBasicVideo*, int, int>)(lpVtbl[18]))((IBasicVideo*)Unsafe.AsPointer(ref this), SourceHeight);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_SourceHeight([NativeTypeName("long *")] int* pSourceHeight)
        {
            return ((delegate* unmanaged<IBasicVideo*, int*, int>)(lpVtbl[19]))((IBasicVideo*)Unsafe.AsPointer(ref this), pSourceHeight);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_DestinationLeft([NativeTypeName("long")] int DestinationLeft)
        {
            return ((delegate* unmanaged<IBasicVideo*, int, int>)(lpVtbl[20]))((IBasicVideo*)Unsafe.AsPointer(ref this), DestinationLeft);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_DestinationLeft([NativeTypeName("long *")] int* pDestinationLeft)
        {
            return ((delegate* unmanaged<IBasicVideo*, int*, int>)(lpVtbl[21]))((IBasicVideo*)Unsafe.AsPointer(ref this), pDestinationLeft);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_DestinationWidth([NativeTypeName("long")] int DestinationWidth)
        {
            return ((delegate* unmanaged<IBasicVideo*, int, int>)(lpVtbl[22]))((IBasicVideo*)Unsafe.AsPointer(ref this), DestinationWidth);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_DestinationWidth([NativeTypeName("long *")] int* pDestinationWidth)
        {
            return ((delegate* unmanaged<IBasicVideo*, int*, int>)(lpVtbl[23]))((IBasicVideo*)Unsafe.AsPointer(ref this), pDestinationWidth);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_DestinationTop([NativeTypeName("long")] int DestinationTop)
        {
            return ((delegate* unmanaged<IBasicVideo*, int, int>)(lpVtbl[24]))((IBasicVideo*)Unsafe.AsPointer(ref this), DestinationTop);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_DestinationTop([NativeTypeName("long *")] int* pDestinationTop)
        {
            return ((delegate* unmanaged<IBasicVideo*, int*, int>)(lpVtbl[25]))((IBasicVideo*)Unsafe.AsPointer(ref this), pDestinationTop);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_DestinationHeight([NativeTypeName("long")] int DestinationHeight)
        {
            return ((delegate* unmanaged<IBasicVideo*, int, int>)(lpVtbl[26]))((IBasicVideo*)Unsafe.AsPointer(ref this), DestinationHeight);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_DestinationHeight([NativeTypeName("long *")] int* pDestinationHeight)
        {
            return ((delegate* unmanaged<IBasicVideo*, int*, int>)(lpVtbl[27]))((IBasicVideo*)Unsafe.AsPointer(ref this), pDestinationHeight);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetSourcePosition([NativeTypeName("long")] int Left, [NativeTypeName("long")] int Top, [NativeTypeName("long")] int Width, [NativeTypeName("long")] int Height)
        {
            return ((delegate* unmanaged<IBasicVideo*, int, int, int, int, int>)(lpVtbl[28]))((IBasicVideo*)Unsafe.AsPointer(ref this), Left, Top, Width, Height);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSourcePosition([NativeTypeName("long *")] int* pLeft, [NativeTypeName("long *")] int* pTop, [NativeTypeName("long *")] int* pWidth, [NativeTypeName("long *")] int* pHeight)
        {
            return ((delegate* unmanaged<IBasicVideo*, int*, int*, int*, int*, int>)(lpVtbl[29]))((IBasicVideo*)Unsafe.AsPointer(ref this), pLeft, pTop, pWidth, pHeight);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetDefaultSourcePosition()
        {
            return ((delegate* unmanaged<IBasicVideo*, int>)(lpVtbl[30]))((IBasicVideo*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetDestinationPosition([NativeTypeName("long")] int Left, [NativeTypeName("long")] int Top, [NativeTypeName("long")] int Width, [NativeTypeName("long")] int Height)
        {
            return ((delegate* unmanaged<IBasicVideo*, int, int, int, int, int>)(lpVtbl[31]))((IBasicVideo*)Unsafe.AsPointer(ref this), Left, Top, Width, Height);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDestinationPosition([NativeTypeName("long *")] int* pLeft, [NativeTypeName("long *")] int* pTop, [NativeTypeName("long *")] int* pWidth, [NativeTypeName("long *")] int* pHeight)
        {
            return ((delegate* unmanaged<IBasicVideo*, int*, int*, int*, int*, int>)(lpVtbl[32]))((IBasicVideo*)Unsafe.AsPointer(ref this), pLeft, pTop, pWidth, pHeight);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetDefaultDestinationPosition()
        {
            return ((delegate* unmanaged<IBasicVideo*, int>)(lpVtbl[33]))((IBasicVideo*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetVideoSize([NativeTypeName("long *")] int* pWidth, [NativeTypeName("long *")] int* pHeight)
        {
            return ((delegate* unmanaged<IBasicVideo*, int*, int*, int>)(lpVtbl[34]))((IBasicVideo*)Unsafe.AsPointer(ref this), pWidth, pHeight);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetVideoPaletteEntries([NativeTypeName("long")] int StartIndex, [NativeTypeName("long")] int Entries, [NativeTypeName("long *")] int* pRetrieved, [NativeTypeName("long *")] int* pPalette)
        {
            return ((delegate* unmanaged<IBasicVideo*, int, int, int*, int*, int>)(lpVtbl[35]))((IBasicVideo*)Unsafe.AsPointer(ref this), StartIndex, Entries, pRetrieved, pPalette);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetCurrentImage([NativeTypeName("long *")] int* pBufferSize, [NativeTypeName("long *")] int* pDIBImage)
        {
            return ((delegate* unmanaged<IBasicVideo*, int*, int*, int>)(lpVtbl[36]))((IBasicVideo*)Unsafe.AsPointer(ref this), pBufferSize, pDIBImage);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int IsUsingDefaultSource()
        {
            return ((delegate* unmanaged<IBasicVideo*, int>)(lpVtbl[37]))((IBasicVideo*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int IsUsingDefaultDestination()
        {
            return ((delegate* unmanaged<IBasicVideo*, int>)(lpVtbl[38]))((IBasicVideo*)Unsafe.AsPointer(ref this));
        }
    }
}
