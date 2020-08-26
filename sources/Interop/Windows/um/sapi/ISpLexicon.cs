// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("DA41A7C2-5383-4DB2-916B-6C1719E3DB58")]
    [NativeTypeName("struct ISpLexicon : IUnknown")]
    public unsafe partial struct ISpLexicon
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<ISpLexicon*, Guid*, void**, int>)(lpVtbl[0]))((ISpLexicon*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<ISpLexicon*, uint>)(lpVtbl[1]))((ISpLexicon*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<ISpLexicon*, uint>)(lpVtbl[2]))((ISpLexicon*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPronunciations([NativeTypeName("LPCWSTR")] ushort* pszWord, [NativeTypeName("WORD")] ushort LangID, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("SPWORDPRONUNCIATIONLIST *")] SPWORDPRONUNCIATIONLIST* pWordPronunciationList)
        {
            return ((delegate* stdcall<ISpLexicon*, ushort*, ushort, uint, SPWORDPRONUNCIATIONLIST*, int>)(lpVtbl[3]))((ISpLexicon*)Unsafe.AsPointer(ref this), pszWord, LangID, dwFlags, pWordPronunciationList);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int AddPronunciation([NativeTypeName("LPCWSTR")] ushort* pszWord, [NativeTypeName("WORD")] ushort LangID, SPPARTOFSPEECH ePartOfSpeech, [NativeTypeName("PCSPPHONEID")] ushort* pszPronunciation)
        {
            return ((delegate* stdcall<ISpLexicon*, ushort*, ushort, SPPARTOFSPEECH, ushort*, int>)(lpVtbl[4]))((ISpLexicon*)Unsafe.AsPointer(ref this), pszWord, LangID, ePartOfSpeech, pszPronunciation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RemovePronunciation([NativeTypeName("LPCWSTR")] ushort* pszWord, [NativeTypeName("WORD")] ushort LangID, SPPARTOFSPEECH ePartOfSpeech, [NativeTypeName("PCSPPHONEID")] ushort* pszPronunciation)
        {
            return ((delegate* stdcall<ISpLexicon*, ushort*, ushort, SPPARTOFSPEECH, ushort*, int>)(lpVtbl[5]))((ISpLexicon*)Unsafe.AsPointer(ref this), pszWord, LangID, ePartOfSpeech, pszPronunciation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetGeneration([NativeTypeName("DWORD *")] uint* pdwGeneration)
        {
            return ((delegate* stdcall<ISpLexicon*, uint*, int>)(lpVtbl[6]))((ISpLexicon*)Unsafe.AsPointer(ref this), pdwGeneration);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetGenerationChange([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD *")] uint* pdwGeneration, [NativeTypeName("SPWORDLIST *")] SPWORDLIST* pWordList)
        {
            return ((delegate* stdcall<ISpLexicon*, uint, uint*, SPWORDLIST*, int>)(lpVtbl[7]))((ISpLexicon*)Unsafe.AsPointer(ref this), dwFlags, pdwGeneration, pWordList);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetWords([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD *")] uint* pdwGeneration, [NativeTypeName("DWORD *")] uint* pdwCookie, [NativeTypeName("SPWORDLIST *")] SPWORDLIST* pWordList)
        {
            return ((delegate* stdcall<ISpLexicon*, uint, uint*, uint*, SPWORDLIST*, int>)(lpVtbl[8]))((ISpLexicon*)Unsafe.AsPointer(ref this), dwFlags, pdwGeneration, pdwCookie, pWordList);
        }
    }
}
