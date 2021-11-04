// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("8FCEBC98-4E49-4067-9C6C-D86A0E092E3D")]
    [NativeTypeName("struct ISpPhraseAlt : ISpPhrase")]
    [NativeInheritance("ISpPhrase")]
    public unsafe partial struct ISpPhraseAlt
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ISpPhraseAlt*, Guid*, void**, int>)(lpVtbl[0]))((ISpPhraseAlt*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISpPhraseAlt*, uint>)(lpVtbl[1]))((ISpPhraseAlt*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISpPhraseAlt*, uint>)(lpVtbl[2]))((ISpPhraseAlt*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetPhrase(SPPHRASE** ppCoMemPhrase)
        {
            return ((delegate* unmanaged<ISpPhraseAlt*, SPPHRASE**, int>)(lpVtbl[3]))((ISpPhraseAlt*)Unsafe.AsPointer(ref this), ppCoMemPhrase);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetSerializedPhrase(SPSERIALIZEDPHRASE** ppCoMemPhrase)
        {
            return ((delegate* unmanaged<ISpPhraseAlt*, SPSERIALIZEDPHRASE**, int>)(lpVtbl[4]))((ISpPhraseAlt*)Unsafe.AsPointer(ref this), ppCoMemPhrase);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetText([NativeTypeName("ULONG")] uint ulStart, [NativeTypeName("ULONG")] uint ulCount, BOOL fUseTextReplacements, [NativeTypeName("LPWSTR *")] ushort** ppszCoMemText, byte* pbDisplayAttributes)
        {
            return ((delegate* unmanaged<ISpPhraseAlt*, uint, uint, BOOL, ushort**, byte*, int>)(lpVtbl[5]))((ISpPhraseAlt*)Unsafe.AsPointer(ref this), ulStart, ulCount, fUseTextReplacements, ppszCoMemText, pbDisplayAttributes);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Discard([NativeTypeName("DWORD")] uint dwValueTypes)
        {
            return ((delegate* unmanaged<ISpPhraseAlt*, uint, int>)(lpVtbl[6]))((ISpPhraseAlt*)Unsafe.AsPointer(ref this), dwValueTypes);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT GetAltInfo(ISpPhrase** ppParent, [NativeTypeName("ULONG *")] uint* pulStartElementInParent, [NativeTypeName("ULONG *")] uint* pcElementsInParent, [NativeTypeName("ULONG *")] uint* pcElementsInAlt)
        {
            return ((delegate* unmanaged<ISpPhraseAlt*, ISpPhrase**, uint*, uint*, uint*, int>)(lpVtbl[7]))((ISpPhraseAlt*)Unsafe.AsPointer(ref this), ppParent, pulStartElementInParent, pcElementsInParent, pcElementsInAlt);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT Commit()
        {
            return ((delegate* unmanaged<ISpPhraseAlt*, int>)(lpVtbl[8]))((ISpPhraseAlt*)Unsafe.AsPointer(ref this));
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpPhraseAlt*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ISpPhraseAlt*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ISpPhraseAlt*, uint> Release;

            [NativeTypeName("HRESULT (SPPHRASE **) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpPhraseAlt*, SPPHRASE**, int> GetPhrase;

            [NativeTypeName("HRESULT (SPSERIALIZEDPHRASE **) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpPhraseAlt*, SPSERIALIZEDPHRASE**, int> GetSerializedPhrase;

            [NativeTypeName("HRESULT (ULONG, ULONG, BOOL, LPWSTR *, BYTE *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpPhraseAlt*, uint, uint, BOOL, ushort**, byte*, int> GetText;

            [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpPhraseAlt*, uint, int> Discard;

            [NativeTypeName("HRESULT (ISpPhrase **, ULONG *, ULONG *, ULONG *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpPhraseAlt*, ISpPhrase**, uint*, uint*, uint*, int> GetAltInfo;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<ISpPhraseAlt*, int> Commit;
        }
    }
}
