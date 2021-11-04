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
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
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
        public HRESULT GetTypeInfoCount(uint* pctinfo)
        {
            return ((delegate* unmanaged<IScriptErrorList*, uint*, int>)(lpVtbl[3]))((IScriptErrorList*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<IScriptErrorList*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IScriptErrorList*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<IScriptErrorList*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IScriptErrorList*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
        {
            return ((delegate* unmanaged<IScriptErrorList*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IScriptErrorList*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT advanceError()
        {
            return ((delegate* unmanaged<IScriptErrorList*, int>)(lpVtbl[7]))((IScriptErrorList*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT retreatError()
        {
            return ((delegate* unmanaged<IScriptErrorList*, int>)(lpVtbl[8]))((IScriptErrorList*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT canAdvanceError(BOOL* pfCanAdvance)
        {
            return ((delegate* unmanaged<IScriptErrorList*, BOOL*, int>)(lpVtbl[9]))((IScriptErrorList*)Unsafe.AsPointer(ref this), pfCanAdvance);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT canRetreatError(BOOL* pfCanRetreat)
        {
            return ((delegate* unmanaged<IScriptErrorList*, BOOL*, int>)(lpVtbl[10]))((IScriptErrorList*)Unsafe.AsPointer(ref this), pfCanRetreat);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT getErrorLine([NativeTypeName("LONG *")] int* plLine)
        {
            return ((delegate* unmanaged<IScriptErrorList*, int*, int>)(lpVtbl[11]))((IScriptErrorList*)Unsafe.AsPointer(ref this), plLine);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT getErrorChar([NativeTypeName("LONG *")] int* plChar)
        {
            return ((delegate* unmanaged<IScriptErrorList*, int*, int>)(lpVtbl[12]))((IScriptErrorList*)Unsafe.AsPointer(ref this), plChar);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT getErrorCode([NativeTypeName("LONG *")] int* plCode)
        {
            return ((delegate* unmanaged<IScriptErrorList*, int*, int>)(lpVtbl[13]))((IScriptErrorList*)Unsafe.AsPointer(ref this), plCode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT getErrorMsg([NativeTypeName("BSTR *")] ushort** pstr)
        {
            return ((delegate* unmanaged<IScriptErrorList*, ushort**, int>)(lpVtbl[14]))((IScriptErrorList*)Unsafe.AsPointer(ref this), pstr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT getErrorUrl([NativeTypeName("BSTR *")] ushort** pstr)
        {
            return ((delegate* unmanaged<IScriptErrorList*, ushort**, int>)(lpVtbl[15]))((IScriptErrorList*)Unsafe.AsPointer(ref this), pstr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT getAlwaysShowLockState(BOOL* pfAlwaysShowLocked)
        {
            return ((delegate* unmanaged<IScriptErrorList*, BOOL*, int>)(lpVtbl[16]))((IScriptErrorList*)Unsafe.AsPointer(ref this), pfAlwaysShowLocked);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT getDetailsPaneOpen(BOOL* pfDetailsPaneOpen)
        {
            return ((delegate* unmanaged<IScriptErrorList*, BOOL*, int>)(lpVtbl[17]))((IScriptErrorList*)Unsafe.AsPointer(ref this), pfDetailsPaneOpen);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public HRESULT setDetailsPaneOpen(BOOL fDetailsPaneOpen)
        {
            return ((delegate* unmanaged<IScriptErrorList*, BOOL, int>)(lpVtbl[18]))((IScriptErrorList*)Unsafe.AsPointer(ref this), fDetailsPaneOpen);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public HRESULT getPerErrorDisplay(BOOL* pfPerErrorDisplay)
        {
            return ((delegate* unmanaged<IScriptErrorList*, BOOL*, int>)(lpVtbl[19]))((IScriptErrorList*)Unsafe.AsPointer(ref this), pfPerErrorDisplay);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        public HRESULT setPerErrorDisplay(BOOL fPerErrorDisplay)
        {
            return ((delegate* unmanaged<IScriptErrorList*, BOOL, int>)(lpVtbl[20]))((IScriptErrorList*)Unsafe.AsPointer(ref this), fPerErrorDisplay);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IScriptErrorList*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IScriptErrorList*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IScriptErrorList*, uint> Release;

            [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IScriptErrorList*, uint*, int> GetTypeInfoCount;

            [NativeTypeName("HRESULT (UINT, LCID, ITypeInfo **) __attribute__((stdcall))")]
            public delegate* unmanaged<IScriptErrorList*, uint, uint, ITypeInfo**, int> GetTypeInfo;

            [NativeTypeName("HRESULT (const IID &, LPOLESTR *, UINT, LCID, DISPID *) __attribute__((stdcall))")]
            public delegate* unmanaged<IScriptErrorList*, Guid*, ushort**, uint, uint, int*, int> GetIDsOfNames;

            [NativeTypeName("HRESULT (DISPID, const IID &, LCID, WORD, DISPPARAMS *, VARIANT *, EXCEPINFO *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IScriptErrorList*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> Invoke;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IScriptErrorList*, int> advanceError;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IScriptErrorList*, int> retreatError;

            [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged<IScriptErrorList*, BOOL*, int> canAdvanceError;

            [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged<IScriptErrorList*, BOOL*, int> canRetreatError;

            [NativeTypeName("HRESULT (LONG *) __attribute__((stdcall))")]
            public delegate* unmanaged<IScriptErrorList*, int*, int> getErrorLine;

            [NativeTypeName("HRESULT (LONG *) __attribute__((stdcall))")]
            public delegate* unmanaged<IScriptErrorList*, int*, int> getErrorChar;

            [NativeTypeName("HRESULT (LONG *) __attribute__((stdcall))")]
            public delegate* unmanaged<IScriptErrorList*, int*, int> getErrorCode;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IScriptErrorList*, ushort**, int> getErrorMsg;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IScriptErrorList*, ushort**, int> getErrorUrl;

            [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged<IScriptErrorList*, BOOL*, int> getAlwaysShowLockState;

            [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged<IScriptErrorList*, BOOL*, int> getDetailsPaneOpen;

            [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
            public delegate* unmanaged<IScriptErrorList*, BOOL, int> setDetailsPaneOpen;

            [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged<IScriptErrorList*, BOOL*, int> getPerErrorDisplay;

            [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
            public delegate* unmanaged<IScriptErrorList*, BOOL, int> setPerErrorDisplay;
        }
    }
}
