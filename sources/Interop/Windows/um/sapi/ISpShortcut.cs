// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3DF681E2-EA56-11D9-8BDE-F66BAD1E3F3A")]
    [NativeTypeName("struct ISpShortcut : IUnknown")]
    public unsafe partial struct ISpShortcut
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<ISpShortcut*, Guid*, void**, int>)(lpVtbl[0]))((ISpShortcut*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<ISpShortcut*, uint>)(lpVtbl[1]))((ISpShortcut*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<ISpShortcut*, uint>)(lpVtbl[2]))((ISpShortcut*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int AddShortcut([NativeTypeName("LPCWSTR")] ushort* pszDisplay, [NativeTypeName("WORD")] ushort LangID, [NativeTypeName("LPCWSTR")] ushort* pszSpoken, SPSHORTCUTTYPE shType)
        {
            return ((delegate* stdcall<ISpShortcut*, ushort*, ushort, ushort*, SPSHORTCUTTYPE, int>)(lpVtbl[3]))((ISpShortcut*)Unsafe.AsPointer(ref this), pszDisplay, LangID, pszSpoken, shType);
        }

        [return: NativeTypeName("HRESULT")]
        public int RemoveShortcut([NativeTypeName("LPCWSTR")] ushort* pszDisplay, [NativeTypeName("WORD")] ushort LangID, [NativeTypeName("LPCWSTR")] ushort* pszSpoken, SPSHORTCUTTYPE shType)
        {
            return ((delegate* stdcall<ISpShortcut*, ushort*, ushort, ushort*, SPSHORTCUTTYPE, int>)(lpVtbl[4]))((ISpShortcut*)Unsafe.AsPointer(ref this), pszDisplay, LangID, pszSpoken, shType);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetShortcuts([NativeTypeName("WORD")] ushort LangID, [NativeTypeName("SPSHORTCUTPAIRLIST *")] SPSHORTCUTPAIRLIST* pShortcutpairList)
        {
            return ((delegate* stdcall<ISpShortcut*, ushort, SPSHORTCUTPAIRLIST*, int>)(lpVtbl[5]))((ISpShortcut*)Unsafe.AsPointer(ref this), LangID, pShortcutpairList);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetGeneration([NativeTypeName("DWORD *")] uint* pdwGeneration)
        {
            return ((delegate* stdcall<ISpShortcut*, uint*, int>)(lpVtbl[6]))((ISpShortcut*)Unsafe.AsPointer(ref this), pdwGeneration);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetWordsFromGenerationChange([NativeTypeName("DWORD *")] uint* pdwGeneration, [NativeTypeName("SPWORDLIST *")] SPWORDLIST* pWordList)
        {
            return ((delegate* stdcall<ISpShortcut*, uint*, SPWORDLIST*, int>)(lpVtbl[7]))((ISpShortcut*)Unsafe.AsPointer(ref this), pdwGeneration, pWordList);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetWords([NativeTypeName("DWORD *")] uint* pdwGeneration, [NativeTypeName("DWORD *")] uint* pdwCookie, [NativeTypeName("SPWORDLIST *")] SPWORDLIST* pWordList)
        {
            return ((delegate* stdcall<ISpShortcut*, uint*, uint*, SPWORDLIST*, int>)(lpVtbl[8]))((ISpShortcut*)Unsafe.AsPointer(ref this), pdwGeneration, pdwCookie, pWordList);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetShortcutsForGeneration([NativeTypeName("DWORD *")] uint* pdwGeneration, [NativeTypeName("DWORD *")] uint* pdwCookie, [NativeTypeName("SPSHORTCUTPAIRLIST *")] SPSHORTCUTPAIRLIST* pShortcutpairList)
        {
            return ((delegate* stdcall<ISpShortcut*, uint*, uint*, SPSHORTCUTPAIRLIST*, int>)(lpVtbl[9]))((ISpShortcut*)Unsafe.AsPointer(ref this), pdwGeneration, pdwCookie, pShortcutpairList);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetGenerationChange([NativeTypeName("DWORD *")] uint* pdwGeneration, [NativeTypeName("SPSHORTCUTPAIRLIST *")] SPSHORTCUTPAIRLIST* pShortcutpairList)
        {
            return ((delegate* stdcall<ISpShortcut*, uint*, SPSHORTCUTPAIRLIST*, int>)(lpVtbl[10]))((ISpShortcut*)Unsafe.AsPointer(ref this), pdwGeneration, pShortcutpairList);
        }
    }
}
