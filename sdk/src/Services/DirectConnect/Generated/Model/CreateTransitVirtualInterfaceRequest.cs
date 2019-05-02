/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the directconnect-2012-10-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DirectConnect.Model
{
    /// <summary>
    /// Container for the parameters to the CreateTransitVirtualInterface operation.
    /// Creates a transit virtual interface. A transit virtual interface is a VLAN that transports
    /// traffic from a Direct Connect gateway to one or more transit gateways. A transit virtual
    /// interface enables the connection of multiple VPCs attached to a transit gateway to
    /// a Direct Connect gateway.
    /// </summary>
    public partial class CreateTransitVirtualInterfaceRequest : AmazonDirectConnectRequest
    {
        private string _connectionId;
        private NewTransitVirtualInterface _newTransitVirtualInterface;

        /// <summary>
        /// Gets and sets the property ConnectionId. 
        /// <para>
        /// The ID of the connection.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ConnectionId
        {
            get { return this._connectionId; }
            set { this._connectionId = value; }
        }

        // Check to see if ConnectionId property is set
        internal bool IsSetConnectionId()
        {
            return this._connectionId != null;
        }

        /// <summary>
        /// Gets and sets the property NewTransitVirtualInterface. 
        /// <para>
        /// Information about the transit virtual interface.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public NewTransitVirtualInterface NewTransitVirtualInterface
        {
            get { return this._newTransitVirtualInterface; }
            set { this._newTransitVirtualInterface = value; }
        }

        // Check to see if NewTransitVirtualInterface property is set
        internal bool IsSetNewTransitVirtualInterface()
        {
            return this._newTransitVirtualInterface != null;
        }

    }
}