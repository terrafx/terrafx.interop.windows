// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/RestrictedErrorInfo.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("04A2DBF3-DF83-116C-0946-0812ABF6E07D")]
    [NativeTypeName("struct ILanguageExceptionErrorInfo : IUnknown")]
    public unsafe partial struct ILanguageExceptionErrorInfo
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<ILanguageExceptionErrorInfo*, Guid*, void**, int>)(lpVtbl[0]))((ILanguageExceptionErrorInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ILanguageExceptionErrorInfo*, uint>)(lpVtbl[1]))((ILanguageExceptionErrorInfo*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ILanguageExceptionErrorInfo*, uint>)(lpVtbl[2]))((ILanguageExceptionErrorInfo*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetLanguageException([NativeTypeName("IUnknown **")] IUnknown** languageException)
        {
            return ((delegate* unmanaged<ILanguageExceptionErrorInfo*, IUnknown**, int>)(lpVtbl[3]))((ILanguageExceptionErrorInfo*)Unsafe.AsPointer(ref this), languageException);
        }
    }
}
