// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("8FCEBC98-4E49-4067-9C6C-D86A0E092E3D")]
    [NativeTypeName("struct ISpPhraseAlt : ISpPhrase")]
    public unsafe partial struct ISpPhraseAlt
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ISpPhraseAlt*, Guid*, void**, int>)(lpVtbl[0]))((ISpPhraseAlt*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISpPhraseAlt*, uint>)(lpVtbl[1]))((ISpPhraseAlt*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISpPhraseAlt*, uint>)(lpVtbl[2]))((ISpPhraseAlt*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPhrase(SPPHRASE** ppCoMemPhrase)
        {
            return ((delegate* unmanaged<ISpPhraseAlt*, SPPHRASE**, int>)(lpVtbl[3]))((ISpPhraseAlt*)Unsafe.AsPointer(ref this), ppCoMemPhrase);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSerializedPhrase(SPSERIALIZEDPHRASE** ppCoMemPhrase)
        {
            return ((delegate* unmanaged<ISpPhraseAlt*, SPSERIALIZEDPHRASE**, int>)(lpVtbl[4]))((ISpPhraseAlt*)Unsafe.AsPointer(ref this), ppCoMemPhrase);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetText([NativeTypeName("ULONG")] uint ulStart, [NativeTypeName("ULONG")] uint ulCount, [NativeTypeName("BOOL")] int fUseTextReplacements, [NativeTypeName("LPWSTR *")] ushort** ppszCoMemText, [NativeTypeName("BYTE *")] byte* pbDisplayAttributes)
        {
            return ((delegate* unmanaged<ISpPhraseAlt*, uint, uint, int, ushort**, byte*, int>)(lpVtbl[5]))((ISpPhraseAlt*)Unsafe.AsPointer(ref this), ulStart, ulCount, fUseTextReplacements, ppszCoMemText, pbDisplayAttributes);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Discard([NativeTypeName("DWORD")] uint dwValueTypes)
        {
            return ((delegate* unmanaged<ISpPhraseAlt*, uint, int>)(lpVtbl[6]))((ISpPhraseAlt*)Unsafe.AsPointer(ref this), dwValueTypes);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetAltInfo(ISpPhrase** ppParent, [NativeTypeName("ULONG *")] uint* pulStartElementInParent, [NativeTypeName("ULONG *")] uint* pcElementsInParent, [NativeTypeName("ULONG *")] uint* pcElementsInAlt)
        {
            return ((delegate* unmanaged<ISpPhraseAlt*, ISpPhrase**, uint*, uint*, uint*, int>)(lpVtbl[7]))((ISpPhraseAlt*)Unsafe.AsPointer(ref this), ppParent, pulStartElementInParent, pcElementsInParent, pcElementsInAlt);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Commit()
        {
            return ((delegate* unmanaged<ISpPhraseAlt*, int>)(lpVtbl[8]))((ISpPhraseAlt*)Unsafe.AsPointer(ref this));
        }
    }
}
