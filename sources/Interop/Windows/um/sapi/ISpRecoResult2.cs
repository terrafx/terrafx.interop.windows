// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("27CAC6C4-88F2-41F2-8817-0C95E59F1E6E")]
    [NativeTypeName("struct ISpRecoResult2 : ISpRecoResult")]
    public unsafe partial struct ISpRecoResult2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ISpRecoResult2*, Guid*, void**, int>)(lpVtbl[0]))((ISpRecoResult2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISpRecoResult2*, uint>)(lpVtbl[1]))((ISpRecoResult2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISpRecoResult2*, uint>)(lpVtbl[2]))((ISpRecoResult2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPhrase(SPPHRASE** ppCoMemPhrase)
        {
            return ((delegate* unmanaged<ISpRecoResult2*, SPPHRASE**, int>)(lpVtbl[3]))((ISpRecoResult2*)Unsafe.AsPointer(ref this), ppCoMemPhrase);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSerializedPhrase(SPSERIALIZEDPHRASE** ppCoMemPhrase)
        {
            return ((delegate* unmanaged<ISpRecoResult2*, SPSERIALIZEDPHRASE**, int>)(lpVtbl[4]))((ISpRecoResult2*)Unsafe.AsPointer(ref this), ppCoMemPhrase);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetText([NativeTypeName("ULONG")] uint ulStart, [NativeTypeName("ULONG")] uint ulCount, [NativeTypeName("BOOL")] int fUseTextReplacements, [NativeTypeName("LPWSTR *")] ushort** ppszCoMemText, [NativeTypeName("BYTE *")] byte* pbDisplayAttributes)
        {
            return ((delegate* unmanaged<ISpRecoResult2*, uint, uint, int, ushort**, byte*, int>)(lpVtbl[5]))((ISpRecoResult2*)Unsafe.AsPointer(ref this), ulStart, ulCount, fUseTextReplacements, ppszCoMemText, pbDisplayAttributes);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Discard([NativeTypeName("DWORD")] uint dwValueTypes)
        {
            return ((delegate* unmanaged<ISpRecoResult2*, uint, int>)(lpVtbl[6]))((ISpRecoResult2*)Unsafe.AsPointer(ref this), dwValueTypes);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetResultTimes(SPRECORESULTTIMES* pTimes)
        {
            return ((delegate* unmanaged<ISpRecoResult2*, SPRECORESULTTIMES*, int>)(lpVtbl[7]))((ISpRecoResult2*)Unsafe.AsPointer(ref this), pTimes);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetAlternates([NativeTypeName("ULONG")] uint ulStartElement, [NativeTypeName("ULONG")] uint cElements, [NativeTypeName("ULONG")] uint ulRequestCount, ISpPhraseAlt** ppPhrases, [NativeTypeName("ULONG *")] uint* pcPhrasesReturned)
        {
            return ((delegate* unmanaged<ISpRecoResult2*, uint, uint, uint, ISpPhraseAlt**, uint*, int>)(lpVtbl[8]))((ISpRecoResult2*)Unsafe.AsPointer(ref this), ulStartElement, cElements, ulRequestCount, ppPhrases, pcPhrasesReturned);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetAudio([NativeTypeName("ULONG")] uint ulStartElement, [NativeTypeName("ULONG")] uint cElements, ISpStreamFormat** ppStream)
        {
            return ((delegate* unmanaged<ISpRecoResult2*, uint, uint, ISpStreamFormat**, int>)(lpVtbl[9]))((ISpRecoResult2*)Unsafe.AsPointer(ref this), ulStartElement, cElements, ppStream);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SpeakAudio([NativeTypeName("ULONG")] uint ulStartElement, [NativeTypeName("ULONG")] uint cElements, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("ULONG *")] uint* pulStreamNumber)
        {
            return ((delegate* unmanaged<ISpRecoResult2*, uint, uint, uint, uint*, int>)(lpVtbl[10]))((ISpRecoResult2*)Unsafe.AsPointer(ref this), ulStartElement, cElements, dwFlags, pulStreamNumber);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Serialize(SPSERIALIZEDRESULT** ppCoMemSerializedResult)
        {
            return ((delegate* unmanaged<ISpRecoResult2*, SPSERIALIZEDRESULT**, int>)(lpVtbl[11]))((ISpRecoResult2*)Unsafe.AsPointer(ref this), ppCoMemSerializedResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ScaleAudio([NativeTypeName("const GUID *")] Guid* pAudioFormatId, [NativeTypeName("const WAVEFORMATEX *")] WAVEFORMATEX* pWaveFormatEx)
        {
            return ((delegate* unmanaged<ISpRecoResult2*, Guid*, WAVEFORMATEX*, int>)(lpVtbl[12]))((ISpRecoResult2*)Unsafe.AsPointer(ref this), pAudioFormatId, pWaveFormatEx);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRecoContext(ISpRecoContext** ppRecoContext)
        {
            return ((delegate* unmanaged<ISpRecoResult2*, ISpRecoContext**, int>)(lpVtbl[13]))((ISpRecoResult2*)Unsafe.AsPointer(ref this), ppRecoContext);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CommitAlternate(ISpPhraseAlt* pPhraseAlt, ISpRecoResult** ppNewResult)
        {
            return ((delegate* unmanaged<ISpRecoResult2*, ISpPhraseAlt*, ISpRecoResult**, int>)(lpVtbl[14]))((ISpRecoResult2*)Unsafe.AsPointer(ref this), pPhraseAlt, ppNewResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CommitText([NativeTypeName("ULONG")] uint ulStartElement, [NativeTypeName("ULONG")] uint cElements, [NativeTypeName("LPCWSTR")] ushort* pszCorrectedData, [NativeTypeName("DWORD")] uint eCommitFlags)
        {
            return ((delegate* unmanaged<ISpRecoResult2*, uint, uint, ushort*, uint, int>)(lpVtbl[15]))((ISpRecoResult2*)Unsafe.AsPointer(ref this), ulStartElement, cElements, pszCorrectedData, eCommitFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetTextFeedback([NativeTypeName("LPCWSTR")] ushort* pszFeedback, [NativeTypeName("BOOL")] int fSuccessful)
        {
            return ((delegate* unmanaged<ISpRecoResult2*, ushort*, int, int>)(lpVtbl[16]))((ISpRecoResult2*)Unsafe.AsPointer(ref this), pszFeedback, fSuccessful);
        }
    }
}
