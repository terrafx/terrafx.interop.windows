// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='ISpContainerLexicon.xml' path='doc/member[@name="ISpContainerLexicon"]/*' />
[Guid("8565572F-C094-41CC-B56E-10BD9C3FF044")]
[NativeTypeName("struct ISpContainerLexicon : ISpLexicon")]
[NativeInheritance("ISpLexicon")]
public unsafe partial struct ISpContainerLexicon : ISpContainerLexicon.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISpContainerLexicon));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpContainerLexicon*, Guid*, void**, int>)(lpVtbl[0]))((ISpContainerLexicon*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ISpContainerLexicon*, uint>)(lpVtbl[1]))((ISpContainerLexicon*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ISpContainerLexicon*, uint>)(lpVtbl[2]))((ISpContainerLexicon*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="ISpLexicon.GetPronunciations" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetPronunciations([NativeTypeName("LPCWSTR")] char* pszWord, [NativeTypeName("WORD")] ushort LangID, [NativeTypeName("DWORD")] uint dwFlags, SPWORDPRONUNCIATIONLIST* pWordPronunciationList)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpContainerLexicon*, char*, ushort, uint, SPWORDPRONUNCIATIONLIST*, int>)(lpVtbl[3]))((ISpContainerLexicon*)Unsafe.AsPointer(ref this), pszWord, LangID, dwFlags, pWordPronunciationList);
    }

    /// <inheritdoc cref="ISpLexicon.AddPronunciation" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT AddPronunciation([NativeTypeName("LPCWSTR")] char* pszWord, [NativeTypeName("WORD")] ushort LangID, SPPARTOFSPEECH ePartOfSpeech, [NativeTypeName("PCSPPHONEID")] char* pszPronunciation)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpContainerLexicon*, char*, ushort, SPPARTOFSPEECH, char*, int>)(lpVtbl[4]))((ISpContainerLexicon*)Unsafe.AsPointer(ref this), pszWord, LangID, ePartOfSpeech, pszPronunciation);
    }

    /// <inheritdoc cref="ISpLexicon.RemovePronunciation" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT RemovePronunciation([NativeTypeName("LPCWSTR")] char* pszWord, [NativeTypeName("WORD")] ushort LangID, SPPARTOFSPEECH ePartOfSpeech, [NativeTypeName("PCSPPHONEID")] char* pszPronunciation)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpContainerLexicon*, char*, ushort, SPPARTOFSPEECH, char*, int>)(lpVtbl[5]))((ISpContainerLexicon*)Unsafe.AsPointer(ref this), pszWord, LangID, ePartOfSpeech, pszPronunciation);
    }

    /// <inheritdoc cref="ISpLexicon.GetGeneration" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetGeneration([NativeTypeName("DWORD *")] uint* pdwGeneration)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpContainerLexicon*, uint*, int>)(lpVtbl[6]))((ISpContainerLexicon*)Unsafe.AsPointer(ref this), pdwGeneration);
    }

    /// <inheritdoc cref="ISpLexicon.GetGenerationChange" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetGenerationChange([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD *")] uint* pdwGeneration, SPWORDLIST* pWordList)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpContainerLexicon*, uint, uint*, SPWORDLIST*, int>)(lpVtbl[7]))((ISpContainerLexicon*)Unsafe.AsPointer(ref this), dwFlags, pdwGeneration, pWordList);
    }

    /// <inheritdoc cref="ISpLexicon.GetWords" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetWords([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD *")] uint* pdwGeneration, [NativeTypeName("DWORD *")] uint* pdwCookie, SPWORDLIST* pWordList)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpContainerLexicon*, uint, uint*, uint*, SPWORDLIST*, int>)(lpVtbl[8]))((ISpContainerLexicon*)Unsafe.AsPointer(ref this), dwFlags, pdwGeneration, pdwCookie, pWordList);
    }

    /// <include file='ISpContainerLexicon.xml' path='doc/member[@name="ISpContainerLexicon.AddLexicon"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT AddLexicon(ISpLexicon* pAddLexicon, [NativeTypeName("DWORD")] uint dwFlags)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpContainerLexicon*, ISpLexicon*, uint, int>)(lpVtbl[9]))((ISpContainerLexicon*)Unsafe.AsPointer(ref this), pAddLexicon, dwFlags);
    }

    public interface Interface : ISpLexicon.Interface
    {
        [VtblIndex(9)]
        HRESULT AddLexicon(ISpLexicon* pAddLexicon, [NativeTypeName("DWORD")] uint dwFlags);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

        [NativeTypeName("HRESULT (LPCWSTR, WORD, DWORD, SPWORDPRONUNCIATIONLIST *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, ushort, uint, SPWORDPRONUNCIATIONLIST*, int> GetPronunciations;

        [NativeTypeName("HRESULT (LPCWSTR, WORD, SPPARTOFSPEECH, PCSPPHONEID) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, ushort, SPPARTOFSPEECH, char*, int> AddPronunciation;

        [NativeTypeName("HRESULT (LPCWSTR, WORD, SPPARTOFSPEECH, PCSPPHONEID) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, ushort, SPPARTOFSPEECH, char*, int> RemovePronunciation;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> GetGeneration;

        [NativeTypeName("HRESULT (DWORD, DWORD *, SPWORDLIST *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint*, SPWORDLIST*, int> GetGenerationChange;

        [NativeTypeName("HRESULT (DWORD, DWORD *, DWORD *, SPWORDLIST *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint*, uint*, SPWORDLIST*, int> GetWords;

        [NativeTypeName("HRESULT (ISpLexicon *, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ISpLexicon*, uint, int> AddLexicon;
    }
}
