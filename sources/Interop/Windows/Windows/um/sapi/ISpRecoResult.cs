// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    [Guid("20B053BE-E235-43CD-9A2A-8D17A48B7842")]
    [NativeTypeName("struct ISpRecoResult : ISpPhrase")]
    [NativeInheritance("ISpPhrase")]
    public unsafe partial struct ISpRecoResult : ISpRecoResult.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
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
        public HRESULT GetPhrase(SPPHRASE** ppCoMemPhrase)
        {
            return ((delegate* unmanaged<ISpRecoResult*, SPPHRASE**, int>)(lpVtbl[3]))((ISpRecoResult*)Unsafe.AsPointer(ref this), ppCoMemPhrase);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetSerializedPhrase(SPSERIALIZEDPHRASE** ppCoMemPhrase)
        {
            return ((delegate* unmanaged<ISpRecoResult*, SPSERIALIZEDPHRASE**, int>)(lpVtbl[4]))((ISpRecoResult*)Unsafe.AsPointer(ref this), ppCoMemPhrase);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetText([NativeTypeName("ULONG")] uint ulStart, [NativeTypeName("ULONG")] uint ulCount, BOOL fUseTextReplacements, [NativeTypeName("LPWSTR *")] ushort** ppszCoMemText, byte* pbDisplayAttributes)
        {
            return ((delegate* unmanaged<ISpRecoResult*, uint, uint, BOOL, ushort**, byte*, int>)(lpVtbl[5]))((ISpRecoResult*)Unsafe.AsPointer(ref this), ulStart, ulCount, fUseTextReplacements, ppszCoMemText, pbDisplayAttributes);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Discard([NativeTypeName("DWORD")] uint dwValueTypes)
        {
            return ((delegate* unmanaged<ISpRecoResult*, uint, int>)(lpVtbl[6]))((ISpRecoResult*)Unsafe.AsPointer(ref this), dwValueTypes);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT GetResultTimes(SPRECORESULTTIMES* pTimes)
        {
            return ((delegate* unmanaged<ISpRecoResult*, SPRECORESULTTIMES*, int>)(lpVtbl[7]))((ISpRecoResult*)Unsafe.AsPointer(ref this), pTimes);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT GetAlternates([NativeTypeName("ULONG")] uint ulStartElement, [NativeTypeName("ULONG")] uint cElements, [NativeTypeName("ULONG")] uint ulRequestCount, ISpPhraseAlt** ppPhrases, [NativeTypeName("ULONG *")] uint* pcPhrasesReturned)
        {
            return ((delegate* unmanaged<ISpRecoResult*, uint, uint, uint, ISpPhraseAlt**, uint*, int>)(lpVtbl[8]))((ISpRecoResult*)Unsafe.AsPointer(ref this), ulStartElement, cElements, ulRequestCount, ppPhrases, pcPhrasesReturned);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT GetAudio([NativeTypeName("ULONG")] uint ulStartElement, [NativeTypeName("ULONG")] uint cElements, ISpStreamFormat** ppStream)
        {
            return ((delegate* unmanaged<ISpRecoResult*, uint, uint, ISpStreamFormat**, int>)(lpVtbl[9]))((ISpRecoResult*)Unsafe.AsPointer(ref this), ulStartElement, cElements, ppStream);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT SpeakAudio([NativeTypeName("ULONG")] uint ulStartElement, [NativeTypeName("ULONG")] uint cElements, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("ULONG *")] uint* pulStreamNumber)
        {
            return ((delegate* unmanaged<ISpRecoResult*, uint, uint, uint, uint*, int>)(lpVtbl[10]))((ISpRecoResult*)Unsafe.AsPointer(ref this), ulStartElement, cElements, dwFlags, pulStreamNumber);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT Serialize(SPSERIALIZEDRESULT** ppCoMemSerializedResult)
        {
            return ((delegate* unmanaged<ISpRecoResult*, SPSERIALIZEDRESULT**, int>)(lpVtbl[11]))((ISpRecoResult*)Unsafe.AsPointer(ref this), ppCoMemSerializedResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT ScaleAudio([NativeTypeName("const GUID *")] Guid* pAudioFormatId, [NativeTypeName("const WAVEFORMATEX *")] WAVEFORMATEX* pWaveFormatEx)
        {
            return ((delegate* unmanaged<ISpRecoResult*, Guid*, WAVEFORMATEX*, int>)(lpVtbl[12]))((ISpRecoResult*)Unsafe.AsPointer(ref this), pAudioFormatId, pWaveFormatEx);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT GetRecoContext(ISpRecoContext** ppRecoContext)
        {
            return ((delegate* unmanaged<ISpRecoResult*, ISpRecoContext**, int>)(lpVtbl[13]))((ISpRecoResult*)Unsafe.AsPointer(ref this), ppRecoContext);
        }

        public interface Interface : ISpPhrase.Interface
        {
            [VtblIndex(7)]
            HRESULT GetResultTimes(SPRECORESULTTIMES* pTimes);

            [VtblIndex(8)]
            HRESULT GetAlternates([NativeTypeName("ULONG")] uint ulStartElement, [NativeTypeName("ULONG")] uint cElements, [NativeTypeName("ULONG")] uint ulRequestCount, ISpPhraseAlt** ppPhrases, [NativeTypeName("ULONG *")] uint* pcPhrasesReturned);

            [VtblIndex(9)]
            HRESULT GetAudio([NativeTypeName("ULONG")] uint ulStartElement, [NativeTypeName("ULONG")] uint cElements, ISpStreamFormat** ppStream);

            [VtblIndex(10)]
            HRESULT SpeakAudio([NativeTypeName("ULONG")] uint ulStartElement, [NativeTypeName("ULONG")] uint cElements, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("ULONG *")] uint* pulStreamNumber);

            [VtblIndex(11)]
            HRESULT Serialize(SPSERIALIZEDRESULT** ppCoMemSerializedResult);

            [VtblIndex(12)]
            HRESULT ScaleAudio([NativeTypeName("const GUID *")] Guid* pAudioFormatId, [NativeTypeName("const WAVEFORMATEX *")] WAVEFORMATEX* pWaveFormatEx);

            [VtblIndex(13)]
            HRESULT GetRecoContext(ISpRecoContext** ppRecoContext);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpRecoResult*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ISpRecoResult*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ISpRecoResult*, uint> Release;

            [NativeTypeName("HRESULT (SPPHRASE **) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpRecoResult*, SPPHRASE**, int> GetPhrase;

            [NativeTypeName("HRESULT (SPSERIALIZEDPHRASE **) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpRecoResult*, SPSERIALIZEDPHRASE**, int> GetSerializedPhrase;

            [NativeTypeName("HRESULT (ULONG, ULONG, BOOL, LPWSTR *, BYTE *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpRecoResult*, uint, uint, BOOL, ushort**, byte*, int> GetText;

            [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpRecoResult*, uint, int> Discard;

            [NativeTypeName("HRESULT (SPRECORESULTTIMES *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpRecoResult*, SPRECORESULTTIMES*, int> GetResultTimes;

            [NativeTypeName("HRESULT (ULONG, ULONG, ULONG, ISpPhraseAlt **, ULONG *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpRecoResult*, uint, uint, uint, ISpPhraseAlt**, uint*, int> GetAlternates;

            [NativeTypeName("HRESULT (ULONG, ULONG, ISpStreamFormat **) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpRecoResult*, uint, uint, ISpStreamFormat**, int> GetAudio;

            [NativeTypeName("HRESULT (ULONG, ULONG, DWORD, ULONG *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpRecoResult*, uint, uint, uint, uint*, int> SpeakAudio;

            [NativeTypeName("HRESULT (SPSERIALIZEDRESULT **) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpRecoResult*, SPSERIALIZEDRESULT**, int> Serialize;

            [NativeTypeName("HRESULT (const GUID *, const WAVEFORMATEX *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpRecoResult*, Guid*, WAVEFORMATEX*, int> ScaleAudio;

            [NativeTypeName("HRESULT (ISpRecoContext **) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpRecoResult*, ISpRecoContext**, int> GetRecoContext;
        }
    }
}
