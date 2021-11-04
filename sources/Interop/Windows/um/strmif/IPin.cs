// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("56A86891-0AD4-11CE-B03A-0020AF0BA770")]
    [NativeTypeName("struct IPin : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IPin
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IPin*, Guid*, void**, int>)(lpVtbl[0]))((IPin*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IPin*, uint>)(lpVtbl[1]))((IPin*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IPin*, uint>)(lpVtbl[2]))((IPin*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT Connect(IPin* pReceivePin, [NativeTypeName("const AM_MEDIA_TYPE *")] AM_MEDIA_TYPE* pmt)
        {
            return ((delegate* unmanaged<IPin*, IPin*, AM_MEDIA_TYPE*, int>)(lpVtbl[3]))((IPin*)Unsafe.AsPointer(ref this), pReceivePin, pmt);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT ReceiveConnection(IPin* pConnector, [NativeTypeName("const AM_MEDIA_TYPE *")] AM_MEDIA_TYPE* pmt)
        {
            return ((delegate* unmanaged<IPin*, IPin*, AM_MEDIA_TYPE*, int>)(lpVtbl[4]))((IPin*)Unsafe.AsPointer(ref this), pConnector, pmt);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT Disconnect()
        {
            return ((delegate* unmanaged<IPin*, int>)(lpVtbl[5]))((IPin*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT ConnectedTo(IPin** pPin)
        {
            return ((delegate* unmanaged<IPin*, IPin**, int>)(lpVtbl[6]))((IPin*)Unsafe.AsPointer(ref this), pPin);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT ConnectionMediaType(AM_MEDIA_TYPE* pmt)
        {
            return ((delegate* unmanaged<IPin*, AM_MEDIA_TYPE*, int>)(lpVtbl[7]))((IPin*)Unsafe.AsPointer(ref this), pmt);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT QueryPinInfo(PIN_INFO* pInfo)
        {
            return ((delegate* unmanaged<IPin*, PIN_INFO*, int>)(lpVtbl[8]))((IPin*)Unsafe.AsPointer(ref this), pInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT QueryDirection(PIN_DIRECTION* pPinDir)
        {
            return ((delegate* unmanaged<IPin*, PIN_DIRECTION*, int>)(lpVtbl[9]))((IPin*)Unsafe.AsPointer(ref this), pPinDir);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT QueryId([NativeTypeName("LPWSTR *")] ushort** Id)
        {
            return ((delegate* unmanaged<IPin*, ushort**, int>)(lpVtbl[10]))((IPin*)Unsafe.AsPointer(ref this), Id);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT QueryAccept([NativeTypeName("const AM_MEDIA_TYPE *")] AM_MEDIA_TYPE* pmt)
        {
            return ((delegate* unmanaged<IPin*, AM_MEDIA_TYPE*, int>)(lpVtbl[11]))((IPin*)Unsafe.AsPointer(ref this), pmt);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT EnumMediaTypes(IEnumMediaTypes** ppEnum)
        {
            return ((delegate* unmanaged<IPin*, IEnumMediaTypes**, int>)(lpVtbl[12]))((IPin*)Unsafe.AsPointer(ref this), ppEnum);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT QueryInternalConnections(IPin** apPin, [NativeTypeName("ULONG *")] uint* nPin)
        {
            return ((delegate* unmanaged<IPin*, IPin**, uint*, int>)(lpVtbl[13]))((IPin*)Unsafe.AsPointer(ref this), apPin, nPin);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT EndOfStream()
        {
            return ((delegate* unmanaged<IPin*, int>)(lpVtbl[14]))((IPin*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT BeginFlush()
        {
            return ((delegate* unmanaged<IPin*, int>)(lpVtbl[15]))((IPin*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT EndFlush()
        {
            return ((delegate* unmanaged<IPin*, int>)(lpVtbl[16]))((IPin*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT NewSegment([NativeTypeName("REFERENCE_TIME")] long tStart, [NativeTypeName("REFERENCE_TIME")] long tStop, double dRate)
        {
            return ((delegate* unmanaged<IPin*, long, long, double, int>)(lpVtbl[17]))((IPin*)Unsafe.AsPointer(ref this), tStart, tStop, dRate);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IPin*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IPin*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IPin*, uint> Release;

            [NativeTypeName("HRESULT (IPin *, const AM_MEDIA_TYPE *) __attribute__((stdcall))")]
            public delegate* unmanaged<IPin*, IPin*, AM_MEDIA_TYPE*, int> Connect;

            [NativeTypeName("HRESULT (IPin *, const AM_MEDIA_TYPE *) __attribute__((stdcall))")]
            public delegate* unmanaged<IPin*, IPin*, AM_MEDIA_TYPE*, int> ReceiveConnection;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IPin*, int> Disconnect;

            [NativeTypeName("HRESULT (IPin **) __attribute__((stdcall))")]
            public delegate* unmanaged<IPin*, IPin**, int> ConnectedTo;

            [NativeTypeName("HRESULT (AM_MEDIA_TYPE *) __attribute__((stdcall))")]
            public delegate* unmanaged<IPin*, AM_MEDIA_TYPE*, int> ConnectionMediaType;

            [NativeTypeName("HRESULT (PIN_INFO *) __attribute__((stdcall))")]
            public delegate* unmanaged<IPin*, PIN_INFO*, int> QueryPinInfo;

            [NativeTypeName("HRESULT (PIN_DIRECTION *) __attribute__((stdcall))")]
            public delegate* unmanaged<IPin*, PIN_DIRECTION*, int> QueryDirection;

            [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IPin*, ushort**, int> QueryId;

            [NativeTypeName("HRESULT (const AM_MEDIA_TYPE *) __attribute__((stdcall))")]
            public delegate* unmanaged<IPin*, AM_MEDIA_TYPE*, int> QueryAccept;

            [NativeTypeName("HRESULT (IEnumMediaTypes **) __attribute__((stdcall))")]
            public delegate* unmanaged<IPin*, IEnumMediaTypes**, int> EnumMediaTypes;

            [NativeTypeName("HRESULT (IPin **, ULONG *) __attribute__((stdcall))")]
            public delegate* unmanaged<IPin*, IPin**, uint*, int> QueryInternalConnections;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IPin*, int> EndOfStream;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IPin*, int> BeginFlush;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IPin*, int> EndFlush;

            [NativeTypeName("HRESULT (REFERENCE_TIME, REFERENCE_TIME, double) __attribute__((stdcall))")]
            public delegate* unmanaged<IPin*, long, long, double, int> NewSegment;
        }
    }
}
