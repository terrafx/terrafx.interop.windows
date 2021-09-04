// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/shdeprecated.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;

namespace TerraFX.Interop
{
    [NativeTypeName("struct CIE4ConnectionPoint : IConnectionPoint")]
    public unsafe partial struct CIE4ConnectionPoint
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<CIE4ConnectionPoint*, Guid*, void**, int>)(lpVtbl[0]))((CIE4ConnectionPoint*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<CIE4ConnectionPoint*, uint>)(lpVtbl[1]))((CIE4ConnectionPoint*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<CIE4ConnectionPoint*, uint>)(lpVtbl[2]))((CIE4ConnectionPoint*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetConnectionInterface([NativeTypeName("IID *")] Guid* pIID)
        {
            return ((delegate* unmanaged<CIE4ConnectionPoint*, Guid*, int>)(lpVtbl[3]))((CIE4ConnectionPoint*)Unsafe.AsPointer(ref this), pIID);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetConnectionPointContainer(IConnectionPointContainer** ppCPC)
        {
            return ((delegate* unmanaged<CIE4ConnectionPoint*, IConnectionPointContainer**, int>)(lpVtbl[4]))((CIE4ConnectionPoint*)Unsafe.AsPointer(ref this), ppCPC);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Advise(IUnknown* pUnkSink, [NativeTypeName("DWORD *")] uint* pdwCookie)
        {
            return ((delegate* unmanaged<CIE4ConnectionPoint*, IUnknown*, uint*, int>)(lpVtbl[5]))((CIE4ConnectionPoint*)Unsafe.AsPointer(ref this), pUnkSink, pdwCookie);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Unadvise([NativeTypeName("DWORD")] uint dwCookie)
        {
            return ((delegate* unmanaged<CIE4ConnectionPoint*, uint, int>)(lpVtbl[6]))((CIE4ConnectionPoint*)Unsafe.AsPointer(ref this), dwCookie);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int EnumConnections(IEnumConnections** ppEnum)
        {
            return ((delegate* unmanaged<CIE4ConnectionPoint*, IEnumConnections**, int>)(lpVtbl[7]))((CIE4ConnectionPoint*)Unsafe.AsPointer(ref this), ppEnum);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        private int DoInvokeIE4([NativeTypeName("BOOL *")] int* pf, void** ppv, [NativeTypeName("DISPID")] int dispid, DISPPARAMS* pdispparams)
        {
            return ((delegate* unmanaged<CIE4ConnectionPoint*, int*, void**, int, DISPPARAMS*, int>)(lpVtbl[8]))((CIE4ConnectionPoint*)Unsafe.AsPointer(ref this), pf, ppv, dispid, pdispparams);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        private int DoInvokePIDLIE4([NativeTypeName("DISPID")] int dispid, [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl, [NativeTypeName("BOOL")] int fCanCancel)
        {
            return ((delegate* unmanaged<CIE4ConnectionPoint*, int, ITEMIDLIST*, int, int>)(lpVtbl[9]))((CIE4ConnectionPoint*)Unsafe.AsPointer(ref this), dispid, pidl, fCanCancel);
        }
    }
}
