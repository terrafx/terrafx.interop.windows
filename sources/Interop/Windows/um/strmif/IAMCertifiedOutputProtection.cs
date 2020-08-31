// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("6FEDED3E-0FF1-4901-A2F1-43F7012C8515")]
    [NativeTypeName("struct IAMCertifiedOutputProtection : IUnknown")]
    public unsafe partial struct IAMCertifiedOutputProtection
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IAMCertifiedOutputProtection*, Guid*, void**, int>)(lpVtbl[0]))((IAMCertifiedOutputProtection*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IAMCertifiedOutputProtection*, uint>)(lpVtbl[1]))((IAMCertifiedOutputProtection*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IAMCertifiedOutputProtection*, uint>)(lpVtbl[2]))((IAMCertifiedOutputProtection*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int KeyExchange([NativeTypeName("GUID *")] Guid* pRandom, [NativeTypeName("BYTE **")] byte** VarLenCertGH, [NativeTypeName("DWORD *")] uint* pdwLengthCertGH)
        {
            return ((delegate* stdcall<IAMCertifiedOutputProtection*, Guid*, byte**, uint*, int>)(lpVtbl[3]))((IAMCertifiedOutputProtection*)Unsafe.AsPointer(ref this), pRandom, VarLenCertGH, pdwLengthCertGH);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SessionSequenceStart([NativeTypeName("AMCOPPSignature *")] AMCOPPSignature* pSig)
        {
            return ((delegate* stdcall<IAMCertifiedOutputProtection*, AMCOPPSignature*, int>)(lpVtbl[4]))((IAMCertifiedOutputProtection*)Unsafe.AsPointer(ref this), pSig);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ProtectionCommand([NativeTypeName("const AMCOPPCommand *")] AMCOPPCommand* cmd)
        {
            return ((delegate* stdcall<IAMCertifiedOutputProtection*, AMCOPPCommand*, int>)(lpVtbl[5]))((IAMCertifiedOutputProtection*)Unsafe.AsPointer(ref this), cmd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ProtectionStatus([NativeTypeName("const AMCOPPStatusInput *")] AMCOPPStatusInput* pStatusInput, [NativeTypeName("AMCOPPStatusOutput *")] AMCOPPStatusOutput* pStatusOutput)
        {
            return ((delegate* stdcall<IAMCertifiedOutputProtection*, AMCOPPStatusInput*, AMCOPPStatusOutput*, int>)(lpVtbl[6]))((IAMCertifiedOutputProtection*)Unsafe.AsPointer(ref this), pStatusInput, pStatusOutput);
        }
    }
}
