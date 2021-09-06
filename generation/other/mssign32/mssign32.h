// Code sourced from from https://docs.microsoft.com/en-us/windows/win32/appxpkg/how-to-programmatically-sign-a-package
// Copyright © Microsoft. All rights reserved. License information available at https://github.com/MicrosoftDocs/win32/blob/docs/LICENSE-CODE

#include <wincrypt.h>

extern "C"
{
    typedef struct _SIGNER_FILE_INFO
    {
        DWORD cbSize;
        LPCWSTR pwszFileName;
        HANDLE hFile;
    }SIGNER_FILE_INFO, *PSIGNER_FILE_INFO;

    typedef struct _SIGNER_BLOB_INFO
    {
        DWORD cbSize;
        GUID *pGuidSubject;
        DWORD cbBlob;
        BYTE *pbBlob;
        LPCWSTR pwszDisplayName;
    }SIGNER_BLOB_INFO, *PSIGNER_BLOB_INFO;


    typedef struct _SIGNER_SUBJECT_INFO
    {
        DWORD cbSize;
        DWORD *pdwIndex;
        DWORD dwSubjectChoice;
        union
        {
            SIGNER_FILE_INFO *pSignerFileInfo;
            SIGNER_BLOB_INFO *pSignerBlobInfo;
        };
    }SIGNER_SUBJECT_INFO, *PSIGNER_SUBJECT_INFO;

    // dwSubjectChoice should be one of the following:
    #define SIGNER_SUBJECT_FILE    0x01
    #define SIGNER_SUBJECT_BLOB    0x02

    typedef struct _SIGNER_ATTR_AUTHCODE
    {
        DWORD cbSize;
        BOOL fCommercial;
        BOOL fIndividual;
        LPCWSTR pwszName;
        LPCWSTR pwszInfo;
    }SIGNER_ATTR_AUTHCODE, *PSIGNER_ATTR_AUTHCODE;

    typedef struct _SIGNER_SIGNATURE_INFO
    {
        DWORD cbSize;
        ALG_ID algidHash;
        DWORD dwAttrChoice;
        union
        {
            SIGNER_ATTR_AUTHCODE *pAttrAuthcode;
        };
        PCRYPT_ATTRIBUTES psAuthenticated;
        PCRYPT_ATTRIBUTES psUnauthenticated;
    }SIGNER_SIGNATURE_INFO, *PSIGNER_SIGNATURE_INFO;

    // dwAttrChoice should be one of the following:
    #define SIGNER_NO_ATTR          0x00
    #define SIGNER_AUTHCODE_ATTR    0x01

    typedef struct _SIGNER_PROVIDER_INFO
    {
        DWORD cbSize;
        LPCWSTR pwszProviderName;
        DWORD dwProviderType;
        DWORD dwKeySpec;
        DWORD dwPvkChoice;
        union
        {
            LPWSTR pwszPvkFileName;
            LPWSTR pwszKeyContainer;
        };
    }SIGNER_PROVIDER_INFO, *PSIGNER_PROVIDER_INFO;

    //dwPvkChoice should be one of the following:
    #define PVK_TYPE_FILE_NAME       0x01
    #define PVK_TYPE_KEYCONTAINER    0x02

    typedef struct _SIGNER_SPC_CHAIN_INFO
    {
        DWORD cbSize;
        LPCWSTR pwszSpcFile;
        DWORD dwCertPolicy;
        HCERTSTORE hCertStore;
    }SIGNER_SPC_CHAIN_INFO, *PSIGNER_SPC_CHAIN_INFO;

    typedef struct _SIGNER_CERT_STORE_INFO
    {
        DWORD cbSize;
        PCCERT_CONTEXT pSigningCert;
        DWORD dwCertPolicy;
        HCERTSTORE hCertStore;
    }SIGNER_CERT_STORE_INFO, *PSIGNER_CERT_STORE_INFO;

    //dwCertPolicy can be a combination of the following flags:
    #define SIGNER_CERT_POLICY_STORE            0x01
    #define SIGNER_CERT_POLICY_CHAIN            0x02
    #define SIGNER_CERT_POLICY_SPC              0x04
    #define SIGNER_CERT_POLICY_CHAIN_NO_ROOT    0x08

    typedef struct _SIGNER_CERT
    {
        DWORD cbSize;
        DWORD dwCertChoice;
        union
        {
            LPCWSTR pwszSpcFile;
            SIGNER_CERT_STORE_INFO *pCertStoreInfo;
            SIGNER_SPC_CHAIN_INFO *pSpcChainInfo;
        };
        HWND hwnd;
    }SIGNER_CERT, *PSIGNER_CERT;

    //dwCertChoice should be one of the following
    #define SIGNER_CERT_SPC_FILE     0x01
    #define SIGNER_CERT_STORE        0x02
    #define SIGNER_CERT_SPC_CHAIN    0x03

    typedef struct _SIGNER_CONTEXT
    {
        DWORD cbSize;
        DWORD cbBlob;
        BYTE *pbBlob;
    }SIGNER_CONTEXT, *PSIGNER_CONTEXT;

    typedef struct _SIGNER_SIGN_EX2_PARAMS
    {
        DWORD dwFlags;
        PSIGNER_SUBJECT_INFO pSubjectInfo;
        PSIGNER_CERT pSigningCert;
        PSIGNER_SIGNATURE_INFO pSignatureInfo;
        PSIGNER_PROVIDER_INFO pProviderInfo;
        DWORD dwTimestampFlags;
        PCSTR pszAlgorithmOid;
        PCWSTR pwszTimestampURL;
        PCRYPT_ATTRIBUTES pCryptAttrs;
        PVOID pSipData;
        PSIGNER_CONTEXT *pSignerContext;
        PVOID pCryptoPolicy;
        PVOID pReserved;
    } SIGNER_SIGN_EX2_PARAMS, *PSIGNER_SIGN_EX2_PARAMS;

    typedef struct _APPX_SIP_CLIENT_DATA
    {
        PSIGNER_SIGN_EX2_PARAMS pSignerParams;
        IUnknown* pAppxSipState;
    } APPX_SIP_CLIENT_DATA, *PAPPX_SIP_CLIENT_DATA;

    HRESULT WINAPI SignerSignEx2(
      _In_       DWORD                  dwFlags,
      _In_       SIGNER_SUBJECT_INFO    *pSubjectInfo,
      _In_       SIGNER_CERT            *pSignerCert,
      _In_       SIGNER_SIGNATURE_INFO  *pSignatureInfo,
      _In_opt_   SIGNER_PROVIDER_INFO   *pProviderInfo,
      _In_opt_   DWORD                  dwTimestampFlags,
      _In_opt_   PCSTR                  pszTimestampAlgorithmOid,
      _In_opt_   PCWSTR                 pwszHttpTimeStamp,
      _In_opt_   PCRYPT_ATTRIBUTES      psRequest,
      _In_opt_   PVOID                  pSipData,
      _Out_      SIGNER_CONTEXT         **ppSignerContext,
      _In_opt_   PCERT_STRONG_SIGN_PARA pCryptoPolicy,
      _Reserved_ PVOID                  pReserved
    );
}
