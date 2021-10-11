// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/XblIdpAuthManager.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("46CE0225-F267-4D68-B299-B2762552DEC1")]
    [NativeTypeName("struct IXblIdpAuthTokenResult : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IXblIdpAuthTokenResult
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IXblIdpAuthTokenResult*, Guid*, void**, int>)(lpVtbl[0]))((IXblIdpAuthTokenResult*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IXblIdpAuthTokenResult*, uint>)(lpVtbl[1]))((IXblIdpAuthTokenResult*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IXblIdpAuthTokenResult*, uint>)(lpVtbl[2]))((IXblIdpAuthTokenResult*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetStatus(XBL_IDP_AUTH_TOKEN_STATUS* status)
        {
            return ((delegate* unmanaged<IXblIdpAuthTokenResult*, XBL_IDP_AUTH_TOKEN_STATUS*, int>)(lpVtbl[3]))((IXblIdpAuthTokenResult*)Unsafe.AsPointer(ref this), status);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetErrorCode([NativeTypeName("HRESULT *")] int* errorCode)
        {
            return ((delegate* unmanaged<IXblIdpAuthTokenResult*, int*, int>)(lpVtbl[4]))((IXblIdpAuthTokenResult*)Unsafe.AsPointer(ref this), errorCode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int GetToken([NativeTypeName("LPWSTR *")] ushort** token)
        {
            return ((delegate* unmanaged<IXblIdpAuthTokenResult*, ushort**, int>)(lpVtbl[5]))((IXblIdpAuthTokenResult*)Unsafe.AsPointer(ref this), token);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int GetSignature([NativeTypeName("LPWSTR *")] ushort** signature)
        {
            return ((delegate* unmanaged<IXblIdpAuthTokenResult*, ushort**, int>)(lpVtbl[6]))((IXblIdpAuthTokenResult*)Unsafe.AsPointer(ref this), signature);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int GetSandbox([NativeTypeName("LPWSTR *")] ushort** sandbox)
        {
            return ((delegate* unmanaged<IXblIdpAuthTokenResult*, ushort**, int>)(lpVtbl[7]))((IXblIdpAuthTokenResult*)Unsafe.AsPointer(ref this), sandbox);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int GetEnvironment([NativeTypeName("LPWSTR *")] ushort** environment)
        {
            return ((delegate* unmanaged<IXblIdpAuthTokenResult*, ushort**, int>)(lpVtbl[8]))((IXblIdpAuthTokenResult*)Unsafe.AsPointer(ref this), environment);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int GetMsaAccountId([NativeTypeName("LPWSTR *")] ushort** msaAccountId)
        {
            return ((delegate* unmanaged<IXblIdpAuthTokenResult*, ushort**, int>)(lpVtbl[9]))((IXblIdpAuthTokenResult*)Unsafe.AsPointer(ref this), msaAccountId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int GetXuid([NativeTypeName("LPWSTR *")] ushort** xuid)
        {
            return ((delegate* unmanaged<IXblIdpAuthTokenResult*, ushort**, int>)(lpVtbl[10]))((IXblIdpAuthTokenResult*)Unsafe.AsPointer(ref this), xuid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int GetGamertag([NativeTypeName("LPWSTR *")] ushort** gamertag)
        {
            return ((delegate* unmanaged<IXblIdpAuthTokenResult*, ushort**, int>)(lpVtbl[11]))((IXblIdpAuthTokenResult*)Unsafe.AsPointer(ref this), gamertag);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("HRESULT")]
        public int GetAgeGroup([NativeTypeName("LPWSTR *")] ushort** ageGroup)
        {
            return ((delegate* unmanaged<IXblIdpAuthTokenResult*, ushort**, int>)(lpVtbl[12]))((IXblIdpAuthTokenResult*)Unsafe.AsPointer(ref this), ageGroup);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        [return: NativeTypeName("HRESULT")]
        public int GetPrivileges([NativeTypeName("LPWSTR *")] ushort** privileges)
        {
            return ((delegate* unmanaged<IXblIdpAuthTokenResult*, ushort**, int>)(lpVtbl[13]))((IXblIdpAuthTokenResult*)Unsafe.AsPointer(ref this), privileges);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        [return: NativeTypeName("HRESULT")]
        public int GetMsaTarget([NativeTypeName("LPWSTR *")] ushort** msaTarget)
        {
            return ((delegate* unmanaged<IXblIdpAuthTokenResult*, ushort**, int>)(lpVtbl[14]))((IXblIdpAuthTokenResult*)Unsafe.AsPointer(ref this), msaTarget);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        [return: NativeTypeName("HRESULT")]
        public int GetMsaPolicy([NativeTypeName("LPWSTR *")] ushort** msaPolicy)
        {
            return ((delegate* unmanaged<IXblIdpAuthTokenResult*, ushort**, int>)(lpVtbl[15]))((IXblIdpAuthTokenResult*)Unsafe.AsPointer(ref this), msaPolicy);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        [return: NativeTypeName("HRESULT")]
        public int GetMsaAppId([NativeTypeName("LPWSTR *")] ushort** msaAppId)
        {
            return ((delegate* unmanaged<IXblIdpAuthTokenResult*, ushort**, int>)(lpVtbl[16]))((IXblIdpAuthTokenResult*)Unsafe.AsPointer(ref this), msaAppId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        [return: NativeTypeName("HRESULT")]
        public int GetRedirect([NativeTypeName("LPWSTR *")] ushort** redirect)
        {
            return ((delegate* unmanaged<IXblIdpAuthTokenResult*, ushort**, int>)(lpVtbl[17]))((IXblIdpAuthTokenResult*)Unsafe.AsPointer(ref this), redirect);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        [return: NativeTypeName("HRESULT")]
        public int GetMessageW([NativeTypeName("LPWSTR *")] ushort** message)
        {
            return ((delegate* unmanaged<IXblIdpAuthTokenResult*, ushort**, int>)(lpVtbl[18]))((IXblIdpAuthTokenResult*)Unsafe.AsPointer(ref this), message);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        [return: NativeTypeName("HRESULT")]
        public int GetHelpId([NativeTypeName("LPWSTR *")] ushort** helpId)
        {
            return ((delegate* unmanaged<IXblIdpAuthTokenResult*, ushort**, int>)(lpVtbl[19]))((IXblIdpAuthTokenResult*)Unsafe.AsPointer(ref this), helpId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        [return: NativeTypeName("HRESULT")]
        public int GetEnforcementBans([NativeTypeName("LPWSTR *")] ushort** enforcementBans)
        {
            return ((delegate* unmanaged<IXblIdpAuthTokenResult*, ushort**, int>)(lpVtbl[20]))((IXblIdpAuthTokenResult*)Unsafe.AsPointer(ref this), enforcementBans);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        [return: NativeTypeName("HRESULT")]
        public int GetRestrictions([NativeTypeName("LPWSTR *")] ushort** restrictions)
        {
            return ((delegate* unmanaged<IXblIdpAuthTokenResult*, ushort**, int>)(lpVtbl[21]))((IXblIdpAuthTokenResult*)Unsafe.AsPointer(ref this), restrictions);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        [return: NativeTypeName("HRESULT")]
        public int GetTitleRestrictions([NativeTypeName("LPWSTR *")] ushort** titleRestrictions)
        {
            return ((delegate* unmanaged<IXblIdpAuthTokenResult*, ushort**, int>)(lpVtbl[22]))((IXblIdpAuthTokenResult*)Unsafe.AsPointer(ref this), titleRestrictions);
        }
    }
}
