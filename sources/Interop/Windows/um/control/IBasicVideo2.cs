// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/control.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("329BB360-F6EA-11D1-9038-00A0C9697298")]
    [NativeTypeName("struct IBasicVideo2 : IBasicVideo")]
    [NativeInheritance("IBasicVideo")]
    public unsafe partial struct IBasicVideo2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IBasicVideo2*, Guid*, void**, int>)(lpVtbl[0]))((IBasicVideo2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IBasicVideo2*, uint>)(lpVtbl[1]))((IBasicVideo2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IBasicVideo2*, uint>)(lpVtbl[2]))((IBasicVideo2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetTypeInfoCount(uint* pctinfo)
        {
            return ((delegate* unmanaged<IBasicVideo2*, uint*, int>)(lpVtbl[3]))((IBasicVideo2*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<IBasicVideo2*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IBasicVideo2*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<IBasicVideo2*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IBasicVideo2*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
        {
            return ((delegate* unmanaged<IBasicVideo2*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IBasicVideo2*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT get_AvgTimePerFrame([NativeTypeName("REFTIME *")] double* pAvgTimePerFrame)
        {
            return ((delegate* unmanaged<IBasicVideo2*, double*, int>)(lpVtbl[7]))((IBasicVideo2*)Unsafe.AsPointer(ref this), pAvgTimePerFrame);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT get_BitRate([NativeTypeName("long *")] int* pBitRate)
        {
            return ((delegate* unmanaged<IBasicVideo2*, int*, int>)(lpVtbl[8]))((IBasicVideo2*)Unsafe.AsPointer(ref this), pBitRate);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT get_BitErrorRate([NativeTypeName("long *")] int* pBitErrorRate)
        {
            return ((delegate* unmanaged<IBasicVideo2*, int*, int>)(lpVtbl[9]))((IBasicVideo2*)Unsafe.AsPointer(ref this), pBitErrorRate);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT get_VideoWidth([NativeTypeName("long *")] int* pVideoWidth)
        {
            return ((delegate* unmanaged<IBasicVideo2*, int*, int>)(lpVtbl[10]))((IBasicVideo2*)Unsafe.AsPointer(ref this), pVideoWidth);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT get_VideoHeight([NativeTypeName("long *")] int* pVideoHeight)
        {
            return ((delegate* unmanaged<IBasicVideo2*, int*, int>)(lpVtbl[11]))((IBasicVideo2*)Unsafe.AsPointer(ref this), pVideoHeight);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT put_SourceLeft([NativeTypeName("long")] int SourceLeft)
        {
            return ((delegate* unmanaged<IBasicVideo2*, int, int>)(lpVtbl[12]))((IBasicVideo2*)Unsafe.AsPointer(ref this), SourceLeft);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT get_SourceLeft([NativeTypeName("long *")] int* pSourceLeft)
        {
            return ((delegate* unmanaged<IBasicVideo2*, int*, int>)(lpVtbl[13]))((IBasicVideo2*)Unsafe.AsPointer(ref this), pSourceLeft);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT put_SourceWidth([NativeTypeName("long")] int SourceWidth)
        {
            return ((delegate* unmanaged<IBasicVideo2*, int, int>)(lpVtbl[14]))((IBasicVideo2*)Unsafe.AsPointer(ref this), SourceWidth);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT get_SourceWidth([NativeTypeName("long *")] int* pSourceWidth)
        {
            return ((delegate* unmanaged<IBasicVideo2*, int*, int>)(lpVtbl[15]))((IBasicVideo2*)Unsafe.AsPointer(ref this), pSourceWidth);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT put_SourceTop([NativeTypeName("long")] int SourceTop)
        {
            return ((delegate* unmanaged<IBasicVideo2*, int, int>)(lpVtbl[16]))((IBasicVideo2*)Unsafe.AsPointer(ref this), SourceTop);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT get_SourceTop([NativeTypeName("long *")] int* pSourceTop)
        {
            return ((delegate* unmanaged<IBasicVideo2*, int*, int>)(lpVtbl[17]))((IBasicVideo2*)Unsafe.AsPointer(ref this), pSourceTop);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public HRESULT put_SourceHeight([NativeTypeName("long")] int SourceHeight)
        {
            return ((delegate* unmanaged<IBasicVideo2*, int, int>)(lpVtbl[18]))((IBasicVideo2*)Unsafe.AsPointer(ref this), SourceHeight);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public HRESULT get_SourceHeight([NativeTypeName("long *")] int* pSourceHeight)
        {
            return ((delegate* unmanaged<IBasicVideo2*, int*, int>)(lpVtbl[19]))((IBasicVideo2*)Unsafe.AsPointer(ref this), pSourceHeight);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        public HRESULT put_DestinationLeft([NativeTypeName("long")] int DestinationLeft)
        {
            return ((delegate* unmanaged<IBasicVideo2*, int, int>)(lpVtbl[20]))((IBasicVideo2*)Unsafe.AsPointer(ref this), DestinationLeft);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        public HRESULT get_DestinationLeft([NativeTypeName("long *")] int* pDestinationLeft)
        {
            return ((delegate* unmanaged<IBasicVideo2*, int*, int>)(lpVtbl[21]))((IBasicVideo2*)Unsafe.AsPointer(ref this), pDestinationLeft);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        public HRESULT put_DestinationWidth([NativeTypeName("long")] int DestinationWidth)
        {
            return ((delegate* unmanaged<IBasicVideo2*, int, int>)(lpVtbl[22]))((IBasicVideo2*)Unsafe.AsPointer(ref this), DestinationWidth);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        public HRESULT get_DestinationWidth([NativeTypeName("long *")] int* pDestinationWidth)
        {
            return ((delegate* unmanaged<IBasicVideo2*, int*, int>)(lpVtbl[23]))((IBasicVideo2*)Unsafe.AsPointer(ref this), pDestinationWidth);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        public HRESULT put_DestinationTop([NativeTypeName("long")] int DestinationTop)
        {
            return ((delegate* unmanaged<IBasicVideo2*, int, int>)(lpVtbl[24]))((IBasicVideo2*)Unsafe.AsPointer(ref this), DestinationTop);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        public HRESULT get_DestinationTop([NativeTypeName("long *")] int* pDestinationTop)
        {
            return ((delegate* unmanaged<IBasicVideo2*, int*, int>)(lpVtbl[25]))((IBasicVideo2*)Unsafe.AsPointer(ref this), pDestinationTop);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        public HRESULT put_DestinationHeight([NativeTypeName("long")] int DestinationHeight)
        {
            return ((delegate* unmanaged<IBasicVideo2*, int, int>)(lpVtbl[26]))((IBasicVideo2*)Unsafe.AsPointer(ref this), DestinationHeight);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        public HRESULT get_DestinationHeight([NativeTypeName("long *")] int* pDestinationHeight)
        {
            return ((delegate* unmanaged<IBasicVideo2*, int*, int>)(lpVtbl[27]))((IBasicVideo2*)Unsafe.AsPointer(ref this), pDestinationHeight);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(28)]
        public HRESULT SetSourcePosition([NativeTypeName("long")] int Left, [NativeTypeName("long")] int Top, [NativeTypeName("long")] int Width, [NativeTypeName("long")] int Height)
        {
            return ((delegate* unmanaged<IBasicVideo2*, int, int, int, int, int>)(lpVtbl[28]))((IBasicVideo2*)Unsafe.AsPointer(ref this), Left, Top, Width, Height);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(29)]
        public HRESULT GetSourcePosition([NativeTypeName("long *")] int* pLeft, [NativeTypeName("long *")] int* pTop, [NativeTypeName("long *")] int* pWidth, [NativeTypeName("long *")] int* pHeight)
        {
            return ((delegate* unmanaged<IBasicVideo2*, int*, int*, int*, int*, int>)(lpVtbl[29]))((IBasicVideo2*)Unsafe.AsPointer(ref this), pLeft, pTop, pWidth, pHeight);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(30)]
        public HRESULT SetDefaultSourcePosition()
        {
            return ((delegate* unmanaged<IBasicVideo2*, int>)(lpVtbl[30]))((IBasicVideo2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(31)]
        public HRESULT SetDestinationPosition([NativeTypeName("long")] int Left, [NativeTypeName("long")] int Top, [NativeTypeName("long")] int Width, [NativeTypeName("long")] int Height)
        {
            return ((delegate* unmanaged<IBasicVideo2*, int, int, int, int, int>)(lpVtbl[31]))((IBasicVideo2*)Unsafe.AsPointer(ref this), Left, Top, Width, Height);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(32)]
        public HRESULT GetDestinationPosition([NativeTypeName("long *")] int* pLeft, [NativeTypeName("long *")] int* pTop, [NativeTypeName("long *")] int* pWidth, [NativeTypeName("long *")] int* pHeight)
        {
            return ((delegate* unmanaged<IBasicVideo2*, int*, int*, int*, int*, int>)(lpVtbl[32]))((IBasicVideo2*)Unsafe.AsPointer(ref this), pLeft, pTop, pWidth, pHeight);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(33)]
        public HRESULT SetDefaultDestinationPosition()
        {
            return ((delegate* unmanaged<IBasicVideo2*, int>)(lpVtbl[33]))((IBasicVideo2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(34)]
        public HRESULT GetVideoSize([NativeTypeName("long *")] int* pWidth, [NativeTypeName("long *")] int* pHeight)
        {
            return ((delegate* unmanaged<IBasicVideo2*, int*, int*, int>)(lpVtbl[34]))((IBasicVideo2*)Unsafe.AsPointer(ref this), pWidth, pHeight);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(35)]
        public HRESULT GetVideoPaletteEntries([NativeTypeName("long")] int StartIndex, [NativeTypeName("long")] int Entries, [NativeTypeName("long *")] int* pRetrieved, [NativeTypeName("long *")] int* pPalette)
        {
            return ((delegate* unmanaged<IBasicVideo2*, int, int, int*, int*, int>)(lpVtbl[35]))((IBasicVideo2*)Unsafe.AsPointer(ref this), StartIndex, Entries, pRetrieved, pPalette);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(36)]
        public HRESULT GetCurrentImage([NativeTypeName("long *")] int* pBufferSize, [NativeTypeName("long *")] int* pDIBImage)
        {
            return ((delegate* unmanaged<IBasicVideo2*, int*, int*, int>)(lpVtbl[36]))((IBasicVideo2*)Unsafe.AsPointer(ref this), pBufferSize, pDIBImage);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(37)]
        public HRESULT IsUsingDefaultSource()
        {
            return ((delegate* unmanaged<IBasicVideo2*, int>)(lpVtbl[37]))((IBasicVideo2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(38)]
        public HRESULT IsUsingDefaultDestination()
        {
            return ((delegate* unmanaged<IBasicVideo2*, int>)(lpVtbl[38]))((IBasicVideo2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(39)]
        public HRESULT GetPreferredAspectRatio([NativeTypeName("long *")] int* plAspectX, [NativeTypeName("long *")] int* plAspectY)
        {
            return ((delegate* unmanaged<IBasicVideo2*, int*, int*, int>)(lpVtbl[39]))((IBasicVideo2*)Unsafe.AsPointer(ref this), plAspectX, plAspectY);
        }
    }
}
