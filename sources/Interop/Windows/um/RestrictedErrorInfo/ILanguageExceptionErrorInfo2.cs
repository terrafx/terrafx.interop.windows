// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/RestrictedErrorInfo.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("5746E5C4-5B97-424C-B620-2822915734DD")]
    [NativeTypeName("struct ILanguageExceptionErrorInfo2 : ILanguageExceptionErrorInfo")]
    [NativeInheritance("ILanguageExceptionErrorInfo")]
    public unsafe partial struct ILanguageExceptionErrorInfo2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ILanguageExceptionErrorInfo2*, Guid*, void**, int>)(lpVtbl[0]))((ILanguageExceptionErrorInfo2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ILanguageExceptionErrorInfo2*, uint>)(lpVtbl[1]))((ILanguageExceptionErrorInfo2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ILanguageExceptionErrorInfo2*, uint>)(lpVtbl[2]))((ILanguageExceptionErrorInfo2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetLanguageException(IUnknown** languageException)
        {
            return ((delegate* unmanaged<ILanguageExceptionErrorInfo2*, IUnknown**, int>)(lpVtbl[3]))((ILanguageExceptionErrorInfo2*)Unsafe.AsPointer(ref this), languageException);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetPreviousLanguageExceptionErrorInfo(ILanguageExceptionErrorInfo2** previousLanguageExceptionErrorInfo)
        {
            return ((delegate* unmanaged<ILanguageExceptionErrorInfo2*, ILanguageExceptionErrorInfo2**, int>)(lpVtbl[4]))((ILanguageExceptionErrorInfo2*)Unsafe.AsPointer(ref this), previousLanguageExceptionErrorInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int CapturePropagationContext(IUnknown* languageException)
        {
            return ((delegate* unmanaged<ILanguageExceptionErrorInfo2*, IUnknown*, int>)(lpVtbl[5]))((ILanguageExceptionErrorInfo2*)Unsafe.AsPointer(ref this), languageException);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int GetPropagationContextHead(ILanguageExceptionErrorInfo2** propagatedLanguageExceptionErrorInfoHead)
        {
            return ((delegate* unmanaged<ILanguageExceptionErrorInfo2*, ILanguageExceptionErrorInfo2**, int>)(lpVtbl[6]))((ILanguageExceptionErrorInfo2*)Unsafe.AsPointer(ref this), propagatedLanguageExceptionErrorInfoHead);
        }
    }
}
