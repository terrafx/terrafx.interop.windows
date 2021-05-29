// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("F264DA52-E457-4696-B856-A737B717AF79")]
    [NativeTypeName("struct ISpPhrase2 : ISpPhrase")]
    public unsafe partial struct ISpPhrase2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ISpPhrase2*, Guid*, void**, int>)(lpVtbl[0]))((ISpPhrase2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISpPhrase2*, uint>)(lpVtbl[1]))((ISpPhrase2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISpPhrase2*, uint>)(lpVtbl[2]))((ISpPhrase2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPhrase(SPPHRASE** ppCoMemPhrase)
        {
            return ((delegate* unmanaged<ISpPhrase2*, SPPHRASE**, int>)(lpVtbl[3]))((ISpPhrase2*)Unsafe.AsPointer(ref this), ppCoMemPhrase);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSerializedPhrase(SPSERIALIZEDPHRASE** ppCoMemPhrase)
        {
            return ((delegate* unmanaged<ISpPhrase2*, SPSERIALIZEDPHRASE**, int>)(lpVtbl[4]))((ISpPhrase2*)Unsafe.AsPointer(ref this), ppCoMemPhrase);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetText([NativeTypeName("ULONG")] uint ulStart, [NativeTypeName("ULONG")] uint ulCount, [NativeTypeName("BOOL")] int fUseTextReplacements, [NativeTypeName("LPWSTR *")] ushort** ppszCoMemText, [NativeTypeName("BYTE *")] byte* pbDisplayAttributes)
        {
            return ((delegate* unmanaged<ISpPhrase2*, uint, uint, int, ushort**, byte*, int>)(lpVtbl[5]))((ISpPhrase2*)Unsafe.AsPointer(ref this), ulStart, ulCount, fUseTextReplacements, ppszCoMemText, pbDisplayAttributes);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Discard([NativeTypeName("DWORD")] uint dwValueTypes)
        {
            return ((delegate* unmanaged<ISpPhrase2*, uint, int>)(lpVtbl[6]))((ISpPhrase2*)Unsafe.AsPointer(ref this), dwValueTypes);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetXMLResult([NativeTypeName("LPWSTR *")] ushort** ppszCoMemXMLResult, SPXMLRESULTOPTIONS Options)
        {
            return ((delegate* unmanaged<ISpPhrase2*, ushort**, SPXMLRESULTOPTIONS, int>)(lpVtbl[7]))((ISpPhrase2*)Unsafe.AsPointer(ref this), ppszCoMemXMLResult, Options);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetXMLErrorInfo(SPSEMANTICERRORINFO* pSemanticErrorInfo)
        {
            return ((delegate* unmanaged<ISpPhrase2*, SPSEMANTICERRORINFO*, int>)(lpVtbl[8]))((ISpPhrase2*)Unsafe.AsPointer(ref this), pSemanticErrorInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetAudio([NativeTypeName("ULONG")] uint ulStartElement, [NativeTypeName("ULONG")] uint cElements, ISpStreamFormat** ppStream)
        {
            return ((delegate* unmanaged<ISpPhrase2*, uint, uint, ISpStreamFormat**, int>)(lpVtbl[9]))((ISpPhrase2*)Unsafe.AsPointer(ref this), ulStartElement, cElements, ppStream);
        }
    }
}
