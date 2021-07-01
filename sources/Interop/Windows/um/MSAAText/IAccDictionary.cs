// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MSAAText.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("1DC4CB5F-D737-474D-ADE9-5CCFC9BC1CC9")]
    [NativeTypeName("struct IAccDictionary : IUnknown")]
    public unsafe partial struct IAccDictionary
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IAccDictionary*, Guid*, void**, int>)(lpVtbl[0]))((IAccDictionary*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAccDictionary*, uint>)(lpVtbl[1]))((IAccDictionary*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAccDictionary*, uint>)(lpVtbl[2]))((IAccDictionary*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetLocalizedString([NativeTypeName("const GUID &")] Guid* Term, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("BSTR *")] ushort** pResult, [NativeTypeName("LCID *")] uint* plcid)
        {
            return ((delegate* unmanaged<IAccDictionary*, Guid*, uint, ushort**, uint*, int>)(lpVtbl[3]))((IAccDictionary*)Unsafe.AsPointer(ref this), Term, lcid, pResult, plcid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetParentTerm([NativeTypeName("const GUID &")] Guid* Term, [NativeTypeName("GUID *")] Guid* pParentTerm)
        {
            return ((delegate* unmanaged<IAccDictionary*, Guid*, Guid*, int>)(lpVtbl[4]))((IAccDictionary*)Unsafe.AsPointer(ref this), Term, pParentTerm);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetMnemonicString([NativeTypeName("const GUID &")] Guid* Term, [NativeTypeName("BSTR *")] ushort** pResult)
        {
            return ((delegate* unmanaged<IAccDictionary*, Guid*, ushort**, int>)(lpVtbl[5]))((IAccDictionary*)Unsafe.AsPointer(ref this), Term, pResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int LookupMnemonicTerm([NativeTypeName("BSTR")] ushort* bstrMnemonic, [NativeTypeName("GUID *")] Guid* pTerm)
        {
            return ((delegate* unmanaged<IAccDictionary*, ushort*, Guid*, int>)(lpVtbl[6]))((IAccDictionary*)Unsafe.AsPointer(ref this), bstrMnemonic, pTerm);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ConvertValueToString([NativeTypeName("const GUID &")] Guid* Term, [NativeTypeName("LCID")] uint lcid, VARIANT varValue, [NativeTypeName("BSTR *")] ushort** pbstrResult, [NativeTypeName("LCID *")] uint* plcid)
        {
            return ((delegate* unmanaged<IAccDictionary*, Guid*, uint, VARIANT, ushort**, uint*, int>)(lpVtbl[7]))((IAccDictionary*)Unsafe.AsPointer(ref this), Term, lcid, varValue, pbstrResult, plcid);
        }
    }
}
