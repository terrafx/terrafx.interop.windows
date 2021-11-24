// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[Guid("DA41A7C2-5383-4DB2-916B-6C1719E3DB58")]
[NativeTypeName("struct ISpLexicon : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ISpLexicon : ISpLexicon.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISpLexicon*, Guid*, void**, int>)(lpVtbl[0]))((ISpLexicon*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ISpLexicon*, uint>)(lpVtbl[1]))((ISpLexicon*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISpLexicon*, uint>)(lpVtbl[2]))((ISpLexicon*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetPronunciations([NativeTypeName("LPCWSTR")] ushort* pszWord, [NativeTypeName("WORD")] ushort LangID, [NativeTypeName("DWORD")] uint dwFlags, SPWORDPRONUNCIATIONLIST* pWordPronunciationList)
    {
        return ((delegate* unmanaged<ISpLexicon*, ushort*, ushort, uint, SPWORDPRONUNCIATIONLIST*, int>)(lpVtbl[3]))((ISpLexicon*)Unsafe.AsPointer(ref this), pszWord, LangID, dwFlags, pWordPronunciationList);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT AddPronunciation([NativeTypeName("LPCWSTR")] ushort* pszWord, [NativeTypeName("WORD")] ushort LangID, SPPARTOFSPEECH ePartOfSpeech, [NativeTypeName("PCSPPHONEID")] ushort* pszPronunciation)
    {
        return ((delegate* unmanaged<ISpLexicon*, ushort*, ushort, SPPARTOFSPEECH, ushort*, int>)(lpVtbl[4]))((ISpLexicon*)Unsafe.AsPointer(ref this), pszWord, LangID, ePartOfSpeech, pszPronunciation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT RemovePronunciation([NativeTypeName("LPCWSTR")] ushort* pszWord, [NativeTypeName("WORD")] ushort LangID, SPPARTOFSPEECH ePartOfSpeech, [NativeTypeName("PCSPPHONEID")] ushort* pszPronunciation)
    {
        return ((delegate* unmanaged<ISpLexicon*, ushort*, ushort, SPPARTOFSPEECH, ushort*, int>)(lpVtbl[5]))((ISpLexicon*)Unsafe.AsPointer(ref this), pszWord, LangID, ePartOfSpeech, pszPronunciation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetGeneration([NativeTypeName("DWORD *")] uint* pdwGeneration)
    {
        return ((delegate* unmanaged<ISpLexicon*, uint*, int>)(lpVtbl[6]))((ISpLexicon*)Unsafe.AsPointer(ref this), pdwGeneration);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetGenerationChange([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD *")] uint* pdwGeneration, SPWORDLIST* pWordList)
    {
        return ((delegate* unmanaged<ISpLexicon*, uint, uint*, SPWORDLIST*, int>)(lpVtbl[7]))((ISpLexicon*)Unsafe.AsPointer(ref this), dwFlags, pdwGeneration, pWordList);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetWords([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD *")] uint* pdwGeneration, [NativeTypeName("DWORD *")] uint* pdwCookie, SPWORDLIST* pWordList)
    {
        return ((delegate* unmanaged<ISpLexicon*, uint, uint*, uint*, SPWORDLIST*, int>)(lpVtbl[8]))((ISpLexicon*)Unsafe.AsPointer(ref this), dwFlags, pdwGeneration, pdwCookie, pWordList);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetPronunciations([NativeTypeName("LPCWSTR")] ushort* pszWord, [NativeTypeName("WORD")] ushort LangID, [NativeTypeName("DWORD")] uint dwFlags, SPWORDPRONUNCIATIONLIST* pWordPronunciationList);

        [VtblIndex(4)]
        HRESULT AddPronunciation([NativeTypeName("LPCWSTR")] ushort* pszWord, [NativeTypeName("WORD")] ushort LangID, SPPARTOFSPEECH ePartOfSpeech, [NativeTypeName("PCSPPHONEID")] ushort* pszPronunciation);

        [VtblIndex(5)]
        HRESULT RemovePronunciation([NativeTypeName("LPCWSTR")] ushort* pszWord, [NativeTypeName("WORD")] ushort LangID, SPPARTOFSPEECH ePartOfSpeech, [NativeTypeName("PCSPPHONEID")] ushort* pszPronunciation);

        [VtblIndex(6)]
        HRESULT GetGeneration([NativeTypeName("DWORD *")] uint* pdwGeneration);

        [VtblIndex(7)]
        HRESULT GetGenerationChange([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD *")] uint* pdwGeneration, SPWORDLIST* pWordList);

        [VtblIndex(8)]
        HRESULT GetWords([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD *")] uint* pdwGeneration, [NativeTypeName("DWORD *")] uint* pdwCookie, SPWORDLIST* pWordList);
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<ISpLexicon*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<ISpLexicon*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<ISpLexicon*, uint> Release;

        [NativeTypeName("HRESULT (LPCWSTR, WORD, DWORD, SPWORDPRONUNCIATIONLIST *) __attribute__((stdcall))")]
        public delegate* unmanaged<ISpLexicon*, ushort*, ushort, uint, SPWORDPRONUNCIATIONLIST*, int> GetPronunciations;

        [NativeTypeName("HRESULT (LPCWSTR, WORD, SPPARTOFSPEECH, PCSPPHONEID) __attribute__((stdcall))")]
        public delegate* unmanaged<ISpLexicon*, ushort*, ushort, SPPARTOFSPEECH, ushort*, int> AddPronunciation;

        [NativeTypeName("HRESULT (LPCWSTR, WORD, SPPARTOFSPEECH, PCSPPHONEID) __attribute__((stdcall))")]
        public delegate* unmanaged<ISpLexicon*, ushort*, ushort, SPPARTOFSPEECH, ushort*, int> RemovePronunciation;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<ISpLexicon*, uint*, int> GetGeneration;

        [NativeTypeName("HRESULT (DWORD, DWORD *, SPWORDLIST *) __attribute__((stdcall))")]
        public delegate* unmanaged<ISpLexicon*, uint, uint*, SPWORDLIST*, int> GetGenerationChange;

        [NativeTypeName("HRESULT (DWORD, DWORD *, DWORD *, SPWORDLIST *) __attribute__((stdcall))")]
        public delegate* unmanaged<ISpLexicon*, uint, uint*, uint*, SPWORDLIST*, int> GetWords;
    }
}
