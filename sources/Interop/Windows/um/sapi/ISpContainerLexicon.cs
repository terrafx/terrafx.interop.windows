// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("8565572F-C094-41CC-B56E-10BD9C3FF044")]
    [NativeTypeName("struct ISpContainerLexicon : ISpLexicon")]
    public unsafe partial struct ISpContainerLexicon
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<ISpContainerLexicon*, Guid*, void**, int>)(lpVtbl[0]))((ISpContainerLexicon*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<ISpContainerLexicon*, uint>)(lpVtbl[1]))((ISpContainerLexicon*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<ISpContainerLexicon*, uint>)(lpVtbl[2]))((ISpContainerLexicon*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPronunciations([NativeTypeName("LPCWSTR")] ushort* pszWord, [NativeTypeName("WORD")] ushort LangID, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("SPWORDPRONUNCIATIONLIST *")] SPWORDPRONUNCIATIONLIST* pWordPronunciationList)
        {
            return ((delegate* stdcall<ISpContainerLexicon*, ushort*, ushort, uint, SPWORDPRONUNCIATIONLIST*, int>)(lpVtbl[3]))((ISpContainerLexicon*)Unsafe.AsPointer(ref this), pszWord, LangID, dwFlags, pWordPronunciationList);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int AddPronunciation([NativeTypeName("LPCWSTR")] ushort* pszWord, [NativeTypeName("WORD")] ushort LangID, SPPARTOFSPEECH ePartOfSpeech, [NativeTypeName("PCSPPHONEID")] ushort* pszPronunciation)
        {
            return ((delegate* stdcall<ISpContainerLexicon*, ushort*, ushort, SPPARTOFSPEECH, ushort*, int>)(lpVtbl[4]))((ISpContainerLexicon*)Unsafe.AsPointer(ref this), pszWord, LangID, ePartOfSpeech, pszPronunciation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RemovePronunciation([NativeTypeName("LPCWSTR")] ushort* pszWord, [NativeTypeName("WORD")] ushort LangID, SPPARTOFSPEECH ePartOfSpeech, [NativeTypeName("PCSPPHONEID")] ushort* pszPronunciation)
        {
            return ((delegate* stdcall<ISpContainerLexicon*, ushort*, ushort, SPPARTOFSPEECH, ushort*, int>)(lpVtbl[5]))((ISpContainerLexicon*)Unsafe.AsPointer(ref this), pszWord, LangID, ePartOfSpeech, pszPronunciation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetGeneration([NativeTypeName("DWORD *")] uint* pdwGeneration)
        {
            return ((delegate* stdcall<ISpContainerLexicon*, uint*, int>)(lpVtbl[6]))((ISpContainerLexicon*)Unsafe.AsPointer(ref this), pdwGeneration);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetGenerationChange([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD *")] uint* pdwGeneration, [NativeTypeName("SPWORDLIST *")] SPWORDLIST* pWordList)
        {
            return ((delegate* stdcall<ISpContainerLexicon*, uint, uint*, SPWORDLIST*, int>)(lpVtbl[7]))((ISpContainerLexicon*)Unsafe.AsPointer(ref this), dwFlags, pdwGeneration, pWordList);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetWords([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD *")] uint* pdwGeneration, [NativeTypeName("DWORD *")] uint* pdwCookie, [NativeTypeName("SPWORDLIST *")] SPWORDLIST* pWordList)
        {
            return ((delegate* stdcall<ISpContainerLexicon*, uint, uint*, uint*, SPWORDLIST*, int>)(lpVtbl[8]))((ISpContainerLexicon*)Unsafe.AsPointer(ref this), dwFlags, pdwGeneration, pdwCookie, pWordList);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int AddLexicon([NativeTypeName("ISpLexicon *")] ISpLexicon* pAddLexicon, [NativeTypeName("DWORD")] uint dwFlags)
        {
            return ((delegate* stdcall<ISpContainerLexicon*, ISpLexicon*, uint, int>)(lpVtbl[9]))((ISpContainerLexicon*)Unsafe.AsPointer(ref this), pAddLexicon, dwFlags);
        }
    }
}
