// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/http.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='HTTP_CREATE_REQUEST_QUEUE_PROPERTY_ID.xml' path='doc/member[@name="HTTP_CREATE_REQUEST_QUEUE_PROPERTY_ID"]/*' />
public enum HTTP_CREATE_REQUEST_QUEUE_PROPERTY_ID
{
    /// <include file='HTTP_CREATE_REQUEST_QUEUE_PROPERTY_ID.xml' path='doc/member[@name="HTTP_CREATE_REQUEST_QUEUE_PROPERTY_ID.CreateRequestQueueExternalIdProperty"]/*' />
    CreateRequestQueueExternalIdProperty = 1,

    /// <include file='HTTP_CREATE_REQUEST_QUEUE_PROPERTY_ID.xml' path='doc/member[@name="HTTP_CREATE_REQUEST_QUEUE_PROPERTY_ID.CreateRequestQueueMax"]/*' />
    CreateRequestQueueMax,
}
