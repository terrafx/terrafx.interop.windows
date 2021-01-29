// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ctffunc.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("38E09D4C-586D-435A-B592-C8A86691DEC6")]
    [NativeTypeName("struct ISpeechCommandProvider : IUnknown")]
    public unsafe partial struct ISpeechCommandProvider
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<ISpeechCommandProvider*, Guid*, void**, int>)(lpVtbl[0]))((ISpeechCommandProvider*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISpeechCommandProvider*, uint>)(lpVtbl[1]))((ISpeechCommandProvider*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISpeechCommandProvider*, uint>)(lpVtbl[2]))((ISpeechCommandProvider*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int EnumSpeechCommands([NativeTypeName("LANGID")] ushort langid, [NativeTypeName("IEnumSpeechCommands **")] IEnumSpeechCommands** ppEnum)
        {
            return ((delegate* unmanaged<ISpeechCommandProvider*, ushort, IEnumSpeechCommands**, int>)(lpVtbl[3]))((ISpeechCommandProvider*)Unsafe.AsPointer(ref this), langid, ppEnum);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ProcessCommand([NativeTypeName("const WCHAR *")] ushort* pszCommand, [NativeTypeName("ULONG")] uint cch, [NativeTypeName("LANGID")] ushort langid)
        {
            return ((delegate* unmanaged<ISpeechCommandProvider*, ushort*, uint, ushort, int>)(lpVtbl[4]))((ISpeechCommandProvider*)Unsafe.AsPointer(ref this), pszCommand, cch, langid);
        }
    }
}
