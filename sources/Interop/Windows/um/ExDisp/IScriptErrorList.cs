// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ExDisp.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("F3470F24-15FD-11D2-BB2E-00805FF7EFCA")]
    [NativeTypeName("struct IScriptErrorList : IDispatch")]
    [NativeInheritance("IDispatch")]
    public unsafe partial struct IScriptErrorList
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IScriptErrorList*, Guid*, void**, int>)(lpVtbl[0]))((IScriptErrorList*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IScriptErrorList*, uint>)(lpVtbl[1]))((IScriptErrorList*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IScriptErrorList*, uint>)(lpVtbl[2]))((IScriptErrorList*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* unmanaged<IScriptErrorList*, uint*, int>)(lpVtbl[3]))((IScriptErrorList*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<IScriptErrorList*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IScriptErrorList*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<IScriptErrorList*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IScriptErrorList*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* unmanaged<IScriptErrorList*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IScriptErrorList*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int advanceError()
        {
            return ((delegate* unmanaged<IScriptErrorList*, int>)(lpVtbl[7]))((IScriptErrorList*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int retreatError()
        {
            return ((delegate* unmanaged<IScriptErrorList*, int>)(lpVtbl[8]))((IScriptErrorList*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int canAdvanceError(BOOL* pfCanAdvance)
        {
            return ((delegate* unmanaged<IScriptErrorList*, BOOL*, int>)(lpVtbl[9]))((IScriptErrorList*)Unsafe.AsPointer(ref this), pfCanAdvance);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int canRetreatError(BOOL* pfCanRetreat)
        {
            return ((delegate* unmanaged<IScriptErrorList*, BOOL*, int>)(lpVtbl[10]))((IScriptErrorList*)Unsafe.AsPointer(ref this), pfCanRetreat);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int getErrorLine([NativeTypeName("LONG *")] int* plLine)
        {
            return ((delegate* unmanaged<IScriptErrorList*, int*, int>)(lpVtbl[11]))((IScriptErrorList*)Unsafe.AsPointer(ref this), plLine);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("HRESULT")]
        public int getErrorChar([NativeTypeName("LONG *")] int* plChar)
        {
            return ((delegate* unmanaged<IScriptErrorList*, int*, int>)(lpVtbl[12]))((IScriptErrorList*)Unsafe.AsPointer(ref this), plChar);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        [return: NativeTypeName("HRESULT")]
        public int getErrorCode([NativeTypeName("LONG *")] int* plCode)
        {
            return ((delegate* unmanaged<IScriptErrorList*, int*, int>)(lpVtbl[13]))((IScriptErrorList*)Unsafe.AsPointer(ref this), plCode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        [return: NativeTypeName("HRESULT")]
        public int getErrorMsg([NativeTypeName("BSTR *")] ushort** pstr)
        {
            return ((delegate* unmanaged<IScriptErrorList*, ushort**, int>)(lpVtbl[14]))((IScriptErrorList*)Unsafe.AsPointer(ref this), pstr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        [return: NativeTypeName("HRESULT")]
        public int getErrorUrl([NativeTypeName("BSTR *")] ushort** pstr)
        {
            return ((delegate* unmanaged<IScriptErrorList*, ushort**, int>)(lpVtbl[15]))((IScriptErrorList*)Unsafe.AsPointer(ref this), pstr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        [return: NativeTypeName("HRESULT")]
        public int getAlwaysShowLockState(BOOL* pfAlwaysShowLocked)
        {
            return ((delegate* unmanaged<IScriptErrorList*, BOOL*, int>)(lpVtbl[16]))((IScriptErrorList*)Unsafe.AsPointer(ref this), pfAlwaysShowLocked);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        [return: NativeTypeName("HRESULT")]
        public int getDetailsPaneOpen(BOOL* pfDetailsPaneOpen)
        {
            return ((delegate* unmanaged<IScriptErrorList*, BOOL*, int>)(lpVtbl[17]))((IScriptErrorList*)Unsafe.AsPointer(ref this), pfDetailsPaneOpen);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        [return: NativeTypeName("HRESULT")]
        public int setDetailsPaneOpen(BOOL fDetailsPaneOpen)
        {
            return ((delegate* unmanaged<IScriptErrorList*, BOOL, int>)(lpVtbl[18]))((IScriptErrorList*)Unsafe.AsPointer(ref this), fDetailsPaneOpen);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        [return: NativeTypeName("HRESULT")]
        public int getPerErrorDisplay(BOOL* pfPerErrorDisplay)
        {
            return ((delegate* unmanaged<IScriptErrorList*, BOOL*, int>)(lpVtbl[19]))((IScriptErrorList*)Unsafe.AsPointer(ref this), pfPerErrorDisplay);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        [return: NativeTypeName("HRESULT")]
        public int setPerErrorDisplay(BOOL fPerErrorDisplay)
        {
            return ((delegate* unmanaged<IScriptErrorList*, BOOL, int>)(lpVtbl[20]))((IScriptErrorList*)Unsafe.AsPointer(ref this), fPerErrorDisplay);
        }
    }
}
