// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/XblIdpAuthManager.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    [Guid("46CE0225-F267-4D68-B299-B2762552DEC1")]
    [NativeTypeName("struct IXblIdpAuthTokenResult : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IXblIdpAuthTokenResult : IXblIdpAuthTokenResult.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
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
        public HRESULT GetStatus(XBL_IDP_AUTH_TOKEN_STATUS* status)
        {
            return ((delegate* unmanaged<IXblIdpAuthTokenResult*, XBL_IDP_AUTH_TOKEN_STATUS*, int>)(lpVtbl[3]))((IXblIdpAuthTokenResult*)Unsafe.AsPointer(ref this), status);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetErrorCode(HRESULT* errorCode)
        {
            return ((delegate* unmanaged<IXblIdpAuthTokenResult*, HRESULT*, int>)(lpVtbl[4]))((IXblIdpAuthTokenResult*)Unsafe.AsPointer(ref this), errorCode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetToken([NativeTypeName("LPWSTR *")] ushort** token)
        {
            return ((delegate* unmanaged<IXblIdpAuthTokenResult*, ushort**, int>)(lpVtbl[5]))((IXblIdpAuthTokenResult*)Unsafe.AsPointer(ref this), token);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT GetSignature([NativeTypeName("LPWSTR *")] ushort** signature)
        {
            return ((delegate* unmanaged<IXblIdpAuthTokenResult*, ushort**, int>)(lpVtbl[6]))((IXblIdpAuthTokenResult*)Unsafe.AsPointer(ref this), signature);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT GetSandbox([NativeTypeName("LPWSTR *")] ushort** sandbox)
        {
            return ((delegate* unmanaged<IXblIdpAuthTokenResult*, ushort**, int>)(lpVtbl[7]))((IXblIdpAuthTokenResult*)Unsafe.AsPointer(ref this), sandbox);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT GetEnvironment([NativeTypeName("LPWSTR *")] ushort** environment)
        {
            return ((delegate* unmanaged<IXblIdpAuthTokenResult*, ushort**, int>)(lpVtbl[8]))((IXblIdpAuthTokenResult*)Unsafe.AsPointer(ref this), environment);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT GetMsaAccountId([NativeTypeName("LPWSTR *")] ushort** msaAccountId)
        {
            return ((delegate* unmanaged<IXblIdpAuthTokenResult*, ushort**, int>)(lpVtbl[9]))((IXblIdpAuthTokenResult*)Unsafe.AsPointer(ref this), msaAccountId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT GetXuid([NativeTypeName("LPWSTR *")] ushort** xuid)
        {
            return ((delegate* unmanaged<IXblIdpAuthTokenResult*, ushort**, int>)(lpVtbl[10]))((IXblIdpAuthTokenResult*)Unsafe.AsPointer(ref this), xuid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT GetGamertag([NativeTypeName("LPWSTR *")] ushort** gamertag)
        {
            return ((delegate* unmanaged<IXblIdpAuthTokenResult*, ushort**, int>)(lpVtbl[11]))((IXblIdpAuthTokenResult*)Unsafe.AsPointer(ref this), gamertag);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT GetAgeGroup([NativeTypeName("LPWSTR *")] ushort** ageGroup)
        {
            return ((delegate* unmanaged<IXblIdpAuthTokenResult*, ushort**, int>)(lpVtbl[12]))((IXblIdpAuthTokenResult*)Unsafe.AsPointer(ref this), ageGroup);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT GetPrivileges([NativeTypeName("LPWSTR *")] ushort** privileges)
        {
            return ((delegate* unmanaged<IXblIdpAuthTokenResult*, ushort**, int>)(lpVtbl[13]))((IXblIdpAuthTokenResult*)Unsafe.AsPointer(ref this), privileges);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT GetMsaTarget([NativeTypeName("LPWSTR *")] ushort** msaTarget)
        {
            return ((delegate* unmanaged<IXblIdpAuthTokenResult*, ushort**, int>)(lpVtbl[14]))((IXblIdpAuthTokenResult*)Unsafe.AsPointer(ref this), msaTarget);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT GetMsaPolicy([NativeTypeName("LPWSTR *")] ushort** msaPolicy)
        {
            return ((delegate* unmanaged<IXblIdpAuthTokenResult*, ushort**, int>)(lpVtbl[15]))((IXblIdpAuthTokenResult*)Unsafe.AsPointer(ref this), msaPolicy);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT GetMsaAppId([NativeTypeName("LPWSTR *")] ushort** msaAppId)
        {
            return ((delegate* unmanaged<IXblIdpAuthTokenResult*, ushort**, int>)(lpVtbl[16]))((IXblIdpAuthTokenResult*)Unsafe.AsPointer(ref this), msaAppId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT GetRedirect([NativeTypeName("LPWSTR *")] ushort** redirect)
        {
            return ((delegate* unmanaged<IXblIdpAuthTokenResult*, ushort**, int>)(lpVtbl[17]))((IXblIdpAuthTokenResult*)Unsafe.AsPointer(ref this), redirect);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public HRESULT GetMessageW([NativeTypeName("LPWSTR *")] ushort** message)
        {
            return ((delegate* unmanaged<IXblIdpAuthTokenResult*, ushort**, int>)(lpVtbl[18]))((IXblIdpAuthTokenResult*)Unsafe.AsPointer(ref this), message);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public HRESULT GetHelpId([NativeTypeName("LPWSTR *")] ushort** helpId)
        {
            return ((delegate* unmanaged<IXblIdpAuthTokenResult*, ushort**, int>)(lpVtbl[19]))((IXblIdpAuthTokenResult*)Unsafe.AsPointer(ref this), helpId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        public HRESULT GetEnforcementBans([NativeTypeName("LPWSTR *")] ushort** enforcementBans)
        {
            return ((delegate* unmanaged<IXblIdpAuthTokenResult*, ushort**, int>)(lpVtbl[20]))((IXblIdpAuthTokenResult*)Unsafe.AsPointer(ref this), enforcementBans);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        public HRESULT GetRestrictions([NativeTypeName("LPWSTR *")] ushort** restrictions)
        {
            return ((delegate* unmanaged<IXblIdpAuthTokenResult*, ushort**, int>)(lpVtbl[21]))((IXblIdpAuthTokenResult*)Unsafe.AsPointer(ref this), restrictions);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        public HRESULT GetTitleRestrictions([NativeTypeName("LPWSTR *")] ushort** titleRestrictions)
        {
            return ((delegate* unmanaged<IXblIdpAuthTokenResult*, ushort**, int>)(lpVtbl[22]))((IXblIdpAuthTokenResult*)Unsafe.AsPointer(ref this), titleRestrictions);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT GetStatus(XBL_IDP_AUTH_TOKEN_STATUS* status);

            [VtblIndex(4)]
            HRESULT GetErrorCode(HRESULT* errorCode);

            [VtblIndex(5)]
            HRESULT GetToken([NativeTypeName("LPWSTR *")] ushort** token);

            [VtblIndex(6)]
            HRESULT GetSignature([NativeTypeName("LPWSTR *")] ushort** signature);

            [VtblIndex(7)]
            HRESULT GetSandbox([NativeTypeName("LPWSTR *")] ushort** sandbox);

            [VtblIndex(8)]
            HRESULT GetEnvironment([NativeTypeName("LPWSTR *")] ushort** environment);

            [VtblIndex(9)]
            HRESULT GetMsaAccountId([NativeTypeName("LPWSTR *")] ushort** msaAccountId);

            [VtblIndex(10)]
            HRESULT GetXuid([NativeTypeName("LPWSTR *")] ushort** xuid);

            [VtblIndex(11)]
            HRESULT GetGamertag([NativeTypeName("LPWSTR *")] ushort** gamertag);

            [VtblIndex(12)]
            HRESULT GetAgeGroup([NativeTypeName("LPWSTR *")] ushort** ageGroup);

            [VtblIndex(13)]
            HRESULT GetPrivileges([NativeTypeName("LPWSTR *")] ushort** privileges);

            [VtblIndex(14)]
            HRESULT GetMsaTarget([NativeTypeName("LPWSTR *")] ushort** msaTarget);

            [VtblIndex(15)]
            HRESULT GetMsaPolicy([NativeTypeName("LPWSTR *")] ushort** msaPolicy);

            [VtblIndex(16)]
            HRESULT GetMsaAppId([NativeTypeName("LPWSTR *")] ushort** msaAppId);

            [VtblIndex(17)]
            HRESULT GetRedirect([NativeTypeName("LPWSTR *")] ushort** redirect);

            [VtblIndex(18)]
            HRESULT GetMessageW([NativeTypeName("LPWSTR *")] ushort** message);

            [VtblIndex(19)]
            HRESULT GetHelpId([NativeTypeName("LPWSTR *")] ushort** helpId);

            [VtblIndex(20)]
            HRESULT GetEnforcementBans([NativeTypeName("LPWSTR *")] ushort** enforcementBans);

            [VtblIndex(21)]
            HRESULT GetRestrictions([NativeTypeName("LPWSTR *")] ushort** restrictions);

            [VtblIndex(22)]
            HRESULT GetTitleRestrictions([NativeTypeName("LPWSTR *")] ushort** titleRestrictions);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IXblIdpAuthTokenResult*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IXblIdpAuthTokenResult*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IXblIdpAuthTokenResult*, uint> Release;

            [NativeTypeName("HRESULT (XBL_IDP_AUTH_TOKEN_STATUS *) __attribute__((stdcall))")]
            public delegate* unmanaged<IXblIdpAuthTokenResult*, XBL_IDP_AUTH_TOKEN_STATUS*, int> GetStatus;

            [NativeTypeName("HRESULT (HRESULT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IXblIdpAuthTokenResult*, HRESULT*, int> GetErrorCode;

            [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IXblIdpAuthTokenResult*, ushort**, int> GetToken;

            [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IXblIdpAuthTokenResult*, ushort**, int> GetSignature;

            [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IXblIdpAuthTokenResult*, ushort**, int> GetSandbox;

            [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IXblIdpAuthTokenResult*, ushort**, int> GetEnvironment;

            [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IXblIdpAuthTokenResult*, ushort**, int> GetMsaAccountId;

            [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IXblIdpAuthTokenResult*, ushort**, int> GetXuid;

            [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IXblIdpAuthTokenResult*, ushort**, int> GetGamertag;

            [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IXblIdpAuthTokenResult*, ushort**, int> GetAgeGroup;

            [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IXblIdpAuthTokenResult*, ushort**, int> GetPrivileges;

            [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IXblIdpAuthTokenResult*, ushort**, int> GetMsaTarget;

            [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IXblIdpAuthTokenResult*, ushort**, int> GetMsaPolicy;

            [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IXblIdpAuthTokenResult*, ushort**, int> GetMsaAppId;

            [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IXblIdpAuthTokenResult*, ushort**, int> GetRedirect;

            [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IXblIdpAuthTokenResult*, ushort**, int> GetMessageW;

            [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IXblIdpAuthTokenResult*, ushort**, int> GetHelpId;

            [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IXblIdpAuthTokenResult*, ushort**, int> GetEnforcementBans;

            [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IXblIdpAuthTokenResult*, ushort**, int> GetRestrictions;

            [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IXblIdpAuthTokenResult*, ushort**, int> GetTitleRestrictions;
        }
    }
}
