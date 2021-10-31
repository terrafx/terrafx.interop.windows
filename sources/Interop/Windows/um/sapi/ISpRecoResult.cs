// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("20B053BE-E235-43CD-9A2A-8D17A48B7842")]
    [NativeTypeName("struct ISpRecoResult : ISpPhrase")]
    [NativeInheritance("ISpPhrase")]
    public unsafe partial struct ISpRecoResult
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ISpRecoResult*, Guid*, void**, int>)(lpVtbl[0]))((ISpRecoResult*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISpRecoResult*, uint>)(lpVtbl[1]))((ISpRecoResult*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISpRecoResult*, uint>)(lpVtbl[2]))((ISpRecoResult*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetPhrase(SPPHRASE** ppCoMemPhrase)
        {
            return ((delegate* unmanaged<ISpRecoResult*, SPPHRASE**, int>)(lpVtbl[3]))((ISpRecoResult*)Unsafe.AsPointer(ref this), ppCoMemPhrase);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetSerializedPhrase(SPSERIALIZEDPHRASE** ppCoMemPhrase)
        {
            return ((delegate* unmanaged<ISpRecoResult*, SPSERIALIZEDPHRASE**, int>)(lpVtbl[4]))((ISpRecoResult*)Unsafe.AsPointer(ref this), ppCoMemPhrase);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int GetText([NativeTypeName("ULONG")] uint ulStart, [NativeTypeName("ULONG")] uint ulCount, BOOL fUseTextReplacements, [NativeTypeName("LPWSTR *")] ushort** ppszCoMemText, [NativeTypeName("BYTE *")] byte* pbDisplayAttributes)
        {
            return ((delegate* unmanaged<ISpRecoResult*, uint, uint, BOOL, ushort**, byte*, int>)(lpVtbl[5]))((ISpRecoResult*)Unsafe.AsPointer(ref this), ulStart, ulCount, fUseTextReplacements, ppszCoMemText, pbDisplayAttributes);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int Discard([NativeTypeName("DWORD")] uint dwValueTypes)
        {
            return ((delegate* unmanaged<ISpRecoResult*, uint, int>)(lpVtbl[6]))((ISpRecoResult*)Unsafe.AsPointer(ref this), dwValueTypes);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int GetResultTimes(SPRECORESULTTIMES* pTimes)
        {
            return ((delegate* unmanaged<ISpRecoResult*, SPRECORESULTTIMES*, int>)(lpVtbl[7]))((ISpRecoResult*)Unsafe.AsPointer(ref this), pTimes);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int GetAlternates([NativeTypeName("ULONG")] uint ulStartElement, [NativeTypeName("ULONG")] uint cElements, [NativeTypeName("ULONG")] uint ulRequestCount, ISpPhraseAlt** ppPhrases, [NativeTypeName("ULONG *")] uint* pcPhrasesReturned)
        {
            return ((delegate* unmanaged<ISpRecoResult*, uint, uint, uint, ISpPhraseAlt**, uint*, int>)(lpVtbl[8]))((ISpRecoResult*)Unsafe.AsPointer(ref this), ulStartElement, cElements, ulRequestCount, ppPhrases, pcPhrasesReturned);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int GetAudio([NativeTypeName("ULONG")] uint ulStartElement, [NativeTypeName("ULONG")] uint cElements, ISpStreamFormat** ppStream)
        {
            return ((delegate* unmanaged<ISpRecoResult*, uint, uint, ISpStreamFormat**, int>)(lpVtbl[9]))((ISpRecoResult*)Unsafe.AsPointer(ref this), ulStartElement, cElements, ppStream);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int SpeakAudio([NativeTypeName("ULONG")] uint ulStartElement, [NativeTypeName("ULONG")] uint cElements, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("ULONG *")] uint* pulStreamNumber)
        {
            return ((delegate* unmanaged<ISpRecoResult*, uint, uint, uint, uint*, int>)(lpVtbl[10]))((ISpRecoResult*)Unsafe.AsPointer(ref this), ulStartElement, cElements, dwFlags, pulStreamNumber);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int Serialize(SPSERIALIZEDRESULT** ppCoMemSerializedResult)
        {
            return ((delegate* unmanaged<ISpRecoResult*, SPSERIALIZEDRESULT**, int>)(lpVtbl[11]))((ISpRecoResult*)Unsafe.AsPointer(ref this), ppCoMemSerializedResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("HRESULT")]
        public int ScaleAudio([NativeTypeName("const GUID *")] Guid* pAudioFormatId, [NativeTypeName("const WAVEFORMATEX *")] WAVEFORMATEX* pWaveFormatEx)
        {
            return ((delegate* unmanaged<ISpRecoResult*, Guid*, WAVEFORMATEX*, int>)(lpVtbl[12]))((ISpRecoResult*)Unsafe.AsPointer(ref this), pAudioFormatId, pWaveFormatEx);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        [return: NativeTypeName("HRESULT")]
        public int GetRecoContext(ISpRecoContext** ppRecoContext)
        {
            return ((delegate* unmanaged<ISpRecoResult*, ISpRecoContext**, int>)(lpVtbl[13]))((ISpRecoResult*)Unsafe.AsPointer(ref this), ppRecoContext);
        }
    }
}
