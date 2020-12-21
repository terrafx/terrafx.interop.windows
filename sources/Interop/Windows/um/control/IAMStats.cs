// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/control.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("BC9BCF80-DCD2-11D2-ABF6-00A0C905F375")]
    [NativeTypeName("struct IAMStats : IDispatch")]
    public unsafe partial struct IAMStats
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IAMStats*, Guid*, void**, int>)(lpVtbl[0]))((IAMStats*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IAMStats*, uint>)(lpVtbl[1]))((IAMStats*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IAMStats*, uint>)(lpVtbl[2]))((IAMStats*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* unmanaged[Stdcall]<IAMStats*, uint*, int>)(lpVtbl[3]))((IAMStats*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("ITypeInfo **")] ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged[Stdcall]<IAMStats*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IAMStats*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged[Stdcall]<IAMStats*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IAMStats*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, [NativeTypeName("DISPPARAMS *")] DISPPARAMS* pDispParams, [NativeTypeName("VARIANT *")] VARIANT* pVarResult, [NativeTypeName("EXCEPINFO *")] EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* unmanaged[Stdcall]<IAMStats*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IAMStats*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Reset()
        {
            return ((delegate* unmanaged[Stdcall]<IAMStats*, int>)(lpVtbl[7]))((IAMStats*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Count([NativeTypeName("LONG *")] int* plCount)
        {
            return ((delegate* unmanaged[Stdcall]<IAMStats*, int*, int>)(lpVtbl[8]))((IAMStats*)Unsafe.AsPointer(ref this), plCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetValueByIndex([NativeTypeName("long")] int lIndex, [NativeTypeName("BSTR *")] ushort** szName, [NativeTypeName("long *")] int* lCount, [NativeTypeName("double *")] double* dLast, [NativeTypeName("double *")] double* dAverage, [NativeTypeName("double *")] double* dStdDev, [NativeTypeName("double *")] double* dMin, [NativeTypeName("double *")] double* dMax)
        {
            return ((delegate* unmanaged[Stdcall]<IAMStats*, int, ushort**, int*, double*, double*, double*, double*, double*, int>)(lpVtbl[9]))((IAMStats*)Unsafe.AsPointer(ref this), lIndex, szName, lCount, dLast, dAverage, dStdDev, dMin, dMax);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetValueByName([NativeTypeName("BSTR")] ushort* szName, [NativeTypeName("long *")] int* lIndex, [NativeTypeName("long *")] int* lCount, [NativeTypeName("double *")] double* dLast, [NativeTypeName("double *")] double* dAverage, [NativeTypeName("double *")] double* dStdDev, [NativeTypeName("double *")] double* dMin, [NativeTypeName("double *")] double* dMax)
        {
            return ((delegate* unmanaged[Stdcall]<IAMStats*, ushort*, int*, int*, double*, double*, double*, double*, double*, int>)(lpVtbl[10]))((IAMStats*)Unsafe.AsPointer(ref this), szName, lIndex, lCount, dLast, dAverage, dStdDev, dMin, dMax);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIndex([NativeTypeName("BSTR")] ushort* szName, [NativeTypeName("long")] int lCreate, [NativeTypeName("long *")] int* plIndex)
        {
            return ((delegate* unmanaged[Stdcall]<IAMStats*, ushort*, int, int*, int>)(lpVtbl[11]))((IAMStats*)Unsafe.AsPointer(ref this), szName, lCreate, plIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int AddValue([NativeTypeName("long")] int lIndex, double dValue)
        {
            return ((delegate* unmanaged[Stdcall]<IAMStats*, int, double, int>)(lpVtbl[12]))((IAMStats*)Unsafe.AsPointer(ref this), lIndex, dValue);
        }
    }
}
