// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("C3E4F353-433F-43D6-89A1-6A62A7054C3D")]
    [NativeTypeName("struct ISpeechPhoneConverter : IDispatch")]
    public unsafe partial struct ISpeechPhoneConverter
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ISpeechPhoneConverter*, Guid*, void**, int>)(lpVtbl[0]))((ISpeechPhoneConverter*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISpeechPhoneConverter*, uint>)(lpVtbl[1]))((ISpeechPhoneConverter*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISpeechPhoneConverter*, uint>)(lpVtbl[2]))((ISpeechPhoneConverter*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* unmanaged<ISpeechPhoneConverter*, uint*, int>)(lpVtbl[3]))((ISpeechPhoneConverter*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<ISpeechPhoneConverter*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((ISpeechPhoneConverter*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<ISpeechPhoneConverter*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((ISpeechPhoneConverter*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* unmanaged<ISpeechPhoneConverter*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((ISpeechPhoneConverter*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_LanguageId([NativeTypeName("SpeechLanguageId *")] int* LanguageId)
        {
            return ((delegate* unmanaged<ISpeechPhoneConverter*, int*, int>)(lpVtbl[7]))((ISpeechPhoneConverter*)Unsafe.AsPointer(ref this), LanguageId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_LanguageId([NativeTypeName("SpeechLanguageId")] int LanguageId)
        {
            return ((delegate* unmanaged<ISpeechPhoneConverter*, int, int>)(lpVtbl[8]))((ISpeechPhoneConverter*)Unsafe.AsPointer(ref this), LanguageId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int PhoneToId([NativeTypeName("const BSTR")] ushort* Phonemes, VARIANT* IdArray)
        {
            return ((delegate* unmanaged<ISpeechPhoneConverter*, ushort*, VARIANT*, int>)(lpVtbl[9]))((ISpeechPhoneConverter*)Unsafe.AsPointer(ref this), Phonemes, IdArray);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int IdToPhone([NativeTypeName("const VARIANT")] VARIANT IdArray, [NativeTypeName("BSTR *")] ushort** Phonemes)
        {
            return ((delegate* unmanaged<ISpeechPhoneConverter*, VARIANT, ushort**, int>)(lpVtbl[10]))((ISpeechPhoneConverter*)Unsafe.AsPointer(ref this), IdArray, Phonemes);
        }
    }
}
