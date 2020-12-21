// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("AE39362B-45A8-4074-9B9E-CCF49AA2D0B6")]
    [NativeTypeName("struct ISpXMLRecoResult : ISpRecoResult")]
    public unsafe partial struct ISpXMLRecoResult
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<ISpXMLRecoResult*, Guid*, void**, int>)(lpVtbl[0]))((ISpXMLRecoResult*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<ISpXMLRecoResult*, uint>)(lpVtbl[1]))((ISpXMLRecoResult*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<ISpXMLRecoResult*, uint>)(lpVtbl[2]))((ISpXMLRecoResult*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPhrase([NativeTypeName("SPPHRASE **")] SPPHRASE** ppCoMemPhrase)
        {
            return ((delegate* unmanaged[Stdcall]<ISpXMLRecoResult*, SPPHRASE**, int>)(lpVtbl[3]))((ISpXMLRecoResult*)Unsafe.AsPointer(ref this), ppCoMemPhrase);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSerializedPhrase([NativeTypeName("SPSERIALIZEDPHRASE **")] SPSERIALIZEDPHRASE** ppCoMemPhrase)
        {
            return ((delegate* unmanaged[Stdcall]<ISpXMLRecoResult*, SPSERIALIZEDPHRASE**, int>)(lpVtbl[4]))((ISpXMLRecoResult*)Unsafe.AsPointer(ref this), ppCoMemPhrase);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetText([NativeTypeName("ULONG")] uint ulStart, [NativeTypeName("ULONG")] uint ulCount, [NativeTypeName("BOOL")] int fUseTextReplacements, [NativeTypeName("LPWSTR *")] ushort** ppszCoMemText, [NativeTypeName("BYTE *")] byte* pbDisplayAttributes)
        {
            return ((delegate* unmanaged[Stdcall]<ISpXMLRecoResult*, uint, uint, int, ushort**, byte*, int>)(lpVtbl[5]))((ISpXMLRecoResult*)Unsafe.AsPointer(ref this), ulStart, ulCount, fUseTextReplacements, ppszCoMemText, pbDisplayAttributes);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Discard([NativeTypeName("DWORD")] uint dwValueTypes)
        {
            return ((delegate* unmanaged[Stdcall]<ISpXMLRecoResult*, uint, int>)(lpVtbl[6]))((ISpXMLRecoResult*)Unsafe.AsPointer(ref this), dwValueTypes);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetResultTimes([NativeTypeName("SPRECORESULTTIMES *")] SPRECORESULTTIMES* pTimes)
        {
            return ((delegate* unmanaged[Stdcall]<ISpXMLRecoResult*, SPRECORESULTTIMES*, int>)(lpVtbl[7]))((ISpXMLRecoResult*)Unsafe.AsPointer(ref this), pTimes);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetAlternates([NativeTypeName("ULONG")] uint ulStartElement, [NativeTypeName("ULONG")] uint cElements, [NativeTypeName("ULONG")] uint ulRequestCount, [NativeTypeName("ISpPhraseAlt **")] ISpPhraseAlt** ppPhrases, [NativeTypeName("ULONG *")] uint* pcPhrasesReturned)
        {
            return ((delegate* unmanaged[Stdcall]<ISpXMLRecoResult*, uint, uint, uint, ISpPhraseAlt**, uint*, int>)(lpVtbl[8]))((ISpXMLRecoResult*)Unsafe.AsPointer(ref this), ulStartElement, cElements, ulRequestCount, ppPhrases, pcPhrasesReturned);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetAudio([NativeTypeName("ULONG")] uint ulStartElement, [NativeTypeName("ULONG")] uint cElements, [NativeTypeName("ISpStreamFormat **")] ISpStreamFormat** ppStream)
        {
            return ((delegate* unmanaged[Stdcall]<ISpXMLRecoResult*, uint, uint, ISpStreamFormat**, int>)(lpVtbl[9]))((ISpXMLRecoResult*)Unsafe.AsPointer(ref this), ulStartElement, cElements, ppStream);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SpeakAudio([NativeTypeName("ULONG")] uint ulStartElement, [NativeTypeName("ULONG")] uint cElements, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("ULONG *")] uint* pulStreamNumber)
        {
            return ((delegate* unmanaged[Stdcall]<ISpXMLRecoResult*, uint, uint, uint, uint*, int>)(lpVtbl[10]))((ISpXMLRecoResult*)Unsafe.AsPointer(ref this), ulStartElement, cElements, dwFlags, pulStreamNumber);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Serialize([NativeTypeName("SPSERIALIZEDRESULT **")] SPSERIALIZEDRESULT** ppCoMemSerializedResult)
        {
            return ((delegate* unmanaged[Stdcall]<ISpXMLRecoResult*, SPSERIALIZEDRESULT**, int>)(lpVtbl[11]))((ISpXMLRecoResult*)Unsafe.AsPointer(ref this), ppCoMemSerializedResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ScaleAudio([NativeTypeName("const GUID *")] Guid* pAudioFormatId, [NativeTypeName("const WAVEFORMATEX *")] WAVEFORMATEX* pWaveFormatEx)
        {
            return ((delegate* unmanaged[Stdcall]<ISpXMLRecoResult*, Guid*, WAVEFORMATEX*, int>)(lpVtbl[12]))((ISpXMLRecoResult*)Unsafe.AsPointer(ref this), pAudioFormatId, pWaveFormatEx);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRecoContext([NativeTypeName("ISpRecoContext **")] ISpRecoContext** ppRecoContext)
        {
            return ((delegate* unmanaged[Stdcall]<ISpXMLRecoResult*, ISpRecoContext**, int>)(lpVtbl[13]))((ISpXMLRecoResult*)Unsafe.AsPointer(ref this), ppRecoContext);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetXMLResult([NativeTypeName("LPWSTR *")] ushort** ppszCoMemXMLResult, SPXMLRESULTOPTIONS Options)
        {
            return ((delegate* unmanaged[Stdcall]<ISpXMLRecoResult*, ushort**, SPXMLRESULTOPTIONS, int>)(lpVtbl[14]))((ISpXMLRecoResult*)Unsafe.AsPointer(ref this), ppszCoMemXMLResult, Options);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetXMLErrorInfo([NativeTypeName("SPSEMANTICERRORINFO *")] SPSEMANTICERRORINFO* pSemanticErrorInfo)
        {
            return ((delegate* unmanaged[Stdcall]<ISpXMLRecoResult*, SPSEMANTICERRORINFO*, int>)(lpVtbl[15]))((ISpXMLRecoResult*)Unsafe.AsPointer(ref this), pSemanticErrorInfo);
        }
    }
}
