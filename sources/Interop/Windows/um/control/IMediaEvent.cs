// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/control.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("56A868B6-0AD4-11CE-B03A-0020AF0BA770")]
    [NativeTypeName("struct IMediaEvent : IDispatch")]
    [NativeInheritance("IDispatch")]
    public unsafe partial struct IMediaEvent
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMediaEvent*, Guid*, void**, int>)(lpVtbl[0]))((IMediaEvent*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMediaEvent*, uint>)(lpVtbl[1]))((IMediaEvent*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMediaEvent*, uint>)(lpVtbl[2]))((IMediaEvent*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetTypeInfoCount(uint* pctinfo)
        {
            return ((delegate* unmanaged<IMediaEvent*, uint*, int>)(lpVtbl[3]))((IMediaEvent*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<IMediaEvent*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IMediaEvent*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<IMediaEvent*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IMediaEvent*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
        {
            return ((delegate* unmanaged<IMediaEvent*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IMediaEvent*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT GetEventHandle([NativeTypeName("OAEVENT *")] nint* hEvent)
        {
            return ((delegate* unmanaged<IMediaEvent*, nint*, int>)(lpVtbl[7]))((IMediaEvent*)Unsafe.AsPointer(ref this), hEvent);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT GetEvent([NativeTypeName("long *")] int* lEventCode, [NativeTypeName("LONG_PTR *")] nint* lParam1, [NativeTypeName("LONG_PTR *")] nint* lParam2, [NativeTypeName("long")] int msTimeout)
        {
            return ((delegate* unmanaged<IMediaEvent*, int*, nint*, nint*, int, int>)(lpVtbl[8]))((IMediaEvent*)Unsafe.AsPointer(ref this), lEventCode, lParam1, lParam2, msTimeout);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT WaitForCompletion([NativeTypeName("long")] int msTimeout, [NativeTypeName("long *")] int* pEvCode)
        {
            return ((delegate* unmanaged<IMediaEvent*, int, int*, int>)(lpVtbl[9]))((IMediaEvent*)Unsafe.AsPointer(ref this), msTimeout, pEvCode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT CancelDefaultHandling([NativeTypeName("long")] int lEvCode)
        {
            return ((delegate* unmanaged<IMediaEvent*, int, int>)(lpVtbl[10]))((IMediaEvent*)Unsafe.AsPointer(ref this), lEvCode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT RestoreDefaultHandling([NativeTypeName("long")] int lEvCode)
        {
            return ((delegate* unmanaged<IMediaEvent*, int, int>)(lpVtbl[11]))((IMediaEvent*)Unsafe.AsPointer(ref this), lEvCode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT FreeEventParams([NativeTypeName("long")] int lEvCode, [NativeTypeName("LONG_PTR")] nint lParam1, [NativeTypeName("LONG_PTR")] nint lParam2)
        {
            return ((delegate* unmanaged<IMediaEvent*, int, nint, nint, int>)(lpVtbl[12]))((IMediaEvent*)Unsafe.AsPointer(ref this), lEvCode, lParam1, lParam2);
        }
    }
}
