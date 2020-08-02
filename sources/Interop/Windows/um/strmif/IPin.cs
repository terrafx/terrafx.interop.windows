// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("56A86891-0AD4-11CE-B03A-0020AF0BA770")]
    public unsafe partial struct IPin
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IPin*, Guid*, void**, int>)(lpVtbl[0]))((IPin*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IPin*, uint>)(lpVtbl[1]))((IPin*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IPin*, uint>)(lpVtbl[2]))((IPin*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Connect([NativeTypeName("IPin *")] IPin* pReceivePin, [NativeTypeName("const AM_MEDIA_TYPE *")] AM_MEDIA_TYPE* pmt)
        {
            return ((delegate* stdcall<IPin*, IPin*, AM_MEDIA_TYPE*, int>)(lpVtbl[3]))((IPin*)Unsafe.AsPointer(ref this), pReceivePin, pmt);
        }

        [return: NativeTypeName("HRESULT")]
        public int ReceiveConnection([NativeTypeName("IPin *")] IPin* pConnector, [NativeTypeName("const AM_MEDIA_TYPE *")] AM_MEDIA_TYPE* pmt)
        {
            return ((delegate* stdcall<IPin*, IPin*, AM_MEDIA_TYPE*, int>)(lpVtbl[4]))((IPin*)Unsafe.AsPointer(ref this), pConnector, pmt);
        }

        [return: NativeTypeName("HRESULT")]
        public int Disconnect()
        {
            return ((delegate* stdcall<IPin*, int>)(lpVtbl[5]))((IPin*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int ConnectedTo([NativeTypeName("IPin **")] IPin** pPin)
        {
            return ((delegate* stdcall<IPin*, IPin**, int>)(lpVtbl[6]))((IPin*)Unsafe.AsPointer(ref this), pPin);
        }

        [return: NativeTypeName("HRESULT")]
        public int ConnectionMediaType([NativeTypeName("AM_MEDIA_TYPE *")] AM_MEDIA_TYPE* pmt)
        {
            return ((delegate* stdcall<IPin*, AM_MEDIA_TYPE*, int>)(lpVtbl[7]))((IPin*)Unsafe.AsPointer(ref this), pmt);
        }

        [return: NativeTypeName("HRESULT")]
        public int QueryPinInfo([NativeTypeName("PIN_INFO *")] PIN_INFO* pInfo)
        {
            return ((delegate* stdcall<IPin*, PIN_INFO*, int>)(lpVtbl[8]))((IPin*)Unsafe.AsPointer(ref this), pInfo);
        }

        [return: NativeTypeName("HRESULT")]
        public int QueryDirection([NativeTypeName("PIN_DIRECTION *")] PIN_DIRECTION* pPinDir)
        {
            return ((delegate* stdcall<IPin*, PIN_DIRECTION*, int>)(lpVtbl[9]))((IPin*)Unsafe.AsPointer(ref this), pPinDir);
        }

        [return: NativeTypeName("HRESULT")]
        public int QueryId([NativeTypeName("LPWSTR *")] ushort** Id)
        {
            return ((delegate* stdcall<IPin*, ushort**, int>)(lpVtbl[10]))((IPin*)Unsafe.AsPointer(ref this), Id);
        }

        [return: NativeTypeName("HRESULT")]
        public int QueryAccept([NativeTypeName("const AM_MEDIA_TYPE *")] AM_MEDIA_TYPE* pmt)
        {
            return ((delegate* stdcall<IPin*, AM_MEDIA_TYPE*, int>)(lpVtbl[11]))((IPin*)Unsafe.AsPointer(ref this), pmt);
        }

        [return: NativeTypeName("HRESULT")]
        public int EnumMediaTypes([NativeTypeName("IEnumMediaTypes **")] IEnumMediaTypes** ppEnum)
        {
            return ((delegate* stdcall<IPin*, IEnumMediaTypes**, int>)(lpVtbl[12]))((IPin*)Unsafe.AsPointer(ref this), ppEnum);
        }

        [return: NativeTypeName("HRESULT")]
        public int QueryInternalConnections([NativeTypeName("IPin **")] IPin** apPin, [NativeTypeName("ULONG *")] uint* nPin)
        {
            return ((delegate* stdcall<IPin*, IPin**, uint*, int>)(lpVtbl[13]))((IPin*)Unsafe.AsPointer(ref this), apPin, nPin);
        }

        [return: NativeTypeName("HRESULT")]
        public int EndOfStream()
        {
            return ((delegate* stdcall<IPin*, int>)(lpVtbl[14]))((IPin*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int BeginFlush()
        {
            return ((delegate* stdcall<IPin*, int>)(lpVtbl[15]))((IPin*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int EndFlush()
        {
            return ((delegate* stdcall<IPin*, int>)(lpVtbl[16]))((IPin*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int NewSegment([NativeTypeName("REFERENCE_TIME")] long tStart, [NativeTypeName("REFERENCE_TIME")] long tStop, double dRate)
        {
            return ((delegate* stdcall<IPin*, long, long, double, int>)(lpVtbl[17]))((IPin*)Unsafe.AsPointer(ref this), tStart, tStop, dRate);
        }
    }
}
