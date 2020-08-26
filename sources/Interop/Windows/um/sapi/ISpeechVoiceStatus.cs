// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("8BE47B07-57F6-11D2-9EEE-00C04F797396")]
    [NativeTypeName("struct ISpeechVoiceStatus : IDispatch")]
    public unsafe partial struct ISpeechVoiceStatus
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<ISpeechVoiceStatus*, Guid*, void**, int>)(lpVtbl[0]))((ISpeechVoiceStatus*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<ISpeechVoiceStatus*, uint>)(lpVtbl[1]))((ISpeechVoiceStatus*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<ISpeechVoiceStatus*, uint>)(lpVtbl[2]))((ISpeechVoiceStatus*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* stdcall<ISpeechVoiceStatus*, uint*, int>)(lpVtbl[3]))((ISpeechVoiceStatus*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("ITypeInfo **")] ITypeInfo** ppTInfo)
        {
            return ((delegate* stdcall<ISpeechVoiceStatus*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((ISpeechVoiceStatus*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* stdcall<ISpeechVoiceStatus*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((ISpeechVoiceStatus*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, [NativeTypeName("DISPPARAMS *")] DISPPARAMS* pDispParams, [NativeTypeName("VARIANT *")] VARIANT* pVarResult, [NativeTypeName("EXCEPINFO *")] EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* stdcall<ISpeechVoiceStatus*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((ISpeechVoiceStatus*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_CurrentStreamNumber([NativeTypeName("long *")] int* StreamNumber)
        {
            return ((delegate* stdcall<ISpeechVoiceStatus*, int*, int>)(lpVtbl[7]))((ISpeechVoiceStatus*)Unsafe.AsPointer(ref this), StreamNumber);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_LastStreamNumberQueued([NativeTypeName("long *")] int* StreamNumber)
        {
            return ((delegate* stdcall<ISpeechVoiceStatus*, int*, int>)(lpVtbl[8]))((ISpeechVoiceStatus*)Unsafe.AsPointer(ref this), StreamNumber);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_LastHResult([NativeTypeName("long *")] int* HResult)
        {
            return ((delegate* stdcall<ISpeechVoiceStatus*, int*, int>)(lpVtbl[9]))((ISpeechVoiceStatus*)Unsafe.AsPointer(ref this), HResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_RunningState([NativeTypeName("SpeechRunState *")] SpeechRunState* State)
        {
            return ((delegate* stdcall<ISpeechVoiceStatus*, SpeechRunState*, int>)(lpVtbl[10]))((ISpeechVoiceStatus*)Unsafe.AsPointer(ref this), State);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_InputWordPosition([NativeTypeName("long *")] int* Position)
        {
            return ((delegate* stdcall<ISpeechVoiceStatus*, int*, int>)(lpVtbl[11]))((ISpeechVoiceStatus*)Unsafe.AsPointer(ref this), Position);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_InputWordLength([NativeTypeName("long *")] int* Length)
        {
            return ((delegate* stdcall<ISpeechVoiceStatus*, int*, int>)(lpVtbl[12]))((ISpeechVoiceStatus*)Unsafe.AsPointer(ref this), Length);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_InputSentencePosition([NativeTypeName("long *")] int* Position)
        {
            return ((delegate* stdcall<ISpeechVoiceStatus*, int*, int>)(lpVtbl[13]))((ISpeechVoiceStatus*)Unsafe.AsPointer(ref this), Position);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_InputSentenceLength([NativeTypeName("long *")] int* Length)
        {
            return ((delegate* stdcall<ISpeechVoiceStatus*, int*, int>)(lpVtbl[14]))((ISpeechVoiceStatus*)Unsafe.AsPointer(ref this), Length);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_LastBookmark([NativeTypeName("BSTR *")] ushort** Bookmark)
        {
            return ((delegate* stdcall<ISpeechVoiceStatus*, ushort**, int>)(lpVtbl[15]))((ISpeechVoiceStatus*)Unsafe.AsPointer(ref this), Bookmark);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_LastBookmarkId([NativeTypeName("long *")] int* BookmarkId)
        {
            return ((delegate* stdcall<ISpeechVoiceStatus*, int*, int>)(lpVtbl[16]))((ISpeechVoiceStatus*)Unsafe.AsPointer(ref this), BookmarkId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_PhonemeId([NativeTypeName("short *")] short* PhoneId)
        {
            return ((delegate* stdcall<ISpeechVoiceStatus*, short*, int>)(lpVtbl[17]))((ISpeechVoiceStatus*)Unsafe.AsPointer(ref this), PhoneId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_VisemeId([NativeTypeName("short *")] short* VisemeId)
        {
            return ((delegate* stdcall<ISpeechVoiceStatus*, short*, int>)(lpVtbl[18]))((ISpeechVoiceStatus*)Unsafe.AsPointer(ref this), VisemeId);
        }
    }
}
