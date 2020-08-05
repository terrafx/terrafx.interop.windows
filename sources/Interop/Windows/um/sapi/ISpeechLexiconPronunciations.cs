// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("72829128-5682-4704-A0D4-3E2BB6F2EAD3")]
    [NativeTypeName("struct ISpeechLexiconPronunciations : IDispatch")]
    public unsafe partial struct ISpeechLexiconPronunciations
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<ISpeechLexiconPronunciations*, Guid*, void**, int>)(lpVtbl[0]))((ISpeechLexiconPronunciations*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<ISpeechLexiconPronunciations*, uint>)(lpVtbl[1]))((ISpeechLexiconPronunciations*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<ISpeechLexiconPronunciations*, uint>)(lpVtbl[2]))((ISpeechLexiconPronunciations*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* stdcall<ISpeechLexiconPronunciations*, uint*, int>)(lpVtbl[3]))((ISpeechLexiconPronunciations*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("ITypeInfo **")] ITypeInfo** ppTInfo)
        {
            return ((delegate* stdcall<ISpeechLexiconPronunciations*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((ISpeechLexiconPronunciations*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* stdcall<ISpeechLexiconPronunciations*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((ISpeechLexiconPronunciations*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, [NativeTypeName("DISPPARAMS *")] DISPPARAMS* pDispParams, [NativeTypeName("VARIANT *")] VARIANT* pVarResult, [NativeTypeName("EXCEPINFO *")] EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* stdcall<ISpeechLexiconPronunciations*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((ISpeechLexiconPronunciations*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_Count([NativeTypeName("long *")] int* Count)
        {
            return ((delegate* stdcall<ISpeechLexiconPronunciations*, int*, int>)(lpVtbl[7]))((ISpeechLexiconPronunciations*)Unsafe.AsPointer(ref this), Count);
        }

        [return: NativeTypeName("HRESULT")]
        public int Item([NativeTypeName("long")] int Index, [NativeTypeName("ISpeechLexiconPronunciation **")] ISpeechLexiconPronunciation** Pronunciation)
        {
            return ((delegate* stdcall<ISpeechLexiconPronunciations*, int, ISpeechLexiconPronunciation**, int>)(lpVtbl[8]))((ISpeechLexiconPronunciations*)Unsafe.AsPointer(ref this), Index, Pronunciation);
        }

        [return: NativeTypeName("HRESULT")]
        public int get__NewEnum([NativeTypeName("IUnknown **")] IUnknown** EnumVARIANT)
        {
            return ((delegate* stdcall<ISpeechLexiconPronunciations*, IUnknown**, int>)(lpVtbl[9]))((ISpeechLexiconPronunciations*)Unsafe.AsPointer(ref this), EnumVARIANT);
        }
    }
}
