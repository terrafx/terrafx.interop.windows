// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("C360CE4B-76D1-4214-AD68-52657D5083DA")]
    [NativeTypeName("struct ISpEnginePronunciation : IUnknown")]
    public unsafe partial struct ISpEnginePronunciation
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<ISpEnginePronunciation*, Guid*, void**, int>)(lpVtbl[0]))((ISpEnginePronunciation*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<ISpEnginePronunciation*, uint>)(lpVtbl[1]))((ISpEnginePronunciation*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<ISpEnginePronunciation*, uint>)(lpVtbl[2]))((ISpEnginePronunciation*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Normalize([NativeTypeName("LPCWSTR")] ushort* pszWord, [NativeTypeName("LPCWSTR")] ushort* pszLeftContext, [NativeTypeName("LPCWSTR")] ushort* pszRightContext, [NativeTypeName("WORD")] ushort LangID, [NativeTypeName("SPNORMALIZATIONLIST *")] SPNORMALIZATIONLIST* pNormalizationList)
        {
            return ((delegate* stdcall<ISpEnginePronunciation*, ushort*, ushort*, ushort*, ushort, SPNORMALIZATIONLIST*, int>)(lpVtbl[3]))((ISpEnginePronunciation*)Unsafe.AsPointer(ref this), pszWord, pszLeftContext, pszRightContext, LangID, pNormalizationList);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPronunciations([NativeTypeName("LPCWSTR")] ushort* pszWord, [NativeTypeName("LPCWSTR")] ushort* pszLeftContext, [NativeTypeName("LPCWSTR")] ushort* pszRightContext, [NativeTypeName("WORD")] ushort LangID, [NativeTypeName("SPWORDPRONUNCIATIONLIST *")] SPWORDPRONUNCIATIONLIST* pEnginePronunciationList)
        {
            return ((delegate* stdcall<ISpEnginePronunciation*, ushort*, ushort*, ushort*, ushort, SPWORDPRONUNCIATIONLIST*, int>)(lpVtbl[4]))((ISpEnginePronunciation*)Unsafe.AsPointer(ref this), pszWord, pszLeftContext, pszRightContext, LangID, pEnginePronunciationList);
        }
    }
}
