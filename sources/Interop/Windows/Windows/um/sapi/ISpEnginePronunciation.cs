// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='ISpEnginePronunciation.xml' path='doc/member[@name="ISpEnginePronunciation"]/*' />
[Guid("C360CE4B-76D1-4214-AD68-52657D5083DA")]
[NativeTypeName("struct ISpEnginePronunciation : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ISpEnginePronunciation : ISpEnginePronunciation.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISpEnginePronunciation));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpEnginePronunciation*, Guid*, void**, int>)(lpVtbl[0]))((ISpEnginePronunciation*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ISpEnginePronunciation*, uint>)(lpVtbl[1]))((ISpEnginePronunciation*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ISpEnginePronunciation*, uint>)(lpVtbl[2]))((ISpEnginePronunciation*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ISpEnginePronunciation.xml' path='doc/member[@name="ISpEnginePronunciation.Normalize"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Normalize([NativeTypeName("LPCWSTR")] char* pszWord, [NativeTypeName("LPCWSTR")] char* pszLeftContext, [NativeTypeName("LPCWSTR")] char* pszRightContext, [NativeTypeName("WORD")] ushort LangID, SPNORMALIZATIONLIST* pNormalizationList)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpEnginePronunciation*, char*, char*, char*, ushort, SPNORMALIZATIONLIST*, int>)(lpVtbl[3]))((ISpEnginePronunciation*)Unsafe.AsPointer(ref this), pszWord, pszLeftContext, pszRightContext, LangID, pNormalizationList);
    }

    /// <include file='ISpEnginePronunciation.xml' path='doc/member[@name="ISpEnginePronunciation.GetPronunciations"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetPronunciations([NativeTypeName("LPCWSTR")] char* pszWord, [NativeTypeName("LPCWSTR")] char* pszLeftContext, [NativeTypeName("LPCWSTR")] char* pszRightContext, [NativeTypeName("WORD")] ushort LangID, SPWORDPRONUNCIATIONLIST* pEnginePronunciationList)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpEnginePronunciation*, char*, char*, char*, ushort, SPWORDPRONUNCIATIONLIST*, int>)(lpVtbl[4]))((ISpEnginePronunciation*)Unsafe.AsPointer(ref this), pszWord, pszLeftContext, pszRightContext, LangID, pEnginePronunciationList);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Normalize([NativeTypeName("LPCWSTR")] char* pszWord, [NativeTypeName("LPCWSTR")] char* pszLeftContext, [NativeTypeName("LPCWSTR")] char* pszRightContext, [NativeTypeName("WORD")] ushort LangID, SPNORMALIZATIONLIST* pNormalizationList);

        [VtblIndex(4)]
        HRESULT GetPronunciations([NativeTypeName("LPCWSTR")] char* pszWord, [NativeTypeName("LPCWSTR")] char* pszLeftContext, [NativeTypeName("LPCWSTR")] char* pszRightContext, [NativeTypeName("WORD")] ushort LangID, SPWORDPRONUNCIATIONLIST* pEnginePronunciationList);
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

        [NativeTypeName("HRESULT (LPCWSTR, LPCWSTR, LPCWSTR, WORD, SPNORMALIZATIONLIST *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, char*, char*, ushort, SPNORMALIZATIONLIST*, int> Normalize;

        [NativeTypeName("HRESULT (LPCWSTR, LPCWSTR, LPCWSTR, WORD, SPWORDPRONUNCIATIONLIST *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, char*, char*, ushort, SPWORDPRONUNCIATIONLIST*, int> GetPronunciations;
    }
}
